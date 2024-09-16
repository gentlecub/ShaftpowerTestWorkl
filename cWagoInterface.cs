

using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Modbus.Device;
using Modbus.Data;


namespace ShaftpowerTest
{
    public class cWagoInterface
    {
        const double openDelayMs = 5000;            // Wartezeit für TCP Open
        const int tcpIpTimeout = 1000;            // Wartezeit für TCP Write/Read
        private Object thisLock = new Object();
        public string ipAdress = "192.168.1.1";
        IModbusMaster master;
        public bool hasError = true;
        private Thread workerThread;
        //private double lastOpenTime = 0;
        public bool doExitWorkerThread = false;
        UInt32 txCnt = 0;
        UInt32 rxCnt = 0;
        UInt32 errCnt = 0;

        public bool isOpen = false;

        public UInt32 txCount
        {
            get
            {
                lock (thisLock)
                {
                    return txCnt;
                }
            }
        }

        public UInt32 rxCount
        {
            get
            {
                lock (thisLock)
                {
                    return rxCnt;
                }
            }
        }

        public UInt32 errorCount
        {
            get
            {
                lock (thisLock)
                {
                    return errCnt;
                }
            }
        }

        public cWagoInterface()
        {
            ipAdress = "192.168.1.1";
        }

        ~cWagoInterface()
        {
            doExitWorkerThread = true;
        }

        public void RequestStop()
        {
            doExitWorkerThread = true;
            Thread.Sleep(50);
        }

        public void Open()
        {
            
                if (workerThread == null)
                {
                    workerThread = new Thread(DoWagoIdle);
                    workerThread.Start();
                }
            
        }

        public bool ReadDigital(ushort ioNr)
        {
            if (hasError)
                return false;
            lock (thisLock)
            {
                if (master != null)
                {
                    try
                    {

                        var val = master.ReadCoils(1, ioNr, 1);
                        hasError = false;
                        rxCnt++;
                        return val[0];
                    }
                    catch (Exception es)
                    {
                        string txt = es.ToString();
                        hasError = true;
                        errCnt++;
                        throw es;
                    }
                }
                return false;
            }
        }

        public bool ReadDigital(ushort ioNr, int anzahl, ref bool[] arr)
        {
            if (hasError)
                return false;
            lock (thisLock)
            {
                if (master != null)
                {
                    try
                    {

                        arr = master.ReadCoils(1, ioNr, (ushort)arr.Length);
                        hasError = false;
                        rxCnt++;
                        return true;
                    }
                    catch (Exception es)
                    {
                        string txt = es.ToString();
                        hasError = true;
                        errCnt++;
                        throw es;
                    }
                }
                return false;
            }
        }

        public void WriteDigital(ushort ioNr, bool val)
        {
            if (hasError)
                return;
            lock (thisLock)
            {
                if (master != null)
                {
                    try
                    {

                        master.WriteSingleCoil(1, ioNr, val);
                        hasError = false;
                        txCnt++;
                    }
                    catch (Exception es)
                    {
                        string txt = es.ToString();
                        hasError = true;
                        errCnt++;
                        throw es;
                    }
                }
            }
        }

        public void WriteDigital(ushort ioNr, bool[] vals)
        {
            if (hasError)
                return;
            lock (thisLock)
            {
                if (master != null)
                {
                    try
                    {

                        master.WriteMultipleCoils(1, ioNr, vals);
                        hasError = false;
                        txCnt++;
                    }

                    catch (Exception es)
                    {
                        string txt = es.ToString();
                        hasError = true;
                        errCnt++;
                        throw es;
                    }
                }
            }
        }

        public void Write4_20mA(ushort ioNr, double val, double minVal, double maxVal)
        {
            double outVal;

            if (val < minVal)
                val = minVal;
            if (val > maxVal)
                val = maxVal;
            outVal = 16 / (maxVal - minVal) * val + 4;
            Write4_20mA(ioNr, outVal);
        }

        public void Write4_20mA(ushort ioNr, double val)
        {
            if (hasError)
                return;
            lock (thisLock)
            {
                if (master != null)
                {
                    try
                    {
                        UInt16 iVal;

                        // 4  mA ==> iVal = 0
                        // 20 mA ==> iVal = 0x7FFF (32767);

                        iVal = (UInt16)((val - 4) / 16 * 32767.0);
                        if (iVal > 32767)
                            iVal = 32767;
                        master.WriteSingleRegister(1, ioNr, iVal);
                        hasError = false;
                        txCnt++;
                    }
                    catch (Exception es)
                    {
                        string txt = es.ToString();
                        hasError = true;
                        errCnt++;
                        throw es;
                    }
                }
            }
        }

        public void Write4_20mA(ushort ioNr, double[] vals)
        {
            if (hasError)
                return;
            lock (thisLock)
            {
                if (master != null)
                {
                    try
                    {
                        UInt16[] iVal = new UInt16[vals.Length];

                        // 4  mA ==> iVal = 0
                        // 20 mA ==> iVal = 0x7FFF (32767);
                        for (int k = 0; k < vals.Length; k++)
                        {
                            iVal[k] = (UInt16)((vals[k] - 4) / 16 * 32767.0);
                            if (iVal[k] > 32767)
                                iVal[k] = 32767;
                        }
                        master.WriteMultipleRegisters(1, ioNr, iVal);
                        hasError = false;
                        txCnt++;
                    }
                    catch (Exception es)
                    {
                        string txt = es.ToString();
                        hasError = true;
                        errCnt++;
                        throw es;
                    }
                }
            }
        }

        public double Read0_20mA(ushort ioNr)
        {
            if (hasError)
                return -1;
            lock (thisLock)
            {
                if (master != null)
                {
                    try
                    {
                        double dval;

                        // 0  mA ==> iVal = 0
                        // 20 mA ==> iVal = 0x7FF8 (32760);

                        var val = master.ReadHoldingRegisters(1, ioNr, 1);
                        dval = (double)val[0] * (20.0 / 32760.0);
                        hasError = false;
                        rxCnt++;
                        return dval;
                    }
                    catch (Exception es)
                    {
                        string txt = es.ToString();
                        hasError = true;
                        errCnt++;
                        throw es;
                    }
                }
                return -1;
            }
        }

        public bool Read0_20mA(ushort ioNr, int lenght, ref double[] vals)
        {
            if (hasError)
                return false;
            lock (thisLock)
            {
                if (master != null)
                {
                    try
                    {
                        // 0  mA ==> iVal = 0
                        // 20 mA ==> iVal = 0x7FF8 (32760);

                        ushort[] uVals = master.ReadHoldingRegisters(1, ioNr, (ushort)vals.Length);
                        for (int k = 0; k < vals.Length; k++)
                            vals[k] = (double)uVals[k] * (20.0 / 32760.0);

                        hasError = false;
                        rxCnt++;
                        return true;
                    }
                    catch (Exception es)
                    {
                        string txt = es.ToString();
                        hasError = true;
                        errCnt++;
                        throw es;
                    }
                }
                return false;
            }
        }

        public double Read4_20mA(ushort ioNr)
        {
            if (hasError)
                return -1;
            lock (thisLock)
            {
                if (master != null)
                {
                    try
                    {
                        double dval;

                        // 4  mA ==> iVal = 0
                        // 20 mA ==> iVal = 0x7FF8 (32760);

                        var val = master.ReadHoldingRegisters(1, ioNr, 1);
                        dval = (double)val[0] * (16.0 / 32760.0) + 4;
                        hasError = false;
                        rxCnt++;
                        return dval;
                    }
                    catch (Exception es)
                    {
                        string txt = es.ToString();
                        hasError = true;
                        errCnt++;
                        throw es;
                    }
                }
                return -1;
            }
        }

        void DoOpen()
        {
            try
            {
                //IPAddress address = new IPAddress(new byte[] { 192, 168, 1, 1 });
                //var masterClient = new TcpClient(address.ToString(), 502);
                var masterClient = new TcpClient();
                masterClient.SendTimeout = tcpIpTimeout;
                masterClient.ReceiveTimeout = tcpIpTimeout;
                //masterClient.Connect(address.ToString(), 502);
                masterClient.Connect(ipAdress, 502);
                master = ModbusIpMaster.CreateIp(masterClient);

                master.WriteSingleRegister(1, 0x1005, 0xAAAA); // Watchdog stoppen, falls dieser ausgelöst ist
                master.WriteSingleRegister(1, 0x1005, 0x5555); // 
#if DEBUG
#else
                master.WriteSingleRegister(1, 0x1000, 100);      // Watchdog Timeout Zeit in 100 ms
                //master.WriteSingleRegister(1, 0x1001, 1);       // Starte Watchdog
                master.WriteSingleRegister(1, 0x1001, 0x0010);       // Funktionscode 5 (Schreiben eines digitalen Ausgangs) Starte Watchdog
                master.WriteSingleRegister(1, 0x1009, 1);       // Socket schliessen bei WD-Timeout
#endif

                hasError = false;
                isOpen = true;
            }
            catch (Exception es)
            {
                string txt = es.ToString();
               
                hasError = true;
                errCnt++;
            }
        }

        void DoWagoIdle()
        {
            while (doExitWorkerThread == false)
            {
                lock (thisLock)
                {
                    if (hasError)
                    {
                        //if (cGlobalData.TimeDiff(ref lastOpenTime) >= openDelayMs)
                        DoOpen();
                    }
                }
                System.Threading.Thread.Sleep((int)openDelayMs);
            }
        }
    }
}

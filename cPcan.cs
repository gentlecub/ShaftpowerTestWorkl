using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using Peak.Can.Light;
using System.Diagnostics;

namespace ShaftpowerTest
{
    class cPcan
    {
        private HardwareType ActiveHardware = (HardwareType)HardwareType.USB_1CH;

        public bool Init()
        {
            CANResult Res;

            Res = PCANLight.Init(HardwareType.USB_1CH,
                            (Baudrates)Baudrates.BAUD_50K,
                            FramesType.INIT_TYPE_EX);

            if (Res == CANResult.ERR_OK)
            {
                ActiveHardware = (HardwareType)HardwareType.USB_1CH;
                return (true);
            }
            else
            {
                Res = PCANLight.Init(HardwareType.PCI_1CH,
                                (Baudrates)Baudrates.BAUD_50K,
                            FramesType.INIT_TYPE_EX);
                if (Res == CANResult.ERR_OK)
                {
                    ActiveHardware = (HardwareType)HardwareType.PCI_1CH;
                    return (true);
                }
            }
            return (false);
        }

        public bool Transmit(UInt32 ID, byte Len, byte[] Data)
        {
            TCLightMsg MsgToSend;
            CANResult Res;

            MsgToSend = new TCLightMsg();

            MsgToSend.ID = ID;
            MsgToSend.Len = Len;
            MsgToSend.MsgType = MsgTypes.MSGTYPE_EXTENDED;
            for (int i = 0; i < MsgToSend.Len; i++)
                MsgToSend.Data[i] = Data[i];

            Res = PCANLight.Write(ActiveHardware, MsgToSend);

            if (Res == CANResult.ERR_OK)
                return (true);
            else
                return (false);
        } 

        public TCLightMsg Receive()
        {
            //TCLightMsg MsgToRecv;
            //CANResult Res;

            //while (true)
            //{ 
            //    Res = PCANLight.Read(ActiveHardware, out MsgToRecv);
            //    if (Res != CANResult.ERR_OK)
            //        return null;
            //    if ((MsgToRecv.ID >= 0x00100000) & (MsgToRecv.MsgType == MsgTypes.MSGTYPE_EXTENDED))
            //    {
            //        // TCFI Message oder neueres Modul
            //        Program.frm1.ScannTCFI(MsgToRecv);
            //    }
            //    else
            //        return (MsgToRecv);
            //}
            return null;
        } 
    }
}

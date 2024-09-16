using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Peak.Can.Light;
using System.Globalization;
using System.Xml.Serialization;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace ShaftpowerTest
{
    public partial class Form1 : Form
    {
        cPcan pcan = new cPcan();
        string paraFilename = "";
        cWagoInterface wago = new cWagoInterface();

        static string output = string.Empty;

        private string Version()
        {
            return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        public Form1()
        {
            try
            {
                InitializeComponent();
                this.Load += new EventHandler(Form1_Load);

                wago.Open();

                Text = "LEMAG SHAFTPOWER/SPEAT test V" + Version();

                dataGridViewTcfiList.RowCount = Convert.ToUInt16(textBoxNrOfTcfi.Text);

                serialNmeaOutput.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);

                int y = 0;
                dataGridViewTcfiList.Rows[y++].Cells[0].Value = "1 Main Engine";
                dataGridViewTcfiList.Rows[y++].Cells[0].Value = "2 Aux Engine ";
                dataGridViewTcfiList.Rows[y++].Cells[0].Value = "3 Boiler     ";

                int val = 1000;
                for (int i = 0; i < dataGridViewTcfiList.RowCount; i++)
                {
                    dataGridViewTcfiList.Rows[i].Cells[1].Value = val;          // Frequenz In
                    dataGridViewTcfiList.Rows[i].Cells[3].Value = val - 50;      // Frequenz out
                    val -= 100;
                }
                val = 50;
                for (int i = 0; i < dataGridViewTcfiList.RowCount; i++)
                {
                    dataGridViewTcfiList.Rows[i].Cells[2].Value = val;
                    dataGridViewTcfiList.Rows[i].Cells[4].Value = val + 1;
                    val += 10;
                }

                dataGridViewShaft.RowCount = 10;
                val = 900;
                /*for (int i = 0; i < dataGridViewShaft.RowCount; i++)
                {
                    dataGridViewShaft.Rows[i].Cells[0].Value = "";           // comment
                    dataGridViewShaft.Rows[i].Cells[1].Value = val;           // Sensor 1
                    dataGridViewShaft.Rows[i].Cells[2].Value = 2200 + val;    // Sensor 3
                    dataGridViewShaft.Rows[i].Cells[3].Value = 90 + i*10;     // Speed
                    dataGridViewShaft.Rows[i].Cells[4].Value = 1;   // Clockwise
                    val -= 100;
                }*/

                dataGridViewShaft.Rows[0].Cells[0].Value = "Torque alarm 5%";           // comment
                dataGridViewShaft.Rows[0].Cells[1].Value = 1;           // Sensor 1
                dataGridViewShaft.Rows[0].Cells[2].Value = 4000;    // Sensor 3
                dataGridViewShaft.Rows[0].Cells[3].Value = 75;     // Speed
                dataGridViewShaft.Rows[0].Cells[4].Value = 1;

                dataGridViewShaft.Rows[1].Cells[0].Value = "Torque warning 10%";           // comment 
                dataGridViewShaft.Rows[1].Cells[1].Value = 100;           // comment
                dataGridViewShaft.Rows[1].Cells[2].Value = 2300;    // Sensor 3
                dataGridViewShaft.Rows[1].Cells[3].Value = 80;    // Speed
                dataGridViewShaft.Rows[1].Cells[4].Value = 1;

                dataGridViewShaft.Rows[2].Cells[0].Value = "RPM alarm 5%";           // comment
                dataGridViewShaft.Rows[2].Cells[1].Value = 400;           // Sensor 1
                dataGridViewShaft.Rows[2].Cells[2].Value = 2600;    // Sensor 3
                dataGridViewShaft.Rows[2].Cells[3].Value = 103;    // Speed
                dataGridViewShaft.Rows[2].Cells[4].Value = 1;

                dataGridViewShaft.Rows[3].Cells[0].Value = "RPM warning 10%";           // comment
                dataGridViewShaft.Rows[3].Cells[1].Value = 500;           // Sensor 1
                dataGridViewShaft.Rows[3].Cells[2].Value = 2700;    // Sensor 3
                dataGridViewShaft.Rows[3].Cells[3].Value = 98;    // Speed
                dataGridViewShaft.Rows[3].Cells[4].Value = 1;

                dataGridViewShaft.Rows[4].Cells[0].Value = "Power alarm 5%";           // comment
                dataGridViewShaft.Rows[4].Cells[1].Value = 510;           // Sensor 1
                dataGridViewShaft.Rows[4].Cells[2].Value = 3400;    // Sensor 3
                dataGridViewShaft.Rows[4].Cells[3].Value = 87;    // Speed
                dataGridViewShaft.Rows[4].Cells[4].Value = 1;

                dataGridViewShaft.Rows[5].Cells[0].Value = "Power warning 10%";           // comment
                dataGridViewShaft.Rows[5].Cells[1].Value = 540;           // Sensor 1
                dataGridViewShaft.Rows[5].Cells[2].Value = 3300;    // Sensor 3
                dataGridViewShaft.Rows[5].Cells[3].Value = 87;    // Speed
                dataGridViewShaft.Rows[5].Cells[4].Value = 1;

                dataGridViewShaft.Rows[6].Cells[0].Value = "Overload alarm";           // comment
                dataGridViewShaft.Rows[6].Cells[1].Value = 700;           // Sensor 1
                dataGridViewShaft.Rows[6].Cells[2].Value = 3300;    // Sensor 3
                dataGridViewShaft.Rows[6].Cells[3].Value = 80;    // Speed
                dataGridViewShaft.Rows[6].Cells[4].Value = 1;

                dataGridViewShaft.Rows[7].Cells[0].Value = "Overload warning";           // comment
                dataGridViewShaft.Rows[7].Cells[1].Value = 700;           // Sensor 1
                dataGridViewShaft.Rows[7].Cells[2].Value = 3300;    // Sensor 3
                dataGridViewShaft.Rows[7].Cells[3].Value = 88;    // Speed
                dataGridViewShaft.Rows[7].Cells[4].Value = 1;

                dataGridViewShaft.Rows[8].Cells[0].Value = "Overspeed";           // comment
                dataGridViewShaft.Rows[8].Cells[1].Value = 800;           // Sensor 1
                dataGridViewShaft.Rows[8].Cells[2].Value = 3200;    // Sensor 3
                dataGridViewShaft.Rows[8].Cells[3].Value = 121;    // Speed
                dataGridViewShaft.Rows[8].Cells[4].Value = 1;

                dataGridViewShaft.Rows[9].Cells[0].Value = "Normal";           // comment
                dataGridViewShaft.Rows[9].Cells[1].Value = 800;           // Sensor 1
                dataGridViewShaft.Rows[9].Cells[2].Value = 3200;    // Sensor 3
                dataGridViewShaft.Rows[9].Cells[3].Value = 90;    // Speed
                dataGridViewShaft.Rows[9].Cells[4].Value = 1;
 

                if (pcan.Init() == false)
                {
                    Program.eventlog.EventLog("Error: PCAN init");
                }
                else
                {
                    Program.eventlog.EventLog("PCAN init: OK");
                    timerCanTx.Enabled = true;
                }
                comboBoxComPortsNMEA.Items.Clear();
                foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
                {
                    comboBoxComPortsNMEA.Items.Add(s);
                    comboBoxShaftpowerPort.Items.Add(s);
                    comboBoxNmeaOutput.Items.Add(s);
                    
                }
                //comboBoxComPortsNMEA.Text = "com3";
                //comboBoxShaftpowerPort.Text = "com4";
                //toolStripStatusLabelState.Text = "";
                toolStripStatusLabelFileName.Text = "";
                toolStripStatusLabelError.Text = "";

                string configDir = Path.Combine(Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Chris-Marine"), "Shaftpower.Test"), "config");
                string defaultFile = Path.Combine(configDir, "ShaftpowerTest.xml");

                if (File.Exists(defaultFile))
                {
                    paraFilename = defaultFile;
                    DoOpen(false);
                }

            }
            catch (Exception ex)
            {
                Program.eventlog.EventLog(ex);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Llamar al método para manejar el estado del CheckBox al cargar el formulario
            checkBoxSpeedlog_CheckedChanged(checkBoxSpeedlog, EventArgs.Empty);
            checkBoxGPS_CheckedChanged(checkBoxGPS, EventArgs.Empty);
            
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        void ToArray(float inVal, ref byte[] bt, UInt16 offset)
        {
            byte[] byteVal = new byte[4];

            byteVal = System.BitConverter.GetBytes(inVal);
            for (int i = 0; i < byteVal.Length; i++)
            {
                bt[offset + i] = byteVal[i];
            }
        }

        void ToArray(UInt16 inVal, ref byte[] bt, UInt16 offset)
        {
            byte[] byteVal = new byte[2];

            byteVal = System.BitConverter.GetBytes(inVal);
            for (int i = 0; i < byteVal.Length; i++)
            {
                bt[offset + i] = byteVal[i];
            }
        }

        static int nextRow = 0;
        static int nextSub = 0;
        private void timerCanTx_Tick(object sender, EventArgs e)
        {
            if (checkBoxTCFIenabled.Checked == false)
                return;

            try
            {
                UInt32 ID = (UInt32)(nextRow+1);
                ID = (ID << 20) | (((UInt32) (nextSub + 1))& 0x000FFFFF)  ;//0x00010001;
                byte[] Data = new byte[8];
                //switch (nextRow)
                //{
                //    case 0: dataGridViewTcfiList.Rows[nextRow].Cells[1].Value = Convert.ToSingle(dataGridViewTcfiList.Rows[nextRow].Cells[3].Value) * 
                //                                                                ((float)zoomTrackBarControl1.Value / 10 + 1); break;
                //    case 1: dataGridViewTcfiList.Rows[nextRow].Cells[1].Value = Convert.ToSingle(dataGridViewTcfiList.Rows[nextRow].Cells[3].Value) *
                //                                                                ((float)zoomTrackBarControl2.Value / 10 + 1); break;
                //    case 2: dataGridViewTcfiList.Rows[nextRow].Cells[1].Value = Convert.ToSingle(dataGridViewTcfiList.Rows[nextRow].Cells[3].Value) *
                //                                                                ((float)zoomTrackBarControl3.Value / 10 + 1); break;
                //}
                switch (nextSub++)
                {
                    case 0:
                        {
                            // In 1. Telegramm
                            float frIn = Convert.ToSingle(dataGridViewTcfiList.Rows[nextRow].Cells[1].Value);
                            UInt16 TempIn = Convert.ToUInt16(dataGridViewTcfiList.Rows[nextRow].Cells[2].Value);
                            TempIn *= 100;
                            ToArray(frIn, ref Data, 0);
                            ToArray(TempIn, ref Data, 4);
                        }
                        break;
                    case 1:
                        {
                            // In 2. Telegramm
                            UInt32 pulse = 0;
                            UInt16 fehlpulse = 0;
                            UInt16 rueckPulse = 0;
                            ToArray(pulse, ref Data, 0);
                            ToArray(fehlpulse, ref Data, 4);
                            ToArray(rueckPulse, ref Data, 6);
                        }
                        break;
                    case 2:
                        {
                            // Out 1. Telegramm
                            float frOut = Convert.ToSingle(dataGridViewTcfiList.Rows[nextRow].Cells[3].Value);
                            UInt16 TempOut = Convert.ToUInt16(dataGridViewTcfiList.Rows[nextRow].Cells[4].Value);
                            TempOut *= 100;
                            ToArray(frOut, ref Data, 0);
                            ToArray(TempOut, ref Data, 4);
                        }
                        break;
                    case 3:
                        {
                            // Out 2. Telegramm
                            UInt32 pulse = 0;
                            UInt16 fehlpulse = 0;
                            UInt16 rueckPulse = 0;
                            ToArray(pulse, ref Data, 0);
                            ToArray(fehlpulse, ref Data, 4);
                            ToArray(rueckPulse, ref Data, 6);
                            nextSub = 0;
                            nextRow++;
                            if (nextRow >= dataGridViewTcfiList.RowCount)
                                nextRow = 0;
                        }
                        break;
                }
                pcan.Transmit(ID, 8, Data);
            }
            catch (Exception ex)
            {
                Program.eventlog.EventLog(ex);
            }
        }

        private void trackBarControl1_EditValueChanged(object sender, EventArgs e)
        {
            dataGridViewTcfiList.Rows[0].Cells[3].Value = Convert.ToSingle(dataGridViewTcfiList.Rows[0].Cells[1].Value) * 
                                                                (1-(float)zoomTrackBarControl1.Value / 10 );
        }

        private void zoomTrackBarControl2_EditValueChanged(object sender, EventArgs e)
        {
            dataGridViewTcfiList.Rows[1].Cells[3].Value = Convert.ToSingle(dataGridViewTcfiList.Rows[1].Cells[1].Value) *
                                                                (1-(float)zoomTrackBarControl2.Value / 10);
        }

        private void zoomTrackBarControl3_EditValueChanged(object sender, EventArgs e)
        {
            dataGridViewTcfiList.Rows[2].Cells[3].Value = Convert.ToSingle(dataGridViewTcfiList.Rows[2].Cells[1].Value) *
                                                                (1-(float)zoomTrackBarControl3.Value / 10);
        }

        static string lastNMEAPort = "";
        private void comboBoxComPortsNMEA_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (serialPortNMEA.IsOpen)
                    serialPortNMEA.Close();
                serialPortNMEA.PortName = comboBoxComPortsNMEA.SelectedItem.ToString();
                serialPortNMEA.BaudRate = 4800;
                serialPortNMEA.Open();
                lastNMEAPort = serialPortNMEA.PortName;
                timerNMEA.Enabled = true;
                toolStripStatusLabelError.Text = "";

            }
            catch(Exception ex)
            {
                if (lastNMEAPort.Length>0)
                { 
                    serialPortNMEA.PortName = lastNMEAPort;
                    comboBoxComPortsNMEA.SelectedItem = lastNMEAPort;
                }
                //MessageBox.Show(ex.ToString(),"Error", MessageBoxButtons.OK);
                toolStripStatusLabelError.Text = ex.Message;
                Program.eventlog.EventLog(ex);
            }
        }

        byte Checksum(string nmeaLine)
        {
            // checksum!!!
            // Optional kann zusätzlich eine durch ein „*“ abgetrennte hexadezimale Prüfzahl angehängt werden. 
            // Diese wird durch die XOR-Verknüpfung der ASCII-Werte aller Zeichen zwischen dem $ und dem * errechnet.
            // (ohne $ undCgecj ohne '*')
            // Der BCC wird in "HEX" übertragen

            byte bcc = 0;
            //nmeaLine += "*";
            for (int k = 1; k < nmeaLine.Length; k++)
                bcc ^= (byte)nmeaLine[k];
            return bcc;
        }


        



        
        static bool toggle = false;
        static int nextindex = 0;
        

        private Dictionary<CheckBox, bool> checkBoxTextAdded = new Dictionary<CheckBox, bool>();

        private void HandleCheckBox(CheckBox checkBox, TextBox targetTextBox, string linkedTextBox)
        {
            // Inicializar el estado en el diccionario si no está presente
            if (!checkBoxTextAdded.ContainsKey(checkBox))
            {
                checkBoxTextAdded[checkBox] = false;
            }

            string textToAdd = linkedTextBox.TrimEnd('\r', '\n');

            // Verificar si el CheckBox está marcado y si el texto no ha sido agregado aún
            if (checkBox.Checked && !checkBoxTextAdded[checkBox])
            {
                // Llamar al método para agregar el texto
                CheckBox_CheckedChanged(checkBox, EventArgs.Empty, targetTextBox, linkedTextBox);

                // Marcar que el texto fue agregado
                checkBoxTextAdded[checkBox] = true;
            }
     
            // Si el CheckBox fue desmarcado, restablecer el estado y eliminar el texto si es necesario
            else if (!checkBox.Checked && checkBoxTextAdded[checkBox])
            {
                // Llamar al método para eliminar el texto
                CheckBox_CheckedChanged(checkBox, EventArgs.Empty, targetTextBox, linkedTextBox);

                // Marcar que el texto fue eliminado
                checkBoxTextAdded[checkBox] = false;
            }
        }
        

        public string ProcessNmeaLine(string nmeaLine)
        {
  
            string processedLine = nmeaLine.TrimStart('\n', '\r');

           
            processedLine += "*" + Checksum(processedLine).ToString("X2");
            processedLine += "\r\n";

            // Devolver la línea procesada
            return processedLine;
        }

        private void UpdateArrayWithTimeAtPosition(string[] arr, int position)
        {
            // Verificar que la posición es válida dentro del arreglo
            if (position >= 0 && position < arr.Length)
            {
                // Asignar la hora actual en formato "HHmmss.ff" a la posición dada
                arr[position] = DateTime.UtcNow.ToString("HHmmss.ff");
            }
            else
            {
                Console.WriteLine("Posición fuera de los límites del arreglo.");
            }
        }
        private void UpdateArrayWithDateAtPosition(string[] arr, int position)
        {
            // Verificar que la posición es válida dentro del arreglo
            if (position >= 0 && position < arr.Length)
            {
                // Asignar la fecha actual en formato "ddMMyy" a la posición dada
                arr[position] = DateTime.UtcNow.ToString("ddMMyy");
            }
            else
            {
                Console.WriteLine("Posición fuera de los límites del arreglo.");
            }
        }

        private void UpdateArrayWithHousAtPosition(string[] arr, int position)
        {
            if (position >= 0 && position < arr.Length)
            {
                TimeZoneInfo localTimeZone = TimeZoneInfo.Local;
                DateTime utcNow = DateTime.UtcNow;
                DateTime localNow = TimeZoneInfo.ConvertTimeFromUtc(utcNow, localTimeZone);
                int hour = localNow.Hour;
                arr[position] = hour.ToString();
            }
            else
            {
                Console.WriteLine("Posición fuera de los límites del arreglo.");
            }
        
    }
        private void UpdateArrayWithMinutesAtPosition(string[] arr, int position)
        {
            if (position >= 0 && position < arr.Length)
            {
                TimeZoneInfo localTimeZone = TimeZoneInfo.Local;
                DateTime utcNow = DateTime.UtcNow;
                DateTime localNow = TimeZoneInfo.ConvertTimeFromUtc(utcNow, localTimeZone);
                int minute = localNow.Minute;
                arr[position] = minute.ToString();
            }
            else
            {
                Console.WriteLine("Posición fuera de los límites del arreglo.");
            }
        }

        private string GetNmeaMessageType(string nmeaSentence)
        {
            string[] parts = nmeaSentence.Split(',');
            if(parts.Length > 0 && parts[0].Length >= 3)
            {
               return parts[0].Substring(3);
            }
            return string.Empty;
        }
        string linesFromText;
        private void timerNMEA_Tick(object sender, EventArgs e)
        {
            string[] nmeaString;
            string[] nmeaStringaux;
           
            // Obtener todas las líneas del TextBox (separadas por nueva línea)
            linesFromText = textBox4.Text.TrimStart('\r', '\n'); // textBoxInput es el nombre de tu TextBox
            string[] linesFromTextBox = linesFromText.Split('\r');

            for (int i = 0; i < linesFromTextBox.Length; i++)
            {   
                string messageType = GetNmeaMessageType(linesFromTextBox[i].TrimStart('\n', '\r'));

                switch (messageType)
                {
                    case "VHW":
                        string processedLine = linesFromTextBox[i].Replace("\n", "").Replace("\r", "");

                        // Calcula y agrega el checksum
                        processedLine += "*" + Checksum(processedLine).ToString("X2");
                        processedLine += "\r\n";

                        // Actualiza la línea procesada en el array
                        linesFromTextBox[i] = processedLine;
                        break;
                    case "RMC":
                        string[] tempArr = linesFromTextBox[i].Split(',');

                        UpdateArrayWithTimeAtPosition(tempArr, 1);

                        UpdateArrayWithDateAtPosition(tempArr, 9);

                        string concatenatedString = String.Join(",", tempArr).TrimStart('\n', '\r');
                        concatenatedString += "*" + Checksum(concatenatedString).ToString("X2");
                        linesFromTextBox[i] += "\r\n";

                        linesFromTextBox[i] = concatenatedString;
                        break;
                    case "ZDA":
                        string[] tempZda = linesFromTextBox[i].Split(',');
                        UpdateArrayWithTimeAtPosition(tempZda, 1);
                        UpdateArrayWithHousAtPosition(tempZda, 5);
                        UpdateArrayWithMinutesAtPosition(tempZda, 6);

                        string concatenatedStringZda = String.Join(",", tempZda).TrimStart('\n', '\r');
                        concatenatedStringZda += "*" + Checksum(concatenatedStringZda).ToString("X2");
                        linesFromTextBox[i] += "\r\n";
                        linesFromTextBox[i] = concatenatedStringZda;
                        break;
                    case "GGA":
                        string[] tempGga = linesFromTextBox[i].Split(',');
                        UpdateArrayWithTimeAtPosition(tempGga, 1);
                        string concatenatedStringGga = String.Join(",", tempGga).TrimStart('\n', '\r');
                        concatenatedStringGga += "*" + Checksum(concatenatedStringGga).ToString("X2");
                        linesFromTextBox[i] += "\r\n";
                        linesFromTextBox[i] = concatenatedStringGga;
                        break;
                    case "GLL":
                        string[] tempGll = linesFromTextBox[i].Split(',');
                        UpdateArrayWithTimeAtPosition(tempGll, 5);
                        string concatenatedStringGll = String.Join(",", tempGll).TrimStart('\n', '\r');
                        concatenatedStringGll += "*" + Checksum(concatenatedStringGll).ToString("X2");
                        linesFromTextBox[i] += "\r\n";
                        linesFromTextBox[i] = concatenatedStringGll;
                        break;
                    case "VBW":
                        string concatenatedStringVbw = ProcessNmeaLine(linesFromTextBox[i]);
                        linesFromTextBox[i] = concatenatedStringVbw;
                        break;
                    case "VTG":
                        string concatenatedStringVtg = ProcessNmeaLine(linesFromTextBox[i]);
                        linesFromTextBox[i] = concatenatedStringVtg;
                        break;
                    case "OSD":
                        string concatenatedStringOsd = ProcessNmeaLine(linesFromTextBox[i]);
                        linesFromTextBox[i] = concatenatedStringOsd;
                        break;
                    case "HDG":
                        string concatenatedStringHdg = ProcessNmeaLine(linesFromTextBox[i]);
                        linesFromTextBox[i] = concatenatedStringHdg;
                        break;
                    case "DBK":
                        string concatenatedStringDbk = ProcessNmeaLine(linesFromTextBox[i]);
                        linesFromTextBox[i] = concatenatedStringDbk;
                        break;
                    case "DPT":
                        string concatenatedStringDpt = ProcessNmeaLine(linesFromTextBox[i]);
                        linesFromTextBox[i] = concatenatedStringDpt;
                        break;
                    case "MWV":
                        string concatenatedStringMwv = ProcessNmeaLine(linesFromTextBox[i]);
                        linesFromTextBox[i] = concatenatedStringMwv;
                        break;
                    case "RSA":
                        string concatenatedStringRsa = ProcessNmeaLine(linesFromTextBox[i]);
                        linesFromTextBox[i] = concatenatedStringRsa;
                        break;
                }

            }

            // Ejemplo de método ProcessNmeaString para verificar si el identificador coincide
            
            // Crear el arreglo nmeaString con el mismo tamaño que las líneas del TextBox
            nmeaStringaux = new string[linesFromTextBox.Length];

            // Recorrer cada línea del TextBox y procesarla
            for (int i = 0; i < linesFromTextBox.Length; i++)
            {
                string processedLine = linesFromTextBox[i].Replace("\n", "").Replace("\r", ""); // Quitar los \r y \n
                processedLine += "\r\n"; // Agregar \r\n al final de la línea procesada

                // Asignar la línea procesada al arreglo nmeaStringaux
                nmeaStringaux[i] = processedLine;
            }
            if (nmeaStringaux.Length == 0)
                return;
            if (nextindex >= nmeaStringaux.Length)
                nextindex = 0;
            try
            {
                if (serialPortNMEA.IsOpen)
                {
                    //string str = nmeaString[nextindex] + "*" + Checksum(nmeaString[nextindex]);
                    serialPortNMEA.Write(nmeaStringaux[nextindex]);
                    nextindex++;
                }

            }
            catch (Exception ex)
            {
                Program.eventlog.EventLog(ex);
            }
        }

        static string lastShaftpowerPort = "";
        private void comboBoxShaftpowerPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                if (serialPortShaftpower.IsOpen)
                    serialPortShaftpower.Close();
                serialPortShaftpower.PortName = comboBoxShaftpowerPort.SelectedItem.ToString();
                serialPortShaftpower.Open();
                lastShaftpowerPort = serialPortShaftpower.PortName;
                timerShaftpower.Enabled = true;
                toolStripStatusLabelError.Text = "";
            }
            catch(Exception ex)
            {
                if (lastShaftpowerPort.Length > 0)
                {
                    serialPortShaftpower.PortName = lastShaftpowerPort;
                    comboBoxShaftpowerPort.SelectedItem = lastShaftpowerPort;
                }
                //MessageBox.Show(ex.ToString(),"Error", MessageBoxButtons.OK);
                toolStripStatusLabelError.Text = ex.Message;
                Program.eventlog.EventLog(ex);
            }

        }
        double scale = 120/16; // last number max rpm

        private void timerShaftpower_Tick(object sender, EventArgs e)
        {
            //    Telegramaufbau:
            //
            //    STX
            //    Betriebsart
            //        '1' ode '0'
            //    Drehrichtung 
            //        'r' oder 'l'
            //    Drehzahl
            //        Format: 0Xmmmm, z.B. 0X1234
            //    Anzahl Messwerte
            //        Format: 0Xmmmm, z.B. 0X1234
            //    Messwert 1
            //        Format: 0Xmmmm, z.B. 0X1234
            //    Messwert 2
            //        Format: 0Xmmmm, z.B. 0X1234
            //    ETX

            if (!checkBoxShaftpower.Checked)
            {
                return;
            }

            if (checkBoxEEXISim.Checked)
            {
                textBoxSpeed.ReadOnly = true;
                
                if (wago.isOpen == false)
                {
                    wago.Open();
                }

                if(wago.isOpen == true)
                {
                    double angEexiInput=0;

                    try
                    {
                        angEexiInput = wago.Read4_20mA(0);

                    }
                    catch (Exception ex)
                    {
                        Program.eventlog.EventLog(ex);
                    }
                
                                       
                    double angRpm =   scale * (angEexiInput - 4);

                   textBoxSpeed.Text = Convert.ToString(Convert.ToInt32(angRpm));
                   //textBox1.Text = Convert.ToString(angEexiInput);
                   //textBox2.Text = Convert.ToString(angRpm);


                    // string asd   =angRpm.ToString("###");
                    //    textBoxSpeed.Text = angRpm.ToString("###");

                }        
            }
            else
            {
               textBoxSpeed.ReadOnly = false;
            }
               

            string nmea;

            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            provider.NumberGroupSeparator = ".";

            string drehrichtung = checkBoxClockwise.Checked ? "r" : "l";
            double speed = Convert.ToDouble(textBoxSpeed.Text, provider) * 100.0;
            Int32 sens1 = Convert.ToInt32(textBoxSensor1.Text);
            Int32 sens3 = Convert.ToInt32(textBoxSensor3.Text);

            if (speed == 0)
                nmea = '\x02' + "0" + drehrichtung + "0x" + String.Format("{0:X04}", Convert.ToInt32(speed)) + "0x" + String.Format("{0:X04}", Convert.ToInt32("30")) +
                     "0x" + String.Format("{0:X04}", sens1) + "0x" + String.Format("{0:X04}", sens3) + '\x03';
            else
                nmea = '\x02' + "1" + drehrichtung + "0x" + String.Format("{0:X04}", Convert.ToInt32(speed)) + "0x" + String.Format("{0:X04}", Convert.ToInt32("30")) +
                         "0x" + String.Format("{0:X04}", sens1) + "0x" + String.Format("{0:X04}", sens3) + '\x03';


            // faulty if statement to send scrap
            //r10x23280x001E0x03200x0C8
            if (checkBoxFaultyMsg.Checked)
            {
                nmea = '\x02' + "1" + "fwd" + '\x03';
            }

            try
            {
                if (serialPortShaftpower.IsOpen)
                {
                    serialPortShaftpower.Write(nmea);
                }

            }
            catch (Exception ex)
            {
                Program.eventlog.EventLog(ex);
            }
        }

        private string InterpretationOf(string receivedCommand)
        {
            string interpretationToReturn = string.Empty;
            string[] rxCP = receivedCommand.Split(',');

            for (int ix = 0; ix < rxCP.Length; ix++) { if (rxCP[ix].Equals(string.Empty)) rxCP[ix] = "n/a"; }

            if (receivedCommand.Length > 5)
            {
                switch (receivedCommand.Substring(0, 5))
                {
                    case "SNLSP":

                        interpretationToReturn = $@"Power, Shaft1 (rpm={rxCP[1]}, torque={rxCP[2]}, power={rxCP[3]}) Shaft2 (rpm={rxCP[4]}, torque={rxCP[5]}, power={rxCP[6]})";
                        break;

                    case "SNLSL":

                        interpretationToReturn = $@"Shaftpower ShaPoLi, Shaft1 (rpm={rxCP[1]}, torque={rxCP[2]}, power={rxCP[3]}) Shaft2 (rpm={rxCP[4]}, torque={rxCP[5]}, power={rxCP[6]})";
                        break;

                    case "SNLSS":

                        interpretationToReturn = $@"Status, Warning={rxCP[1]}, Error={rxCP[2]}, System Error={rxCP[3]}";

                        break;

                    case "SNLM1":
                    case "SNLM2":

                        interpretationToReturn = $@"Main engine ({receivedCommand.Substring(4,1)}) Data, ";
                        for (int fuelIx = 1; fuelIx < 5; fuelIx++)
                        {
                            interpretationToReturn += $@"Fuel{fuelIx} (temp={rxCP[(fuelIx - 1) * 3 + 1]}, dens={rxCP[(fuelIx - 1) * 3 + 2]}, cons={rxCP[(fuelIx - 1) * 3 + 3]}), ";
                        }
                        interpretationToReturn += $@"SFOC={rxCP[13]}";
                        break;

                    case "SNLA1":
                    case "SNLA2":
                    case "SNLA3":
                    case "SNLA4":

                        interpretationToReturn = $@"Aux engine ({receivedCommand.Substring(4, 1)}) Data, ";
                        for (int fuelIx = 1; fuelIx < 5; fuelIx++)
                        {
                            interpretationToReturn += $@"Fuel{fuelIx} (temp={rxCP[(fuelIx - 1) * 3 + 1]}, dens={rxCP[(fuelIx - 1) * 3 + 2]}, cons={rxCP[(fuelIx - 1) * 3 + 3]}), ";
                        }
                        break;

                    case "SNLB1":
                    case "SNLB2":
                    case "SNLB3":

                        interpretationToReturn = $@"Boiler ({receivedCommand.Substring(4, 1)}) Data, ";
                        for (int fuelIx = 1; fuelIx < 5; fuelIx++)
                        {
                            interpretationToReturn += $@"Fuel{fuelIx} (temp={rxCP[(fuelIx - 1) * 3 + 1]}, dens={rxCP[(fuelIx - 1) * 3 + 2]}, cons={rxCP[(fuelIx - 1) * 3 + 3]}), ";
                        }
                        break;
                    case "SNLEN":

                        interpretationToReturn = $@"Energy Consumption, Energy(kWh{rxCP[1]})";
                        break;

                    case "SNLRO":

                        interpretationToReturn = $@"Shaft Revolutions, Shaft1 (revs={rxCP[1]}) Shaft2 (rpm{rxCP[2]})";
                        //interpretationToReturn = $@"Number Of Shaft Revolutions Starboard, Revs(rpm){rxCP[13]})";
                        break;

                    default:

                        interpretationToReturn = "Unknown command";
                        break;

                }
            }
            else
            {
                interpretationToReturn = "Unknown command";
            }
            return interpretationToReturn;
        }
        
        
        private void timerNmeaOutput_Tick(object sender, EventArgs e)
        {
            
            if (!checkBox1.Checked)return;

            if (checkBoxSendingMsg.Checked)
            {
                //$SNLSP,075.0,1481,013961,,,,*52                protocol 1 msg
                //\x02$SNLSP,090.0,1481,013961,,,*75\x03
                serialNmeaOutput.Write("$SNLSP,090.0,1481,013961,,,*75\r\n");
                    return; 
            }
            if (checkBoxSendMsg2.Checked)
            {
                serialNmeaOutput.Write("$SNLSP,075.0,1481,013961,,,,*52\r\n");
                return;
            }

            string[] receivedCommands = output.Split('$');

            for (int cIx = 0; cIx < receivedCommands.Length; cIx++)
            {
                if (receivedCommands[cIx].Length > 0)
                {
                    string timeStamp = DateTime.Now.ToString("yyMMdd HH:mm:ss.ff");
                    textBoxNemaOutput.AppendText(string.Format("{0}: {1}{2}", timeStamp, receivedCommands[cIx], Environment.NewLine));

                    string[] outputsRe = output.Split(',');
                    try
                    {
                        textBoxRepresentation.AppendText(string.Format("{0}: {1}{2}", timeStamp, InterpretationOf(receivedCommands[cIx]), Environment.NewLine));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
            output = string.Empty;
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Show all the incoming data in the port's buffer
            //textBoxNemaOutput.AppendText(serialNmeaOutput.ReadExisting());
            output += serialNmeaOutput.ReadLine();
        }


        private void dataGridViewShaft_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView vi = (DataGridView)sender;
            int k = vi.CurrentRow.Index;

            try
            {
                textBoxSensor1.Text = dataGridViewShaft.Rows[k].Cells[1].Value.ToString();
                textBoxSensor3.Text = dataGridViewShaft.Rows[k].Cells[2].Value.ToString();
                textBoxSpeed.Text = dataGridViewShaft.Rows[k].Cells[3].Value.ToString();
                if (dataGridViewShaft.Rows[k].Cells[4].Value.ToString() == "1")
                    checkBoxClockwise.Checked = true;
                else
                    checkBoxClockwise.Checked = false;
            }
            catch (Exception ex)
            {
                checkBoxClockwise.Checked = false;
            }
        }

        public struct dataGridViewdata
        {
            public int nRows;
            public int nCells;
            public List<string> lst;
        }

        public struct xmlPara
        {
            public string numberOfTCFIs;
            public dataGridViewdata tcfis;
            public dataGridViewdata shaftpower;
            public string comportNMEA;
            public string comportShaftpower;
            public string nmeaString;
            public string gpsString;
            public bool gpsEnabled;
            public bool speedlogEnabled;
            public bool shaftpowerEnabled;
        }

        void DataGridViewToList(DataGridView vi, ref dataGridViewdata da)
        {
            da.lst = new List<string>();
            da.nRows = vi.RowCount;
            da.nCells = vi.ColumnCount;
            for (int zeile = 0; zeile < vi.RowCount; zeile++)
            {
                for (int sp = 0; sp < vi.ColumnCount; sp++)
                    da.lst.Add(vi.Rows[zeile].Cells[sp].Value.ToString());
            }

        }

        void ListToDataGridView(dataGridViewdata da, ref DataGridView vi)
        {
            int k = 0;
            vi.RowCount = da.nRows;
            vi.ColumnCount = da.nCells;
            for (int zeile = 0; zeile < da.nRows; zeile++)
            {
                for (int sp = 0; sp < da.nCells; sp++)
                    vi.Rows[zeile].Cells[sp].Value = da.lst[k++];
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (paraFilename.Length == 0)
                {
                    saveFileDialog1.ShowDialog();
                    paraFilename = saveFileDialog1.FileName;
                    saveFileDialog1.Reset();
                    toolStripStatusLabelFileName.Text = paraFilename;
                }
                if (paraFilename.Length > 0)
                {
                    toolStripStatusLabelError.Text = "";
                    Type t = typeof(xmlPara);
                    XmlSerializer mySerializer = new XmlSerializer(t);
                    StreamWriter myWriter = new StreamWriter(paraFilename, false);  // Nicht anfuegen sondern ueberschreiben
                    xmlPara pa = new xmlPara();

                    pa.numberOfTCFIs = textBoxNrOfTcfi.Text;
                    DataGridViewToList(dataGridViewTcfiList, ref pa.tcfis);
                    DataGridViewToList(dataGridViewShaft, ref pa.shaftpower);
                    pa.comportNMEA = comboBoxComPortsNMEA.Text;
                    pa.comportShaftpower = comboBoxShaftpowerPort.Text;
                    pa.gpsEnabled = checkBoxGPS.Checked;
                    pa.speedlogEnabled = checkBoxSpeedlog.Checked;
                    pa.shaftpowerEnabled = checkBoxShaftpower.Checked;
                   // pa.nmeaString = textBoxSpeedlog.Text;
                    //pa.gpsString = textBoxGPS.Text;
                    mySerializer.Serialize(myWriter, pa);
                    myWriter.Flush();
                    myWriter.Close();
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabelError.Text = ex.Message;
            }

        }

        void DoOpen(bool dialog)
        {
            FileStream myFileStream;
            try
            {
                if (dialog)
                {
                    openFileDialog1.ShowDialog();
                    paraFilename = openFileDialog1.FileName;
                    openFileDialog1.Reset();
                }
                if (paraFilename.Length > 0)
                {
                    toolStripStatusLabelFileName.Text = paraFilename;
                    toolStripStatusLabelError.Text = "";
                    xmlPara pa = new xmlPara();

                    Type t = typeof(xmlPara);
                    XmlSerializer mySerializer = new XmlSerializer(t);
                    myFileStream = new FileStream(paraFilename, FileMode.Open);
                    try
                    {
                        pa = (xmlPara)mySerializer.Deserialize(myFileStream);
                        myFileStream.Close();
                    }
                    catch (Exception ex)
                    {
                        toolStripStatusLabelError.Text = ex.Message;
                        myFileStream.Close();
                        return;
                    }

                    textBoxNrOfTcfi.Text = pa.numberOfTCFIs;
                    ListToDataGridView(pa.tcfis, ref dataGridViewTcfiList);
                    ListToDataGridView(pa.shaftpower, ref dataGridViewShaft);
                    comboBoxComPortsNMEA.Text = pa.comportNMEA;
                    comboBoxShaftpowerPort.Text = pa.comportShaftpower;
                    checkBoxGPS.Checked = pa.gpsEnabled;
                    checkBoxSpeedlog.Checked = pa.speedlogEnabled;
                    checkBoxShaftpower.Checked = pa.shaftpowerEnabled;
                    //textBoxSpeedlog.Text = pa.nmeaString.Replace("\n", "\r\n");
                    //textBoxGPS.Text = pa.gpsString.Replace("\n", "\r\n"); ;

                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabelError.Text = ex.Message;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoOpen(true);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paraFilename = "";
            saveToolStripMenuItem_Click(sender, e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string curDir = Directory.GetCurrentDirectory();
            string defaultFile = curDir + "\\ShaftpowerTest.xml";


            paraFilename = defaultFile;
            saveToolStripMenuItem_Click(null, null);

            System.Environment.Exit(1);
        }


        static string lastNmeaOutputPort = "";
        private void comboBoxNmeaOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (serialNmeaOutput.IsOpen)
                    serialNmeaOutput.Close();
                serialNmeaOutput.PortName = comboBoxNmeaOutput.SelectedItem.ToString();
                serialNmeaOutput.Open();
                lastNmeaOutputPort = serialNmeaOutput.PortName;
                timerNmeaOutput.Enabled = true;
                toolStripStatusLabelError.Text = "";
            }
            catch (Exception ex)
            {
                if (lastNmeaOutputPort.Length > 0)
                {
                    serialNmeaOutput.PortName = lastNmeaOutputPort;
                    comboBoxNmeaOutput.SelectedItem = lastNmeaOutputPort;
                }
                //MessageBox.Show(ex.ToString(),"Error", MessageBoxButtons.OK);
                toolStripStatusLabelError.Text = ex.Message;
                Program.eventlog.EventLog(ex);
            }

        }

        


        private void CheckBox_CheckedChanged(object sender, EventArgs e, TextBox targetTextBox, string linkedTextBox)
        {
            // Obtener el texto que debe agregarse o eliminarse
            string textToAddOrRemove = linkedTextBox.TrimEnd('\r', '\n');

            // Verificar si el CheckBox fue seleccionado
            if ((sender as CheckBox).Checked)
            {
                // Agregar el texto al TextBox de destino en una nueva línea
                targetTextBox.AppendText(Environment.NewLine + textToAddOrRemove);
            }
            else
            {
                // Eliminar el texto del TextBox de destino si existe
                string[] lines = targetTextBox.Lines;

                // Crear una lista de las líneas sin el texto que se debe eliminar
                List<string> updatedLines = new List<string>();

                foreach (string line in lines)
                {
                    // Solo agregamos las líneas que no coinciden con el texto a eliminar
                    if (!line.Equals(textToAddOrRemove))
                    {
                        updatedLines.Add(line);
                    }
                }

                // Actualizar el TextBox con las líneas filtradas (sin el texto eliminado)
                targetTextBox.Lines = updatedLines.ToArray();
            }
        }
        

        private void checkBoxGPS_CheckedChanged(object sender, EventArgs e)
        {
            string textBoxGPS = "$GPRMC,092054.27,A,3938.61287,N,00347.22401,W,20.0,355.0,231216,0.0,W";
            HandleCheckBox(checkBoxGPS, textBox4, textBoxGPS);
        }

        private void checkBoxSpeedlog_CheckedChanged(object sender, EventArgs e)
        {
            string textBoxSpeedlog = "$VWVHW,355.0,T,355.0,M,12.0,N,22.2,K";
            HandleCheckBox(checkBoxSpeedlog, textBox4, textBoxSpeedlog);
        }

        private void textBoxSpeedlog_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            string texBoxZda = "$GPZDA,172809.456,12,07,1996,00,00";
            HandleCheckBox(checkBoxZda, textBox4, texBoxZda);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            string texBoxGga = "$GPGGA,172814.0,3723.46587704,N,12202.26957864,W,2,6,1.2,18.893,M,-25.669,M,2.0 0031";
            HandleCheckBox(checkGga, textBox4, texBoxGga);  
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            string texBoxGll = "$GPGLL,3953.88008971,N,10506.75318910,W,034138.00,A,D";
            HandleCheckBox(checkBoxGll, textBox4, texBoxGll);
           
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            string texBoxVbw = "$IIVBW,5.2,0.0,A,5.4,0.0,A";
            HandleCheckBox(checkBoxVbw, textBox4, texBoxVbw);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            string texBoxVtg = "$GPVTG,140.88,T,,M,8.04,N,14.89,K,D";
            HandleCheckBox(checkBoxVtg, textBox4, texBoxVtg);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            string texBoxOsd = "$RAOSD,087.2,A,087.0,W,11.4,W,,,N";
            HandleCheckBox(checkBoxOsd, textBox4, texBoxOsd);
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            string texBoxHdg = "$GPHDG,123.4,2.5,E,5.1,W";
            HandleCheckBox(checkBoxHdg, textBox4, texBoxHdg);
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            string texBoxDbk = "$GPDBK,12.3,f,243,M,4.5,F";
            HandleCheckBox(checkBoxDbk, textBox4, texBoxDbk);
        }

        private void checkBox5_CheckedChanged_1(object sender, EventArgs e)
        {
            string texBoxDpt = "$SDDPT,45.5,1.2,100.0";
            HandleCheckBox(checkBoxDpt, textBox4, texBoxDpt);
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            string texBoxMwv = "$WIMWV,320,R,15.0,M,A";
            HandleCheckBox(checkBoxMwv, textBox4, texBoxMwv);
        }

        private void checkBoxRsa_CheckedChanged(object sender, EventArgs e)
        {
            string texBoxRsa = "$GPRSA,22.3,A,-15.7,A";
            HandleCheckBox(checkBoxRsa, textBox4, texBoxRsa);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            linesFromText = textBox4.Text;
        }
    }







        /* private void timerModbus_Tick(object sender, EventArgs e)
         {



             if (!checkBoxModbus.Checked) return;
             string str = "01 03 00 00 00 08 44 0c";
             byte[] bytes = str.Split(' ').Select(s => Convert.ToByte(s, 16)).ToArray();
             serialPortModbus.Write(bytes, 0, bytes.Length);

             serialPortModbus.DataReceived += new SerialDataReceivedEventHandler(port_ModbusDataReceived);



         }*/



    
}

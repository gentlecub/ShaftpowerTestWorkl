using System;

namespace ShaftpowerTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelError = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerCanTx = new System.Windows.Forms.Timer(this.components);
            this.serialPortNMEA = new System.IO.Ports.SerialPort(this.components);
            this.timerNMEA = new System.Windows.Forms.Timer(this.components);
            this.serialPortShaftpower = new System.IO.Ports.SerialPort(this.components);
            this.serialNmeaOutput = new System.IO.Ports.SerialPort(this.components);
            this.serialPortModbus = new System.IO.Ports.SerialPort(this.components);
            this.timerShaftpower = new System.Windows.Forms.Timer(this.components);
            this.timerNmeaOutput = new System.Windows.Forms.Timer(this.components);
            this.timerModbus = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxSendMsg2 = new System.Windows.Forms.CheckBox();
            this.checkBoxSendingMsg = new System.Windows.Forms.CheckBox();
            this.textBoxRepresentation = new System.Windows.Forms.TextBox();
            this.textBoxNemaOutput = new System.Windows.Forms.TextBox();
            this.comboBoxNmeaOutput = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPageShaft = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridViewShaft = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxEEXITestBox = new System.Windows.Forms.TextBox();
            this.checkBoxEEXISim = new System.Windows.Forms.CheckBox();
            this.checkBoxFaultyMsg = new System.Windows.Forms.CheckBox();
            this.checkBoxClockwise = new System.Windows.Forms.CheckBox();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSensor3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSensor1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxShaftpowerPort = new System.Windows.Forms.ComboBox();
            this.checkBoxShaftpower = new System.Windows.Forms.CheckBox();
            this.tabPageGpsSpeed = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.checkBoxRsa = new System.Windows.Forms.CheckBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.checkBoxMwv = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.checkBoxVtg = new System.Windows.Forms.CheckBox();
            this.checkBoxVbw = new System.Windows.Forms.CheckBox();
            this.checkBoxSpeedlog = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkBoxHdg = new System.Windows.Forms.CheckBox();
            this.checkBoxOsd = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBoxDpt = new System.Windows.Forms.CheckBox();
            this.checkBoxDbk = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBoxGPS = new System.Windows.Forms.CheckBox();
            this.checkBoxGll = new System.Windows.Forms.CheckBox();
            this.checkBoxZda = new System.Windows.Forms.CheckBox();
            this.checkGga = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxComPortsNMEA = new System.Windows.Forms.ComboBox();
            this.tabPageTCFI = new System.Windows.Forms.TabPage();
            this.checkBoxTCFIenabled = new System.Windows.Forms.CheckBox();
            this.zoomTrackBarControl3 = new DevExpress.XtraEditors.ZoomTrackBarControl();
            this.zoomTrackBarControl2 = new DevExpress.XtraEditors.ZoomTrackBarControl();
            this.zoomTrackBarControl1 = new DevExpress.XtraEditors.ZoomTrackBarControl();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNrOfTcfi = new System.Windows.Forms.TextBox();
            this.dataGridViewTcfiList = new System.Windows.Forms.DataGridView();
            this.ColumnTcfi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFrequenz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFrequenzOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTempOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modbus = new System.Windows.Forms.TabControl();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageShaft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShaft)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPageGpsSpeed.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPageTCFI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTcfiList)).BeginInit();
            this.Modbus.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Green;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1924, 39);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(34, 34);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.ToolTipText = "Open";
            this.toolStripButton3.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 34);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Save";
            this.toolStripButton1.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 34);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Save as";
            this.toolStripButton2.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelFileName,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelError});
            this.statusStrip1.Location = new System.Drawing.Point(0, 985);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1924, 32);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelFileName
            // 
            this.toolStripStatusLabelFileName.BackColor = System.Drawing.Color.DimGray;
            this.toolStripStatusLabelFileName.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabelFileName.Name = "toolStripStatusLabelFileName";
            this.toolStripStatusLabelFileName.Size = new System.Drawing.Size(182, 25);
            this.toolStripStatusLabelFileName.Text = "c:\\\\Lemag\\temp\\.....   ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(179, 25);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabelError
            // 
            this.toolStripStatusLabelError.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabelError.Name = "toolStripStatusLabelError";
            this.toolStripStatusLabelError.Size = new System.Drawing.Size(1540, 25);
            this.toolStripStatusLabelError.Spring = true;
            this.toolStripStatusLabelError.Text = "toolStripStatusLabelError";
            this.toolStripStatusLabelError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerCanTx
            // 
            this.timerCanTx.Tick += new System.EventHandler(this.timerCanTx_Tick);
            // 
            // serialPortNMEA
            // 
            this.serialPortNMEA.BaudRate = 4800;
            // 
            // timerNMEA
            // 
            this.timerNMEA.Enabled = true;
            this.timerNMEA.Interval = 1000;
            this.timerNMEA.Tick += new System.EventHandler(this.timerNMEA_Tick);
            // 
            // serialPortShaftpower
            // 
            this.serialPortShaftpower.BaudRate = 38400;
            this.serialPortShaftpower.WriteTimeout = 500;
            // 
            // serialNmeaOutput
            // 
            this.serialNmeaOutput.PortName = "COM19";
            // 
            // serialPortModbus
            // 
            this.serialPortModbus.Parity = System.IO.Ports.Parity.Even;
            // 
            // timerShaftpower
            // 
            this.timerShaftpower.Interval = 2000;
            this.timerShaftpower.Tick += new System.EventHandler(this.timerShaftpower_Tick);
            // 
            // timerNmeaOutput
            // 
            this.timerNmeaOutput.Interval = 2000;
            this.timerNmeaOutput.Tick += new System.EventHandler(this.timerNmeaOutput_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 33);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(173, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(173, 34);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(173, 34);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Para file (*.xml)|*.xml";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Para file (*.xml)|*.xml";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.checkBoxSendMsg2);
            this.tabPage1.Controls.Add(this.checkBoxSendingMsg);
            this.tabPage1.Controls.Add(this.textBoxRepresentation);
            this.tabPage1.Controls.Add(this.textBoxNemaOutput);
            this.tabPage1.Controls.Add(this.comboBoxNmeaOutput);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(2206, 835);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Nmea Output";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 103);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Incoming raw messages:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 460);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(271, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Interpretation of incoming messages:";
            // 
            // checkBoxSendMsg2
            // 
            this.checkBoxSendMsg2.AutoSize = true;
            this.checkBoxSendMsg2.Location = new System.Drawing.Point(375, 72);
            this.checkBoxSendMsg2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxSendMsg2.Name = "checkBoxSendMsg2";
            this.checkBoxSendMsg2.Size = new System.Drawing.Size(238, 24);
            this.checkBoxSendMsg2.TabIndex = 15;
            this.checkBoxSendMsg2.Text = "Sending Message Protocol 1";
            this.checkBoxSendMsg2.UseVisualStyleBackColor = true;
            // 
            // checkBoxSendingMsg
            // 
            this.checkBoxSendingMsg.AutoSize = true;
            this.checkBoxSendingMsg.Location = new System.Drawing.Point(123, 72);
            this.checkBoxSendingMsg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxSendingMsg.Name = "checkBoxSendingMsg";
            this.checkBoxSendingMsg.Size = new System.Drawing.Size(238, 24);
            this.checkBoxSendingMsg.TabIndex = 14;
            this.checkBoxSendingMsg.Text = "Sending Message Protocol 0";
            this.checkBoxSendingMsg.UseVisualStyleBackColor = true;
            // 
            // textBoxRepresentation
            // 
            this.textBoxRepresentation.Location = new System.Drawing.Point(22, 485);
            this.textBoxRepresentation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRepresentation.Multiline = true;
            this.textBoxRepresentation.Name = "textBoxRepresentation";
            this.textBoxRepresentation.Size = new System.Drawing.Size(1753, 306);
            this.textBoxRepresentation.TabIndex = 13;
            // 
            // textBoxNemaOutput
            // 
            this.textBoxNemaOutput.Location = new System.Drawing.Point(22, 128);
            this.textBoxNemaOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNemaOutput.Multiline = true;
            this.textBoxNemaOutput.Name = "textBoxNemaOutput";
            this.textBoxNemaOutput.Size = new System.Drawing.Size(1753, 306);
            this.textBoxNemaOutput.TabIndex = 12;
            // 
            // comboBoxNmeaOutput
            // 
            this.comboBoxNmeaOutput.FormattingEnabled = true;
            this.comboBoxNmeaOutput.Location = new System.Drawing.Point(123, 25);
            this.comboBoxNmeaOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxNmeaOutput.Name = "comboBoxNmeaOutput";
            this.comboBoxNmeaOutput.Size = new System.Drawing.Size(121, 28);
            this.comboBoxNmeaOutput.TabIndex = 11;
            this.comboBoxNmeaOutput.Text = "COM3";
            this.comboBoxNmeaOutput.SelectedIndexChanged += new System.EventHandler(this.comboBoxNmeaOutput_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "COM port";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(22, 72);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 24);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Enable";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabPageShaft
            // 
            this.tabPageShaft.Controls.Add(this.textBox2);
            this.tabPageShaft.Controls.Add(this.dataGridViewShaft);
            this.tabPageShaft.Controls.Add(this.groupBox3);
            this.tabPageShaft.Controls.Add(this.label5);
            this.tabPageShaft.Controls.Add(this.comboBoxShaftpowerPort);
            this.tabPageShaft.Controls.Add(this.checkBoxShaftpower);
            this.tabPageShaft.Location = new System.Drawing.Point(4, 29);
            this.tabPageShaft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageShaft.Name = "tabPageShaft";
            this.tabPageShaft.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageShaft.Size = new System.Drawing.Size(2206, 835);
            this.tabPageShaft.TabIndex = 1;
            this.tabPageShaft.Text = "Shaft";
            this.tabPageShaft.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(1520, 503);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(104, 28);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = " ";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dataGridViewShaft
            // 
            this.dataGridViewShaft.AllowUserToAddRows = false;
            this.dataGridViewShaft.AllowUserToDeleteRows = false;
            this.dataGridViewShaft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewShaft.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewShaft.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShaft.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewShaft.ColumnHeadersHeight = 32;
            this.dataGridViewShaft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewShaft.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewShaft.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewShaft.Location = new System.Drawing.Point(22, 123);
            this.dataGridViewShaft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewShaft.MultiSelect = false;
            this.dataGridViewShaft.Name = "dataGridViewShaft";
            this.dataGridViewShaft.RowHeadersWidth = 62;
            this.dataGridViewShaft.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewShaft.Size = new System.Drawing.Size(1228, 635);
            this.dataGridViewShaft.TabIndex = 11;
            this.dataGridViewShaft.SelectionChanged += new System.EventHandler(this.dataGridViewShaft_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn1.HeaderText = "Comment";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.HeaderText = "Sensor 1";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.HeaderText = "Sensor 3";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.HeaderText = "Speed";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.HeaderText = "Clock wise";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.textBoxEEXITestBox);
            this.groupBox3.Controls.Add(this.checkBoxEEXISim);
            this.groupBox3.Controls.Add(this.checkBoxFaultyMsg);
            this.groupBox3.Controls.Add(this.checkBoxClockwise);
            this.groupBox3.Controls.Add(this.textBoxSpeed);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBoxSensor3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxSensor1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(1292, 123);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(344, 380);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(228, 338);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 28);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = " ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxEEXITestBox
            // 
            this.textBoxEEXITestBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEEXITestBox.Location = new System.Drawing.Point(228, 303);
            this.textBoxEEXITestBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEEXITestBox.Name = "textBoxEEXITestBox";
            this.textBoxEEXITestBox.Size = new System.Drawing.Size(104, 28);
            this.textBoxEEXITestBox.TabIndex = 14;
            this.textBoxEEXITestBox.Text = " ";
            this.textBoxEEXITestBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBoxEEXISim
            // 
            this.checkBoxEEXISim.AutoSize = true;
            this.checkBoxEEXISim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEEXISim.Location = new System.Drawing.Point(21, 282);
            this.checkBoxEEXISim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxEEXISim.Name = "checkBoxEEXISim";
            this.checkBoxEEXISim.Size = new System.Drawing.Size(179, 29);
            this.checkBoxEEXISim.TabIndex = 13;
            this.checkBoxEEXISim.Text = "EEXI Simulation";
            this.checkBoxEEXISim.UseVisualStyleBackColor = false;
            // 
            // checkBoxFaultyMsg
            // 
            this.checkBoxFaultyMsg.AutoSize = true;
            this.checkBoxFaultyMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFaultyMsg.Location = new System.Drawing.Point(21, 242);
            this.checkBoxFaultyMsg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxFaultyMsg.Name = "checkBoxFaultyMsg";
            this.checkBoxFaultyMsg.Size = new System.Drawing.Size(179, 29);
            this.checkBoxFaultyMsg.TabIndex = 12;
            this.checkBoxFaultyMsg.Text = "Faulty Telegram";
            this.checkBoxFaultyMsg.UseVisualStyleBackColor = true;
            // 
            // checkBoxClockwise
            // 
            this.checkBoxClockwise.AutoSize = true;
            this.checkBoxClockwise.Checked = true;
            this.checkBoxClockwise.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxClockwise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxClockwise.Location = new System.Drawing.Point(21, 202);
            this.checkBoxClockwise.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxClockwise.Name = "checkBoxClockwise";
            this.checkBoxClockwise.Size = new System.Drawing.Size(132, 29);
            this.checkBoxClockwise.TabIndex = 8;
            this.checkBoxClockwise.Text = "Clock wise";
            this.checkBoxClockwise.UseVisualStyleBackColor = true;
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSpeed.Location = new System.Drawing.Point(142, 148);
            this.textBoxSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(104, 28);
            this.textBoxSpeed.TabIndex = 7;
            this.textBoxSpeed.Text = " 50";
            this.textBoxSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Speed";
            // 
            // textBoxSensor3
            // 
            this.textBoxSensor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSensor3.Location = new System.Drawing.Point(142, 94);
            this.textBoxSensor3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSensor3.Name = "textBoxSensor3";
            this.textBoxSensor3.Size = new System.Drawing.Size(104, 28);
            this.textBoxSensor3.TabIndex = 5;
            this.textBoxSensor3.Text = "3100";
            this.textBoxSensor3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Sensor 3";
            // 
            // textBoxSensor1
            // 
            this.textBoxSensor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSensor1.Location = new System.Drawing.Point(142, 48);
            this.textBoxSensor1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSensor1.Name = "textBoxSensor1";
            this.textBoxSensor1.Size = new System.Drawing.Size(104, 28);
            this.textBoxSensor1.TabIndex = 3;
            this.textBoxSensor1.Text = "900";
            this.textBoxSensor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Sensor 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "COM port";
            // 
            // comboBoxShaftpowerPort
            // 
            this.comboBoxShaftpowerPort.FormattingEnabled = true;
            this.comboBoxShaftpowerPort.Location = new System.Drawing.Point(128, 26);
            this.comboBoxShaftpowerPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxShaftpowerPort.Name = "comboBoxShaftpowerPort";
            this.comboBoxShaftpowerPort.Size = new System.Drawing.Size(180, 28);
            this.comboBoxShaftpowerPort.TabIndex = 8;
            this.comboBoxShaftpowerPort.Text = "COM4";
            this.comboBoxShaftpowerPort.SelectedIndexChanged += new System.EventHandler(this.comboBoxShaftpowerPort_SelectedIndexChanged);
            // 
            // checkBoxShaftpower
            // 
            this.checkBoxShaftpower.AutoSize = true;
            this.checkBoxShaftpower.Checked = true;
            this.checkBoxShaftpower.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShaftpower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShaftpower.Location = new System.Drawing.Point(22, 85);
            this.checkBoxShaftpower.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxShaftpower.Name = "checkBoxShaftpower";
            this.checkBoxShaftpower.Size = new System.Drawing.Size(212, 29);
            this.checkBoxShaftpower.TabIndex = 7;
            this.checkBoxShaftpower.Text = "Shaftpower enabled";
            this.checkBoxShaftpower.UseVisualStyleBackColor = true;
            // 
            // tabPageGpsSpeed
            // 
            this.tabPageGpsSpeed.Controls.Add(this.groupBox11);
            this.tabPageGpsSpeed.Controls.Add(this.groupBox10);
            this.tabPageGpsSpeed.Controls.Add(this.groupBox9);
            this.tabPageGpsSpeed.Controls.Add(this.groupBox8);
            this.tabPageGpsSpeed.Controls.Add(this.groupBox7);
            this.tabPageGpsSpeed.Controls.Add(this.groupBox6);
            this.tabPageGpsSpeed.Controls.Add(this.groupBox5);
            this.tabPageGpsSpeed.Controls.Add(this.label4);
            this.tabPageGpsSpeed.Controls.Add(this.comboBoxComPortsNMEA);
            this.tabPageGpsSpeed.Location = new System.Drawing.Point(4, 29);
            this.tabPageGpsSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageGpsSpeed.Name = "tabPageGpsSpeed";
            this.tabPageGpsSpeed.Size = new System.Drawing.Size(2206, 835);
            this.tabPageGpsSpeed.TabIndex = 2;
            this.tabPageGpsSpeed.Text = "GPS/Speed";
            this.tabPageGpsSpeed.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.textBox4);
            this.groupBox11.Location = new System.Drawing.Point(980, 43);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox11.Size = new System.Drawing.Size(520, 708);
            this.groupBox11.TabIndex = 18;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "groupBox11";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(44, 49);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(433, 638);
            this.textBox4.TabIndex = 0;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.checkBoxRsa);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(416, 576);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox10.Size = new System.Drawing.Size(428, 113);
            this.groupBox10.TabIndex = 17;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Rudder Group";
            // 
            // checkBoxRsa
            // 
            this.checkBoxRsa.AutoSize = true;
            this.checkBoxRsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRsa.Location = new System.Drawing.Point(10, 44);
            this.checkBoxRsa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxRsa.Name = "checkBoxRsa";
            this.checkBoxRsa.Size = new System.Drawing.Size(143, 29);
            this.checkBoxRsa.TabIndex = 13;
            this.checkBoxRsa.Text = "RSA enable";
            this.checkBoxRsa.UseVisualStyleBackColor = true;
            this.checkBoxRsa.CheckedChanged += new System.EventHandler(this.checkBoxRsa_CheckedChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.checkBoxMwv);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(32, 576);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox9.Size = new System.Drawing.Size(321, 113);
            this.groupBox9.TabIndex = 16;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Anemometer Group";
            // 
            // checkBoxMwv
            // 
            this.checkBoxMwv.AutoSize = true;
            this.checkBoxMwv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMwv.Location = new System.Drawing.Point(9, 44);
            this.checkBoxMwv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxMwv.Name = "checkBoxMwv";
            this.checkBoxMwv.Size = new System.Drawing.Size(153, 29);
            this.checkBoxMwv.TabIndex = 12;
            this.checkBoxMwv.Text = "MWV enable";
            this.checkBoxMwv.UseVisualStyleBackColor = true;
            this.checkBoxMwv.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_1);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.checkBoxVtg);
            this.groupBox8.Controls.Add(this.checkBoxVbw);
            this.groupBox8.Controls.Add(this.checkBoxSpeedlog);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(416, 117);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox8.Size = new System.Drawing.Size(428, 245);
            this.groupBox8.TabIndex = 15;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Speed Group";
            // 
            // checkBoxVtg
            // 
            this.checkBoxVtg.AutoSize = true;
            this.checkBoxVtg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxVtg.Location = new System.Drawing.Point(9, 122);
            this.checkBoxVtg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxVtg.Name = "checkBoxVtg";
            this.checkBoxVtg.Size = new System.Drawing.Size(144, 29);
            this.checkBoxVtg.TabIndex = 5;
            this.checkBoxVtg.Text = "VTG enable";
            this.checkBoxVtg.UseVisualStyleBackColor = true;
            this.checkBoxVtg.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // checkBoxVbw
            // 
            this.checkBoxVbw.AutoSize = true;
            this.checkBoxVbw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxVbw.Location = new System.Drawing.Point(10, 78);
            this.checkBoxVbw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxVbw.Name = "checkBoxVbw";
            this.checkBoxVbw.Size = new System.Drawing.Size(149, 29);
            this.checkBoxVbw.TabIndex = 4;
            this.checkBoxVbw.Text = "VBW enable";
            this.checkBoxVbw.UseVisualStyleBackColor = true;
            this.checkBoxVbw.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBoxSpeedlog
            // 
            this.checkBoxSpeedlog.AutoSize = true;
            this.checkBoxSpeedlog.Checked = true;
            this.checkBoxSpeedlog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSpeedlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSpeedlog.Location = new System.Drawing.Point(9, 37);
            this.checkBoxSpeedlog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxSpeedlog.Name = "checkBoxSpeedlog";
            this.checkBoxSpeedlog.Size = new System.Drawing.Size(161, 29);
            this.checkBoxSpeedlog.TabIndex = 3;
            this.checkBoxSpeedlog.Text = "VHW enabled";
            this.checkBoxSpeedlog.UseVisualStyleBackColor = true;
            this.checkBoxSpeedlog.CheckedChanged += new System.EventHandler(this.checkBoxSpeedlog_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkBoxHdg);
            this.groupBox7.Controls.Add(this.checkBoxOsd);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(32, 403);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox7.Size = new System.Drawing.Size(321, 154);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Compass Group";
            // 
            // checkBoxHdg
            // 
            this.checkBoxHdg.AutoSize = true;
            this.checkBoxHdg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHdg.Location = new System.Drawing.Point(8, 85);
            this.checkBoxHdg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxHdg.Name = "checkBoxHdg";
            this.checkBoxHdg.Size = new System.Drawing.Size(145, 29);
            this.checkBoxHdg.TabIndex = 12;
            this.checkBoxHdg.Text = "HDG enable";
            this.checkBoxHdg.UseVisualStyleBackColor = true;
            this.checkBoxHdg.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged_1);
            // 
            // checkBoxOsd
            // 
            this.checkBoxOsd.AutoSize = true;
            this.checkBoxOsd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOsd.Location = new System.Drawing.Point(8, 46);
            this.checkBoxOsd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxOsd.Name = "checkBoxOsd";
            this.checkBoxOsd.Size = new System.Drawing.Size(146, 29);
            this.checkBoxOsd.TabIndex = 11;
            this.checkBoxOsd.Text = "OSD enable";
            this.checkBoxOsd.UseVisualStyleBackColor = true;
            this.checkBoxOsd.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBoxDpt);
            this.groupBox6.Controls.Add(this.checkBoxDbk);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(416, 403);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Size = new System.Drawing.Size(428, 154);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Echo Sound Group";
            // 
            // checkBoxDpt
            // 
            this.checkBoxDpt.AutoSize = true;
            this.checkBoxDpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDpt.Location = new System.Drawing.Point(10, 85);
            this.checkBoxDpt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxDpt.Name = "checkBoxDpt";
            this.checkBoxDpt.Size = new System.Drawing.Size(142, 29);
            this.checkBoxDpt.TabIndex = 13;
            this.checkBoxDpt.Text = "DPT enable";
            this.checkBoxDpt.UseVisualStyleBackColor = true;
            this.checkBoxDpt.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged_1);
            // 
            // checkBoxDbk
            // 
            this.checkBoxDbk.AutoSize = true;
            this.checkBoxDbk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDbk.Location = new System.Drawing.Point(10, 46);
            this.checkBoxDbk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxDbk.Name = "checkBoxDbk";
            this.checkBoxDbk.Size = new System.Drawing.Size(143, 29);
            this.checkBoxDbk.TabIndex = 12;
            this.checkBoxDbk.Text = "DBK enable";
            this.checkBoxDbk.UseVisualStyleBackColor = true;
            this.checkBoxDbk.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBoxGPS);
            this.groupBox5.Controls.Add(this.checkBoxGll);
            this.groupBox5.Controls.Add(this.checkBoxZda);
            this.groupBox5.Controls.Add(this.checkGga);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(32, 117);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(321, 245);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "GPS Group";
            // 
            // checkBoxGPS
            // 
            this.checkBoxGPS.AutoSize = true;
            this.checkBoxGPS.Checked = true;
            this.checkBoxGPS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxGPS.Location = new System.Drawing.Point(9, 31);
            this.checkBoxGPS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxGPS.Name = "checkBoxGPS";
            this.checkBoxGPS.Size = new System.Drawing.Size(158, 29);
            this.checkBoxGPS.TabIndex = 1;
            this.checkBoxGPS.Text = "RMC enabled";
            this.checkBoxGPS.UseVisualStyleBackColor = true;
            this.checkBoxGPS.CheckedChanged += new System.EventHandler(this.checkBoxGPS_CheckedChanged);
            // 
            // checkBoxGll
            // 
            this.checkBoxGll.AutoSize = true;
            this.checkBoxGll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxGll.Location = new System.Drawing.Point(9, 154);
            this.checkBoxGll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxGll.Name = "checkBoxGll";
            this.checkBoxGll.Size = new System.Drawing.Size(139, 29);
            this.checkBoxGll.TabIndex = 11;
            this.checkBoxGll.Text = "GLL enable";
            this.checkBoxGll.UseVisualStyleBackColor = true;
            this.checkBoxGll.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBoxZda
            // 
            this.checkBoxZda.AutoSize = true;
            this.checkBoxZda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxZda.Location = new System.Drawing.Point(9, 72);
            this.checkBoxZda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxZda.Name = "checkBoxZda";
            this.checkBoxZda.Size = new System.Drawing.Size(153, 29);
            this.checkBoxZda.TabIndex = 9;
            this.checkBoxZda.Text = "ZDA enabled";
            this.checkBoxZda.UseVisualStyleBackColor = true;
            this.checkBoxZda.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkGga
            // 
            this.checkGga.AutoSize = true;
            this.checkGga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkGga.Location = new System.Drawing.Point(9, 108);
            this.checkGga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkGga.Name = "checkGga";
            this.checkGga.Size = new System.Drawing.Size(146, 29);
            this.checkGga.TabIndex = 10;
            this.checkGga.Text = "GGA enable";
            this.checkGga.UseVisualStyleBackColor = true;
            this.checkGga.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "COM port";
            // 
            // comboBoxComPortsNMEA
            // 
            this.comboBoxComPortsNMEA.FormattingEnabled = true;
            this.comboBoxComPortsNMEA.Location = new System.Drawing.Point(136, 43);
            this.comboBoxComPortsNMEA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxComPortsNMEA.Name = "comboBoxComPortsNMEA";
            this.comboBoxComPortsNMEA.Size = new System.Drawing.Size(128, 28);
            this.comboBoxComPortsNMEA.TabIndex = 5;
            this.comboBoxComPortsNMEA.Text = "COM3";
            this.comboBoxComPortsNMEA.SelectedIndexChanged += new System.EventHandler(this.comboBoxComPortsNMEA_SelectedIndexChanged);
            // 
            // tabPageTCFI
            // 
            this.tabPageTCFI.Controls.Add(this.checkBoxTCFIenabled);
            this.tabPageTCFI.Controls.Add(this.zoomTrackBarControl3);
            this.tabPageTCFI.Controls.Add(this.zoomTrackBarControl2);
            this.tabPageTCFI.Controls.Add(this.zoomTrackBarControl1);
            this.tabPageTCFI.Controls.Add(this.label1);
            this.tabPageTCFI.Controls.Add(this.textBoxNrOfTcfi);
            this.tabPageTCFI.Controls.Add(this.dataGridViewTcfiList);
            this.tabPageTCFI.Location = new System.Drawing.Point(4, 29);
            this.tabPageTCFI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageTCFI.Name = "tabPageTCFI";
            this.tabPageTCFI.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageTCFI.Size = new System.Drawing.Size(2206, 835);
            this.tabPageTCFI.TabIndex = 0;
            this.tabPageTCFI.Text = "TCFI";
            this.tabPageTCFI.UseVisualStyleBackColor = true;
            // 
            // checkBoxTCFIenabled
            // 
            this.checkBoxTCFIenabled.AutoSize = true;
            this.checkBoxTCFIenabled.Checked = true;
            this.checkBoxTCFIenabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTCFIenabled.Location = new System.Drawing.Point(22, 85);
            this.checkBoxTCFIenabled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxTCFIenabled.Name = "checkBoxTCFIenabled";
            this.checkBoxTCFIenabled.Size = new System.Drawing.Size(85, 24);
            this.checkBoxTCFIenabled.TabIndex = 6;
            this.checkBoxTCFIenabled.Text = "Enable";
            this.checkBoxTCFIenabled.UseVisualStyleBackColor = true;
            // 
            // zoomTrackBarControl3
            // 
            this.zoomTrackBarControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomTrackBarControl3.EditValue = null;
            this.zoomTrackBarControl3.Location = new System.Drawing.Point(1422, 203);
            this.zoomTrackBarControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zoomTrackBarControl3.Name = "zoomTrackBarControl3";
            // 
            // 
            // 
            this.zoomTrackBarControl3.Properties.Middle = 5;
            this.zoomTrackBarControl3.Size = new System.Drawing.Size(368, 21);
            this.zoomTrackBarControl3.TabIndex = 5;
            this.zoomTrackBarControl3.EditValueChanged += new System.EventHandler(this.zoomTrackBarControl3_EditValueChanged);
            // 
            // zoomTrackBarControl2
            // 
            this.zoomTrackBarControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomTrackBarControl2.EditValue = null;
            this.zoomTrackBarControl2.Location = new System.Drawing.Point(1422, 165);
            this.zoomTrackBarControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zoomTrackBarControl2.Name = "zoomTrackBarControl2";
            // 
            // 
            // 
            this.zoomTrackBarControl2.Properties.Middle = 5;
            this.zoomTrackBarControl2.Size = new System.Drawing.Size(368, 21);
            this.zoomTrackBarControl2.TabIndex = 4;
            this.zoomTrackBarControl2.EditValueChanged += new System.EventHandler(this.zoomTrackBarControl2_EditValueChanged);
            // 
            // zoomTrackBarControl1
            // 
            this.zoomTrackBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomTrackBarControl1.EditValue = null;
            this.zoomTrackBarControl1.Location = new System.Drawing.Point(1422, 126);
            this.zoomTrackBarControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zoomTrackBarControl1.Name = "zoomTrackBarControl1";
            // 
            // 
            // 
            this.zoomTrackBarControl1.Properties.Middle = 5;
            this.zoomTrackBarControl1.Size = new System.Drawing.Size(368, 21);
            this.zoomTrackBarControl1.TabIndex = 3;
            this.zoomTrackBarControl1.EditValueChanged += new System.EventHandler(this.trackBarControl1_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "TCFI\'s";
            // 
            // textBoxNrOfTcfi
            // 
            this.textBoxNrOfTcfi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNrOfTcfi.Location = new System.Drawing.Point(92, 31);
            this.textBoxNrOfTcfi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNrOfTcfi.Multiline = true;
            this.textBoxNrOfTcfi.Name = "textBoxNrOfTcfi";
            this.textBoxNrOfTcfi.Size = new System.Drawing.Size(55, 29);
            this.textBoxNrOfTcfi.TabIndex = 1;
            this.textBoxNrOfTcfi.Text = "3";
            // 
            // dataGridViewTcfiList
            // 
            this.dataGridViewTcfiList.AllowUserToAddRows = false;
            this.dataGridViewTcfiList.AllowUserToDeleteRows = false;
            this.dataGridViewTcfiList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewTcfiList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTcfiList.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTcfiList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTcfiList.ColumnHeadersHeight = 32;
            this.dataGridViewTcfiList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewTcfiList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTcfi,
            this.ColumnFrequenz,
            this.Column1,
            this.ColumnFrequenzOut,
            this.ColumnTempOut});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTcfiList.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTcfiList.Location = new System.Drawing.Point(22, 120);
            this.dataGridViewTcfiList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewTcfiList.Name = "dataGridViewTcfiList";
            this.dataGridViewTcfiList.RowHeadersWidth = 62;
            this.dataGridViewTcfiList.Size = new System.Drawing.Size(1392, 675);
            this.dataGridViewTcfiList.TabIndex = 0;
            this.dataGridViewTcfiList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnTcfi
            // 
            this.ColumnTcfi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnTcfi.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColumnTcfi.HeaderText = "TCFI";
            this.ColumnTcfi.MinimumWidth = 8;
            this.ColumnTcfi.Name = "ColumnTcfi";
            this.ColumnTcfi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnTcfi.Width = 200;
            // 
            // ColumnFrequenz
            // 
            this.ColumnFrequenz.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnFrequenz.HeaderText = "Frequenz in";
            this.ColumnFrequenz.MinimumWidth = 8;
            this.ColumnFrequenz.Name = "ColumnFrequenz";
            this.ColumnFrequenz.Width = 150;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "Temp in";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // ColumnFrequenzOut
            // 
            this.ColumnFrequenzOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnFrequenzOut.HeaderText = "Frequenz Out";
            this.ColumnFrequenzOut.MinimumWidth = 8;
            this.ColumnFrequenzOut.Name = "ColumnFrequenzOut";
            this.ColumnFrequenzOut.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnFrequenzOut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnFrequenzOut.Width = 150;
            // 
            // ColumnTempOut
            // 
            this.ColumnTempOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnTempOut.HeaderText = "Temp out";
            this.ColumnTempOut.MinimumWidth = 8;
            this.ColumnTempOut.Name = "ColumnTempOut";
            this.ColumnTempOut.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnTempOut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnTempOut.Width = 125;
            // 
            // Modbus
            // 
            this.Modbus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Modbus.Controls.Add(this.tabPageTCFI);
            this.Modbus.Controls.Add(this.tabPageGpsSpeed);
            this.Modbus.Controls.Add(this.tabPageShaft);
            this.Modbus.Controls.Add(this.tabPage1);
            this.Modbus.Location = new System.Drawing.Point(8, 97);
            this.Modbus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Modbus.Name = "Modbus";
            this.Modbus.SelectedIndex = 0;
            this.Modbus.Size = new System.Drawing.Size(2214, 868);
            this.Modbus.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1017);
            this.Controls.Add(this.Modbus);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "-";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPageShaft.ResumeLayout(false);
            this.tabPageShaft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShaft)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPageGpsSpeed.ResumeLayout(false);
            this.tabPageGpsSpeed.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPageTCFI.ResumeLayout(false);
            this.tabPageTCFI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTcfiList)).EndInit();
            this.Modbus.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFileName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelError;
        private System.Windows.Forms.Timer timerCanTx;
        private System.IO.Ports.SerialPort serialPortNMEA;
        private System.Windows.Forms.Timer timerNMEA;
        private System.IO.Ports.SerialPort serialPortShaftpower;
        private System.IO.Ports.SerialPort serialNmeaOutput;
        private System.IO.Ports.SerialPort serialPortModbus;
        private System.Windows.Forms.Timer timerShaftpower;
        private System.Windows.Forms.Timer timerNmeaOutput;
        private System.Windows.Forms.Timer timerModbus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox checkBoxSendMsg2;
        private System.Windows.Forms.CheckBox checkBoxSendingMsg;
        private System.Windows.Forms.TextBox textBoxRepresentation;
        private System.Windows.Forms.TextBox textBoxNemaOutput;
        private System.Windows.Forms.ComboBox comboBoxNmeaOutput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabPage tabPageShaft;
        private System.Windows.Forms.DataGridView dataGridViewShaft;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxFaultyMsg;
        private System.Windows.Forms.CheckBox checkBoxClockwise;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSensor3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSensor1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxShaftpowerPort;
        private System.Windows.Forms.CheckBox checkBoxShaftpower;
        private System.Windows.Forms.TabPage tabPageGpsSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxComPortsNMEA;
        private System.Windows.Forms.CheckBox checkBoxSpeedlog;
        private System.Windows.Forms.CheckBox checkBoxGPS;
        private System.Windows.Forms.TabPage tabPageTCFI;
        private System.Windows.Forms.CheckBox checkBoxTCFIenabled;
        private DevExpress.XtraEditors.ZoomTrackBarControl zoomTrackBarControl3;
        private DevExpress.XtraEditors.ZoomTrackBarControl zoomTrackBarControl2;
        private DevExpress.XtraEditors.ZoomTrackBarControl zoomTrackBarControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNrOfTcfi;
        private System.Windows.Forms.DataGridView dataGridViewTcfiList;
        private System.Windows.Forms.TabControl Modbus;
        private System.Windows.Forms.CheckBox checkBoxEEXISim;
        private System.Windows.Forms.TextBox textBoxEEXITestBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTcfi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFrequenz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFrequenzOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTempOut;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBoxGll;
        private System.Windows.Forms.CheckBox checkBoxZda;
        private System.Windows.Forms.CheckBox checkGga;
        private System.Windows.Forms.CheckBox checkBoxVtg;
        private System.Windows.Forms.CheckBox checkBoxVbw;
        private System.Windows.Forms.CheckBox checkBoxHdg;
        private System.Windows.Forms.CheckBox checkBoxOsd;
        private System.Windows.Forms.CheckBox checkBoxDpt;
        private System.Windows.Forms.CheckBox checkBoxDbk;
        private System.Windows.Forms.CheckBox checkBoxRsa;
        private System.Windows.Forms.CheckBox checkBoxMwv;
    }
}
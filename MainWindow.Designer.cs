namespace Estes_GSW
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.loadButton = new System.Windows.Forms.Button();
            this.gpsSatCount = new System.Windows.Forms.Label();
            this.gpsFixLabel = new System.Windows.Forms.Label();
            this.startTelemetry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.outputName = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.serialConnect = new System.Windows.Forms.Button();
            this.port = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.TextBox();
            this.graphPanel = new System.Windows.Forms.TableLayoutPanel();
            this.radioChecker = new System.Windows.Forms.Timer(this.components);
            this.vbatGraph = new Estes_GSW.RealTimeChart();
            this.tempGraph = new Estes_GSW.RealTimeChart();
            this.altitudeGraph = new Estes_GSW.RealTimeChart();
            this.gyroChart = new Estes_GSW.RealTimeChart();
            this.positionGraph = new Estes_GSW.RealTimeChart();
            this.accelGraph = new Estes_GSW.RealTimeChart();
            this.panel1.SuspendLayout();
            this.graphPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Controls.Add(this.loadButton);
            this.panel1.Controls.Add(this.gpsSatCount);
            this.panel1.Controls.Add(this.gpsFixLabel);
            this.panel1.Controls.Add(this.startTelemetry);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.outputName);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.serialConnect);
            this.panel1.Controls.Add(this.port);
            this.panel1.Controls.Add(this.portLabel);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 47);
            this.panel1.TabIndex = 0;
            // 
            // loadButton
            // 
            this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadButton.Location = new System.Drawing.Point(807, 16);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 24);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Load Data";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadData);
            // 
            // gpsSatCount
            // 
            this.gpsSatCount.AutoSize = true;
            this.gpsSatCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gpsSatCount.Location = new System.Drawing.Point(404, 19);
            this.gpsSatCount.Name = "gpsSatCount";
            this.gpsSatCount.Size = new System.Drawing.Size(65, 13);
            this.gpsSatCount.TabIndex = 4;
            this.gpsSatCount.Text = "GPS Sats: 0";
            // 
            // gpsFixLabel
            // 
            this.gpsFixLabel.AutoSize = true;
            this.gpsFixLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gpsFixLabel.Location = new System.Drawing.Point(322, 19);
            this.gpsFixLabel.Name = "gpsFixLabel";
            this.gpsFixLabel.Size = new System.Drawing.Size(76, 13);
            this.gpsFixLabel.TabIndex = 3;
            this.gpsFixLabel.Text = "GPS Fix: False";
            // 
            // startTelemetry
            // 
            this.startTelemetry.Location = new System.Drawing.Point(203, 14);
            this.startTelemetry.Name = "startTelemetry";
            this.startTelemetry.Size = new System.Drawing.Size(89, 23);
            this.startTelemetry.TabIndex = 1;
            this.startTelemetry.Text = "Start Telemetry";
            this.startTelemetry.UseVisualStyleBackColor = true;
            this.startTelemetry.Click += new System.EventHandler(this.startTelemetry_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(535, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CSV File Name";
            // 
            // outputName
            // 
            this.outputName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outputName.Location = new System.Drawing.Point(619, 19);
            this.outputName.Name = "outputName";
            this.outputName.Size = new System.Drawing.Size(100, 20);
            this.outputName.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(725, 17);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save Data";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // serialConnect
            // 
            this.serialConnect.Location = new System.Drawing.Point(122, 14);
            this.serialConnect.Name = "serialConnect";
            this.serialConnect.Size = new System.Drawing.Size(75, 23);
            this.serialConnect.TabIndex = 1;
            this.serialConnect.Text = "Connect";
            this.serialConnect.UseVisualStyleBackColor = true;
            this.serialConnect.Click += new System.EventHandler(this.serialConnect_Click);
            // 
            // port
            // 
            this.port.AutoSize = true;
            this.port.ForeColor = System.Drawing.SystemColors.Control;
            this.port.Location = new System.Drawing.Point(12, 19);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(55, 13);
            this.port.TabIndex = 2;
            this.port.Text = "Serial Port";
            // 
            // portLabel
            // 
            this.portLabel.Location = new System.Drawing.Point(66, 16);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(50, 20);
            this.portLabel.TabIndex = 1;
            // 
            // graphPanel
            // 
            this.graphPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphPanel.ColumnCount = 3;
            this.graphPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.graphPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.graphPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.graphPanel.Controls.Add(this.vbatGraph, 2, 1);
            this.graphPanel.Controls.Add(this.tempGraph, 1, 1);
            this.graphPanel.Controls.Add(this.altitudeGraph, 0, 0);
            this.graphPanel.Controls.Add(this.gyroChart, 2, 0);
            this.graphPanel.Controls.Add(this.positionGraph, 1, 0);
            this.graphPanel.Controls.Add(this.accelGraph, 0, 1);
            this.graphPanel.Location = new System.Drawing.Point(0, 43);
            this.graphPanel.Margin = new System.Windows.Forms.Padding(0);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.RowCount = 2;
            this.graphPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.graphPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.graphPanel.Size = new System.Drawing.Size(896, 549);
            this.graphPanel.TabIndex = 4;
            // 
            // radioChecker
            // 
            this.radioChecker.Enabled = true;
            this.radioChecker.Interval = 10;
            this.radioChecker.Tick += new System.EventHandler(this.checkRadio);
            // 
            // vbatGraph
            // 
            this.vbatGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vbatGraph.BackColor = System.Drawing.Color.Gainsboro;
            this.vbatGraph.Location = new System.Drawing.Point(596, 274);
            this.vbatGraph.Margin = new System.Windows.Forms.Padding(0);
            this.vbatGraph.Name = "vbatGraph";
            this.vbatGraph.Size = new System.Drawing.Size(300, 275);
            this.vbatGraph.TabIndex = 6;
            // 
            // tempGraph
            // 
            this.tempGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tempGraph.BackColor = System.Drawing.Color.Gainsboro;
            this.tempGraph.Location = new System.Drawing.Point(298, 274);
            this.tempGraph.Margin = new System.Windows.Forms.Padding(0);
            this.tempGraph.Name = "tempGraph";
            this.tempGraph.Size = new System.Drawing.Size(298, 275);
            this.tempGraph.TabIndex = 5;
            // 
            // altitudeGraph
            // 
            this.altitudeGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.altitudeGraph.BackColor = System.Drawing.Color.Gainsboro;
            this.altitudeGraph.Location = new System.Drawing.Point(0, 0);
            this.altitudeGraph.Margin = new System.Windows.Forms.Padding(0);
            this.altitudeGraph.Name = "altitudeGraph";
            this.altitudeGraph.Size = new System.Drawing.Size(298, 274);
            this.altitudeGraph.TabIndex = 1;
            // 
            // gyroChart
            // 
            this.gyroChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gyroChart.BackColor = System.Drawing.Color.White;
            this.gyroChart.Location = new System.Drawing.Point(596, 0);
            this.gyroChart.Margin = new System.Windows.Forms.Padding(0);
            this.gyroChart.Name = "gyroChart";
            this.gyroChart.Size = new System.Drawing.Size(300, 274);
            this.gyroChart.TabIndex = 3;
            // 
            // positionGraph
            // 
            this.positionGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.positionGraph.BackColor = System.Drawing.Color.Gainsboro;
            this.positionGraph.Location = new System.Drawing.Point(298, 0);
            this.positionGraph.Margin = new System.Windows.Forms.Padding(0);
            this.positionGraph.Name = "positionGraph";
            this.positionGraph.Size = new System.Drawing.Size(298, 274);
            this.positionGraph.TabIndex = 2;
            // 
            // accelGraph
            // 
            this.accelGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accelGraph.BackColor = System.Drawing.Color.Gainsboro;
            this.accelGraph.Location = new System.Drawing.Point(0, 274);
            this.accelGraph.Margin = new System.Windows.Forms.Padding(0);
            this.accelGraph.Name = "accelGraph";
            this.accelGraph.Size = new System.Drawing.Size(298, 275);
            this.accelGraph.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(894, 591);
            this.Controls.Add(this.graphPanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Estes Ground Station";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Leave += new System.EventHandler(this.MainWindow_Leave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.graphPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label port;
        private System.Windows.Forms.TextBox portLabel;
        private System.Windows.Forms.Button serialConnect;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputName;
        private System.Windows.Forms.Button startTelemetry;
        private RealTimeChart altitudeGraph;
        private RealTimeChart positionGraph;
        private RealTimeChart gyroChart;
        private System.Windows.Forms.TableLayoutPanel graphPanel;
        private RealTimeChart vbatGraph;
        private RealTimeChart tempGraph;
        private RealTimeChart accelGraph;
        private System.Windows.Forms.Label gpsSatCount;
        private System.Windows.Forms.Label gpsFixLabel;
        private System.Windows.Forms.Timer radioChecker;
        private System.Windows.Forms.Button loadButton;
    }
}


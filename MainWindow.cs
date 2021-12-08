using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO.Ports;
using System.Collections.Generic;
using System.IO;

namespace Estes_GSW
{
    public partial class MainWindow : Form
    {
        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
                DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
        }

        List<string> allPackets;
        SerialPort serialPort;
        Random r;

        public MainWindow()
        {
            InitializeComponent();

            r = new Random();
            altitudeGraph.setTitle("Altitude");
            positionGraph.setTitle("GPS Position");
            gyroChart.setTitle("Gyroscope Rates");
            accelGraph.setTitle("Acceleration");
            tempGraph.setTitle("Temperature");
            vbatGraph.setTitle("Battery Voltage");

            altitudeGraph.AddChart("Milliseconds", "Height", "GPS", SeriesChartType.FastLine);
            altitudeGraph.AddLineToChart("chart0", "Press", SeriesChartType.FastLine);

            positionGraph.AddChart("Milliseconds", "Degrees", "Lat", SeriesChartType.FastLine);
            positionGraph.AddLineToChart("chart0", "Long", SeriesChartType.FastLine);

            gyroChart.AddChart("Milliseconds", "Radian Rate", "X", SeriesChartType.FastLine);
            gyroChart.AddLineToChart("chart0", "Y", SeriesChartType.FastLine);
            gyroChart.AddLineToChart("chart0", "Z", SeriesChartType.FastLine);

            accelGraph.AddChart("Milliseconds", "m / s^2", "X", SeriesChartType.FastLine);
            accelGraph.AddLineToChart("chart0", "Y", SeriesChartType.FastLine);
            accelGraph.AddLineToChart("chart0", "Z", SeriesChartType.FastLine);

            tempGraph.AddChart("Milliseconds", "Celsuis", "Temp", SeriesChartType.FastLine);

            vbatGraph.AddChart("Milliseconds", "Voltage", "Vbat", SeriesChartType.FastLine);

            allPackets = new List<string>();
            serialPort = new SerialPort();
            serialPort.BaudRate = 9600;
            serialPort.ReadTimeout = 100;
            serialPort.WriteTimeout = 100;
        }

        //int time = 0;
        //bool connect = false;
        private void checkRadio(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen) return;
            //if (!connect) return;

            try
            {
                //serialPort.BytesToRead > 0
                //time % 500 == 0
                if (serialPort.BytesToRead > 0)
                {
                    string packet = serialPort.ReadLine();

                    allPackets.Add(packet);

                    string[] items = packet.Split(',');

                    AddNewData(items);
                    //AddRandomData();

                    gpsFixLabel.Text = "GPS Fix: " + packet[1];
                    gpsSatCount.Text = "GPS Sats: " + packet[5];
                }
            }
            catch (TimeoutException) { }

            //time += 10;
        }

        private void serialConnect_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                serialPort.PortName = portLabel.Text;
                serialPort.Open();
                serialConnect.Text = "Disconnect";
                allPackets.Clear();

                altitudeGraph.Clear();
                positionGraph.Clear();
                gyroChart.Clear();
                accelGraph.Clear();
                tempGraph.Clear();
                vbatGraph.Clear();
            }
            else
            {
                serialPort.Close();
                serialConnect.Text = "Connect";
            }

            //connect = !connect;
        }

        private void AddNewData(string[] data) 
        {
            try
            {
                int time = Convert.ToInt32(data[0]);

                altitudeGraph.AddPoint(time, Convert.ToDouble(data[4]), "GPS");
                altitudeGraph.AddPoint(time, Convert.ToDouble(data[7]), "Press");

                positionGraph.AddPoint(time, Convert.ToDouble(data[2]), "Lat");
                positionGraph.AddPoint(time, Convert.ToDouble(data[3]), "Long");

                gyroChart.AddPoint(time, Convert.ToDouble(data[9]), "X");
                gyroChart.AddPoint(time, Convert.ToDouble(data[10]), "Y");
                gyroChart.AddPoint(time, Convert.ToDouble(data[11]), "Z");

                accelGraph.AddPoint(time, Convert.ToDouble(data[12]), "X");
                accelGraph.AddPoint(time, Convert.ToDouble(data[13]), "Y");
                accelGraph.AddPoint(time, Convert.ToDouble(data[14]), "Z");

                tempGraph.AddPoint(time, Convert.ToDouble(data[8]), "Temp");

                vbatGraph.AddPoint(time, Convert.ToDouble(data[6]), "Vbat");
            }
            catch { }
        }

        /*private void AddRandomData()
        {
            try
            {
                altitudeGraph.AddPoint(time, Convert.ToDouble(r.NextDouble()), "GPS");
                altitudeGraph.AddPoint(time, Convert.ToDouble(r.NextDouble()), "Press");

                positionGraph.AddPoint(time, Convert.ToDouble(r.NextDouble()), "Lat");
                positionGraph.AddPoint(time, Convert.ToDouble(r.NextDouble()), "Long");

                gyroChart.AddPoint(time, Convert.ToDouble(r.NextDouble()), "X");
                gyroChart.AddPoint(time, Convert.ToDouble(r.NextDouble()), "Y");
                gyroChart.AddPoint(time, Convert.ToDouble(r.NextDouble()), "Z");

                accelGraph.AddPoint(time, Convert.ToDouble(r.NextDouble()), "X");
                accelGraph.AddPoint(time, Convert.ToDouble(r.NextDouble()), "Y");
                accelGraph.AddPoint(time, Convert.ToDouble(r.NextDouble()), "Z");

                tempGraph.AddPoint(time, Convert.ToDouble(r.NextDouble()), "Temp");

                vbatGraph.AddPoint(time, Convert.ToDouble(r.NextDouble()), "Vbat");
            }
            catch { }
        }*/

        private void saveButton_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(outputName.Text + ".csv", allPackets);
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort.Close();
        }

        private void MainWindow_Leave(object sender, EventArgs e)
        {
            serialPort.Close();
        }

        private void startTelemetry_Click(object sender, EventArgs e)
        {
            if (startTelemetry.Text == "Start Telemetry")
            {
                serialPort.WriteLine("0\r");
                startTelemetry.Text = "Stop Telemetry";
            }
            else
            {
                serialPort.WriteLine("1\r");
                startTelemetry.Text = "Start Telemetry";
            }
        }

        private void loadData(object sender, EventArgs e)
        {
            allPackets.Clear();
            altitudeGraph.Clear();
            positionGraph.Clear();
            gyroChart.Clear();
            accelGraph.Clear();
            tempGraph.Clear();
            vbatGraph.Clear();

            string[] data = File.ReadAllLines(outputName.Text + ".csv");

            foreach (string line in data)
            {
                AddNewData(line.Split(','));
            }
        }
    }
}

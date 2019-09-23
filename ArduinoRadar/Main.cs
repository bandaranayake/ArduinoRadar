using System.Drawing;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace ArduinoRadar
{
    public partial class Main : Form
    {
        SerialPort serialPort;
        Radar radar;

        public Main()
        {
            InitializeComponent();
            cmbxPort.Items.AddRange(SerialPort.GetPortNames());
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            MatchCollection mc = Regex.Matches(indata, "-?[0-9][0-9]*,[0-9][0-9]*");

            if (mc.Count > 0)
            {
                radar.update(mc[mc.Count - 1].Value);
                pbxRadar.Image = radar.draw();
                Thread.Sleep(200);
            }
        }

        private void btnStart_Click(object sender, System.EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
            serialPort = new SerialPort(cmbxPort.SelectedItem.ToString());
            serialPort.BaudRate = int.Parse(txtBaudRate.Text);
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            serialPort.Open();
            radar = new Radar(25, 800, 800, Color.FromArgb(150, 40, 70, 40), Color.Black);
        }
    }
}

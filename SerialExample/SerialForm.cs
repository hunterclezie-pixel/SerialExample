using System.IO.Ports;
using System.Xml.Serialization;

namespace SerialExample
{
    public partial class SerialForm : Form
    {
        public SerialForm()
        {
            InitializeComponent();
        }

        SerialPort _serialPort = new SerialPort();
        void SerialPortSetup()
        {
            _serialPort.Close();
            _serialPort = new SerialPort();
            _serialPort.PortName = "COM9"; // Set your COM port here
            _serialPort.BaudRate = 9600; // Set your baud rate here
            _serialPort.DataBits = 8;
            _serialPort.Parity = Parity.None;
            //_serialPort.StopBits = StopBits.One;

        }

        void SerialConnect()
        {
            _serialPort.Close();
            _serialPort.Open();
        }

        void SerialSend()
        {
            _serialPort.Write("Hello World");
        }

        void SerialRead()
        {
            SerialTextBox.Text = _serialPort.ReadExisting();
        }

        void GetSerialPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            PortsComboBox.Items.Clear();
            foreach (string port in ports)
            {
                PortsComboBox.Items.Add(port);
            }
        }

        string GetSelectedPort()
        {
            return PortsComboBox.SelectedItem?.ToString() ?? "";
        }

        void UpdatePortSelection()
        {
            foreach (string port in SerialPort.GetPortNames())
            {
                PortsComboBox.Items.Add(port);
            }

            if (PortsComboBox.Items.Count > 0)
            { 
                PortsComboBox.SelectedIndex = 0; // Select the first port by default
            }

        }


        // Event Handlers Below Here ---------------------------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            SerialPortSetup();
            SerialConnect();
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            SerialSend();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            SerialRead();
        }

        private void StatusTimer_Tick(object sender, EventArgs e)
        {
            string portName;
            int rxBuffer, txBuffer;
            if (_serialPort.IsOpen)
            {
                portName = _serialPort.PortName;
                rxBuffer = _serialPort.BytesToRead;
                txBuffer = _serialPort.BytesToWrite;
            }
            else
            {
                portName = "none";
                rxBuffer = 0;
                txBuffer = 0;
            }

            StatusLabel.Text = $"Port: {portName} tx:{txBuffer} rx:{rxBuffer}";
        }

        private void StatusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
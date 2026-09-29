using System.IO.Ports;

namespace SerialExample
{
    public partial class SerialForm : Form
    {
        public SerialForm()
        {
            InitializeComponent();
        }

        private SerialPort _serialPort;
        void SerialPortSetup()
        {
            _serialPort = new SerialPort();
            _serialPort.PortName = "COM9"; // Set your COM port here
            _serialPort.BaudRate = 9600; // Set your baud rate here
            _serialPort.DataBits = 8;
            _serialPort.Parity = Parity.None;
            _serialPort.StopBits = StopBits.One;
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }


        // Event Handlers Below Here ---------------------------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            SerialPortSetup();
        }
    }
}

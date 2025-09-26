namespace GUI_arduino
{
    public partial class MainPage : ContentPage
    {
        private arduino_comm _arduino = new();
        public MainPage()
        {
            InitializeComponent();

            PortPicker.ItemsSource = new List<string> { "COM1", "COM2", "COM3" };
            BaudPicker.ItemsSource = new List<string> { "9600", "19200", "57600", "115200" };
        }

        private void ConnectButton_Clicked(object sender, EventArgs e)
        {
            _arduino.Connect("COM5", 9600);
        }

        private void DisconnectButton_Clicked(object sender, EventArgs e)
        {
            _arduino.Disconnect();
        }

        private void SendButton_Clicked(object sender, EventArgs e)
        {
            _arduino.Send(CommEntry.Text);
        }
    }
}

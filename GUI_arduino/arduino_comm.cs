using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
namespace GUI_arduino
{
    internal class arduino_comm
    {

        private SerialPort? _serialPort;

        public void Connect(string portName, int baudRate = 9600)
        {
            if (_serialPort?.IsOpen == true)
                _serialPort.Close();

            _serialPort = new SerialPort(portName, baudRate)
            {
                ReadTimeout = 500,
                WriteTimeout = 500
            };
            _serialPort.Open();
        }

        public void Send(string data)
        {
            if (_serialPort?.IsOpen == true)
                _serialPort.WriteLine(data);
        }

        public string? Read()
        {
            if (_serialPort?.IsOpen == true)
                return _serialPort.ReadLine();

            return null;
        }

        public void Disconnect()
        {
            if (_serialPort?.IsOpen == true)
                _serialPort.Close();
        }
    }
}

using System.IO.Ports;

namespace ActuatorsTest.Data
{
    public class Cereal : ICereal
    {
        public List<string> GetCommunicationPorts()
        {
            return SerialPort.GetPortNames().ToList();
        }

        public void SendData()
        {



            //throw new NotImplementedException();
        }


        public void SendDataSample(byte bit, string comPort)
        {
            //Create the communication port with factory settings
            SerialPort port = new SerialPort(comPort, 115200, Parity.None, 8, StopBits.One);


            port.Open();

            port.Write(new byte[] { bit }, 0, 3);

            port.Close();

        }


        
    }
}

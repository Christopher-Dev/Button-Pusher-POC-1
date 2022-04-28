using System.IO.Ports;

namespace ActuatorsTest.Data
{
    public class Cereal : ICereal
    {
        public void SendData()
        {



            //throw new NotImplementedException();
        }


        public void SendDataSample(byte bit)
        {

            var q = new List<string>();

            //Local variable to check ports available
            foreach (var item in SerialPort.GetPortNames())
            {
                q.Add(item);
            }
            
            //Create the communication port with factory settings
            SerialPort port = new SerialPort($"COM1", 115200, Parity.None, 8, StopBits.One);


            port.Open();

            port.Write(new byte[] {0x0A, 0xE2, 0xFF},0,3);

            port.Close();
        
        }


        
    }
}

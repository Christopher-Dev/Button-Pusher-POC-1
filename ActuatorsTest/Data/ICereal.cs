namespace ActuatorsTest.Data
{
    public interface ICereal
    {
        public void SendData();
        public void SendDataSample(byte bit, string ComPort);

        public List<string> GetCommunicationPorts();
    }
}

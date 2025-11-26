using EchoTspServer;

namespace NetSdrClientApp
{
    public class DummyClassToTest
    {
        public void CreateServer()
        {
            var server = new EchoServer(5000);
        }
    }
}
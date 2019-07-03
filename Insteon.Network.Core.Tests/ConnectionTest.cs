using Microsoft.VisualStudio.TestTools.UnitTesting;
using Insteon.Network;

namespace Insteon.Network.Core.Tests
{
    /// <summary>
    /// Some simple connection tests
    /// </summary>
    [TestClass]
    public class ConnectionTest
    {

        /// <summary>
        /// Attemps to connect to the INSTEON network via USB/Serial connection
        /// </summary>
        [TestMethod]
        public void TestSerialConnection()
        {
            var network = new InsteonNetwork();
            var connections = network.GetAvailableSerialConnections();

            foreach(var connection in connections)
            {
                if(!network.IsConnected)
                {
                    network.Connect(connection);
                }

                Assert.IsTrue(network.IsConnected);
            }
        }

        /// <summary>
        /// Try testing connectivity to the old INSTEON hub. I can't really test this as I don't have an old hub.
        /// </summary>
        [TestMethod]
        public void TestNetworkConnection()
        {
            var network = new InsteonNetwork();
            var connections = network.GetAvailableNetworkConnections(true);

            foreach(var connection in connections)
            {
                if(!network.IsConnected)
                {
                    network.Connect(connection);
                }
            }
        }
    }
}

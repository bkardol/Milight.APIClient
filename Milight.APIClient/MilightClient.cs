using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Milight.APIClient
{
    //https://www.home-assistant.io/components/limitlessled/
    internal class MilightClient
    {
        private readonly UdpClient _udpClient;
        private readonly IPAddress _ipAddress;
        private readonly int _portNumber;

        public MilightClient()
        {
        }

        public MilightClient(IPAddress ipAddress, int portNumber)
        {
            _ipAddress = ipAddress;
            _portNumber = portNumber;
        }

        /// <summary>
        /// Turns on all groups.
        /// </summary>
        public void TurnOn()
        {

        }

        /// <summary>
        /// Turns on a group.
        /// </summary>
        /// <param name="group">The number of the group to turn on.</param>
        public void TurnOn(int group)
        {

        }

        /// <summary>
        /// Turns off all groups.
        /// </summary>
        public void TurnOff()
        {

        }

        /// <summary>
        /// Turns off a group.
        /// </summary>
        /// <param name="group">The number of the group to turn off.</param>
        public void TurnOff(int group)
        {

        }

        /// <summary>
        /// Sets the disco to the next mode.
        /// </summary>
        public void NextDiscoMode()
        {

        }

        /// <summary>
        /// Sets the speed of the disco faster.
        /// </summary>
        public void SetDiscoSpeedFaster()
        {

        }

        /// <summary>
        /// Sets the speed of the disco slower.
        /// </summary>
        public void SetDiscoSpeedSlower()
        {

        }

        private async Task SendCommands(byte[] commands) =>
            await _udpClient?.SendAsync(commands, commands.Length);
    }
}

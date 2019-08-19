using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Milight.APIClient
{
    internal class MilightClient
    {
        private const byte _suffix1 = 0x00;
        private const byte _suffix2 = 0x55;

        private readonly UdpClient _udpClient;

        private readonly IPAddress _ipAddress;
        private readonly int _portNumber;

        private IDictionary<Zone, Command> _zoneOnMapping = new Dictionary<Zone, Command>
        {
            [Zone.All] = Command.AllOn,
            [Zone.One] = Command.Group1On,
            [Zone.Two] = Command.Group2On,
            [Zone.Three] = Command.Group3On,
            [Zone.Four] = Command.Group4On
        };
        private IDictionary<Zone, Command> _zoneOffMapping = new Dictionary<Zone, Command>
        {
            [Zone.All] = Command.AllOff,
            [Zone.One] = Command.Group1Off,
            [Zone.Two] = Command.Group2Off,
            [Zone.Three] = Command.Group3Off,
            [Zone.Four] = Command.Group4Off
        };

        public MilightClient()
        {
        }

        public MilightClient(IPAddress ipAddress, int portNumber)
        {
            _ipAddress = ipAddress;
            _portNumber = portNumber;
        }

        /// <summary>
        /// Turns on a zone.
        /// </summary>
        public async Task TurnOn(Zone zone) => await SendCommands((byte)_zoneOnMapping[zone], _suffix1, _suffix2);

        /// <summary>
        /// Turns off a zone.
        /// </summary>
        /// <param name="zone">The zone to turn off.</param>
        public async Task TurnOff(Zone zone) => await SendCommands((byte)_zoneOffMapping[zone], _suffix1, _suffix2);

        /// <summary>
        /// Sets the disco to the next mode.
        /// </summary>
        public async Task NextDiscoMode() => await SendCommands((byte)Command.DiscoMode, _suffix1, _suffix2);

        /// <summary>
        /// Sets the speed of the disco faster.
        /// </summary>
        public async Task SetDiscoSpeedFaster() => await SendCommands((byte)Command.DiscoSpeedUp, _suffix1, _suffix2);

        /// <summary>
        /// Sets the speed of the disco slower.
        /// </summary>
        public async Task SetDiscoSpeedSlower() => await SendCommands((byte)Command.DiscoSpeedDown, _suffix1, _suffix2);

        private async Task SendCommands(params byte[] commands) =>
            await _udpClient?.SendAsync(commands, commands.Length);
    }
}

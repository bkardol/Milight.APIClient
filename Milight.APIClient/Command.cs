namespace Milight.APIClient
{
    /// <summary>
    /// The following enum exposes all available commands tohrough the Milight bridge.
    /// Always send 3 byte commands: <your_command>, 0x00, 0x55. 
    /// Exceptions on this 3 byte sequence (like color) are described below.
    /// </summary>
    internal enum Command : byte
    {
        WhiteAllOn = 0x35,
        WhiteAllOff = 0x39,

        BrightnessDown = 0x34,
        BrightnessUp = 0x3C,

        // (RGBW ONLY) - 100ms before send the Group On command. Set the color with 0x40, followed by 0x00(Violet) - 0xFF(Lavendar), end with 0x55
        Color = 0x40,

        AllOff = 0x41,
        AllOn = 0x42,

        DiscoSpeedDown = 0x43,
        DiscoSpeedUp = 0x44,

        Group1On = 0x45,
        Group1Off = 0x46,

        Group2On = 0x47,
        Group2Off = 0x48,

        Group3On = 0x49,
        Group3Off = 0x4A,

        Group4On = 0x4B,
        Group4Off = 0x4C,

        DiscoMode = 0x4D,

        // (RGBW ONLY) - 100ms before send the Group On command. Set the brightness with 0x4E, followed by 0x02(min) - 0x1B(max), end with 0x55
        Brightness = 0x4E,

        // (NO RGBW) - 100ms before send the AllOff command.
        AllNightMode = 0xC1,

        // 100ms before send the AllOn command
        AllWhite = 0xC2,

        // 100ms before send the Group1On command
        Group1White = 0xC5,

        // (NO RGBW) - 100ms before send the Group1Off command.
        Group1NightMode = 0xC6,

        // 100ms before send the Group2On command
        Group2White = 0xC7,

        // (NO RGBW) - 100ms before send the Group2Off command.
        Group2NightMode = 0xC8,

        // 100ms before send the Group3On command
        Group3White = 0xC9,

        // (NO RGBW) - 100ms before send the Group3Off command.
        Group3NightMode = 0xCA,

        // 100ms before send the Group4On command
        Group4White = 0xCB,

        // (NO RGBW) - 100ms before send the Group4Off command.
        Group4NightMode = 0xCC,
    }
}

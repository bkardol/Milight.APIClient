namespace Milight.APIClient
{
    public enum Commands : byte
    {       
        AllOn = 0x42,
        AllOff = 0x41,
        AllWhite = 0xC2,

        BrightnessUp = 0x3C,
        BrightnessDown = 0x34,

        Group1On = 0x45,
        Group1Off = 0x46,
        Group1White = 0xC5,

        Group2On = 0x47,
        Group2Off = 0x48,
        Group2White = 0xC7,

        Group3On = 0x49,
        Group3Off = 0x4A,
        Group3White = 0xC9,

        Group4On = 0x4B,
        Group4Off = 0x4C,
        Group4White = 0xCB,

        DiscoSpeedUp = 0x44,
        DiscoSpeedDown = 0x43,

        DiscoNext = 0x4D,

        RGBColour = 0x20
    }
}

namespace Enums
{
    [Flags]
    public enum Days
    {
        None = 0,                   // 0000 0000
        Monday = 1,                 // 0000 0001
        Tuesday = 2,                // 0000 0010
        Wednesday = 4,              // 0000 0100
        Thursday = 8,               // 0000 1000
        Friday = 16,                // 0001 0000
        Saturday = 32,              // 0010 0000
        Sunday = 64,                // 0100 0000
        Weekend = Saturday | Sunday // 0110 0000
    }
}

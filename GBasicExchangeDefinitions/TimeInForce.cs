namespace GBasicExchangeDefinitions
{
    /// <summary>
    /// Time in force type enum.
    /// </summary>
    public enum TimeInForce
    {
        ///<summary> Good Till Cancel.</summary>
        GTC,
        ///<summary> Immediate or Cancel.</summary>
        IOC,
        ///<summary> Fill or Kill.</summary>
        FOK,
        ///<summary> Good Till Crossing (Post Only).</summary>
        GTX
    }
}

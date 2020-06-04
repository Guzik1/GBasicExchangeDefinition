namespace GBasicExchangeDefinitions
{
    /// <summary>
    /// Order type enum.
    /// </summary>
    public enum OrderType
    {
        /// <summary> Limit order type. </summary>
        LIMIT,
        /// <summary> Market order type. </summary>
        MARKET,
        /// <summary> Stop limit order type. </summary>
        STOP,
        /// <summary> Stop market order type. </summary>
        STOP_MARKET,
        /// <summary> Take profit limit order type. </summary>
        TAKE_PROFIT,
        /// <summary> Take profit market order type. </summary>
        TAKE_PROFIT_MARKET,
        /// <summary> Trailing stop market order type. </summary>
        TRAILING_STOP_MARKET
    }
}

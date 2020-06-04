namespace GBasicExchangeDefinitions
{
    /// <summary>
    /// Order status enum.
    /// </summary>
    public enum OrderStatus
    {
        /// <summary> New order. </summary>
        NEW,
        /// <summary> Partially filled order. </summary>
        PARTIALLY_FILLED,
        /// <summary> Filled order. </summary>
        FILLED,
        /// <summary> Canceled order. </summary>
        CANCELED,
        /// <summary> Rejected order. </summary>
        REJECTED,
        /// <summary> Expired order. </summary>
        EXPIRED
    }
}

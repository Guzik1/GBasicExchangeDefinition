namespace GBasicExchangeDefinitions
{
    /// <summary>
    /// Kline/candlestick chart intervals enum.
    /// </summary>
    public enum CandlestickInterval
    {
        /// <summary> 1 minute. </summary>
        m1 = 60,
        /// <summary> 3 minute. </summary>
        m3 = 180,
        /// <summary> 5 minute. </summary>
        m5 = 300,
        /// <summary> 15 minute. </summary>
        m15 = 900,
        /// <summary> 30 minute. </summary>
        m30 = 1800,
        /// <summary> 1 hour. </summary>
        h1 = 3600,
        /// <summary> 2 hours. </summary>
        h2 = 7200,
        /// <summary> 4 hours. </summary>
        h4 = 14400,
        /// <summary> 6 hours. </summary>
        h6 = 21600,
        /// <summary> 12 hours. </summary>
        h12 = 43200,
        /// <summary> 1 day. </summary>
        d1 = 86400,
        /// <summary> 3 days. </summary>
        d3 = 259200,
        /// <summary> 1 week. </summary>
        w1 = 604800,

        // binance
        /// <summary> 1 month. </summary>
        M1 = 2628000
    }

    /// <summary>
    /// Extension method for Cnadlestick interval enum.
    /// </summary>
    public static class CandlestickIntervalExtension
    {
        /// <summary>
        /// Get count of second in selected interval.
        /// </summary>
        /// <param name="resolution">Candlestick interval object.</param>
        /// <returns>Count of second.</returns>
        public static int GetSecond(this CandlestickInterval resolution)
        {
            return (int)resolution;
        }

        /// <summary>
        /// Convert enum value to string.
        /// </summary>
        /// <param name="resolution">Candlestick interval object.</param>
        /// <returns>Object converting to string.</returns>
        public static string ToString(this CandlestickInterval resolution)
        {
            string res = resolution.ToString();
            char first = res[0];

            return res.Substring(1) + first;
        }
    }
}

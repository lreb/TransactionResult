using System.Collections.Generic;
using static StandardTransaction.Enum.ResultEnum;

namespace StandardTransaction.Model
{
    /// <summary>
    /// Common response
    /// </summary>
    public class StandardResponse
    {
        /// <summary>
        /// ERROR, SUCCESS, WARNING
        /// </summary>
        public Result Code { get; set; }
        /// <summary>
        /// Is true if transaction execution succesds
        /// </summary>
        public bool Success { get; set; } = false;
        /// <summary>
        /// Is true if transaction execution fails
        /// </summary>
        public bool Fail { get; set; } = false;
        /// <summary>
        /// Is true if transaction execution partial succeeds
        /// </summary>
        public bool Warning { get; set; } = false;
        /// <summary>
        /// Contains the message result of the transaction execution
        /// </summary>
        public string Message { get; set; } = string.Empty;
        /// <summary>
        /// Stores the data (object) result of the transaction execution
        /// </summary>
        public object? Data { get; set; }
        /// <summary>
        /// Stores an ID/Reference for the event that was executed
        /// </summary>
        public string EventReference { get; set; } = string.Empty;

        /// <summary>
        /// Collection of detailed messages <seealso cref="ProcessDetail"/>
        /// </summary>
        public List<TransactionDetail> MessageDetail { get; set; } = new List<TransactionDetail>();
    }
}

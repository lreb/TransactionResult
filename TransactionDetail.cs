using static StandardTransaction.Enum.ResultEnum;

namespace StandardTransaction
{
    /// <summary>
    /// common treansaction detail data
    /// </summary>
    public class TransactionDetail
    {
        /// <summary>
        /// ERROR, SUCCESS, WARNING
        /// </summary>
        public Result type;
        /// <summary>
        /// Stores an ID for the transaction that was executed
        /// </summary>
        public string key;
        /// <summary>
        /// Contains the message result of the transaction execution
        /// </summary>
        public string message;
        /// <summary>
        /// Contains the message detail result of the transaction execution
        /// </summary>
        public string messageDetail;

        /// <summary>
        /// Constructor with fields
        /// </summary>
        /// <param name="key">Message identifier. It can be a code, serial number, etc.</param>
        /// <param name="message">Actual message to store, in short format</param>
        /// <param name="messageDetail">Extended/detailed message. It can be an exception text</param>
        public TransactionDetail(string key, string message, string messageDetail)
        {
            this.key = key;
            this.message = message;
            this.messageDetail = messageDetail;
        }

        /// <summary>
        /// Create a SUCCESS instance
        /// </summary>
        /// <param name="key"> Message identifier. It can be a code, serial number, etc.</param>
        /// <param name="message">Actual message to store, in short format</param>
        /// <param name="messageDetail">Extended/detailed message. It can be an exception text</param>
        /// <returns>Message Detail Instance</returns>
        public static TransactionDetail CreateSuccessMessage(string key, string message, string messageDetail)
        {
            TransactionDetail m = new TransactionDetail(key, message, messageDetail);
            m.SetType(Result.SUCCESS);
            return m;
        }

        /// <summary>
        /// Create an ERROR instance
        /// </summary>
        /// <param name="key">Message identifier. It can be a code, serial number, etc.</param>
        /// <param name="message">Actual message to store, in short format</param>
        /// <param name="messageDetail">Extended/detailed message. It can be an exception text</param>
        /// <returns></returns>
        public static TransactionDetail CreateErrorMessage(string key, string message, string messageDetail)
        {
            TransactionDetail m = new TransactionDetail(key, message, messageDetail);
            m.SetType(Result.ERROR);
            return m;
        }

        /// <summary>
        /// Create a WARNING instance
        /// </summary>
        /// <param name="key">Message identifier. It can be a code, serial number, etc.</param>
        /// <param name="message"> Actual message to store, in short format</param>
        /// <param name="messageDetail">Extended/detailed message. It can be an exception text</param>
        /// <returns>New Message Detail Instance</returns>
        public static TransactionDetail CreateWarningMessage(string key, string message, string messageDetail)
        {
            TransactionDetail m = new TransactionDetail(key, message, messageDetail);
            m.SetType(Result.WARNING);
            return m;
        }

        /// <summary>
        /// Gets the message key / identifier. It can be a serial number, process,
        /// </summary>
        /// <returns></returns>
        public string GetKey()
        {
            return key;
        }
        
        /// <summary>
        /// Get the message
        /// </summary>
        /// <returns></returns>
        public string GetMessage()
        {
            return message;
        }
        
        /// <summary>
        /// Gets the message details
        /// </summary>
        /// <returns></returns>
        public string GetMessageDetail()
        {
            return messageDetail;
        }
        
        /// <summary>
        /// Gets result type
        /// </summary>
        /// <returns></returns>
        public Result GetResultType()
        {
            return type;
        }
        
        /// <summary>
        /// Set key
        /// </summary>
        /// <param name="key"></param>
        public void SetKey(string key)
        {
            this.key = key;
        }

        /// <summary>
        /// Sets the message 
        /// </summary>
        /// <param name="message">Value to set</param>
        public void SetMessage(string message)
        {
            this.message = message;
        }

        /// <summary>
        /// Sets the message detail
        /// </summary>
        /// <param name="messageDetail">Value to set</param>
        public void SetMessageDetail(string messageDetail)
        {
            this.messageDetail = messageDetail;
        }

        /// <summary>
        /// Sets the message type 
        /// </summary>
        /// <param name="type">Value to set<see cref="Result"/></param>
        public void SetType(Result type)
        {
            this.type = type;
        }

        /// <summary>
        /// Evaluates if message is SUCCESS
        /// </summary>
        /// <returns>True for successful messages. False otherwise</returns>
        public bool IsSuccess()
        {
            return type == Result.SUCCESS;
        }

        /// <summary>
        /// Evaluates if message is ERROR 
        /// </summary>
        /// <returns>True for error messages. False otherwise</returns>
        public bool IsError()
        {
            return type == Result.ERROR;
        }

        /// <summary>
        /// Evaluates if message is WARNING
        /// </summary>
        /// <returns>True for warning messages. False otherwise</returns>
        public bool IsWarning()
        {
            return type == Result.WARNING;
        }

        /// <summary>
        /// Creates serializable representation of the message
        /// </summary>
        /// <returns>Message data as a string</returns>
        public string ToHtml()
        {
            string typeStr = "";
            switch (type)
            {
                case Result.SUCCESS:
                    typeStr = "SUCCESS";
                    break;
                case Result.ERROR:
                    typeStr = "ERROR";
                    break;
                case Result.WARNING:
                    typeStr = "WARNING";
                    break;
                default:
                    typeStr = "";
                    break;
            }
            return "<tr><td>" + typeStr + "</td><td>" + key + "</td><td>" + message + "</td><td>" + messageDetail + "</td>";
        }
    }
}

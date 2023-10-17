namespace StandardTransaction.Enum
{
    /// <summary>
    /// Common result types
    /// </summary>
    public class ResultEnum
    {
        /// <summary>
        /// Indicates the possible values for a process result
        /// </summary>
        public enum Result { ERROR, SUCCESS, WARNING }

        /// <summary>
        /// Defines possible message status
        /// </summary>
        public enum ResultType
        {
            SUCCESS, ERROR, WARNING, NONE, INFO
        }
    }
}

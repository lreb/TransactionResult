using System.Collections.Generic;
using StandardTransaction.Model;
using static StandardTransaction.Enum.ResultEnum;

namespace StandardTransaction
{

    public class TransactionResults : ITransactionResults
    {
        #region SUCCESS    

        /// <summary>
        /// Creates SUCCESS response
        /// </summary>
        /// <param name="message">SUCCESS mesage</param>
        /// <returns>Resturns SUCCESS response</returns>
        public StandardResponse CreateSuccessResponse(string message)
        {
            var result = new StandardResponse();
            InitializeResult(ref result, Result.SUCCESS);
            result.Message = message;
            return result;
        }

        /// <summary>
        /// Creates SUCCESS response
        /// </summary>
        /// <param name="message">SUCCESS mesage</param>
        /// <param name="data">SUCCESS response data</param>
        /// <returns>Resturns SUCCESS response</returns>
        public StandardResponse CreateSuccessResponse(string message, object data)
        {
            var result = new StandardResponse();
            InitializeResult(ref result, Result.SUCCESS);
            result.Message = message;
            result.Data = data;
            return result;
        }

        /// <summary>
        /// Creates SUCCESS response
        /// </summary>
        /// <param name="message">SUCCESS mesage</param>
        /// <param name="eventReference">SUCCESS internal reference</param>
        /// <returns>Resturns SUCCESS response</returns>
        public StandardResponse CreateSuccessResponse(string message, string eventReference)
        {
            var result = new StandardResponse();
            InitializeResult(ref result, Result.SUCCESS);
            result.Message = message;
            result.EventReference = eventReference;
            return result;
        }

        /// <summary>
        /// Creates SUCCESS response
        /// </summary>
        /// <param name="message">SUCCESS mesage</param>
        /// <param name="eventReference">SUCCESS internal reference</param>
        /// <param name="data">SUCCESS response data</param>
        /// <returns>Resturns SUCCESS response</returns>
        public StandardResponse CreateSuccessResponse(string message, string eventReference, object data)
        {
            var result = new StandardResponse();
            InitializeResult(ref result, Result.SUCCESS);
            result.Message = message;
            result.EventReference = eventReference;
            result.Data = data;
            return result;
        }

        #endregion

        #region FAIL

        /// <summary>
        /// Creates ERROR response
        /// </summary>
        /// <param name="message">ERROR mesage</param>
        /// <returns>Resturns ERROR response</returns>
        public StandardResponse CreateErrorResponse(string message)
        {
            var result = new StandardResponse();
            InitializeResult(ref result, Result.ERROR);
            result.Message = message;
            return result;
        }

        /// <summary>
        /// Creates ERROR response
        /// </summary>
        /// <param name="message">ERROR mesage</param>
        /// <param name="details">ERROR details message</param>
        /// <returns>Resturns ERROR response</returns>
        public StandardResponse CreateErrorResponse(string message, List<TransactionDetail> details)
        {
            var result = new StandardResponse();
            InitializeResult(ref result, Result.ERROR);
            result.Message = message;
            result.MessageDetail.AddRange(details);
            return result;
        }

        /// <summary>
        /// Creates ERROR response
        /// </summary>
        /// <param name="message">ERROR mesage</param>
        /// <param name="eventReference">ERROR internal reference</param>
        /// <returns>Resturns ERROR response</returns>
        public StandardResponse CreateErrorResponse(string message, string eventReference)
        {
            var result = new StandardResponse();
            InitializeResult(ref result, Result.ERROR);
            result.Message = message;
            result.EventReference = eventReference;
            return result;
        }

        /// <summary>
        /// Creates ERROR response
        /// </summary>
        /// <param name="message">ERROR mesage</param>
        /// <param name="eventReference">ERROR internal reference</param>
        /// <param name="details">ERROR details message</param>
        /// <returns>Resturns ERROR response</returns>
        public StandardResponse CreateErrorResponse(string message, string eventReference, List<TransactionDetail> details)
        {
            var result = new StandardResponse();
            InitializeResult(ref result, Result.ERROR);
            result.Message = message;
            result.EventReference = eventReference;
            result.MessageDetail.AddRange(details);
            return result;
        }

        #endregion

        #region WARNING

        /// <summary>
        /// Creates WARNINIG response
        /// </summary>
        /// <param name="message">WARNINIG mesage</param>
        /// <returns>Resturns WARNINIG response</returns>
        public StandardResponse CreateWarningResponse(string message)
        {
            var result = new StandardResponse();
            InitializeResult(ref result, Result.ERROR);
            result.Message = message;
            return result;
        }

        /// <summary>
        /// Creates WARNINIG response
        /// </summary>
        /// <param name="message">WARNINIG mesage</param>
        /// <param name="details">WARNINIG details message</param>
        /// <returns>Resturns WARNINIG response</returns>
        public StandardResponse CreateWarningResponse(string message, List<TransactionDetail> details)
        {
            var result = new StandardResponse();
            InitializeResult(ref result, Result.WARNING);
            result.Message = message;
            result.MessageDetail.AddRange(details);
            return result;
        }

        /// <summary>
        /// Creates WARNINIG response
        /// </summary>
        /// <param name="message">WARNINIG mesage</param>
        /// <param name="eventReference">WARNINIG internal reference</param>
        /// <returns>Resturns WARNINIG response</returns>
        public StandardResponse CreateWarningResponse(string message, string eventReference)
        {
            var result = new StandardResponse();
            InitializeResult(ref result, Result.WARNING);
            result.Message = message;
            result.EventReference = eventReference;
            return result;
        }

        /// <summary>
        /// Creates WARNINIG response
        /// </summary>
        /// <param name="message">WARNINIG mesage</param>
        /// <param name="eventReference">WARNINIG internal reference</param>
        /// <param name="details">WARNINIG details message</param>
        /// <returns>Resturns WARNINIG response</returns>
        public StandardResponse CreateWarningResponse(string message, string eventReference, List<TransactionDetail> details)
        {
            var result = new StandardResponse();
            InitializeResult(ref result, Result.WARNING);
            result.Message = message;
            result.EventReference = eventReference;
            result.MessageDetail.AddRange(details);
            return result;
        }

        #endregion

        private void InitializeResult(ref StandardResponse result, Result status)
        {
            result.Code = status;
            switch (result.Code)
            {
                case Result.ERROR:
                    result.Fail = true;
                    result.Success = false;
                    result.Warning = false;
                    break;
                case Result.SUCCESS:
                    result.Fail = false;
                    result.Success = true;
                    result.Warning = false;
                    break;
                case Result.WARNING:
                    result.Fail = false;
                    result.Success = false;
                    result.Warning = true;
                    break;
            }
        }
    }
}

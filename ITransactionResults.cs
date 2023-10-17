using System.Collections.Generic;
using StandardTransaction.Model;

namespace StandardTransaction
{
    /// <summary>
    /// Common transaction results
    /// </summary>
    public interface ITransactionResults
    {
        /// <summary>
        /// Creates SUCCESS response
        /// </summary>
        /// <param name="message">SUCCESS mesage</param>
        /// <returns>Resturns SUCCESS response</returns>
        StandardResponse CreateSuccessResponse(string message);

        /// <summary>
        /// Creates SUCCESS response
        /// </summary>
        /// <param name="message">SUCCESS mesage</param>
        /// <param name="data">SUCCESS response data</param>
        /// <returns>Resturns SUCCESS response</returns>
        StandardResponse CreateSuccessResponse(string message, object data);

        /// <summary>
        /// Creates SUCCESS response
        /// </summary>
        /// <param name="message">SUCCESS mesage</param>
        /// <param name="eventReference">SUCCESS internal reference</param>
        /// <returns>Resturns SUCCESS response</returns>
        StandardResponse CreateSuccessResponse(string message, string eventReference);
        /// <summary>
        /// Creates SUCCESS response
        /// </summary>
        /// <param name="message">SUCCESS mesage</param>
        /// <param name="eventReference">SUCCESS internal reference</param>
        /// <param name="data">SUCCESS response data</param>
        /// <returns>Resturns SUCCESS response</returns>
        StandardResponse CreateSuccessResponse(string message, string eventReference, object data);

        /// <summary>
        /// Creates ERROR response
        /// </summary>
        /// <param name="message">ERROR mesage</param>
        /// <returns>Resturns ERROR response</returns>
        StandardResponse CreateErrorResponse(string message);

        /// <summary>
        /// Creates ERROR response
        /// </summary>
        /// <param name="message">ERROR mesage</param>
        /// <param name="details">ERROR details message</param>
        /// <returns>Resturns ERROR response</returns>
        StandardResponse CreateErrorResponse(string message, List<TransactionDetail> details);

        /// <summary>
        /// Creates ERROR response
        /// </summary>
        /// <param name="message">ERROR mesage</param>
        /// <param name="eventReference">ERROR internal reference</param>
        /// <returns>Resturns ERROR response</returns>
        StandardResponse CreateErrorResponse(string message, string eventReference);

        /// <summary>
        /// Creates ERROR response
        /// </summary>
        /// <param name="message">ERROR mesage</param>
        /// <param name="eventReference">ERROR internal reference</param>
        /// <param name="details">ERROR details message</param>
        /// <returns>Resturns ERROR response</returns>
        StandardResponse CreateErrorResponse(string message, string eventReference, List<TransactionDetail> details);

        /// <summary>
        /// Creates WARNINIG response
        /// </summary>
        /// <param name="message">WARNINIG mesage</param>
        /// <returns>Resturns WARNINIG response</returns>
        StandardResponse CreateWarningResponse(string message);

        /// <summary>
        /// Creates WARNINIG response
        /// </summary>
        /// <param name="message">WARNINIG mesage</param>
        /// <param name="details">WARNINIG details message</param>
        /// <returns>Resturns WARNINIG response</returns>
        StandardResponse CreateWarningResponse(string message, List<TransactionDetail> details);

        /// <summary>
        /// Creates WARNINIG response
        /// </summary>
        /// <param name="message">WARNINIG mesage</param>
        /// <param name="eventReference">WARNINIG internal reference</param>
        /// <returns>Resturns WARNINIG response</returns>
        StandardResponse CreateWarningResponse(string message, string eventReference);

        /// <summary>
        /// Creates WARNINIG response
        /// </summary>
        /// <param name="message">WARNINIG mesage</param>
        /// <param name="eventReference">WARNINIG internal reference</param>
        /// <param name="details">WARNINIG details message</param>
        /// <returns>Resturns WARNINIG response</returns>
        StandardResponse CreateWarningResponse(string message, string eventReference, List<TransactionDetail> details);
    }
}

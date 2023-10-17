using StandardTransaction.Model;
using System;
using System.Collections.Generic;

namespace StandardTransaction.Example
{
    /// <summary>
    /// example implementation
    /// </summary>
    public class TestTransaction : ITestTransaction
    {
        public ITransactionResults _result { get; set; }
        public TestTransaction(ITransactionResults iResult)
        {
            _result = iResult;
        }

        public StandardResponse EventA()
        {
            try
            {
                // some validations, maybe some was not as expected, but we can continue (WARNING)
                // set as true
                var forceWarning = false;
                if (forceWarning)
                {
                    // register some warning messages
                    var detail = new TransactionDetail("INTERNAL_CODE", "message", "some detail");
                    var detailList = new List<TransactionDetail>();
                    detailList.Add(detail);

                    var warning = _result.CreateWarningResponse("WARNING", "12", detailList);
                    return warning;
                }


                // all steps were seccessed  (SUCCESS)

                var objectEvent = new { Id = 1, Value = "some" };

                var r = _result.CreateSuccessResponse("DI", "10", objectEvent);

                return r;
            }
            catch (Exception ex)
            {
                // event fails (ERROR)
                var detail = new TransactionDetail("INTERNAL_CODE", ex.Message, "some detail");

                var detailList = new List<TransactionDetail>();
                detailList.Add(detail);

                var r = _result.CreateErrorResponse("ERROR", "12", detailList);

                return r;
            }
        }
    }
}

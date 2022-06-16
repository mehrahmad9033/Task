using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Assignment.Application.DTOS
{
   public  class Investor_Response<T> : Response<T>
    {
           public new Investor_ValidationResultModel ValidationResultModel { get; set; }
    }
    public class Investor_ValidationResultModel
    {
        public int ErrorCode { get; set; } = (int)HttpStatusCode.BadRequest;
        public string Message { get; set; } = "Validation Failed.";

        public List<InvestorValidationError> Errors { get; }

        //public SubmissionValidationResultModel(ValidationResult validationResult = null)
        //{
        //    Errors = validationResult.Errors
        //        .Select(error => new SubmissionValidationError(error.PropertyName, error.ErrorMessage, error.ErrorCode, error.))
        //        .ToList();
        //}

        public Investor_ValidationResultModel(List<InvestorValidationError> ErrorsResult = null)
        {
            Errors = ErrorsResult;
        }
         
    }
    public class InvestorValidationError
    {
        public string Field { get; }
        public string Message { get; }
        public string Type { get; }
        public string Code { get; set; }
        public bool NeedConfirmation { get; set; }
        public bool TerminateCondition { get; set; }

        public InvestorValidationError(string field, string message)
        {
            Field = field != string.Empty ? field : null;
            Message = message;
        }

        public InvestorValidationError(string field, string message, string code = null, bool needConfirmation = false, bool terminateCondition = false)
        {
            Field = field != string.Empty ? field : null;
            Message = message;
            Code = code;
            NeedConfirmation = needConfirmation;
            TerminateCondition = terminateCondition;
        }
    }
}


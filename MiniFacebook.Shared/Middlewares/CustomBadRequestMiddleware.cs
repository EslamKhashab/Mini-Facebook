using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MiniFacebook.Shared.GlobalResponse;
using System.Collections.Generic;

public class CustomBadRequest : ValidationProblemDetails
{
    public CustomBadRequest(ActionContext context, HttpContext httpContext)
    {
        httpContext.Response.WriteAsync(new GlobalBadRequestResponse
        {
            ErrorMessage = "One or more validation errors occurred.",
            Success = false,
            Data = null,
            //ErrorCode = "One or more validation errors occurred.",
            Validation = ConstructErrorMessages(context)

        }.ToString());
    }

    private IDictionary<string, string[]> ConstructErrorMessages(ActionContext context)
    {
        foreach (var keyModelStatePair in context.ModelState)
        {
            var key = keyModelStatePair.Key;
            var errors = keyModelStatePair.Value.Errors;
            if (errors != null && errors.Count > 0)
            {
                if (errors.Count == 1)
                {
                    var errorMessage = GetErrorMessage(errors[0]);
                    Errors.Add(key, new[] { errorMessage });
                    return Errors;
                }
                else
                {
                    var errorMessages = new string[errors.Count];
                    for (var i = 0; i < errors.Count; i++)
                    {
                        errorMessages[i] = GetErrorMessage(errors[i]);
                    }

                    Errors.Add(key, errorMessages);
                    return Errors;
                }
            }
        }
        return null;
    }

    string GetErrorMessage(ModelError error)
    {
        return string.IsNullOrEmpty(error.ErrorMessage) ?
            "The input was not valid." :
            error.ErrorMessage;
    }
}
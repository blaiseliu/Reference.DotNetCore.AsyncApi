using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Reference.DotNetCore.AsyncApi.Filters
{
    public class NoteResultFilterAttribute:ResultFilterAttribute
    {
        public override async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            var resultFromAction = context.Result as ObjectResult;
            if (resultFromAction?.Value==null ||
                resultFromAction.StatusCode<200 ||
                resultFromAction.StatusCode>=300)
            {
                await next();
                return;
            }
            
            await next();
        }
    }
}

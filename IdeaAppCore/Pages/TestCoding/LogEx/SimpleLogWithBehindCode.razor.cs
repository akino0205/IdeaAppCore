using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;

namespace IdeaAppCore.Pages.TestCoding.LogEx
{
    public partial class SimpleLogWithBehindCode
    {
        //Blazor Log
        //참고 article https://www.c-sharpcorner.com/article/introduction-to-logging-framework-in-blazor-with-net-core/
        //source from https://github.com/jignesht24/Blazor/tree/master/BasicOfLogging https://github.com/BlazorExtensions/Logging
        [Inject]
        protected ILogger<Index> logger { get; set; }

        protected override void OnInitialized()
        {
            logger.LogInformation("OnInitSimpleLogWithBehindCode");
            logger.LogInformation("Log Test Success?!?!");
        }
    }
}

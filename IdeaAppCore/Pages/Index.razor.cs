using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;

namespace IdeaAppCore.Pages
{
    public partial class Index
    {
        //Blazor Log
        //참고 article https://www.c-sharpcorner.com/article/introduction-to-logging-framework-in-blazor-with-net-core/
        //source from https://github.com/jignesht24/Blazor/tree/master/BasicOfLogging https://github.com/BlazorExtensions/Logging
        [Inject]
        protected ILogger<Index> logger { get; set; }

        protected override void OnInitialized()
        {
            logger.LogDebug("OnInitIndex");
            logger.LogInformation("Log Test Success?!?!");
        }
    }
}

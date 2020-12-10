using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdeaAppCore.Pages
{
    public partial class Index
    {
        //Blazor 로깅 https://docs.microsoft.com/ko-kr/aspnet/core/blazor/fundamentals/logging?view=aspnetcore-5.0
        private readonly ILogger _logger;
        public Index(ILogger<Index> logger)
        {
            _logger = logger;
        }
        public string Message { get; set; }
        private int count1;
        private int count2;

        protected override void OnInitialized()
        {
            //전역변수로 로깅
            _logger.LogInformation($"전역변수 로그 Test - Count : {(++count1).ToString()} - Time : {DateTime.UtcNow.ToLongTimeString()}");

            //지역변수로 로깅
            //var logger = LoggerFactory.CreateLogger<Index>();
            //logger.LogInformation("지역변수 로그 Test" + (++count2).ToString());
        }
    }
}

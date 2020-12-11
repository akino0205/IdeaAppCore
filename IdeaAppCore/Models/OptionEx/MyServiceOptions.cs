using Microsoft.AspNetCore.Components;

namespace IdeaAppCore.Models
{
    public class MyServiceOptions
    {
        /* IOptionSnapshot, IOptionMonitor */
        public const string MyService = "MyService";
        
        public string strOption { get; set; }
        public int intOption { get; set; }
        public bool boolOption { get; set; }

        /* IConfigureNamedOptions */
        public const string strArrOption = "strArrOption";
        public const string strArrOption2 = "strArrOption2";

        public string item1 { get; set; }
        public string item2 { get; set; }
        public string item3 { get; set; }
    }
}

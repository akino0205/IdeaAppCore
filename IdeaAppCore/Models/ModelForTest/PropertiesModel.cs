using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace IdeaAppCore.Models
{
    public class LevelModel 
    {
        public int level { get; set; }
        public string text { get; set; }

    }

    public class PackModel
    {
        public string pack { get; set; }
        public string text { get; set; }
    }
}

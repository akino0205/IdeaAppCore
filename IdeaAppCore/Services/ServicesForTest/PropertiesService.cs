using IdeaAppCore.Models;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IdeaAppCore.Services
{
    public class PropertiesService : IPropertiesService
    {
        private readonly IWebHostEnvironment _env;
        private readonly string _pathOfManagerProperties;

        public PropertiesService(IWebHostEnvironment env)
        {
            _env = env;
            _pathOfManagerProperties = _env.ContentRootPath + "\\App_Data\\ManagerProperties.json";
        }

        public List<LevelModel> GetLevelList()
        {
            List<LevelModel> levelList = new List<LevelModel>();
            var jsonString = File.ReadAllText(_pathOfManagerProperties);
            JObject root = JObject.Parse(jsonString);
            foreach (var item in root["LevelList"])
            {
                var jProperty = item.ToObject<JProperty>();
                LevelModel model = new LevelModel();
                model.level = Int32.Parse(jProperty.Name);
                model.text = jProperty.Value.ToString();
                levelList.Add(model);
            }
            return levelList;
        }

        public List<PackModel> GetPackList()
        {
            List<PackModel> packList = new List<PackModel>();
            var jsonString = File.ReadAllText(_pathOfManagerProperties, Encoding.Unicode);
            JObject root = JObject.Parse(jsonString);
            foreach (var item in root["AddPackList"])
            {
                var jProperty = item.ToObject<JProperty>();
                PackModel model = new PackModel();
                model.text = jProperty.Name;
                model.pack = jProperty.Value.ToString();
                packList.Add(model);
            }
            return packList;
        }
    }
}

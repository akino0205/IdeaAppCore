using IdeaAppCore.Models;
using System.Collections.Generic;

namespace IdeaAppCore.Services
{
    public interface IPropertiesService
    {
        List<LevelModel> GetLevelList();
        List<PackModel> GetPackList();
    }
}
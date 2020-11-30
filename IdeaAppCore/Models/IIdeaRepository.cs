using System.Collections.Generic;
using System.Threading.Tasks;

namespace IdeaAppCore.Models
{
    public interface IIdeaRepository
    {
        Task<Idea> AddIdea(Idea Idea);
        Task<List<Idea>> GetIdeas();
    }
}

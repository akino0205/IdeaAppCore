using IdeaAppCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdeaAppCore.Pages
{
    public partial class Ideas
    {
        Idea idea = new Idea();

        private bool isShow = false;

        private List<Idea> ideas;

        protected override async Task OnInitializedAsync()
        {
            //Task.Delay(3000);
            ideas = await repository.GetIdeas();
        }

        private void btnCreate_Click()
        {
            isShow = true;
        }

        private void btnClose_Click()
        {
            isShow = false;
            idea = new Idea();
        }

        private async Task btnSave_Click()
        {
            await repository.AddIdea(idea);
            isShow = false;
            ideas = await repository.GetIdeas();
            idea = new Idea();
        }
    }
}

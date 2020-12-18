using IdeaAppCore.Models;
using IdeaAppCore.ViewModels;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Json;

namespace IdeaAppCore.Services.ServiceForTest.ConnectWebAPIEx
{
    public class GroupService
    {
        public AppSettings _appSettings { get; }
        public HttpClient _httpClient { get; }

        public GroupService(HttpClient httpClient, IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(_appSettings.UserManageAPIBaseAddress);
        }

        public PaginatedItemsViewModel<GroupItem> GetGroupItemsPaginated(int pageSize, int pageIndex)
        {
            var response = _httpClient.GetStringAsync($"/Group/GetGroupItems?pageSize={pageSize}&pageIndex={pageIndex}");
            response.Wait();

            var result = new PaginatedItemsViewModel<GroupItem>(0, 10, 0, null);
            if (response.IsCompleted)
            {
                result = JsonConvert.DeserializeObject<PaginatedItemsViewModel<GroupItem>>(response.Result);
            }
            return result;
        }

        public bool UpdateGroupItem(string code, GroupItem groupItem)
        {
            bool retValue = false;
            var response = _httpClient.PostAsJsonAsync($"/Group/{code}", groupItem);
            response.Wait();
            if (response.IsCompleted)
            {
                retValue = true;
            }
            return retValue;
        }
    }
}

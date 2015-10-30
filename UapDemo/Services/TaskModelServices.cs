using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UapDemo.Models;

namespace UapDemo.Services
{
    public class TaskModelServices
    {

        private const string WebServiceUrl = "http://taskmodel.azurewebsites.net/api/TaskModels/";

        public async Task<List<TaskModel>> GetTaskModelsAsync()
        {
            var httpClient = new HttpClient();

            var json = await httpClient.GetStringAsync(WebServiceUrl);

            var taskModels = JsonConvert.DeserializeObject<List<TaskModel>>(json);

            return taskModels;
        }

        public async Task<bool> AddTaskModelAsync(TaskModel taskModel)
        {
            var httpClient = new HttpClient();

            var json = JsonConvert.SerializeObject(taskModel);

            HttpContent httpContent = new StringContent(json);

            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var result = await httpClient.PostAsync(WebServiceUrl, httpContent);

            return result.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteTaskModelAsync(TaskModel taskModel)
        {
            var httpClient = new HttpClient();

            var response = await httpClient.DeleteAsync(WebServiceUrl + taskModel.Id);

            return response.IsSuccessStatusCode;
        }
    }
}

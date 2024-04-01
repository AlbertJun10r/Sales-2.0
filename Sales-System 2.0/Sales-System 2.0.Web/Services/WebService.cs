using Newtonsoft.Json;
using Sales_System_2._0.Application.Dtos.Base;
using Sales_System_2._0.Web.Models.Responses;

namespace Sales_System_2._0.Web.Services
{
    public class WebService : IWebService
    {
        private readonly HttpClient httpClient;

        public WebService()
        {
            httpClient = new HttpClient(new HttpClientHandler());
        }

        public BaseResponse<T> GetDataFromApi<T>(string apiUrl)
        {
            BaseResponse<T> responseData = new BaseResponse<T>();

            using (var response = httpClient.GetAsync(apiUrl).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                    responseData = JsonConvert.DeserializeObject<BaseResponse<T>>(apiResponse);

                    if (!responseData.success)
                    {
                        throw new ApplicationException(responseData.message.ToString());
                    }
                }
                else
                {
                    throw new ApplicationException("Error connecting to API.");
                }
            }

            return responseData;
        }

        public T PostDataToApi<T>(string apiUrl, DtoBase data)
        {
            try
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(data), System.Text.Encoding.UTF8, "application/json");

                using (var response = httpClient.PostAsync(apiUrl, content).Result)
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string apiResponse = response.Content.ReadAsStringAsync().Result;
                        var responseData = JsonConvert.DeserializeObject<BaseResponse<T>>(apiResponse);

                        if (!responseData.success)
                        {
                            throw new ApplicationException(responseData.message.ToString());
                        }

                        return responseData.data;
                    }
                    else
                    {
                        throw new ApplicationException("Error connecting to API.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
    }
}

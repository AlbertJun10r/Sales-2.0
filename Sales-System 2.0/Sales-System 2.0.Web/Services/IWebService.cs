using Sales_System_2._0.Application.Dtos.Base;
using Sales_System_2._0.Web.Models.Responses;

namespace Sales_System_2._0.Web.Services
{
    public interface IWebService
    {       
        public BaseResponse<T> GetDataFromApi<T>(string apiUrl);
        public T PostDataToApi<T>(string apiUrl, DtoBase data);
    }
}

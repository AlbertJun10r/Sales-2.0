using Microsoft.AspNetCore.Mvc;
using Sales_System_2._0.Application.Contract;
using Sales_System_2._0.Application.Dtos.Usuario;
using Sales_System_2._0.Web.Models.Responses;
using Sales_System_2._0.Web.Services;

namespace Sales_System_2._0.Web.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService usuarioService;
        private readonly string usuarioApiURLBase;
        private readonly IWebService webService;

        public UsuarioController(IUsuarioService storeService, IWebService webService, IConfiguration configuration)
        {
            this.usuarioService = storeService;
            this.webService = webService;
            this.usuarioApiURLBase = configuration["ApiSettings:UsuarioApiBaseUrl"];
        }
        public ActionResult Index()
        {
            try
            {
                BaseResponse<List<UsuarioViewResult>> responseData = webService.GetDataFromApi<List<UsuarioViewResult>>($"{usuarioApiURLBase}GetUsuarios");
                return View(responseData.data);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }

        // GET: UsuarioController/Details/5
        public ActionResult Details(int Id)
        {
            try
            {
                BaseResponse<UsuarioViewResult> responseData = webService.GetDataFromApi<UsuarioViewResult>($"{usuarioApiURLBase}GetUsuario?id={Id}");
                return View(responseData.data);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }

        // GET: UsuarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioDtoAdd usuarioDtoAdd)
        {
            var apiUrl = $"{usuarioApiURLBase}SaveUsuario";

            usuarioDtoAdd.FechaMod = DateTime.Now;
            usuarioDtoAdd.IdUsuarioMod = 1;

            try
            {
                webService.PostDataToApi<BaseResponse<UsuarioDtoAdd>>(apiUrl, usuarioDtoAdd);

                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }

        // GET: UsuarioController/Edit/5
        public ActionResult Edit(int Id)
        {
            try
            {
                BaseResponse<UsuarioViewResult> responseData = webService.GetDataFromApi<UsuarioViewResult>($"{usuarioApiURLBase}GetUsuario?id={Id}");
                return View(responseData.data);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }

        // POST: UsuarioController/Edit/5
        [HttpPut]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UsuarioDtoUpdate usuarioDtoUpdate)
        {
            var apiUrl = $"{usuarioApiURLBase}UpdateUsuario";

            usuarioDtoUpdate.FechaMod = DateTime.Now;
            usuarioDtoUpdate.IdUsuarioMod = 1;

            try
            {
                webService.PostDataToApi<BaseResponse<UsuarioDtoUpdate>>(apiUrl, usuarioDtoUpdate);

                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }

        public ActionResult Delete(int Id)
        {
            try
            {
                BaseResponse<UsuarioDtoRemove> responseData = webService.GetDataFromApi<UsuarioDtoRemove>($"{usuarioApiURLBase}GetUsuario?id={Id}");
                return View(responseData.data);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }

        [HttpDelete]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(UsuarioDtoRemove usuarioDtoRemove)
        {
            var apiUrl = $"{usuarioApiURLBase}RemoveUsuario";

            usuarioDtoRemove.FechaMod = DateTime.Now;
            usuarioDtoRemove.IdUsuarioMod = 1;

            try
            {
                var response = webService.PostDataToApi<BaseResponse<UsuarioDtoRemove>>(apiUrl, usuarioDtoRemove);

                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }
    }
}


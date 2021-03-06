using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoCasaDeShow.Models;

namespace ProjetoCasaDeShow.Controllers
{
    public class CasaDeShowController : Controller
    {
        private IDataService dataService;

        public CasaDeShowController(IDataService dataService)
        {
            this.dataService = dataService;
        }
        
        [Authorize]
        public IActionResult CriarCasaDeShow(CasaDeShow casa){
            ViewBag.casas = dataService.GetCasaDeShowRepository().GetCasasCliente().Where(c => c.Id != casa.Id);

            return View(casa);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public IActionResult AddCasa(CasaDeShow casaDeShow, IFormFile arquivo){

            if(casaDeShow.Id == 0){
                dataService.GetCasaDeShowRepository().Add(casaDeShow);
            }
            else{
                dataService.GetCasaDeShowRepository().Update(casaDeShow);
            }

            //Salva imagem
            string pathImage = dataService.SalvaImagem(arquivo, @"\Arquivos\Images\CasasDeShow\", casaDeShow.Id.ToString());

            if (pathImage != null)
            {
                dataService.SalvaCaminhoNaCasa(casaDeShow.Id, pathImage);
            }

            return RedirectToAction("CriarCasaDeShow");
        }

        [Authorize]
        public IActionResult EditCasa(int id){
            var casa = dataService.GetCasaDeShowRepository().GetCasaPeloId(id);
            return RedirectToAction("CriarCasaDeShow", casa);
        }

        [Authorize]
        public IActionResult DeleteCasa(int id){
            dataService.GetCasaDeShowRepository().Delete(id);
            return RedirectToAction("CriarCasaDeShow");
        }

        public IActionResult Casas(){
            ViewBag.casaDeShowRepository = dataService.GetCasaDeShowRepository();

            return View();
        }

        public IActionResult Casa(int id){
            var casa = dataService.GetCasaDeShowRepository().GetCasaPeloId(id);

            ViewBag.historicoRepository = dataService.GetHistoricoRepository();

            return View(casa);
        }
    }
}
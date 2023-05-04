using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProdutosController : Controller
    {
        // GET: ProdutosController1
        public ActionResult Index()
        {
            List<Produtos> lista = new List<Produtos>();

            Produtos produto = new Produtos();
            produto.Id = 1;
            produto.Nome = "Produto 1";

            Produtos produto2 = new Produtos();
            produto2.Id = 2;
            produto2.Nome = "Produto 2";

            lista.Add(produto);
            lista.Add(produto2);

            return View(lista); 
        }

        // GET: ProdutosController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProdutosController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProdutosController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProdutosController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProdutosController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProdutosController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProdutosController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

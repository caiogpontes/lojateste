using LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {
        private ProdutosRepositorio _repositorio;
        public int ProdutosPorPagina = 3;

        // GET: Produtos
        public ActionResult Index(int pagina = 1)
        {

            var produtos = _repositorio.Produtos
                .OrderBy(p => p.Descricao)
                .Skip((pagina - 1) * ProdutosPorPagina)
                .Take(ProdutosPorPagina);

            return View(produtos);
        }



    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ativ2_PedroOliveira.Models;

namespace Ativ2_PedroOliveira.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(ItemPedido itemPedido)
        {
            Dados.PedidoAtual.AddPedido(itemPedido);
            return View("Listagem", Dados.PedidoAtual.ListaPedido());
        }

        [HttpGet]
        public IActionResult Listagem()
        {
            List<ItemPedido> pedido = Dados.PedidoAtual.ListaPedido();
            return View(pedido);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

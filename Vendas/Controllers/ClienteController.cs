using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendas.Models.Cliente;
using Vendas.Repository.Cliente;

namespace Vendas.Controllers
{
    public class ClienteController : Controller
    {

        private readonly IClienteRepository _clienteRepository;

        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ClienteModel cliente)
        {
            _clienteRepository.Insert(cliente);

            return RedirectToAction("Index");
        }
    }
}

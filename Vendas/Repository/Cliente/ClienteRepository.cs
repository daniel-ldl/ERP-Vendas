using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendas.Data;
using Vendas.Models.Cliente;

namespace Vendas.Repository.Cliente
{
    public class ClienteRepository : IClienteRepository
    {

        private readonly BancoContext _bancoContext;

        public ClienteRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public ClienteModel Insert(ClienteModel cliente)
        {
            //insert
            _bancoContext.Cliente.Add(cliente);
            _bancoContext.SaveChanges();

            return cliente;
        }
    }
}

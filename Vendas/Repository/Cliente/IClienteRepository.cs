using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendas.Models.Cliente;

namespace Vendas.Repository.Cliente
{
    public interface IClienteRepository
    {
        ClienteModel GetClientById(int Id);
        List<ClienteModel> GetAllClient();
        ClienteModel Insert(ClienteModel cliente);
    }
}

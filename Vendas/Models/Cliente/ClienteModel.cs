using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vendas.Models.Cliente
{
    public class ClienteModel
    {

        public int Id { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }

    }
}

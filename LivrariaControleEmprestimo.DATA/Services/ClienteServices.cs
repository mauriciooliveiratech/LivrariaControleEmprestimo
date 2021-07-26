using LivrariaControleEmprestimo.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaControleEmprestimo.DATA.Services
{
    public class ClienteServices
    {
        public RepositoryCliente oRepositoryCliente { get; set; }

        public ClienteServices()
        {
            oRepositoryCliente = new RepositoryCliente();
        }
    }
}

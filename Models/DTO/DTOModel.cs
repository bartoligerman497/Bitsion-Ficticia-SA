using Bitsion_Ficticia_S.A.Models.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bitsion_Ficticia_S.A.Models.DTO
{
    public class DTOModel
    {
        private List<ClienteModel> listadoClientes;
        private ClienteModel cliente;

        public DTOModel(List<ClienteModel> listadoClientes, ClienteModel cliente)
        {
            this.listadoClientes = listadoClientes;
            this.Cliente = cliente;
        }

        public DTOModel()
        {
            listadoClientes = new();
            Cliente = new();
        }

        public List<ClienteModel> ListadoClientes { get => listadoClientes; set => listadoClientes = value; }
        public ClienteModel Cliente { get => cliente; set => cliente = value; }
    }
}
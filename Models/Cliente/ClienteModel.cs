using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bitsion_Ficticia_S.A.Models.Cliente
{
    public class ClienteModel
    {
        private int idCliente;
        private string nombre;
        private string apellido;
        private string dni;
        private int edad;
        private GeneroModel genero;
        private bool maneja;
        private bool usaLentes;
        private bool diabetico;
        private string enfermedades;
        private bool activoCliente;

        public ClienteModel(int idCliente, string nombre, string apellido, string dni, int edad, GeneroModel genero, bool maneja,
            bool usaLentes, bool diabetico, string enfermedades, bool activoCliente)
        {
            this.IdCliente = idCliente;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Edad = edad;
            this.Genero = genero;
            this.Maneja = maneja;
            this.UsaLentes = usaLentes;
            this.Diabetico = diabetico;
            this.Enfermedades = enfermedades;
            this.ActivoCliente = activoCliente;
        }

        public ClienteModel()
        {
        }

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }
        public int Edad { get => edad; set => edad = value; }
        public GeneroModel Genero { get => genero; set => genero = value; }
        public bool Maneja { get => maneja; set => maneja = value; }
        public bool UsaLentes { get => usaLentes; set => usaLentes = value; }
        public bool Diabetico { get => diabetico; set => diabetico = value; }
        public string Enfermedades { get => enfermedades; set => enfermedades = value; }
        public bool ActivoCliente { get => activoCliente; set => activoCliente = value; }
    }
}
namespace Bitsion_Ficticia_S.A.Models.Cliente
{
    public class GeneroModel
    {
        private int idGenero;
        private string descripcion;

        public GeneroModel(int idGenero, string descripcion)
        {
            this.idGenero = idGenero;
            this.descripcion = descripcion;
        }

        public GeneroModel()
        {
        }

        public int IdGenero { get => idGenero; set => idGenero = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
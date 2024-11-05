namespace MandalorianoENT
{
    public class clsMisionENT
    {
        public int id { get; set; } = 0;
        public string nombre { get; set; } = "";
        public string descripcion { get; set; } = "";
        public int recompensa { get; set; } = 0;

        public clsMisionENT() { }

        public clsMisionENT(int id, string nombre, string descripcion, int recompensa)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;

            if (recompensa >= 0)
            {
                this.recompensa = recompensa;
            }
        }
    }
}

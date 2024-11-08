using MandalorianoBL;
using MandalorianoENT;

namespace MandalorianoUI.Models.VM
{
    public class clsVistaMisionesVM : clsMisionENT
    {
        public List<clsMisionENT> misiones { get; }

        public clsVistaMisionesVM()
        {
            misiones = clsObtenerMisionesBL.obtenerMisionesBL();
        }

        public clsVistaMisionesVM(clsMisionENT mision)
        : this()
        {
            // Actualizamos el model con los datos de la misión
            this.id = mision.id;
            this.nombre = mision.nombre;
            this.descripcion = mision.descripcion;
            this.recompensa = mision.recompensa;
        }
    }
}

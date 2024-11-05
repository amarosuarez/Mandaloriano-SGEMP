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
    }
}

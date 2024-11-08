using MandalorianoBL;
using MandalorianoENT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MandalorianoMAUI.ViewModels
{
    public class clsVistaMisiones : INotifyPropertyChanged
    {
        private List<clsMisionENT> misiones;

        private clsMisionENT mision;

        public List<clsMisionENT> Misiones { 
            get
            {
                return misiones;
            }
        }

        public clsMisionENT Mision
        {
            get
            {
                return mision;
            }

            set { 
                mision = value;
                NotifyPropertyChanged("Mision");
            }
        }

        public clsVistaMisiones() { 
            misiones = clsObtenerMisionesBL.obtenerMisionesBL();
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}

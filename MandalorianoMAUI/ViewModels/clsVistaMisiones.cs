
using MandalorianoBL;
using MandalorianoENT;
using MandalorianoUI.Models;
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

        private Boolean visibleFrame;

        private Boolean visibleError;

        private Boolean visiblePicker;

        private String mensajeExc;

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
                NotifyPropertyChanged("VisibleFrame");
            }
        }

        public Boolean VisibleFrame
        {
            get {
                return mision != null;
            }
        }
        public Boolean VisibleError
        {
            get
            {
                return visibleError;
            }
        }

        public Boolean VisiblePicker
        {
            get
            {
                return !visibleError;
            }
        }

        public String MensajeExc
        {
            get
            {
                return mensajeExc;
            }
        }

        public clsVistaMisiones() {
            try
            {
                misiones = clsObtenerMisionesBL.obtenerMisionesBL();
            }
            catch (HourException h)
            {
                visibleError = true;
                mensajeExc = h.Message;
                NotifyPropertyChanged("VisibleError");
                NotifyPropertyChanged("VisiblePicker");
                NotifyPropertyChanged("MensajeExc");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

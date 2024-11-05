using MandalorianoDAL;
using MandalorianoENT;

namespace MandalorianoBL
{
    public class clsObtenerMisionesBL
    {
        /// <summary>
        /// Función que obtiene todas las misiones y si la hora está entre las 8 am y las 23:59 las devuelve como lista
        /// </summary>
        /// <returns>Devuelve todas las misiones como una lista</returns>
        public static List<clsMisionENT> obtenerMisionesBL()
        {
            if (DateTime.Now.Hour >= 8 && DateTime.Now.Hour < 24)
            {
                return clsObtenerMisionesDAL.obtenerMisionesDAL();
            }

            return null;
        }

        /// <summary>
        /// Función que obtiene una misión de la lista de misiones por su id
        /// </summary>
        /// <param name="id">Parámetro por el que busca la misión</param>
        /// <returns>Devuelve una misión concreta por su id</returns>
        public static clsMisionENT obtenerMisionByIDBL(int id)
        {
            return clsObtenerMisionesDAL.obtenerMisionByIDDAL(id);
        }
    }
}

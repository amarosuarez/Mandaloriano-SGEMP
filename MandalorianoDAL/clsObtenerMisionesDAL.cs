using MandalorianoENT;

namespace MandalorianoDAL
{
    public class clsObtenerMisionesDAL
    {
        private static List<clsMisionENT> misiones = new List<clsMisionENT>
            {
                new clsMisionENT(1, "Rescate de Baby Yoda", "Debes hacerte con Grogu y llevárselo a Luke SkyWalker para su entrenamiento.", 5000),
                new clsMisionENT(2, "Recuperar armadura Beskar", "Tu armadura de Beskar ha sido robada. Debes encontrarla.", 2000),
                new clsMisionENT(3, "Planeta Sorgon", "Debes llevar a un niño de vuelta a su planeta natal “Sorgon”.", 500),
                new clsMisionENT(4, "Renacuajos", "Debes llevar a una Dama Rana y sus huevos de Tatooine a la luna del estuario Trask, donde su esposo fertilizará los huevos.", 500)
            };

        /// <summary>
        /// Función que obtiene todas las misiones y las devuelve como lista
        /// </summary>
        /// <returns>Devuelve todas las misiones como una lista</returns>
        public static List<clsMisionENT> obtenerMisionesDAL()
        {
            return misiones;
        }

        /// <summary>
        /// Función que obtiene una misión de la lista de misiones por su id
        /// </summary>
        /// <param name="id">Parámetro por el que busca la misión</param>
        /// <returns>Devuelve una misión concreta por su id</returns>
        public static clsMisionENT? obtenerMisionByIDDAL(int id)
        {
            clsMisionENT? mision = new clsMisionENT();

            /*for (int i = 0; i < misiones.Count; i++)
            {
                if (misiones[i].id == id)
                {
                    mision = misiones[i];
                }
            }*/
            
            // Equivalente a esto
            mision = misiones.Find(mision => mision.id == id);

            return mision;
        }

    }
}

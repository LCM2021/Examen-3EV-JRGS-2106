using System.Collections.Generic;

namespace Examen3EV_NS
{
    /// <summary>
    /// esta clase nos calcula las estadísticas de un conjunto de notas 
    /// </summary>
    public class estNot
    {
        private int suspendidos;  // Suspensos
        private int aprobados;  // Aprobados
        private int notables;  // Notables
        private int sobresalientes;  // Sobresalientes

        public double media; // Nota media

        public int Suspendidos
        {
            get => suspendidos;
            set => suspendidos = value;
        }
        public int Aprobados
        {
            get => aprobados;
            set => aprobados = value;
        }
        public int Notables
        {
            get => notables;
            set => notables = value;
        }
        public int Sobresalientes
        {
            get => sobresalientes;
            set => sobresalientes = value;
        }

        ///<summary>
        ///Constructor vacío
        ///</summary>
        public estNot ()
        {
            Suspendidos = Aprobados = Notables = Sobresalientes = 0;  // inicializamos las variables
            media = 0.0;
        }


        ///<summary>
        ///Constructor a partir de un array, calcula las estadísticas al crear el objeto
        ///</summary>
        public estNot (List<int> listnot)
        {
            media = 0.0;

            for (int i = 0; i < listnot.Count; i++)
            {
                if (listnot[i] < 5)
                {
                    Suspendidos++;
                }

                // Por debajo de 5 suspenso
                else if (listnot[i] > 5 && listnot[i] < 7)
                {
                    Aprobados++; //Nota para aprobar: 5
                }

                else if (listnot[i] > 7 && listnot[i] < 9)
                {
                    Notables++; // Nota para notable: 7
                }

                else if (listnot[i] > 9)
                {
                    Sobresalientes++; // Nota para sobresaliente: 9
                }
                    
                media = media + listnot[i];
            }

            media = media / listnot.Count;
        }


        /// <summary>
        /// <para>Para un conjunto de listnot, calculamos las estadísticas</para>
        /// <para>calcula la media y el número de suspensos/aprobados/notables/sobresalientes</para>
        /// </summary>
        /// <param name="listnot"></param>
        /// <returns>El método devuelve -1 si ha habido algún problema, la media en caso contrario</returns>

        public double CalcEst (List<int> listnot)
        {
            media = 0.0;

            // TODO: hay que modificar el tratamiento de errores para generar excepciones
            // Si la lista no contiene elementos, devolvemos un error
            if (listnot.Count <= 0)
            {
                return -1;
            }


            for (int i = 0; i < 10; i++)
            {
                ///<summary>comprobamos que las <paramref name="listnot">notas</paramref> están entre 0 y 10 (mínimo y máximo), si no, error</summary>
                if (listnot[i] < 0 || listnot[i] > 10)
                    return -1;
            }
                

            for (int i = 0; i < listnot.Count; i++)
            {
                ///<summary><paramref name="listnot">notas</paramref>Por debajo de 5 suspenso</summary> 
                if (listnot[i] < 5)
                {
                    Suspendidos++;
                }

                ///<summary><paramref name="listnot">notas</paramref> para aprobar: 5</summary> 
                else if (listnot[i] >= 5 && listnot[i] < 7)
                {
                    Aprobados++;
                }

                ///<summary><paramref name="listnot">notas</paramref> para notable: 7</summary> 
                else if (listnot[i] >= 7 && listnot[i] < 9)
                {
                    Notables++;
                }

                ///<summary><paramref name="listnot">notas</paramref> para sobresaliente: 9</summary> 
                else if (listnot[i] > 9)
                {
                    Sobresalientes++;
                }

                media = media + listnot[i];
            }

            media = media / listnot.Count;

            return media;
        }
    }
}

using System.Collections.Generic;

namespace Examen3EV_NS
{
    /// <summary>
    /// esta clase nos calcula las estadísticas de un conjunto de notas 
    /// </summary>
    public class EstNot
    {
        private int suspendidos;  // Suspensos
        private int aprobados;  // Aprobados
        private int notables;  // Notables
        private int sobresalientes;  // Sobresalientes

        private double media; // Nota media

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
        public double meida
        {
            get => media;
            set => media = value;
        }

        ///<summary>
        ///Constructor vacío
        ///</summary>
        public EstNot ()
        {
            ///<summary>inicializamos las variables</summary> 
            suspendidos = aprobados = notables = sobresalientes = 0;  
            meida = 0.0;
        }


        ///<summary>
        ///Constructor a partir de un array, calcula las estadísticas al crear el objeto
        ///</summary>
        public EstNot (List<int> listnot)
        {
            meida = 0.0;

            for (int i = 0; i < listnot.Count; i++)
            {
                CandidadesCadaNota(listnot, i);
            }

            meida = meida / listnot.Count;
        }


        /// <summary>
        /// <para>Para un conjunto de listnot, calculamos las estadísticas</para>
        /// <para>calcula la media y el número de suspensos/aprobados/notables/sobresalientes</para>
        /// </summary>
        /// <returns>El método devuelve -1 si ha habido algún problema, la media en caso contrario</returns>

        public double CalcEst (List<int> listnot)
        {
            meida = 0.0;

            // TODO: hay que modificar el tratamiento de errores para generar excepciones
            ///<exception>Si la lista no contiene elementos, devolvemos un error</exception>
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
                CandidadesCadaNota(listnot, i);
            }

            meida = meida / listnot.Count;

            return meida;
        }

        private void CandidadesCadaNota (List<int> listnot, int i)
        {
            if (listnot[i] < 5)
            {
                suspendidos++;
            }

            ///<summary><paramref name="listnot">notas</paramref> para aprobar: 5</summary> 
            else if (listnot[i] >= 5 && listnot[i] < 7)
            {
                aprobados++;
            }

            ///<summary><paramref name="listnot">notas</paramref> para notable: 7</summary> 
            else if (listnot[i] >= 7 && listnot[i] < 9)
            {
                notables++;
            }

            ///<summary><paramref name="listnot">notas</paramref> para sobresaliente: 9</summary> 
            else if (listnot[i] > 9)
            {
                sobresalientes++;
            }

            meida = meida + listnot[i];
        }
    }
}

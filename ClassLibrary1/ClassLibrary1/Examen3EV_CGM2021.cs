
using System;
using System.Collections.Generic;

namespace Examen3EV_CGM2021
{

    /// <summary>
    /// Clase principal <see cref="estadisticaNotas_CGM2021" />.
    /// </summary>
    /// <para>Calcula la estadística de un conjunto de notas</para>
    public class estadisticaNotas_CGM2021  // esta clase nos calcula las estadísticas de un conjunto de notas 
    {
        /// <summary>
        /// Suma total de suspensos.
        /// </summary>
        private int suspenso;// Suspensos

        /// <summary>
        /// Suma total de aprobados.
        /// </summary>
        private int aprobado;// Aprobados

        /// <summary>
        /// Suma total de notables.
        /// </summary>
        private int notable;// Notables

        /// <summary>
        /// Suma total de sobresalientes.
        /// </summary>
        private int sobresaliente;// Sobresalientes

        /// <summary>
        /// Almacena la nota media.
        /// </summary>
        private double notaMedia;// Nota media

        /// <summary>
        /// Establece un mensaje de error que lanza en las excepciones.
        /// </summary>
        public const string mensajeDeError = "El índice estaba fuera del intervalo. Debe ser un valor no negativo e inferior al tamaño de la colección";


        /// <summary>
        /// Obtiene el valor total de suspensos.
        /// </summary>
        public int Suspenso { 
            get => suspenso; 
            set => suspenso = value; 
        }

        /// <summary>
        /// Obtiene el valor total de aprobados.
        /// </summary>
        public int Aprobado { 
            get => aprobado; 
            set => aprobado = value; 
        }

        /// <summary>
        /// Obtiene el valor total de notables.
        /// </summary>
        public int Notable { 
            get => notable; 
            set => notable = value; 
        }

        /// <summary>
        /// Obtiene el valor total de sobresalientes.
        /// </summary>
        public int Sobresaliente { 
            get => sobresaliente; 
            set => sobresaliente = value; 
        }

        /// <summary>
        /// Obtiene la nota media.
        /// </summary>
        public double NotaMedia { 
            get => notaMedia; 
            set => notaMedia = value; 
        }

        /// <summary>
        /// Constructor por defecto que inicializa un nuevo objeto <see cref="estadisticaNotas_CGM2021"/> class.
        /// </summary>
        public estadisticaNotas_CGM2021()
        {
            this.suspenso = 0;
            this.aprobado = 0;
            this.notable = 0;
            this.sobresaliente = 0;
            this.notaMedia = 0.0; // aun que siendo decimal puedo inicializarla a 0, pero prefiero dejarlo como 0.0
        }

        /// <summary>
        /// Constructor sobrecargado que inicializa un objeto <see cref="estadisticaNotas_CGM2021"/> class.
        /// </summary>
        /// <param name="listaNotas">The listaNotas<see cref="List{int}"/>.</param>
        public estadisticaNotas_CGM2021(List<int> listaNotas)
        {
            CalcularEstadistica_CGM2021(listaNotas);
        }

        /// <summary>
        /// TFunción que calcula la estadística.
        /// </summary>
        /// <param name="listaNotas">parámetro de entrada listaNotas de tipo <see cref="List{int}"/>.</param>
        /// <returns>Devuelve un <see cref="double"/> que contiene la nota media.</returns>
        public double CalcularEstadistica_CGM2021(List<int> listaNotas)
        {
            NotaMedia = 0.0;

            // TODO: hay que modificar el tratamiento de errores para generar excepciones
            //
            if (listaNotas.Count <= 0)
            {  // Si la lista no contiene elementos, devolvemos un error
                throw new ArgumentOutOfRangeException(mensajeDeError);
            }

            for (int i = 0; i < 10; i++)
            {
                if (listaNotas[i] < 0 || listaNotas[i] > 10)
                {
                    throw new ArgumentOutOfRangeException(mensajeDeError); // comprobamos que las not están entre 0 y 10 (mínimo y máximo), si no, error
                }
            }

            for (int i = 0; i < listaNotas.Count; i++)
            {
                if (listaNotas[i] < 5)
                {
                    Suspenso++; // Por debajo de 5 suspenso
                }
                else if (listaNotas[i] >= 5 && listaNotas[i] < 7)
                {
                    Aprobado++;// Nota para aprobar: 5
                }
                else if (listaNotas[i] >= 7 && listaNotas[i] < 9)
                {
                    Notable++;// Nota para notable: 7
                }
                else if (listaNotas[i] > 9)
                {
                    Sobresaliente++;         // Nota para sobresaliente: 9
                }

                NotaMedia = NotaMedia + listaNotas[i];
            }

            NotaMedia = NotaMedia / listaNotas.Count;

            return NotaMedia;
        }
    }
}

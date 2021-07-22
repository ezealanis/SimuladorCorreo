using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Entidades.Excepciones;
using Entidades.Interfaz;

namespace Entidades.Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;

        //Getter y setter de la lista paquetes.
        public List<Paquete> Paquetes
        {
            get
            {
                return this.paquetes;
            }
            set
            {
                this.paquetes = value;
            }
        }

        public Correo()
        {
            this.mockPaquetes = new List<Thread>();
            this.paquetes = new List<Paquete>();
        }

        //Muestra todos los datos de los paquetes en la lista.
        public string MostrarDatos(IMostrar<List<Paquete>> elemento)
        {
            List<Paquete> lista = (List<Paquete>)elemento;
            StringBuilder sb = new StringBuilder();

            foreach(Paquete item in lista)
            {
                sb.AppendLine($"{item.TrackinID} para {item.DireccionEntrega}");
            }

            return sb.ToString();
        }
    
        //Agrega un paquete al correo y ejecuta la simulacion en un hilo aparte.
        public static Correo operator +(Correo correo, Paquete p)
        {
            try
            {
                foreach (Paquete item in correo.Paquetes)
                {
                    if (item == p)
                    {
                        throw new TrackingIDRepetidoException("El paquete ya se encuentra en la lista.");
                    }
                }

                correo.Paquetes.Add(p);

                Thread hilo = new Thread(p.MockCicloDeVida);
                correo.mockPaquetes.Add(hilo);
                hilo.Start();

                return correo;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        
        //Cierra todos los hilos en ejecucion.
        public void FinEntregas()
        {
            foreach(Thread hilo in this.mockPaquetes)
            {
                hilo.Abort();
            }
        }

    }
}

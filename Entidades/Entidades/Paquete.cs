using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Entidades.Interfaz;
using Entidades.Entidades;
using Entidades.Excepciones;

namespace Entidades
{
    public enum EEstado { Ingresado, EnViaje, Entregado }

    public class Paquete : IMostrar<Paquete>
    {
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;

        //Creacion de delegado
        public delegate void DelegadoEstado(object sender, EventArgs e);
        //Evento asociado al delegado
        public event DelegadoEstado InformaEstado;

        #region Propiedades

        //Getter y Setter de la direccion de entrega
        public string DireccionEntrega
        {
            get
            {
                return this.direccionEntrega;
            }
            set
            {
                this.direccionEntrega = value;
            }
        }

        //Getter y Setter de el estado del envio
        public EEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        //Getter y Setter de el numero de trackeo
        public string TrackinID
        {
            get
            {
                return this.trackingID;
            }
            set
            {
                this.trackingID = value;
            }
        }

        #endregion

        public Paquete(string direccionEntrega, string trackingID)
        {
            this.direccionEntrega = direccionEntrega;
            this.estado = EEstado.Ingresado;
            this.trackingID = trackingID;
        }

        public string InfoPaquete()
        {
            return $"Tracking ID: {this.TrackinID}\nDomicilio de Entrega: {this.DireccionEntrega}\nEstado: {this.Estado}\n";
        }

        //Implementacion de la interfaz, muestra los datos recibidos.
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            Paquete aux = (Paquete)elemento;

            return aux.InfoPaquete();
        }

        //simula la entrega de un paquete, cada 4 segundos cambia su estado.
        public void MockCicloDeVida()
        {
            do
            {
                Thread.Sleep(4000);
                this.Estado += 1;
                this.InformaEstado(this, new EventArgs());
            } while (this.Estado != EEstado.Entregado);

            try
            {
                PaqueteDAO.Insertar(this);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #region Sobrecarga

        //Dos paquetes son iguales si tienen el mismo tracking
        public static bool operator ==(Paquete p1, Paquete p2)
        {
            if (p1.TrackinID == p2.TrackinID)
            {
                throw new TrackingIDRepetidoException("Tracking repetido, ya se encuentra en el correo.");
            }

            return true;
        }

        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

        //Sobrecarga que retorna toda la informacion del paquete.
        public override string ToString()
        {
            return $"Tracking ID: {this.TrackinID}";
        }

        #endregion





    }
}

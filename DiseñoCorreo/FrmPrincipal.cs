using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.Entidades;
using Entidades.Interfaz;

namespace DiseñoCorreo
{
    public partial class FrmPrincipal : Form
    {
        Correo correo;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.correo = new Correo();
        }

        private void btnAgregarPaquete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.mtxtTrackingID.Text) && !string.IsNullOrWhiteSpace(this.txtDireccionEntrega.Text))
            {
                Paquete nuevoPaquete = new Paquete(this.txtDireccionEntrega.Text, this.mtxtTrackingID.Text);
                nuevoPaquete.InformaEstado += this.paq_InformaEstado;
                
                try
                {
                    this.correo += nuevoPaquete;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void paq_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado delegado = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke(delegado, new object[] { sender, e });
            }
            else
            {
                this.ActualizarEstados();
            }
        }

        //Actualiza las tres listas de paquetes.
        private void ActualizarEstados()
        {
            this.lstIngresado.Items.Clear();
            this.lstEnViaje.Items.Clear();
            this.lstEntregado.Items.Clear();

            foreach(Paquete item in this.correo.Paquetes)
            {
                switch (item.Estado)
                {
                    case EEstado.Ingresado:
                        this.lstIngresado.Items.Add(item);
                        break;

                    case EEstado.EnViaje:
                        this.lstEnViaje.Items.Add(item);
                        break;

                    case EEstado.Entregado:
                        this.lstEntregado.Items.Add(item);
                        break;

                    default:
                        break;
                }
            }
        }

        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            if(!object.Equals(elemento, null))
            {
                this.rtbMostrar.Text = elemento.MostrarDatos(elemento);

                if (this.rtbMostrar.Text.Guardar("Salida.txt"))
                {
                    MessageBox.Show("Se guardo el archivo!");
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el archivo.");
                }
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.correo.FinEntregas();
        }
    }
}

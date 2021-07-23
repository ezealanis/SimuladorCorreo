
namespace DiseñoCorreo
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbxEstadoPaquetes = new System.Windows.Forms.GroupBox();
            this.lstEntregado = new System.Windows.Forms.ListBox();
            this.lstEnViaje = new System.Windows.Forms.ListBox();
            this.lstIngresado = new System.Windows.Forms.ListBox();
            this.lblEntregado = new System.Windows.Forms.Label();
            this.lblEnViaje = new System.Windows.Forms.Label();
            this.lblIngresado = new System.Windows.Forms.Label();
            this.gbxPaquete = new System.Windows.Forms.GroupBox();
            this.lblTrackNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtTrackingID = new System.Windows.Forms.MaskedTextBox();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnAgregarPaquete = new System.Windows.Forms.Button();
            this.txtDireccionEntrega = new System.Windows.Forms.TextBox();
            this.rtbMostrar = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gbxEstadoPaquetes.SuspendLayout();
            this.gbxPaquete.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxEstadoPaquetes
            // 
            this.gbxEstadoPaquetes.Controls.Add(this.lstEntregado);
            this.gbxEstadoPaquetes.Controls.Add(this.lstEnViaje);
            this.gbxEstadoPaquetes.Controls.Add(this.lstIngresado);
            this.gbxEstadoPaquetes.Controls.Add(this.lblEntregado);
            this.gbxEstadoPaquetes.Controls.Add(this.lblEnViaje);
            this.gbxEstadoPaquetes.Controls.Add(this.lblIngresado);
            this.gbxEstadoPaquetes.Location = new System.Drawing.Point(12, 12);
            this.gbxEstadoPaquetes.Name = "gbxEstadoPaquetes";
            this.gbxEstadoPaquetes.Size = new System.Drawing.Size(605, 277);
            this.gbxEstadoPaquetes.TabIndex = 0;
            this.gbxEstadoPaquetes.TabStop = false;
            this.gbxEstadoPaquetes.Text = "Estado de los Paquetes";
            // 
            // lstEntregado
            // 
            this.lstEntregado.FormattingEnabled = true;
            this.lstEntregado.Location = new System.Drawing.Point(433, 60);
            this.lstEntregado.Name = "lstEntregado";
            this.lstEntregado.Size = new System.Drawing.Size(166, 199);
            this.lstEntregado.TabIndex = 6;
            // 
            // lstEnViaje
            // 
            this.lstEnViaje.FormattingEnabled = true;
            this.lstEnViaje.Location = new System.Drawing.Point(218, 60);
            this.lstEnViaje.Name = "lstEnViaje";
            this.lstEnViaje.Size = new System.Drawing.Size(166, 199);
            this.lstEnViaje.TabIndex = 5;
            // 
            // lstIngresado
            // 
            this.lstIngresado.FormattingEnabled = true;
            this.lstIngresado.Location = new System.Drawing.Point(6, 60);
            this.lstIngresado.Name = "lstIngresado";
            this.lstIngresado.Size = new System.Drawing.Size(166, 199);
            this.lstIngresado.TabIndex = 4;
            // 
            // lblEntregado
            // 
            this.lblEntregado.AutoSize = true;
            this.lblEntregado.Location = new System.Drawing.Point(446, 34);
            this.lblEntregado.Name = "lblEntregado";
            this.lblEntregado.Size = new System.Drawing.Size(56, 13);
            this.lblEntregado.TabIndex = 3;
            this.lblEntregado.Text = "Entregado";
            // 
            // lblEnViaje
            // 
            this.lblEnViaje.AutoSize = true;
            this.lblEnViaje.Location = new System.Drawing.Point(236, 34);
            this.lblEnViaje.Name = "lblEnViaje";
            this.lblEnViaje.Size = new System.Drawing.Size(46, 13);
            this.lblEnViaje.TabIndex = 2;
            this.lblEnViaje.Text = "En Viaje";
            // 
            // lblIngresado
            // 
            this.lblIngresado.AutoSize = true;
            this.lblIngresado.Location = new System.Drawing.Point(23, 34);
            this.lblIngresado.Name = "lblIngresado";
            this.lblIngresado.Size = new System.Drawing.Size(54, 13);
            this.lblIngresado.TabIndex = 1;
            this.lblIngresado.Text = "Ingresado";
            // 
            // gbxPaquete
            // 
            this.gbxPaquete.Controls.Add(this.lblTrackNumber);
            this.gbxPaquete.Controls.Add(this.label2);
            this.gbxPaquete.Controls.Add(this.mtxtTrackingID);
            this.gbxPaquete.Controls.Add(this.btnMostrarTodos);
            this.gbxPaquete.Controls.Add(this.btnAgregarPaquete);
            this.gbxPaquete.Controls.Add(this.txtDireccionEntrega);
            this.gbxPaquete.Location = new System.Drawing.Point(346, 308);
            this.gbxPaquete.Name = "gbxPaquete";
            this.gbxPaquete.Size = new System.Drawing.Size(271, 130);
            this.gbxPaquete.TabIndex = 2;
            this.gbxPaquete.TabStop = false;
            this.gbxPaquete.Text = "Paquete";
            // 
            // lblTrackNumber
            // 
            this.lblTrackNumber.AutoSize = true;
            this.lblTrackNumber.Location = new System.Drawing.Point(19, 29);
            this.lblTrackNumber.Name = "lblTrackNumber";
            this.lblTrackNumber.Size = new System.Drawing.Size(63, 13);
            this.lblTrackNumber.TabIndex = 7;
            this.lblTrackNumber.Text = "Tracking ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Direccion";
            // 
            // mtxtTrackingID
            // 
            this.mtxtTrackingID.Location = new System.Drawing.Point(13, 45);
            this.mtxtTrackingID.Mask = "000-000-0000";
            this.mtxtTrackingID.Name = "mtxtTrackingID";
            this.mtxtTrackingID.Size = new System.Drawing.Size(151, 20);
            this.mtxtTrackingID.TabIndex = 4;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(170, 89);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(85, 23);
            this.btnMostrarTodos.TabIndex = 3;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnAgregarPaquete
            // 
            this.btnAgregarPaquete.Location = new System.Drawing.Point(170, 43);
            this.btnAgregarPaquete.Name = "btnAgregarPaquete";
            this.btnAgregarPaquete.Size = new System.Drawing.Size(85, 23);
            this.btnAgregarPaquete.TabIndex = 2;
            this.btnAgregarPaquete.Text = "Agregar";
            this.btnAgregarPaquete.UseVisualStyleBackColor = true;
            this.btnAgregarPaquete.Click += new System.EventHandler(this.btnAgregarPaquete_Click);
            // 
            // txtDireccionEntrega
            // 
            this.txtDireccionEntrega.Location = new System.Drawing.Point(13, 91);
            this.txtDireccionEntrega.Name = "txtDireccionEntrega";
            this.txtDireccionEntrega.Size = new System.Drawing.Size(151, 20);
            this.txtDireccionEntrega.TabIndex = 1;
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.Location = new System.Drawing.Point(12, 308);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.ReadOnly = true;
            this.rtbMostrar.Size = new System.Drawing.Size(328, 130);
            this.rtbMostrar.TabIndex = 1;
            this.rtbMostrar.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.gbxPaquete);
            this.Controls.Add(this.rtbMostrar);
            this.Controls.Add(this.gbxEstadoPaquetes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro de Correo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.gbxEstadoPaquetes.ResumeLayout(false);
            this.gbxEstadoPaquetes.PerformLayout();
            this.gbxPaquete.ResumeLayout(false);
            this.gbxPaquete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxEstadoPaquetes;
        private System.Windows.Forms.ListBox lstEnViaje;
        private System.Windows.Forms.ListBox lstIngresado;
        private System.Windows.Forms.Label lblEntregado;
        private System.Windows.Forms.Label lblEnViaje;
        private System.Windows.Forms.Label lblIngresado;
        private System.Windows.Forms.GroupBox gbxPaquete;
        private System.Windows.Forms.TextBox txtDireccionEntrega;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnAgregarPaquete;
        private System.Windows.Forms.ListBox lstEntregado;
        private System.Windows.Forms.MaskedTextBox mtxtTrackingID;
        private System.Windows.Forms.RichTextBox rtbMostrar;
        private System.Windows.Forms.Label lblTrackNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}


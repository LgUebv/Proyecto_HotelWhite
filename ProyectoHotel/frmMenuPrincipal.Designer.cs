﻿namespace ProyectoHotel
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.optHabitacion = new System.Windows.Forms.ToolStripButton();
            this.optClientes = new System.Windows.Forms.ToolStripButton();
            this.optReservacion = new System.Windows.Forms.ToolStripButton();
            this.optSalir = new System.Windows.Forms.ToolStripButton();
            this.optUsuarios = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optHabitacion,
            this.optClientes,
            this.optReservacion,
            this.optUsuarios,
            this.optSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(41, 366);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // optHabitacion
            // 
            this.optHabitacion.AutoSize = false;
            this.optHabitacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.optHabitacion.Image = ((System.Drawing.Image)(resources.GetObject("optHabitacion.Image")));
            this.optHabitacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optHabitacion.Name = "optHabitacion";
            this.optHabitacion.Size = new System.Drawing.Size(40, 40);
            this.optHabitacion.Text = "Habitacion";
            // 
            // optClientes
            // 
            this.optClientes.AutoSize = false;
            this.optClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.optClientes.Image = ((System.Drawing.Image)(resources.GetObject("optClientes.Image")));
            this.optClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optClientes.Name = "optClientes";
            this.optClientes.Size = new System.Drawing.Size(40, 40);
            this.optClientes.Text = "Clientes";
            // 
            // optReservacion
            // 
            this.optReservacion.AutoSize = false;
            this.optReservacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.optReservacion.Image = ((System.Drawing.Image)(resources.GetObject("optReservacion.Image")));
            this.optReservacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optReservacion.Name = "optReservacion";
            this.optReservacion.Size = new System.Drawing.Size(40, 40);
            this.optReservacion.Text = "optReservacion";
            // 
            // optSalir
            // 
            this.optSalir.AutoSize = false;
            this.optSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.optSalir.Image = ((System.Drawing.Image)(resources.GetObject("optSalir.Image")));
            this.optSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optSalir.Name = "optSalir";
            this.optSalir.Size = new System.Drawing.Size(40, 40);
            this.optSalir.Text = "Salir";
            // 
            // optUsuarios
            // 
            this.optUsuarios.AutoSize = false;
            this.optUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.optUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("optUsuarios.Image")));
            this.optUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optUsuarios.Name = "optUsuarios";
            this.optUsuarios.Size = new System.Drawing.Size(40, 40);
            this.optUsuarios.Text = "toolStripButton1";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMenuPrincipal";
            this.Text = "frmMenuPrincipal";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton optHabitacion;
        private System.Windows.Forms.ToolStripButton optClientes;
        private System.Windows.Forms.ToolStripButton optReservacion;
        private System.Windows.Forms.ToolStripButton optSalir;
        private System.Windows.Forms.ToolStripButton optUsuarios;
    }
}
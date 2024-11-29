namespace ProyectoHotel
{
    partial class frmHabitacion2
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
            this.dtgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.txtHabitacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHabitaciones)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvHabitaciones
            // 
            this.dtgvHabitaciones.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHabitaciones.Location = new System.Drawing.Point(14, 85);
            this.dtgvHabitaciones.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtgvHabitaciones.Name = "dtgvHabitaciones";
            this.dtgvHabitaciones.RowHeadersWidth = 51;
            this.dtgvHabitaciones.Size = new System.Drawing.Size(702, 321);
            this.dtgvHabitaciones.TabIndex = 73;
            this.dtgvHabitaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHabitaciones_CellClick);
            // 
            // txtHabitacion
            // 
            this.txtHabitacion.BackColor = System.Drawing.SystemColors.Control;
            this.txtHabitacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHabitacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHabitacion.Location = new System.Drawing.Point(262, 53);
            this.txtHabitacion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtHabitacion.Name = "txtHabitacion";
            this.txtHabitacion.Size = new System.Drawing.Size(454, 27);
            this.txtHabitacion.TabIndex = 72;
            this.txtHabitacion.TextChanged += new System.EventHandler(this.txtHabitacion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 28);
            this.label1.TabIndex = 71;
            this.label1.Text = "Tipo de Habitacion:";
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(702, 3);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(21, 23);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "x";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 33);
            this.panel1.TabIndex = 74;
            // 
            // frmHabitacion2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(732, 420);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvHabitaciones);
            this.Controls.Add(this.txtHabitacion);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmHabitacion2";
            this.Text = "frmHabitacion2";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHabitaciones)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvHabitaciones;
        private System.Windows.Forms.TextBox txtHabitacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnSalir;
        private System.Windows.Forms.Panel panel1;
    }
}
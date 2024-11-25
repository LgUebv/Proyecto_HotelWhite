namespace ProyectoHotel
{
    partial class frmReservaciones
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
            this.txtDias = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvClientes = new System.Windows.Forms.DataGridView();
            this.pListas = new System.Windows.Forms.Panel();
            this.dtgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHabitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(461, 19);
            this.txtDias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDias.Multiline = true;
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(81, 28);
            this.txtDias.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dias";
            // 
            // dtgvClientes
            // 
            this.dtgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvClientes.Location = new System.Drawing.Point(9, 8);
            this.dtgvClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvClientes.Name = "dtgvClientes";
            this.dtgvClientes.RowHeadersWidth = 51;
            this.dtgvClientes.Size = new System.Drawing.Size(340, 145);
            this.dtgvClientes.TabIndex = 10;
            // 
            // pListas
            // 
            this.pListas.AutoScroll = true;
            this.pListas.Location = new System.Drawing.Point(368, 69);
            this.pListas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pListas.Name = "pListas";
            this.pListas.Size = new System.Drawing.Size(293, 236);
            this.pListas.TabIndex = 9;
            this.pListas.Paint += new System.Windows.Forms.PaintEventHandler(this.pListas_Paint);
            // 
            // dtgvHabitaciones
            // 
            this.dtgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHabitaciones.Location = new System.Drawing.Point(9, 160);
            this.dtgvHabitaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvHabitaciones.Name = "dtgvHabitaciones";
            this.dtgvHabitaciones.RowHeadersWidth = 51;
            this.dtgvHabitaciones.Size = new System.Drawing.Size(340, 145);
            this.dtgvHabitaciones.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(561, 7);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 48);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // frmReservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 321);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvClientes);
            this.Controls.Add(this.pListas);
            this.Controls.Add(this.dtgvHabitaciones);
            this.Controls.Add(this.btnAgregar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmReservaciones";
            this.Text = "frmReservaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHabitaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvClientes;
        private System.Windows.Forms.Panel pListas;
        private System.Windows.Forms.DataGridView dtgvHabitaciones;
        private System.Windows.Forms.Button btnAgregar;
    }
}
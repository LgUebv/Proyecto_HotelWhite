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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtgvReservaciones = new System.Windows.Forms.DataGridView();
            this.txtReservaciones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReservaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(627, 17);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(42, 28);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtgvReservaciones
            // 
            this.dtgvReservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReservaciones.Location = new System.Drawing.Point(63, 73);
            this.dtgvReservaciones.Name = "dtgvReservaciones";
            this.dtgvReservaciones.RowHeadersWidth = 51;
            this.dtgvReservaciones.Size = new System.Drawing.Size(606, 315);
            this.dtgvReservaciones.TabIndex = 14;
            this.dtgvReservaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvReservaciones_CellClick);
            // 
            // txtReservaciones
            // 
            this.txtReservaciones.Location = new System.Drawing.Point(176, 17);
            this.txtReservaciones.Multiline = true;
            this.txtReservaciones.Name = "txtReservaciones";
            this.txtReservaciones.Size = new System.Drawing.Size(445, 29);
            this.txtReservaciones.TabIndex = 13;
            this.txtReservaciones.TextChanged += new System.EventHandler(this.txtReservaciones_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "RESERVACIONES";
            // 
            // frmReservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgvReservaciones);
            this.Controls.Add(this.txtReservaciones);
            this.Controls.Add(this.label1);
            this.Name = "frmReservaciones";
            this.Text = "frmReservaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReservaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dtgvReservaciones;
        private System.Windows.Forms.TextBox txtReservaciones;
        private System.Windows.Forms.Label label1;
    }
}
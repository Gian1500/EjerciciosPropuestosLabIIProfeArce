namespace TuGestor
{
    partial class FormVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentas));
            this.dataGridViewVentas = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_busquedaCod = new System.Windows.Forms.TextBox();
            this.btn_agregarVenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cantidadProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EnPuerta = new System.Windows.Forms.RadioButton();
            this.Envio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewVentas
            // 
            this.dataGridViewVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVentas.Location = new System.Drawing.Point(1, 1);
            this.dataGridViewVentas.Name = "dataGridViewVentas";
            this.dataGridViewVentas.Size = new System.Drawing.Size(798, 253);
            this.dataGridViewVentas.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Búsqueda por código";
            // 
            // txt_busquedaCod
            // 
            this.txt_busquedaCod.Location = new System.Drawing.Point(15, 298);
            this.txt_busquedaCod.Name = "txt_busquedaCod";
            this.txt_busquedaCod.Size = new System.Drawing.Size(155, 20);
            this.txt_busquedaCod.TabIndex = 17;
            // 
            // btn_agregarVenta
            // 
            this.btn_agregarVenta.Location = new System.Drawing.Point(302, 333);
            this.btn_agregarVenta.Name = "btn_agregarVenta";
            this.btn_agregarVenta.Size = new System.Drawing.Size(98, 41);
            this.btn_agregarVenta.TabIndex = 18;
            this.btn_agregarVenta.Text = "Agregar Venta";
            this.btn_agregarVenta.UseVisualStyleBackColor = true;
            this.btn_agregarVenta.Click += new System.EventHandler(this.btn_agregarVenta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(182, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cantidad de productos";
            // 
            // txt_cantidadProd
            // 
            this.txt_cantidadProd.Location = new System.Drawing.Point(185, 298);
            this.txt_cantidadProd.Name = "txt_cantidadProd";
            this.txt_cantidadProd.Size = new System.Drawing.Size(155, 20);
            this.txt_cantidadProd.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(346, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Fecha de entrega";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(350, 297);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Envio);
            this.groupBox1.Controls.Add(this.EnPuerta);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 50);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Método de entrega";
            // 
            // EnPuerta
            // 
            this.EnPuerta.AutoSize = true;
            this.EnPuerta.Location = new System.Drawing.Point(6, 19);
            this.EnPuerta.Name = "EnPuerta";
            this.EnPuerta.Size = new System.Drawing.Size(125, 23);
            this.EnPuerta.TabIndex = 0;
            this.EnPuerta.TabStop = true;
            this.EnPuerta.Text = "Retiro en local";
            this.EnPuerta.UseVisualStyleBackColor = true;
            // 
            // Envio
            // 
            this.Envio.AutoSize = true;
            this.Envio.Location = new System.Drawing.Point(140, 19);
            this.Envio.Name = "Envio";
            this.Envio.Size = new System.Drawing.Size(144, 23);
            this.Envio.TabIndex = 1;
            this.Envio.TabStop = true;
            this.Envio.Text = "Envio a domicilio";
            this.Envio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(622, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 45);
            this.label3.TabIndex = 21;
            this.label3.Text = "TOTAL";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.BackColor = System.Drawing.Color.Transparent;
            this.label_total.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.ForeColor = System.Drawing.SystemColors.Control;
            this.label_total.Location = new System.Drawing.Point(645, 323);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(68, 45);
            this.label_total.TabIndex = 22;
            this.label_total.Text = "0.0";
            this.label_total.Click += new System.EventHandler(this.label5_Click);
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_agregarVenta);
            this.Controls.Add(this.txt_cantidadProd);
            this.Controls.Add(this.txt_busquedaCod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewVentas);
            this.Name = "FormVentas";
            this.Text = "FormVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVentas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_busquedaCod;
        private System.Windows.Forms.Button btn_agregarVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cantidadProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Envio;
        private System.Windows.Forms.RadioButton EnPuerta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_total;
    }
}
namespace Planificacion_viajes
{
    partial class vtPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstPendientes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarViaje = new System.Windows.Forms.Button();
            this.txtAgregarViaje = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtfechaida = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtfechavuelta = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnombreviaje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "Planificación de Destino";
            // 
            // lstPendientes
            // 
            this.lstPendientes.FormattingEnabled = true;
            this.lstPendientes.ItemHeight = 16;
            this.lstPendientes.Location = new System.Drawing.Point(387, 193);
            this.lstPendientes.Margin = new System.Windows.Forms.Padding(4);
            this.lstPendientes.Name = "lstPendientes";
            this.lstPendientes.Size = new System.Drawing.Size(450, 244);
            this.lstPendientes.TabIndex = 3;
            this.lstPendientes.SelectedIndexChanged += new System.EventHandler(this.lstPendientes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lista de viajes";
            // 
            // btnAgregarViaje
            // 
            this.btnAgregarViaje.Location = new System.Drawing.Point(129, 409);
            this.btnAgregarViaje.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarViaje.Name = "btnAgregarViaje";
            this.btnAgregarViaje.Size = new System.Drawing.Size(147, 28);
            this.btnAgregarViaje.TabIndex = 5;
            this.btnAgregarViaje.Text = "Agregar plan";
            this.btnAgregarViaje.UseVisualStyleBackColor = true;
            this.btnAgregarViaje.Click += new System.EventHandler(this.btnAgregarViaje_Click);
            // 
            // txtAgregarViaje
            // 
            this.txtAgregarViaje.Location = new System.Drawing.Point(191, 209);
            this.txtAgregarViaje.Margin = new System.Windows.Forms.Padding(4);
            this.txtAgregarViaje.Name = "txtAgregarViaje";
            this.txtAgregarViaje.Size = new System.Drawing.Size(176, 22);
            this.txtAgregarViaje.TabIndex = 6;
            this.txtAgregarViaje.TextChanged += new System.EventHandler(this.txtAgregarViaje_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(51, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "País/Cuidad :";
            // 
            // dtfechaida
            // 
            this.dtfechaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechaida.Location = new System.Drawing.Point(212, 256);
            this.dtfechaida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtfechaida.Name = "dtfechaida";
            this.dtfechaida.Size = new System.Drawing.Size(135, 22);
            this.dtfechaida.TabIndex = 9;
            this.dtfechaida.ValueChanged += new System.EventHandler(this.dtfechaida_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(51, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha de ida :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(29, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha de vuelta :";
            // 
            // dtfechavuelta
            // 
            this.dtfechavuelta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechavuelta.Location = new System.Drawing.Point(212, 300);
            this.dtfechavuelta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtfechavuelta.Name = "dtfechavuelta";
            this.dtfechavuelta.Size = new System.Drawing.Size(135, 22);
            this.dtfechavuelta.TabIndex = 12;
            this.dtfechavuelta.ValueChanged += new System.EventHandler(this.dtfechavuelta_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(27, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 34);
            this.label6.TabIndex = 13;
            this.label6.Text = "Agregar destino";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(27, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nombre de viaje :";
            // 
            // txtnombreviaje
            // 
            this.txtnombreviaje.Location = new System.Drawing.Point(191, 345);
            this.txtnombreviaje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnombreviaje.Name = "txtnombreviaje";
            this.txtnombreviaje.Size = new System.Drawing.Size(176, 22);
            this.txtnombreviaje.TabIndex = 15;
            this.txtnombreviaje.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // vtPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1016, 703);
            this.Controls.Add(this.txtnombreviaje);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtfechavuelta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtfechaida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAgregarViaje);
            this.Controls.Add(this.btnAgregarViaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstPendientes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "vtPrincipal";
            this.Text = "Ventana_destino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstPendientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarViaje;
        private System.Windows.Forms.TextBox txtAgregarViaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtfechaida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtfechavuelta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnombreviaje;
    }
}
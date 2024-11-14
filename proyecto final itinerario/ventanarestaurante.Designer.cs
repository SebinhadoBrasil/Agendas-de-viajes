namespace Planificacion_viajes
{
    partial class ventanarestaurante
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
            this.lvRestaurante = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.AllBox = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MetPagar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SelecMenu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AllBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvRestaurante
            // 
            this.lvRestaurante.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvRestaurante.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvRestaurante.GridLines = true;
            this.lvRestaurante.HideSelection = false;
            this.lvRestaurante.Location = new System.Drawing.Point(12, 319);
            this.lvRestaurante.Name = "lvRestaurante";
            this.lvRestaurante.Size = new System.Drawing.Size(668, 120);
            this.lvRestaurante.TabIndex = 12;
            this.lvRestaurante.UseCompatibleStateImageBehavior = false;
            this.lvRestaurante.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AllBox
            // 
            this.AllBox.Controls.Add(this.txtCantidad);
            this.AllBox.Controls.Add(this.label3);
            this.AllBox.Controls.Add(this.MetPagar);
            this.AllBox.Controls.Add(this.label2);
            this.AllBox.Controls.Add(this.SelecMenu);
            this.AllBox.Controls.Add(this.label1);
            this.AllBox.Location = new System.Drawing.Point(12, 101);
            this.AllBox.Name = "AllBox";
            this.AllBox.Size = new System.Drawing.Size(690, 169);
            this.AllBox.TabIndex = 10;
            this.AllBox.TabStop = false;
            this.AllBox.Text = "groupBox1";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(222, 49);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(125, 20);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad:";
            // 
            // MetPagar
            // 
            this.MetPagar.FormattingEnabled = true;
            this.MetPagar.Items.AddRange(new object[] {
            "EFECTIVO",
            "YAPE",
            "PLIN",
            "TARJETA"});
            this.MetPagar.Location = new System.Drawing.Point(31, 120);
            this.MetPagar.Name = "MetPagar";
            this.MetPagar.Size = new System.Drawing.Size(155, 21);
            this.MetPagar.TabIndex = 1;
            this.MetPagar.SelectedIndexChanged += new System.EventHandler(this.MetPagar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Metodo de Pago:";
            // 
            // SelecMenu
            // 
            this.SelecMenu.FormattingEnabled = true;
            this.SelecMenu.Items.AddRange(new object[] {
            "PACHAMANCA",
            "AJI DE GALLINA",
            "JARRA DE CHICHA MORADA",
            "COMBINADO",
            "CEVICHE"});
            this.SelecMenu.Location = new System.Drawing.Point(31, 48);
            this.SelecMenu.Name = "SelecMenu";
            this.SelecMenu.Size = new System.Drawing.Size(155, 21);
            this.SelecMenu.TabIndex = 0;
            this.SelecMenu.SelectedIndexChanged += new System.EventHandler(this.SelecMenu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar Menu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(247, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 36);
            this.label4.TabIndex = 13;
            this.label4.Text = "Restaurante";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 43);
            this.panel1.TabIndex = 14;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PRODUCTO";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CANTIDAD";
            this.columnHeader2.Width = 84;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "PRECIO";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "PRECIO FINAL";
            this.columnHeader4.Width = 99;
            // 
            // ventanarestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(756, 469);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lvRestaurante);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AllBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ventanarestaurante";
            this.Text = "ventanarestaurante";
            this.Load += new System.EventHandler(this.ventanarestaurante_Load);
            this.AllBox.ResumeLayout(false);
            this.AllBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvRestaurante;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox AllBox;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MetPagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SelecMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
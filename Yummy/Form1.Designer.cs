namespace Yummy
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Añadir = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butBuscar = new System.Windows.Forms.Button();
            this.Registrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lemon", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Producto:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(325, 345);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(357, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lemon", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(820, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1002, 350);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 31);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Location = new System.Drawing.Point(700, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Añadir
            // 
            this.Añadir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Añadir.Location = new System.Drawing.Point(1118, 344);
            this.Añadir.Name = "Añadir";
            this.Añadir.Size = new System.Drawing.Size(100, 42);
            this.Añadir.TabIndex = 5;
            this.Añadir.Text = "Añadir";
            this.Añadir.UseVisualStyleBackColor = false;
            this.Añadir.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv.Location = new System.Drawing.Point(45, 409);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 82;
            this.dgv.Size = new System.Drawing.Size(1189, 225);
            this.dgv.TabIndex = 23;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lemon", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 36);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nombre Cliente:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(385, 172);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(509, 31);
            this.textBox3.TabIndex = 25;
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lemon", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 36);
            this.label4.TabIndex = 27;
            this.label4.Text = "NIT o CI Cliente:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(385, 239);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(509, 31);
            this.textBox4.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(426, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(559, 65);
            this.label6.TabIndex = 31;
            this.label6.Text = "Supermercado Lider";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Playball", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(624, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 60);
            this.label5.TabIndex = 32;
            this.label5.Text = "Factura";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(410, 668);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 80);
            this.button5.TabIndex = 34;
            this.button5.Text = "Mostrar Factura";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(731, 668);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 80);
            this.button6.TabIndex = 35;
            this.button6.Text = "Guardar Transaccion";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(376, 296);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(331, 31);
            this.textBox5.TabIndex = 36;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Descripción";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Precio Unit";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.Width = 162;
            // 
            // butBuscar
            // 
            this.butBuscar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.butBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butBuscar.Cursor = System.Windows.Forms.Cursors.No;
            this.butBuscar.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butBuscar.Image = global::Yummy.Properties.Resources.buscar3;
            this.butBuscar.Location = new System.Drawing.Point(941, 181);
            this.butBuscar.Name = "butBuscar";
            this.butBuscar.Size = new System.Drawing.Size(74, 70);
            this.butBuscar.TabIndex = 29;
            this.butBuscar.UseVisualStyleBackColor = false;
            this.butBuscar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Registrar
            // 
            this.Registrar.BackColor = System.Drawing.Color.IndianRed;
            this.Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Registrar.Font = new System.Drawing.Font("Ravie", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Registrar.Image = global::Yummy.Properties.Resources.registro2;
            this.Registrar.Location = new System.Drawing.Point(1042, 181);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(89, 63);
            this.Registrar.TabIndex = 26;
            this.Registrar.UseVisualStyleBackColor = false;
            this.Registrar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 856);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.butBuscar);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.Añadir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Añadir;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button butBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}


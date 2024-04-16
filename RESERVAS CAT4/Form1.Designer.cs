namespace RESERVAS_CAT4
{
    partial class ReservaVuelos
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
            this.idavuelta = new System.Windows.Forms.CheckBox();
            this.ida = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btbuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbeleccion = new System.Windows.Forms.ComboBox();
            this.cbeleccion1 = new System.Windows.Forms.ComboBox();
            this.vf = new System.Windows.Forms.Button();
            this.vf1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // idavuelta
            // 
            this.idavuelta.AutoSize = true;
            this.idavuelta.Location = new System.Drawing.Point(60, 54);
            this.idavuelta.Name = "idavuelta";
            this.idavuelta.Size = new System.Drawing.Size(81, 17);
            this.idavuelta.TabIndex = 2;
            this.idavuelta.Text = "Ida y vuelta";
            this.idavuelta.UseVisualStyleBackColor = true;
            this.idavuelta.CheckedChanged += new System.EventHandler(this.idavuelta_CheckedChanged);
            // 
            // ida
            // 
            this.ida.AutoSize = true;
            this.ida.Location = new System.Drawing.Point(180, 54);
            this.ida.Name = "ida";
            this.ida.Size = new System.Drawing.Size(64, 17);
            this.ida.TabIndex = 3;
            this.ida.Text = "Solo ida";
            this.ida.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(251, 122);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(50, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(341, 122);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(45, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(374, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tu proximo destino ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(375, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Te esta esperando";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(374, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 33);
            this.label3.TabIndex = 12;
            this.label3.Text = "COP  1.200.000";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RESERVAS_CAT4.Properties.Resources.rojo;
            this.pictureBox3.Location = new System.Drawing.Point(368, 194);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(319, 132);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RESERVAS_CAT4.Properties.Resources.playa;
            this.pictureBox2.Location = new System.Drawing.Point(60, 194);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(308, 134);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RESERVAS_CAT4.Properties.Resources.airport;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(809, 473);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(590, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Compra ya";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btbuscar
            // 
            this.btbuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.btbuscar.BackColor = System.Drawing.Color.Black;
            this.btbuscar.ForeColor = System.Drawing.Color.White;
            this.btbuscar.Location = new System.Drawing.Point(541, 123);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(75, 23);
            this.btbuscar.TabIndex = 14;
            this.btbuscar.Text = "Buscar";
            this.btbuscar.UseVisualStyleBackColor = false;
            this.btbuscar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(57, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Origen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Destino";
            // 
            // cbeleccion
            // 
            this.cbeleccion.FormattingEnabled = true;
            this.cbeleccion.Location = new System.Drawing.Point(50, 129);
            this.cbeleccion.Name = "cbeleccion";
            this.cbeleccion.Size = new System.Drawing.Size(80, 21);
            this.cbeleccion.TabIndex = 17;
            this.cbeleccion.SelectedIndexChanged += new System.EventHandler(this.cbeleccion_SelectedIndexChanged);
            // 
            // cbeleccion1
            // 
            this.cbeleccion1.FormattingEnabled = true;
            this.cbeleccion1.Location = new System.Drawing.Point(136, 129);
            this.cbeleccion1.Name = "cbeleccion1";
            this.cbeleccion1.Size = new System.Drawing.Size(77, 21);
            this.cbeleccion1.TabIndex = 18;
            this.cbeleccion1.SelectedIndexChanged += new System.EventHandler(this.cbeleccion2_SelectedIndexChanged);
            // 
            // vf
            // 
            this.vf.Location = new System.Drawing.Point(50, 157);
            this.vf.Name = "vf";
            this.vf.Size = new System.Drawing.Size(80, 23);
            this.vf.TabIndex = 19;
            this.vf.Text = "verificar";
            this.vf.UseVisualStyleBackColor = true;
            this.vf.Click += new System.EventHandler(this.vf_Click);
            // 
            // vf1
            // 
            this.vf1.Location = new System.Drawing.Point(136, 156);
            this.vf1.Name = "vf1";
            this.vf1.Size = new System.Drawing.Size(75, 23);
            this.vf1.TabIndex = 20;
            this.vf1.Text = "verificar";
            this.vf1.UseVisualStyleBackColor = true;
            this.vf1.Click += new System.EventHandler(this.vf1_Click);
            // 
            // ReservaVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vf1);
            this.Controls.Add(this.vf);
            this.Controls.Add(this.cbeleccion1);
            this.Controls.Add(this.cbeleccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ida);
            this.Controls.Add(this.idavuelta);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ReservaVuelos";
            this.Text = "VUELOS CAT4";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ReservaVuelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox idavuelta;
        private System.Windows.Forms.CheckBox ida;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btbuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbeleccion;
        private System.Windows.Forms.ComboBox cbeleccion1;
        private System.Windows.Forms.Button vf;
        private System.Windows.Forms.Button vf1;
    }
}


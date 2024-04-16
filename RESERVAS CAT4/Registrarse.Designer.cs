namespace RESERVAS_CAT4
{
    partial class Registrarse
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtpast = new System.Windows.Forms.TextBox();
            this.txtfec = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtcont = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NombreCompleto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de pasaporte ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Registrarse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(225, 73);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(100, 20);
            this.txtnom.TabIndex = 6;
            // 
            // txtpast
            // 
            this.txtpast.Location = new System.Drawing.Point(225, 110);
            this.txtpast.Name = "txtpast";
            this.txtpast.Size = new System.Drawing.Size(100, 20);
            this.txtpast.TabIndex = 7;
            // 
            // txtfec
            // 
            this.txtfec.Location = new System.Drawing.Point(225, 147);
            this.txtfec.Name = "txtfec";
            this.txtfec.Size = new System.Drawing.Size(100, 20);
            this.txtfec.TabIndex = 8;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(225, 176);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(100, 20);
            this.txttel.TabIndex = 9;
            // 
            // txtcont
            // 
            this.txtcont.Location = new System.Drawing.Point(194, 242);
            this.txtcont.Name = "txtcont";
            this.txtcont.PasswordChar = '*';
            this.txtcont.Size = new System.Drawing.Size(100, 20);
            this.txtcont.TabIndex = 10;
            this.txtcont.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(225, 44);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 12;
            // 
            // Registrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcont);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtfec);
            this.Controls.Add(this.txtpast);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registrarse";
            this.Text = "Registrarse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtpast;
        private System.Windows.Forms.TextBox txtfec;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtcont;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtid;
    }
}
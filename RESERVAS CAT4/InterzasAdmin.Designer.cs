namespace RESERVAS_CAT4
{
    partial class InterzasAdmin
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
            this.p = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txid = new System.Windows.Forms.TextBox();
            this.txnom = new System.Windows.Forms.TextBox();
            this.btad = new System.Windows.Forms.Button();
            this.txpt = new System.Windows.Forms.TextBox();
            this.txdt = new System.Windows.Forms.TextBox();
            this.txtf = new System.Windows.Forms.TextBox();
            this.txco = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.Location = new System.Drawing.Point(93, 53);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(16, 13);
            this.p.TabIndex = 0;
            this.p.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero pasaporte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono";
            // 
            // txid
            // 
            this.txid.Location = new System.Drawing.Point(256, 53);
            this.txid.Name = "txid";
            this.txid.Size = new System.Drawing.Size(100, 20);
            this.txid.TabIndex = 6;
            // 
            // txnom
            // 
            this.txnom.Location = new System.Drawing.Point(256, 90);
            this.txnom.Name = "txnom";
            this.txnom.Size = new System.Drawing.Size(100, 20);
            this.txnom.TabIndex = 7;
            // 
            // btad
            // 
            this.btad.Location = new System.Drawing.Point(202, 369);
            this.btad.Name = "btad";
            this.btad.Size = new System.Drawing.Size(75, 23);
            this.btad.TabIndex = 8;
            this.btad.Text = "Enviar";
            this.btad.UseVisualStyleBackColor = true;
            this.btad.Click += new System.EventHandler(this.btad_Click);
            // 
            // txpt
            // 
            this.txpt.Location = new System.Drawing.Point(256, 143);
            this.txpt.Name = "txpt";
            this.txpt.Size = new System.Drawing.Size(100, 20);
            this.txpt.TabIndex = 9;
            // 
            // txdt
            // 
            this.txdt.Location = new System.Drawing.Point(256, 186);
            this.txdt.Name = "txdt";
            this.txdt.Size = new System.Drawing.Size(100, 20);
            this.txdt.TabIndex = 10;
            // 
            // txtf
            // 
            this.txtf.Location = new System.Drawing.Point(256, 238);
            this.txtf.Name = "txtf";
            this.txtf.Size = new System.Drawing.Size(100, 20);
            this.txtf.TabIndex = 11;
            // 
            // txco
            // 
            this.txco.Location = new System.Drawing.Point(256, 284);
            this.txco.Name = "txco";
            this.txco.Size = new System.Drawing.Size(100, 20);
            this.txco.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(485, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(378, 321);
            this.dataGridView1.TabIndex = 14;
            // 
            // InterzasAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txco);
            this.Controls.Add(this.txtf);
            this.Controls.Add(this.txdt);
            this.Controls.Add(this.txpt);
            this.Controls.Add(this.btad);
            this.Controls.Add(this.txnom);
            this.Controls.Add(this.txid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.p);
            this.Name = "InterzasAdmin";
            this.Text = "InterzasAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label p;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txid;
        private System.Windows.Forms.TextBox txnom;
        private System.Windows.Forms.Button btad;
        private System.Windows.Forms.TextBox txpt;
        private System.Windows.Forms.TextBox txdt;
        private System.Windows.Forms.TextBox txtf;
        private System.Windows.Forms.TextBox txco;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
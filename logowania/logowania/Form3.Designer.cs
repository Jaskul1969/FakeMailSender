namespace logowania
{
    partial class Form3
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
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTytul = new System.Windows.Forms.TextBox();
            this.txtTresc = new System.Windows.Forms.TextBox();
            this.btnWyczysc = new System.Windows.Forms.Button();
            this.btnWyslij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(66, 9);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(622, 20);
            this.txtAdres.TabIndex = 1;
            this.txtAdres.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tytuł";
            // 
            // txtTytul
            // 
            this.txtTytul.Location = new System.Drawing.Point(66, 40);
            this.txtTytul.Name = "txtTytul";
            this.txtTytul.Size = new System.Drawing.Size(622, 20);
            this.txtTytul.TabIndex = 4;
            this.txtTytul.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtTresc
            // 
            this.txtTresc.Location = new System.Drawing.Point(15, 73);
            this.txtTresc.Multiline = true;
            this.txtTresc.Name = "txtTresc";
            this.txtTresc.Size = new System.Drawing.Size(673, 436);
            this.txtTresc.TabIndex = 5;
            this.txtTresc.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnWyczysc
            // 
            this.btnWyczysc.Location = new System.Drawing.Point(15, 516);
            this.btnWyczysc.Name = "btnWyczysc";
            this.btnWyczysc.Size = new System.Drawing.Size(318, 34);
            this.btnWyczysc.TabIndex = 6;
            this.btnWyczysc.Text = "Wyczyść";
            this.btnWyczysc.UseVisualStyleBackColor = true;
            this.btnWyczysc.Click += new System.EventHandler(this.btnWyczysc_Click);
            // 
            // btnWyslij
            // 
            this.btnWyslij.Location = new System.Drawing.Point(339, 515);
            this.btnWyslij.Name = "btnWyslij";
            this.btnWyslij.Size = new System.Drawing.Size(349, 34);
            this.btnWyslij.TabIndex = 7;
            this.btnWyslij.Text = "Wyślij";
            this.btnWyslij.UseVisualStyleBackColor = true;
            this.btnWyslij.Click += new System.EventHandler(this.btnWyslij_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 562);
            this.Controls.Add(this.btnWyslij);
            this.Controls.Add(this.btnWyczysc);
            this.Controls.Add(this.txtTresc);
            this.Controls.Add(this.txtTytul);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdres);
            this.Name = "Form3";
            this.Text = "Wyślij Maila";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTytul;
        private System.Windows.Forms.TextBox txtTresc;
        private System.Windows.Forms.Button btnWyczysc;
        private System.Windows.Forms.Button btnWyslij;
    }
}
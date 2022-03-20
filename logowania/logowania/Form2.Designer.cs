namespace logowania
{
    partial class Form2
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
            this.txtNoweHaslo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSkasuj = new System.Windows.Forms.Button();
            this.btnUstaw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNoweHaslo
            // 
            this.txtNoweHaslo.Location = new System.Drawing.Point(12, 25);
            this.txtNoweHaslo.Name = "txtNoweHaslo";
            this.txtNoweHaslo.Size = new System.Drawing.Size(237, 20);
            this.txtNoweHaslo.TabIndex = 0;
            this.txtNoweHaslo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nowe hasło:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSkasuj
            // 
            this.btnSkasuj.Location = new System.Drawing.Point(13, 52);
            this.btnSkasuj.Name = "btnSkasuj";
            this.btnSkasuj.Size = new System.Drawing.Size(111, 35);
            this.btnSkasuj.TabIndex = 2;
            this.btnSkasuj.Text = "Usuń";
            this.btnSkasuj.UseVisualStyleBackColor = true;
            this.btnSkasuj.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUstaw
            // 
            this.btnUstaw.Location = new System.Drawing.Point(138, 52);
            this.btnUstaw.Name = "btnUstaw";
            this.btnUstaw.Size = new System.Drawing.Size(111, 35);
            this.btnUstaw.TabIndex = 3;
            this.btnUstaw.Text = "Zmień";
            this.btnUstaw.UseVisualStyleBackColor = true;
            this.btnUstaw.Click += new System.EventHandler(this.btnUstaw_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 99);
            this.Controls.Add(this.btnUstaw);
            this.Controls.Add(this.btnSkasuj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNoweHaslo);
            this.Name = "Form2";
            this.Text = "Zmiana Hasła";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNoweHaslo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSkasuj;
        private System.Windows.Forms.Button btnUstaw;
    }
}
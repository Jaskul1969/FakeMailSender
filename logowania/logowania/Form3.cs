using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logowania
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
        private void Wyslano()
        {
            DialogResult t =  MessageBox.Show($"Wiadomość została wysłana na adres {txtAdres.Text}. Czy chcesz zobaczyć treść wiadomości?","Wysłano", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (t == DialogResult.Yes)
            {
                DialogResult f = MessageBox.Show($"Oto treść wiadomości  {txtTresc.Text}", "Wysłano", MessageBoxButtons.OK, MessageBoxIcon.None);
                if (f == DialogResult.OK)
                {
                    Close();
                }


            }

        }

        private void btnWyslij_Click(object sender, EventArgs e)
        {
            if(txtAdres.Text == string.Empty)
            {
                DialogResult d = MessageBox.Show("Brak adresata!","Brak adresu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(d == DialogResult.OK)
                {
                    Close();
                }

            }
            if (txtTytul.Text == string.Empty)
            {
               DialogResult wynik =  MessageBox.Show("Brak Tytułu. Czy chcesz wysłać wiadomość bez niego?", "Brak tytułu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(wynik == DialogResult.No)
                {
                    return;
                }
                if (wynik == DialogResult.Yes)
                {
                    Wyslano();
                    Close();
                }

                
            }
            Wyslano();
            Close();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnWyczysc_Click(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

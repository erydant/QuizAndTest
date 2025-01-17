using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizAndTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cb_difficulté.Items.Add("Facile");
            cb_difficulté.Items.Add("Moyen");
            cb_difficulté.Items.Add("Difficile");
            cb_difficulté.Items.Add("Enfer");
            
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {

            if (txt_name.Text != "" && txt_prenom.Text != "")
            {
                string result = "Bonjour ";
                result += txt_prenom.Text + " " + txt_name.Text + "\r\n La difficultés sélectionnée est : " + cb_difficulté.SelectedItem;
                txt_afficher.Text = result;
            }
            else if (txt_name.Text == "" && txt_prenom.Text == "")
            {
                MessageBox.Show("Aucun nom ou prénom n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_name.Text == "")
            {
                MessageBox.Show("Aucun nom n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_prenom.Text == "")
            {
                MessageBox.Show("Aucun prénom n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cb_difficulté_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_difficulté.SelectedItem == "Enfer")
            {
                this.BackColor = Color.Red;
                lbl_rep.Font = new Font(lbl_rep.Font, FontStyle.Bold);
                lbl_name.Font = new Font(lbl_name.Font, FontStyle.Bold);
                lbl_prenom.Font = new Font(lbl_prenom.Font, FontStyle.Bold);
                lbl_difficulté.Font = new Font(lbl_difficulté.Font, FontStyle.Bold);
            }
            else
            {
                this.BackColor = Color.FromArgb(153, 180, 209);
                lbl_rep.Font = new Font(lbl_rep.Font, FontStyle.Regular);
                lbl_name.Font = new Font(lbl_name.Font, FontStyle.Regular);
                lbl_prenom.Font = new Font(lbl_prenom.Font, FontStyle.Regular);
                lbl_difficulté.Font = new Font(lbl_difficulté.Font, FontStyle.Regular);
            }
        }


    }
}

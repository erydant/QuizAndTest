
using QuizAndTest.controleur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuizAndTest
{
    public partial class Form1 : Form
    {
        private DataView dvD;
        difficulteBdd dt_listeDifficulte;
        public Form1()
        {
            InitializeComponent();
            
            dt_listeDifficulte = new difficulteBdd();
            dvD = new DataView(dt_listeDifficulte.GetListeDifficulte());
            cb_difficulté.DataSource = dvD;
            cb_difficulté.DisplayMember = "LABELDIFFICULTE";
            cb_difficulté.ValueMember = "IDDIFFICULTE";

        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            string result = "";
            if (txt_nom.Text != "" && txt_prenom.Text != "" && cb_difficulté.SelectedIndex >= -1)
            {
                result += txt_prenom.Text + " " + txt_nom.Text + "\r\n La difficultés sélectionnée est : " + cb_difficulté.SelectedItem;
                MessageBox.Show(result, "Bonjour", MessageBoxButtons.OK, MessageBoxIcon.Information);
                jeu J = new jeu(txt_nom.Text, txt_prenom.Text, cb_difficulté.SelectedValue.ToString() );
                (System.Windows.Forms.Application.OpenForms["menu"] as menu).openChildForm(J);
                this.Hide();


            }
            else if (txt_nom.Text == "" || txt_prenom.Text == "" || cb_difficulté.SelectedIndex == -1)
            {
                if (txt_nom.Text == "")
                {
                    result = "Aucun nom n'est rentré";
                }
                if (txt_prenom.Text == "")
                {
                    if (txt_nom.Text == "")
                    {
                        result += " et ";
                    }
                    result += "Aucun prénom n'est rentré";
                }
                if (cb_difficulté.SelectedIndex <= -1)
                {
                    if (txt_prenom.Text == "")
                    {                        
                            result += " et ";                       
                    }
                    result += "Vous n'avez pas sélectionner de difficulté";
                }

                MessageBox.Show(result, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void cb_difficulté_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_difficulté.SelectedItem == "Enfer")
            {
                this.BackColor = Color.Red;
                lbl_name.Font = new Font(lbl_name.Font, FontStyle.Bold);
                lbl_prenom.Font = new Font(lbl_prenom.Font, FontStyle.Bold);
                lbl_difficulté.Font = new Font(lbl_difficulté.Font, FontStyle.Bold);
            }
            else
            {
                this.BackColor = Color.FromArgb(153, 180, 209);
                lbl_name.Font = new Font(lbl_name.Font, FontStyle.Regular);
                lbl_prenom.Font = new Font(lbl_prenom.Font, FontStyle.Regular);
                lbl_difficulté.Font = new Font(lbl_difficulté.Font, FontStyle.Regular);
            }
        }

        private void nom_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        



    }
}

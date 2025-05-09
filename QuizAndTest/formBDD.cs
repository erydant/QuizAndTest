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

namespace QuizAndTest
{
    public partial class formBDD : Form
    {
        private DataView dvQ;
        private DataView dvD;
        private DataView dvQR;
        QuestionBDD dt_listeQuestions;
        difficulteBdd dt_listeDifficulte;      

        public formBDD()
        {
            InitializeComponent();
            dt_listeQuestions = new QuestionBDD();
            dt_listeDifficulte = new difficulteBdd();

             dvQ = new DataView(dt_listeQuestions.GetListeQuestion());
             dvD = new DataView(dt_listeDifficulte.GetListeDifficulte());

            dgv_questions.DataSource = dvQ;


            dgv_questions.Columns["IDQUESTION"].Visible = false;

            dgv_questions.Columns["enoncé"].Width = 190;


            cb_difficulte.DataSource = dvD;
            cb_difficulte.DisplayMember = "LABELDIFFICULTE";
            cb_difficulte.ValueMember = "IDDIFFICULTE";

        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_rechercheMot_TextChanged(object sender, EventArgs e)
        {
            
            dvQR = new DataView(dt_listeQuestions.GetListeQuestionRecherche(txt_rechercheMot.Text, cb_difficulte.SelectedIndex));
            dgv_questions.DataSource = dvQR;
        }

        private void cb_difficulte_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dvQR = new DataView(dt_listeQuestions.GetListeQuestionRecherche(txt_rechercheMot.Text, cb_difficulte.SelectedIndex));
            dgv_questions.DataSource = dvQR;
        }
    }
}

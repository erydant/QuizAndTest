
using QuizAndTest.controleur;
using QuizzAndTest.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QuizAndTest
{
    public partial class jeu : Form
    {
        int reponseQuestion = 0;
        Partie partie;
        private DataView dvQ;
        QuestionBDD dt_listeQuestion;
        private void Init(int diff)
        {
            InitializeComponent();

            //Déclaration d'une nouvelle liste
            dt_listeQuestion = new QuestionBDD();
            List<Question> ListeQuestions = dt_listeQuestion.GetListeQuestionDiff(diff);

            partie = new Partie(ListeQuestions);

            partie.changerQuestion(txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, gb_reponse, pb_valide,this);
            pb_dureeRepQuestion.Value = 0;
            partie.gestionTimer(txt_timer, pb_dureeRepQuestion, txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, this, gb_reponse, pb_valide, lbl_numero);

        }
        public jeu(string nomJ, string prenomJ, string difficultePartie)
        {
            Init(Convert.ToInt32(difficultePartie));
            string nom_prenom = nomJ + " " + prenomJ;
            nom_tb.Text = nom_prenom;
            difficulte_tb.Text = difficultePartie;
        }
        
        
        
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void b_valider_Click(object sender, EventArgs e)
        {
            partie.validerReponse(reponseQuestion);
            partie.numeroQuestion++;
            partie.changerQuestion(txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, gb_reponse, pb_valide,this);
            lbl_numero.Text = "Question "+(partie.numeroQuestion + 1).ToString();
            reponseQuestion = 0;
            pb_dureeRepQuestion.Value = 0;
        }

      



        private void ckb_reponse1_Click(object sender, EventArgs e)
        {
            foreach (var box in gb_reponse.Controls.OfType<CheckBox>())
            {
                box.Checked = false;
            }

            ((CheckBox)sender).Checked = true;
            reponseQuestion = Convert.ToInt32(((CheckBox)sender).Name.Substring(11,1));
        }

        private void txt_timer_TextChanged(object sender, EventArgs e)
        {

        }

        private void jeu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void difficulte_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


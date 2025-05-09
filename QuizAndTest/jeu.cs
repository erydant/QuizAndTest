
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

        private void Init()
        {
            InitializeComponent();

            List<Question> ListeQuestions = new List<Question>();
            ListeQuestions.Add(new Question("Quelle est la capitale de la France ?", 1, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de l'Espagne ?", 4, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de l'Allemagne ?", 3, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de l'Italie ?", 5, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de l'Angleterre ?", 2, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de la Belgique ?", 1, 1, "Bruxelles", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de la Suisse ?", 2, 1, "Bruxelles", "Berne", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale du Luxembourg ?", 3, 1, "Bruxelles", "Berne", "Luxembourg", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale du Portugal ?", 4, 1, "Bruxelles", "Berne", "Luxembourg", "Lisbonne", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de l'Autriche ?", 5, 1, "Bruxelles", "Berne", "Luxembourg", "Lisbonne", "Vienne"));

            partie = new Partie(ListeQuestions);

            partie.changerQuestion(txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, gb_reponse, pb_valide,this);
            pb_dureeRepQuestion.Value = 0;
            partie.gestionTimer(txt_timer, pb_dureeRepQuestion, txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, this, gb_reponse, pb_valide, lbl_numero);

        }
        public jeu(string nomJ, string prenomJ, string difficultePartie)
        {
            Init();
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
       



    }
}


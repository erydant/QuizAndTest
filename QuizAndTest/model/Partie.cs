using QuizAndTest;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizzAndTest.Model
{
    public class Partie
    {
        public int score;
        public string difficulte;
        public List<Question> questions;
        public int numeroQuestion;
        public int nombreQuestions;
        public int reponseValidQuestion;
        public string nomJoueur;
        public string prenomJoueur;
        public int dureePartie;
        public int dureeTQuestion;
        public Timer timer;
        private menu SF;


        public Partie(List<Question> ListeQuestions)
        {
            score = 0;
            difficulte = "";
            numeroQuestion = 0;
            questions = ListeQuestions;
            nombreQuestions = questions.Count;
           
        }
        public Partie(List<Question> ListeQuestions, string nomJ, string prenomJ, string difficulteJ)
        {
            score = 0;
            difficulte = difficulteJ;
            numeroQuestion = 0;
            questions = ListeQuestions;
            nombreQuestions = questions.Count;
            nomJoueur = nomJ;
            prenomJoueur = prenomJ;
        }

        public void validerReponse(int reponse)
        {
            if (reponse == reponseValidQuestion)
            {
                calculerScore(true);
                
            }
            else
            {
                calculerScore(false);
                

            }
        }

        private void calculerScore(bool BonneReponse)
        {
            if (BonneReponse)
            {
                score++;
            }

        }

        

        public void finDePartie(TextBox txt_affichage, CheckBox ckb_reponse1, CheckBox ckb_reponse2, CheckBox ckb_reponse3, CheckBox ckb_reponse4, CheckBox ckb_reponse5, GroupBox gd_reponse, PictureBox PbImage, Form formulaire)
        {
            DialogResult msg;
            timer.Stop();
            msg = MessageBox.Show("Votre score est de " + score + ".\r\n vous avez fini la partie en " + dureePartie + " secondes.\r\n Voulez vous rejouer", "Fin de la partie"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (msg == DialogResult.Yes)
            {
                score = 0;
                numeroQuestion = 0;
                dureePartie = 0;
                changerQuestion(txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, gd_reponse, PbImage, formulaire);
                
                timer.Start();
            }
            else
            {
                    menu SF = new menu();
                    (System.Windows.Forms.Application.OpenForms["menu"] as menu).openChildForm(SF);
                    formulaire.Close();
                    SF.Close();

            }



        }

        public void changerQuestion(TextBox txt_affichage, CheckBox ckb_reponse1, CheckBox ckb_reponse2, CheckBox ckb_reponse3, CheckBox ckb_reponse4, CheckBox ckb_reponse5, GroupBox gd_reponse, PictureBox PbImage, Form formulaire)
        {

            if (nombreQuestions > numeroQuestion)
            {
                aleatoireReponde(txt_affichage, gd_reponse);
                ckb_reponse1.Checked = false;
                ckb_reponse2.Checked = false;
                ckb_reponse3.Checked = false;
                ckb_reponse4.Checked = false;
                ckb_reponse5.Checked = false;

            }
            else
            {
                
                finDePartie(txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, gd_reponse, PbImage, formulaire);


            }
        }

        private void aleatoireReponde(TextBox txt_affichage, GroupBox gd_reponse)
        {
            int bonneReponse = questions[numeroQuestion].reponse;
            txt_affichage.Text = questions[numeroQuestion].enonce;
            List<int> reponseAleatoire = new List<int>() { 1, 2, 3, 4, 5 };
            Random rnd = new Random();

            for (int i = 1; i <= 5; i++)
            {
                int randIndex = rnd.Next(reponseAleatoire.Count);
                int random = reponseAleatoire[randIndex];
                reponseAleatoire.Remove(random);
                string reponse = "";
                switch (random)
                {
                    case 1:
                        reponse = questions[numeroQuestion].proposition1;
                        break;
                    case 2:
                        reponse = questions[numeroQuestion].proposition2;
                        break;
                    case 3:
                        reponse = questions[numeroQuestion].proposition3;
                        break;
                    case 4:
                        reponse = questions[numeroQuestion].proposition4;
                        break;
                    case 5:
                        reponse = questions[numeroQuestion].proposition5;
                        break;
                }
                getTextBox(i, gd_reponse).Text = reponse;
                if (bonneReponse == random)
                {
                    reponseValidQuestion = i;
                }


            }

        }
        private CheckBox getTextBox(int indice, GroupBox gd_reponse)
        {
            foreach (Control c in gd_reponse.Controls)
            {
                if (c.GetType() == typeof(CheckBox) && c.Name == "ckb_reponse" + indice.ToString())
                {

                    return ((CheckBox)c);

                }
            }
            return null;

        }
        
        public void gestionTimer(TextBox txt_timer, ProgressBar pb_dureeRepQuestion, TextBox txt_affichage, CheckBox ckb_reponse1, CheckBox ckb_reponse2, CheckBox ckb_reponse3, CheckBox ckb_reponse4, CheckBox ckb_reponse5, Form formulaire, GroupBox gd_reponse, PictureBox PbImage, Label lblquestion)
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (sender, e) => Timer_Tick(sender, e, txt_timer, pb_dureeRepQuestion, txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, gd_reponse, PbImage, lblquestion,formulaire);

            timer.Start();
        }

        public void Timer_Tick(object sender, EventArgs e, TextBox txt_timer, ProgressBar pb_dureeRepQuestion, TextBox txt_affichage, CheckBox ckb_reponse1, CheckBox ckb_reponse2, CheckBox ckb_reponse3, CheckBox ckb_reponse4, CheckBox ckb_reponse5, GroupBox gd_reponse, PictureBox PbImage,Label lblquestion, Form formulaire)
        {
            dureePartie++;
            dureeTQuestion++;
            pb_dureeRepQuestion.Increment(1);
            txt_timer.Text = dureePartie.ToString() + " sec";
            if (dureeTQuestion > 15)
            {
                validerReponse(0);
                numeroQuestion++;
                lblquestion.Text = "Question " + (numeroQuestion + 1).ToString();
                changerQuestion(txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, gd_reponse, PbImage,formulaire);
                pb_dureeRepQuestion.Value = 0;
                dureeTQuestion = 0;
            }
        }
        

    }
}

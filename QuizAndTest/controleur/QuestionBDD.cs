using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace QuizAndTest.controleur
{
    public class QuestionBDD
    {
        public DataTable GetListeQuestion()
        {
            DataTable dt = new DataTable();
            ConnetionBDD conn = new ConnetionBDD();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT `IDQUESTION`, `ENONCEQUESTION` as 'enoncé', `REPONSE1QUESTION` as rep1, `REPONSE2QUESTION` as rep2, `REPONSE3QUESTION` as rep3, `REPONSE4QUESTION` as rep4, `REPONSE5QUESTION` as rep5, `BONREPQUESTION` as bonneRep, LABELDIFFICULTE as difficulté FROM QUESTION INNER JOIN DIFFICULTE ON QUESTION.IDDIFFICULTE = DIFFICULTE.IDDIFFICULTE;", conn.MySqlCo))
                {
                    conn.MySqlCo.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            conn.MySqlCo.Close();
            conn.MySqlCo = null;
            return dt;
        }
        public DataTable GetListeQuestionRecherche(string rechercheMot, int difficultee)
        {
            DataTable dt = new DataTable();
            string rqtSql = "SELECT `IDQUESTION`, `ENONCEQUESTION` as 'enoncé', `REPONSE1QUESTION` as rep1, `REPONSE2QUESTION` as rep2, `REPONSE3QUESTION` as rep3, `REPONSE4QUESTION` as rep4, `REPONSE5QUESTION` as rep5, `BONREPQUESTION` as bonneRep,LABELDIFFICULTE as difficulté FROM QUESTION INNER JOIN DIFFICULTE ON QUESTION.IDDIFFICULTE = DIFFICULTE.IDDIFFICULTE WHERE DIFFICULTE.IDDIFFICULTE = @difficulte AND ENONCEQUESTION LIKE @rechercheMot;";
            try
            {
                ConnetionBDD conn = new ConnetionBDD();
                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.MySqlCo))
                {
                    conn.MySqlCo.Open();
                    cmd.Parameters.AddWithValue("@rechercheMot", "%" + rechercheMot + "%");
                    cmd.Parameters.AddWithValue("@difficulte", difficultee);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dt;
        }

     





    }
}

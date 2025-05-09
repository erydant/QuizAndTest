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
    public class difficulteBdd
    {
        public DataTable GetListeDifficulte()
        {
            DataTable dt = new DataTable();
            ConnetionBDD conn = new ConnetionBDD();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT IDDIFFICULTE, LABELDIFFICULTE FROM DIFFICULTE;", conn.MySqlCo))
                {
                    conn.MySqlCo.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
                DataRow workRow = dt.NewRow();
                workRow[0] = -1;
                workRow[1] = "";
                dt.Rows.InsertAt(workRow, 0);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            conn.MySqlCo.Close();
            conn.MySqlCo = null;
            return dt;
        }
    }
}

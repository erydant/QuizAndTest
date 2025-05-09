using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace QuizAndTest
{
    public class ConnetionBDD
    {
        private MySqlConnection mySqlCo;
        private string serveurBDD;
        private string nomBDD; 
        private string loginBDD; 
        private string mdpBDD;
        private void initConnexion()
        {
            mySqlCo = new MySqlConnection("Server=" + serveurBDD + ";Database=" + nomBDD + ";User ID=" + loginBDD + ";Password=" + mdpBDD);
        }
        public ConnetionBDD()
        {
            this.serveurBDD = "192.168.10.16";
            this.nomBDD = "chauvat_jeremy_QuizzAndTest";  
            this.loginBDD = "chauvat_jeremy";
            this.mdpBDD = "2eJ6CHC5";
            initConnexion();
        }
        public MySqlConnection MySqlCo
        {
            get { return mySqlCo; }
            set { mySqlCo = value; }
        }
    }
}

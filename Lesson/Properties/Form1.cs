using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Properties
{
    public class Form1
    {
        
        public Form1(string Login, string Password) {
            this.Login = Login;
            this.Password = Password;
            this.IdUser++;
        }

        public string getLogin()
        {
            return this.Login;
        }

        public string getPassword()
        {
            return this.Password;   
        }

        public int getId()
        {
           return this.IdUser;
        }

        private int IdUser;
        private string Login;
        private string Password;

    }

        
}

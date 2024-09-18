using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddUsers
{
    public class User
    {
        public int scoreId = 0;
        public int id;
        public string fullName;
        public string email;
        public string login;
        public string password;
        public int passportId;
        public string sex;
        public int indificationCode;

        public User(string fullName, string email, string password, string login = null, int passportId = 0, string sex = null, int indificationCode = 0 )
        {
            scoreId++;
            id = scoreId;
            this.fullName = fullName;
            this.email = email;
            this.password = password;
            this.login = login;
            this.passportId = passportId;
            this.sex = sex;
            this.indificationCode = indificationCode;
        }
    }
}

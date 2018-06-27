using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class User
    {
        private string username;
        private string password;

      
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;

        }

        public void setUsername(string username)
        {        
                this.username = username;       
        }

        public void setPassword(string password)
        {
                this.password = password;      
        }
        public string getUsername()
        {
            return username;
        }
        public string getPassword()
        {
            return password;
        }

      
    }
    
}

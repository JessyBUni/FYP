using System;
namespace detail_test.Services
{
    [Serializable] public class User
    {

        public string Username;
        public string password;
        public bool activateToken;
        public int Subscription;
        public int progress;

        public User()
        {

        }
        public User(string name, string pass)
        {

            this.Username = name;
            this.password = pass;
            this.activateToken = false;
            this.Subscription = 1;
            this.progress = 1;
        }
        public User( string name, string pass, bool b)
        {
           
            this.Username = name;
            this.password = pass;
            this.activateToken = b;
            this.Subscription = 1;
            this.progress = 1;
        }
        public User(string name, string pass, bool b,int s)
        {
           
            this.Username = name;
            this.password = pass;
            this.activateToken = b;
            this.Subscription = s;
            this.progress = 1;
        }
        public void updateProgress(int prog)
        {
            this.progress = prog;
        }
        public void updateSubscription(int sub)
        {
            this.Subscription = sub;
        }
    }
}

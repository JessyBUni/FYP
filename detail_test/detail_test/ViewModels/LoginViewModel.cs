
using System;  
using System.ComponentModel;  
using System.Windows.Input;
using System.Threading.Tasks;
using Xamarin.Forms;
using detail_test.Services;

namespace detail_test.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public Action DisplayInvalidLoginPrompt;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }
        public ICommand SubmitCommand { protected set; get; }
        public bool SubmitInfo (out int subLevel, out int progress,out string ServerCon)
        { 
            if (email==null || password == null)
            {
                //turn on for deploy
                DisplayInvalidLoginPrompt();
                subLevel = 0;
                progress = 0;
                ServerCon = "";             
                return false;
                //subLevel = 1;
                //progress = 3;
                //return true; // turn off for deploy
            }
            MockServer mockServer = new MockServer("",out string ServerConn);
            bool b= mockServer.checkServer(ServerConn,email, password,true, out int sub, out int prog);
            if (b)
            {
                subLevel = sub;
                progress = prog;
                ServerCon = ServerConn;
                return true;
            }
            else
            {
                subLevel = 0;
                progress = 0;
                ServerCon = ServerConn;
                return false;
            }


        }
    }
}
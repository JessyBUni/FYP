using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace detail_test.Services

{
    public class MockServer
    {
        List<User> registeredUsers;
        public MockServer()
        {
            registeredUsers = new List<User>();

            User person = new User("test@gmail.com", "test", false);
            registeredUsers.Add(person);
            person = new User("test", "1", false);
            registeredUsers.Add(person);
        }
        public void updateUserSubscription(string user,int sub)
        {
            User field = new User();
            field = registeredUsers.Find(x => x.Username.Equals(user));
            field.Subscription = sub;
        }
        public void updateUserProgress(string user, int prog)
        {
            User field = new User();
            field = registeredUsers.Find(x => x.Username.Equals(user));
            field.progress = prog;
        }
        public bool checkServer(string user, string pass, bool tok, out int sub, out int prog )
        {
            User field = new User();
            field=registeredUsers.Find(x => x.Username.Equals(user));
            try
            {
                if (field.password==pass)
                {
                    sub = field.Subscription;
                    prog = field.progress;
                    return true;
                }
                else
                {
                    sub = 0;
                    prog = 0;
                    return false;
                }
            }
            catch
            {
                sub = 0;
                prog = 0;
                return false;
            }

        }
    }
}

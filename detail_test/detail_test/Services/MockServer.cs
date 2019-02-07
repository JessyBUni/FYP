using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Linq;
using System.Threading.Tasks;
namespace detail_test.Services

{
    public class MockServer
    {
        public void CreateServer(List<User> registeredUsers, out bool err, out string ServerCon)
        {
            err = false;
            //try
            //{
            ServerCon = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ServerData.bin");
            IFormatter formatter = new BinaryFormatter();

            Stream stream = new FileStream(ServerCon, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, registeredUsers);
            stream.Close();
            err = true;
            /*}
            catch { 
                err= false;
                ServerCon =""; 
            }
        */
        }
        public MockServer(string server,out string ServerConn)
        {
            if (server == "")
            {
                List<User> registeredUsers;
                registeredUsers = new List<User>();

                User person = new User("test@gmail.com", "test", false);
                registeredUsers.Add(person);
                person = new User("test", "1", false);
                registeredUsers.Add(person);
                CreateServer(registeredUsers, out bool err, out string ServerCon);
                ServerConn = ServerCon;
            }
            else
            {
                ServerConn = server;
            }

        }
        public void openServer(string ServerCon, out List<User> registeredUsers)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(ServerCon, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            registeredUsers = (List<User>)formatter.Deserialize(stream);
            //stream.Close();
        }
        public void updateUserSubscription(string ServerCon,string user,int sub)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(ServerCon, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            List<User> registeredUsers = (List<User>)formatter.Deserialize(stream);

            User oldfield = new User();
            oldfield = registeredUsers.Find(x => x.Username.Equals(user));
            User newfield = oldfield;
            oldfield.Subscription = sub;

            registeredUsers.Remove(oldfield);
            registeredUsers.Add(newfield);
            formatter.Serialize(stream, registeredUsers);
            stream.Close();
        }
        public void updateUserProgress(string ServerCon,string user, int prog)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(ServerCon, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            List<User> registeredUsers = (List<User>)formatter.Deserialize(stream);

            User oldfield = new User();
            oldfield = registeredUsers.Find(x => x.Username.Equals(user));
            User newfield = oldfield;
            oldfield.progress = prog;

            registeredUsers.Remove(oldfield);
            registeredUsers.Add(newfield);
            formatter.Serialize(stream, registeredUsers);
            stream.Close();
        }
        public bool checkServer(string ServerCon, string user, string pass, bool tok, out int sub, out int prog )
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(ServerCon, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            List<User> registeredUsers = (List<User>)formatter.Deserialize(stream);
            stream.Close();
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

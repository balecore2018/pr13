using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using _13prak.Classes;

namespace _13prak
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public UsersContext usersContext = new Classes.UsersContext();
        public MessagesContext messagesContext = new Classes.MessagesContext();
        public int IdSelectUser = -1;
        public static MainWindow mainWindow;
        public MainWindow()
        {
            InitializeComponent();
            mainWindow = this;
            LoadUser();
        }
        public void LoadUser()
        {
            foreach(Models.Users User in usersContext.AllUsers)
                ParentUser.Children.Add(new Elements.Users(User));
        }
        public void SelectUser(Models.Users User)
        {
            if (User != null)
                IdSelectUser = usersContext.AllUsers.FindIndex(x => x == User);
            parentMessage.Children.Clear();
            foreach (MessagesContext Messages in MessagesContext.AllMessages.FindAll(x=>x.IdUser == IdSelectUser))
                parentMessage.Children.Add(new Elements.Messages(Messages));
            BlockMessage.IsEnabled = true;
        }
        private void SendMessages(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if(e.Key == System.Windows.Input.Key.Enter)
            {
                if (IdSelectUser == -1) return;
                MessagesContext newMessages = new MessagesContext(Message.Text, DateTime.Now, IdSelectUser);
                newMessages.Save();
                Message.Text = "";
                SelectUser(null);
            }
        }
    }
}

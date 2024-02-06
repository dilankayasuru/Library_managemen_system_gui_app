using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS.Forms.SearchUI;

namespace LMS.Forms
{
    public partial class MainWindow : Form
    {
        Library library;
        public MainWindow(Library library)
        {
            this.library = library;
            InitializeComponent();

            this.FormClosed += MainPage_FormClosed;
        }

        public void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var user = LibraryDatabase.getRecords<User>("Users").Find(u => u.UserName == this.username.Text);

            if (user != null && user.userLogin(this.username.Text, this.password.Text))
            {
                if (user.IsAdmin)
                {
                    Librarian activeUser = user as Librarian;
                    this.Hide();
                    LibrarianWindow window = new LibrarianWindow(activeUser, library);
                    window.Show();
                }
                else
                {
                    Member activeUser = user as Member;
                    this.Hide();
                    MemberWindow window = new MemberWindow(activeUser);
                    window.Show();
                }
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password!", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.username.Clear();
                this.password.Clear();
                this.username.Focus();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchResult window = new SearchResult(this.searchTxt.Text);
            window.ShowDialog();
            this.searchTxt.Clear();
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

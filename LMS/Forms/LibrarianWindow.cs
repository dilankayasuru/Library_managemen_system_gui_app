using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Forms
{
    public partial class LibrarianWindow : Form
    {
        Librarian activeUser;
        Library library;
        public LibrarianWindow(Librarian activeUser, Library library)
        {
            this.activeUser = activeUser;
            this.library = library;
            InitializeComponent();
            initializeWindow();
            switchTabs(new LibrarianHome(library));


            this.FormClosing += LibrarianWindow_FormClosing;
            this.FormClosed += LibrarianWindow_FormClosed;
        }

        private void LibrarianWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you realy want to Exit the Application", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void LibrarianWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void switchTabs(UserControl userControlForm)
        {
            userControlForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControlForm);
            userControlForm.BringToFront();
        }

        public void initializeWindow()
        {
            this.adminName.Text = activeUser.FirstName;
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            switchTabs(new LibrarianHome(library));
        }

        private void browseBooksBtn_Click(object sender, EventArgs e)
        {
            switchTabs(new BrowseBooks(library));
        }

        private void manageMembersBtn_Click(object sender, EventArgs e)
        {
            switchTabs(new ManageMembers(activeUser));
        }

        private void manageBooksBtn_Click(object sender, EventArgs e)
        {
            switchTabs(new ManageBooks(library));
        }

        private void issueBtn_Click(object sender, EventArgs e)
        {
            IssueBook window = new IssueBook(activeUser);
            window.ShowDialog();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            ReturnBook window = new ReturnBook(activeUser);
            window.ShowDialog();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            activeUser = null;
            MainWindow window = new MainWindow(library);
            window.Show();
        }
    }
}

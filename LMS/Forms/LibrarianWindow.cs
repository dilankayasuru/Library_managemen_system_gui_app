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
        public LibrarianWindow()
        {
            InitializeComponent();
            switchTabs(new LibrarianHome());
        }

        public void switchTabs(UserControl userControlForm)
        {
            userControlForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControlForm);
            userControlForm.BringToFront();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            switchTabs(new LibrarianHome());
        }

        private void browseBooksBtn_Click(object sender, EventArgs e)
        {
            switchTabs(new BrowseBooks());
        }

        private void manageMembersBtn_Click(object sender, EventArgs e)
        {
            switchTabs(new ManageMembers());
        }

        private void manageBooksBtn_Click(object sender, EventArgs e)
        {
            switchTabs(new ManageBooks());
        }

        private void issueBtn_Click(object sender, EventArgs e)
        {
            IssueBook window = new IssueBook();
            window.ShowDialog();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            ReturnBook window = new ReturnBook();
            window.ShowDialog();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow window = new MainWindow();
            window.Show();
        }
    }
}

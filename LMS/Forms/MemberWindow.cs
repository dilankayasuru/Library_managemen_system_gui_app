using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS.Forms;

namespace LMS.Forms
{
    public partial class MemberWindow : Form
    {
        public MemberWindow()
        {
            InitializeComponent();
            switchTabs(new MemberHome());
        }
        public void switchTabs(UserControl userControlForm)
        {
            userControlForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControlForm);
            userControlForm.BringToFront();
        }

        private void browseBooksBtn_Click(object sender, EventArgs e)
        {
            switchTabs(new BrowseBooks());
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            switchTabs(new MemberHome());
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow window = new MainWindow();
            window.Show();
        }

        private void borrowBtn_Click(object sender, EventArgs e)
        {
            IssueBook window = new IssueBook();
            window.ShowDialog();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            ReturnBook window = new ReturnBook();
            window.ShowDialog();
        }

        private void borrowedBooksBtn_Click(object sender, EventArgs e)
        {
            switchTabs(new ShowBorrowedBooks());
        }
    }
}

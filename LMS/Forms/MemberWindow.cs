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
        Member activeUser;

        public MemberWindow(Member activeUser)
        {
            this.activeUser = activeUser;
            InitializeComponent();
            initializeWindow();
            switchTabs(new MemberHome(activeUser));

            this.FormClosing += MemberWindow_FormClosing;
        }

        private void MemberWindow_FormClosing(object sender, FormClosingEventArgs e)
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
            this.memberName.Text = activeUser.FirstName;
        }

        private void browseBooksBtn_Click(object sender, EventArgs e)
        {
            switchTabs(new BrowseBooks());
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            switchTabs(new MemberHome(activeUser));
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            activeUser = null;
            MainWindow window = new MainWindow(new Library());
            window.Show();
        }

        private void borrowBtn_Click(object sender, EventArgs e)
        {
            IssueBook window = new IssueBook(activeUser);
            window.memberIDtxt.Text = activeUser.Id;
            window.memberIDtxt.Enabled = false;
            window.nameDetailTxt.Text = $"{activeUser.FirstName} {activeUser.LastName}";
            window.idDetailTxt.Text = activeUser.Id;
            window.ShowDialog();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            ReturnBook window = new ReturnBook(activeUser);
            window.memberIDtxt.Text = activeUser.Id;
            window.memberIDtxt.Enabled = false;
            window.nameDetailTxt.Text = $"{activeUser.FirstName} {activeUser.LastName}";
            window.idDetailTxt.Text = activeUser.Id;
            window.ShowDialog();
        }

        private void borrowedBooksBtn_Click(object sender, EventArgs e)
        {
            ShowBorrowedBooks userControlForm = new ShowBorrowedBooks(activeUser);

            if (activeUser.BorrowedBooksISBN.Count <= 0)
            {
                MessageBox.Show("You have not borrowed any book yet!", "No Borrowed Books", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                switchTabs(userControlForm);
            }
        }
    }
}

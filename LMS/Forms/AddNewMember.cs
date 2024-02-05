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
    public partial class AddNewMember : Form
    {
        Librarian librarian;
        public AddNewMember(Librarian librarian)
        {
            this.librarian = librarian;
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            clearText();
            changeBorderToGray();
        }

        private void reEnterPasswordTxt_TextChanged(object sender, EventArgs e)
        {
            if (!(this.passwordTxt.Text == this.reEnterPasswordTxt.Text))
            {
                changeBorderToRed();
            }
            else
            {
                changeBorderToGreen();
            }
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            if (!(this.passwordTxt.Text == this.reEnterPasswordTxt.Text))
            {
                changeBorderToRed();
            }
            else
            {
                changeBorderToGreen();
            }
        }

        private void clearText()
        {
            this.memberIDtxt.Clear();
            this.fnameTxt.Clear();
            this.lnameTxt.Clear();
            this.userNameTxt.Clear();
            this.passwordTxt.Clear();
            this.reEnterPasswordTxt.Clear();
        }
        public void changeBorderToRed()
        {
            this.reEnterPasswordTxt.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            this.reEnterPasswordTxt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            this.reEnterPasswordTxt.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            this.reEnterPasswordTxt.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
        }
        public void changeBorderToGreen()
        {
            this.reEnterPasswordTxt.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.reEnterPasswordTxt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.reEnterPasswordTxt.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.reEnterPasswordTxt.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
        }
        public void changeBorderToGray()
        {
            this.reEnterPasswordTxt.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.reEnterPasswordTxt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.reEnterPasswordTxt.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.reEnterPasswordTxt.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (this.memberIDtxt.Text == "" || this.userNameTxt.Text == "" || this.passwordTxt.Text == "" || this.fnameTxt.Text == "" || this.lnameTxt.Text == "")
            {
                MessageBox.Show("Please enter valid informatino!", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearText();
            }
            else if (!(this.passwordTxt.Text == this.reEnterPasswordTxt.Text))
            {
                MessageBox.Show("Password not matched!", "Wrong Password!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.passwordTxt.Clear();
                this.reEnterPasswordTxt.Clear();
            }
            else
            {
                try
                {
                    librarian.addNewMember(this.memberIDtxt.Text, this.userNameTxt.Text, this.passwordTxt.Text, this.fnameTxt.Text, this.lnameTxt.Text);
                }
                catch
                {
                    MessageBox.Show("Member already exists!", "Duplicate Entry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    clearText();
                }
            }
        }
    }
}

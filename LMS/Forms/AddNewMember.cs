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
        public AddNewMember()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.memberIDtxt.Clear();
            this.fnameTxt.Clear();
            this.lnameTxt.Clear();
            this.userNameTxt.Clear();
            this.passwordTxt.Clear();
            this.reEnterPasswordTxt.Clear();
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

    }
}

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
    public partial class IssueBook : Form
    {
        public IssueBook()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.ISBNTxt.Clear();
            this.memberIDtxt.Clear();

            this.nameDetailTxt.Clear();
            this.memberIDtxt.Clear();
            this.titleDetailTxt.Clear();
            this.isbnDetailTxt.Clear();
            this.authorDetailTxt.Clear();
            this.publishedYearDetailTxt.Clear();
        }
    }
}

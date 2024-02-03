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
    public partial class AddNewBook : Form
    {
        public AddNewBook()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.bookIdTxt.Clear();
            this.authorTxt.Clear();
            this.titleTxt.Clear();
            this.isbnTxt.Clear();
            this.publishedYearTxt.Clear();
            this.copiesTxt.Clear();
        }
    }
}

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
    public partial class ManageBooks : UserControl
    {
        public ManageBooks()
        {
            InitializeComponent();
            this.filterComboBox.SelectedIndex = 0;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.bookTitleTxt.Clear();
            this.authorTxt.Clear();
            this.ISBNTxt.Clear();
            this.publishedYearTxt.Clear();
            this.copiesTxt.Clear();
            this.bookIdTxt.Clear();
        }

        private void addNewBookBtn_Click(object sender, EventArgs e)
        {
            AddNewBook window = new AddNewBook();
            window.ShowDialog();
        }
    }
}

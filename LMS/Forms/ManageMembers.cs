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
    public partial class ManageMembers : UserControl
    {
        public ManageMembers()
        {
            InitializeComponent();
            this.filterComboBox.SelectedIndex = 2;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.fnameText.Clear();
            this.lnameText.Clear();
            this.idText.Clear();
        }

        private void addNewMemberBtn_Click(object sender, EventArgs e)
        {
            AddNewMember window = new AddNewMember();
            window.ShowDialog();
        }
    }
}

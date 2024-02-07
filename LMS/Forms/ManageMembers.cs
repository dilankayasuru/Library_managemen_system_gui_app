using MongoDB.Libmongocrypt;
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
        Librarian librarian;
        DataTable membersDataTable;
        public ManageMembers(Librarian librarian)
        {
            this.librarian = librarian;
            InitializeComponent();
            initialiseTable();
            this.filterComboBox.SelectedIndex = 2;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            clearTexts();
            initialiseTable();
        }

        private void addNewMemberBtn_Click(object sender, EventArgs e)
        {
            AddNewMember window = new AddNewMember(librarian);
            window.ShowDialog();
            initialiseTable();
        }
        private void clearTexts()
        {
            this.fnameText.Clear();
            this.lnameText.Clear();
            this.idText.Clear();
            this.searchTxt.Clear();
        }
        void initialiseTable()
        {
            membersDataTable = new DataTable();
            membersDataTable.Columns.Add("MemberID", typeof(string));
            membersDataTable.Columns.Add("Username", typeof(string));
            membersDataTable.Columns.Add("FirstName", typeof(string));
            membersDataTable.Columns.Add("LastName", typeof(string));

            populateMembersTable(librarian.getAllMembers());
        }
        void populateMembersTable(List<Member> members)
        {
            foreach (Member member in members)
            {
                membersDataTable.Rows.Add(member.Id, member.UserName, member.FirstName, member.LastName);
            }

            this.membersDataGridView.DataSource = membersDataTable;
        }

        private void filterTable(string attribute, string keyword)
        {
            DataView dataview = membersDataTable.DefaultView;
            dataview.RowFilter = $"{attribute} LIKE '" + keyword + "%'";
            this.membersDataGridView.DataSource = dataview;
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            searchInTable();
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchInTable();
        }

        private void searchInTable()
        {
            switch (filterComboBox.SelectedIndex)
            {
                case 0:
                    filterTable("FirstName", this.searchTxt.Text);
                    break;

                case 1:
                    filterTable("LastName", this.searchTxt.Text);
                    break;

                case 2:
                    filterTable("MemberID", this.searchTxt.Text);
                    break;

            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (isValidatedInputs())
            {
                try
                {
                    librarian.editMemberDetail(this.idText.Text.Trim(), this.fnameText.Text.Trim(), this.lnameText.Text.Trim());
                    initialiseTable();
                    MessageBox.Show("Member saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearTexts();
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Please select a member and double click to edit member information!", "Invalid Information!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearTexts();
                }
            }
            else
            {
                MessageBox.Show("Please enter valid information!", "Invalid Information!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTexts();
            }
        }

        private void membersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.fnameText.Text = membersDataTable.Rows[membersDataGridView.CurrentCell.RowIndex].ItemArray[2].ToString();
            this.lnameText.Text = membersDataTable.Rows[membersDataGridView.CurrentCell.RowIndex].ItemArray[3].ToString();
            this.idText.Text = membersDataTable.Rows[membersDataGridView.CurrentCell.RowIndex].ItemArray[0].ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (isValidatedInputs())
            {
                if (MessageBox.Show($"Are you sure you want to delete {this.fnameText.Text}!", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        librarian.deleteMemberDetail(this.idText.Text);
                        initialiseTable();
                        clearTexts();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.StackTrace, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clearTexts();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter valid information!", "Invalid Information!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTexts();
            }
        }

        private bool isValidatedInputs()
        {
            return this.idText.Text.Trim() != "" && this.fnameText.Text.Trim() != "" && this.lnameText.Text.Trim() != "";
        }
    }
}

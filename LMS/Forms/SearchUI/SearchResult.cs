using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Forms.SearchUI
{
    public partial class SearchResult : Form
    {
        string title;

        public SearchResult(string title)
        {
            this.title = title.Replace(" ", "").ToLower();
            InitializeComponent();
        }

        private void SearchResult_Load(object sender, EventArgs e)
        {
            List<Book> books = new List<Book>();
            books = LibraryDatabase.getRecords<Book>("Books");

            Book book = books.Find(b => b.Title.Replace(" ", "").ToLower() == this.title);

            if (book != null)
            {
                loadPanel(new result(book));
            }
            else
            {
                loadPanel(new nullResult());
            }
        }

        private void loadPanel(UserControl form)
        {
            form.Dock = DockStyle.Fill;
            resultPanel.Controls.Clear();
            resultPanel.Controls.Add(form);
            form.BringToFront();
        }
    }
}

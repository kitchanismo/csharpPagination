using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using kitchanismo;

namespace pagination
{
    public partial class Form1 : Form
    {

        private Pages  page = new Pages();
        private Index index = new Index();
        const int firstPage = 1;
        int        lastPage;
        
        public Form1()
        {
            InitializeComponent();
            InitializePage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CurrentPage(firstPage);
        }

        private void InitializePage()
        {
            page.numPerPage     = 10; // number of item per page
            numIndex.Maximum    = page.count(page.numPerPage);//limit the num index max value
            lblitems.Text       = page.rows().ToString() + " items";
            lblitemPerPage.Text = "Items per page: " + page.numPerPage.ToString();
        }

        private void NavigatePage(int i)
        {
            CurrentPage(Int32.Parse(btn3.Text) + i);

            btn1.Text = (Int32.Parse(btn1.Text) + i).ToString();
            btn2.Text = (Int32.Parse(btn2.Text) + i).ToString();
            btn3.Text = (Int32.Parse(btn3.Text) + i).ToString();

        }
        private void CurrentPage(int i)
        {
            page.fromPage = index.fromItem(i, page.numPerPage);
            page.toPage    = page.numPerPage * i;
            lblpages.Text  = page.getText(page.count(page.numPerPage));
            numIndex.Value = i;

            page.load(lvitems);
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            lastPage  = page.count(page.numPerPage);

            CurrentPage(lastPage);

            btn1.Text = (lastPage - 2).ToString();
            btn2.Text = (lastPage - 1).ToString();
            btn3.Text = lastPage.ToString();
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            CurrentPage(firstPage);

            btn1.Text = "1";
            btn2.Text = "2";
            btn3.Text = "3";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            CurrentPage(Int32.Parse(btn1.Text));
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            CurrentPage(Int32.Parse(btn2.Text));
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            CurrentPage(Int32.Parse(btn3.Text));
        }
       
        private void btnnext_Click(object sender, EventArgs e)
        {
            var pages  = page.count(page.numPerPage).ToString();

            if (pages != btn3.Text)
            {
                //parameter 1 is increment the page
                NavigatePage(1);
            }
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "1")
            {
                CurrentPage(firstPage);
            }
            else
            {
                //parameter -1 is decrement the page
                NavigatePage(-1);
            }
        }

        private void btngoto_Click(object sender, EventArgs e)
        {
            var index = Int32.Parse(numIndex.Value.ToString());
            var pages = page.count(page.numPerPage);

            if (index == Int32.Parse(btn3.Text))
            {
                return;
            }

            if (index < 4)
            {
                CurrentPage(index);
                btn1.Text = "1";
                btn2.Text = "2";
                btn3.Text = "3";
                return;
            }

            if (index <= pages)
            {
                CurrentPage(index);
                btn1.Text = (index - 2).ToString();
                btn2.Text = (index - 1).ToString();
                btn3.Text = index.ToString();
                return;
            }
            
        }

    }
}

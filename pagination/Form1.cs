using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace pagination
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loaddata(1, qtyperpage);
            lblpage.Text = "1 of " + countpage();
            disablebtn(false);
        }

        #region variables
       
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        string query;
        const int qtyperpage = 10; //number of item per page
        int first;
        int second;

        #endregion

        #region buttons
       
        private void btn1_Click(object sender, EventArgs e)
        {
            loaddata(fromqty(Int32.Parse(btn1.Text)), qtyperpage * Int32.Parse(btn1.Text));
            lblpage.Text = btn1.Text + " of " + countpage();
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            loaddata(fromqty(Int32.Parse(btn2.Text)), qtyperpage * Int32.Parse(btn2.Text));
            lblpage.Text = btn2.Text + " of " + countpage();
            btnprev.Enabled = true;
        }
       
        private void btnnext_Click(object sender, EventArgs e)
        {
            if (countpage().ToString() == btn2.Text)
            {
                return;
            }

            first = Int32.Parse(btn1.Text) + 1;
            second = Int32.Parse(btn2.Text) + 1;
            btn1.Text = first.ToString();
            btn2.Text = second.ToString();
            loaddata(fromqty(second), qtyperpage * Int32.Parse(btn2.Text));
            lblpage.Text = second + " of " + countpage();
            btnprev.Enabled = true;
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "1")
            {
                loaddata(1, qtyperpage);
                lblpage.Text = "1 of " + countpage();
                btnprev.Enabled = false; 
                return;
            }
            else if (btn1.Text == "2") { btnprev.Enabled = false; }

            first = Int32.Parse(btn1.Text) - 1;
            second = Int32.Parse(btn2.Text) - 1;
            btn1.Text = first.ToString();
            btn2.Text = second.ToString();
            loaddata(fromqty(second), qtyperpage * Int32.Parse(btn2.Text));
            lblpage.Text = second + " of " + countpage();
        }
        private void btnlast_Click(object sender, EventArgs e)
        {
            loaddata(countrows() - (qtyperpage - 1), countrows());
            first = Int32.Parse(countpage().ToString()) - 1;
            second = Int32.Parse(countpage().ToString());
            btn1.Text = first.ToString();
            btn2.Text = second.ToString();
            lblpage.Text = countpage() + " of " + countpage();
            btnprev.Enabled = true;
        }
        #endregion

        #region methods/functions
      
        void loaddata(int fromqty, int toqty)
        {
            con.Close();
            lvitems.Items.Clear();
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\testdb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            query = " SELECT * FROM tblitems where id >=  " + fromqty + "   AND id <= " + toqty + " order by id";
            con.Open();
            cmd.CommandText = query;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem with_1 = lvitems.Items.Add((dr["id"]).ToString());
                with_1.SubItems.Add(dr["item_name"].ToString());
                with_1.SubItems.Add(dr["qty"].ToString());
            }
            con.Close();
        }

        double countpage()
        {
           int res = countrows() / qtyperpage;
           string str = (Double.Parse(countrows().ToString()) / qtyperpage).ToString();
    
           if (str.Contains("."))
           {
               res += 1;
           }
           return res;
        }
       
        int countrows()
        {
            con.Close();
            int rows = 0;
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\testdb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            query = "SELECT * FROM tblitems";
            con.Open();
            cmd.CommandText = query;
            cmd.Connection = con;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                rows++;
            }
            return rows;
        }
       
  
        int fromqty(int num)
        {
            int j = 1;
            for (int i = 0; i < num - 1; i++)
            {
               j += qtyperpage;    
            }
            return j;
        }

        void disablebtn(bool bl)
        {
            if (countrows() < qtyperpage)
            {
                btn2.Enabled = bl;
                btnlast.Enabled = bl;
                btnnext.Enabled = bl;
            }
        }


        #endregion
    }
}

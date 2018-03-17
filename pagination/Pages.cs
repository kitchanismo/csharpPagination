using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pagination
{
    class Pages: Connection
    {

        public int numPerPage { get; set; }
     
        public int fromPage { get; set; }
        public int toPage { get; set; }

        //load data from database
        public void load(ListView lv)
        {
            
            Connected();
            var cond = "WITH newTable AS (SELECT id, item_name, qty, ROW_NUMBER() OVER(ORDER BY id ASC) AS Row FROM tbltest) ";
            query = "SELECT id, item_name, qty, ROW_NUMBER() OVER(ORDER BY id ASC) AS Row FROM newTable WHERE Row BETWEEN " + fromPage + " AND " + toPage + " ";
            cmd.CommandText = cond + query;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            lv.Items.Clear();
            while (dr.Read())
            {
                ListViewItem with_1 = lv.Items.Add((dr["id"]).ToString());
                with_1.SubItems.Add(dr["item_name"].ToString());
                with_1.SubItems.Add(dr["qty"].ToString());
            }
        }

        //count pages by qty per page
       public int count(int qty)
        {
            double res = Double.Parse(rows().ToString()) / Double.Parse(qty.ToString());

            if (res.ToString().Contains("."))
            {
                res += 1;
            }
            return (int)res;
        }

        //count rows in database
       public int rows()
        {
            var rows = 0;
            Connected();
            query = "SELECT * FROM tbltest";
            cmd.CommandText = query;
            cmd.Connection = con;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                rows++;
            }
            return rows;
        }

      
        public string getText(int toPage) 
        {
            return " of " + toPage;
        }

        public int getFirstIndex(ListView lv)
        {
            return Int32.Parse(lv.Items[0].SubItems[0].Text);
        }

        public int getLastIndex(ListView lv)
        {
            int i = lv.Items.Count - 1;
            return Int32.Parse(lv.Items[i].SubItems[0].Text);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using EasyIo;
using System.Collections;
using System.Windows.Forms;

namespace testCnnoect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            string Msg = string.Empty;
            bool blConn=testConn(ref Msg);
            lbl_light.Visible = true;
            if (blConn)
            {
                lbl_light.ForeColor = Color.Green;
                MessageBox.Show("連線成功");
            }
            else
            {
                lbl_light.ForeColor = Color.Red;
                MessageBox.Show("連線失敗 : \r\n "+ Msg);
            }
        }

        private bool testConn(ref string Msg)
        {
            bool blConn = false;
            try
            {
                string SqlCmd = "Select Top 1 * From [dbo].[T_SSO_User_Cloud_Account]";
                Hashtable hsParm = new Hashtable();
                DB_IO IO = new DB_IO();
                DataSet ds = new DataSet();
                ds = IO.SqlQuery("Conn", SqlCmd, hsParm);
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                int intDataCnt = dt.Rows.Count;
                blConn = true;
            }
            catch (Exception ex)
            {
                Msg = ex.Message;
                blConn = false;
            }
            return blConn;
        }
    }
}

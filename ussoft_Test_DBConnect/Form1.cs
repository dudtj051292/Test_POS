using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
namespace ussoft_Test_DBConnect
{
    public partial class Form1 : Form
    {
        const string connect_info = "DATA SOURCE=database-2.c3gs0qaovgfi.ap-northeast-2.rds.amazonaws.com:1521/orcl; User ID=COMMIN; Password=edu";

        OracleConnection conn = new OracleConnection(connect_info);
        

        public Form1()
        {
            InitializeComponent();
        }

        public void connect_DB()
        {
            conn.Open();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void imageEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //음료 버튼 눌럿을때

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //빵 버튼 눌럿을때
        }
    }
}

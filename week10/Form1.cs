using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace week10
{
    public partial class Form1 : Form
    {


        int i=0;
        //so thu tu cau hoi
        string[] quest= {"Hoa la ai?", "Hoa co khon khong?", "Hoa co nguoi yeu chua?"};

        KetNoi kn = new KetNoi();
        SqlConnection connect_SQL;
        //tao bien kn de ket noi vs SQL

        public Form1()
        {
            InitializeComponent();
            connect_SQL = kn.connect;
        }

        private void Next_button_Click(object sender, EventArgs e)
        {

            Console.WriteLine(quest[i].ToString());
            question_number.Text = "Cau " + Convert.ToString(i + 1);
            question_content.Text = quest[i].ToString();
            i++;
            if(i==3)
                Next_button.Enabled = false;
            
                
        }

        private void Check_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect_SQL.State == ConnectionState.Closed)
                    connect_SQL.Open();
                //ket noi toi SQL

                string check_command;
                check_command = "select ";
                SqlCommand cmd = new SqlCommand(check_command, connect_SQL);
                cmd.ExecuteReader();


                //dong ket noi SQL
                if (connect_SQL.State == ConnectionState.Open)
                    connect_SQL.Close();
                MessageBox.Show("Thanh cong");
            }

            catch (Exception ex)
            {
                MessageBox.Show("That bai");
            }
        }
    }
}

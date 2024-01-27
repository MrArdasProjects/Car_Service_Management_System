using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArunaCarServices
{
    public partial class Form1 : Form
    {
        String connectionString = @"Data Source=Matebook16s\MSSQLSERVER01;Initial Catalog=ARUNA";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String username = txt_username.Text;
            String password = txt_password.Text;
            
            SqlConnection conn = new SqlConnection(@"Data Source=Matebook16s\MSSQLSERVER01;Initial Catalog=ARUNA; User ID = admin; Password = admin; Integrated Security = True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.users JOIN dbo.roles ON users.role_id = roles.ID where username = '" + username+"'  and password = '"+password+"' ",conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(rdr);

            if(dt.Rows.Count > 0)
            {
                
                if (dt.Rows[0]["name"].ToString().Replace(" ","") == "ADMIN")
                {
                    Menu myForm = new Menu(true);
                    this.Hide();
                    myForm.Show();
                }
                else
                {
                    Menu myForm = new Menu(false);
                    this.Hide();
                    myForm.Show();
                }

            }
            else
            {
                MessageBox.Show("Giriş başarısız");
            }

            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

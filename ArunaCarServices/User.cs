using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArunaCarServices
{
    public partial class User : Form
    {
        private int userID;
        private Menu _menu;
        public User(Menu menü)
        {
            InitializeComponent();
            _menu = menü;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Query = "Insert into users(first_name,last_name,username,password,phone,mail,adress, role_id) values ('" + this.txt_first_name.Text + "','" + this.txt_last_name.Text + "','" + this.txt_username.Text + "','" + this.txt_password.Text + "','" + this.txt_phone.Text + "','" + this.txt_mail.Text + "','" + this.txt_adres.Text + "',2)";
            SqlConnection conn = new SqlConnection(@"Data Source=Matebook16s\MSSQLSERVER01;Initial Catalog=ARUNA; User ID = admin; Password = admin; Integrated Security = True");
            SqlCommand cmd = new SqlCommand(Query, conn);
            SqlDataReader dr;
            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Saved");
                while (dr.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txt_first_name.Text = String.Empty;
            txt_last_name.Text = String.Empty;
            txt_username.Text = String.Empty;
            txt_password.Text = String.Empty;
            txt_phone.Text = String.Empty;
            txt_mail.Text = String.Empty;
            txt_adres.Text = String.Empty;
            this.Hide();
            _menu.usersData();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde güncelle butonunu gizle
            update.Visible = false;

            // Eğer yeni personel ekleniyorsa (ID 0 ise), güncelle butonunu gizle
            if (userID > 0)
            {
                update.Visible = true;
            }
        }
        public void SetBilgiler(string ad, string soyisim, string username, string password, string telefon, string mail, string adress, int id, int role_id)
        {
            txt_first_name.Text = ad; // Örneğin, txtAd adlı bir TextBox kontrolü
            txt_last_name.Text = soyisim; // Örneğin, txtTelefon adlı bir TextBox kontrolü
            txt_phone.Text = telefon;
            txt_username.Text = username;
            txt_password.Text = password;
            txt_mail.Text = mail;
            txt_adres.Text = adress;
            userID = id;

            

            if (id > 0)
            {

                button1.Visible = false;
                update.Visible = true;
            }
            else
            {
                button1.Visible = true;
                update.Visible = false;
            }

            


        }

        private void update_Click(object sender, EventArgs e)
        {
            string Query = "UPDATE users SET first_name='" + this.txt_first_name.Text + "', last_name='" + this.txt_last_name.Text + "', username='" + this.txt_username.Text + "', password='" + this.txt_password.Text + "', phone='" + this.txt_phone.Text + "', mail='" + this.txt_mail.Text + "', adress='" + this.txt_adres.Text + "' WHERE ID=" + userID;
            SqlConnection conn = new SqlConnection(@"Data Source=Matebook16s\MSSQLSERVER01;Initial Catalog=ARUNA; User ID = admin; Password = admin; Integrated Security = True");
            SqlCommand cmd = new SqlCommand(Query, conn);
            SqlDataReader dr;
            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Saved");
                while (dr.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txt_first_name.Text = String.Empty;
            txt_last_name.Text = String.Empty;
            txt_username.Text = String.Empty;
            txt_password.Text = String.Empty;
            txt_phone.Text = String.Empty;
            txt_mail.Text = String.Empty;
            txt_adres.Text = String.Empty;
            this.Hide();
            _menu.usersData();
        }
    }
    }


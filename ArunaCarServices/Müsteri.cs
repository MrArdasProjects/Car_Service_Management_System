using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArunaCarServices
{
    public partial class Müsteri : Form
    {
        private int userID=0;
        private Menu _menu;
        public Müsteri(Menu menu)
        {
            InitializeComponent();
            _menu = menu;
        }
        private void ShowCars()
        {
            // Müşteriye ait araçları DataGridView'de göster
            car_owner_data(userID);

            
            
        }
        private void Add_Customer_Click(object sender, EventArgs e)
        {
            string Query = "Insert into CarOwner(first_name,last_name,phone,mail,adress) values ('" + this.txt_customer_name.Text + "','" + this.txt_customerlastname.Text + "','" + this.txt_customerphone.Text + "','" + txt_customermail.Text + "','" + this.txt_customeradres.Text + "')";
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
            txt_customer_name.Text = String.Empty;
            txt_customerlastname.Text = String.Empty;
            txt_customerphone.Text = String.Empty;
            txt_customermail.Text = String.Empty;
            txt_customeradres.Text = String.Empty;
            
            this.Hide();
            _menu.customersData();


            MessageBox.Show("Saved");

            // Yeni müşteriyi ekledikten sonra araçları göster
            ShowCars();

            this.Hide();
            _menu.customersData();


        }
        public void SetBilgiler(string ad, string soyisim, string telefon, string mail, string adress, int id)
        {
            txt_customer_name.Text = ad; // Örneğin, txtAd adlı bir TextBox kontrolü
            txt_customerlastname.Text = soyisim; // Örneğin, txtTelefon adlı bir TextBox kontrolü
            txt_customerphone.Text = telefon;
            txt_customermail.Text = mail;
            txt_customeradres.Text = adress;
            txt_customeradres.Text = adress;
            userID = id;

            if (id > 0)
            {
                btn_add_car.Visible = true;
                Güncelle_Musteri.Visible = true;
                carsGridView.Visible = true;
            }
            else
            {
                btn_add_car.Visible = false;
                Güncelle_Musteri.Visible = false;
                carsGridView.Visible = false;
            }

           

        }

        private void Güncelle_Musteri_Click(object sender, EventArgs e)
        {
            string Query = "UPDATE CarOwner SET first_name='" + this.txt_customer_name.Text + "', last_name='" + this.txt_customerlastname.Text + "', phone='" + this.txt_customerphone.Text + "', mail='" + txt_customermail.Text + "', adress='" + this.txt_customeradres.Text + "' WHERE ID=" + userID;
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
            txt_customer_name.Text = String.Empty;
            txt_customerlastname.Text = String.Empty;
            txt_customerphone.Text = String.Empty;
            txt_customermail.Text = String.Empty;
            txt_customeradres.Text = String.Empty;

            this.Hide();
            _menu.customersData();


            MessageBox.Show("Saved");

            // Müşteriyi güncelledikten sonra araçları göster
            ShowCars();

            this.Hide();
            _menu.customersData();



        }

        private void btn_add_car_Click(object sender, EventArgs e)
        {
            Car car = new Car(userID,_menu,this);
            car.Show();
        }

        private void carsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void car_owner_data(int ownerId)
        {
            string Query = "SELECT * FROM Car WHERE ownerID=" + ownerId;
            SqlConnection conn = new SqlConnection(@"Data Source=Matebook16s\MSSQLSERVER01;Initial Catalog=ARUNA; User ID = admin; Password = admin; Integrated Security = True");

            try
            {
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Query, conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                carsGridView.DataSource = dataTable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Müsteri_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde  butonunu gizle
            Add_Customer.Visible = true;
            carsGridView.Visible = false;

            // Eğer yeni müşteri ekleniyorsa (ID 0 ise), güncelle butonunu gizle
            if (userID > 0)
            {
                Add_Customer.Visible = false;
                carsGridView.Visible = true;
            }
            


        }
    }
}

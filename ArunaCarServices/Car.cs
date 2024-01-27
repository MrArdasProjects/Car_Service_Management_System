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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ArunaCarServices
{
    public partial class Car : Form
    {
        private int userID;
        private Menu _menu;
        private Müsteri _musteri;
        private int carID;

        public Car(int userId, Menu menu, Müsteri m = null)
        {
            InitializeComponent();
            userID = userId;
            _menu = menu;
            if (m != null)
            {
                _musteri = m;
            }
            fetchCarModels();

        }

        private void Car_Load(object sender, EventArgs e)
        {
            if (carID > 0) // Eğer carID değeri varsa (güncelleme işlemi)
            {
                add_car.Visible = false; // Ekleme butonunu gizle
                update_car.Visible = true;  // Güncelleme butonunu göster
            }
            else // Eğer carID değeri yoksa (ekleme işlemi)
            {
                add_car.Visible = true;  // Ekleme butonunu göster
                update_car.Visible = false; // Güncelleme butonunu gizle
            }
            

        }

        private void fetchCarModels()
        {
            string Query = "SELECT modelName FROM car_model";
            SqlConnection conn = new SqlConnection(@"Data Source=Matebook16s\MSSQLSERVER01;Initial Catalog=ARUNA; User ID = admin; Password = admin; Integrated Security = True");

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                // ComboBox'a verileri ekleyin
                while (reader.Read())
                {
                    comboBox_models.Items.Add(reader["modelName"].ToString());
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void add_car_Click(object sender, EventArgs e)
        {
            string Query = "Insert into Car(nuımber_plate,model,uretim_yili,color,kilometer,ownerID) values ('" + this.txt_nuımber_plate.Text + "','" + comboBox_models.SelectedItem.ToString().Replace(" ", "") + "','" + this.txt_uretim_yili.Text + "','" + this.txt_color.Text + "','" + this.txt_kilometer.Text + "',"+userID+")";
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
            txt_nuımber_plate.Text = String.Empty;
            txt_uretim_yili.Text = String.Empty;
            txt_color.Text = String.Empty;
            txt_kilometer.Text = String.Empty;          
            this.Hide();
            _menu.carData();


            if (_musteri != null)
            {
                _musteri.car_owner_data(userID);
            }

           





        }
        public void SetBilgiler(string plaka, string model, string uretimYili, string color, string km, int id)
        {
            txt_nuımber_plate.Text = plaka; // Örneğin, txtAd adlı bir TextBox kontrolü
            if (comboBox_models.Items.Contains(model.Replace(" ", "")))
            {
                comboBox_models.SelectedItem = model.Replace(" ", "");
            }
            txt_uretim_yili.Text = uretimYili;
            txt_color.Text = color;
            txt_kilometer.Text = km;
            carID = id;

            if (id > 0)
            {
                add_car.Visible = false;
                update_car.Visible = true; 
            }
            else
            {
                add_car.Visible = false;
                update_car.Visible = false;
            }

        }

        private void update_car_Click(object sender, EventArgs e)
        {
            string Query = "UPDATE Car SET nuımber_plate='" + this.txt_nuımber_plate.Text + "', model='" + comboBox_models.SelectedItem.ToString().Replace(" ", "") + "', uretim_yili='" + this.txt_uretim_yili.Text + "', color='" + txt_color.Text + "', kilometer='" + this.txt_kilometer.Text + "' WHERE ID=" + carID;
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
            txt_nuımber_plate.Text = String.Empty;
            txt_uretim_yili.Text = String.Empty;
            txt_color.Text = String.Empty;
            txt_kilometer.Text = String.Empty;
            

            this.Hide();
            _menu.carData();
            
        }

        private void comboBox_models_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

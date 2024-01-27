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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ArunaCarServices
{
    public partial class Personel_Secimi : Form
    {
        private static int carID;
        private static int MaintenanceID;
        public Personel_Secimi()
        {
            InitializeComponent();
        }

        private void Personel_Secimi_Load(object sender, EventArgs e)
        {
            fetchUsers();

        }
       

        private void fetchUsers()
        {
            string Query = "SELECT * FROM users";
            SqlConnection conn = new SqlConnection(@"Data Source=Matebook16s\MSSQLSERVER01;Initial Catalog=ARUNA; User ID = admin; Password = admin; Integrated Security = True");

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                // ComboBox'a verileri ekleyin
                while (reader.Read())
                {
                    string name = reader["first_name"].ToString().Trim();
                    string lastname = reader["last_name"].ToString().Trim();
                    int userID = Convert.ToInt32(reader["ID"]);
                    string displayText = $"{name} {lastname}";
                    comboBox_employee_select.Items.Add(new ComboboxItem(displayText, userID));
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void setBilgiler(int car_ID, int Maintenance_ID)
        {
            carID = car_ID;
            MaintenanceID = Maintenance_ID;
            


        }

        private void button_take_care_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            DateTime nextDate = dateTimePicker2.Value;          
            int status = 1;

            ComboboxItem selectedEmployee = (ComboboxItem)comboBox_employee_select.SelectedItem;

            int userID = selectedEmployee.ID;
            

            string Query = "Insert into CarMaintenance(carID, Date, Maintenance, Next_Maintenance, Status,UserID) values ('" + carID + "','" + selectedDate.ToString() + "','" + MaintenanceID + "','" + nextDate.ToString() + "','" + status + "','" + userID +"')";
            SqlConnection conn = new SqlConnection(@"Data Source=Matebook16s\MSSQLSERVER01;Initial Catalog=ARUNA; User ID = admin; Password = admin; Integrated Security = True");
            SqlCommand cmd = new SqlCommand(Query, conn);
            SqlDataReader dr;
            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Araba Bakıma alındı.");
                while (dr.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            this.Hide();
        }
    }
}

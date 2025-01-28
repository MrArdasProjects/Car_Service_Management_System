using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace ArunaCarServices
{
    public partial class Menu : Form

    {

        public Menu(bool adminRole)
        {
            InitializeComponent();

            if (adminRole == false)
            {
                tab_bakımAraclar.TabPages.Remove(tab_users);
                tab_bakımAraclar.TabPages.Remove(tab_maintenance);
            }
            fetchMaintenance();

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            createDataView();
            carData();
            customersData();
            usersData();
            bakımData();
            dataPastMaintenance();
        }



        #region data

        //musteri
        public void customersData()
        {



            string Query = "SELECT * FROM CarOwner";
            SqlConnection conn = new SqlConnection(@"Data Source=Matebook16s\MSSQLSERVER01;Initial Catalog=ARUNA; User ID = admin; Password = admin; Integrated Security = True");

            try
            {
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Query, conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                data_customers.DataSource = dataTable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void createDataView()
        {
            //customer
            // DataGridView'e güncelle ve sil butonları için sütunlar ekleyin
            DataGridViewButtonColumn btnUpdateColumn = new DataGridViewButtonColumn();
            btnUpdateColumn.HeaderText = "Detaylar";
            btnUpdateColumn.Text = "Detaylar";
            btnUpdateColumn.Name = "Detaylar";
            btnUpdateColumn.UseColumnTextForButtonValue = true;
            data_customers.Columns.Add(btnUpdateColumn);

            DataGridViewButtonColumn btnDeleteColumn = new DataGridViewButtonColumn();
            btnDeleteColumn.HeaderText = "Sil";
            btnDeleteColumn.Text = "Sil";
            btnDeleteColumn.Name = "Sil";
            btnDeleteColumn.UseColumnTextForButtonValue = true;
            data_customers.Columns.Add(btnDeleteColumn);

            // DataGridView'e buton tıklama olayları ekleyin
            data_customers.CellContentClick += new DataGridViewCellEventHandler(data_customers_CellContentClick);


            //car

            // DataGridView'e güncelle ve sil butonları için sütunlar ekleyin
            DataGridViewButtonColumn btnUpdateColumn1 = new DataGridViewButtonColumn();
            btnUpdateColumn1.HeaderText = "Güncelle";
            btnUpdateColumn1.Text = "Güncelle";
            btnUpdateColumn1.Name = "Güncelle";
            btnUpdateColumn1.UseColumnTextForButtonValue = true;
            dataCar.Columns.Add(btnUpdateColumn1);

            DataGridViewButtonColumn btnDeleteColumn1 = new DataGridViewButtonColumn();
            btnDeleteColumn1.HeaderText = "Sil";
            btnDeleteColumn1.Text = "Sil";
            btnDeleteColumn1.Name = "Sil";
            btnDeleteColumn1.UseColumnTextForButtonValue = true;
            dataCar.Columns.Add(btnDeleteColumn1);

            // DataGridView'e buton tıklama olayları ekleyin
            dataCar.CellContentClick += new DataGridViewCellEventHandler(dataCar_CellContentClick);

            //user

            // DataGridView'e güncelle ve sil butonları için sütunlar ekleyin
            DataGridViewButtonColumn btnUpdateColumn2 = new DataGridViewButtonColumn();
            btnUpdateColumn2.HeaderText = "Güncelle";
            btnUpdateColumn2.Text = "Güncelle";
            btnUpdateColumn2.Name = "Güncelle";
            btnUpdateColumn2.UseColumnTextForButtonValue = true;
            dataUser.Columns.Add(btnUpdateColumn2);

            DataGridViewButtonColumn btnDeleteColumn2 = new DataGridViewButtonColumn();
            btnDeleteColumn2.HeaderText = "Sil";
            btnDeleteColumn2.Text = "Sil";
            btnDeleteColumn2.Name = "Sil";
            btnDeleteColumn2.UseColumnTextForButtonValue = true;
            dataUser.Columns.Add(btnDeleteColumn2);

            // DataGridView'e buton tıklama olayları ekleyin
            dataUser.CellContentClick += new DataGridViewCellEventHandler(dataUser_CellContentClick);

            //bakımData
            DataGridViewButtonColumn btnUpdateColumn3 = new DataGridViewButtonColumn();
            btnUpdateColumn3.HeaderText = "Bakımı Bitir";
            btnUpdateColumn3.Text = "Bakımı Bitir";
            btnUpdateColumn3.Name = "Bakımı Bitir";
            btnUpdateColumn3.UseColumnTextForButtonValue = true;
            maintenanceData.Columns.Add(btnUpdateColumn3);
            maintenanceData.CellContentClick += new DataGridViewCellEventHandler(maintenanceData_CellContentClick);

        }


        //araba
        public void carData()
        {

            string Query = "SELECT * FROM Car";
            SqlConnection conn = new SqlConnection(@"Data Source=Matebook16s\MSSQLSERVER01;Initial Catalog=ARUNA; User ID = admin; Password = admin; Integrated Security = True");

            try
            {
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Query, conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataCar.DataSource = dataTable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //personel
        public void usersData()
        {



            string Query = "SELECT * FROM users";
            SqlConnection conn = new SqlConnection(@"Data Source=Matebook16s\MSSQLSERVER01;Initial Catalog=ARUNA; User ID = admin; Password = admin; Integrated Security = True");

            try
            {
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Query, conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataUser.DataSource = dataTable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        #endregion

        #region CellContentClick
        private void data_customers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Güncelle butonuna tıklanırsa
            if (e.ColumnIndex == data_customers.Columns["Detaylar"].Index && e.RowIndex >= 0)
            {
                // Seçili satırdaki verileri güncelleme metoduyla işleyebilirsiniz
                Müsteri müsteri = new Müsteri(this);

                int rowIndex = data_customers.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = data_customers.Rows[rowIndex];

                string ad = selectedRow.Cells["first_name"].Value.ToString().Replace(" ", "");
                string soyad = selectedRow.Cells["last_name"].Value.ToString().Replace(" ", "");
                string telefon = selectedRow.Cells["phone"].Value.ToString().Replace(" ", "");
                string mail = selectedRow.Cells["mail"].Value.ToString().Replace(" ", "");
                string adres = selectedRow.Cells["adress"].Value.ToString().Replace(" ", "");
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value.ToString().Replace(" ", ""));

                // Yeni formu oluştur ve bilgileri aktar

                müsteri.SetBilgiler(ad, soyad, telefon, mail, adres, id);
                müsteri.car_owner_data(id);
                müsteri.Show();
            }

            // Sil butonuna tıklanırsa
            if (e.ColumnIndex == data_customers.Columns["Sil"].Index && e.RowIndex >= 0)
            {
                int customerId = Convert.ToInt32(data_customers.Rows[e.RowIndex].Cells["ID"].Value);

                // Veritabanında silme işlemini gerçekleştir
                DeleteCustomer(customerId);

                // Silinen satırı DataGridView'den kaldır
                data_customers.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dataCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Güncelle butonuna tıklanırsa
            if (e.ColumnIndex == dataCar.Columns["Güncelle"].Index && e.RowIndex >= 0)
            {
                int customerId = Convert.ToInt32(dataCar.Rows[e.RowIndex].Cells["ownerID"].Value);
                // Seçili satırdaki verileri güncelleme metoduyla işleyebilirsiniz
                Car car = new Car(customerId, this);
                int rowIndex = dataCar.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataCar.Rows[rowIndex];

                string number_plate = selectedRow.Cells["nuımber_plate"].Value.ToString().Replace(" ", "");
                string model = selectedRow.Cells["model"].Value.ToString().Replace(" ", "");
                string üretim_yili = selectedRow.Cells["uretim_yili"].Value.ToString().Replace(" ", "");
                string renk = selectedRow.Cells["color"].Value.ToString().Replace(" ", "");
                string kilometer = selectedRow.Cells["kilometer"].Value.ToString().Replace(" ", "");
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value.ToString().Replace(" ", ""));

                // Yeni formu oluştur ve bilgileri aktar

                car.SetBilgiler(number_plate, model, üretim_yili, renk, kilometer, id);
                car.Show();
            }

            // Sil butonuna tıklanırsa
            if (e.ColumnIndex == dataCar.Columns["Sil"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Seçili satırı silmek istiyor musunuz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int carId = Convert.ToInt32(dataCar.Rows[e.RowIndex].Cells["ID"].Value);

                    // Veritabanında silme işlemini gerçekleştir
                    DeleteCar(carId);

                    // Silinen satırı DataGridView'den kaldır
                    dataCar.Rows.RemoveAt(e.RowIndex);
                }
            }


        }

        private void dataUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataUser.Columns["Güncelle"].Index && e.RowIndex >= 0)
            {
                // Seçili satırdaki verileri güncelleme metoduyla işleyebilirsiniz
                User user = new User(this);
                int rowIndex = dataUser.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataUser.Rows[rowIndex];

                string ad = selectedRow.Cells["first_name"].Value.ToString().Replace(" ", "");
                string soyad = selectedRow.Cells["last_name"].Value.ToString().Replace(" ", "");
                string username = selectedRow.Cells["username"].Value.ToString().Replace(" ", "");
                string password = selectedRow.Cells["Password"].Value.ToString().Replace(" ", "");
                string telefon = selectedRow.Cells["phone"].Value.ToString().Replace("  ", "");
                string mail = selectedRow.Cells["mail"].Value.ToString().Replace(" ", "");
                string adres = selectedRow.Cells["adress"].Value.ToString().Replace(" ", "");
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value.ToString().Replace("  ", ""));
                int role_id = Convert.ToInt32(selectedRow.Cells["role_id"].Value.ToString().Replace(" ", ""));

                // Yeni formu oluştur ve bilgileri aktar

                user.SetBilgiler(ad, soyad, username, password, telefon, mail, adres, id, role_id);

                user.Show();
            }

            // Sil butonuna tıklanırsa
            if (e.ColumnIndex == dataUser.Columns["Sil"].Index && e.RowIndex >= 0)
            {
                int userID = Convert.ToInt32(dataUser.Rows[e.RowIndex].Cells["ID"].Value);

                // Veritabanında silme işlemini gerçekleştir
                DeleteUser(userID);

                // Silinen satırı DataGridView'den kaldır
                dataUser.Rows.RemoveAt(e.RowIndex);

            }
        }



        #endregion

        #region delete-new form

        private void DeleteCustomer(int customerId)
        {
            string Query = "DELETE FROM CarOwner WHERE ID =" + customerId;
            SqlConnection conn = new SqlConnection(@"Data Source=Matebook16s\MSSQLSERVER01;Initial Catalog=ARUNA; User ID = admin; Password = admin; Integrated Security = True");
            SqlCommand cmd = new SqlCommand(Query, conn);
            SqlDataReader dr;
            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Deleted");
                while (dr.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();


        }



        private void button_add_customer_Click(object sender, EventArgs e)
        {

            {
                Müsteri müsteri = new Müsteri(this);
                müsteri.Show();

            }
        }



        private void DeleteCar(int carId)
        {
            string Query = "DELETE FROM Car WHERE ID =" + carId;
            SqlConnection conn = new SqlConnection(@"Data Source=Matebook16s\MSSQLSERVER01;Initial Catalog=ARUNA; User ID = admin; Password = admin; Integrated Security = True");
            SqlCommand cmd = new SqlCommand(Query, conn);

            try
            {
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Silme işlemi başarıyla gerçekleştirildi.");
                }
                else
                {
                    MessageBox.Show("Silme işlemi sırasında bir hata oluştu veya silinecek kayıt bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();

        }

        private void DeleteUser(int userID)
        {
            string Query = "DELETE FROM users WHERE ID =" + userID;
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

            conn.Close();


        }

        private void Add_Customer_Click(object sender, EventArgs e)
        {
            User user = new User(this);
            user.Show();
        }



        #endregion



        private void filter_Click_1(object sender, EventArgs e)
        {
            string plakaFilter = txtFilter.Text.Trim();

            if (!string.IsNullOrEmpty(plakaFilter))
            {
                // Filtreleme sorgusu oluştur
                string Query = $"SELECT * FROM Car WHERE nuımber_plate = '{plakaFilter}'";

                SqlConnection conn = new SqlConnection(@"Data Source=Matebook16s\MSSQLSERVER01;Initial Catalog=ARUNA; User ID=admin; Password=admin; Integrated Security=True");

                try
                {
                    conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(Query, conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataCar.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }

            }
            else
            {
                // Kullanıcı plaka numarası girmeden önce bir uyarı.
                MessageBox.Show("Lütfen plaka numarasını girin.");
            }

        }

        private void refreshbox_car_Click(object sender, EventArgs e)
        {
            // Veriyi yenileme sorgusunu oluştur
            string refreshQuery = "SELECT * FROM Car";

            SqlConnection conn = new SqlConnection(@"Data Source=Matebook16s\MSSQLSERVER01;Initial Catalog=ARUNA; User ID=admin; Password=admin; Integrated Security=True");

            try
            {
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(refreshQuery, conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataCar.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void filter_users_Click(object sender, EventArgs e)
        {
            string usernameFilter = txtFilter_users.Text.Trim();

            if (!string.IsNullOrEmpty(usernameFilter))
            {
                // Filtreleme sorgusu oluştur
                string query = $"SELECT * FROM users WHERE username LIKE '%{usernameFilter}%'";

                SqlConnection conn = new SqlConnection(@"Data Source=Matebook16s\MSSQLSERVER01;Initial Catalog=ARUNA; User ID=admin; Password=admin; Integrated Security=True");

                try
                {
                    conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataUser.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                // Kullanıcı adı girmeden önce bir uyarı verebilirsiniz.
                MessageBox.Show("Lütfen kullanıcı adını girin.");
            }
        }

        private void refreshbox_users_Click(object sender, EventArgs e)
        {
            // Veriyi yenileme sorgusunu oluştur
            string refreshQuery = "SELECT * FROM users";

            SqlConnection conn = new SqlConnection(@"Data Source=Matebook16s\MSSQLSERVER01;Initial Catalog=ARUNA; User ID=admin; Password=admin; Integrated Security=True");

            try
            {
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(refreshQuery, conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataUser.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private bool isMaintenanceSelected = false;
        private void btnGetMaintenanceInfo_Click(object sender, EventArgs e)
        {
            string plakaNumarasi = txtPlakaNumarasi.Text.Trim();
            int MaintenanceID = getMaintenanceID();
            int carID = getCarID(plakaNumarasi);

            if (!string.IsNullOrEmpty(plakaNumarasi))
            {
                // Plakaya ait bakım bilgilerini çekme
                string maintenanceQuery = $"SELECT ml.Model, ml.Bakım_madde, ml.Time, ml.Cost " +
                                          $"FROM MaintenanceList ml " +
                                          $"JOIN Car c ON ml.Model = c.model " +
                                          $"WHERE c.nuımber_plate = '{plakaNumarasi}' AND ml.MaintenanceID = {MaintenanceID}";

                DataTable maintenanceTable = new DataTable();

                using (SqlConnection conn = new SqlConnection(@"Data Source=Matebook16s\MSSQLSERVER01;Initial Catalog=ARUNA; User ID=admin; Password=admin; Integrated Security=True"))
                {
                    conn.Open();
                    SqlDataAdapter maintenanceAdapter = new SqlDataAdapter(maintenanceQuery, conn);
                    maintenanceAdapter.Fill(maintenanceTable);
                    conn.Close();
                }

                // DataGridView'da gösterme
                dataMaintenance.DataSource = maintenanceTable;



                // Toplam bilgileri hesapla
                decimal totalCost = 0;
                int totalTime = 0;

                foreach (DataGridViewRow row in dataMaintenance.Rows)
                {
                    totalCost += Convert.ToDecimal(row.Cells["Cost"].Value);
                    totalTime += Convert.ToInt32(row.Cells["Time"].Value);
                }

                // DataGridView'e toplam satırı ekleme
                DataRow totalRow = maintenanceTable.NewRow();

                totalRow["Bakım_madde"] = "Toplam";
                totalRow["Cost"] = totalCost;
                totalRow["Time"] = totalTime;
                maintenanceTable.Rows.Add(totalRow);

                // DataGridView'i güncelleme
                dataMaintenance.DataSource = maintenanceTable;

                // DataGridView'e buton tıklama olayını ekleme
                dataMaintenance.CellContentClick += new DataGridViewCellEventHandler(dataMaintenance_CellContentClick);
            }
            else
            {
                MessageBox.Show("Lütfen plaka numarasını girin.");
            }

            Personel_Secimi.setBilgiler(carID, MaintenanceID);
            isMaintenanceSelected = true;
        }

        private void dataMaintenance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataMaintenance.Columns["Detaylar"].Index && e.RowIndex >= 0)
            {
                // Seçili satırdaki detayları gösterme işlemi
                int rowIndex = dataMaintenance.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataMaintenance.Rows[rowIndex];

                string bakimAdi = selectedRow.Cells["Maintenance"].Value.ToString().Replace(" ", "");
                string degisecekParcalar = selectedRow.Cells["Bakım_madde"].Value.ToString().Replace(" ", "");
                string cost = selectedRow.Cells["Cost"].Value.ToString().Replace(" ", "");
                string time = selectedRow.Cells["Time"].Value.ToString().Replace(" ", "");

                // Detayları kullanarak işlem yapabilirsiniz (örneğin, MessageBox ile gösterme)
                MessageBox.Show($"Bakım Adı: {bakimAdi}\nDeğişecek Parçalar: {degisecekParcalar}\nCost: {cost}");
            }

        }
        private void fetchMaintenance()
        {
            string Query = "SELECT Maintenance_Name FROM MaintenanceName";
            SqlConnection conn = new SqlConnection(@"Data Source=Matebook16s\MSSQLSERVER01;Initial Catalog=ARUNA; User ID = admin; Password = admin; Integrated Security = True");

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                // ComboBox'a verileri ekleyin
                while (reader.Read())
                {
                    comboBox_maintenance.Items.Add(reader["Maintenance_Name"].ToString());
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabBakımAraclar_Click(object sender, EventArgs e)
        {

        }



        private void menu_take_care_Click_1(object sender, EventArgs e)
        {
            if (isMaintenanceSelected)
            {
                Personel_Secimi personel = new Personel_Secimi();

                // Oluşturulan formu gösterin
                personel.Show();
            }
            else
            {
                MessageBox.Show("Lütfen önce bir bakım türü seçin.");
            }

        }



        private void filter_customer_Click(object sender, EventArgs e)
        {
            string phoneFilter = txtFilter_customer.Text.Trim();

            if (!string.IsNullOrEmpty(phoneFilter))
            {
                // Filtreleme sorgusu oluştur
                string query = $"SELECT * FROM CarOwner WHERE phone LIKE '%{phoneFilter}%'";

                SqlConnection conn = new SqlConnection(@"Data Source=Matebook16s\MSSQLSERVER01;Initial Catalog=ARUNA; User ID=admin; Password=admin; Integrated Security=True");

                try
                {
                    conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // DataGridView veri kaynağını güncelle
                    data_customers.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                // Kullanıcı telefon numarası girmeden önce bir uyarı verebilirsiniz.
                MessageBox.Show("Lütfen telefon numarasını girin.");
            }
        }

        private void refreshbox_customer_Click(object sender, EventArgs e)
        {
            // Veriyi yenileme sorgusunu oluştur
            string refreshQuery = "SELECT * FROM CarOwner";

            SqlConnection conn = new SqlConnection(@"Data Source=Matebook16s\MSSQLSERVER01;Initial Catalog=ARUNA; User ID=admin; Password=admin; Integrated Security=True");

            try
            {
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(refreshQuery, conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // DataGridView veri kaynağını güncelle
                data_customers.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private int getMaintenanceID()
        {
            if (comboBox_maintenance.SelectedItem != null)
            {
                string selectedMaintenanceName = comboBox_maintenance.SelectedItem.ToString();
                int maintenanceID = -1;

                string sqlQuery = $"SELECT ID FROM MaintenanceName WHERE Maintenance_Name = '{selectedMaintenanceName}'";

                using (SqlConnection conn = new SqlConnection(@"Data Source=Matebook16s\MSSQLSERVER01;Initial Catalog=ARUNA; User ID=admin; Password=admin; Integrated Security=True"))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            maintenanceID = Convert.ToInt32(result);
                        }
                    }
                }
                return maintenanceID;
            }
            else
            {
                MessageBox.Show("Lütfen bakım türü seçin.");
                return -1; // veya başka bir değer döndürebilirsiniz
            }
        }
        private int getCarID(string plaka)
        {
            int carID = -1;
            string sqlQuery = $"SELECT ID FROM Car WHERE nuımber_plate = '{plaka}'";

            using (SqlConnection conn = new SqlConnection(@"Data Source=Matebook16s\MSSQLSERVER01;Initial Catalog=ARUNA; User ID=admin; Password=admin; Integrated Security=True"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {


                    // ExecuteScalar kullanarak tek bir değeri getirme
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        // ID'yi al
                        carID = Convert.ToInt32(result);
                    }
                }
            }
            return carID;

        }


        public void bakımData()
        {
            string maintenanceQuery = $"SELECT cm.ID, c.model, cm.Date, c.nuımber_plate, co.first_name, " +
    $"co.last_name AS owner_lastname, co.phone AS owner_phone, co.mail AS owner_mail, co.adress, CONCAT(u.first_name, ' ', u.last_name) AS Sorumlu_Personel, mn.Maintenance_Name AS Yapılan_Bakım " +
    $"FROM CarMaintenance cm " +
    $"JOIN Car c ON cm.CarID = c.ID " +
    $"JOIN CarOwner co ON c.OwnerID = co.ID " +
    $"JOIN Users u ON cm.UserID = u.ID " +
    $"JOIN MaintenanceName mn ON cm.Maintenance = mn.ID " +
    $"WHERE cm.status = 1";

            SqlConnection conn = new SqlConnection(@"Data Source=Matebook16s\MSSQLSERVER01;Initial Catalog=ARUNA; User ID = admin; Password = admin; Integrated Security = True");

            try
            {
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(maintenanceQuery, conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                maintenanceData.DataSource = dataTable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void maintenanceData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == maintenanceData.Columns["Bakımı Bitir"].Index && e.RowIndex >= 0)
            {
                int ID = Convert.ToInt32(maintenanceData.Rows[e.RowIndex].Cells["ID"].Value);

                removeFromMaintenance(ID);

                bakımData();

            }

        }
        private void removeFromMaintenance(int ID)
        {
            string updateQuery = $"UPDATE CarMaintenance SET status = 0 WHERE ID = {ID}";

            SqlConnection conn = new SqlConnection(@"Data Source=Matebook16s\MSSQLSERVER01;Initial Catalog=ARUNA; User ID = admin; Password = admin; Integrated Security = True");
            SqlCommand cmd = new SqlCommand(updateQuery, conn);

            try
            {
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Bakım tamamlandı");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();

        }

        private void refresh_maintenance_Click(object sender, EventArgs e)
        {
            bakımData();
        }

        private void Final_datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataPastMaintenance()
        {
            string maintenanceQuery = $"SELECT cm.ID, c.model, cm.Date, c.nuımber_plate, co.first_name, co.last_name AS owner_lastname, " +
    $"co.phone AS owner_phone, co.mail AS owner_mail, co.adress, CONCAT(u.first_name, ' ', u.last_name) AS Sorumlu_Personel, mn.Maintenance_Name AS Yapılan_Bakım, cm.Next_Maintenance AS Bir_Sonraki_Bakım_Tarih " +
    $"FROM CarMaintenance cm " +
    $"JOIN Car c ON cm.CarID = c.ID " +
    $"JOIN CarOwner co ON c.OwnerID = co.ID " +
    $"JOIN Users u ON cm.UserID = u.ID " +
    $"JOIN MaintenanceName mn ON cm.Maintenance = mn.ID " +
    $"WHERE cm.status = 0";

            SqlConnection conn = new SqlConnection(@"Data Source=Matebook16s\MSSQLSERVER01;Initial Catalog=ARUNA; User ID = admin; Password = admin; Integrated Security = True");

            try
            {
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(maintenanceQuery, conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                past_datagridview.DataSource = dataTable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Final_search_Click(object sender, EventArgs e)
        {

            string plakaFilter = txt_past_filter.Text.Trim();

            if (!string.IsNullOrEmpty(plakaFilter))
            {
                // Filtreleme sorgusu oluştur
                string maintenanceQuery = $"SELECT cm.ID, c.model, cm.Date, c.nuımber_plate, co.first_name, co.last_name AS owner_lastname, co.phone AS owner_phone, co.mail AS owner_mail, co.adress, CONCAT(u.first_name, ' ', u.last_name) AS Sorumlu_Personel, mn.Maintenance_Name AS Yapılan_Bakım, cm.Next_Maintenance AS Bir_Sonraki_Bakım_Tarihi " +
    $"FROM CarMaintenance cm " +
    $"JOIN Car c ON cm.CarID = c.ID " +
    $"JOIN CarOwner co ON c.OwnerID = co.ID " +
    $"JOIN Users u ON cm.UserID = u.ID " +
    $"JOIN MaintenanceName mn ON cm.Maintenance = mn.ID " +
    $"WHERE cm.status = 0 AND c.nuımber_plate='{plakaFilter}'";

                SqlConnection conn = new SqlConnection(@"Data Source=Matebook16s\MSSQLSERVER01;Initial Catalog=ARUNA; User ID=admin; Password=admin; Integrated Security=True");

                try
                {
                    conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(maintenanceQuery, conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    past_datagridview.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void past_picturebox_Click(object sender, EventArgs e)
        {
            string maintenanceQuery = $"SELECT cm.ID, c.model, cm.Date, c.nuımber_plate, co.first_name, co.last_name AS owner_lastname, co.phone AS owner_phone, co.mail AS owner_mail, " +
   $"co.adress, CONCAT(u.first_name, ' ', u.last_name) AS Sorumlu_Personel, mn.Maintenance_Name AS Yapılan_Bakım, cm.Next_Maintenance AS Bir_Sonraki_Bakım_Tarihi " +
   $"FROM CarMaintenance cm " +
   $"JOIN Car c ON cm.CarID = c.ID " +
   $"JOIN CarOwner co ON c.OwnerID = co.ID " +
   $"JOIN Users u ON cm.UserID = u.ID " +
   $"JOIN MaintenanceName mn ON cm.Maintenance = mn.ID " +
   $"WHERE cm.status = 0";

            SqlConnection conn = new SqlConnection(@"Data Source=Matebook16s\MSSQLSERVER01;Initial Catalog=ARUNA; User ID = admin; Password = admin; Integrated Security = True");

            try
            {
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(maintenanceQuery, conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                past_datagridview.DataSource = dataTable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            // Oluşturulan Form1'ı gösterin
            form1.Show();

            // Mevcut formu kapat.
            this.Hide();
        }

    }
}



namespace ArunaCarServices
{
    partial class Car
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            { 
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_kilometer = new System.Windows.Forms.TextBox();
            this.txt_color = new System.Windows.Forms.TextBox();
            this.txt_uretim_yili = new System.Windows.Forms.TextBox();
            this.txt_nuımber_plate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.add_car = new System.Windows.Forms.Button();
            this.update_car = new System.Windows.Forms.Button();
            this.comboBox_models = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_kilometer
            // 
            this.txt_kilometer.Location = new System.Drawing.Point(274, 288);
            this.txt_kilometer.Name = "txt_kilometer";
            this.txt_kilometer.Size = new System.Drawing.Size(241, 26);
            this.txt_kilometer.TabIndex = 29;
            // 
            // txt_color
            // 
            this.txt_color.Location = new System.Drawing.Point(274, 227);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(241, 26);
            this.txt_color.TabIndex = 28;
            // 
            // txt_uretim_yili
            // 
            this.txt_uretim_yili.Location = new System.Drawing.Point(274, 174);
            this.txt_uretim_yili.Name = "txt_uretim_yili";
            this.txt_uretim_yili.Size = new System.Drawing.Size(241, 26);
            this.txt_uretim_yili.TabIndex = 27;
            // 
            // txt_nuımber_plate
            // 
            this.txt_nuımber_plate.Location = new System.Drawing.Point(274, 62);
            this.txt_nuımber_plate.Name = "txt_nuımber_plate";
            this.txt_nuımber_plate.Size = new System.Drawing.Size(241, 26);
            this.txt_nuımber_plate.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(109, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Araç Km :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Araç Renk :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Araç Üretim Yılı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Araç Model :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Araç Plaka :";
            // 
            // add_car
            // 
            this.add_car.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.add_car.Location = new System.Drawing.Point(226, 371);
            this.add_car.Name = "add_car";
            this.add_car.Size = new System.Drawing.Size(122, 51);
            this.add_car.TabIndex = 30;
            this.add_car.Text = "KAYDET";
            this.add_car.UseVisualStyleBackColor = false;
            this.add_car.Click += new System.EventHandler(this.add_car_Click);
            // 
            // update_car
            // 
            this.update_car.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.update_car.Location = new System.Drawing.Point(386, 371);
            this.update_car.Name = "update_car";
            this.update_car.Size = new System.Drawing.Size(129, 51);
            this.update_car.TabIndex = 31;
            this.update_car.Text = "GÜNCELLE";
            this.update_car.UseVisualStyleBackColor = false;
            this.update_car.Click += new System.EventHandler(this.update_car_Click);
            // 
            // comboBox_models
            // 
            this.comboBox_models.FormattingEnabled = true;
            this.comboBox_models.Location = new System.Drawing.Point(274, 113);
            this.comboBox_models.Name = "comboBox_models";
            this.comboBox_models.Size = new System.Drawing.Size(241, 28);
            this.comboBox_models.TabIndex = 32;
            
            // 
            // Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(855, 520);
            this.Controls.Add(this.comboBox_models);
            this.Controls.Add(this.update_car);
            this.Controls.Add(this.add_car);
            this.Controls.Add(this.txt_kilometer);
            this.Controls.Add(this.txt_color);
            this.Controls.Add(this.txt_uretim_yili);
            this.Controls.Add(this.txt_nuımber_plate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "Car";
            this.Text = "Car";
            this.Load += new System.EventHandler(this.Car_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_kilometer;
        private System.Windows.Forms.TextBox txt_color;
        private System.Windows.Forms.TextBox txt_uretim_yili;
        private System.Windows.Forms.TextBox txt_nuımber_plate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button add_car;
        private System.Windows.Forms.Button update_car;
        private System.Windows.Forms.ComboBox comboBox_models;
    }
}
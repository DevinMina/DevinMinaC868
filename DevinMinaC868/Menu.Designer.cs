﻿
namespace DevinMinaC868
{
    partial class Menu
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
            this.appointmentsByConsultant = new System.Windows.Forms.Button();
            this.appointmentsByCustomer = new System.Windows.Forms.Button();
            this.deleteUser = new System.Windows.Forms.Button();
            this.modifyUser = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.apptByMonthButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.monthRadio = new System.Windows.Forms.RadioButton();
            this.weekRadio = new System.Windows.Forms.RadioButton();
            this.appointmentCalendar = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.addAppointmentButton = new System.Windows.Forms.Button();
            this.deleteAppointmentButton = new System.Windows.Forms.Button();
            this.modifyAppointmentButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.deleteCustomerButton = new System.Windows.Forms.Button();
            this.modifyCustomerButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.customersList = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refreshCustomers = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentCalendar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // appointmentsByConsultant
            // 
            this.appointmentsByConsultant.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.appointmentsByConsultant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsByConsultant.Location = new System.Drawing.Point(505, 46);
            this.appointmentsByConsultant.Name = "appointmentsByConsultant";
            this.appointmentsByConsultant.Size = new System.Drawing.Size(98, 63);
            this.appointmentsByConsultant.TabIndex = 17;
            this.appointmentsByConsultant.Text = "Search Appointments by Consultant";
            this.appointmentsByConsultant.UseVisualStyleBackColor = false;
            this.appointmentsByConsultant.Visible = false;
            this.appointmentsByConsultant.Click += new System.EventHandler(this.AppointmentsByConsultant_Click);
            // 
            // appointmentsByCustomer
            // 
            this.appointmentsByCustomer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.appointmentsByCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsByCustomer.Location = new System.Drawing.Point(7, 108);
            this.appointmentsByCustomer.Name = "appointmentsByCustomer";
            this.appointmentsByCustomer.Size = new System.Drawing.Size(99, 63);
            this.appointmentsByCustomer.TabIndex = 19;
            this.appointmentsByCustomer.Text = "Search Appointments By Customer";
            this.appointmentsByCustomer.UseVisualStyleBackColor = false;
            this.appointmentsByCustomer.Click += new System.EventHandler(this.AppointmentsByCustomer_Click);
            // 
            // deleteUser
            // 
            this.deleteUser.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteUser.Cursor = System.Windows.Forms.Cursors.No;
            this.deleteUser.Location = new System.Drawing.Point(622, 26);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(65, 37);
            this.deleteUser.TabIndex = 24;
            this.deleteUser.Text = "Delete User";
            this.deleteUser.UseVisualStyleBackColor = false;
            this.deleteUser.Visible = false;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // modifyUser
            // 
            this.modifyUser.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.modifyUser.Location = new System.Drawing.Point(373, 62);
            this.modifyUser.Name = "modifyUser";
            this.modifyUser.Size = new System.Drawing.Size(95, 47);
            this.modifyUser.TabIndex = 23;
            this.modifyUser.Text = "Edit User";
            this.modifyUser.UseVisualStyleBackColor = false;
            this.modifyUser.Visible = false;
            this.modifyUser.Click += new System.EventHandler(this.editUser_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.apptByMonthButton);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.appointmentsByCustomer);
            this.panel3.Location = new System.Drawing.Point(726, 215);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 178);
            this.panel3.TabIndex = 21;
            // 
            // apptByMonthButton
            // 
            this.apptByMonthButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.apptByMonthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptByMonthButton.Location = new System.Drawing.Point(111, 108);
            this.apptByMonthButton.Name = "apptByMonthButton";
            this.apptByMonthButton.Size = new System.Drawing.Size(99, 63);
            this.apptByMonthButton.TabIndex = 6;
            this.apptByMonthButton.Text = "Appointments by Month";
            this.apptByMonthButton.UseVisualStyleBackColor = false;
            this.apptByMonthButton.Click += new System.EventHandler(this.ApptByMonthButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Reports";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(54, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 63);
            this.button1.TabIndex = 13;
            this.button1.Text = "Appointment Count by Type";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ApptCountByType_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(648, 181);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 32);
            this.refreshButton.TabIndex = 20;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // monthRadio
            // 
            this.monthRadio.AutoSize = true;
            this.monthRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthRadio.Location = new System.Drawing.Point(545, 187);
            this.monthRadio.Name = "monthRadio";
            this.monthRadio.Size = new System.Drawing.Size(93, 20);
            this.monthRadio.TabIndex = 18;
            this.monthRadio.TabStop = true;
            this.monthRadio.Text = "Month View";
            this.monthRadio.UseVisualStyleBackColor = true;
            // 
            // weekRadio
            // 
            this.weekRadio.AutoSize = true;
            this.weekRadio.Checked = true;
            this.weekRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekRadio.Location = new System.Drawing.Point(446, 187);
            this.weekRadio.Name = "weekRadio";
            this.weekRadio.Size = new System.Drawing.Size(93, 20);
            this.weekRadio.TabIndex = 16;
            this.weekRadio.TabStop = true;
            this.weekRadio.Text = "Week View";
            this.weekRadio.UseVisualStyleBackColor = true;
            this.weekRadio.CheckedChanged += new System.EventHandler(this.WeekRadio_CheckedChanged);
            // 
            // appointmentCalendar
            // 
            this.appointmentCalendar.AllowUserToOrderColumns = true;
            this.appointmentCalendar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appointmentCalendar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.appointmentCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentCalendar.Location = new System.Drawing.Point(188, 215);
            this.appointmentCalendar.Name = "appointmentCalendar";
            this.appointmentCalendar.ReadOnly = true;
            this.appointmentCalendar.RowHeadersWidth = 45;
            this.appointmentCalendar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentCalendar.Size = new System.Drawing.Size(535, 178);
            this.appointmentCalendar.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.AccessibleName = "";
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.addAppointmentButton);
            this.panel2.Controls.Add(this.deleteAppointmentButton);
            this.panel2.Controls.Add(this.modifyAppointmentButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 194);
            this.panel2.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Management";
            // 
            // addAppointmentButton
            // 
            this.addAppointmentButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAppointmentButton.Location = new System.Drawing.Point(13, 55);
            this.addAppointmentButton.Name = "addAppointmentButton";
            this.addAppointmentButton.Size = new System.Drawing.Size(137, 32);
            this.addAppointmentButton.TabIndex = 4;
            this.addAppointmentButton.Text = "Add Appointment";
            this.addAppointmentButton.UseVisualStyleBackColor = false;
            this.addAppointmentButton.Click += new System.EventHandler(this.AddAppointmentButton_Click);
            // 
            // deleteAppointmentButton
            // 
            this.deleteAppointmentButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAppointmentButton.Location = new System.Drawing.Point(12, 161);
            this.deleteAppointmentButton.Name = "deleteAppointmentButton";
            this.deleteAppointmentButton.Size = new System.Drawing.Size(142, 25);
            this.deleteAppointmentButton.TabIndex = 6;
            this.deleteAppointmentButton.Text = "Delete Appointment";
            this.deleteAppointmentButton.UseVisualStyleBackColor = false;
            this.deleteAppointmentButton.Click += new System.EventHandler(this.DeleteAppointmentButton_Click);
            // 
            // modifyAppointmentButton
            // 
            this.modifyAppointmentButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.modifyAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyAppointmentButton.Location = new System.Drawing.Point(12, 104);
            this.modifyAppointmentButton.Name = "modifyAppointmentButton";
            this.modifyAppointmentButton.Size = new System.Drawing.Size(137, 32);
            this.modifyAppointmentButton.TabIndex = 5;
            this.modifyAppointmentButton.Text = "Edit Appointment";
            this.modifyAppointmentButton.UseVisualStyleBackColor = false;
            this.modifyAppointmentButton.Click += new System.EventHandler(this.EditAppointmentButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Appointment";
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerButton.Location = new System.Drawing.Point(10, 665);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(137, 33);
            this.addCustomerButton.TabIndex = 0;
            this.addCustomerButton.Text = "Add Customer";
            this.addCustomerButton.UseVisualStyleBackColor = false;
            this.addCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // deleteCustomerButton
            // 
            this.deleteCustomerButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCustomerButton.Location = new System.Drawing.Point(720, 665);
            this.deleteCustomerButton.Name = "deleteCustomerButton";
            this.deleteCustomerButton.Size = new System.Drawing.Size(137, 33);
            this.deleteCustomerButton.TabIndex = 2;
            this.deleteCustomerButton.Text = "Delete Customer";
            this.deleteCustomerButton.UseVisualStyleBackColor = false;
            this.deleteCustomerButton.Click += new System.EventHandler(this.DeleteCustomerButton_Click);
            // 
            // modifyCustomerButton
            // 
            this.modifyCustomerButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.modifyCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyCustomerButton.Location = new System.Drawing.Point(160, 665);
            this.modifyCustomerButton.Name = "modifyCustomerButton";
            this.modifyCustomerButton.Size = new System.Drawing.Size(137, 33);
            this.modifyCustomerButton.TabIndex = 1;
            this.modifyCustomerButton.Text = "Edit Customer";
            this.modifyCustomerButton.UseVisualStyleBackColor = false;
            this.modifyCustomerButton.Click += new System.EventHandler(this.EditCustomerButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(207, 451);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(332, 26);
            this.searchBox.TabIndex = 25;
            this.searchBox.Text = "Search Customer Name";
            this.searchBox.TextChanged += new System.EventHandler(this.txtBox_search_TextChanged);
            // 
            // customersList
            // 
            this.customersList.AllowUserToOrderColumns = true;
            this.customersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersList.Location = new System.Drawing.Point(10, 483);
            this.customersList.Name = "customersList";
            this.customersList.ReadOnly = true;
            this.customersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customersList.Size = new System.Drawing.Size(847, 176);
            this.customersList.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 31);
            this.label6.TabIndex = 27;
            this.label6.Text = "Customer List";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(474, 37);
            this.label7.TabIndex = 28;
            this.label7.Text = "APPOINTMENT SCHEDULER";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 42);
            this.label8.TabIndex = 29;
            this.label8.Text = "MAIN MENU";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(192, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(248, 31);
            this.label9.TabIndex = 30;
            this.label9.Text = "Appointment View";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(64, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 47);
            this.button2.TabIndex = 22;
            this.button2.Text = "Add User";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.addUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Advanced Options";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(726, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 84);
            this.panel1.TabIndex = 31;
            // 
            // refreshCustomers
            // 
            this.refreshCustomers.Location = new System.Drawing.Point(572, 446);
            this.refreshCustomers.Name = "refreshCustomers";
            this.refreshCustomers.Size = new System.Drawing.Size(75, 31);
            this.refreshCustomers.TabIndex = 32;
            this.refreshCustomers.Text = "Refresh";
            this.refreshCustomers.UseVisualStyleBackColor = true;
            this.refreshCustomers.Click += new System.EventHandler(this.refreshCustomers_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 721);
            this.Controls.Add(this.refreshCustomers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.modifyUser);
            this.Controls.Add(this.appointmentsByConsultant);
            this.Controls.Add(this.deleteUser);
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.deleteCustomerButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.modifyCustomerButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.customersList);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.monthRadio);
            this.Controls.Add(this.weekRadio);
            this.Controls.Add(this.appointmentCalendar);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentCalendar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button appointmentsByConsultant;
        private System.Windows.Forms.Button appointmentsByCustomer;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.Button modifyUser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button apptByMonthButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.RadioButton monthRadio;
        private System.Windows.Forms.RadioButton weekRadio;
        private System.Windows.Forms.DataGridView appointmentCalendar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addAppointmentButton;
        private System.Windows.Forms.Button deleteAppointmentButton;
        private System.Windows.Forms.Button modifyAppointmentButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.Button deleteCustomerButton;
        private System.Windows.Forms.Button modifyCustomerButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView customersList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button refreshCustomers;
    }
}

namespace DevinMinaC868.Appt
{
    partial class DeleteAppt
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
            this.label10 = new System.Windows.Forms.Label();
            this.appointmentComboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.startDateValue = new System.Windows.Forms.DateTimePicker();
            this.endDateValue = new System.Windows.Forms.DateTimePicker();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contactText = new System.Windows.Forms.TextBox();
            this.locationText = new System.Windows.Forms.TextBox();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.appointmentText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(435, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 105;
            this.label10.Text = "Select Appointment";
            // 
            // appointmentComboBox
            // 
            this.appointmentComboBox.FormattingEnabled = true;
            this.appointmentComboBox.Location = new System.Drawing.Point(550, 42);
            this.appointmentComboBox.Name = "appointmentComboBox";
            this.appointmentComboBox.Size = new System.Drawing.Size(260, 21);
            this.appointmentComboBox.TabIndex = 104;
            this.appointmentComboBox.Text = "--Select--";
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Cleaning",
            "Cavities",
            "Wisdom Teeth",
            "Consultation",
            "Other",
            "Root Canal"});
            this.typeComboBox.Location = new System.Drawing.Point(127, 122);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(260, 21);
            this.typeComboBox.TabIndex = 103;
            // 
            // startDateValue
            // 
            this.startDateValue.Checked = false;
            this.startDateValue.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.startDateValue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateValue.Location = new System.Drawing.Point(550, 96);
            this.startDateValue.Name = "startDateValue";
            this.startDateValue.Size = new System.Drawing.Size(260, 20);
            this.startDateValue.TabIndex = 102;
            // 
            // endDateValue
            // 
            this.endDateValue.Checked = false;
            this.endDateValue.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.endDateValue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateValue.Location = new System.Drawing.Point(550, 122);
            this.endDateValue.Name = "endDateValue";
            this.endDateValue.Size = new System.Drawing.Size(260, 20);
            this.endDateValue.TabIndex = 101;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelButton.Location = new System.Drawing.Point(735, 313);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 100;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteButton.Location = new System.Drawing.Point(25, 300);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 99;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(342, 13);
            this.label9.TabIndex = 98;
            this.label9.Text = "Please select the customer you would like to delete an appointment for.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(435, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 97;
            this.label8.Text = "End Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 96;
            this.label7.Text = "Start Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 95;
            this.label6.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 94;
            this.label5.Text = "Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 93;
            this.label4.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 92;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 91;
            this.label2.Text = "Appointment Name";
            // 
            // contactText
            // 
            this.contactText.Location = new System.Drawing.Point(127, 96);
            this.contactText.Name = "contactText";
            this.contactText.Size = new System.Drawing.Size(260, 20);
            this.contactText.TabIndex = 90;
            // 
            // locationText
            // 
            this.locationText.Location = new System.Drawing.Point(127, 69);
            this.locationText.Name = "locationText";
            this.locationText.Size = new System.Drawing.Size(260, 20);
            this.locationText.TabIndex = 89;
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(127, 174);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(683, 103);
            this.descriptionText.TabIndex = 88;
            // 
            // appointmentText
            // 
            this.appointmentText.Location = new System.Drawing.Point(550, 68);
            this.appointmentText.Name = "appointmentText";
            this.appointmentText.Size = new System.Drawing.Size(260, 20);
            this.appointmentText.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "Select Customer";
            // 
            // customerComboBox
            // 
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(127, 42);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(260, 21);
            this.customerComboBox.TabIndex = 85;
            this.customerComboBox.Text = "--Select--";
            // 
            // DeleteAppt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 348);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.appointmentComboBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.startDateValue);
            this.Controls.Add(this.endDateValue);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contactText);
            this.Controls.Add(this.locationText);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.appointmentText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerComboBox);
            this.Name = "DeleteAppt";
            this.Text = "DeleteAppt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox appointmentComboBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.DateTimePicker startDateValue;
        private System.Windows.Forms.DateTimePicker endDateValue;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contactText;
        private System.Windows.Forms.TextBox locationText;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.TextBox appointmentText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox customerComboBox;
    }
}
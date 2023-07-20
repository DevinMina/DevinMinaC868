
namespace DevinMinaC868
{
    partial class EditCustomer
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.noRadio = new System.Windows.Forms.RadioButton();
            this.yesRadio = new System.Windows.Forms.RadioButton();
            this.countryText = new System.Windows.Forms.TextBox();
            this.zipText = new System.Windows.Forms.TextBox();
            this.cityText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.modifyComboBox = new System.Windows.Forms.ComboBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelButton.Location = new System.Drawing.Point(262, 288);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(79, 23);
            this.cancelButton.TabIndex = 39;
            this.cancelButton.Text = "Cancel/Done";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateButton.Enabled = false;
            this.updateButton.Location = new System.Drawing.Point(30, 288);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 38;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(252, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Please select the customer you would like to modify.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Active";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Country";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Zip Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Name";
            // 
            // noRadio
            // 
            this.noRadio.AutoSize = true;
            this.noRadio.Enabled = false;
            this.noRadio.Location = new System.Drawing.Point(192, 250);
            this.noRadio.Name = "noRadio";
            this.noRadio.Size = new System.Drawing.Size(39, 17);
            this.noRadio.TabIndex = 29;
            this.noRadio.TabStop = true;
            this.noRadio.Text = "No";
            this.noRadio.UseVisualStyleBackColor = true;
            // 
            // yesRadio
            // 
            this.yesRadio.AutoSize = true;
            this.yesRadio.Enabled = false;
            this.yesRadio.Location = new System.Drawing.Point(131, 251);
            this.yesRadio.Name = "yesRadio";
            this.yesRadio.Size = new System.Drawing.Size(43, 17);
            this.yesRadio.TabIndex = 28;
            this.yesRadio.TabStop = true;
            this.yesRadio.Text = "Yes";
            this.yesRadio.UseVisualStyleBackColor = true;
            // 
            // countryText
            // 
            this.countryText.Enabled = false;
            this.countryText.Location = new System.Drawing.Point(130, 211);
            this.countryText.Name = "countryText";
            this.countryText.Size = new System.Drawing.Size(100, 20);
            this.countryText.TabIndex = 27;
            this.countryText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountryText_KeyPress);
            // 
            // zipText
            // 
            this.zipText.Enabled = false;
            this.zipText.Location = new System.Drawing.Point(130, 184);
            this.zipText.Name = "zipText";
            this.zipText.Size = new System.Drawing.Size(100, 20);
            this.zipText.TabIndex = 26;
            this.zipText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ZipText_KeyPress);
            // 
            // cityText
            // 
            this.cityText.Enabled = false;
            this.cityText.Location = new System.Drawing.Point(130, 157);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(100, 20);
            this.cityText.TabIndex = 25;
            this.cityText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CityText_KeyPress);
            // 
            // addressText
            // 
            this.addressText.Enabled = false;
            this.addressText.Location = new System.Drawing.Point(130, 130);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(211, 20);
            this.addressText.TabIndex = 24;
            this.addressText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddressText_KeyPress);
            // 
            // phoneText
            // 
            this.phoneText.Enabled = false;
            this.phoneText.Location = new System.Drawing.Point(130, 103);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(211, 20);
            this.phoneText.TabIndex = 23;
            this.phoneText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneText_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Select Customer";
            // 
            // modifyComboBox
            // 
            this.modifyComboBox.FormattingEnabled = true;
            this.modifyComboBox.Location = new System.Drawing.Point(130, 47);
            this.modifyComboBox.Name = "modifyComboBox";
            this.modifyComboBox.Size = new System.Drawing.Size(211, 21);
            this.modifyComboBox.TabIndex = 20;
            this.modifyComboBox.Text = "--Select--";
            this.modifyComboBox.SelectedValueChanged += new System.EventHandler(this.EditComboBox_SelectedValueChanged);
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(130, 77);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(211, 20);
            this.nameText.TabIndex = 22;
            this.nameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameText_KeyPress);
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 329);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.noRadio);
            this.Controls.Add(this.yesRadio);
            this.Controls.Add(this.countryText);
            this.Controls.Add(this.zipText);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modifyComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditCustomer";
            this.Text = "EditCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton noRadio;
        private System.Windows.Forms.RadioButton yesRadio;
        private System.Windows.Forms.TextBox countryText;
        private System.Windows.Forms.TextBox zipText;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox modifyComboBox;
        private System.Windows.Forms.TextBox nameText;
    }
}
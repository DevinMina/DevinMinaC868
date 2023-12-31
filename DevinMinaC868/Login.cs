﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevinMinaC868
{
    public partial class Login : Form
    {
        public string error = "The username or password entered does not exist or is incorrect. Please try again.";
        public string exit = "Are you sure you want to exit the application?";
        public Login()
        {
            InitializeComponent();
            languageCheck(CultureInfo.CurrentUICulture.LCID);
        }

        private void languageCheck(int LCID)
        {
            if (LCID == 1036)
            {
                this.Text = "Connexion";
                usernameLabel.Text = "Nom d'utilisateur";
                passwordLabel.Text = "Mot de passe";
                loginButton.Text = "Connexion";
                exitButton.Text = "Sortie";
                error = "Le nom d'utilisateur ou le mot de passe entré n'existe pas ou est incorrect. Veuillez réessayer.";
                exit = "Voulez-vous vraiment quitter l'application?";
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(exit, this.Text, MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //check database to confirm user and password are correct
            if (dbHelp.userCheck(usernameText.Text, passwordText.Text) == 1)
            {
                //login with current time and user and log to .txt file/open portal/close login window
                Record.logIn(dbHelp.getUserName());
                Form MainMenu = new Menu();
                Record.reminder();
                MainMenu.Show();
                this.Hide();

            }
            else MessageBox.Show(error);
        }
    }
}

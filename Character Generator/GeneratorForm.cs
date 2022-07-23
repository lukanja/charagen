﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Character_Generator;

namespace Character_Generator
{
    public partial class GeneratorForm : Form
    {
        DatabaseControl databaseControl = new DatabaseControl();

        public GeneratorForm()
        {
            InitializeComponent();
        }


        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            textBoxLifePhase.Text = databaseControl.GenerateTrait("LifePhase");
            textBoxMainTrait.Text = databaseControl.GenerateTrait("MainTrait");
            textBoxMainStrength.Text = databaseControl.GenerateTrait("MainStrength");
            textBoxMainFlaw.Text = databaseControl.GenerateTrait("MainFlaw");
            textBoxGoal.Text = databaseControl.GenerateTrait("Goal");
            textBoxSecret.Text = databaseControl.GenerateTrait("Secret");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            //closes this form and reopens main form
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}


    


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
using System.IO;
using System.Text.RegularExpressions;

namespace Character_Generator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonCreationMode_Click(object sender, EventArgs e)
        {
            //opens character generator and hides main form
            GeneratorForm generatorForm = new GeneratorForm();
            generatorForm.Show();
            this.Hide();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            //opens form with instructions and hides main form
            InstructionForm instructionForm = new InstructionForm();
            instructionForm.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void testDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseControl db = new DatabaseControl();
            string doesitwork;
            db.ConnectDatabase();
            if (db.ConnectDatabase() == true)
            {
                doesitwork = "Connection works.";
                db.DisconnectDatabase();
            }
            else
            {
                doesitwork = "Connection doesn't work.";
            }

            MessageBox.Show(doesitwork);
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            //opens browsing form with and hides main form
            BrowsingForm browsingForm = new BrowsingForm();
            browsingForm.Show();
            this.Hide();
        }

        private void createDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To initialize the database, create it manually and run T-SQL query from file charactergenerator.sql.");
        }     
    }
}

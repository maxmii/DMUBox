﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMUBox
{
    public partial class frmStudentReport : Form
    {
        public frmStudentReport()
        {
            InitializeComponent();
        }

        private void frmStudentReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DMUBoxDataSet.tblStudent' table. You can move, or remove it, as needed.
            this.tblStudentTableAdapter.Fill(this.DMUBoxDataSet.tblStudent);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //close this form
            this.Close();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jukebox_assignment_SB
{
    public partial class frm_About : Form
    {
        public frm_About()
        {
            InitializeComponent();
        }

        private void txt_About_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_About_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
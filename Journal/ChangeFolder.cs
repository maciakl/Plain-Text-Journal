/*
 * License: This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 3 of the License, or (at your
 * option) any later version. This program is distributed in the hope that it
 * will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty
 * of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General
 * Public License for more details.
 * 
 * Copyright © 2011 Lukasz Grzegorz Maciak (maciak.org)
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Journal
{
    public partial class ChangeFolder : Form
    {
        public ChangeFolder()
        {
            InitializeComponent();



            this.folder.Text = Properties.Settings.Default.JOURNAL_PATH;

            this.folderBrowserDialog1.SelectedPath = this.folder.Text;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Focus();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.folder.Text = folderBrowserDialog1.SelectedPath;
            }

        }

        private void sv_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.JOURNAL_PATH = this.folder.Text;
            Properties.Settings.Default.Save();
            this.Hide();
            this.Owner.Focus();
            this.Dispose();
        }
    }
}

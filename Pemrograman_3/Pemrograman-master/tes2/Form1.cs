﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tes2
{
    public partial class frmLatihanTiga3 : Form
    {
        public frmLatihanTiga3()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var nama = txtNama.Text;
            var pendidikan = cmbBox.Text;
            var pekerjaan = lstPekerjaan.Text;

            txtPesan1.Text = string.Format("Halo {0} ", nama);
            txtPesan2.Text = string.Format("Pendidikan Anda {0} Ya ?", pendidikan);
            txtPesan3.Text = string.Format("Anda Seorang {0}, hebat !!!", pekerjaan);
        }
    }
}

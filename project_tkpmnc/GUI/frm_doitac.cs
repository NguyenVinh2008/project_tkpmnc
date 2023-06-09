﻿using project_tkpmnc.GUI;
using System;
using System.Windows.Forms;

namespace project_tkpmnc
{
    public partial class frm_doitac : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frm_doitac()
        {
            InitializeComponent();
        }
        doitac_quanlychiendich ucQuanlychiendich;
        doitac_quanlyvoucher ucQuanlyvoucher;
        doitac_thaydoithongtin ucThaydoithongtin;
        doitac_thongkehethong ucThongkehethong;
        private void ce_quanlychiendich_Click(object sender, EventArgs e)
        {
            //if (ucQuanlychiendich == null)
            //{
                ucQuanlychiendich = new doitac_quanlychiendich();
                ucQuanlychiendich.Dock = DockStyle.Fill;
                fluentDesignFormContainer1.Controls.Add(ucQuanlychiendich);
                ucQuanlychiendich.BringToFront();
            //}
            //else
            //    ucQuanlychiendich.BringToFront();
        }

        private void ce_quanlyvoucher_Click(object sender, EventArgs e)
        {
            //if (ucQuanlyvoucher == null)
            //{
                ucQuanlyvoucher = new doitac_quanlyvoucher();
                ucQuanlyvoucher.Dock = DockStyle.Fill;
                fluentDesignFormContainer1.Controls.Add(ucQuanlyvoucher);
                ucQuanlyvoucher.BringToFront();
            //}
            //else
            //    ucQuanlyvoucher.BringToFront();
        }

        private void ce_thaydoithongtin_Click(object sender, EventArgs e)
        {
            //if (ucThaydoithongtin == null)
            //{
                ucThaydoithongtin = new doitac_thaydoithongtin();
                ucThaydoithongtin.Dock = DockStyle.Fill;
                fluentDesignFormContainer1.Controls.Add(ucThaydoithongtin);
                ucThaydoithongtin.BringToFront();
            //}
            //else
            //    ucThaydoithongtin.BringToFront();
        }

        private void ce_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ce_dangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_dangnhap dangnhap = new frm_dangnhap();
            dangnhap.ShowDialog();
        }

        private void ce_thongke_Click(object sender, EventArgs e)
        {
            ucThongkehethong = new doitac_thongkehethong();
            ucThongkehethong.Dock = DockStyle.Fill;
            fluentDesignFormContainer1.Controls.Add(ucThongkehethong);
            ucThongkehethong.BringToFront();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using project_tkpmnc.DAO;

namespace project_tkpmnc.BUS
{
    internal class application_BUS
    {
        login_DAO login_DAO = new login_DAO();
        public bool IsNumber(string pText)
        {
            Regex regex = null;
            try
            {
                regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$"); return regex.IsMatch(pText);
            }
            catch (Exception ex)
            {
                return regex.IsMatch(pText);
            }
        }
        public string GetMD5(string chuoi)
        {
            string str_md5 = "";
            byte[] mang = System.Text.Encoding.UTF8.GetBytes(chuoi);

            MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
            mang = my_md5.ComputeHash(mang);

            foreach (byte b in mang)
            {
                str_md5 += b.ToString("X2");
            }
            return str_md5;
        }

        public int CheckExistEmail(string email)
        {
            // return 1: tồn tại email, return 0: không tồn tại email
            login_DAO login_DAO = new login_DAO();
            var kq = login_DAO.checkexist(email);
            if (kq.Rows.Count >= 1)
                return 1;
            else
                return 0;
        }
        public int CheckLogin(string email, string password)
        {
            // return 1: đăng nhập thành công, return 0: đăng nhập không thành công
            login_DAO login_DAO = new login_DAO();
            var kq = login_DAO.checklogin(email, password);
            if (kq.Rows.Count == 1)
                return 1;
            else
                return 0;
        }

        public int CheckAdmin(string email)
        {
            login_DAO login_DAO = new login_DAO();
            var kq = login_DAO.checkadmin(email);
            if (kq.Rows.Count == 1)
                return 1;
            else
                return 0;
        }
        public int checkUserType(string email)
        {
            // return 0: người dùng; return 1: quản trị viên; return 2: đối tác
            login_DAO login_DAO = new login_DAO();
            var kq = login_DAO.checkadmin(email);
            if (kq.Rows.Count == 1)
                return 1;
            else
            {
                kq = login_DAO.checkdoitac(email);
                if (kq.Rows.Count == 1)
                    return 2;
            }
            return 0;
        }

        public int CheckStatus(string email, int trangthai)
        {
            login_DAO login_DAO = new login_DAO();
            var kq = login_DAO.checkstatusbyemail(email, trangthai);
            if (kq.Rows.Count == 1)
                // return 1 > có dữ liệu
                return 1;
            else
                // return 0 > không có dữ liệu
                return 0;
        }
    }
}

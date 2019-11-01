using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyXeMay.DTO;
using QuanLyXeMay.DAO;

namespace QuanLyXeMay
{
    public partial class UC_Account : UserControl
    {
        public UC_Account()
        {
            InitializeComponent();
        }

        private void UC_Account_Load(object sender, EventArgs e)
        {
            LoadListAccount();
        }

        private void ShowAccount()
        {
            lsvAccount.Items.Clear();

            List<Account> listAccount = AccountDAO.Instance.GetListAccount();

            foreach (Account item in listAccount)
            {
                ListViewItem lsvItem = new ListViewItem(item.TenDN);
                //lsvItem.SubItems.Add(item.MatKhau);
                lsvItem.SubItems.Add(item.LoaiTaiKhoan);

                lsvAccount.Items.Add(lsvItem);
            }
        }

        private void LsvAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvAccount.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvAccount.SelectedItems[0];
                txbTenDN.Text = item.SubItems[0].Text;
                //txbMatKhau.Text = item.SubItems[1].Text;
                cbxLoaiTaiKhoan.SelectedIndex = cbxLoaiTaiKhoan.FindStringExact(item.SubItems[1].Text);

            }
            else
            {
                txbTenDN.Text = string.Empty;
                txbMatKhau.Text = string.Empty;
                cbxLoaiTaiKhoan.SelectedItem = null;
            }
        }

        public void LoadListAccount()
        {
            ShowAccount();

            lsvAccount.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsvAccount.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            cbxLoaiTaiKhoan.SelectedIndex = 0;
        }

        #region Button Them + Xoa + Sua
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string tenDN = txbTenDN.Text;
            string matKhau = txbMatKhau.Text;
            string loaiTaiKhoan = cbxLoaiTaiKhoan.SelectedItem.ToString();

            //Check có thiếu trường nào không
            if (CheckInput(tenDN, matKhau) == "")
            {
                // Check Mã có bị trùng chưa
                if (CheckTenDN(tenDN))
                {
                    //Check có Insert được không
                    if (AccountDAO.Instance.InsertAccount(tenDN, matKhau, loaiTaiKhoan))
                    {
                        MessageBox.Show("Thêm tài khoản thành công!");
                        LoadListAccount();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm tài khoản!");
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!");
                }
            }
            else
            {
                MessageBox.Show("Thiếu " + CheckInput(tenDN, matKhau) + "\nVui Lòng Nhập Đầy Đủ!");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string tenDN = txbTenDN.Text;

            if (AccountDAO.Instance.DeleteAccount(tenDN))
            {
                MessageBox.Show("Xóa tài khoản thành công!");
                LoadListAccount();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa tài khoản!");
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            string tenDN = txbTenDN.Text;
            string matKhau = txbMatKhau.Text;
            string loaiTaiKhoan = cbxLoaiTaiKhoan.SelectedItem.ToString();

            //Check có thiếu trường nào không
            if (CheckInput(tenDN, matKhau) == "")
            {
                //Check có Update được không
                if (AccountDAO.Instance.UpdateAccount(tenDN, matKhau, loaiTaiKhoan))
                {
                    MessageBox.Show("Sửa tài khoản thành công!");
                    LoadListAccount();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi sửa tài khoản!");
                }
            }
            else
            {
                MessageBox.Show("Thiếu " + CheckInput(tenDN, matKhau) + "\nVui Lòng Nhập Đầy Đủ!");
            }
        }

        private bool CheckTenDN(string tenDN)
        {
            List<Account> account = AccountDAO.Instance.GetListAccount();
            foreach (Account item in account)
            {
                if (item.TenDN == tenDN)
                {
                    return false;
                }
            }
            return true;
        }

        private string CheckInput(string tenDN, string matKhau)
        {
            string result = "";
            if (tenDN == string.Empty)
            {
                result += "tên đăng nhập, ";
            }
            if (matKhau == string.Empty)
            {
                result += "mật khẩu, ";
            }

            return result;
        }
        #endregion
    }
}

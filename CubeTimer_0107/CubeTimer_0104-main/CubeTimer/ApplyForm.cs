using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubeTimer
{
    public partial class ApplyForm : Form
    {
        public ApplyForm()
        {
            InitializeComponent();
        }

        /**
         * 確認鍵按下
         */
        private void ButtonComfirm_Click(object sender, EventArgs e)
        {
            if (PasswordCheck()) //密碼驗證通關
            {
                if ((accountBox.Text.Length > 0) && (emailBox.Text.Length > 0) && (phoneBox.Text.Length > 0)) //都有填資料
                {
                    if (!NameRepeatCheck())
                    {
                        RememberState();
                        DatabaseCall();

                        LoginForm login = new LoginForm();
                        login.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("此名稱已被註冊，請重新取名", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("請確保所有資料皆已填寫", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /**
         * 密碼驗證
         */
        public bool PasswordCheck()
        {
            string password = passwordBox.Text;
            string passwordCheck = passwordChkBox.Text;

            if ((password.Length < 6) && (password.Length > 12))
            {
                MessageBox.Show("請輸入正確字元數量的密碼", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!password.Equals(passwordCheck))
            {
                MessageBox.Show("密碼前後不一，請重新輸入", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /**
         * 將使用者資料存到使用者端
         */
        public void RememberState()
        {
            UserStatement us = new UserStatement();

            us.inUser(accountBox.Text);
            us.inPassword(passwordBox.Text);
            us.inEmail(emailBox.Text);
            us.inPhone(Convert.ToInt32(phoneBox.Text));
            us.inTimes(0);
        }

        /**
         * 呼叫資料庫連接器
         */
        public void DatabaseCall()
        {
            DatabaseConnect dbc = new DatabaseConnect();
            dbc.InsertNewUserToDatabase();
        }

        /**
         * 檢視帳號名稱有無重複
         */
        public bool NameRepeatCheck()
        {
            DatabaseConnect dbc = new DatabaseConnect();
            return dbc.PickUserFromDatabase(accountBox.Text);
        }
    }
}

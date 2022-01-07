using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CubeTimer
{
    class DatabaseConnect
    {
        /**
         * 不同裝置需要修改mdf檔案位置設定 目前尚未解決
         */

        UserStatement us = new UserStatement();
        CurrentGradeHolder cgh = new CurrentGradeHolder();

        /**
         * 把用戶註冊資料存進資料庫
         */
        public void InsertNewUserToDatabase()
        {
            try
            {
                SqlConnection scn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename = C:\Users\王銘澤\OneDrive\桌面\CubeTimer_0104-main\CubeTimer_0104-main\CubeTimer\Database1.mdf;Integrated Security=True");
                scn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = scn,
                    CommandText = "INSERT INTO [會員資料](Name, Password, Email, PhoneNumber, ScoringTimes) VALUES(@Name, @Password, @Email, @PhoneNumber, @ScoringTimes)"
                };

                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = us.getUser();
                cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = us.getPassword();
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = us.getEmail();
                cmd.Parameters.Add("@PhoneNumber", SqlDbType.Int).Value = us.getPhone();
                cmd.Parameters.Add("@ScoringTimes", SqlDbType.Int).Value = us.getTimes();

                cmd.ExecuteNonQuery();

                scn.Close();
                scn.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("連線失敗，請再嘗試一次\r\n" + ex.Message, "警告", MessageBoxButtons.OK , MessageBoxIcon.Warning);
            }
        }

        /**
         * 提取用戶資料
         */
        public bool PickUserFromDatabase(string user)
        {
            try
            {
                SqlConnection scn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename = C:\Users\王銘澤\OneDrive\桌面\CubeTimer_0104-main\CubeTimer_0104-main\CubeTimer\Database1.mdf;Integrated Security=True");
                scn.Open();

                SqlCommand cmd = new SqlCommand
                {
                    Connection = scn,
                    CommandText = "SELECT * FROM [會員資料] WHERE Name = @Name"
                };
                cmd.Parameters.Add("@Name",SqlDbType.NVarChar).Value = us.getUser();

                SqlDataReader sdr = cmd.ExecuteReader();
                if (!sdr.HasRows)
                {
                    sdr.Close();
                    scn.Close();
                    scn.Dispose();
                    return false;
                }

                // Insert data to user statement
                while (sdr.Read())
                {
                    us.inUser(sdr["Name"].ToString());
                    us.inPassword(sdr["Password"].ToString());
                    us.inEmail(sdr["Email"].ToString());
                    us.inPhone(Convert.ToInt32(sdr["PhoneNumber"]));
                    us.inTimes(Convert.ToInt32(sdr["ScoringTimes"]));
                }

                sdr.Close();
                scn.Close();
                scn.Dispose();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("找不到使用者資料\r\n" + ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /**
         * 成績上傳連結(在此成績以打散的方式儲存，因SQL有SELECT這個東西可以取出特定用戶的資料)
         */
        public void UpdateGradesToDatabase()
        {
            try
            {
                SqlConnection scn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename = C:\Users\王銘澤\OneDrive\桌面\CubeTimer_0104-main\CubeTimer_0104-main\CubeTimer\Database1.mdf;Integrated Security=True");
                scn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = scn,
                    CommandText = "INSERT INTO [成績存放中心](DateTime, Name, Number, Time, CurrScramble) VALUES(@DateTime, @Name, @Number, @Time, @CurrScramble) "
                };

                cmd.Parameters.Add("@DateTime", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = us.getUser();
                us.updateTimes();
                cmd.Parameters.Add("@Number", SqlDbType.NVarChar).Value = us.getTimes();
                cmd.Parameters.Add("@Time", SqlDbType.Float).Value = cgh.getCurrScore();
                cmd.Parameters.Add("@CurrScramble", SqlDbType.NVarChar).Value = cgh.getCurrScramble();

                cmd.ExecuteNonQuery();

                scn.Close();
                scn.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("連線失敗，請再嘗試一次\r\n" + ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /**
         * 提取該用戶成績資料
         */ 
        public void GetUserScoresFromDatabase()
        {
            try
            {
                SqlConnection scn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename = C:\Users\王銘澤\OneDrive\桌面\CubeTimer_0104-main\CubeTimer_0104-main\CubeTimer\Database1.mdf;Integrated Security=True");
                scn.Open();

                SqlCommand cmd = new SqlCommand
                {
                    Connection = scn,
                    CommandText = "SELECT * FROM [成績存放中心] WHERE Name = @Name"
                };
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = us.getUser();

                SqlDataReader sdr = cmd.ExecuteReader();

                int arrayCount = 0;
                // Insert data to user statement
                while (sdr.Read())
                {
                    us.inPlayTime(arrayCount++, Convert.ToDouble(sdr["Time"]));
                }

                sdr.Close();
                scn.Close();
                scn.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /**
         * 更新成績數量
         */ 
        public void UpdateScoringTimes()
        {
            try
            {
                SqlConnection scn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename = C:\Users\王銘澤\OneDrive\桌面\CubeTimer_0104-main\CubeTimer_0104-main\CubeTimer\Database1.mdf;Integrated Security=True");
                scn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = scn,
                    CommandText = "UPDATE [會員資料] SET ScoringTimes = @ScoringTimes WHERE Name = @Name"
                };

                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = us.getUser();
                cmd.Parameters.Add("@ScoringTimes", SqlDbType.Int).Value = us.getTimes();

                cmd.ExecuteNonQuery();

                scn.Close();
                scn.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("連線失敗，請再嘗試一次\r\n" + ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

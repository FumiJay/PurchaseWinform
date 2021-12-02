using System.Data;

namespace PurchaseWinform.loginManager
{
    class LoginHelper
    {
        public static class LoginInfo
        {
            public static bool? LoginKey;
            public static int UserID;
            public static string UserPW;
            public static string UserNM;
        }

        public static bool Haslogined()
        {
            bool? val = LoginInfo.LoginKey as bool?;

            if (val.HasValue && val.Value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool tryLogin(string Account, string Password)
        {
            if (Haslogined())
            {
                return true;
            }

            DataTable dt = DBAccount.AccountCheck(Account);
            LoginInfo.UserPW = dt.Rows[0].Field<string>("Password");

            if (dt == null || dt.Rows.Count == 0)
            {
                return false;
            }

            bool isPasswordRight = string.Compare(LoginInfo.UserPW, Password.Trim()) == 0;

            if (isPasswordRight)
            {
                LoginInfo.LoginKey = true;
                LoginInfo.UserID = dt.Rows[0].Field<int>("Staff_ID");
                LoginInfo.UserNM = dt.Rows[0].Field<string>("Staff_Name");

                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Logout()
        {
            if (!Haslogined())
            {
                return;
            }
        }
    }
}


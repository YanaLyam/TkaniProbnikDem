using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TkaniProbnikDem
{
    public class User
    {
        public static User localuser;

        public int UserID;
        public string UserName;
        public string UserSurname;
        public string UserPatronymic;
        public string UserLogin;
        public string UserPassword;
        public Role UserRole;

        public static string GetRoleName(Role role)
        {
            switch (role)
            {
                case Role.admin:
                    return "Администатор";
                case Role.manager:
                    return "Менеджер";
                case Role.client:
                    return "Клиент";
                default:
                    return "";

            }
        }

        public User(DataRow row)
        {
            UserID = Convert.ToInt32(row["UserID"]);
            UserName = Convert.ToString(row["UserName"]);
            UserSurname = Convert.ToString(row["UserSurname"]);
            UserPatronymic = Convert.ToString(row["UserPatronymic"]);
            UserLogin = Convert.ToString(row["UserLogin"]);
            UserPassword = Convert.ToString(row["UserPassword"]);
            UserRole = (Role)Convert.ToInt32(row["UserRole"]);
        }
  
    }
}

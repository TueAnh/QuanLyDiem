using QuanLyDiem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.BLL
{
    class UserInfo_BLL
    {
        private static UserInfo_BLL bLL;
        public static UserInfo_BLL BLL
        {
            get => (bLL == null) ? bLL = new UserInfo_BLL() : bLL;
            set => bLL = value;
        }
        private UserInfo_BLL() { }
        public bool UpdateUser(User user)
        {
            if (user.typeAcc == 1)
                return UpdateUserHV(user);
            return UpdateUserGV(user);
        }
        public bool UpdateUserHV(User user)
        {
            return UserInfo_DAL.DAL.UpdateUserHV(user);
        }
        public bool UpdateUserGV(User user)
        {
            return UserInfo_DAL.DAL.UpdateUserGV(user);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;
using DAL;

namespace BLL
{
   public class MZGUserBLL
    {
        MZGUserDAL dl = new MZGUserDAL();
        public int UserAdd(ModelInfo mo)
        {
            return dl.UserAdd(mo);
        }
        public bool Show(string UserPhone)
        {
            return dl.Show(UserPhone);
        }
        public int DiscountsTableAdd(ModelInfo mo)
        {
            return dl.DiscountsTableAdd(mo);
        }

        public string UserInfoShow(string UserPhone)
        {
            return dl.UserInfoShow(UserPhone);
        }
        public string ShopTableShow()
        {
            return dl.ShopTableShow();
        }
        public int ManageTableShow(string ManageAccount, string ManagePwd)
        {
            return dl.ManageTableShow(ManageAccount, ManagePwd);
        }
    }
}

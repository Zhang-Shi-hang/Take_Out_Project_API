using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class MZGUserDAL
    {

        DBHelperList dl = new DBHelperList();
        public int UserAdd(ModelInfo mo)
        {
            var sql = string.Format("insert into UserInfo(UserPhone) values('{0}')", mo.UserPhone);
            return dl.ExecuteNonQuery(sql);
        }
        public bool Show(string UserPhone)
        {
            string sql =string.Format("select * from UserInfo where UserPhone='{0}'", UserPhone);
            var table= dl.GetTable(sql);
            if (table.Rows.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int DiscountsTableAdd(ModelInfo mo)
        {
            var sql = string.Format("insert into [DiscountsTable] values(NEWID(),'100','{0}','{1}',DATEADD(DAY,7,getdate()),1)", mo.Sid, mo.Uid);
            return dl.ExecuteNonQuery(sql);
        }
       // 
       // 

        public string UserInfoShow(string UserPhone)
        {
            var sql = string.Format("select* from[dbo].[UserInfo] where[UserPhone] ='{0}'",UserPhone);
            var mo = dl.GetToList<ModelInfo>(sql).FirstOrDefault();
            return mo.UserId.ToString();
        }
        public string ShopTableShow()
        {
            var sql = "select* from[dbo].[ShopTable] order by ShopId desc";
            var mo = dl.GetToList<ModelInfo>(sql).FirstOrDefault();
            return mo.ShopId.ToString();
        }
        public int ManageTableShow(string ManageAccount, string ManagePwd)
        {
            var sql = string.Format("select * from ManageTable where ManageAccount='{0}'and ManagePwd ='{1}'", ManageAccount, ManagePwd);
            var list= dl.GetToList<ModelInfo>(sql);
            return list.Count();
        }
    }
}

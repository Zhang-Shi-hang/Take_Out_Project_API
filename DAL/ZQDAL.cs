using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class ZQDAL
    {
        DBHelperList db = new DBHelperList();
        /// <summary>
        /// 个人信息修改
        /// </summary>
        /// <param name="mi"></param>
        /// <returns></returns>
        public int Upt(ModelInfo mi)
        {
            string sql = string.Format("update UserInfo set UserName='{0}',UserSex={1},UserAddress='{2}'  where UserPhone='{3}'", mi.UserName,mi.UserSex==false?0:1,mi.UserAddress,mi.UserPhone);
            int i = db.ExecuteNonQuery(sql);
            return i;
        }
        /// <summary>
        /// 获取用户个人信息
        /// </summary>
        /// <returns></returns>
        public List<ModelInfo> Show(string phone)
        {
            string sql = "select * from UserInfo where UserPhone='"+phone+"'";
            var list = db.GetToList<ModelInfo>(sql);
            return list;
        }
        /// <summary>
        /// 优惠表显示
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<ModelInfo> ShowYH(Guid id)
        {
            string sql = " select * from DiscountsTable where Uid='"+id+"'";
            var list = db.GetToList<ModelInfo>(sql);
            return list;
        }
        /// <summary>
        /// 修改地址
        /// </summary>
        /// <param name="mi"></param>
        /// <returns></returns>
        public int UptDZ(ModelInfo mi)
        {
            string sql = string.Format("update UserInfo set UserAddress='{0}' where UserPhone='{1}'",mi.UserAddress, mi.UserPhone);
            int i = db.ExecuteNonQuery(sql);
            return i;
        }
       
    }
}

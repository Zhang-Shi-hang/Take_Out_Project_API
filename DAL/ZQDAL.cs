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
        public List<ModelInfo> Show(string userid)
        {
            string sql = "select * from UserInfo where UserId='"+ userid + "'";
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
        /// 修改优惠劵状态
        /// </summary>
        /// <param name="mi"></param>
        /// <returns></returns>
        public int UptYH(string id)
        {
            string sql = string.Format("update DiscountsTable set DiscountStatic=0 where DiscountsId='{0}'", id);
            int i = db.ExecuteNonQuery(sql);
            return i;
        }
        /// <summary>
        /// 未付款订单
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public List<ModelInfo> Wei(Guid UserId)
        {
            string sql = "select * from OrderTable where OrderStatic=0 and Uid='"+UserId+"'";
            return db.GetToList<ModelInfo>(sql);
        }
        /// <summary>
        /// 历史订单
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public List<ModelInfo> Lishi(Guid UserId)
        {
            string sql = "select * from OrderTable where OrderStatic=3 or OrderStatic>4 and Uid='" + UserId+"'";
            return db.GetToList<ModelInfo>(sql);
        }

    }
}

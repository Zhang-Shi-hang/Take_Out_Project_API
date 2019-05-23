using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL
{
    public class WqbDAL
    {
        DBHelperList db = new DBHelperList();
        /// <summary>
        /// 全部订单
        /// </summary>
        /// <param name="id">用户id</param>
        /// <returns></returns>
        public List<ModelInfo> OrderShow(Guid id)
        {
            string sql = @"select * from OrderTable a join ShopTable b on a.Sid=b.ShopId where a.Uid = '" + id + "'";
            var list = db.GetToList<ModelInfo>(sql);
            return list;
        }
        /// <summary>
        /// 取消订单
        /// </summary>
        /// <param name="id">订单id</param>
        /// <returns></returns>
        public int DelOrder(Guid id)
        {
            string sql = "delete from OrderTable where OrderId='" + id + "'";
            var dt = db.ExecuteNonQuery(sql);
            return dt;
        }


        /// <summary>
        /// 再来一单功能
        /// </summary>
        /// <param name="id">订单id</param>
        /// <returns></returns>
        public ModelInfo FtOrder(Guid id)
        {
            string sql = "select * from DetailTable where Oid='" + id + "'";
            var mo = db.GetToList<ModelInfo>(sql).FirstOrDefault();
            return mo;
        }


        /// <summary>
        /// 订单详情    
        /// </summary>
        /// <param name="UserId">用户主键参数</param>
        /// <returns></returns>
        public List<ModelInfo> OrderParticulars(Guid UserId)
        {
            string sql = $"select * from OrderTable where Uid='{UserId}'";
            var list = db.GetToList<ModelInfo>(sql);
            return list;
        }
        /// <summary>
        /// 菜单详情中的菜品
        /// </summary>
        /// <param name="OrderId">订单主键参数</param>
        /// <returns></returns>
        public List<ModelInfo> ShowMenu(Guid OrderId)
        {
            string sql = $"select * from GreensTable a join DetailTable b on a.GreensId=b.Gid where Oid='{OrderId}'";
            var list = db.GetToList<ModelInfo>(sql);
            return list;
        }

        /// <summary>
        /// 退款表添加
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int Refund(ModelInfo m)
        {
            string sql = string.Format("insert into RefundTable values('{0}','{1}')", m.RefundCause, m.RefundExplain);
            var dt = db.ExecuteNonQuery(sql);
            return dt;
        }
        /// <summary>
        /// 评论添加
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int Comment(ModelInfo m)
        {
            string sql = string.Format("insert into CommentTable values('{0}','{1}','{2}','{3}','{4}')", m.CommentContent, m.CommentTime, m.Uid, m.Sid, m.CommentScore);
            var dt = db.ExecuteNonQuery(sql);
            return dt;
        }

        /// <summary>
        /// 订单详情    
        /// </summary>
        /// <param name="UserId">用户主键参数</param>
        /// <returns></returns>
        public List<ModelInfo> OrderParticulars(Guid UserId)
        {
            string sql = $"select * from OrderTable where Uid='{UserId}'";
            var list = db.GetToList<ModelInfo>(sql);
            return list;
        }
        /// <summary>
        /// 菜单详情中的菜品
        /// </summary>
        /// <param name="OrderId">订单主键参数</param>
        /// <returns></returns>
        public List<ModelInfo> ShowMenu(Guid OrderId)
        {
            string sql = $"select * from GreensTable a join DetailTable b on a.GreensId=b.Gid where Oid='{OrderId}'";
            var list = db.GetToList<ModelInfo>(sql);
            return list;
        }
    }
}

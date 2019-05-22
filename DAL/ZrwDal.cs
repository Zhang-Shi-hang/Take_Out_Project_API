using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;

namespace DAL
{
    public class ZrwDal
    {
        //实例化DBHelper
        DBHelperList db = new DBHelperList();



        /// <summary>
        /// 获取店铺详情信息
        /// </summary>
        /// <returns></returns>
        public List<ModelInfo> GetShopTable()
        {
            string sql = "select * from ShopTable";
            var list=db.GetToList<ModelInfo>(sql);
            return list;
        }

        /// <summary>
        /// 根据名称查询菜品信息
        /// </summary>
        /// <returns></returns>
        public List<ModelInfo> GetGreens()
        {
            string sql = $"select * from GreensTable  ";
            return db.GetToList<ModelInfo>(sql);
        }

        /// <summary>
        /// 查询菜品类型
        /// </summary>
        /// <returns></returns>
        public List<ModelInfo> GetGreensType()
        {
            string sql = "select distinct a.GreensType from GreensTable a";
            var list= db.GetToList<ModelInfo>(sql);
            return list;
        }

        /// <summary>
        /// 根据分类查询菜品信息
        /// </summary>
        /// <param name="TypeName">分类名称</param>
        /// <returns></returns>
        public List<ModelInfo> GetGreensInType(string TypeName)
        {
            string sql = $"select * from GreensTable where GreensType like'%{TypeName}%' ";
            var list= db.GetToList<ModelInfo>(sql);
            return list;
        }

        /// <summary>
        /// 生成一条订单
        /// </summary>
        /// <param name="m">信息集</param>
        /// <returns></returns>
        public int InsertOrderTable(ModelInfo m)
        {
            string sql = string.Format("insert into OrderTable values(newid(),'{0}','{1}','{2}',{3},'{4}',GETDATE(),'{5}',{6},{7})", m.Oen, m.Uid, m.Hid, m.OrderStatic,m.Sid, m.OrderRemark, m.RepastWay?1:0,m.OrderSum);
            return db.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 查询最新一条订单
        /// </summary>
        /// <returns></returns>
        public List<ModelInfo> GetOrderFirst()
        {
            string sql = "select top 1 * from OrderTable order by OrderId desc";
            return db.GetToList<ModelInfo>(sql);
        }
        /// <summary>
        /// 生成明细表数据
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int InsertDetailTable(IEnumerable<ModelInfo> Model)
        {
            var i = 0;
            foreach (var m in Model)
            {
                string sql = string.Format("insert into DetailTable values(NEWID(),'{0}',{1},{2},'{3}')", m.Gid, m.Gprice, m.Gnum,m.Oid);
                 i = db.ExecuteTrasaction(sql);
            }
            return i;
        }

        /// <summary>
        /// 根据订单编号查询菜品明细
        /// </summary>
        /// <param name="OenNum">订单编号</param>
        /// <returns></returns>
        public List<ModelInfo> GetDetailInOen(int OenNum)
        {
            string sql = "select * from DetailTable a inner join OrderTable b on a.Oid=b.OrderId inner join GreensTable c on a.Gid=c.GreensId  where b.Oen='" + OenNum + "'";
            var list= db.GetToList<ModelInfo>(sql);
            return list;
        }

        //根据订单编号查询菜品数量
        public int GetCount(int OenNum)
        {
            string sql = "select * from DetailTable a inner join OrderTable b on a.Oid=b.OrderId inner join GreensTable c on a.Gid=c.GreensId  where b.Oen='" + OenNum + "'";
            var list = db.GetToList<ModelInfo>(sql);
            return list.Count;
        }


        /// <summary>
        /// 修改订单详细情况
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int UpdateOrderInSay(ModelInfo m)
        {
            string sql = string.Format("update OrderTable set RepastWay='{0}',OrderRemark='{1}',OrderPrice='{2}', where Oen='{3}'", m.RepastWay, m.OrderRemark,m.OrderPrice, m.Oen);
            return db.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 根据用户Id查询优惠券信息
        /// </summary>
        /// <param name="Uid">用户ID</param>
        /// <returns></returns>
        public List<ModelInfo> GetDiscountsTable(string Uid)
        {
            string sql = "select * from DiscountsTable  where Uid='" + Uid + "'and DiscountStatic=1 ";
            return db.GetToList<ModelInfo>(sql);
        }

        /// <summary>
        /// 根据用户Id更改优惠券状态
        /// </summary>
        /// <param name="Uid">用户ID</param>
        /// <returns></returns>
        public int UpdateDiscounts(string Uid)
        {
            string sql = "update DiscountsTable set DiscountStatic=0 where Uid='" + Uid + "'";
            return db.ExecuteNonQuery(sql);
        }


        /// <summary>
        /// 查询订单信息
        /// </summary>
        /// <param name="Oen"></param>
        /// <returns></returns>
        public List<ModelInfo> GetOrder(string Oen)
        {
            string sql = "select * from OrderTable where Oen='" + Oen + "'";
            return db.GetToList<ModelInfo>(sql);
        }


        /// <summary>
        /// 结算完成后修改订单状态
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int UpdateOrder(ModelInfo m)
        {
            string sql = $"update OrderTable set OrderStatic='{m.OrderStatic}' where Oen='{m.Oen}'";
            return db.ExecuteNonQuery(sql);
        }
    }
}

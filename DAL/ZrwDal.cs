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
            return db.GetToList<ModelInfo>(sql);
        }

        /// <summary>
        /// 根据名称查询菜品信息
        /// </summary>
        /// <param name="name">菜品名称</param>
        /// <returns></returns>
        public List<ModelInfo> GetGreensInName(string Name)
        {
            string sql = $"select * from GreensTable where GreensName like'%{Name}%' ";
            return db.GetToList<ModelInfo>(sql);
        }

        /// <summary>
        /// 查询菜品类型
        /// </summary>
        /// <returns></returns>
        public List<ModelInfo> GetGreensType()
        {
            string sql = "select distinct a.GreensType from GreensTable a";
            return db.GetToList<ModelInfo>(sql);
        }

        /// <summary>
        /// 根据分类查询菜品信息
        /// </summary>
        /// <param name="TypeName">分类名称</param>
        /// <returns></returns>
        public List<ModelInfo> GetGreensInType(string TypeName)
        {
            string sql = $"select * from GreensTable where GreensType like'%{TypeName}%' ";
            return db.GetToList<ModelInfo>(sql);
        }

        /// <summary>
        /// 生成一条订单
        /// </summary>
        /// <param name="m">信息集</param>
        /// <returns></returns>
        public int InsertOrderTable(ModelInfo m)
        {
            string sql = string.Format("insert into OrderTable values(newid(),'{0}','{1}','{2}',{3},GETDATE(),'{4}',{5},{6})", m.Oen, m.Uid, m.Hid, m.OrderStatic, m.OrderRemark, m.RepastWay,m.OrderSum);
            return db.ExecuteNonQuery(sql);
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
                string sql = string.Format("insert into DetailTable values(NEWID(),'{0}',{1},{2},{3},'{4}')", m.Gid, m.Gprice, m.Gnum, m.Gsum, m.Oid);
                i += db.ExecuteNonQuery(sql);
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
            string sql = "select * from OrderTable a inner join DetailTable b on a.OrderId=b.Oid where a.Oen=" + OenNum;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using BLL;
using Model;

namespace Take_Out_Project_API.Controllers
{
    public class ZrwController : ApiController
    {

        //实例化bll层
        ZrwBll bll = new ZrwBll();

        /// <summary>
        /// 获取店铺详情信息
        /// </summary>
        /// <returns></returns>
        public List<ModelInfo> GetShopTable()
        {
            return bll.GetShopTable();
        }

        /// <summary>
        /// 根据名称查询菜品信息
        /// </summary>
        /// <param name="name">菜品名称</param>
        /// <returns></returns>
        public List<ModelInfo> GetGreensInName(string Name)
        {
            return bll.GetGreensInName(Name);
        }

        /// <summary>
        /// 查询菜品类型
        /// </summary>
        /// <returns></returns>
        public List<ModelInfo> GetGreensType()
        {
            return bll.GetGreensType();
        }

        /// <summary>
        /// 根据分类查询菜品信息
        /// </summary>
        /// <param name="TypeName">分类名称</param>
        /// <returns></returns>
        public List<ModelInfo> GetGreensInType(string TypeName)
        {
            return bll.GetGreensInName(TypeName);
        }

        /// <summary>
        /// 生成一条订单
        /// </summary>
        /// <param name="m">信息集</param>
        /// <returns></returns>
        public int InsertOrderTable(ModelInfo m)
        {
            return bll.InsertOrderTable(m);
        }

        /// <summary>
        /// 生成明细表数据
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int InsertDetailTable(IEnumerable<ModelInfo> Model)
        {
            return bll.InsertDetailTable(Model);
        }

        /// <summary>
        /// 根据订单编号查询菜品明细
        /// </summary>
        /// <param name="OenNum">订单编号</param>
        /// <returns></returns>
        public List<ModelInfo> GetDetailInOen(int OenNum)
        {
            return bll.GetDetailInOen(OenNum);
        }

        /// <summary>
        /// 结算完成后修改订单状态
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int UpdateOrder(ModelInfo m)
        {
            return bll.UpdateOrder(m);
        }
    }
}

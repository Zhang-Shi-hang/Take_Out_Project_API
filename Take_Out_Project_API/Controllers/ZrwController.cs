using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using BLL;
using Model;
using Newtonsoft.Json;

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
        /// 
        [HttpGet]
        public List<ModelInfo> GetShopTable()
        {
            return bll.GetShopTable();
        }

        /// <summary>
        /// 根据名称查询菜品信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<ModelInfo> GetGreens( )
        {
            return bll.GetGreens();
        }

        /// <summary>
        /// 查询菜品类型
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<ModelInfo> GetGreensType()
        {
            return bll.GetGreensType();
        }

        /// <summary>
        /// 根据分类查询菜品信息
        /// </summary>
        /// <param name="TypeName">分类名称</param>
        /// <returns></returns>
        [HttpGet]
        public List<ModelInfo> GetGreensInType(string TypeName)
        {
            return bll.GetGreensInType(TypeName);
        }
        /// <summary>
        /// 生成一条订单
        /// </summary>
        /// <param name="m">信息集</param>
        /// <returns></returns>
        [HttpPost]
        public int InsertOrderTable([FromBody] ModelInfo m)
        {
            return bll.InsertOrderTable(m);
        }
        /// <summary>
        /// 查询最新一条订单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<ModelInfo> GetOrderFirst()
        {
            return bll.GetOrderFirst();
        }
        /// <summary>
        /// 生成明细表数据
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        [HttpPost]
        public int InsertDetailTable(IEnumerable<ModelInfo> Model)
        {
            return bll.InsertDetailTable(Model);
        }

        /// <summary>
        /// 根据订单编号查询菜品明细
        /// </summary>
        /// <param name="OenNum">订单编号</param>
        /// <returns></returns>
        
        [HttpGet]
        public List<ModelInfo> GetDetailInOen(string OenNum)
        {
            return bll.GetDetailInOen(OenNum);
        }
        //根据订单编号查询菜品数量
        [HttpGet]
        public int GetCount(string OenNum)
        {
            return bll.GetCount(OenNum);
        }

        /// <summary>
        /// 修改订单备注和就餐方式
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        [HttpGet]
        public int UpdateOrderInSay(string str)
        {
            var m = JsonConvert.DeserializeObject<ModelInfo>(str);
            return bll.UpdateOrderInSay(m);
        }

        /// <summary>
        /// 根据用户Id查询优惠券信息
        /// </summary>
        /// <param name="Uid">用户ID</param>
        /// <returns></returns>
        [HttpGet]
        public List<ModelInfo> GetDiscountsTable(string Uid)
        {
            var list= bll.GetDiscountsTable(Uid);
            return list;
        }

        /// <summary>
        /// 根据用户Id更改优惠券状态
        /// </summary>
        /// <param name="Uid">用户ID</param>
        /// <returns></returns>
        [HttpGet]
        public int UpdateDiscounts(string Uid,string DiscountsId)
        {
            return bll.UpdateDiscounts(Uid, DiscountsId);
        }

        /// <summary>
        /// 查询订单信息
        /// </summary>
        /// <param name="Oen"></param>
        /// <returns></returns>
        [HttpGet]
        public List<ModelInfo> GetOrder(string Oen)
        {
            return bll.GetOrder(Oen);
        }

        /// <summary>
        /// 结算完成后修改订单状态
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        [HttpGet]
        public int UpdateOrder(string Oen)
        {
            return bll.UpdateOrder(Oen);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using BLL;
namespace Take_Out_Project_API.Controllers
{
    public class WqbController : ApiController
    {
        WqbBLL bll = new WqbBLL();
        /// <summary>
        /// 全部订单
        /// </summary>
        /// <param name="id">用户id</param>
        /// <returns></returns>
        /// 1
        [HttpGet]
        public List<ModelInfo> OrderShow(Guid id)
        {
            return bll.OrderShow(id);
        }
        /// <summary> 
        /// 取消订单
        /// </summary>
        /// <param name="id">订单id</param>
        /// <returns></returns>
        /// 
        [HttpGet]
        public int DelOrder(Guid id)
        {
            return bll.DelOrder(id);
        }


        /// <summary>
        /// 再来一单功能
        /// </summary>
        /// <param name="id">订单id</param>
        /// <returns></returns>
        /// 
        [HttpGet]
        public ModelInfo FtOrder(Guid id)
        {
            return bll.FtOrder(id);
        }


        /// <summary>
        /// 订单详情
        /// </summary>
        /// <param name="uid">用户ID</param>
        /// <param name="oid">订单ID</param>
        /// <returns></returns>
        /// 
        [HttpGet]
        public List<ModelInfo> OrderInfo(Guid uid, Guid oid)
        {
            return bll.OrderInfo(uid, oid);
        }


        /// <summary>
        /// 退款表添加
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        /// 
        [HttpGet]
        public int Refund(ModelInfo m)
        {
            return bll.Refund(m);
        }
        /// <summary>
        /// 评论添加
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        /// 
        [HttpGet]
        public int Comment(ModelInfo m)
        {
            return bll.Comment(m);
        }
    }
}

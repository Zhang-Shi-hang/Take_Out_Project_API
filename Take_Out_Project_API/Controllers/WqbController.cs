using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using BLL;
using Newtonsoft.Json;
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
        /// 
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
        /// <param name="OrderId">订单主键参数</param>
        /// <returns></returns>
        [HttpGet]
        public List<ModelInfo> OrderParticulars(Guid OrderId)
        {
            return bll.OrderParticulars(OrderId);
        }
        /// <summary>
        /// 菜单详情中的菜品
        /// </summary>
        /// <param name="OrderId">订单主键参数</param>
        /// <returns></returns>
        [HttpGet]
        public List<ModelInfo> ShowMenu(Guid OrderId)
        {
            return bll.ShowMenu(OrderId);
        }
        /// <summary>
        /// 退款表添加
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        /// 
        [HttpGet]
        public int Refund(string str)
        {
            var m = JsonConvert.DeserializeObject<ModelInfo>(str);
            return bll.Refund(m);
        }
        /// <summary>
        /// 评论添加
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        /// 
        [HttpGet]
        public int Comment(string str)
        {
            var m = JsonConvert.DeserializeObject<ModelInfo>(str);
            return bll.Comment(m);
        }

        /// <summary>
        /// 修改订单状态评论完成
        /// </summary>
        /// <param name="OrderId">订单主键参数</param>
        /// <returns></returns>
        /// 
        [HttpGet]
        public int UptComment(Guid OrderId)
        {
            return bll.UptComment(OrderId);
        }

        /// <summary>
        /// 修改订单状态退款中
        /// </summary>
        /// <param name="OrderId">订单主键参数</param>
        /// <returns></returns>
        /// 
        [HttpGet]
        public int UptRefund(Guid OrderId)
        {
            return bll.UptRefund(OrderId);
        }

        /// <summary>
        /// 修改订单状态退款完成
        /// </summary>
        /// <param name="OrderId">订单主键参数</param>
        /// <returns></returns>
        /// 
        [HttpGet]
        public int UptRefundOk(Guid OrderId)
        {
            return bll.UptRefundOk(OrderId);
        }
    }
}

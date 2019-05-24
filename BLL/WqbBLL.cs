using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
namespace BLL
{
    public class WqbBLL
    {
        WqbDAL dal = new WqbDAL();
        /// <summary>
        /// 全部订单
        /// </summary>
        /// <param name="id">用户id</param>
        /// <returns></returns>
        public List<ModelInfo> OrderShow(Guid id)
        {
            return dal.OrderShow(id);
        }
        /// <summary>
        /// 取消订单
        /// </summary>
        /// <param name="id">订单id</param>
        /// <returns></returns>
        public int DelOrder(Guid id)
        {
            return dal.DelOrder(id);
        }


        /// <summary>
        /// 再来一单功能
        /// </summary>
        /// <param name="id">订单id</param>
        /// <returns></returns>
        public ModelInfo FtOrder(Guid id)
        {
            return dal.FtOrder(id);
        }


        /// <summary>
        /// 订单详情    
        /// </summary>
        /// <param name="UserId">用户主键参数</param>
        /// <returns></returns>
        public List<ModelInfo> OrderParticulars(Guid OrderId)
        {
            return dal.OrderParticulars(OrderId);
        }
        /// <summary>
        /// 菜单详情中的菜品
        /// </summary>
        /// <param name="OrderId">订单主键参数</param>
        /// <returns></returns>
        public List<ModelInfo> ShowMenu(Guid OrderId)
        {
            return dal.ShowMenu(OrderId);
        }

        /// <summary>
        /// 退款表添加
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int Refund(ModelInfo m)
        {
            return dal.Refund(m);
        }
        /// <summary>
        /// 评论添加
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int Comment(ModelInfo m)
        {
            return dal.Comment(m);
        }

        /// <summary>
        /// 修改订单状态评论完成
        /// </summary>
        /// <param name="OrderId">订单主键参数</param>
        /// <returns></returns>
        public int UptComment(Guid OrderId)
        {
            return dal.UptComment(OrderId);
        }

        /// <summary>
        /// 修改订单状态退款中
        /// </summary>
        /// <param name="OrderId">订单主键参数</param>
        /// <returns></returns>
        public int UptRefund(Guid OrderId)
        {
            return dal.UptRefund(OrderId);
        }

        /// <summary>
        /// 修改订单状态退款完成
        /// </summary>
        /// <param name="OrderId">订单主键参数</param>
        /// <returns></returns>
        public int UptRefundOk(Guid OrderId)
        {
            return dal.UptRefundOk(OrderId);
        }
    }
}

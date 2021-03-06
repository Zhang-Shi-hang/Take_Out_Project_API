﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using Model;

namespace BLL
{
    public class ZrwBll
    {
        //实例化DAL层
        ZrwDal dal = new ZrwDal();
        /// <summary>
        /// 获取店铺详情信息
        /// </summary>
        /// <returns></returns>
        public List<ModelInfo> GetShopTable()
        {
            return dal.GetShopTable();
        }

        /// <summary>
        /// 根据名称查询菜品信息
        /// </summary>
        /// <param name="name">菜品名称</param>
        /// <returns></returns>
        public List<ModelInfo> GetGreens( )
        {
            return dal.GetGreens();
        }

        /// <summary>
        /// 查询菜品类型
        /// </summary>
        /// <returns></returns>
        public List<ModelInfo> GetGreensType()
        {
            return dal.GetGreensType();
        }

        /// <summary>
        /// 根据分类查询菜品信息
        /// </summary>
        /// <param name="TypeName">分类名称</param>
        /// <returns></returns>
        public List<ModelInfo> GetGreensInType(string TypeName)
        {
            return dal.GetGreensInType(TypeName);
        }

        /// <summary>
        /// 生成一条订单
        /// </summary>
        /// <param name="m">信息集</param>
        /// <returns></returns>
        public int InsertOrderTable(ModelInfo m)
        {
            return dal.InsertOrderTable(m);
        }
        /// <summary>
        /// 查询最新一条订单
        /// </summary>
        /// <returns></returns>
        public List<ModelInfo> GetOrderFirst()
        {
            return dal.GetOrderFirst();
        }
        /// <summary>
        /// 生成明细表数据
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int InsertDetailTable(IEnumerable<ModelInfo> Model)
        {
            return dal.InsertDetailTable(Model);
        }

        /// <summary>
        /// 根据订单编号查询菜品明细
        /// </summary>
        /// <param name="OenNum">订单编号</param>
        /// <returns></returns>
        public List<ModelInfo> GetDetailInOen(string OenNum)
        {
            return dal.GetDetailInOen(OenNum);
        }
        //根据订单编号查询菜品数量
        public int GetCount(string OenNum)
        {
            return dal.GetCount(OenNum);
        }

        /// <summary>
        /// 根据用户Id查询优惠券信息
        /// </summary>
        /// <param name="Uid">用户ID</param>
        /// <returns></returns>
        public List<ModelInfo> GetDiscountsTable(string Uid)
        {
            return dal.GetDiscountsTable(Uid);
        }

        /// <summary>
        /// 根据用户Id更改优惠券状态
        /// </summary>
        /// <param name="Uid">用户ID</param>
        /// <returns></returns>
        public int UpdateDiscounts(string Uid,string DiscountsId)
        {
            return dal.UpdateDiscounts(Uid, DiscountsId);
        }

        /// <summary>
        /// 查询订单信息
        /// </summary>
        /// <param name="Oen"></param>
        /// <returns></returns>
        public List<ModelInfo> GetOrder(string Oen)
        {
            return dal.GetOrder(Oen);
        }

        /// <summary>
        /// 修改订单备注和就餐方式
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int UpdateOrderInSay(ModelInfo m)
        {
            return dal.UpdateOrderInSay(m);
        }



        /// <summary>
        /// 结算完成后修改订单状态
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int UpdateOrder(string Oen)
        {
            return dal.UpdateOrder(Oen);
        }
        /// <summary>
        /// 查看用户是否填写个人资料
        /// </summary>
        /// <param name="Uid"></param>
        /// <returns></returns>
        public bool SearchAddress(string Uid)
        {
            return dal.SearchAddress(Uid);
        }
        /// <summary>
        /// 添加用户积分
        /// </summary>
        /// <param name="uid">用户主键Id</param>
        /// <param name="Integral">用户积分参数</param>
        /// <returns></returns>
        public int AddIntegral(Guid uid, decimal Integral)
        {
            return dal.AddIntegral(uid,Integral);
        }
    }
}

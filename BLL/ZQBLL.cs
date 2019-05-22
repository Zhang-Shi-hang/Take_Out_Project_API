using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class ZQBLL
    {
        ZQDAL zd = new ZQDAL();
        /// <summary>
        /// 个人信息修改
        /// </summary>
        /// <param name="mi"></param>
        /// <returns></returns>
        public int Upt(ModelInfo mi)
        {

            return zd.Upt(mi);
        }
        /// <summary>
        /// 获取用户个人信息
        /// </summary>
        /// <returns></returns>
        public List<ModelInfo> Show(string phone)
        {
           
            return zd.Show(phone);
        }
        /// <summary>
        /// 优惠表显示
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<ModelInfo> ShowYH(Guid id)
        {
           
            return zd.ShowYH(id);
        }
        /// <summary>
        /// 修改地址
        /// </summary>
        /// <param name="mi"></param>
        /// <returns></returns>
        public int UptDZ(ModelInfo mi)
        {

            return zd.UptDZ(mi);
        }
    }
}

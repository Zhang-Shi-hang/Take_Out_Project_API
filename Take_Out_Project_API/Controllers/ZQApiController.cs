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
    public class ZQApiController : ApiController
    {
        ZQBLL zb = new ZQBLL();
        /// <summary>
        /// 个人信息修改
        /// </summary>
        /// <param name="mi"></param>
        /// <returns></returns>
        [HttpGet]
        public int Upt(string json)
        {
            var mi = JsonConvert.DeserializeObject<ModelInfo>(json);
           
            return zb.Upt(mi);
        }
        /// <summary>
        /// 获取用户个人信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<ModelInfo> Show(string userid)
        {

            return zb.Show(userid);
        }
        /// <summary>
        /// 优惠表显示
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public List<ModelInfo> ShowYH(Guid id)
        {

            return zb.ShowYH(id);
        }
        /// <summary>
        /// 修改地址
        /// </summary>
        /// <param name="mi"></param>
        /// <returns></returns>
        [HttpPut]
        public int UptDZ(string json)
        {
            var mi = JsonConvert.DeserializeObject<ModelInfo>(json);
            return zb.UptDZ(mi);
        }
    }
}
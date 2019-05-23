using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;

namespace Take_Out_Project_API.Controllers
{
    public class MZGUserController : ApiController
    {
       
            MZGUserBLL bl = new MZGUserBLL();

            //使用手机号完成登录/注册
            [HttpPost]
            public int UserAdd(ModelInfo mo)
            {
                return bl.UserAdd(mo);
            }
        //使用手机号完成登录/注册
        [HttpGet]
            public bool Show(string UserPhone)
            {
                return bl.Show(UserPhone);
            }
        //添加代金券
        [HttpPost]
        public int DiscountsTableAdd(ModelInfo mo)
        {
            return bl.DiscountsTableAdd(mo);
        }
        //绑定Uid
        [HttpGet]
        public string UserInfoShow(string UserPhone)
        {
            return bl.UserInfoShow(UserPhone);
        }
        [HttpGet]
        //绑定Sid
        public string ShopTableShow()
        {
            return bl.ShopTableShow();
        }
        [HttpGet]
        public int ManageTableShow(string ManageAccount, string ManagePwd)
        {
            int n= bl.ManageTableShow(ManageAccount, ManagePwd);
            return n;
        }
    }
    }

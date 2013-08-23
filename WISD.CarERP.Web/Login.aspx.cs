using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WISD.CarERP.Web
{
    public partial class Login : System.Web.UI.Page
    {
        #region 字段

        #endregion


        #region 事件
        /// <summary>
        /// 加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        { }


        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ibtnLogin_Click(object sender, ImageClickEventArgs e)
        {
            this.LoginSys();
        }
        #endregion


        #region 方法
        /// <summary>
        /// 登录
        /// </summary>
        private void LoginSys()
        {
            try
            {
                string userName = this.txtUserName.Text.Trim();
                string userPassword = this.txtUserPassword.Text.Trim();
                string checkCode = this.txtCheckCode.Text.Trim();
                if (userName.Equals("") || userPassword.Equals("") || checkCode.Equals(""))
                {
                    this.lblMessage.Text = "请输入用户名、密码或验证码";
                }
                else if (checkCode.ToLower() != Session["CheckCode"].ToString().Trim().ToLower())
                {
                    this.lblMessage.Text = "验证码错误";
                }
                else
                {
                    if (Session["CountOfLogin"] == null)
                    {
                        Session["CountOfLogin"] = 1;
                    }
                    else
                    {
                        Session["CountOfLogin"] = Convert.ToInt32(Session["CountOfLogin"]) + 1;
                    }

                    //判断登录
                    if (Session["CountOfLogin"] != null && Convert.ToInt32(Session["CountOfLogin"]) > 3)
                    {
                        this.lblMessage.Text = "登录错误超过3次，请关闭浏览器，重新登录！";
                    }
                    else if (true)    //验证用户名和密码
                    {
                        Session.Timeout = 45;    //设置超时时间
                        Session["UserID"] = "1";
                        Session["UserCode"] = "admin";
                        Session["UserName"] = userName;
                        Session["CountOfLogin"] = null;
                        Session["CheckCode"] = null;

                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        this.lblMessage.Text = "用户名或密码不正确。";
                    }
                }
            }
            catch (Exception ex)
            {
                this.lblMessage.Text = "登录出错，请联系管理员。";
            }
        }

        #endregion
    }
}

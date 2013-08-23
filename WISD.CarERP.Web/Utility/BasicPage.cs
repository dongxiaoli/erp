using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace WISD.CarERP.Web.Utility
{
    public class BasicPage : System.Web.UI.Page
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public BasicPage()
        {
            this.Load += new EventHandler(BasicPage_Load);
        }


        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BasicPage_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
            {
                Response.Write("<script>parent.location.href='/Login.aspx'</script>");
                Response.End();
            }
        }


        /// <summary>
        /// 验证用户权限
        /// </summary>
        /// <param name="permission"></param>
        protected void CheckPermission(string permission)
        {

        }


        /// <summary>
        /// 遮罩提示窗口
        /// </summary>
        /// <param name="width">宽度</param>
        /// <param name="height">高度</param>
        /// <param name="title">窗口标题</param>
        /// <param name="message">提示文字</param>
        /// <param name="url">返回地址</param>
        /// <param name="css">CSS样式</param>
        protected void ShowMessageBox(int width, int height, string title, string message, string url, string css)
        {
            string script = "";
            script += "<script type=\"text/javascript\">\n";
            script += "jsmsg(" + width + "," + height + ",\"" + title + "\",\"" + message + "\",\"" + url + "\",\"" + css + "\")\n";
            script += "</script>\n";
            ClientScript.RegisterClientScriptBlock(Page.GetType(), "JsMsg", script);
        }


        /// <summary>
        /// 可以自动关闭的提示窗口
        /// </summary>
        /// <param name="title">提示文字</param>
        /// <param name="url">返回地址</param>
        /// <param name="css">CSS样式</param>
        protected void ShowMessageBox(string title, string url, string css)
        {
            string script = "";
            script += "<script type=\"text/javascript\">\n";
            script += "parent.jsprint(\"" + title + "\",\"" + url + "\",\"" + css + "\")\n";
            script += "</script>\n";
            ClientScript.RegisterClientScriptBlock(Page.GetType(), "JsPrint", script);
        }


    }
}

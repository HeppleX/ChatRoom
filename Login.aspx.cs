using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    string[,] user = { { "张三", "11111" }, { "李四", "11111" }, { "王五", "11111" } };
    
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Focus();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        for(int i=0;i<=2;i++)
        {
            if(TextBox1.Text==user[i,0]&&TextBox2.Text==user[i,1])
            {
                Session["user"] = user[i, 0];
                Response.Redirect("Chat.aspx");
            }
        }
        Response.Write("<script type='text/javascript'>alert('用户名或密码错误！');</script>");
    }
}
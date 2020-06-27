using System;

public partial class Chat : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "发言人：" + Session["user"];
        if(!IsPostBack)
        {
            Application["message"] = Session["user"] + "进入聊天室<br/>"
                + Application["message"];
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Application.Lock();
        Application["message"] = Session["user"] + "说：" + TextBox1.Text +
            "(" + DateTime.Now.ToString() + ")<br/>" + Application["message"];
        Application.UnLock();
        TextBox1.Text = "";
    }
}
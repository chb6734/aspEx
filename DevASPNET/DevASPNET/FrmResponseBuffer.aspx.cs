using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevASPNET
{
    public partial class FrmResponseBuffer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //현재 페이지를 매번 새로 읽어옵
            Response.Expires = -1;
            //버퍼링 사용
            Response.Buffer = false;
            // 화면 글쓰기
            Response.Write(
                "[1] 현재 글은 보여짐 <br />");
            //버퍼에 있는 내용 출력
            Response.Flush();
            //화면 글쓰기
            Response.Write(
                "[2] 현재 글은 안보임<br />");
            //ㅣ현재 버퍼 내용 비우기
            Response.Clear();
            Response.Write("[3] 보여짐 <br />");
            // 현재 페이지 종료
            Response.End();
            //문자열 출력
            Response.Write("[4] 실행 안됨 <br />");
             

        }
    }
}
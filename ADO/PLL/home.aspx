<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="ADO.PLL.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Quiz</title>
    
    <style>
        @import url('https://fonts.googleapis.com/css2?family=Montserrat:wght@200;300;500&display=swap');
  body {
    margin: 0;
    font-size: 16px;
    background-color: #009688 ;
    font-family: 'Montserrat', sans-serif;
    font-weight:400;
   }

*{
    box-sizing:border-box;
    margin:0;
    padding:0;
    outline:none;
}
.custom-box {
    max-width: 700px;
    background-color: #ffffff;
    margin: 40px auto;
    padding: 30px;
    border-radius: 10px;
}

.home-box h3{
    font-size:18px;
    color:#000000;
    font-weight:500;
    margin-bottom:15px;
    line-height:25px;

}
.home-box p{
    font-size:16px;
    margin-bottom:10px;
    line-height:22px;
    color:#000000;
    font-weight:400;

}
.home-box p span{
   
    font-weight:500;

}
.home-box .btn{
  margin-top:20px;
}
.btn{
    padding:15px 45px;
    background-color:#009688;
    color:#ffffff;
    border:none;
    border-radius:5px;
    font-family: 'Montserrat', sans-serif;
    font-size:16px;
    cursor:pointer;
      display:inline-block;
}

    </style>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="home-box custom-box">
            <h3>Instruction:</h3>
            <p>Total number of questions:<span class="total-question">10</span></p>
            <asp:Button CssClass="btn" runat="server" ID="start" Text="Start Quiz" OnClick="start_Click" />
            




        </div>
    </form>
</body>
</html>



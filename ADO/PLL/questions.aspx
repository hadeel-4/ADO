<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="questions.aspx.cs" Inherits="ADO.PLL.questions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Questions</title>
    <style>
        .quiz-box .question-number
        {
            font-size:18px;
          color:#009688;
          font-weight:600;
          border-bottom:1px solid #cccccc;
          padding-bottom:10px;
          line-height:25px;
        
        }

        .quiz-box .question-text{
            font-size:22px;
          color:#000000;
          font-weight:400;
          
          padding:20px 0;
          line-height:28px;
          margin:0;
          
        }
        .quiz-box .option-container .option{
            font-size:15px;
          color:#000000;
         background-color:#cccccc;
          
          padding:15px;
          line-height:22px;
          border-radius:5px;
          margin-bottom:10px;
          cursor:pointer;

        }
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
        .btn{
        border-style: none;
            border-color: inherit;
            border-width: medium;
            padding: 15px 45px;
            background-color:#5ad5cb;
            color:#ffffff;
            border-radius:5px;
            font-family: 'Montserrat', sans-serif;
            font-size:16px;
            cursor:pointer;
            display:inline-block;
            margin:15px 15px;
            height: 54px;
        }
        .custom-box {
    max-width: 700px;
    background-color: #ffffff;
    margin: 40px auto;
    padding: 30px;
    border-radius: 10px;
}
        
    </style>
    
</head>
<body>
    <form id="form1" runat="server">
       
        <asp:Repeater ID="repeater" runat="server" >
             
            <ItemTemplate>
        
        <div class="quiz-box custom-box">
            <div class="question-number">
                
               Question <asp:label runat="server" ID="QuestionNumber" Text="" ></asp:label>of 10
            </div>
            <div class="question-text">
                <%#Eval("statement") %>
            </div>
            <div class="option-container">


                <div class="option">
                    <asp:RadioButton runat="server" ID="rd1" Text='<%#Eval("Option1") %>' GroupName="r" />

                </div>
                <div class="option"> 
                   <asp:RadioButton runat="server" ID="rd2" Text='<%#Eval("Option2") %>' GroupName="r" />

                </div>
                <div class="option">
                   <asp:RadioButton runat="server" ID="rd3" Text='<%#Eval("Option3") %>' GroupName="r" />

                </div>
                

            </div>
            <div >
                <asp:Label ID="correct" runat="server" Text='<%#Eval("CorrectAnswer") %>' Visible="false" ></asp:Label><br />
                <asp:Label ID="selectedOption" runat="server" Text="" ></asp:Label><br />
                 <asp:Label ID="showCorrect" runat="server" Text="" ></asp:Label>
                
            </div>
        </div>
                </ItemTemplate>

      </asp:Repeater>

         <asp:Label ID="Mark" runat="server" Text="" ></asp:Label><br />


        <asp:Button ID="save" runat="server" CssClass="btn" Text="Save" OnClick="save_Click" />
         <asp:Button ID="more" runat="server" CssClass="btn" Text="Solve More" OnClick="more_Click"  />
        
        
       
    </form>
</body>
</html>

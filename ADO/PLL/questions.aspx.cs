using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ADO.PLL
{
    public partial class questions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                Operation data = new Operation();

                repeater.DataSource = data.GetData();
                repeater.DataBind();
                int questionNumber = 1;
                foreach (RepeaterItem ri in repeater.Items)
                {
                    Label q = (Label)ri.FindControl("QuestionNumber");
                    q.Text = questionNumber + " ";
                    questionNumber++;
                }

            }
        }

        protected void save_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int mark = 0;
                foreach (RepeaterItem ri in repeater.Items)
                {
                    RadioButton rb1 = (RadioButton)ri.FindControl("rd1");
                    Label labelCorrectness = (Label)ri.FindControl("correct");
                    Label showCorrect = (Label)ri.FindControl("showCorrect");

                     RadioButton rb2 = (RadioButton)ri.FindControl("rd2");
                    RadioButton rb3 = (RadioButton)ri.FindControl("rd3");

                    if (rb1.Checked == true)
                    {
                        if (rb1.Text.Equals(labelCorrectness.Text))
                        {
                            mark++;
                            Label answer = (Label)ri.FindControl("selectedOption");
                            answer.Text = "The Selected Answer Is <b>" + rb1.Text.ToString() + "</b>";
                            answer.ForeColor = System.Drawing.Color.Green;

                        }
                        else
                        {
                            Label wrong = (Label)ri.FindControl("selectedOption");
                            wrong.Text = "The Selected Answer - <b>" + rb1.Text.ToString() + "</b> - Is Wrong !";
                            wrong.ForeColor = System.Drawing.Color.Red;
                            showCorrect.Text = "The Correct Answer Is: " + labelCorrectness.Text;

                        }
                    }


                    else if (rb2.Checked == true)
                    {
                        if (rb2.Text.Equals(labelCorrectness.Text))
                        {
                            mark++;
                            Label answer = (Label)ri.FindControl("selectedOption");
                            answer.Text = "The Selected Answer Is <b>" + rb2.Text.ToString() + "</b>";
                            answer.ForeColor = System.Drawing.Color.Green;

                        }
                        else
                        {
                            Label wrong = (Label)ri.FindControl("selectedOption");
                            wrong.Text = "The Selected Answer - <b>" + rb2.Text.ToString() + "</b> - Is Wrong !";
                            wrong.ForeColor = System.Drawing.Color.Red;
                            showCorrect.Text = "The Correct Answer Is: " + labelCorrectness.Text;

                        }
                    }

                    else if (rb3.Checked == true)
                    {
                        if (rb3.Text.Equals(labelCorrectness.Text))
                        {
                            mark++;
                            Label answer = (Label)ri.FindControl("selectedOption");
                            answer.Text = "The Selected Answer Is <b>" + rb3.Text.ToString() + "</b>";
                            answer.ForeColor = System.Drawing.Color.Green;

                        }
                        else
                        {
                            Label wrong = (Label)ri.FindControl("selectedOption");
                            wrong.Text = "The Selected Answer -  <b>" + rb3.Text.ToString() + "</b> - Is Wrong !";
                            wrong.ForeColor = System.Drawing.Color.Red;
                            showCorrect.Text = "The Correct Answer Is: " + labelCorrectness.Text;

                        }
                    }


                }
                Label Finalmark = (Label)FindControl("Mark");
                Finalmark.Visible = true;
                Finalmark.Text = "Your Total Mark Is Is <b>" + mark + "</b>";
                save.Enabled = false;
            }
        }

        protected void more_Click(object sender, EventArgs e)
        {
            save.Enabled = true;

            Operation data = new Operation();

            repeater.DataSource = data.GetData();
            repeater.DataBind();
            Label Finalmark = (Label)FindControl("Mark");
            Finalmark.Visible = false;






            int questionNumber = 1;
            foreach (RepeaterItem ri in repeater.Items)
            {
                Label q = (Label)ri.FindControl("QuestionNumber");
                q.Text = questionNumber + " ";
                questionNumber++;
            }
        }
    }
}
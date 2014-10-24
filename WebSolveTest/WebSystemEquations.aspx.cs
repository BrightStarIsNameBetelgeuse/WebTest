using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSolveTest.Logic;

namespace WebSolveTest
{
    public partial class WebSystemEquations : System.Web.UI.Page
    {
        private int[,] matrix;
        private int[] coefs;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            matrix = new int[3, 3];

            matrix[0, 0] = Int32.Parse(TextBox1.Text);
            matrix[0, 1] = Int32.Parse(TextBox2.Text);
            matrix[0, 2] = Int32.Parse(TextBox3.Text);
            matrix[1, 0] = Int32.Parse(TextBox4.Text);
            matrix[1, 1] = Int32.Parse(TextBox5.Text);
            matrix[1, 2] = Int32.Parse(TextBox6.Text);
            matrix[2, 0] = Int32.Parse(TextBox7.Text);
            matrix[2, 1] = Int32.Parse(TextBox8.Text);
            matrix[2, 2] = Int32.Parse(TextBox9.Text);


            coefs = new int[3];

            coefs[0] = Int32.Parse(TextBox10.Text);
            coefs[1] = Int32.Parse(TextBox11.Text);
            coefs[2] = Int32.Parse(TextBox12.Text);

            ContextSolveStrategy context = new ContextSolveStrategy(new KramerSolveStrategy(3,3));
            double[] results = context.Solve(matrix);
            for (int i = 0; i < results.Length; i++)
            {
                Label label = new Label();
                label.Text = "x" + i + " = " + results[i];
                label.Visible = true;
                form2.Controls.Add(label);
            }

        }
    }
}
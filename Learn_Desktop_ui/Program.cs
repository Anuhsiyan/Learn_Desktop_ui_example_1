using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Drawing;

namespace Learn_Desktop_ui
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // Initialize and run the form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Mainform());
        }
    }
    public class Mainform : Form
    {
        private TextBox textBox1;
        private TextBox textBox2;
        private Button Add;

        public Mainform()
        {
            //initialize components
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Add = new Button();

            //set properties of textbox1
            textBox1.Location = new System.Drawing.Point(20,20); //location of the box like margin assemble the box
            textBox1.Size = new System.Drawing.Size(100, 20); //width and Height

            //set properties of textbox1
            textBox2.Location = new System.Drawing.Point(20, 50);
            textBox2.Size = new System.Drawing.Size(100,20);

            //set properties of add button
           /*new button object here add is the name of the button*/ Add.Location = new System.Drawing.Point(20, 80);
            Add.Size = new System.Drawing.Size(100,20);
            Add.Text= "Add"; //Button name
            Add.Click += new EventHandler(Addbutton_click);  //(like addeventlisener) in c# eventhandler

            //Add controls to the form
            this.Controls.Add(textBox1);
            this.Controls.Add(textBox2);
            this.Controls.Add(Add);

            //set form properties
            this.Text = "simple addtion"; //head of the name when screen is created like title
            this.StartPosition = FormStartPosition.CenterScreen ; //form create location when we click the start button
            this.Size = new System.Drawing.Size(500,160); //UI width and Height
       }


        //Event handler for addbutton click
        private void Addbutton_click(object sender, EventArgs e) // tis is a function what happened when click the add button
        {
            try
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int sum = num1 + num2;
                MessageBox.Show("sum : " + sum.ToString(), "Results"); //create msg box and content of the mesg box result head of the msg box 

            }catch(FormatException)
            {
                MessageBox.Show("Please Enter the Valid Number");
            }
        }
    }
}

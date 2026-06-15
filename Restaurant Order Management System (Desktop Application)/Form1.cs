using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        int x = 0;
        int y = 0;
        int total  = 0;
        int total1 = 0;
        String Address = "Ma'an";
        String Order = "Takeaway";


        public Form1()
        {
            InitializeComponent();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label14.Text = "Welcome ";
            label14.Text += textBox1.Text;
            label5.Text = "$ " + x.ToString();
            label7.Text = "$ " + y.ToString();
            label9.Text=(x+y).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            label5.Text = "";
            label7.Text = "";
            label9.Text = "";
            if (checkBox1.Checked)
                checkBox1.Checked = false;
            if (checkBox2.Checked)
                checkBox2.Checked = false;
            if (checkBox3.Checked)
                checkBox3.Checked = false;
            if (checkBox4.Checked)
                checkBox4.Checked = false;
            if (checkBox5.Checked)
                checkBox5.Checked = false;
            if (checkBox6.Checked)
                checkBox6.Checked = false;
            if (checkBox7.Checked)
                checkBox7.Checked = false;
            x = 0;
            y = 0;
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
             textBox5.Text = "1";
            
            x += (10 * Convert.ToInt32(textBox5.Text));
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
                textBox6.Text = "1";
            x += (5 * Convert.ToInt32(textBox6.Text));
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
                textBox7.Text = "1";
            x += (8 * Convert.ToInt32(textBox7.Text));
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
                textBox8.Text = "1";
            x += (2 * Convert.ToInt32(textBox8.Text));
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
                textBox9.Text = "1";
            y += (1 * Convert.ToInt32(textBox9.Text));
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
                textBox10.Text = "1";
            y += (1 * Convert.ToInt32(textBox10.Text));
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox11.Text == "")
                textBox11.Text = "1";
            y += (1 * Convert.ToInt32(textBox11.Text));
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult z;
           z= MessageBox.Show("Order confirmation", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (z.ToString() == "OK")
            {


                MessageBox.Show("Name :" + textBox1.Text + "\nphone :" + textBox4.Text + "\nThe Address :" + Address + "\nOrder Type :" + Order, "The order was taken", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label5.Text = "";
                label7.Text = "";
                label9.Text = "";
                total = x + y;
                total1= Convert.ToInt32(label10.Text);
                label10.Text =(total + total1).ToString();
                if (checkBox1.Checked)
                    checkBox1.Checked = false;
                if (checkBox2.Checked)
                    checkBox2.Checked = false;
                if (checkBox3.Checked)
                    checkBox3.Checked = false;
                if (checkBox4.Checked)
                    checkBox4.Checked = false;
                if (checkBox5.Checked)
                    checkBox5.Checked = false;
                if (checkBox6.Checked)
                    checkBox6.Checked = false;
                if (checkBox7.Checked)
                    checkBox7.Checked = false;
                x = 0;
                y = 0;
                label14.Text = "";
                textBox1.Text = "";
                textBox4.Text = "";
               if(radioButton2.Checked)
                    radioButton2.Checked = false;
               if(radioButton1.Checked)
                    radioButton1.Checked = false;
               if(radioButton6.Checked)
                    radioButton6.Checked = false;
               if(radioButton7.Checked)
                    radioButton7.Checked = false;
               if(radioButton8.Checked)
                    radioButton8.Checked = false;
                if(radioButton3.Checked)
                    radioButton3.Checked = false;
                if(radioButton4.Checked)
                    radioButton4.Checked = false;
                if(radioButton5.Checked)
                    radioButton5.Checked = false;
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";






            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
          
        }

        private void label10_Click(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Address = "Amman";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult x;
            x=MessageBox.Show("Are you sure you want to exit", "Exit Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (x.ToString() == "OK")
                Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (textBox4.PasswordChar == '\0')
            { 
            textBox4.PasswordChar = '*';
                pictureBox14.Image = Image.FromFile("eye password icon.jpg");
            }
            else
            {
                textBox4.PasswordChar = '\0';
                pictureBox14.Image = Image.FromFile("eye icon.png");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.MaxLength = 10;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Address = "Zarqa";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Address = "Irbid";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            Address = "Ma'an";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            Address = "Jerash";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Order = "Takeaway";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Order = "Dine-in";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Order = "Delivery";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult k;
           k= MessageBox.Show("Are you sure you want to reset today's income?", "Reset Income",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (k.ToString() == "Yes")
            {
                label10.Text = "0";
                label5.Text = "";
                label7.Text = "";
                label9.Text = "";
                if (checkBox1.Checked)
                    checkBox1.Checked = false;
                if (checkBox2.Checked)
                    checkBox2.Checked = false;
                if (checkBox3.Checked)
                    checkBox3.Checked = false;
                if (checkBox4.Checked)
                    checkBox4.Checked = false;
                if (checkBox5.Checked)
                    checkBox5.Checked = false;
                if (checkBox6.Checked)
                    checkBox6.Checked = false;
                if (checkBox7.Checked)
                    checkBox7.Checked = false;
                x = 0;
                y = 0;
                label14.Text = "";
                textBox1.Text = "";
                textBox4.Text = "";
                if (radioButton2.Checked)
                    radioButton2.Checked = false;
                if (radioButton1.Checked)
                    radioButton1.Checked = false;
                if (radioButton6.Checked)
                    radioButton6.Checked = false;
                if (radioButton7.Checked)
                    radioButton7.Checked = false;
                if (radioButton8.Checked)
                    radioButton8.Checked = false;
                if (radioButton3.Checked)
                    radioButton3.Checked = false;
                if (radioButton4.Checked)
                    radioButton4.Checked = false;
                if (radioButton5.Checked)
                    radioButton5.Checked = false;
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                MessageBox.Show("Income has been reset successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

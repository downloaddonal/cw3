using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SocialMediaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //here is where i keep variables
        class Variables
        {
            public static string strPath = "";
            public static string strimgPath = "";
        }

        // function here to remove duplicated code in the text boxes below
        public void CompleteForm(string strPath, string strimgPath)
        {
            // builds array with text file and sets image
            try
            {
                //build form
                string[] lines = System.IO.File.ReadAllLines(Variables.strPath);
                textBox1.Text = lines[0];
                textBox2.Text = lines[1];
                textBox3.Text = lines[2];
                textBox4.Text = lines[3];
                textBox5.Text = lines[4];
                textBox6.Text = lines[5];
                textBox7.Text = lines[6];
                // do image
                pictureBox1.Image = Image.FromFile(Variables.strimgPath);
            }

            catch (FileNotFoundException fileex)
            {
                MessageBox.Show(fileex.Message + "unable to display file please reinstall");
            }

            catch (IndexOutOfRangeException index)
            {
                //displaying nothing rather than incomplete
                MessageBox.Show(index.Message);
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;
                textBox5.Text = null;
                textBox6.Text = null;
                textBox7.Text = null;
                pictureBox1.Image = null;
            }

            //catch (UnauthorizedAccessException authex)
            //{
            //    MessageBox.Show(authex.Message);
            //}

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // three buttons calling the function above to complete the form
        private void button1_Click(object sender, EventArgs e)
        {
            Variables.strPath = @"C:\Users\Donald\Desktop\tech\programming two\trump.txt";
            Variables.strimgPath = @"C:\Users\Donald\Desktop\tech\programming two\trump.jpg";
            CompleteForm(Variables.strPath, Variables.strimgPath);
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            Variables.strPath = @"C:\Users\Donald\Desktop\tech\programming two\obama.txt";
            Variables.strimgPath = @"C:\Users\Donald\Desktop\tech\programming two\obama.jpg";
            CompleteForm(Variables.strPath, Variables.strimgPath);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Variables.strPath = @"C:\Users\Donald\Desktop\tech\programming two\cat.txt";
            Variables.strimgPath = @"C:\Users\Donald\Desktop\tech\programming two\cat.jpg";
            CompleteForm(Variables.strPath, Variables.strimgPath);
        }

        // this button is the confirm exit button

        private void button4_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Confirm exit!", "Exit", MessageBoxButtons.YesNo);

            // confirmation of close IF yes close ELSE messagebox closes
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                //do nothing, text box closes and no changes made
            }
        }
    }
}

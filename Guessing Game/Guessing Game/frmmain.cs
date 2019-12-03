using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Guessing_Game
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }
        public static int binary_serch(int result,int[] arr,int low,int high)
        {
            if (low > high)
            {
                return -1;
            }
            int mid = (low + high) / 2;
            if (result == arr[mid])
            {
                return mid;
            }
            if (result < arr[mid])
            {
                return binary_serch(result, arr, low, mid - 1);
            }
            else
            {
                return binary_serch(result, arr, mid + 1, high);
            }
            
        }
        public void guess(int x)
        {
            int low = 1;
            int high = 100;
            int response;
            do
            {
                int guess = (high + low) / 2;
                lbmyguess.Text = Convert.ToString(guess);
                response = x;
                switch (response)
                {
                    case 1:
                        high = guess - 1;
                        break;
                    case 2:
                        low = guess + 1;
                        break;
                    case 3:
                        //Console.WriteLine("thaxs to uing");
                        lbmsg.Text = "Yes! I Knew I Could do it.";
                        break;
                    default:
                        lbmsg.Text = "I didn't get that, you gave an invalid response";
                        lbresult.Text = "Please try again";
                        break;
                }
            } while (response != 3);
        }
        private void frmmain_Load(object sender, EventArgs e)
        {
            if (panelfirst.Visible == true)
            {
                AcceptButton = btnstart;
                CancelButton = btnexit;
            }
            lbusername.Text = "";
            if (btnplay.Enabled == true)
            {
                btnplayagain.Enabled = false;
                lbmsg.Text = "Please click to button PLAY";
            }
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("Please enter your name to start game", "Enter your name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtname.Focus();
            }
            else
            {
                panelfirst.Visible = false;
                lbusername.Text = txtname.Text.ToUpper();
                
            }
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            int userclick;
            //int[] arr = new int[100];
            //binary_serch(8, arr, 0, 100);
            userclick = 1;
            if (userclick == 1)
            {
                btnplay.Enabled = false;
                btnplayagain.Enabled = true;
                lbmsg.Text = "Your Click To Button";
            }
            int a = 1;
            guess(a);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnplayagain_Click(object sender, EventArgs e)
        {
            int userclick;
            userclick = 1;
            if (userclick == 1)
            {
                panelfirst.Visible = true;
                txtname.Text = "";
                txtname.Focus();
                lbusername.Text = "";
                btnplay.Enabled = true;
                btnplayagain.Enabled = false;
                lbmsg.Text = "Please click to button PLAY";
            }
        }

        private void btntoolow_Click(object sender, EventArgs e)
        {
            //int[] arr = new int[100];
            //binary_serch(2,arr,0,100);
            int a = 2;
            guess(a);
        }

        private void btnright_Click(object sender, EventArgs e)
        {

            //int[] arr = new int[100];
            //binary_serch(2, arr, 0, 100);
            int a = 3;
            guess(a);
        }

        private void btntoohogh_Click(object sender, EventArgs e)
        {

            //int[] arr = new int[100];
            //binary_serch(2, arr, 0, 100);
            int a = 1;
            guess(a);
        }

        private void panelfirst_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

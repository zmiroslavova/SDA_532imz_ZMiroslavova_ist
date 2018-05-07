using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA_532imz_ZMiroslavova_ist
{
    public partial class Palindrome : Form
    {
        public Palindrome()
        {
            InitializeComponent();
        }

        private void button_Result_Click(object sender, EventArgs e)
        {
            int inputNumber = int.Parse(textBox_inputNimber.Text);
            int sum = inputNumber + reverseNumber(inputNumber);

            string output = "";
            if (isPalindrome(sum))
            {
                output = "Sum of" + inputNumber + " and his reverse number is " + sum + " and it is palindrome";
            }
            else
            {
                while (sum < 1000000)
                {
                    sum = sum + reverseNumber(sum);
                    if (isPalindrome(sum))
                    {
                        output = "The final sum of " + inputNumber + " and his reverse numbers is " + sum + 
                            " and it is palindrome";
                        break;
                    }
                    else
                    {
                        output = inputNumber + " is special number";
                    }
                }

            }
            this.richTextBox_Result.Text = output;
        }
        
        public int reverseNumber(int inputNumber)
        {
            int left = inputNumber;
            int revNumber = 0;

            while(left>0)
            {
                int r = left % 10;
                revNumber = revNumber * 10 + r;
                left = left / 10;
            }
            return revNumber;
        }

        private Boolean isPalindrome(int number)
        {
            Boolean isPalindrome = false;
            char[] num = number.ToString().ToCharArray();
            char[] reversed = number.ToString().ToCharArray();
            Array.Reverse(reversed);

            String numberString = new String(num);
            String reversedNumber = new String(reversed);
            
            if (numberString == reversedNumber)
                
                isPalindrome = true;
            return isPalindrome;
        }

        private void button_Clear_Click(object sender, EventArgs e) => clear();
       
        void clear()
        {
            textBox_inputNimber.Clear();
            richTextBox_Result.Clear();

            textBox_inputNimber.Focus();
        }

        
    }
}

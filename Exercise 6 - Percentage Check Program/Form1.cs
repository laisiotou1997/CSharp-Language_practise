/*
;|**********************************************************************;
;* Project           : Basic_CSharp
;*
;* Program name      : Form1.cs
;*
;* Author            : SIO TOU LAI (laisiotou1997@gmail.com)
;*
;* Date created      : 14/03/2019
;*
;* Version           : Internal
;*
;* Copyright         : GNU GENERAL PUBLIC LICENSE Version 3
;*
;* Purpose           : Exercise 6 - Percentage Check Program_BHI
;*
;* Revision History  :
;*
;* Date        Author      Ref    Revision (Date in DDMMYYYY format)
;* 14032019    lst97       1      First release
;*
;* Known Issue       :
;*
;|**********************************************************************;
*/

/*S10000399*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Exercise_6___Percentage_Check_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float floatBuffer;
        private void buttonMouth_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxMouth.Text, out floatBuffer))
            {
                // Good Condition
                if (floatBuffer.ToString("0.") == textBoxMouth.Text)    // check float is int
                {
                    // User enter int [BAD]
                    MessageBox.Show("You must enter a floating point number!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxMouth.Text = "";
                    textBoxMouth.Focus();
                    labelReserve.Text = "ERROR - Not float number!";
                    labelReserve.ForeColor = Color.Red;
                }
                else
                {
                    // [GOOD]
                    if (floatBuffer >= 0 && floatBuffer <= 100)     // 0-100
                    {
                        labelMouth.Text = floatBuffer.ToString();
                        buttonMouth.Enabled = false;
                        labelReserve.Text = "PASS - Vote image #1 SUCCESS!";
                        labelReserve.ForeColor = Color.Green;
                    }
                    else
                    {
                        MessageBox.Show("Number must between 0 ~ 100", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxMouth.Text = "";
                        textBoxMouth.Focus();
                        labelReserve.Text = "ERROR - Number Large / Small";
                        labelReserve.ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a number!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxMouth.Text = "";
                textBoxMouth.Focus();
                labelReserve.Text = "ERROR - Invalid input!";
                labelReserve.ForeColor = Color.Red;
            }
        }

        private void buttonEyes_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxEyes.Text, out floatBuffer))
            {
                // Good Condition
                if (floatBuffer.ToString("0.") == textBoxEyes.Text)    // check float if it's int
                {
                    // User enter int [BAD]
                    MessageBox.Show("You must enter a floating point number!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxEyes.Text = "";
                    textBoxEyes.Focus();
                    labelReserve.Text = "ERROR - Not float number!";
                    labelReserve.ForeColor = Color.Red;
                }
                else
                {
                    // [GOOD]
                    if (floatBuffer >= 0 && floatBuffer <= 100)     // check within 0 - 100
                    {
                        // 0 - 100 [GOOD]
                        labelEyes.Text = floatBuffer.ToString();
                        buttonEyes.Enabled = false;
                        labelReserve.Text = "PASS - Vote image #2 SUCCESS!";
                        labelReserve.ForeColor = Color.Green;
                    }
                    else
                    {
                        // 0 - 100 [BAD]
                        MessageBox.Show("Number must between 0 ~ 100", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxEyes.Text = "";
                        textBoxEyes.Focus();
                        labelReserve.Text = "ERROR - Number Large / Small";
                        labelReserve.ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a number!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEyes.Text = "";
                textBoxEyes.Focus();
                labelReserve.Text = "ERROR - Invalid input!";
                labelReserve.ForeColor = Color.Red;
            }
        }

        private void buttonEars_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxEars.Text, out floatBuffer))
            {
                // Good Condition
                if (floatBuffer.ToString("0.") == textBoxEars.Text)    // check float is int
                {
                    // User enter int [BAD]
                    MessageBox.Show("You must enter a floating point number!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxEars.Text = "";
                    textBoxEars.Focus();
                    labelReserve.Text = "ERROR - Not float number!";
                    labelReserve.ForeColor = Color.Red;
                }
                else
                {
                    // [GOOD]
                    if (floatBuffer >= 0 && floatBuffer <= 100)     // 0-100
                    {
                        labelEars.Text = floatBuffer.ToString();
                        buttonEars.Enabled = false;
                        labelReserve.Text = "PASS - Vote image #3 SUCCESS!";
                        labelReserve.ForeColor = Color.Green;
                    }
                    else
                    {
                        MessageBox.Show("Number must between 0 ~ 100", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxEars.Text = "";
                        textBoxEars.Focus();
                        labelReserve.Text = "ERROR - Number Large / Small";
                        labelReserve.ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a number!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEars.Text = "";
                textBoxEars.Focus();
                labelReserve.Text = "ERROR - Invalid input!";
                labelReserve.ForeColor = Color.Red;
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Project\t\t: Basic_CSharp\n\nProgram\t\t: Form1.cs\n\nAuthor\t\t: SIO TOU LAI (laisiotou1997@gmail.com)\n\nDate created\t: 14/03/2019\n\nVersion\t\t: Internal\n\nCopyright\t\t: GNU GENERAL PUBLIC LICENSE Version 3\n\nPurpose\t\t: Exercise 6 - Percentage Check Program_BHI\n\nRevision History\t:\nDate\t\tAuthor\tRef\tRevision\n14032019\tlst97\t1\tFirst release\n\nKnow issue\t:\n", "ABOUT");
        }
    }
}

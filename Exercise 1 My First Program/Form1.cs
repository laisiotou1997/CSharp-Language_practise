/*
;|**********************************************************************;
;* Project           : Basic_CSharp
;*
;* Program name      : Basic.cs
;*
;* Author            : SIO TOU LAI (laisiotou1997@gmail.com)
;*
;* Date created      : 21/02/2019
;*
;* Version           : Internal
;*
;* Copyright         : GNU GENERAL PUBLIC LICENSE Version 3
;*
;* Purpose           : HelloWorld_BHI
;*
;* Revision History  :
;*
;* Date        Author      Ref    Revision (Date in DDMMYYYY format)
;* 21022019    lst97       1      First release
;*
;* Known Issue       :
;*
;|**********************************************************************;
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_1_My_First_Program_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Project\t\t: Basic_CSharp\n\nProgram\t\t: Basic.cs\n\nAuthor\t\t: SIO TOU LAI (laisiotou1997@gmail.com)\n\nDate created\t: 21/02/2019\n\nVersion\t\t: Internal\n\nCopyright\t\t: GNU GENERAL PUBLIC LICENSE Version 3\n\nPurpose\t\t: HelloWorld_BHI\n\nRevision History  :\nDate\tAuthor\tRef\tRevision (Date in DDMMYYYY format)\n21022019\tlst97\t1\tFirst release", "ABOUT");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxGName.Text == "" || textBoxFName.Text == "" )
            {
                MessageBox.Show("Invaild Input!", "Error");
            }
            else{
                MessageBox.Show("Welcome: \"" + textBoxGName.Text + " " + textBoxFName.Text + "\"", "Message");
                labelMShow.Text = (textBoxGName.Text + " " + textBoxFName.Text);
            }
            
        }
    }
}

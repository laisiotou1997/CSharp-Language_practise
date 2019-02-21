/*
;|**********************************************************************;
;* Project           : Basic_CSharp
;*
;* Program name      : Form1.cs
;*
;* Author            : SIO TOU LAI (laisiotou1997@gmail.com)
;*
;* Date created      : 21/02/2019
;*
;* Version           : Internal
;*
;* Copyright         : GNU GENERAL PUBLIC LICENSE Version 3
;*
;* Purpose           : Exercise 2 - Checkboxes_BHI
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

namespace Exercise_2___Checkboxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e){
            //Check order first before font
            if (checkBoxFires.Checked == true) {
                if (checkBoxUpsize.Checked == true) {
                    MessageBox.Show("User choose: \"Fires\" and \"Upsize\"", "Message");
                    labelMessage.Text = "User choose: \"Fires\" and \"Upsize\"";
                }
                else{
                    MessageBox.Show("User choose: \"Fires\"", "Message");
                    labelMessage.Text = "User choose: \"Fires\"";
                }
            }else if (checkBoxUpsize.Checked == true) {
                MessageBox.Show("User choose: \"Upsize\"", "Message");
                labelMessage.Text = "User choose: \"Upsize\"";
            }
            else {
                    MessageBox.Show("NOTHING Checked !", "ERROR");
                    labelMessage.Text = "User choose: \"NOTHING !\"";
            }

            //Font section
            if (checkBoxBHeading.Checked == true) {
                labelMessage.Font = new Font(labelMessage.Font, FontStyle.Bold);
            }
            else {
                labelMessage.Font = new Font(labelMessage.Font, FontStyle.Regular);
            }
            if (checkBoxCHeading.Checked == true) {
                labelMessage.ForeColor = Color.Green;
            }
            else {
                labelMessage.ForeColor = Color.Black;
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Project\t\t: Basic_CSharp\n\nProgram\t\t: Form1.cs\n\nAuthor\t\t: SIO TOU LAI (laisiotou1997@gmail.com)\n\nDate created\t: 21/02/2019\n\nVersion\t\t: Internal\n\nCopyright\t\t: GNU GENERAL PUBLIC LICENSE Version 3\n\nPurpose\t\t: Exercise 2 - Checkboxes_BHI\n\nRevision History\t:\nDate\tAuthor\tRef\tRevision (Date in DDMMYYYY format)\n21022019\tlst97\t1\tFirst release", "ABOUT");
        }
    }
}

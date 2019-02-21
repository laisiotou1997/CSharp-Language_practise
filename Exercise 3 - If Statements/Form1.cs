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
;* Purpose           : Exercise 3 - If Statements
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

namespace Exercise_3___If_Statements
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

        //Check logic
        private void buttonEnter_Click(object sender, EventArgs e){
            if (checkBoxFires.Checked == true){
                if (checkBoxUpsize.Checked == true){
                    MessageBox.Show("User choose: \"Fires\" and \"Upsize\"", "Message");
                    labelMessage.Text = "\"Fires\" and \"Upsize\" by NELSON LAI s10000399";
                }
                else{
                    MessageBox.Show("User choose: \"Fires\"", "Message");
                    labelMessage.Text = "\"Fires\" by NELSON LAI s10000399";
                }
            }else if (checkBoxUpsize.Checked == true){
                MessageBox.Show("User choose: \"Upsize\"", "Message");
                labelMessage.Text = "\"Upsize\" by NELSON LAI s10000399";
            }else{
                MessageBox.Show("NOTHING Checked !", "ERROR");
                labelMessage.Text = "\"NOTHING !\"";
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e){
            MessageBox.Show("Project\t\t: Basic_CSharp\n\nProgram\t\t: Form1.cs\n\nAuthor\t\t: SIO TOU LAI (laisiotou1997@gmail.com)\n\nDate created\t: 21/02/2019\n\nVersion\t\t: Internal\n\nCopyright\t\t: GNU GENERAL PUBLIC LICENSE Version 3\n\nPurpose\t\t: Exercise 3 - If Statements\n\nRevision History\t:\nDate\tAuthor\tRef\tRevision (Date in DDMMYYYY format)\n21022019\tlst97\t1\tFirst release", "ABOUT");
        }
    }
}

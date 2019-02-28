/*
;|**********************************************************************;
;* Project           : Basic_CSharp
;*
;* Program name      : Form1.cs
;*
;* Author            : SIO TOU LAI (laisiotou1997@gmail.com)
;*
;* Date created      : 28/02/2019
;*
;* Version           : Internal
;*
;* Copyright         : GNU GENERAL PUBLIC LICENSE Version 3
;*
;* Purpose           : Assessment 2
;*
;* Revision History  :
;*
;* Date        Author      Ref    Revision (Date in DDMMYYYY format)
;* 28022019    lst97       1      First release
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

namespace Assessment_Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Project\t\t: Basic_CSharp\n\nProgram\t\t: Form1.cs\n\nAuthor\t\t: SIO TOU LAI (laisiotou1997@gmail.com)\n\nDate created\t: 28/02/2019\n\nVersion\t\t: Internal\n\nCopyright\t\t: GNU GENERAL PUBLIC LICENSE Version 3\n\nPurpose\t\t: Assessment 2\n\nRevision History\t:\nDate\tAuthor\tRef\tRevision (Date in DDMMYYYY format)\n28022019\tlst97\t1\tFirst release", "ABOUT");
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (radioButtonTakeAway.Checked == true || radioButtonHomeD.Checked == true)
            {
                //Reset color if Red before.
                labelOrderedFood.ForeColor = Color.Black;
                //Take-Away checked.
                if (radioButtonSalami.Checked == true && radioButtonTakeAway.Checked == true)
                {
                    labelOrderedFood.Text = "Salami";
                    MessageBox.Show("You picked\t: Salami\nOption\t\t: TakeAway", "Message");
                }
                else if (radioButtonChicken.Checked == true && radioButtonTakeAway.Checked == true)
                {
                    labelOrderedFood.Text = "Chicken";
                    MessageBox.Show("You picked\t: Chicken\nOption\t\t: TakeAway", "Message");
                }
                else if (radioButtonPrawns.Checked == true && radioButtonTakeAway.Checked == true)
                {
                    labelOrderedFood.Text = "Prawns";
                    MessageBox.Show("You picked\t: Prawns\nOption\t\t: TakeAway", "Message");
                }
                else if (radioButtonBeef.Checked == true && radioButtonTakeAway.Checked == true)
                {
                    labelOrderedFood.Text = "Beef";
                    MessageBox.Show("You picked\t: Beef\nOption\t\t: TakeAway", "Message");
                }
                else if(radioButtonAnchovies.Checked == true && radioButtonTakeAway.Checked == true)
                {
                    labelOrderedFood.Text = "Anchovies";
                    MessageBox.Show("You picked\t: Anchovies\nOption\t\t: TakeAway", "Message");
                }

                //HomeD checked;
                else if (radioButtonSalami.Checked == true && radioButtonHomeD.Checked == true)
                {
                    labelOrderedFood.Text = "Salami";
                    MessageBox.Show("You picked\t: Salami\nOption\t\t: TakeAway", "Message");
                }
                else if (radioButtonChicken.Checked == true && radioButtonHomeD.Checked == true)
                {
                    labelOrderedFood.Text = "Chicken";
                    MessageBox.Show("You picked\t: Chicken\nOption\t\t: Home Delivery", "Message");
                }
                else if (radioButtonPrawns.Checked == true && radioButtonHomeD.Checked == true)
                {
                    labelOrderedFood.Text = "Prawns";
                    MessageBox.Show("You picked\t: Prawns\nOption\t\t: Home Delivery", "Message");
                }
                else if (radioButtonBeef.Checked == true && radioButtonHomeD.Checked == true)
                {
                    labelOrderedFood.Text = "Beef";
                    MessageBox.Show("You picked\t: Beef\nOption\t\t: Home Delivery", "Message");
                }
                else if (radioButtonAnchovies.Checked == true && radioButtonHomeD.Checked == true)
                {
                    labelOrderedFood.Text = "Anchovies";
                    MessageBox.Show("You picked\t: Anchovies\nOption\t\t: Home Delivery", "Message");
                }
            }
            //Option not checked. - ERROR
            else
            {
                MessageBox.Show("Please pick one option!","Error");
                labelOrderedFood.Text = "ERROR!";
                labelOrderedFood.ForeColor = Color.Red;
            }
        }
    }
}

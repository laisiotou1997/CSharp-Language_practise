/*
;|**********************************************************************;
;* Project           : Basic_CSharp
;*
;* Program name      : Form1.cs
;*
;* Author            : SIO TOU LAI (laisiotou1997@gmail.com)
;*
;* Date created      : 08/03/2019
;*
;* Version           : Internal
;*
;* Copyright         : GNU GENERAL PUBLIC LICENSE Version 3
;*
;* Purpose           : Exercise 5 – Intro to variable_BHI
;*
;* Revision History  :
;*
;* Date        Author      Ref    Revision (Date in DDMMYYYY format)
;* 08032019    lst97       1      First release
;*
;* Known Issue       :
;* Display problem when if messageBox string is too long.
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

namespace Exercise_5___Variable
{
    public partial class Form1 : Form
    {
        //DATA
        static string strChoosePizzaBase;
        static string strChooseSauces;
        static string strChooseDeliveryType;

        static string strChooseMeatChicken;
        static string strChooseMeatSalami;
        static string strChooseMeatHotSalami;
        static string strChooseMeatMince;
        static string strChooseMeatPrawn;
        static string strChooseMeatAnchovies;
        static string strChooseMeatTuna;

        // CODE
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // uncheck radioButton
            radioButtonDeepPan.Checked = true;
            radioButtonDeepPan.Checked = false;
        }

        // Submite button event
        private void buttonSubmite_Click(object sender, EventArgs e)
        {
            // Checking Textbox Information Algorisum
            if (textBoxName.Text == "" || textBoxPhone.Text == "" || textBoxAddress.Text == "")
            {
                MessageBox.Show("You havn't fill all the information yet!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelReserve.Text = "ERROR - Empty Information/s!";
                labelReserve.ForeColor = Color.Red;
                goto END;
            }
            else
            {
                byte[] charByte;
                charByte = Encoding.ASCII.GetBytes(textBoxName.Text);
                for (int loopCounter = 0; loopCounter < textBoxName.Text.Length; loopCounter++)
                {
                    // Using ascii code [Name]
                    if (charByte[loopCounter] <= 0x19 || (charByte[loopCounter] <= 0x40 && charByte[loopCounter] >= 0x21) || (charByte[loopCounter] >= 0x5B && charByte[loopCounter] <= 0x60) || (charByte[loopCounter] <= 0x7B && charByte[loopCounter] >= 0x7F))
                    {
                        // Bad input [Name]
                        MessageBox.Show("Invalide Input", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxName.Text = "";
                        textBoxName.Focus();
                        labelReserve.Text = "ERROR - Invalide Name!";
                        labelReserve.ForeColor = Color.Red;
                        goto END;
                    }
                }

                charByte = Encoding.ASCII.GetBytes(textBoxPhone.Text);
                for (int loopCounter = 0; loopCounter < textBoxPhone.Text.Length; loopCounter++)
                {
                    // Must be 11 number
                    if ((charByte[loopCounter] >= 0x30 && charByte[loopCounter] <= 0x39) && textBoxPhone.Text.Length == 11)
                    {
                        // Good input [Phone]
                    }
                    else
                    {
                        MessageBox.Show("Invalide Input", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxPhone.Text = "";
                        textBoxPhone.Focus();
                        labelReserve.Text = "ERROR - Invalide Phone!";
                        labelReserve.ForeColor = Color.Red;
                        goto END;
                    }
                }

                charByte = Encoding.ASCII.GetBytes(textBoxAddress.Text);
                for (int loopCounter = 0; loopCounter < textBoxAddress.Text.Length; loopCounter++)
                {
                    if ((charByte[loopCounter] >= 0x30 && charByte[loopCounter] <= 0x39) || (charByte[loopCounter] >= 0x41 && charByte[loopCounter] <= 0x5A) || (charByte[loopCounter] >= 0x61 && charByte[loopCounter] <= 0x7A) || charByte[loopCounter] == 0x2C || charByte[loopCounter] == 0x20)
                    {
                        // Good Input [Address]

                    }
                    else
                    {
                        MessageBox.Show("Invalide Input", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxAddress.Text = "";
                        textBoxAddress.Focus();
                        labelReserve.Text = "ERROR - Invalide Address!";
                        labelReserve.ForeColor = Color.Red;
                        goto END;
                    }
                }
            }// END Checking Textbox Information Algorisum

            // Checking RadioButton Information Algorisum
            if (radioButtonDeepPan.Checked == true || radioButtonTraditionalCrust.Checked == true || radioButtonCrispyCrust.Checked == true)
            {
                // Pass [PizzaBase Group]
            }
            else
            {
                MessageBox.Show("You havn't select base!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelReserve.Text = "ERROR - Empty Pizza Base!";
                labelReserve.ForeColor = Color.Red;
                goto END;
            }

            if (radioButtonBBQSauce.Checked == true || radioButtonChilliSauce.Checked == true || radioButtonTomato.Checked == true || radioButtonGarlicSauce.Checked == true)
            {
                // Pass [Sauces Group]
            }
            else
            {
                MessageBox.Show("You havn't select Sauces!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelReserve.Text = "ERROR - Empty Sauces!";
                labelReserve.ForeColor = Color.Red;
                goto END;
            }

            if (radioButtonDelivered.Checked == true || radioButtonPickup.Checked == true)
            {
                // Pass [Delievery Type Group]
            }
            else
            {
                MessageBox.Show("You havn't select Delivery type!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelReserve.Text = "ERROR - Empty Delivery Type!";
                labelReserve.ForeColor = Color.Red;
                goto END;
            }

            // Checking checkBox Information Algorisum
            string strMeatOrder;
            strMeatOrder = (strChooseMeatChicken + strChooseMeatSalami + strChooseMeatHotSalami + strChooseMeatMince + strChooseMeatPrawn + strChooseMeatAnchovies + strChooseMeatTuna);
            if (strMeatOrder == "")
            {
                // Fail [Meat]
                MessageBox.Show("Please select at less one type of meat!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelReserve.Text = "ERROR - Empty Meat!";
                labelReserve.ForeColor = Color.Red;
                goto END;
            }

            // Submite messageBox
            DialogResult diaResult;
            string subOutput = "Click YES to SENT your order!\n" + "\nPizza Base\t: " + strChoosePizzaBase + "\nSauces\t\t: " + strChooseSauces + "\nMeat\t\t: " + strMeatOrder + "\n\nDelivery Type\t: " + strChooseDeliveryType + "\n\nCustomer Name\t: " + textBoxName.Text + "\nPhone\t\t: " + textBoxPhone.Text + "\nAddress\t\t: " + textBoxAddress.Text;
            diaResult = MessageBox.Show(subOutput, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (diaResult == DialogResult.Yes)
            {
                MessageBox.Show("Order SEND!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelReserve.Text = "Order SEND successfully!";
                labelReserve.ForeColor = Color.Green;
                buttonSubmite.Enabled = false;
            }
        END:;
        }

        // RadioButton event
        private void radioButtonTraditionalCrust_CheckedChanged(object sender, EventArgs e)
        {
            strChoosePizzaBase = radioButtonTraditionalCrust.Text;
        }

        private void radioButtonDeepPan_CheckedChanged(object sender, EventArgs e)
        {
            strChoosePizzaBase = radioButtonDeepPan.Text;
        }

        private void radioButtonCrispyCrust_CheckedChanged(object sender, EventArgs e)
        {
            strChoosePizzaBase = radioButtonCrispyCrust.Text;
        }

        private void radioButtonBBQSauce_CheckedChanged(object sender, EventArgs e)
        {
            strChooseSauces = radioButtonBBQSauce.Text;
        }

        private void radioButtonChilliSauce_CheckedChanged(object sender, EventArgs e)
        {
            strChooseSauces = radioButtonChilliSauce.Text;
        }

        private void radioButtonTomato_CheckedChanged(object sender, EventArgs e)
        {
            strChooseSauces = radioButtonTomato.Text;
        }

        private void radioButtonGarlicSauce_CheckedChanged(object sender, EventArgs e)
        {
            strChooseSauces = radioButtonGarlicSauce.Text;
        }

        private void radioButtonDelivered_CheckedChanged(object sender, EventArgs e)
        {
            strChooseDeliveryType = radioButtonDelivered.Text;
        }

        private void radioButtonPickup_CheckedChanged(object sender, EventArgs e)
        {
            strChooseDeliveryType = radioButtonPickup.Text;
        }
       
        // Checkbox event
        private void checkBoxChicken_CheckedChanged(object sender, EventArgs e)
        {
            strChooseMeatChicken = checkBoxChicken.Checked == true ? "Chicken, " : "";
        }

        private void checkBoxSalami_CheckedChanged(object sender, EventArgs e)
        {
            strChooseMeatSalami = checkBoxSalami.Checked == true ? "Salami, " : "";
        }

        private void checkBoxHotSalami_CheckedChanged(object sender, EventArgs e)
        {
            strChooseMeatHotSalami = checkBoxHotSalami.Checked == true ? "Hot Salami, " : "";
        }

        private void checkBoxMince_CheckedChanged(object sender, EventArgs e)
        {
            strChooseMeatMince = checkBoxMince.Checked == true ? "Mince, " : "";
        }

        private void checkBoxPrawn_CheckedChanged(object sender, EventArgs e)
        {
            strChooseMeatPrawn = checkBoxPrawn.Checked == true ? "Prawn, " : "";
        }

        private void checkBoxAnchovise_CheckedChanged(object sender, EventArgs e)
        {
            strChooseMeatAnchovies = checkBoxAnchovise.Checked == true ? "Anchovies, " : "";
        }

        private void checkBoxTuna_CheckedChanged(object sender, EventArgs e)
        {
            strChooseMeatTuna = checkBoxTuna.Checked == true ? "Tuna, " : "";
        }

        // ABOUT
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Project\t\t: Basic_CSharp\n\nProgram\t\t: Form1.cs\n\nAuthor\t\t: SIO TOU LAI (laisiotou1997@gmail.com)\n\nDate created\t: 08/03/2019\n\nVersion\t\t: Internal\n\nCopyright\t: GNU GENERAL PUBLIC LICENSE Version 3\n\nPurpose\t\t: Exercise 5 - Intro to variable_BHI\n\nRevision History\t:\nDate\t\tAuthor\tRef\tRevision\n08032019\tlst97\t1\tFirst release\n\nKnow issue\t:\n1. Display problem when if messageBox string is too long.", "About");
        }
    }
}

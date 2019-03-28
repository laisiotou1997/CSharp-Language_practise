/*
;|**********************************************************************;
;* Project           : Basic_CSharp
;*
;* Program name      : Form1.cs
;*
;* Author            : SIO TOU LAI (laisiotou1997@gmail.com)
;*
;* Date created      : 28/03/2019
;*
;* Version           : Internal
;*
;* Copyright         : GNU GENERAL PUBLIC LICENSE Version 3
;*
;* Purpose           : Exercise 8 on Loops_BHI
;*
;* Revision History  :
;*
;* Date        Author      Ref    Revision (Date in DDMMYYYY format)
;* 28032019    lst97       1      First release
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

namespace Loops_practice_problems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            buttonDo.Enabled = false;
            buttonFor.Enabled = false;
            buttonWhile.Enabled = false;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            // DATA
            Random rnd = new Random();

            // CODE

            for (byte loopCounter = 1; loopCounter <= 50; loopCounter++)
            {
                int intRnd = rnd.Next(1, 11);
                listBox.Items.Add(intRnd);
            }
            buttonDo.Enabled = true;
            buttonFor.Enabled = true;
            buttonWhile.Enabled = true;
        }

        private void buttonItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There are \"" + listBox.Items.Count.ToString() + "\" item/s in the list box.", "Form1 - MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDo_Click(object sender, EventArgs e)
        {
            int loopCounterDo = 1;
            do
            {
                MessageBox.Show("Value of item [" + loopCounterDo + "] : \"" + listBox.Items[loopCounterDo -1].ToString() + "\"", "Form1 - MESSAGE",MessageBoxButtons.OK, MessageBoxIcon.Information);
                loopCounterDo++;
            } while (loopCounterDo <= listBox.Items.Count);
        }

        private void buttonFor_Click(object sender, EventArgs e)
        {
            for (byte loopCounterFor = 1; loopCounterFor <= listBox.Items.Count; loopCounterFor++)
            {
                MessageBox.Show("Value of item [" + loopCounterFor + "] : \"" + listBox.Items[loopCounterFor - 1].ToString() + "\"", "Form1 - MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonWhile_Click(object sender, EventArgs e)
        {
            int loopCounterWhile = 1;
            while (loopCounterWhile <= listBox.Items.Count)
            {
                MessageBox.Show("Value of item [" + loopCounterWhile + "] : \"" + listBox.Items[loopCounterWhile - 1].ToString() + "\"", "Form1 - MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loopCounterWhile++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonDo.Enabled = false;
            buttonFor.Enabled = false;
            buttonWhile.Enabled = false;
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Project\t\t: Basic_CSharp\n\nProgram\t\t: Form1.cs\n\nAuthor\t\t: SIO TOU LAI (laisiotou1997@gmail.com)\n\nDate created\t: 28/03/2019\n\nVersion\t\t: Internal\n\nCopyright\t\t: GNU GENERAL PUBLIC LICENSE Version 3\n\nPurpose\t\t: Exercise 8 - on Loops_BHI\n\nRevision History\t:\nDate\t\tAuthor\tRef\tRevision\n28032019\t\tlst97\t1\tFirst release\n\nKnow issue\t: \n", "ABOUT");
        }
    }
}

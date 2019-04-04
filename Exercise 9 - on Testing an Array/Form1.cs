/*
;|**********************************************************************;
;* Project           : Basic_CSharp
;*
;* Program name      : Form1.cs
;*
;* Author            : SIO TOU LAI (laisiotou1997@gmail.com)
;*
;* Date created      : 04/04/2019
;*
;* Version           : Internal
;*
;* Copyright         : GNU GENERAL PUBLIC LICENSE Version 3
;*
;* Purpose           : Exercise 9 on Testing an Array_BHI
;*
;* Revision History  :
;*
;* Date        Author      Ref    Revision (Date in DDMMYYYY format)
;* 04042019    lst97       1      First release
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

namespace Exercise_9___on_Testing_an_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        /*

        //
        // Summary:
        //     Represents the largest possible value of an System.Int32. This field is constant.
        public const Int32 MaxValue = 2147483647;
        //
        // Summary:
        //     Represents the smallest possible value of System.Int32. This field is constant.
        public const Int32 MinValue = -2147483648;

        */
        Int32[] intArray = new Int32[20];
        private void buttonGenerate_Click(object sender, EventArgs e){
            
            for (int loopCounter = 0; loopCounter < intArray.Length; loopCounter++){
                if (buttonClear.Enabled == false){
                    intArray[loopCounter] = loopCounter * 100;                      // Dont have to * 100 every time when buttonGenerate click because the array had already been generated.
                    listBox.Items.Add(intArray[loopCounter].ToString());
                    
                }
                else { listBox.Items.Add(intArray[loopCounter].ToString()); }
            }
            if (buttonClear.Enabled == false) buttonClear.Enabled = true;           // Dont have to set enable every time when buttonGenerate click.
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            Array.Clear(intArray, 0, intArray.Length);                              // Set intArray to 0;
            buttonClear.Enabled = false;
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Project\t\t: Basic_CSharp\n\nProgram\t\t: Form1.cs\n\nAuthor\t\t: SIO TOU LAI (laisiotou1997@gmail.com)\n\nDate created\t: 04/04/2019\n\nVersion\t\t: Internal\n\nCopyright\t\t: GNU GENERAL PUBLIC LICENSE Version 3\n\nPurpose\t\t: Exercise 9 on Testing an Array_BHI\n\nRevision History\t:\nDate\t\tAuthor\tRef\tRevision\n04042019\t\tlst97\t1\tFirst release\n\nKnow issue\t: \n", "ABOUT");
        }
    }
}

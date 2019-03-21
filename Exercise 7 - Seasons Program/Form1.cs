/*
;|**********************************************************************;
;* Project           : Basic_CSharp
;*
;* Program name      : Form1.cs
;*
;* Author            : SIO TOU LAI (laisiotou1997@gmail.com)
;*
;* Date created      : 21/03/2019
;*
;* Version           : Internal
;*
;* Copyright         : GNU GENERAL PUBLIC LICENSE Version 3
;*
;* Purpose           : Exercise 7 - Seasons Program_BHI
;*
;* Revision History  :
;*
;* Date        Author      Ref    Revision (Date in DDMMYYYY format)
;* 21032019    lst97       1      First release
;*
;* Known Issue       :
;* Remove button disable
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

namespace Exercise_7___Seasons_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int intSeaPicker = 0;
        string[] szMonthBuffer = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        string[] szSeasonBuffer = new string[] { "Spring", "Summer", "Autumn", "Winter" };
        private void buttonCheck_Click(object sender, EventArgs e)
        {
           

            MessageBox.Show("Season\t: " + szSeasonBuffer[intSeaPicker], "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // DATA
            int intDay;
            int intMonth;
            int intYear;

            string szDateBuffer;
            string szMonthNameBuffer = "";

            // CODE
            intDay = dateTimePicker.Value.Day;
            intMonth = dateTimePicker.Value.Month;
            intYear = dateTimePicker.Value.Year;

            switch (intMonth)
            {
                case 1:
                    szMonthNameBuffer = szMonthBuffer[intMonth - 1];
                    intSeaPicker = 1;
                    break;
                case 2:
                    szMonthNameBuffer = szMonthBuffer[intMonth - 1];
                    intSeaPicker = 1;
                    break;
                case 3:
                    szMonthNameBuffer = szMonthBuffer[intMonth - 1];
                    intSeaPicker = 2;
                    break;
                case 4:
                    szMonthNameBuffer = szMonthBuffer[intMonth - 1];
                    intSeaPicker = 2;
                    break;
                case 5:
                    szMonthNameBuffer = szMonthBuffer[intMonth - 1];
                    intSeaPicker = 2;
                    break;
                case 6:
                    szMonthNameBuffer = szMonthBuffer[intMonth - 1];
                    intSeaPicker = 3;
                    break;
                case 7:
                    szMonthNameBuffer = szMonthBuffer[intMonth - 1];
                    intSeaPicker = 3;
                    break;
                case 8:
                    szMonthNameBuffer = szMonthBuffer[intMonth - 1];
                    intSeaPicker = 3;
                    break;
                case 9:
                    szMonthNameBuffer = szMonthBuffer[intMonth - 1];
                    intSeaPicker = 0;
                    break;
                case 10:
                    szMonthNameBuffer = szMonthBuffer[intMonth - 1];
                    intSeaPicker = 0;
                    break;
                case 11:
                    szMonthNameBuffer = szMonthBuffer[intMonth - 1];
                    intSeaPicker = 0;
                    break;
                case 12:
                    szMonthNameBuffer = szMonthBuffer[intMonth - 1];
                    intSeaPicker = 1;
                    break;
            }
            szDateBuffer = intDay.ToString() + "/" + intMonth.ToString() + "/" + intYear.ToString();

            listBoxDate.Items.Add(intDay + " " + szMonthNameBuffer + " " + intYear);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxDate.Items.Clear();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Project\t\t: Basic_CSharp\n\nProgram\t\t: Form1.cs\n\nAuthor\t\t: SIO TOU LAI (laisiotou1997@gmail.com)\n\nDate created\t: 21/03/2019\n\nVersion\t\t: Internal\n\nCopyright\t\t: GNU GENERAL PUBLIC LICENSE Version 3\n\nPurpose\t\t: Exercise 7 - Seasons Program_BHI\n\nRevision History\t:\nDate\t\tAuthor\tRef\tRevision\n21032019\tlst97\t1\tFirst release\n\nKnow issue\t: Remove button not working\n", "ABOUT");
        }
    }
}

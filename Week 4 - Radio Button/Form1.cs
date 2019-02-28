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
;* Purpose           : Exercise 4 – Radio Button
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

namespace Week_4___Radio_Button{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e){

        }

        private void radioButtonAustralia_CheckedChanged(object sender, EventArgs e){
            if (radioButtonAustralia.Checked == true){
                pictureBoxFlag.Image = (Image)Week_4___Radio_Button.Properties.Resources.AustraliaFlag;
                labelCountry.Text = "Australia";
            }
        }

        private void radioButtonNewZealand_CheckedChanged(object sender, EventArgs e){
            if (radioButtonNewZealand.Checked == true){
                pictureBoxFlag.Image = (Image)Week_4___Radio_Button.Properties.Resources.NewZealandFlag;
                labelCountry.Text = "New Zealand";
            }
        }

        private void radioButtonUSA_CheckedChanged(object sender, EventArgs e){
            if (radioButtonUSA.Checked == true){
                pictureBoxFlag.Image = (Image)Week_4___Radio_Button.Properties.Resources.USAFlag;
                labelCountry.Text = "USA";
            }
        }

        private void radioButtonJapan_CheckedChanged(object sender, EventArgs e){
            if (radioButtonJapan.Checked == true){
                pictureBoxFlag.Image = (Image)Week_4___Radio_Button.Properties.Resources.JapanFlag;
                labelCountry.Text = "Japan";
            }
        }

        private void radioButtonChina_CheckedChanged(object sender, EventArgs e){
            if (radioButtonChina.Checked == true){
                pictureBoxFlag.Image = (Image)Week_4___Radio_Button.Properties.Resources.ChinaFlag;
                labelCountry.Text = "China";
            }
        }

        private void radioButtonThumbNail_CheckedChanged(object sender, EventArgs e){
            pictureBoxFlag.ClientSize = new Size(32, 32);
            radioButtonFullSize.Enabled = true;
        }

        private void radioButtonFullSize_CheckedChanged(object sender, EventArgs e){
            pictureBoxFlag.ClientSize = new Size(417, 213);
        }

        private void buttonAbout_Click(object sender, EventArgs e){
            MessageBox.Show("Project\t\t: Basic_CSharp\n\nProgram\t\t: Form1.cs\n\nAuthor\t\t: SIO TOU LAI (laisiotou1997@gmail.com)\n\nDate created\t: 28/02/2019\n\nVersion\t\t: Internal\n\nCopyright\t\t: GNU GENERAL PUBLIC LICENSE Version 3\n\nPurpose\t\t: Exercise 4 - Radio Box\n\nRevision History\t:\nDate\tAuthor\tRef\tRevision (Date in DDMMYYYY format)\n28022019\tlst97\t1\tFirst release", "ABOUT");
        }
    }
}

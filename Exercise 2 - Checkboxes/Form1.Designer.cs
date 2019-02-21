namespace Exercise_2___Checkboxes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.checkBoxFires = new System.Windows.Forms.CheckBox();
            this.checkBoxBHeading = new System.Windows.Forms.CheckBox();
            this.checkBoxUpsize = new System.Windows.Forms.CheckBox();
            this.checkBoxCHeading = new System.Windows.Forms.CheckBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(55, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(556, 55);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Exercise 2 - Checkboxes";
            this.labelTitle.UseMnemonic = false;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthor.Location = new System.Drawing.Point(171, 64);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(364, 39);
            this.labelAuthor.TabIndex = 1;
            this.labelAuthor.Text = "Nelson LAI s10000399";
            // 
            // checkBoxFires
            // 
            this.checkBoxFires.AutoSize = true;
            this.checkBoxFires.Location = new System.Drawing.Point(157, 149);
            this.checkBoxFires.Name = "checkBoxFires";
            this.checkBoxFires.Size = new System.Drawing.Size(48, 17);
            this.checkBoxFires.TabIndex = 2;
            this.checkBoxFires.Text = "Fires";
            this.checkBoxFires.UseVisualStyleBackColor = true;
            // 
            // checkBoxBHeading
            // 
            this.checkBoxBHeading.AutoSize = true;
            this.checkBoxBHeading.Location = new System.Drawing.Point(418, 149);
            this.checkBoxBHeading.Name = "checkBoxBHeading";
            this.checkBoxBHeading.Size = new System.Drawing.Size(90, 17);
            this.checkBoxBHeading.TabIndex = 3;
            this.checkBoxBHeading.Text = "Bold Heading";
            this.checkBoxBHeading.UseVisualStyleBackColor = true;
            // 
            // checkBoxUpsize
            // 
            this.checkBoxUpsize.AutoSize = true;
            this.checkBoxUpsize.Location = new System.Drawing.Point(157, 199);
            this.checkBoxUpsize.Name = "checkBoxUpsize";
            this.checkBoxUpsize.Size = new System.Drawing.Size(58, 17);
            this.checkBoxUpsize.TabIndex = 4;
            this.checkBoxUpsize.Text = "Upsize";
            this.checkBoxUpsize.UseVisualStyleBackColor = true;
            // 
            // checkBoxCHeading
            // 
            this.checkBoxCHeading.AutoSize = true;
            this.checkBoxCHeading.Location = new System.Drawing.Point(418, 199);
            this.checkBoxCHeading.Name = "checkBoxCHeading";
            this.checkBoxCHeading.Size = new System.Drawing.Size(99, 17);
            this.checkBoxCHeading.TabIndex = 5;
            this.checkBoxCHeading.Text = "Colour Heading";
            this.checkBoxCHeading.UseVisualStyleBackColor = true;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(12, 290);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(113, 13);
            this.labelMessage.TabIndex = 6;
            this.labelMessage.Text = "Message Display Here";
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(233, 237);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 23);
            this.buttonEnter.TabIndex = 7;
            this.buttonEnter.Text = "ENTER !";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(314, 237);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 23);
            this.buttonAbout.TabIndex = 8;
            this.buttonAbout.Text = "ABOUT";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 321);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.checkBoxCHeading);
            this.Controls.Add(this.checkBoxUpsize);
            this.Controls.Add(this.checkBoxBHeading);
            this.Controls.Add(this.checkBoxFires);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelTitle);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(680, 360);
            this.MinimumSize = new System.Drawing.Size(680, 360);
            this.Name = "Form1";
            this.Text = "Exercise 2 - Checkboxes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.CheckBox checkBoxFires;
        private System.Windows.Forms.CheckBox checkBoxBHeading;
        private System.Windows.Forms.CheckBox checkBoxUpsize;
        private System.Windows.Forms.CheckBox checkBoxCHeading;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonAbout;
    }
}


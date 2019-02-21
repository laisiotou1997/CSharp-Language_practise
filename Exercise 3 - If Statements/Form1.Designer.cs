namespace Exercise_3___If_Statements
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
            this.labelMessage = new System.Windows.Forms.Label();
            this.checkBoxFires = new System.Windows.Forms.CheckBox();
            this.checkBoxUpsize = new System.Windows.Forms.CheckBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(46, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(553, 55);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Heart Stopper Fast Food";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(12, 259);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(111, 13);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "Message Shows Here";
            // 
            // checkBoxFires
            // 
            this.checkBoxFires.AutoSize = true;
            this.checkBoxFires.Location = new System.Drawing.Point(215, 91);
            this.checkBoxFires.Name = "checkBoxFires";
            this.checkBoxFires.Size = new System.Drawing.Size(167, 17);
            this.checkBoxFires.TabIndex = 2;
            this.checkBoxFires.Text = "Would you like fries with that?";
            this.checkBoxFires.UseVisualStyleBackColor = true;
            // 
            // checkBoxUpsize
            // 
            this.checkBoxUpsize.AutoSize = true;
            this.checkBoxUpsize.Location = new System.Drawing.Point(215, 151);
            this.checkBoxUpsize.Name = "checkBoxUpsize";
            this.checkBoxUpsize.Size = new System.Drawing.Size(147, 17);
            this.checkBoxUpsize.TabIndex = 3;
            this.checkBoxUpsize.Text = "Would you like to upsize?";
            this.checkBoxUpsize.UseVisualStyleBackColor = true;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(215, 205);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 23);
            this.buttonEnter.TabIndex = 4;
            this.buttonEnter.Text = "ORDER !";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(339, 205);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 23);
            this.buttonAbout.TabIndex = 5;
            this.buttonAbout.Text = "ABOUT";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 281);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.checkBoxUpsize);
            this.Controls.Add(this.checkBoxFires);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelTitle);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 320);
            this.MinimumSize = new System.Drawing.Size(640, 320);
            this.Name = "Form1";
            this.Text = "Exercise 3 - If Statements";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.CheckBox checkBoxFires;
        private System.Windows.Forms.CheckBox checkBoxUpsize;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonAbout;
    }
}


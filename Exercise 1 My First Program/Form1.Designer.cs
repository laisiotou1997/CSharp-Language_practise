namespace Exercise_1_My_First_Program_Assignment
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
            this.textBoxGName = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelGName = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.labelMShow = new System.Windows.Forms.Label();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxGName
            // 
            this.textBoxGName.Location = new System.Drawing.Point(156, 73);
            this.textBoxGName.Name = "textBoxGName";
            this.textBoxGName.Size = new System.Drawing.Size(136, 20);
            this.textBoxGName.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Red;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(374, 55);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "HELLO WORLD";
            // 
            // labelGName
            // 
            this.labelGName.AutoSize = true;
            this.labelGName.Location = new System.Drawing.Point(80, 76);
            this.labelGName.Name = "labelGName";
            this.labelGName.Size = new System.Drawing.Size(69, 13);
            this.labelGName.TabIndex = 2;
            this.labelGName.Text = "Given Name:";
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Location = new System.Drawing.Point(80, 122);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(70, 13);
            this.labelFName.TabIndex = 3;
            this.labelFName.Text = "Family Name:";
            // 
            // labelMShow
            // 
            this.labelMShow.AutoSize = true;
            this.labelMShow.Location = new System.Drawing.Point(153, 163);
            this.labelMShow.Name = "labelMShow";
            this.labelMShow.Size = new System.Drawing.Size(77, 13);
            this.labelMShow.TabIndex = 4;
            this.labelMShow.Text = "MessageShow";
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(156, 119);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(136, 20);
            this.textBoxFName.TabIndex = 5;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(83, 198);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 23);
            this.buttonEnter.TabIndex = 6;
            this.buttonEnter.Text = "ENTER!";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(217, 198);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 23);
            this.buttonAbout.TabIndex = 7;
            this.buttonAbout.Text = "ABOUT";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 242);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.labelMShow);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.labelGName);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxGName);
            this.Name = "Form1";
            this.Text = "Exercise 1 My First Program_S10000399";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGName;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelGName;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Label labelMShow;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonAbout;
    }
}


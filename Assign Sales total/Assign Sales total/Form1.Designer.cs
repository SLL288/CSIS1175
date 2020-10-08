namespace Assign_Sales_total
{
    partial class Form1
    {

        //Form1.Size = new System.Drawing.Size(100, 100);
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
            this.contentTextbox = new System.Windows.Forms.RichTextBox();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.GroupBox();
            this.firstnameTextbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lastnameTextbox = new System.Windows.Forms.TextBox();
            this.processButton = new System.Windows.Forms.Button();
            this.depositeCheck = new System.Windows.Forms.CheckBox();
            this.withdrawCheck = new System.Windows.Forms.CheckBox();
            this.FirstName.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentTextbox
            // 
            this.contentTextbox.Location = new System.Drawing.Point(924, 88);
            this.contentTextbox.Name = "contentTextbox";
            this.contentTextbox.Size = new System.Drawing.Size(591, 484);
            this.contentTextbox.TabIndex = 1;
            this.contentTextbox.Text = "";
            // 
            // totalBox
            // 
            this.totalBox.BackColor = System.Drawing.Color.DarkCyan;
            this.totalBox.ForeColor = System.Drawing.Color.Gold;
            this.totalBox.Location = new System.Drawing.Point(923, 613);
            this.totalBox.MinimumSize = new System.Drawing.Size(4, 50);
            this.totalBox.Name = "totalBox";
            this.totalBox.ReadOnly = true;
            this.totalBox.Size = new System.Drawing.Size(591, 35);
            this.totalBox.TabIndex = 2;
            // 
            // FirstName
            // 
            this.FirstName.Controls.Add(this.firstnameTextbox);
            this.FirstName.Location = new System.Drawing.Point(91, 229);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(274, 121);
            this.FirstName.TabIndex = 3;
            this.FirstName.TabStop = false;
            this.FirstName.Text = "First Name";
            // 
            // firstnameTextbox
            // 
            this.firstnameTextbox.Location = new System.Drawing.Point(18, 48);
            this.firstnameTextbox.MinimumSize = new System.Drawing.Size(4, 50);
            this.firstnameTextbox.Name = "firstnameTextbox";
            this.firstnameTextbox.Size = new System.Drawing.Size(228, 35);
            this.firstnameTextbox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lastnameTextbox);
            this.groupBox2.Location = new System.Drawing.Point(371, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 121);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Last Name";
            // 
            // lastnameTextbox
            // 
            this.lastnameTextbox.Location = new System.Drawing.Point(28, 48);
            this.lastnameTextbox.MinimumSize = new System.Drawing.Size(4, 50);
            this.lastnameTextbox.Name = "lastnameTextbox";
            this.lastnameTextbox.Size = new System.Drawing.Size(228, 35);
            this.lastnameTextbox.TabIndex = 1;
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(579, 398);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(245, 65);
            this.processButton.TabIndex = 5;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // depositeCheck
            // 
            this.depositeCheck.AutoSize = true;
            this.depositeCheck.Location = new System.Drawing.Point(109, 415);
            this.depositeCheck.Name = "depositeCheck";
            this.depositeCheck.Size = new System.Drawing.Size(142, 33);
            this.depositeCheck.TabIndex = 6;
            this.depositeCheck.Text = "Deposite";
            this.depositeCheck.UseVisualStyleBackColor = true;
            this.depositeCheck.CheckedChanged += new System.EventHandler(this.depositeCheck_CheckedChanged);
            // 
            // withdrawCheck
            // 
            this.withdrawCheck.AutoSize = true;
            this.withdrawCheck.Location = new System.Drawing.Point(310, 415);
            this.withdrawCheck.Name = "withdrawCheck";
            this.withdrawCheck.Size = new System.Drawing.Size(133, 33);
            this.withdrawCheck.TabIndex = 7;
            this.withdrawCheck.Text = "Withdral";
            this.withdrawCheck.UseVisualStyleBackColor = true;
            this.withdrawCheck.CheckedChanged += new System.EventHandler(this.withdrawCheck_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1972, 766);
            this.Controls.Add(this.withdrawCheck);
            this.Controls.Add(this.depositeCheck);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.contentTextbox);
            this.Location = new System.Drawing.Point(100, 100);
            this.MinimumSize = new System.Drawing.Size(2000, 845);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FirstName.ResumeLayout(false);
            this.FirstName.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox contentTextbox;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.GroupBox FirstName;
        private System.Windows.Forms.TextBox firstnameTextbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox lastnameTextbox;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.CheckBox depositeCheck;
        private System.Windows.Forms.CheckBox withdrawCheck;
    }
}


﻿namespace logo_tool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_logo = new System.Windows.Forms.Label();
            this.lbl_yoda = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lbl_bottle = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.lbl_hand = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.lbl_point = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.lbl_result_folder = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Render";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Chọn file logo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbl_logo
            // 
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.Location = new System.Drawing.Point(127, 16);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(0, 15);
            this.lbl_logo.TabIndex = 7;
            // 
            // lbl_yoda
            // 
            this.lbl_yoda.AutoSize = true;
            this.lbl_yoda.Location = new System.Drawing.Point(127, 56);
            this.lbl_yoda.Name = "lbl_yoda";
            this.lbl_yoda.Size = new System.Drawing.Size(0, 15);
            this.lbl_yoda.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Chọn file yoda";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_bottle
            // 
            this.lbl_bottle.AutoSize = true;
            this.lbl_bottle.Location = new System.Drawing.Point(127, 95);
            this.lbl_bottle.Name = "lbl_bottle";
            this.lbl_bottle.Size = new System.Drawing.Size(0, 15);
            this.lbl_bottle.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 91);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Chọn file chai";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbl_hand
            // 
            this.lbl_hand.AutoSize = true;
            this.lbl_hand.Location = new System.Drawing.Point(127, 134);
            this.lbl_hand.Name = "lbl_hand";
            this.lbl_hand.Size = new System.Drawing.Size(0, 15);
            this.lbl_hand.TabIndex = 13;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 130);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Chọn file tay";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lbl_point
            // 
            this.lbl_point.AutoSize = true;
            this.lbl_point.Location = new System.Drawing.Point(127, 172);
            this.lbl_point.Name = "lbl_point";
            this.lbl_point.Size = new System.Drawing.Size(0, 15);
            this.lbl_point.TabIndex = 15;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 168);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "Chọn file point";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(102, 249);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(84, 15);
            this.lbl_result.TabIndex = 16;
            this.lbl_result.Text = "File result path";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size render";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 19);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "600 x 600";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 22);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(73, 19);
            this.radioButton3.TabIndex = 17;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "600 x 600";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // lbl_result_folder
            // 
            this.lbl_result_folder.AutoSize = true;
            this.lbl_result_folder.Location = new System.Drawing.Point(127, 211);
            this.lbl_result_folder.Name = "lbl_result_folder";
            this.lbl_result_folder.Size = new System.Drawing.Size(0, 15);
            this.lbl_result_folder.TabIndex = 18;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 207);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(109, 23);
            this.button7.TabIndex = 17;
            this.button7.Text = "Chọn folder";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 291);
            this.Controls.Add(this.lbl_result_folder);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.lbl_point);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.lbl_hand);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lbl_bottle);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lbl_yoda);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbl_logo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Render";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.Label lbl_yoda;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbl_bottle;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbl_hand;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lbl_point;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.CheckBox style_resize;
        private System.Windows.Forms.Label lbl_result_folder;
        private System.Windows.Forms.Button button7;
    }
}


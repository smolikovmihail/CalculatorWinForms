﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsCalculator
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
        //this code is generated by the environment as a result of my work with FormDesigner
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click+= new System.EventHandler(this.button_Num_Click); //for each number buttons I can use
                                                                                //one method - button_Num_Click
                                                                                //This method is described in the file Form1.cs
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Num_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Num_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 133);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 44);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Num_Click);
            // 
            // textBox1 - used to store the first number
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 13);
            this.textBox1.Name = "textBoxOutput";
            this.textBox1.Size = new System.Drawing.Size(345, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = new HorizontalAlignment();
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // 
            // textBox2 used to store the second number
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 30);
            this.textBox2.Name = "textBoxInput";
            this.textBox2.Size = new System.Drawing.Size(345, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign =new HorizontalAlignment();
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(108, 133);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 44);
            this.button5.TabIndex = 6;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Num_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(203, 133);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 44);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Num_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 71);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 42);
            this.button7.TabIndex = 8;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Num_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(108, 71);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 42);
            this.button8.TabIndex = 9;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Num_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(203, 71);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 42);
            this.button9.TabIndex = 10;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Num_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 259);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(171, 44);
            this.button10.TabIndex = 11;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click +=new System.EventHandler(this.button_Num_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(203, 259);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 44);
            this.button11.TabIndex = 12;
            this.button11.Font = new Font("TimesNewRoman", 18);
            this.button11.Text = ".";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button_Point_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(378, 203);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 100);
            this.button12.TabIndex = 13;
            this.button12.Text = "Enter";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button_Enter_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(378, 71);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 104);
            this.button13.TabIndex = 14;
            this.button13.Text = "Clear";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(297, 261);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 42);
            this.button14.TabIndex = 15;
            this.button14.Text = "X";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button_Operation_Click); //for each operation buttons
                                                                                         //I can use one method button_Operation_Click
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(297, 203);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 42);
            this.button15.TabIndex = 16;
            this.button15.Text = "÷";
            this.button15.Font = new Font("TimesNewRoman",18);
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button_Operation_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(297, 133);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 42);
            this.button16.TabIndex = 17;
            this.button16.Font = new Font("TimesNewRoman", 18);
            this.button16.Text = "+";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button_Operation_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(297, 71);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 42);
            this.button17.TabIndex = 18;
            this.button17.Font = new Font("TimesNewRoman", 18);
            this.button17.Text = "-";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button_Operation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 315);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
       
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;


    }
}

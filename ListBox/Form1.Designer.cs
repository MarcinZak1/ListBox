﻿namespace ListBox
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnPrzeniesDoListBox2 = new System.Windows.Forms.Button();
            this.btnPrzeniesDoListBox1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(58, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(245, 368);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(493, 43);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(245, 368);
            this.listBox2.TabIndex = 1;
            // 
            // btnPrzeniesDoListBox2
            // 
            this.btnPrzeniesDoListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzeniesDoListBox2.Location = new System.Drawing.Point(361, 94);
            this.btnPrzeniesDoListBox2.Name = "btnPrzeniesDoListBox2";
            this.btnPrzeniesDoListBox2.Size = new System.Drawing.Size(75, 55);
            this.btnPrzeniesDoListBox2.TabIndex = 2;
            this.btnPrzeniesDoListBox2.Text = ">>";
            this.btnPrzeniesDoListBox2.UseVisualStyleBackColor = true;
            this.btnPrzeniesDoListBox2.Click += new System.EventHandler(this.zListBox1DoListBox2_Click);
            // 
            // btnPrzeniesDoListBox1
            // 
            this.btnPrzeniesDoListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzeniesDoListBox1.Location = new System.Drawing.Point(361, 251);
            this.btnPrzeniesDoListBox1.Name = "btnPrzeniesDoListBox1";
            this.btnPrzeniesDoListBox1.Size = new System.Drawing.Size(75, 55);
            this.btnPrzeniesDoListBox1.TabIndex = 3;
            this.btnPrzeniesDoListBox1.Text = "<<";
            this.btnPrzeniesDoListBox1.UseVisualStyleBackColor = true;
            this.btnPrzeniesDoListBox1.Click += new System.EventHandler(this.zListBox2DoListBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrzeniesDoListBox1);
            this.Controls.Add(this.btnPrzeniesDoListBox2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnPrzeniesDoListBox2;
        private System.Windows.Forms.Button btnPrzeniesDoListBox1;
    }
}


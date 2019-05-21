﻿namespace OptiSoft
{
    partial class AddDocument
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
            this.DocumentNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DocumentDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DocumentDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DocumentNumber
            // 
            this.DocumentNumber.Location = new System.Drawing.Point(146, 43);
            this.DocumentNumber.Name = "DocumentNumber";
            this.DocumentNumber.Size = new System.Drawing.Size(332, 20);
            this.DocumentNumber.TabIndex = 0;
            this.DocumentNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер документа";
            // 
            // DocumentDescription
            // 
            this.DocumentDescription.Location = new System.Drawing.Point(146, 82);
            this.DocumentDescription.Multiline = true;
            this.DocumentDescription.Name = "DocumentDescription";
            this.DocumentDescription.Size = new System.Drawing.Size(332, 111);
            this.DocumentDescription.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Описание документа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дата документа";
            // 
            // DocumentDate
            // 
            this.DocumentDate.Location = new System.Drawing.Point(146, 208);
            this.DocumentDate.Name = "DocumentDate";
            this.DocumentDate.Size = new System.Drawing.Size(200, 20);
            this.DocumentDate.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Создать документ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 283);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DocumentDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DocumentDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DocumentNumber);
            this.Name = "AddDocument";
            this.Text = "AddDocument";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DocumentNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DocumentDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DocumentDate;
        private System.Windows.Forms.Button button1;
    }
}
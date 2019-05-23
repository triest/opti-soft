namespace OptiSoft
{
    partial class EditDocument
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
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DocumentDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DocumentDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DocumentNumber = new System.Windows.Forms.TextBox();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Статус";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Создать документ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DocumentDate
            // 
            this.DocumentDate.Location = new System.Drawing.Point(153, 232);
            this.DocumentDate.Name = "DocumentDate";
            this.DocumentDate.Size = new System.Drawing.Size(200, 20);
            this.DocumentDate.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Дата документа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Описание документа";
            // 
            // DocumentDescription
            // 
            this.DocumentDescription.Location = new System.Drawing.Point(153, 54);
            this.DocumentDescription.Multiline = true;
            this.DocumentDescription.Name = "DocumentDescription";
            this.DocumentDescription.Size = new System.Drawing.Size(332, 111);
            this.DocumentDescription.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Номер документа";
            // 
            // DocumentNumber
            // 
            this.DocumentNumber.Location = new System.Drawing.Point(153, 15);
            this.DocumentNumber.Name = "DocumentNumber";
            this.DocumentNumber.Size = new System.Drawing.Size(332, 20);
            this.DocumentNumber.TabIndex = 9;
            this.DocumentNumber.TextChanged += new System.EventHandler(this.DocumentNumber_TextChanged);
            // 
            // statusBox
            // 
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Location = new System.Drawing.Point(153, 183);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(121, 21);
            this.statusBox.TabIndex = 17;
            // 
            // EditDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 330);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DocumentDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DocumentDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DocumentNumber);
            this.Name = "EditDocument";
            this.Text = "EditDocument";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker DocumentDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox DocumentNumber;
        public System.Windows.Forms.TextBox DocumentDescription;
        public System.Windows.Forms.ComboBox statusBox;
    }
}
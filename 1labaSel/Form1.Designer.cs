﻿namespace _1labaSel
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioHord = new System.Windows.Forms.RadioButton();
            this.radioCas = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 399);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(615, 44);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Maximum = 16;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(171, 56);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(772, 117);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(257, 79);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Масштаб";
            // 
            // radioHord
            // 
            this.radioHord.AutoSize = true;
            this.radioHord.Location = new System.Drawing.Point(548, 117);
            this.radioHord.Name = "radioHord";
            this.radioHord.Size = new System.Drawing.Size(105, 21);
            this.radioHord.TabIndex = 4;
            this.radioHord.TabStop = true;
            this.radioHord.Text = "Метод хорд";
            this.radioHord.UseVisualStyleBackColor = true;
            this.radioHord.CheckedChanged += new System.EventHandler(this.radioHord_CheckedChanged);
            // 
            // radioCas
            // 
            this.radioCas.AutoSize = true;
            this.radioCas.Location = new System.Drawing.Point(548, 160);
            this.radioCas.Name = "radioCas";
            this.radioCas.Size = new System.Drawing.Size(159, 21);
            this.radioCas.TabIndex = 5;
            this.radioCas.TabStop = true;
            this.radioCas.Text = "Метод касательных";
            this.radioCas.UseVisualStyleBackColor = true;
            this.radioCas.CheckedChanged += new System.EventHandler(this.radioCas_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "информация";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(769, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "результат";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(519, 315);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(359, 111);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            this.richTextBox2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioCas);
            this.Controls.Add(this.radioHord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioHord;
        private System.Windows.Forms.RadioButton radioCas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}


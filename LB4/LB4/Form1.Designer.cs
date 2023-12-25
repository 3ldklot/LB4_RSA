namespace LB4
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
            label1 = new Label();
            textBoxpValue = new TextBox();
            textBoxqValue = new TextBox();
            label2 = new Label();
            textBoxdValue = new TextBox();
            label3 = new Label();
            textBoxeValue = new TextBox();
            label4 = new Label();
            button1 = new Button();
            groupBoxValues = new GroupBox();
            groupBoxKeys = new GroupBox();
            textBoxnValueOut = new TextBox();
            textBoxdValueOut = new TextBox();
            textBoxeValueOut = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            buttonExit = new Button();
            label10 = new Label();
            label12 = new Label();
            textBoxRead = new TextBox();
            textBoxDecrypted = new TextBox();
            button2 = new Button();
            groupBoxValues.SuspendLayout();
            groupBoxKeys.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 1);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter p value:";
            // 
            // textBoxpValue
            // 
            textBoxpValue.Location = new Point(4, 19);
            textBoxpValue.Name = "textBoxpValue";
            textBoxpValue.Size = new Size(128, 23);
            textBoxpValue.TabIndex = 1;
            textBoxpValue.KeyPress += textBoxpValue_KeyPress;
            // 
            // textBoxqValue
            // 
            textBoxqValue.Location = new Point(4, 64);
            textBoxqValue.Name = "textBoxqValue";
            textBoxqValue.Size = new Size(128, 23);
            textBoxqValue.TabIndex = 3;
            textBoxqValue.KeyPress += textBoxqValue_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 46);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 2;
            label2.Text = "Enter q value:";
            // 
            // textBoxdValue
            // 
            textBoxdValue.Enabled = false;
            textBoxdValue.Location = new Point(4, 164);
            textBoxdValue.Name = "textBoxdValue";
            textBoxdValue.Size = new Size(128, 23);
            textBoxdValue.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 144);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 6;
            label3.Text = "Value of d:";
            // 
            // textBoxeValue
            // 
            textBoxeValue.Location = new Point(4, 111);
            textBoxeValue.Name = "textBoxeValue";
            textBoxeValue.Size = new Size(128, 23);
            textBoxeValue.TabIndex = 5;
            textBoxeValue.KeyPress += textBoxeValue_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 90);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 4;
            label4.Text = "Enter e value:";
            // 
            // button1
            // 
            button1.Location = new Point(4, 193);
            button1.Name = "button1";
            button1.Size = new Size(128, 23);
            button1.TabIndex = 8;
            button1.Text = "Calculate d";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBoxValues
            // 
            groupBoxValues.Controls.Add(button1);
            groupBoxValues.Controls.Add(textBoxdValue);
            groupBoxValues.Controls.Add(label3);
            groupBoxValues.Controls.Add(textBoxeValue);
            groupBoxValues.Controls.Add(label4);
            groupBoxValues.Controls.Add(textBoxqValue);
            groupBoxValues.Controls.Add(label2);
            groupBoxValues.Controls.Add(textBoxpValue);
            groupBoxValues.Controls.Add(label1);
            groupBoxValues.Location = new Point(12, 12);
            groupBoxValues.Name = "groupBoxValues";
            groupBoxValues.Size = new Size(137, 222);
            groupBoxValues.TabIndex = 9;
            groupBoxValues.TabStop = false;
            // 
            // groupBoxKeys
            // 
            groupBoxKeys.Controls.Add(textBoxnValueOut);
            groupBoxKeys.Controls.Add(textBoxdValueOut);
            groupBoxKeys.Controls.Add(textBoxeValueOut);
            groupBoxKeys.Controls.Add(label9);
            groupBoxKeys.Controls.Add(label8);
            groupBoxKeys.Controls.Add(label7);
            groupBoxKeys.Controls.Add(label6);
            groupBoxKeys.Controls.Add(label5);
            groupBoxKeys.Location = new Point(155, 17);
            groupBoxKeys.Name = "groupBoxKeys";
            groupBoxKeys.Size = new Size(200, 100);
            groupBoxKeys.TabIndex = 10;
            groupBoxKeys.TabStop = false;
            groupBoxKeys.Text = "Pairs of keys";
            // 
            // textBoxnValueOut
            // 
            textBoxnValueOut.Location = new Point(39, 68);
            textBoxnValueOut.Name = "textBoxnValueOut";
            textBoxnValueOut.Size = new Size(155, 23);
            textBoxnValueOut.TabIndex = 11;
            // 
            // textBoxdValueOut
            // 
            textBoxdValueOut.Location = new Point(144, 42);
            textBoxdValueOut.Name = "textBoxdValueOut";
            textBoxdValueOut.Size = new Size(50, 23);
            textBoxdValueOut.TabIndex = 6;
            // 
            // textBoxeValueOut
            // 
            textBoxeValueOut.Location = new Point(39, 42);
            textBoxeValueOut.Name = "textBoxeValueOut";
            textBoxeValueOut.Size = new Size(50, 23);
            textBoxeValueOut.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 71);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 4;
            label9.Text = "n = ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(116, 45);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 3;
            label8.Text = "d = ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 45);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 2;
            label7.Text = "e = ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(116, 21);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 1;
            label6.Text = "Private(d, n)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 21);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 0;
            label5.Text = "Public (e, n)";
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(313, 554);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(42, 23);
            buttonExit.TabIndex = 11;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 249);
            label10.Name = "label10";
            label10.Size = new Size(132, 15);
            label10.TabIndex = 12;
            label10.Text = "Чтение из файла: in.txt";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(201, 249);
            label12.Name = "label12";
            label12.Size = new Size(141, 15);
            label12.TabIndex = 14;
            label12.Text = "Расшифровка в: out2.txt";
            // 
            // textBoxRead
            // 
            textBoxRead.Location = new Point(9, 267);
            textBoxRead.Multiline = true;
            textBoxRead.Name = "textBoxRead";
            textBoxRead.Size = new Size(163, 281);
            textBoxRead.TabIndex = 15;
            // 
            // textBoxDecrypted
            // 
            textBoxDecrypted.Location = new Point(194, 267);
            textBoxDecrypted.Multiline = true;
            textBoxDecrypted.Name = "textBoxDecrypted";
            textBoxDecrypted.Size = new Size(161, 281);
            textBoxDecrypted.TabIndex = 16;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Menu;
            button2.Location = new Point(155, 122);
            button2.Name = "button2";
            button2.Size = new Size(200, 124);
            button2.TabIndex = 17;
            button2.Text = "BIG NOT BLUE BUTTON";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 589);
            Controls.Add(button2);
            Controls.Add(textBoxDecrypted);
            Controls.Add(textBoxRead);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(buttonExit);
            Controls.Add(groupBoxKeys);
            Controls.Add(groupBoxValues);
            Name = "Form1";
            Text = "RSA encryption";
            groupBoxValues.ResumeLayout(false);
            groupBoxValues.PerformLayout();
            groupBoxKeys.ResumeLayout(false);
            groupBoxKeys.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxpValue;
        private TextBox textBoxqValue;
        private Label label2;
        private TextBox textBoxdValue;
        private Label label3;
        private TextBox textBoxeValue;
        private Label label4;
        private Button button1;
        private GroupBox groupBoxValues;
        private GroupBox groupBoxKeys;
        private Label label6;
        private Label label5;
        private TextBox textBoxnValueOut;
        private TextBox textBoxdValueOut;
        private TextBox textBoxeValueOut;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button buttonExit;
        private Label label10;
        private Label label12;
        private TextBox textBoxRead;
        private TextBox textBoxDecrypted;
        private Button button2;
    }
}
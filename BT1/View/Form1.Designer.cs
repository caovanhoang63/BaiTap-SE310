namespace BT1
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
            this.cowTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sheepTextBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.goatTextBox = new System.Windows.Forms.TextBox();
            this.addAnimalBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cow = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sheep = new System.Windows.Forms.TextBox();
            this.goat = new System.Windows.Forms.TextBox();
            this.milk = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cowTextBox
            // 
            this.cowTextBox.Location = new System.Drawing.Point(59, 63);
            this.cowTextBox.Name = "cowTextBox";
            this.cowTextBox.Size = new System.Drawing.Size(237, 26);
            this.cowTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(59, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số bò";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(59, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số cừu";
            // 
            // sheepTextBox
            // 
            this.sheepTextBox.Location = new System.Drawing.Point(59, 130);
            this.sheepTextBox.Name = "sheepTextBox";
            this.sheepTextBox.Size = new System.Drawing.Size(237, 26);
            this.sheepTextBox.TabIndex = 2;
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(59, 178);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(123, 24);
            this.label.TabIndex = 5;
            this.label.Text = "Số dê";
            // 
            // goatTextBox
            // 
            this.goatTextBox.Location = new System.Drawing.Point(59, 205);
            this.goatTextBox.Name = "goatTextBox";
            this.goatTextBox.Size = new System.Drawing.Size(237, 26);
            this.goatTextBox.TabIndex = 4;
            // 
            // addAnimalBtn
            // 
            this.addAnimalBtn.Location = new System.Drawing.Point(60, 260);
            this.addAnimalBtn.Name = "addAnimalBtn";
            this.addAnimalBtn.Size = new System.Drawing.Size(236, 45);
            this.addAnimalBtn.TabIndex = 6;
            this.addAnimalBtn.Text = "Thêm";
            this.addAnimalBtn.UseVisualStyleBackColor = true;
            this.addAnimalBtn.Click += new System.EventHandler(this.addAnimalBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(403, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 45);
            this.button2.TabIndex = 7;
            this.button2.Text = "Sinh sản";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(590, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 45);
            this.button3.TabIndex = 8;
            this.button3.Text = "Lấy sữa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(403, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số bò";
            // 
            // cow
            // 
            this.cow.Location = new System.Drawing.Point(495, 127);
            this.cow.Name = "cow";
            this.cow.ReadOnly = true;
            this.cow.Size = new System.Drawing.Size(107, 26);
            this.cow.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(403, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số cừu";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(403, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Số dê";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(403, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Số sữa";
            // 
            // sheep
            // 
            this.sheep.Location = new System.Drawing.Point(495, 175);
            this.sheep.Name = "sheep";
            this.sheep.ReadOnly = true;
            this.sheep.Size = new System.Drawing.Size(107, 26);
            this.sheep.TabIndex = 16;
            // 
            // goat
            // 
            this.goat.Location = new System.Drawing.Point(495, 223);
            this.goat.Name = "goat";
            this.goat.ReadOnly = true;
            this.goat.Size = new System.Drawing.Size(107, 26);
            this.goat.TabIndex = 17;
            // 
            // milk
            // 
            this.milk.Location = new System.Drawing.Point(495, 269);
            this.milk.Name = "milk";
            this.milk.ReadOnly = true;
            this.milk.Size = new System.Drawing.Size(107, 26);
            this.milk.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.milk);
            this.Controls.Add(this.goat);
            this.Controls.Add(this.sheep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addAnimalBtn);
            this.Controls.Add(this.label);
            this.Controls.Add(this.goatTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sheepTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cowTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cow;
        private System.Windows.Forms.TextBox sheep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox goat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox milk;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Button addAnimalBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sheepTextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox goatTextBox;

        private System.Windows.Forms.TextBox cowTextBox;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}
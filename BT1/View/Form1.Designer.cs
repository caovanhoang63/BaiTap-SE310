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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.addAnimalBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sheep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 26);
            this.textBox1.TabIndex = 0;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(59, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 26);
            this.textBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(59, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số dê";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(59, 205);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(237, 26);
            this.textBox3.TabIndex = 4;
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
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(590, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 45);
            this.button3.TabIndex = 8;
            this.button3.Text = "Lấy sữa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.cow, this.sheep, this.goat });
            this.dataGridView1.Location = new System.Drawing.Point(403, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(563, 87);
            this.dataGridView1.TabIndex = 9;
            // 
            // cow
            // 
            this.cow.HeaderText = "Số bò";
            this.cow.Name = "cow";
            // 
            // sheep
            // 
            this.sheep.HeaderText = "Số cừu";
            this.sheep.Name = "sheep";
            // 
            // goat
            // 
            this.goat.HeaderText = "Số dê";
            this.goat.Name = "goat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addAnimalBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn cow;
        private System.Windows.Forms.DataGridViewTextBoxColumn sheep;
        private System.Windows.Forms.DataGridViewTextBoxColumn goat;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Button addAnimalBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}
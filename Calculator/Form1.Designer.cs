namespace Calculator
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
            label2 = new Label();
            txtA = new TextBox();
            btPlus = new Button();
            label1 = new Label();
            txtB = new TextBox();
            label3 = new Label();
            txtResult = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 90);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Số A";
            // 
            // txtA
            // 
            txtA.Location = new Point(417, 86);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 23);
            txtA.TabIndex = 2;
            // 
            // btPlus
            // 
            btPlus.Location = new Point(417, 280);
            btPlus.Name = "btPlus";
            btPlus.Size = new Size(75, 23);
            btPlus.TabIndex = 3;
            btPlus.Text = "Cộng";
            btPlus.UseVisualStyleBackColor = true;
            btPlus.Click += btPlus_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 147);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 1;
            label1.Text = "Số B";
            // 
            // txtB
            // 
            txtB.Location = new Point(417, 143);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 23);
            txtB.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 207);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 1;
            label3.Text = "Kết quả";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(417, 203);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(100, 23);
            txtResult.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(417, 338);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Cộng";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btPlus_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btPlus);
            Controls.Add(txtResult);
            Controls.Add(label3);
            Controls.Add(txtB);
            Controls.Add(label1);
            Controls.Add(txtA);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtA;
        private Button btPlus;
        private Label label1;
        private TextBox txtB;
        private Label label3;
        private TextBox txtResult;
        private Button button1;
    }
}
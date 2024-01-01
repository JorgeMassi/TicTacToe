namespace TicTacToeWindForm
{
    partial class TicTacToe
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            Restart = new Button();
            Timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(15, 25);
            label1.Name = "label1";
            label1.Size = new Size(187, 38);
            label1.TabIndex = 0;
            label1.Text = "Player Wins :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(336, 25);
            label2.Name = "label2";
            label2.Size = new Size(160, 38);
            label2.TabIndex = 1;
            label2.Text = "CPU Wins :";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 21.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(61, 112);
            button1.Name = "button1";
            button1.Size = new Size(135, 111);
            button1.TabIndex = 2;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Playermove;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 21.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(202, 112);
            button2.Name = "button2";
            button2.Size = new Size(135, 111);
            button2.TabIndex = 3;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Playermove;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 21.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(343, 112);
            button3.Name = "button3";
            button3.Size = new Size(135, 111);
            button3.TabIndex = 4;
            button3.Text = "?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Playermove;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 21.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(61, 229);
            button4.Name = "button4";
            button4.Size = new Size(135, 111);
            button4.TabIndex = 5;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Playermove;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 21.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(202, 229);
            button5.Name = "button5";
            button5.Size = new Size(135, 111);
            button5.TabIndex = 6;
            button5.Text = "?";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Playermove;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 21.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(343, 229);
            button6.Name = "button6";
            button6.Size = new Size(135, 111);
            button6.TabIndex = 7;
            button6.Text = "?";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Playermove;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 21.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(61, 346);
            button7.Name = "button7";
            button7.Size = new Size(135, 111);
            button7.TabIndex = 8;
            button7.Text = "?";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Playermove;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 21.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(202, 346);
            button8.Name = "button8";
            button8.Size = new Size(135, 111);
            button8.TabIndex = 9;
            button8.Text = "?";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Playermove;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 21.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(343, 346);
            button9.Name = "button9";
            button9.Size = new Size(135, 111);
            button9.TabIndex = 10;
            button9.Text = "?";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Playermove;
            // 
            // Restart
            // 
            Restart.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            Restart.Location = new Point(61, 482);
            Restart.Name = "Restart";
            Restart.Size = new Size(417, 71);
            Restart.TabIndex = 11;
            Restart.Text = "Restart";
            Restart.UseVisualStyleBackColor = true;
            Restart.Click += RestartBtn;
            // 
            // Timer
            // 
            Timer.Interval = 1000;
            Timer.Tick += CPUMove;
            // 
            // TicTacToe
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 570);
            Controls.Add(Restart);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TicTacToe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TicTacToe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button Restart;
        private System.Windows.Forms.Timer Timer;
    }
}
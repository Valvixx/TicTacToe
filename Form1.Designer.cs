using System.Windows.Forms;

namespace TicTacGame
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
            this.label3 = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WinnerLabel = new System.Windows.Forms.Label();
            this.button3_3 = new System.Windows.Forms.Button();
            this.button3_2 = new System.Windows.Forms.Button();
            this.button3_1 = new System.Windows.Forms.Button();
            this.button2_3 = new System.Windows.Forms.Button();
            this.button2_2 = new System.Windows.Forms.Button();
            this.button2_1 = new System.Windows.Forms.Button();
            this.button1_3 = new System.Windows.Forms.Button();
            this.button1_2 = new System.Windows.Forms.Button();
            this.button1_1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Unispace", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(341, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 35);
            this.label3.TabIndex = 27;
            this.label3.Text = "TicTacToe";
            // 
            // RestartButton
            // 
            this.RestartButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.RestartButton.FlatAppearance.BorderSize = 0;
            this.RestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartButton.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartButton.ForeColor = System.Drawing.Color.White;
            this.RestartButton.Location = new System.Drawing.Point(347, 229);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(172, 100);
            this.RestartButton.TabIndex = 26;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(431, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "by Valvixx";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Unispace", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(339, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 44);
            this.label2.TabIndex = 24;
            this.label2.Text = "Winner:";
            // 
            // WinnerLabel
            // 
            this.WinnerLabel.AutoSize = true;
            this.WinnerLabel.BackColor = System.Drawing.Color.Transparent;
            this.WinnerLabel.Font = new System.Drawing.Font("Unispace", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinnerLabel.ForeColor = System.Drawing.Color.White;
            this.WinnerLabel.Location = new System.Drawing.Point(339, 163);
            this.WinnerLabel.Name = "WinnerLabel";
            this.WinnerLabel.Size = new System.Drawing.Size(0, 44);
            this.WinnerLabel.TabIndex = 23;
            // 
            // button3_3
            // 
            this.button3_3.BackColor = System.Drawing.Color.Indigo;
            this.button3_3.FlatAppearance.BorderSize = 0;
            this.button3_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3_3.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3_3.ForeColor = System.Drawing.Color.White;
            this.button3_3.Location = new System.Drawing.Point(229, 229);
            this.button3_3.Margin = new System.Windows.Forms.Padding(0);
            this.button3_3.Name = "button3_3";
            this.button3_3.Size = new System.Drawing.Size(100, 100);
            this.button3_3.TabIndex = 22;
            this.button3_3.UseVisualStyleBackColor = false;
            this.button3_3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button3_2
            // 
            this.button3_2.BackColor = System.Drawing.Color.Indigo;
            this.button3_2.FlatAppearance.BorderSize = 0;
            this.button3_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3_2.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3_2.ForeColor = System.Drawing.Color.White;
            this.button3_2.Location = new System.Drawing.Point(119, 229);
            this.button3_2.Margin = new System.Windows.Forms.Padding(0);
            this.button3_2.Name = "button3_2";
            this.button3_2.Size = new System.Drawing.Size(100, 100);
            this.button3_2.TabIndex = 21;
            this.button3_2.UseVisualStyleBackColor = false;
            this.button3_2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button3_1
            // 
            this.button3_1.BackColor = System.Drawing.Color.Indigo;
            this.button3_1.FlatAppearance.BorderSize = 0;
            this.button3_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3_1.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3_1.ForeColor = System.Drawing.Color.White;
            this.button3_1.Location = new System.Drawing.Point(9, 229);
            this.button3_1.Margin = new System.Windows.Forms.Padding(0);
            this.button3_1.Name = "button3_1";
            this.button3_1.Size = new System.Drawing.Size(100, 100);
            this.button3_1.TabIndex = 20;
            this.button3_1.UseVisualStyleBackColor = false;
            this.button3_1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button2_3
            // 
            this.button2_3.BackColor = System.Drawing.Color.Indigo;
            this.button2_3.FlatAppearance.BorderSize = 0;
            this.button2_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_3.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2_3.ForeColor = System.Drawing.Color.White;
            this.button2_3.Location = new System.Drawing.Point(229, 119);
            this.button2_3.Margin = new System.Windows.Forms.Padding(0);
            this.button2_3.Name = "button2_3";
            this.button2_3.Size = new System.Drawing.Size(100, 100);
            this.button2_3.TabIndex = 19;
            this.button2_3.UseVisualStyleBackColor = false;
            this.button2_3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button2_2
            // 
            this.button2_2.BackColor = System.Drawing.Color.Indigo;
            this.button2_2.FlatAppearance.BorderSize = 0;
            this.button2_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_2.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2_2.ForeColor = System.Drawing.Color.White;
            this.button2_2.Location = new System.Drawing.Point(119, 119);
            this.button2_2.Margin = new System.Windows.Forms.Padding(0);
            this.button2_2.Name = "button2_2";
            this.button2_2.Size = new System.Drawing.Size(100, 100);
            this.button2_2.TabIndex = 18;
            this.button2_2.UseVisualStyleBackColor = false;
            this.button2_2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button2_1
            // 
            this.button2_1.BackColor = System.Drawing.Color.Indigo;
            this.button2_1.FlatAppearance.BorderSize = 0;
            this.button2_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_1.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2_1.ForeColor = System.Drawing.Color.White;
            this.button2_1.Location = new System.Drawing.Point(9, 119);
            this.button2_1.Margin = new System.Windows.Forms.Padding(0);
            this.button2_1.Name = "button2_1";
            this.button2_1.Size = new System.Drawing.Size(100, 100);
            this.button2_1.TabIndex = 17;
            this.button2_1.UseVisualStyleBackColor = false;
            this.button2_1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button1_3
            // 
            this.button1_3.BackColor = System.Drawing.Color.Indigo;
            this.button1_3.FlatAppearance.BorderSize = 0;
            this.button1_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_3.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_3.ForeColor = System.Drawing.Color.White;
            this.button1_3.Location = new System.Drawing.Point(229, 9);
            this.button1_3.Margin = new System.Windows.Forms.Padding(0);
            this.button1_3.Name = "button1_3";
            this.button1_3.Size = new System.Drawing.Size(100, 100);
            this.button1_3.TabIndex = 16;
            this.button1_3.UseVisualStyleBackColor = false;
            this.button1_3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button1_2
            // 
            this.button1_2.BackColor = System.Drawing.Color.Indigo;
            this.button1_2.FlatAppearance.BorderSize = 0;
            this.button1_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_2.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_2.ForeColor = System.Drawing.Color.White;
            this.button1_2.Location = new System.Drawing.Point(119, 9);
            this.button1_2.Margin = new System.Windows.Forms.Padding(0);
            this.button1_2.Name = "button1_2";
            this.button1_2.Size = new System.Drawing.Size(100, 100);
            this.button1_2.TabIndex = 15;
            this.button1_2.UseVisualStyleBackColor = false;
            this.button1_2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button1_1
            // 
            this.button1_1.BackColor = System.Drawing.Color.Indigo;
            this.button1_1.FlatAppearance.BorderSize = 0;
            this.button1_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_1.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_1.ForeColor = System.Drawing.Color.White;
            this.button1_1.Location = new System.Drawing.Point(9, 9);
            this.button1_1.Margin = new System.Windows.Forms.Padding(0);
            this.button1_1.Name = "button1_1";
            this.button1_1.Size = new System.Drawing.Size(100, 100);
            this.button1_1.TabIndex = 14;
            this.button1_1.UseVisualStyleBackColor = false;
            this.button1_1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(529, 339);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WinnerLabel);
            this.Controls.Add(this.button3_3);
            this.Controls.Add(this.button3_2);
            this.Controls.Add(this.button3_1);
            this.Controls.Add(this.button2_3);
            this.Controls.Add(this.button2_2);
            this.Controls.Add(this.button2_1);
            this.Controls.Add(this.button1_3);
            this.Controls.Add(this.button1_2);
            this.Controls.Add(this.button1_1);
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Button RestartButton;
        private Label label1;
        private Label label2;
        private Label WinnerLabel;
        private Button button3_3;
        private Button button3_2;
        private Button button3_1;
        private Button button2_3;
        private Button button2_2;
        private Button button2_1;
        private Button button1_3;
        private Button button1_2;
        private Button button1_1;
    }
}


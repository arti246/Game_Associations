
namespace MyGame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_star = new System.Windows.Forms.PictureBox();
            this.label_count_coin = new System.Windows.Forms.Label();
            this.label_stars3 = new System.Windows.Forms.Label();
            this.label_stars2 = new System.Windows.Forms.Label();
            this.label_stars1 = new System.Windows.Forms.Label();
            this.pictureBox_coin = new System.Windows.Forms.PictureBox();
            this.button_Level1 = new System.Windows.Forms.Button();
            this.button_Level2 = new System.Windows.Forms.Button();
            this.button_Level3 = new System.Windows.Forms.Button();
            this.button_Level4 = new System.Windows.Forms.Button();
            this.button_Level5 = new System.Windows.Forms.Button();
            this.button_Level9 = new System.Windows.Forms.Button();
            this.button_Level6 = new System.Windows.Forms.Button();
            this.button_Level7 = new System.Windows.Forms.Button();
            this.button_Level8 = new System.Windows.Forms.Button();
            this.button_Level10 = new System.Windows.Forms.Button();
            this.button_Level11 = new System.Windows.Forms.Button();
            this.button_Level12 = new System.Windows.Forms.Button();
            this.buttonON = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_star)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_coin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.buttonON);
            this.panel1.Controls.Add(this.pictureBox_star);
            this.panel1.Controls.Add(this.label_count_coin);
            this.panel1.Controls.Add(this.label_stars3);
            this.panel1.Controls.Add(this.label_stars2);
            this.panel1.Controls.Add(this.label_stars1);
            this.panel1.Controls.Add(this.pictureBox_coin);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 134);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox_star
            // 
            this.pictureBox_star.Image = global::MyGame.Properties.Resources.star;
            this.pictureBox_star.Location = new System.Drawing.Point(487, 5);
            this.pictureBox_star.Name = "pictureBox_star";
            this.pictureBox_star.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_star.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_star.TabIndex = 2;
            this.pictureBox_star.TabStop = false;
            // 
            // label_count_coin
            // 
            this.label_count_coin.AutoSize = true;
            this.label_count_coin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_count_coin.ForeColor = System.Drawing.SystemColors.Control;
            this.label_count_coin.Location = new System.Drawing.Point(457, 70);
            this.label_count_coin.Name = "label_count_coin";
            this.label_count_coin.Size = new System.Drawing.Size(24, 26);
            this.label_count_coin.TabIndex = 5;
            this.label_count_coin.Text = "0";
            // 
            // label_stars3
            // 
            this.label_stars3.AutoSize = true;
            this.label_stars3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_stars3.ForeColor = System.Drawing.SystemColors.Control;
            this.label_stars3.Location = new System.Drawing.Point(445, 14);
            this.label_stars3.Name = "label_stars3";
            this.label_stars3.Size = new System.Drawing.Size(36, 26);
            this.label_stars3.TabIndex = 4;
            this.label_stars3.Text = "12";
            // 
            // label_stars2
            // 
            this.label_stars2.AutoSize = true;
            this.label_stars2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_stars2.ForeColor = System.Drawing.SystemColors.Control;
            this.label_stars2.Location = new System.Drawing.Point(433, 14);
            this.label_stars2.Name = "label_stars2";
            this.label_stars2.Size = new System.Drawing.Size(18, 26);
            this.label_stars2.TabIndex = 3;
            this.label_stars2.Text = "/";
            // 
            // label_stars1
            // 
            this.label_stars1.AutoSize = true;
            this.label_stars1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_stars1.ForeColor = System.Drawing.SystemColors.Control;
            this.label_stars1.Location = new System.Drawing.Point(415, 14);
            this.label_stars1.Name = "label_stars1";
            this.label_stars1.Size = new System.Drawing.Size(24, 26);
            this.label_stars1.TabIndex = 2;
            this.label_stars1.Text = "0";
            // 
            // pictureBox_coin
            // 
            this.pictureBox_coin.Image = global::MyGame.Properties.Resources.coin;
            this.pictureBox_coin.Location = new System.Drawing.Point(487, 56);
            this.pictureBox_coin.Name = "pictureBox_coin";
            this.pictureBox_coin.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_coin.TabIndex = 1;
            this.pictureBox_coin.TabStop = false;
            // 
            // button_Level1
            // 
            this.button_Level1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.button_Level1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Level1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.button_Level1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.button_Level1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Level1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Level1.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Level1.Location = new System.Drawing.Point(21, 156);
            this.button_Level1.Name = "button_Level1";
            this.button_Level1.Size = new System.Drawing.Size(91, 83);
            this.button_Level1.TabIndex = 1;
            this.button_Level1.Text = "1";
            this.button_Level1.UseVisualStyleBackColor = false;
            this.button_Level1.Click += new System.EventHandler(this.button_Level1_Click);
            // 
            // button_Level2
            // 
            this.button_Level2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_Level2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Level2.Enabled = false;
            this.button_Level2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.button_Level2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Level2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Level2.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Level2.Image = global::MyGame.Properties.Resources.замок;
            this.button_Level2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_Level2.Location = new System.Drawing.Point(155, 156);
            this.button_Level2.Name = "button_Level2";
            this.button_Level2.Size = new System.Drawing.Size(91, 83);
            this.button_Level2.TabIndex = 4;
            this.button_Level2.Text = "2";
            this.button_Level2.UseVisualStyleBackColor = false;
            this.button_Level2.Click += new System.EventHandler(this.button_Level2_Click);
            // 
            // button_Level3
            // 
            this.button_Level3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_Level3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Level3.Enabled = false;
            this.button_Level3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.button_Level3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Level3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Level3.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Level3.Image = global::MyGame.Properties.Resources.замок;
            this.button_Level3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_Level3.Location = new System.Drawing.Point(287, 156);
            this.button_Level3.Name = "button_Level3";
            this.button_Level3.Size = new System.Drawing.Size(91, 83);
            this.button_Level3.TabIndex = 5;
            this.button_Level3.Text = "3";
            this.button_Level3.UseVisualStyleBackColor = false;
            this.button_Level3.Click += new System.EventHandler(this.button_Level3_Click);
            // 
            // button_Level4
            // 
            this.button_Level4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_Level4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Level4.Enabled = false;
            this.button_Level4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.button_Level4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Level4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Level4.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Level4.Image = global::MyGame.Properties.Resources.замок;
            this.button_Level4.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_Level4.Location = new System.Drawing.Point(417, 156);
            this.button_Level4.Name = "button_Level4";
            this.button_Level4.Size = new System.Drawing.Size(91, 83);
            this.button_Level4.TabIndex = 6;
            this.button_Level4.Text = "4";
            this.button_Level4.UseVisualStyleBackColor = false;
            this.button_Level4.Click += new System.EventHandler(this.button_Level4_Click);
            // 
            // button_Level5
            // 
            this.button_Level5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_Level5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Level5.Enabled = false;
            this.button_Level5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.button_Level5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Level5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Level5.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Level5.Image = global::MyGame.Properties.Resources.замок;
            this.button_Level5.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_Level5.Location = new System.Drawing.Point(21, 280);
            this.button_Level5.Name = "button_Level5";
            this.button_Level5.Size = new System.Drawing.Size(91, 83);
            this.button_Level5.TabIndex = 7;
            this.button_Level5.Text = "5";
            this.button_Level5.UseVisualStyleBackColor = false;
            this.button_Level5.Click += new System.EventHandler(this.button_Level5_Click);
            // 
            // button_Level9
            // 
            this.button_Level9.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_Level9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Level9.Enabled = false;
            this.button_Level9.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.button_Level9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Level9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Level9.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Level9.Image = global::MyGame.Properties.Resources.замок;
            this.button_Level9.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_Level9.Location = new System.Drawing.Point(21, 401);
            this.button_Level9.Name = "button_Level9";
            this.button_Level9.Size = new System.Drawing.Size(91, 83);
            this.button_Level9.TabIndex = 8;
            this.button_Level9.Text = "9";
            this.button_Level9.UseVisualStyleBackColor = false;
            this.button_Level9.Click += new System.EventHandler(this.button_Level9_Click);
            // 
            // button_Level6
            // 
            this.button_Level6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_Level6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Level6.Enabled = false;
            this.button_Level6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.button_Level6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Level6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Level6.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Level6.Image = global::MyGame.Properties.Resources.замок;
            this.button_Level6.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_Level6.Location = new System.Drawing.Point(155, 280);
            this.button_Level6.Name = "button_Level6";
            this.button_Level6.Size = new System.Drawing.Size(91, 83);
            this.button_Level6.TabIndex = 9;
            this.button_Level6.Text = "6";
            this.button_Level6.UseVisualStyleBackColor = false;
            this.button_Level6.Click += new System.EventHandler(this.button_Level6_Click);
            // 
            // button_Level7
            // 
            this.button_Level7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_Level7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Level7.Enabled = false;
            this.button_Level7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.button_Level7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Level7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Level7.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Level7.Image = global::MyGame.Properties.Resources.замок;
            this.button_Level7.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_Level7.Location = new System.Drawing.Point(287, 280);
            this.button_Level7.Name = "button_Level7";
            this.button_Level7.Size = new System.Drawing.Size(91, 83);
            this.button_Level7.TabIndex = 10;
            this.button_Level7.Text = "7";
            this.button_Level7.UseVisualStyleBackColor = false;
            this.button_Level7.Click += new System.EventHandler(this.button_Level7_Click);
            // 
            // button_Level8
            // 
            this.button_Level8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_Level8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Level8.Enabled = false;
            this.button_Level8.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.button_Level8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Level8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Level8.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Level8.Image = global::MyGame.Properties.Resources.замок;
            this.button_Level8.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_Level8.Location = new System.Drawing.Point(417, 280);
            this.button_Level8.Name = "button_Level8";
            this.button_Level8.Size = new System.Drawing.Size(91, 83);
            this.button_Level8.TabIndex = 11;
            this.button_Level8.Text = "8";
            this.button_Level8.UseVisualStyleBackColor = false;
            this.button_Level8.Click += new System.EventHandler(this.button_Level8_Click);
            // 
            // button_Level10
            // 
            this.button_Level10.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_Level10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Level10.Enabled = false;
            this.button_Level10.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.button_Level10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Level10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Level10.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Level10.Image = global::MyGame.Properties.Resources.замок;
            this.button_Level10.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_Level10.Location = new System.Drawing.Point(155, 401);
            this.button_Level10.Name = "button_Level10";
            this.button_Level10.Size = new System.Drawing.Size(91, 83);
            this.button_Level10.TabIndex = 12;
            this.button_Level10.Text = "10";
            this.button_Level10.UseVisualStyleBackColor = false;
            this.button_Level10.Click += new System.EventHandler(this.button_Level10_Click);
            // 
            // button_Level11
            // 
            this.button_Level11.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_Level11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Level11.Enabled = false;
            this.button_Level11.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.button_Level11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Level11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Level11.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Level11.Image = global::MyGame.Properties.Resources.замок;
            this.button_Level11.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_Level11.Location = new System.Drawing.Point(287, 401);
            this.button_Level11.Name = "button_Level11";
            this.button_Level11.Size = new System.Drawing.Size(91, 83);
            this.button_Level11.TabIndex = 13;
            this.button_Level11.Text = "11";
            this.button_Level11.UseVisualStyleBackColor = false;
            this.button_Level11.Click += new System.EventHandler(this.button_Level11_Click);
            // 
            // button_Level12
            // 
            this.button_Level12.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_Level12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Level12.Enabled = false;
            this.button_Level12.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.button_Level12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Level12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Level12.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Level12.Image = global::MyGame.Properties.Resources.замок;
            this.button_Level12.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_Level12.Location = new System.Drawing.Point(417, 401);
            this.button_Level12.Name = "button_Level12";
            this.button_Level12.Size = new System.Drawing.Size(91, 83);
            this.button_Level12.TabIndex = 14;
            this.button_Level12.Text = "12";
            this.button_Level12.UseVisualStyleBackColor = false;
            this.button_Level12.Click += new System.EventHandler(this.button_Level12_Click);
            // 
            // buttonON
            // 
            this.buttonON.Location = new System.Drawing.Point(0, 91);
            this.buttonON.Name = "buttonON";
            this.buttonON.Size = new System.Drawing.Size(51, 43);
            this.buttonON.TabIndex = 6;
            this.buttonON.Text = "ON";
            this.buttonON.UseVisualStyleBackColor = true;
            this.buttonON.Click += new System.EventHandler(this.buttonON_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(539, 515);
            this.Controls.Add(this.button_Level12);
            this.Controls.Add(this.button_Level11);
            this.Controls.Add(this.button_Level10);
            this.Controls.Add(this.button_Level8);
            this.Controls.Add(this.button_Level7);
            this.Controls.Add(this.button_Level6);
            this.Controls.Add(this.button_Level9);
            this.Controls.Add(this.button_Level5);
            this.Controls.Add(this.button_Level4);
            this.Controls.Add(this.button_Level3);
            this.Controls.Add(this.button_Level2);
            this.Controls.Add(this.button_Level1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра на ассоциации";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_star)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_coin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_coin;
        private System.Windows.Forms.Label label_count_coin;
        private System.Windows.Forms.Label label_stars3;
        private System.Windows.Forms.Label label_stars2;
        private System.Windows.Forms.Label label_stars1;
        private System.Windows.Forms.Button button_Level1;
        private System.Windows.Forms.PictureBox pictureBox_star;
        private System.Windows.Forms.Button button_Level2;
        private System.Windows.Forms.Button button_Level3;
        private System.Windows.Forms.Button button_Level4;
        private System.Windows.Forms.Button button_Level5;
        private System.Windows.Forms.Button button_Level9;
        private System.Windows.Forms.Button button_Level6;
        private System.Windows.Forms.Button button_Level7;
        private System.Windows.Forms.Button button_Level8;
        private System.Windows.Forms.Button button_Level10;
        private System.Windows.Forms.Button button_Level11;
        private System.Windows.Forms.Button button_Level12;
        private System.Windows.Forms.Button buttonON;
    }
}


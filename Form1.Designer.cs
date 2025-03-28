namespace hangManGame
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
            this.components = new System.ComponentModel.Container();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.usedLetters = new DevExpress.XtraEditors.LabelControl();
            this.guessedWord = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnLetterBox = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuessBox = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guessBox = new DevExpress.XtraEditors.TextEdit();
            this.letterBox = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guessBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letterBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("YouYuan", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(54, 337);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(165, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Used Letters : ";
            // 
            // usedLetters
            // 
            this.usedLetters.Location = new System.Drawing.Point(225, 341);
            this.usedLetters.Name = "usedLetters";
            this.usedLetters.Size = new System.Drawing.Size(27, 16);
            this.usedLetters.TabIndex = 1;
            this.usedLetters.Text = "used";
            // 
            // guessedWord
            // 
            this.guessedWord.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessedWord.Appearance.Options.UseFont = true;
            this.guessedWord.Location = new System.Drawing.Point(12, 414);
            this.guessedWord.Name = "guessedWord";
            this.guessedWord.Size = new System.Drawing.Size(102, 36);
            this.guessedWord.TabIndex = 3;
            this.guessedWord.Text = "H e l l o";
            this.guessedWord.Click += new System.EventHandler(this.guessedWord_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(3, 7);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(178, 26);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Category : Animals";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 40);
            this.panel1.TabIndex = 5;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButton1.Location = new System.Drawing.Point(867, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(47, 40);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "X";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(27, 483);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(111, 22);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Enter a Letter";
            // 
            // btnLetterBox
            // 
            this.btnLetterBox.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btnLetterBox.Appearance.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetterBox.Appearance.Options.UseBackColor = true;
            this.btnLetterBox.Appearance.Options.UseFont = true;
            this.btnLetterBox.Location = new System.Drawing.Point(211, 514);
            this.btnLetterBox.Name = "btnLetterBox";
            this.btnLetterBox.Size = new System.Drawing.Size(51, 31);
            this.btnLetterBox.TabIndex = 8;
            this.btnLetterBox.Text = "Go";
            this.btnLetterBox.Click += new System.EventHandler(this.btnLetterBox_Click);
            // 
            // btnGuessBox
            // 
            this.btnGuessBox.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnGuessBox.Appearance.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuessBox.Appearance.Options.UseBackColor = true;
            this.btnGuessBox.Appearance.Options.UseFont = true;
            this.btnGuessBox.Location = new System.Drawing.Point(311, 609);
            this.btnGuessBox.Name = "btnGuessBox";
            this.btnGuessBox.Size = new System.Drawing.Size(72, 31);
            this.btnGuessBox.TabIndex = 11;
            this.btnGuessBox.Text = "Guess";
            this.btnGuessBox.Click += new System.EventHandler(this.btnGuessBox_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(27, 585);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(129, 22);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Guess the Word";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(468, 614);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(55, 26);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Timer";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(445, 639);
            this.progressBar.Maximum = 60;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(457, 31);
            this.progressBar.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::hangManGame.Properties.Resources._7;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(445, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(457, 528);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // guessBox
            // 
            this.guessBox.Location = new System.Drawing.Point(53, 608);
            this.guessBox.Name = "guessBox";
            this.guessBox.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessBox.Properties.Appearance.Options.UseFont = true;
            this.guessBox.Properties.MaxLength = 25;
            this.guessBox.Properties.Padding = new System.Windows.Forms.Padding(2);
            this.guessBox.Size = new System.Drawing.Size(252, 32);
            this.guessBox.TabIndex = 10;
            this.guessBox.Click += new System.EventHandler(this.guessBox_Click);
            // 
            // letterBox
            // 
            this.letterBox.EditValue = "";
            this.letterBox.Location = new System.Drawing.Point(53, 511);
            this.letterBox.Name = "letterBox";
            this.letterBox.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterBox.Properties.Appearance.Options.UseFont = true;
            this.letterBox.Properties.Appearance.Options.UseTextOptions = true;
            this.letterBox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.letterBox.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.letterBox.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.letterBox.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.letterBox.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.letterBox.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.letterBox.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.letterBox.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.letterBox.Properties.MaxLength = 1;
            this.letterBox.Size = new System.Drawing.Size(151, 34);
            this.letterBox.TabIndex = 7;
            this.letterBox.Click += new System.EventHandler(this.letterBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(27, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(914, 706);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.btnGuessBox);
            this.Controls.Add(this.guessBox);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.btnLetterBox);
            this.Controls.Add(this.letterBox);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guessedWord);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.usedLetters);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guessBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letterBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl usedLetters;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl guessedWord;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit letterBox;
        private DevExpress.XtraEditors.SimpleButton btnLetterBox;
        private DevExpress.XtraEditors.SimpleButton btnGuessBox;
        private DevExpress.XtraEditors.TextEdit guessBox;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


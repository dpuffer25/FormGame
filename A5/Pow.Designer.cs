namespace FormGame
{
    partial class PowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PowForm));
            this.targetPictureBox = new System.Windows.Forms.PictureBox();
            this.targetTimer = new System.Windows.Forms.Timer(this.components);
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.bulletPictureBox = new System.Windows.Forms.PictureBox();
            this.fireButton = new System.Windows.Forms.Button();
            this.bulletTimer = new System.Windows.Forms.Timer(this.components);
            this.powPrefixLabel = new System.Windows.Forms.Label();
            this.powSuffixLabel = new System.Windows.Forms.Label();
            this.powTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.targetPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // targetPictureBox
            // 
            this.targetPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.targetPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.targetPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("targetPictureBox.Image")));
            this.targetPictureBox.ImageLocation = "";
            this.targetPictureBox.Location = new System.Drawing.Point(36, 52);
            this.targetPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.targetPictureBox.Name = "targetPictureBox";
            this.targetPictureBox.Size = new System.Drawing.Size(60, 62);
            this.targetPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.targetPictureBox.TabIndex = 0;
            this.targetPictureBox.TabStop = false;
            this.targetPictureBox.Visible = false;
            // 
            // targetTimer
            // 
            this.targetTimer.Tick += new System.EventHandler(this.targetTimer_Tick);
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(18, 571);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(112, 35);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            this.startButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PowForm_KeyPress);
            this.startButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PowForm_KeyUp);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.Yellow;
            this.statusLabel.Location = new System.Drawing.Point(580, 558);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(70, 48);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "60";
            this.statusLabel.Visible = false;
            // 
            // bulletPictureBox
            // 
            this.bulletPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.bulletPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("bulletPictureBox.Image")));
            this.bulletPictureBox.ImageLocation = "";
            this.bulletPictureBox.InitialImage = null;
            this.bulletPictureBox.Location = new System.Drawing.Point(624, 385);
            this.bulletPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bulletPictureBox.Name = "bulletPictureBox";
            this.bulletPictureBox.Size = new System.Drawing.Size(30, 62);
            this.bulletPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulletPictureBox.TabIndex = 3;
            this.bulletPictureBox.TabStop = false;
            this.bulletPictureBox.Visible = false;
            // 
            // fireButton
            // 
            this.fireButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fireButton.BackgroundImage")));
            this.fireButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fireButton.Location = new System.Drawing.Point(590, 443);
            this.fireButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fireButton.Name = "fireButton";
            this.fireButton.Size = new System.Drawing.Size(100, 106);
            this.fireButton.TabIndex = 4;
            this.fireButton.UseVisualStyleBackColor = true;
            this.fireButton.Visible = false;
            this.fireButton.Click += new System.EventHandler(this.fireButton_Click);
            this.fireButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PowForm_KeyPress);
            // 
            // bulletTimer
            // 
            this.bulletTimer.Interval = 10;
            this.bulletTimer.Tick += new System.EventHandler(this.bulletTimer_Tick);
            // 
            // powPrefixLabel
            // 
            this.powPrefixLabel.AutoSize = true;
            this.powPrefixLabel.BackColor = System.Drawing.Color.Transparent;
            this.powPrefixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powPrefixLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.powPrefixLabel.Location = new System.Drawing.Point(729, 434);
            this.powPrefixLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.powPrefixLabel.Name = "powPrefixLabel";
            this.powPrefixLabel.Size = new System.Drawing.Size(19, 20);
            this.powPrefixLabel.TabIndex = 5;
            this.powPrefixLabel.Text = "0";
            this.powPrefixLabel.Visible = false;
            // 
            // powSuffixLabel
            // 
            this.powSuffixLabel.AutoSize = true;
            this.powSuffixLabel.BackColor = System.Drawing.Color.Transparent;
            this.powSuffixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powSuffixLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.powSuffixLabel.Location = new System.Drawing.Point(758, 434);
            this.powSuffixLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.powSuffixLabel.Name = "powSuffixLabel";
            this.powSuffixLabel.Size = new System.Drawing.Size(60, 20);
            this.powSuffixLabel.TabIndex = 7;
            this.powSuffixLabel.Text = "Pows!";
            this.powSuffixLabel.Visible = false;
            // 
            // powTimer
            // 
            this.powTimer.Interval = 5;
            this.powTimer.Tick += new System.EventHandler(this.powTimer_Tick);
            // 
            // PowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(846, 625);
            this.Controls.Add(this.targetPictureBox);
            this.Controls.Add(this.powSuffixLabel);
            this.Controls.Add(this.powPrefixLabel);
            this.Controls.Add(this.fireButton);
            this.Controls.Add(this.bulletPictureBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pow!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PowForm_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PowForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.targetPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox targetPictureBox;
        private System.Windows.Forms.Timer targetTimer;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.PictureBox bulletPictureBox;
        private System.Windows.Forms.Button fireButton;
        private System.Windows.Forms.Timer bulletTimer;
        private System.Windows.Forms.Label powPrefixLabel;
        private System.Windows.Forms.Label powSuffixLabel;
        private System.Windows.Forms.Timer powTimer;
    }
}


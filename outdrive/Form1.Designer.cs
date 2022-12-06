
namespace outdrive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleScreen = new System.Windows.Forms.PictureBox();
            this.PlayB = new System.Windows.Forms.Button();
            this.HSB = new System.Windows.Forms.Button();
            this.QuitB = new System.Windows.Forms.Button();
            this.HSBox = new System.Windows.Forms.ListBox();
            this.cheatc = new System.Windows.Forms.TextBox();
            this.cheatList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.titleScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // titleScreen
            // 
            this.titleScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleScreen.ImageLocation = "../../Textures/menu-back.png";
            this.titleScreen.Location = new System.Drawing.Point(0, 0);
            this.titleScreen.Name = "titleScreen";
            this.titleScreen.Size = new System.Drawing.Size(800, 450);
            this.titleScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titleScreen.TabIndex = 0;
            this.titleScreen.TabStop = false;
            // 
            // PlayB
            // 
            this.PlayB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayB.AutoSize = true;
            this.PlayB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PlayB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PlayB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PlayB.FlatAppearance.BorderSize = 0;
            this.PlayB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayB.Image = ((System.Drawing.Image)(resources.GetObject("PlayB.Image")));
            this.PlayB.Location = new System.Drawing.Point(12, 198);
            this.PlayB.Margin = new System.Windows.Forms.Padding(0);
            this.PlayB.Name = "PlayB";
            this.PlayB.Size = new System.Drawing.Size(305, 65);
            this.PlayB.TabIndex = 1;
            this.PlayB.UseVisualStyleBackColor = false;
            this.PlayB.Click += new System.EventHandler(this.PlayB_Click);
            // 
            // HSB
            // 
            this.HSB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HSB.AutoSize = true;
            this.HSB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HSB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HSB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HSB.FlatAppearance.BorderSize = 0;
            this.HSB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HSB.Image = ((System.Drawing.Image)(resources.GetObject("HSB.Image")));
            this.HSB.Location = new System.Drawing.Point(12, 262);
            this.HSB.Margin = new System.Windows.Forms.Padding(0);
            this.HSB.Name = "HSB";
            this.HSB.Size = new System.Drawing.Size(305, 65);
            this.HSB.TabIndex = 2;
            this.HSB.UseVisualStyleBackColor = false;
            this.HSB.Click += new System.EventHandler(this.HSB_Click);
            // 
            // QuitB
            // 
            this.QuitB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.QuitB.AutoSize = true;
            this.QuitB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.QuitB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.QuitB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.QuitB.FlatAppearance.BorderSize = 0;
            this.QuitB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitB.Image = ((System.Drawing.Image)(resources.GetObject("QuitB.Image")));
            this.QuitB.Location = new System.Drawing.Point(12, 326);
            this.QuitB.Margin = new System.Windows.Forms.Padding(0);
            this.QuitB.Name = "QuitB";
            this.QuitB.Size = new System.Drawing.Size(164, 56);
            this.QuitB.TabIndex = 3;
            this.QuitB.UseVisualStyleBackColor = false;
            this.QuitB.Click += new System.EventHandler(this.QuitB_Click);
            // 
            // HSBox
            // 
            this.HSBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HSBox.BackColor = System.Drawing.Color.Gray;
            this.HSBox.Font = new System.Drawing.Font("Comic Sans MS", 16F);
            this.HSBox.FormattingEnabled = true;
            this.HSBox.ItemHeight = 45;
            this.HSBox.Location = new System.Drawing.Point(126, -44);
            this.HSBox.Name = "HSBox";
            this.HSBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.HSBox.Size = new System.Drawing.Size(662, 454);
            this.HSBox.TabIndex = 4;
            this.HSBox.Visible = false;
            // 
            // cheatc
            // 
            this.cheatc.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheatc.Location = new System.Drawing.Point(-1, 171);
            this.cheatc.Name = "cheatc";
            this.cheatc.Size = new System.Drawing.Size(318, 63);
            this.cheatc.TabIndex = 5;
            this.cheatc.Visible = false;
            this.cheatc.TextChanged += new System.EventHandler(this.cheatc_TextChanged);
            // 
            // cheatList
            // 
            this.cheatList.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cheatList.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheatList.FormattingEnabled = true;
            this.cheatList.ItemHeight = 29;
            this.cheatList.Location = new System.Drawing.Point(0, 0);
            this.cheatList.Name = "cheatList";
            this.cheatList.Size = new System.Drawing.Size(164, 149);
            this.cheatList.TabIndex = 6;
            this.cheatList.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.cheatList);
            this.Controls.Add(this.cheatc);
            this.Controls.Add(this.HSBox);
            this.Controls.Add(this.QuitB);
            this.Controls.Add(this.HSB);
            this.Controls.Add(this.PlayB);
            this.Controls.Add(this.titleScreen);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "|---[  Outdrive  ]---|";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.titleScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox titleScreen;
        private System.Windows.Forms.Button PlayB;
        private System.Windows.Forms.Button HSB;
        private System.Windows.Forms.Button QuitB;
        private System.Windows.Forms.ListBox HSBox;
        private System.Windows.Forms.TextBox cheatc;
        private System.Windows.Forms.ListBox cheatList;
    }
}


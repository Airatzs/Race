namespace Race
{
    partial class Form_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.button_start = new System.Windows.Forms.Button();
            this.button_settings = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_help = new System.Windows.Forms.Button();
            this.label_help = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.checkBox_audio = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.Salmon;
            this.button_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_start.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_start.Location = new System.Drawing.Point(346, 170);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(100, 30);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "Start game";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_settings
            // 
            this.button_settings.BackColor = System.Drawing.Color.Salmon;
            this.button_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_settings.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_settings.Location = new System.Drawing.Point(346, 206);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(100, 30);
            this.button_settings.TabIndex = 2;
            this.button_settings.Text = "Settings";
            this.button_settings.UseVisualStyleBackColor = false;
            this.button_settings.Click += new System.EventHandler(this.button_settings_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.Salmon;
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_exit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_exit.Location = new System.Drawing.Point(346, 278);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(100, 30);
            this.button_exit.TabIndex = 3;
            this.button_exit.Text = "Exit game";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_help
            // 
            this.button_help.BackColor = System.Drawing.Color.Salmon;
            this.button_help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_help.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_help.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_help.Location = new System.Drawing.Point(346, 242);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(100, 30);
            this.button_help.TabIndex = 4;
            this.button_help.Text = "How to play";
            this.button_help.UseVisualStyleBackColor = false;
            this.button_help.Click += new System.EventHandler(this.button_help_Click);
            // 
            // label_help
            // 
            this.label_help.AutoSize = true;
            this.label_help.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_help.Location = new System.Drawing.Point(122, 157);
            this.label_help.Name = "label_help";
            this.label_help.Size = new System.Drawing.Size(555, 115);
            this.label_help.TabIndex = 5;
            this.label_help.Text = "You have to avoid hitting an enemy car\r\nUse WASD to navigate your car\r\nTry to sco" +
    "re as much as you can\r\nPress SPACE to put a game into pause\r\nYou can change the " +
    "color or speed of your car in settings";
            this.label_help.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_help.Visible = false;
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.Color.Salmon;
            this.button_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ok.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ok.Location = new System.Drawing.Point(346, 278);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(100, 30);
            this.button_ok.TabIndex = 6;
            this.button_ok.Text = "Got it!";
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Visible = false;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // checkBox_audio
            // 
            this.checkBox_audio.AutoSize = true;
            this.checkBox_audio.BackColor = System.Drawing.Color.SteelBlue;
            this.checkBox_audio.Checked = true;
            this.checkBox_audio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_audio.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_audio.Location = new System.Drawing.Point(702, 420);
            this.checkBox_audio.Name = "checkBox_audio";
            this.checkBox_audio.Size = new System.Drawing.Size(86, 18);
            this.checkBox_audio.TabIndex = 7;
            this.checkBox_audio.Text = "Sound on";
            this.checkBox_audio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_audio.UseVisualStyleBackColor = false;
            this.checkBox_audio.CheckedChanged += new System.EventHandler(this.checkBox_audio_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Race.Properties.Resources.background_main;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox_audio);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label_help);
            this.Controls.Add(this.button_help);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_settings);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_main";
            this.Load += new System.EventHandler(this.Form_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_help;
        private System.Windows.Forms.Label label_help;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.CheckBox checkBox_audio;
    }
}
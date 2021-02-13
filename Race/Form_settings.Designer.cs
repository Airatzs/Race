namespace Race
{
    partial class Form_settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_settings));
            this.Box_color = new System.Windows.Forms.ComboBox();
            this.button_apply = new System.Windows.Forms.Button();
            this.picture_car = new System.Windows.Forms.PictureBox();
            this.label_choose = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.Box_speed = new System.Windows.Forms.ComboBox();
            this.label_speed = new System.Windows.Forms.Label();
            this.picture_speed = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_speed)).BeginInit();
            this.SuspendLayout();
            // 
            // Box_color
            // 
            this.Box_color.BackColor = System.Drawing.Color.White;
            this.Box_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box_color.DropDownHeight = 105;
            this.Box_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_color.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Box_color.FormattingEnabled = true;
            this.Box_color.IntegralHeight = false;
            this.Box_color.ItemHeight = 16;
            this.Box_color.Items.AddRange(new object[] {
            "red",
            "blue",
            "yellow",
            "green",
            "white"});
            this.Box_color.Location = new System.Drawing.Point(125, 5);
            this.Box_color.Name = "Box_color";
            this.Box_color.Size = new System.Drawing.Size(75, 24);
            this.Box_color.TabIndex = 4;
            this.Box_color.SelectedIndexChanged += new System.EventHandler(this.Box_color_SelectedIndexChanged);
            // 
            // button_apply
            // 
            this.button_apply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_apply.Enabled = false;
            this.button_apply.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_apply.Location = new System.Drawing.Point(527, 326);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(75, 23);
            this.button_apply.TabIndex = 5;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            // 
            // picture_car
            // 
            this.picture_car.BackColor = System.Drawing.Color.Transparent;
            this.picture_car.Location = new System.Drawing.Point(0, 40);
            this.picture_car.Name = "picture_car";
            this.picture_car.Size = new System.Drawing.Size(200, 320);
            this.picture_car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_car.TabIndex = 6;
            this.picture_car.TabStop = false;
            // 
            // label_choose
            // 
            this.label_choose.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label_choose.AutoSize = true;
            this.label_choose.BackColor = System.Drawing.Color.Transparent;
            this.label_choose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_choose.Location = new System.Drawing.Point(12, 9);
            this.label_choose.Name = "label_choose";
            this.label_choose.Size = new System.Drawing.Size(92, 16);
            this.label_choose.TabIndex = 7;
            this.label_choose.Text = "Choose a car";
            // 
            // button_cancel
            // 
            this.button_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel.Location = new System.Drawing.Point(446, 326);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 8;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // Box_speed
            // 
            this.Box_speed.BackColor = System.Drawing.Color.White;
            this.Box_speed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box_speed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_speed.FormattingEnabled = true;
            this.Box_speed.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "5",
            "10",
            "20",
            "23",
            "46",
            "92",
            "115"});
            this.Box_speed.Location = new System.Drawing.Point(481, 9);
            this.Box_speed.Name = "Box_speed";
            this.Box_speed.Size = new System.Drawing.Size(121, 21);
            this.Box_speed.TabIndex = 9;
            this.Box_speed.SelectedIndexChanged += new System.EventHandler(this.Box_speed_SelectedIndexChanged);
            // 
            // label_speed
            // 
            this.label_speed.AutoSize = true;
            this.label_speed.BackColor = System.Drawing.Color.Transparent;
            this.label_speed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_speed.Location = new System.Drawing.Point(320, 10);
            this.label_speed.Name = "label_speed";
            this.label_speed.Size = new System.Drawing.Size(153, 16);
            this.label_speed.TabIndex = 10;
            this.label_speed.Text = "choose starting speed";
            // 
            // picture_speed
            // 
            this.picture_speed.BackColor = System.Drawing.Color.Transparent;
            this.picture_speed.Location = new System.Drawing.Point(320, 40);
            this.picture_speed.Name = "picture_speed";
            this.picture_speed.Size = new System.Drawing.Size(280, 180);
            this.picture_speed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_speed.TabIndex = 11;
            this.picture_speed.TabStop = false;
            // 
            // Form_settings
            // 
            this.AcceptButton = this.button_apply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Race.Properties.Resources.background_settings;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(614, 361);
            this.Controls.Add(this.picture_speed);
            this.Controls.Add(this.label_speed);
            this.Controls.Add(this.Box_speed);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.label_choose);
            this.Controls.Add(this.picture_car);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.Box_color);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_settings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.picture_car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Box_color;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.PictureBox picture_car;
        private System.Windows.Forms.Label label_choose;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.ComboBox Box_speed;
        private System.Windows.Forms.Label label_speed;
        private System.Windows.Forms.PictureBox picture_speed;
    }
}
namespace auto_Login_Sut_Wifi
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.startup = new System.Windows.Forms.CheckBox();
            this.loginwhenStart = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AutoClose = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // startup
            // 
            this.startup.AutoSize = true;
            this.startup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.startup.Location = new System.Drawing.Point(41, 45);
            this.startup.Name = "startup";
            this.startup.Size = new System.Drawing.Size(201, 17);
            this.startup.TabIndex = 5;
            this.startup.Text = "Start Programe when I start Windows";
            this.startup.UseVisualStyleBackColor = true;
            this.startup.CheckedChanged += new System.EventHandler(this.startup_CheckedChanged);
            // 
            // loginwhenStart
            // 
            this.loginwhenStart.AutoSize = true;
            this.loginwhenStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loginwhenStart.Location = new System.Drawing.Point(41, 68);
            this.loginwhenStart.Name = "loginwhenStart";
            this.loginwhenStart.Size = new System.Drawing.Size(164, 17);
            this.loginwhenStart.TabIndex = 5;
            this.loginwhenStart.Text = "Login when start this program";
            this.loginwhenStart.UseVisualStyleBackColor = true;
            this.loginwhenStart.CheckedChanged += new System.EventHandler(this.loginwhenStart_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Settings";
            // 
            // AutoClose
            // 
            this.AutoClose.AutoSize = true;
            this.AutoClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AutoClose.Location = new System.Drawing.Point(41, 91);
            this.AutoClose.Name = "AutoClose";
            this.AutoClose.Size = new System.Drawing.Size(134, 17);
            this.AutoClose.TabIndex = 5;
            this.AutoClose.Text = "Auto close in 5 second";
            this.AutoClose.UseVisualStyleBackColor = true;
            this.AutoClose.CheckedChanged += new System.EventHandler(this.loginwhenStart_CheckedChanged);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 173);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AutoClose);
            this.Controls.Add(this.loginwhenStart);
            this.Controls.Add(this.startup);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox startup;
        private System.Windows.Forms.CheckBox loginwhenStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox AutoClose;
    }
}
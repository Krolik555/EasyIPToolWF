namespace EasyIPToolWF
{
    partial class SettingsForm
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
            this.aCheckBoxAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.aCheckBoxShowInTaskbar = new System.Windows.Forms.CheckBox();
            this.aButtonSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aCheckBoxAlwaysOnTop
            // 
            this.aCheckBoxAlwaysOnTop.AutoSize = true;
            this.aCheckBoxAlwaysOnTop.Location = new System.Drawing.Point(12, 12);
            this.aCheckBoxAlwaysOnTop.Name = "aCheckBoxAlwaysOnTop";
            this.aCheckBoxAlwaysOnTop.Size = new System.Drawing.Size(133, 17);
            this.aCheckBoxAlwaysOnTop.TabIndex = 0;
            this.aCheckBoxAlwaysOnTop.Text = "Window always on top";
            this.aCheckBoxAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // aCheckBoxShowInTaskbar
            // 
            this.aCheckBoxShowInTaskbar.AutoSize = true;
            this.aCheckBoxShowInTaskbar.Location = new System.Drawing.Point(12, 35);
            this.aCheckBoxShowInTaskbar.Name = "aCheckBoxShowInTaskbar";
            this.aCheckBoxShowInTaskbar.Size = new System.Drawing.Size(102, 17);
            this.aCheckBoxShowInTaskbar.TabIndex = 1;
            this.aCheckBoxShowInTaskbar.Text = "Show in taskbar";
            this.aCheckBoxShowInTaskbar.UseVisualStyleBackColor = true;
            // 
            // aButtonSave
            // 
            this.aButtonSave.Location = new System.Drawing.Point(12, 58);
            this.aButtonSave.Name = "aButtonSave";
            this.aButtonSave.Size = new System.Drawing.Size(49, 23);
            this.aButtonSave.TabIndex = 2;
            this.aButtonSave.Text = "Save";
            this.aButtonSave.UseVisualStyleBackColor = true;
            this.aButtonSave.Click += new System.EventHandler(this.AButtonSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Check for Updates";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 92);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aButtonSave);
            this.Controls.Add(this.aCheckBoxShowInTaskbar);
            this.Controls.Add(this.aCheckBoxAlwaysOnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox aCheckBoxAlwaysOnTop;
        private System.Windows.Forms.CheckBox aCheckBoxShowInTaskbar;
        private System.Windows.Forms.Button aButtonSave;
        private System.Windows.Forms.Button button1;
    }
}
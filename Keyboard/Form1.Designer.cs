namespace Keyboard
{
    partial class Form1
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
            this.Enter = new System.Windows.Forms.CheckBox();
            this.Space = new System.Windows.Forms.CheckBox();
            this.BackSpace = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Enter
            // 
            this.Enter.Appearance = System.Windows.Forms.Appearance.Button;
            this.Enter.AutoSize = true;
            this.Enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Enter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Enter.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Enter.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Enter.Location = new System.Drawing.Point(121, 62);
            this.Enter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(114, 56);
            this.Enter.TabIndex = 1;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = false;
            this.Enter.CheckedChanged += new System.EventHandler(this.Enter_CheckedChanged);
            // 
            // Space
            // 
            this.Space.Appearance = System.Windows.Forms.Appearance.Button;
            this.Space.AutoSize = true;
            this.Space.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Space.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Space.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Space.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Space.Location = new System.Drawing.Point(2, 62);
            this.Space.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Space.Name = "Space";
            this.Space.Size = new System.Drawing.Size(122, 56);
            this.Space.TabIndex = 2;
            this.Space.Text = "Space";
            this.Space.UseVisualStyleBackColor = false;
            this.Space.CheckedChanged += new System.EventHandler(this.Space_CheckedChanged);
            // 
            // BackSpace
            // 
            this.BackSpace.Appearance = System.Windows.Forms.Appearance.Button;
            this.BackSpace.AutoSize = true;
            this.BackSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackSpace.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackSpace.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackSpace.Location = new System.Drawing.Point(38, 3);
            this.BackSpace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BackSpace.Name = "BackSpace";
            this.BackSpace.Size = new System.Drawing.Size(176, 51);
            this.BackSpace.TabIndex = 3;
            this.BackSpace.Text = "BackSpace";
            this.BackSpace.UseVisualStyleBackColor = false;
            this.BackSpace.CheckedChanged += new System.EventHandler(this.BackSpace_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(239, 119);
            this.Controls.Add(this.BackSpace);
            this.Controls.Add(this.Space);
            this.Controls.Add(this.Enter);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CheckBox Enter;
        private CheckBox Space;
        private CheckBox BackSpace;
    }
}
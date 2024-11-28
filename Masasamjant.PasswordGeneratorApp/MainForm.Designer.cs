namespace Masasamjant.Passwords
{
    partial class MainForm
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
            textPassword = new TextBox();
            linkProperties = new LinkLabel();
            buttonNext = new Button();
            SuspendLayout();
            // 
            // textPassword
            // 
            textPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPassword.Location = new Point(29, 23);
            textPassword.Name = "textPassword";
            textPassword.ReadOnly = true;
            textPassword.Size = new Size(446, 29);
            textPassword.TabIndex = 0;
            // 
            // linkProperties
            // 
            linkProperties.AutoSize = true;
            linkProperties.LinkBehavior = LinkBehavior.NeverUnderline;
            linkProperties.Location = new Point(29, 80);
            linkProperties.Name = "linkProperties";
            linkProperties.Size = new Size(60, 15);
            linkProperties.TabIndex = 1;
            linkProperties.TabStop = true;
            linkProperties.Text = "&Properties";
            linkProperties.UseWaitCursor = true;
            linkProperties.VisitedLinkColor = Color.Blue;
            linkProperties.LinkClicked += OnLinkPropertiesLinkClicked;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(400, 76);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(75, 23);
            buttonNext.TabIndex = 2;
            buttonNext.Text = "&Next";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += OnButtonNextClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 117);
            Controls.Add(buttonNext);
            Controls.Add(linkProperties);
            Controls.Add(textPassword);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Password Generator App";
            Load += OnMainFormLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textPassword;
        private LinkLabel linkProperties;
        private Button buttonNext;
    }
}
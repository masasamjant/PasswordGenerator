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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            textPassword = new TextBox();
            linkProperties = new LinkLabel();
            buttonNext = new Button();
            linkEdit = new LinkLabel();
            SuspendLayout();
            // 
            // textPassword
            // 
            resources.ApplyResources(textPassword, "textPassword");
            textPassword.Name = "textPassword";
            textPassword.ReadOnly = true;
            // 
            // linkProperties
            // 
            resources.ApplyResources(linkProperties, "linkProperties");
            linkProperties.LinkBehavior = LinkBehavior.NeverUnderline;
            linkProperties.Name = "linkProperties";
            linkProperties.TabStop = true;
            linkProperties.UseWaitCursor = true;
            linkProperties.VisitedLinkColor = Color.Blue;
            linkProperties.LinkClicked += OnLinkPropertiesLinkClicked;
            // 
            // buttonNext
            // 
            resources.ApplyResources(buttonNext, "buttonNext");
            buttonNext.Name = "buttonNext";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += OnButtonNextClick;
            // 
            // linkEdit
            // 
            resources.ApplyResources(linkEdit, "linkEdit");
            linkEdit.ActiveLinkColor = Color.Blue;
            linkEdit.Name = "linkEdit";
            linkEdit.TabStop = true;
            linkEdit.VisitedLinkColor = Color.Blue;
            linkEdit.Click += OnLinkEditClick;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(linkEdit);
            Controls.Add(buttonNext);
            Controls.Add(linkProperties);
            Controls.Add(textPassword);
            MaximizeBox = false;
            Name = "MainForm";
            Load += OnMainFormLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textPassword;
        private LinkLabel linkProperties;
        private Button buttonNext;
        private LinkLabel linkEdit;
    }
}
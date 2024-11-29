namespace Masasamjant.Passwords
{
    partial class PropertiesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropertiesForm));
            groupProperties = new GroupBox();
            groupComplexity = new GroupBox();
            checkSpecials = new CheckBox();
            checkNumbers = new CheckBox();
            checkUpperCaseLetters = new CheckBox();
            checkLowerCaseLetters = new CheckBox();
            numMaxLength = new NumericUpDown();
            labelMaxLength = new Label();
            numMinLength = new NumericUpDown();
            labelMinLength = new Label();
            textCharacters = new TextBox();
            labelCharacters = new Label();
            buttonCancel = new Button();
            buttonSave = new Button();
            groupProperties.SuspendLayout();
            groupComplexity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMaxLength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMinLength).BeginInit();
            SuspendLayout();
            // 
            // groupProperties
            // 
            resources.ApplyResources(groupProperties, "groupProperties");
            groupProperties.Controls.Add(groupComplexity);
            groupProperties.Controls.Add(numMaxLength);
            groupProperties.Controls.Add(labelMaxLength);
            groupProperties.Controls.Add(numMinLength);
            groupProperties.Controls.Add(labelMinLength);
            groupProperties.Controls.Add(textCharacters);
            groupProperties.Controls.Add(labelCharacters);
            groupProperties.Name = "groupProperties";
            groupProperties.TabStop = false;
            // 
            // groupComplexity
            // 
            resources.ApplyResources(groupComplexity, "groupComplexity");
            groupComplexity.Controls.Add(checkSpecials);
            groupComplexity.Controls.Add(checkNumbers);
            groupComplexity.Controls.Add(checkUpperCaseLetters);
            groupComplexity.Controls.Add(checkLowerCaseLetters);
            groupComplexity.Name = "groupComplexity";
            groupComplexity.TabStop = false;
            // 
            // checkSpecials
            // 
            resources.ApplyResources(checkSpecials, "checkSpecials");
            checkSpecials.Checked = true;
            checkSpecials.CheckState = CheckState.Checked;
            checkSpecials.Name = "checkSpecials";
            checkSpecials.UseVisualStyleBackColor = true;
            checkSpecials.CheckedChanged += OnCheckSpecialsCheckedChanged;
            // 
            // checkNumbers
            // 
            resources.ApplyResources(checkNumbers, "checkNumbers");
            checkNumbers.Checked = true;
            checkNumbers.CheckState = CheckState.Checked;
            checkNumbers.Name = "checkNumbers";
            checkNumbers.UseVisualStyleBackColor = true;
            checkNumbers.CheckedChanged += OnCheckNumbersCheckedChanged;
            // 
            // checkUpperCaseLetters
            // 
            resources.ApplyResources(checkUpperCaseLetters, "checkUpperCaseLetters");
            checkUpperCaseLetters.Checked = true;
            checkUpperCaseLetters.CheckState = CheckState.Checked;
            checkUpperCaseLetters.Name = "checkUpperCaseLetters";
            checkUpperCaseLetters.UseVisualStyleBackColor = true;
            checkUpperCaseLetters.CheckedChanged += OnCheckUpperCaseLettersCheckedChanged;
            // 
            // checkLowerCaseLetters
            // 
            resources.ApplyResources(checkLowerCaseLetters, "checkLowerCaseLetters");
            checkLowerCaseLetters.Checked = true;
            checkLowerCaseLetters.CheckState = CheckState.Checked;
            checkLowerCaseLetters.Name = "checkLowerCaseLetters";
            checkLowerCaseLetters.UseVisualStyleBackColor = true;
            checkLowerCaseLetters.CheckedChanged += OnCheckLowerCaseLettersCheckedChanged;
            // 
            // numMaxLength
            // 
            resources.ApplyResources(numMaxLength, "numMaxLength");
            numMaxLength.Name = "numMaxLength";
            numMaxLength.ValueChanged += OnNumMaxLengthValueChanged;
            // 
            // labelMaxLength
            // 
            resources.ApplyResources(labelMaxLength, "labelMaxLength");
            labelMaxLength.Name = "labelMaxLength";
            // 
            // numMinLength
            // 
            resources.ApplyResources(numMinLength, "numMinLength");
            numMinLength.Name = "numMinLength";
            numMinLength.ValueChanged += OnNumMinLengthValueChanged;
            // 
            // labelMinLength
            // 
            resources.ApplyResources(labelMinLength, "labelMinLength");
            labelMinLength.Name = "labelMinLength";
            // 
            // textCharacters
            // 
            resources.ApplyResources(textCharacters, "textCharacters");
            textCharacters.Name = "textCharacters";
            textCharacters.ReadOnly = true;
            // 
            // labelCharacters
            // 
            resources.ApplyResources(labelCharacters, "labelCharacters");
            labelCharacters.Name = "labelCharacters";
            // 
            // buttonCancel
            // 
            resources.ApplyResources(buttonCancel, "buttonCancel");
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Name = "buttonCancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += OnButtonCancelClick;
            // 
            // buttonSave
            // 
            resources.ApplyResources(buttonSave, "buttonSave");
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Name = "buttonSave";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += OnButtonSaveClick;
            // 
            // PropertiesForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Controls.Add(groupProperties);
            MaximizeBox = false;
            Name = "PropertiesForm";
            Load += OnPropertiesFormLoad;
            groupProperties.ResumeLayout(false);
            groupProperties.PerformLayout();
            groupComplexity.ResumeLayout(false);
            groupComplexity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMaxLength).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMinLength).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupProperties;
        private Button buttonCancel;
        private Button buttonSave;
        private Label labelCharacters;
        private TextBox textCharacters;
        private NumericUpDown numMinLength;
        private Label labelMinLength;
        private NumericUpDown numMaxLength;
        private Label labelMaxLength;
        private GroupBox groupComplexity;
        private CheckBox checkUpperCaseLetters;
        private CheckBox checkLowerCaseLetters;
        private CheckBox checkSpecials;
        private CheckBox checkNumbers;
    }
}
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
            groupProperties.Controls.Add(groupComplexity);
            groupProperties.Controls.Add(numMaxLength);
            groupProperties.Controls.Add(labelMaxLength);
            groupProperties.Controls.Add(numMinLength);
            groupProperties.Controls.Add(labelMinLength);
            groupProperties.Controls.Add(textCharacters);
            groupProperties.Controls.Add(labelCharacters);
            groupProperties.Location = new Point(12, 12);
            groupProperties.Name = "groupProperties";
            groupProperties.Size = new Size(553, 327);
            groupProperties.TabIndex = 0;
            groupProperties.TabStop = false;
            groupProperties.Text = "Properties";
            // 
            // groupComplexity
            // 
            groupComplexity.Controls.Add(checkSpecials);
            groupComplexity.Controls.Add(checkNumbers);
            groupComplexity.Controls.Add(checkUpperCaseLetters);
            groupComplexity.Controls.Add(checkLowerCaseLetters);
            groupComplexity.Location = new Point(23, 200);
            groupComplexity.Name = "groupComplexity";
            groupComplexity.Size = new Size(503, 100);
            groupComplexity.TabIndex = 6;
            groupComplexity.TabStop = false;
            groupComplexity.Text = "Complexity";
            // 
            // checkSpecials
            // 
            checkSpecials.AutoSize = true;
            checkSpecials.Checked = true;
            checkSpecials.CheckState = CheckState.Checked;
            checkSpecials.Location = new Point(251, 66);
            checkSpecials.Name = "checkSpecials";
            checkSpecials.Size = new Size(68, 19);
            checkSpecials.TabIndex = 3;
            checkSpecials.Text = "Specials";
            checkSpecials.UseVisualStyleBackColor = true;
            checkSpecials.CheckedChanged += OnCheckSpecialsCheckedChanged;
            // 
            // checkNumbers
            // 
            checkNumbers.AutoSize = true;
            checkNumbers.Checked = true;
            checkNumbers.CheckState = CheckState.Checked;
            checkNumbers.Location = new Point(251, 36);
            checkNumbers.Name = "checkNumbers";
            checkNumbers.Size = new Size(75, 19);
            checkNumbers.TabIndex = 2;
            checkNumbers.Text = "Numbers";
            checkNumbers.UseVisualStyleBackColor = true;
            checkNumbers.CheckedChanged += OnCheckNumbersCheckedChanged;
            // 
            // checkUpperCaseLetters
            // 
            checkUpperCaseLetters.AutoSize = true;
            checkUpperCaseLetters.Checked = true;
            checkUpperCaseLetters.CheckState = CheckState.Checked;
            checkUpperCaseLetters.Location = new Point(39, 66);
            checkUpperCaseLetters.Name = "checkUpperCaseLetters";
            checkUpperCaseLetters.Size = new Size(119, 19);
            checkUpperCaseLetters.TabIndex = 1;
            checkUpperCaseLetters.Text = "Upper case letters";
            checkUpperCaseLetters.UseVisualStyleBackColor = true;
            checkUpperCaseLetters.CheckedChanged += OnCheckUpperCaseLettersCheckedChanged;
            // 
            // checkLowerCaseLetters
            // 
            checkLowerCaseLetters.AutoSize = true;
            checkLowerCaseLetters.Checked = true;
            checkLowerCaseLetters.CheckState = CheckState.Checked;
            checkLowerCaseLetters.Location = new Point(39, 36);
            checkLowerCaseLetters.Name = "checkLowerCaseLetters";
            checkLowerCaseLetters.Size = new Size(119, 19);
            checkLowerCaseLetters.TabIndex = 0;
            checkLowerCaseLetters.Text = "Lower case letters";
            checkLowerCaseLetters.UseVisualStyleBackColor = true;
            checkLowerCaseLetters.CheckedChanged += OnCheckLowerCaseLettersCheckedChanged;
            // 
            // numMaxLength
            // 
            numMaxLength.Location = new Point(352, 163);
            numMaxLength.Name = "numMaxLength";
            numMaxLength.Size = new Size(120, 23);
            numMaxLength.TabIndex = 5;
            numMaxLength.ValueChanged += OnNumMaxLengthValueChanged;
            // 
            // labelMaxLength
            // 
            labelMaxLength.AutoSize = true;
            labelMaxLength.Location = new Point(274, 165);
            labelMaxLength.Name = "labelMaxLength";
            labelMaxLength.Size = new Size(70, 15);
            labelMaxLength.TabIndex = 4;
            labelMaxLength.Text = "Max length:";
            // 
            // numMinLength
            // 
            numMinLength.Location = new Point(97, 163);
            numMinLength.Name = "numMinLength";
            numMinLength.Size = new Size(120, 23);
            numMinLength.TabIndex = 3;
            numMinLength.ValueChanged += OnNumMinLengthValueChanged;
            // 
            // labelMinLength
            // 
            labelMinLength.AutoSize = true;
            labelMinLength.Location = new Point(23, 165);
            labelMinLength.Name = "labelMinLength";
            labelMinLength.Size = new Size(68, 15);
            labelMinLength.TabIndex = 2;
            labelMinLength.Text = "Min length:";
            // 
            // textCharacters
            // 
            textCharacters.Enabled = false;
            textCharacters.Location = new Point(23, 70);
            textCharacters.Multiline = true;
            textCharacters.Name = "textCharacters";
            textCharacters.ReadOnly = true;
            textCharacters.Size = new Size(503, 80);
            textCharacters.TabIndex = 1;
            // 
            // labelCharacters
            // 
            labelCharacters.AutoSize = true;
            labelCharacters.Location = new Point(23, 40);
            labelCharacters.Name = "labelCharacters";
            labelCharacters.Size = new Size(66, 15);
            labelCharacters.TabIndex = 0;
            labelCharacters.Text = "Characters:";
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(490, 359);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "&Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += OnButtonCancelClick;
            // 
            // buttonSave
            // 
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Location = new Point(409, 359);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "&Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += OnButtonSaveClick;
            // 
            // PropertiesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 394);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Controls.Add(groupProperties);
            MaximizeBox = false;
            Name = "PropertiesForm";
            Text = "Password Properties";
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
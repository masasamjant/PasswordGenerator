using Masasamjant.Passwords.Resources;
using System.Text;

namespace Masasamjant.Passwords
{
    public partial class PropertiesForm : Form
    {
        private readonly PasswordGeneratorProperties properties;
        private bool suspendControlEvents = true;

        internal PropertiesForm(PasswordGeneratorProperties properties)
        {
            InitializeComponent();
            this.properties = properties;
            numMinLength.Minimum = PasswordGeneratorProperties.DefaultMinLength;
            numMinLength.Maximum = PasswordGeneratorProperties.DefaultMaxLength;
            numMaxLength.Minimum = PasswordGeneratorProperties.DefaultMinLength;
            numMaxLength.Maximum = PasswordGeneratorProperties.DefaultMaxLength;
        }

        private void OnButtonSaveClick(object sender, EventArgs e)
        {
            Close();
        }

        private void OnButtonCancelClick(object sender, EventArgs e)
        {
            Close();
        }

        private void OnPropertiesFormLoad(object sender, EventArgs e)
        {
            try
            {
                suspendControlEvents = true;
                checkLowerCaseLetters.Checked = properties.Complexity.HasFlag(PasswordComplexity.LowerCaseLetters);
                checkUpperCaseLetters.Checked = properties.Complexity.HasFlag(PasswordComplexity.UpperCaseLetters);
                checkNumbers.Checked = properties.Complexity.HasFlag(PasswordComplexity.Numbers);
                checkSpecials.Checked = properties.Complexity.HasFlag(PasswordComplexity.Specials);
                numMinLength.Value = properties.MinLength;
                numMaxLength.Value = properties.MaxLength;
                panelSpecialCount.Visible = checkSpecials.Checked;
                numSpecialCount.Value = properties.SpecialCharacterCount.GetValueOrDefault(0);
                BuildCharactersText();
            }
            finally
            {
                suspendControlEvents = false;
            }
        }

        private void OnNumMinLengthValueChanged(object sender, EventArgs e)
        {
            if (suspendControlEvents) return;

            int minLength = Convert.ToInt32(numMinLength.Value);
            int maxLength = Convert.ToInt32(numMaxLength.Value);

            if (minLength > maxLength)
            {
                MessageBox.Show(this, Messages.MinimumLengthMessage, Messages.MinimumLengthTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonSave.Enabled = false;
                return;
            }
            else
            {
                buttonSave.Enabled = true;
                properties.ChangeMinLength(minLength);
            }
        }

        private void OnNumMaxLengthValueChanged(object sender, EventArgs e)
        {
            if (suspendControlEvents) return;

            int minLength = Convert.ToInt32(numMinLength.Value);
            int maxLength = Convert.ToInt32(numMaxLength.Value);

            if (maxLength < minLength)
            {
                MessageBox.Show(this, Messages.MaximumLengthMessage, Messages.MaximumLengthTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonSave.Enabled = false;
                return;
            }
            else
            {
                buttonSave.Enabled = true;
                properties.ChangeMaxLength(maxLength);
            }
        }

        private void OnNumSpecialCountValueChanged(object sender, EventArgs e)
        {
            if (suspendControlEvents || !checkSpecials.Checked) return;
            int value = Convert.ToInt32(numSpecialCount.Value);
            properties.ChangeSpecialCharacterCount(value > 0 ? value : null);
        }

        private void OnCheckLowerCaseLettersCheckedChanged(object sender, EventArgs e)
        {
            if (suspendControlEvents || !IsAnyComplexityChecked()) return;
            ChangePasswordComplexity(PasswordComplexity.LowerCaseLetters, checkLowerCaseLetters.Checked);
        }

        private void OnCheckUpperCaseLettersCheckedChanged(object sender, EventArgs e)
        {
            if (suspendControlEvents || !IsAnyComplexityChecked()) return;
            ChangePasswordComplexity(PasswordComplexity.UpperCaseLetters, checkUpperCaseLetters.Checked);
        }

        private void OnCheckNumbersCheckedChanged(object sender, EventArgs e)
        {
            if (suspendControlEvents || !IsAnyComplexityChecked()) return;
            ChangePasswordComplexity(PasswordComplexity.Numbers, checkNumbers.Checked);
        }

        private void OnCheckSpecialsCheckedChanged(object sender, EventArgs e)
        {
            if (suspendControlEvents || !IsAnyComplexityChecked()) return;
            ChangePasswordComplexity(PasswordComplexity.Specials, checkSpecials.Checked);
            panelSpecialCount.Visible = checkSpecials.Checked;
        }

        private void ChangePasswordComplexity(PasswordComplexity flag, bool set)
        {
            var complexity = properties.Complexity;

            if (set)
                complexity |= flag;
            else
                complexity &= ~flag;

            properties.ChangeComplexity(complexity);

            BuildCharactersText();
        }

        private bool IsAnyComplexityChecked()
        {
            bool[] values = [checkLowerCaseLetters.Checked, checkUpperCaseLetters.Checked, checkNumbers.Checked, checkSpecials.Checked];

            if (values.Any(b => b))
            {
                buttonSave.Enabled = true;
                return true;
            }
            else
            {
                MessageBox.Show(this, Messages.NoCharactersMessage, Messages.NoCharactersTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonSave.Enabled = false;
                return false;
            }
        }

        private void BuildCharactersText()
        {
            var builder = new StringBuilder();

            if (checkLowerCaseLetters.Checked)
                builder.Append(string.Concat(PasswordCharacters.LowerCaseLetters));

            if (checkUpperCaseLetters.Checked)
            {
                AppendNewLine(builder);
                builder.Append(string.Concat(PasswordCharacters.UpperCaseLetters));
            }

            if (checkNumbers.Checked)
            {
                AppendNewLine(builder);
                builder.Append(string.Concat(PasswordCharacters.Numbers));
            }

            if (checkSpecials.Checked)
            {
                AppendNewLine(builder);
                builder.Append(string.Concat(PasswordCharacters.Specials));
            }

            textCharacters.Text = builder.ToString();
        }

        private static void AppendNewLine(StringBuilder builder)
        {
            if (builder.Length > 0)
                builder.Append(Environment.NewLine);
        }
    }
}

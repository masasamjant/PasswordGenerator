namespace Masasamjant.Passwords
{
    public partial class MainForm : Form
    {
        private PasswordGeneratorProperties properties;
        private PasswordGenerator generator;

        public MainForm()
        {
            InitializeComponent();
            properties = PasswordGeneratorPropertiesManager.GetProperties();
            generator = new PasswordGenerator(properties);
        }

        private void OnLinkPropertiesLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var propertiesForm = new PropertiesForm(properties))
            {
                if (propertiesForm.ShowDialog(this) == DialogResult.OK)
                {
                    PasswordGeneratorPropertiesManager.SaveProperties(properties);
                    textPassword.Text = string.Empty;
                }
            }
        }

        private void OnButtonNextClick(object sender, EventArgs e)
        {
            GeneratePassword();
        }

        private void OnMainFormLoad(object sender, EventArgs e)
        {
            GeneratePassword();
        }

        private void GeneratePassword()
        {
            textPassword.Text = generator.Generate();
        }
    }
}

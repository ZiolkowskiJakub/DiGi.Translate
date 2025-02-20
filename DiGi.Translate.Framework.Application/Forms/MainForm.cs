using DiGi.Translate.Classes;
using System.Windows.Forms;

namespace DiGi.Translate.Framework.Application
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button_Translate_Click(object sender, System.EventArgs e)
        {
            TranslationModel translationModel = new TranslationModel();
            translationModel.Add(Enums.Language.English, this, false, true);

            Translation translation;

            translation = new Translation(Enums.Category.Control, "MainForm.GroupBox_Test.RadioButton_2");
            translation.Add(Enums.Language.German, "AAA");
            translationModel.Add(translation);

            Modify.TranslateForm(translationModel, Enums.Language.German, this);
        }
    }
}

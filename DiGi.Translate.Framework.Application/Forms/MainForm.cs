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
            translationModel.Update(this, Enums.Language.English);
        }
    }
}

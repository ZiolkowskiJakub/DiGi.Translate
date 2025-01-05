using DiGi.Translate.Classes;
using System.Windows;
using System.Windows.Controls;

namespace DiGi.Translate.WPF.Application.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Translate_Click(object sender, RoutedEventArgs e)
        {
            //string path = @"C:\Users\jakub\Downloads\translationModel.txt";


            //TranslationModel translationModel = new TranslationModel();

            //translationModel.Add(Enums.Language.English, this, false, true);

            //translationModel.Write(path);

            //TranslationModel translationModel_Read = new TranslationModel();
            //translationModel_Read.Read(path);

            using (Forms.TestForm testForm = new Forms.TestForm())
            {
                TranslationModel translationModel = new TranslationModel();

                translationModel.Add(Enums.Language.English, testForm, false, true);
            }

            //Dictionary<string, string?> dictionary = Query.TextDictionary<Control>(this);
            //if(dictionary == null)
            //{
            //    return;
            //}

            //foreach(KeyValuePair<string, string?> keyValuePair in dictionary)
            //{
            //    string id = keyValuePair.Key;
            //    string? value = keyValuePair.Value;
            //}
        }
    }
}
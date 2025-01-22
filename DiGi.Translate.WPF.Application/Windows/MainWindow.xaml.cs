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
            DataGrid_Main.Columns.Add(new DataGridComboBoxColumn() { Header = "TestHeader" });

            TranslationModel translationModel = new TranslationModel();
            translationModel.Add(Enums.Language.English, this, false, true);

            Translation translation = new Translation(Enums.Category.Control, "MainWindow.Grid.DataGrid_Main.0");
            translation.Add(Enums.Language.German, "AAA");

            translationModel.Add(translation);

            Modify.TranslateWindow(translationModel, Enums.Language.German, this);


            //string path = @"C:\Users\jakub\Downloads\translationModel.txt";


            //TranslationModel translationModel = new TranslationModel();

            //translationModel.Add(Enums.Language.English, this, false, true);

            //translationModel.Write(path);

            //TranslationModel translationModel_Read = new TranslationModel();
            //translationModel_Read.Read(path);

            //using (Forms.TestForm testForm = new Forms.TestForm())
            //{
            //    TranslationModel translationModel = new TranslationModel();

            //    translationModel.Add(Enums.Language.English, testForm, false, true);
            //    translationModel.Add(Enums.Category.Control, "TestForm.dataGridView1.Column1_Test", Enums.Language.English, "AAAA");


            //    translationModel.TranslateControl(Enums.Language.English, testForm);

            //    testForm.ShowDialog();
            //}

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
using System.Windows.Controls;
using System.Windows;

namespace DiGi.Translate.WPF
{
    public static partial class Modify
    {
        public static bool SetText(this DependencyObject dependencyObject, string text)
        {
            if (dependencyObject == null)
            {
                return false;
            }

            if (dependencyObject is TextBlock)
            {
                TextBlock textBlock = (TextBlock)dependencyObject;
                textBlock.Text = text;
                return true;
            }

            if (dependencyObject is Window)
            {
                Window window = (Window)dependencyObject;
                window.Title = text;
                return true;
            }

            if (dependencyObject is DataGridColumn)
            {
                DataGridColumn dataGridColumn = ((DataGridColumn)dependencyObject);
                dataGridColumn.Header = text;
                return true;
            }

            if (dependencyObject is System.Windows.Controls.GroupBox)
            {
                System.Windows.Controls.GroupBox groupBox = ((System.Windows.Controls.GroupBox)dependencyObject);
                groupBox.Header = text;
                return true;
            }

            if (dependencyObject is TabItem)
            {
                TabItem tabItem = ((TabItem)dependencyObject);
                tabItem.Header = text;
                return true;
            }

            if (dependencyObject is HeaderedContentControl)
            {
                HeaderedContentControl headeredContentControl = ((HeaderedContentControl)dependencyObject);
                headeredContentControl.Header = text;
                return true;
            }

            if (dependencyObject is ContentControl)
            {
                ContentControl contentControl = (ContentControl)dependencyObject;
                if (contentControl.Content is DependencyObject)
                {
                    return SetText((DependencyObject)contentControl.Content, text);
                }

                contentControl.Content = text;
                return true;
            }

            return false;
        }
    }
}

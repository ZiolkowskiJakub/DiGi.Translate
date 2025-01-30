using System.Windows;
using System.Windows.Controls;

namespace DiGi.Translate.WPF
{
    public static partial class Query
    {
        public static string? Text(this DependencyObject dependencyObject)
        {
            if (dependencyObject == null)
            {
                return null;
            }

            string? result = null;

            if (dependencyObject is TextBlock)
            {
                TextBlock textBlock = (TextBlock)dependencyObject;
                result = textBlock.Text;
            }
            else if (dependencyObject is Window)
            {
                Window window = (Window)dependencyObject;
                result = window.Title;
            }
            else if(dependencyObject is DataGridColumn)
            {
                object header = ((DataGridColumn)dependencyObject).Header;

                if (header is string)
                {
                    result = (string)header;
                }
            }
            else if (dependencyObject is System.Windows.Controls.GroupBox)
            {
                object header = ((System.Windows.Controls.GroupBox)dependencyObject).Header;

                if (header is string)
                {
                    result = (string)header;
                }
            }
            else if (dependencyObject is TabItem)
            {
                object header = ((TabItem)dependencyObject).Header;

                if (header is string)
                {
                    result = (string)header;
                }
            }
            else if (dependencyObject is HeaderedContentControl)
            {
                object header = ((HeaderedContentControl)dependencyObject).Header;

                if (header is string)
                {
                    result = (string)header;
                }
            }
            else if (dependencyObject is ContentControl)
            {
                ContentControl contentControl = (ContentControl)dependencyObject;
                object content = contentControl.Content;

                if (content is string)
                {
                    result = (string)content;
                }
            }

            if(!string.IsNullOrWhiteSpace(result))
            {
                result = result.Replace("\\n", "\n");
            }

            return result;
        }
    }
}


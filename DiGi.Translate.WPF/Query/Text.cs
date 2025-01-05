﻿using System.Windows;
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

            if (dependencyObject is TextBlock)
            {
                TextBlock textBlock = (TextBlock)dependencyObject;
                return textBlock.Text;
            }

            if (dependencyObject is ContentControl)
            {
                ContentControl contentControl = (ContentControl)dependencyObject;
                object content = contentControl.Content;

                if (content is string)
                {
                    return (string)content;
                }

                //if (content is DependencyObject)
                //{
                //    return Text((DependencyObject)content);
                //}

                return null;
            }

            return null;
        }
    }
}


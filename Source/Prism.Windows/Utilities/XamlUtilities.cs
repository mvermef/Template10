﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace Prism.Windows.Utilities
{
    public static class XamlUtilities
    {
        public static List<FrameworkElement> RecurseChildren(DependencyObject parent)
        {
            var list = new List<FrameworkElement>();
            var count = VisualTreeHelper.GetChildrenCount(parent);
            for (var i = 0; i < count; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                if (child is FrameworkElement element)
                {
                    list.Add(element);
                }
                list.AddRange(RecurseChildren(child));
            }
            return list;
        }

    }
}

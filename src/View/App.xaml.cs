﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace View
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        internal void SetTheme(string name)
        {
            var resourceDictionary = new ResourceDictionary() { Source = new Uri($"Themes/{name}.xaml", UriKind.Relative) };
            var resources = new ResourceDictionary();

            resources.MergedDictionaries.Add(resourceDictionary);

            this.Resources = resources;

        }
    }
}

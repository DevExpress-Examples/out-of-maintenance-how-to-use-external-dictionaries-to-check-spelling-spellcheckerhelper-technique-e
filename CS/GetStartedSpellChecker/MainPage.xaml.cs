using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using DevExpress.XtraRichEdit.Commands;
using DevExpress.XtraSpellChecker;
using System.Globalization;
using System.IO;
using System.Windows.Resources;
using System.Text;

namespace GetStartedSpellChecker
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }  

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SpellCheckerHelper.SpellChecker.Check(tb);
        }

        private void btn_DictLoad_Click(object sender, RoutedEventArgs e)
        {
            tb.IsEnabled = false;
            LayoutRoot.Cursor = Cursors.Wait;

            SpellCheckerOpenOfficeDictionary dict =
                new SpellCheckerOpenOfficeDictionary();
            StreamResourceInfo ResourceStreamDic = 
                App.GetResourceStream(new Uri("Dictionary/de_DE.dic", UriKind.Relative));
            Stream dicStream = ResourceStreamDic.Stream;
            StreamResourceInfo ResourceStreamAff = 
                App.GetResourceStream(new Uri("Dictionary/de_DE.aff", UriKind.Relative));
            Stream affStream = ResourceStreamAff.Stream;
            StreamResourceInfo ResourceStreamAlpha = 
                App.GetResourceStream(new Uri("Dictionary/german_alphabet.txt", UriKind.Relative));
            Stream alphaStream = ResourceStreamAlpha.Stream;
            dict.Culture = new CultureInfo("de-DE");
            dict.LoadFromStream(dicStream, affStream, alphaStream);
            SpellCheckerHelper.SpellChecker.Dictionaries.Add(dict);
            SpellCheckerHelper.SpellChecker.Culture = new CultureInfo("de-DE");

            tb.IsEnabled = true;
            LayoutRoot.Cursor = Cursors.Arrow;
        }

    }
}

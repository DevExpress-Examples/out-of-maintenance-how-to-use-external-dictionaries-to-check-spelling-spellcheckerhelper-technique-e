Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports DevExpress.XtraRichEdit.Commands
Imports DevExpress.XtraSpellChecker
Imports System.Globalization
Imports System.IO
Imports System.Windows.Resources
Imports System.Text

Namespace GetStartedSpellChecker
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			SpellCheckerHelper.SpellChecker.Check(tb)
		End Sub

		Private Sub btn_DictLoad_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			tb.IsEnabled = False
			LayoutRoot.Cursor = Cursors.Wait

			Dim dict As New SpellCheckerOpenOfficeDictionary()
			Dim ResourceStreamDic As StreamResourceInfo = App.GetResourceStream(New Uri("Dictionary/de_DE.dic", UriKind.Relative))
			Dim dicStream As Stream = ResourceStreamDic.Stream
			Dim ResourceStreamAff As StreamResourceInfo = App.GetResourceStream(New Uri("Dictionary/de_DE.aff", UriKind.Relative))
			Dim affStream As Stream = ResourceStreamAff.Stream
			Dim ResourceStreamAlpha As StreamResourceInfo = App.GetResourceStream(New Uri("Dictionary/german_alphabet.txt", UriKind.Relative))
			Dim alphaStream As Stream = ResourceStreamAlpha.Stream
			dict.Culture = New CultureInfo("de-DE")
			dict.LoadFromStream(dicStream, affStream, alphaStream)
			SpellCheckerHelper.SpellChecker.Dictionaries.Add(dict)
			SpellCheckerHelper.SpellChecker.Culture = New CultureInfo("de-DE")

			tb.IsEnabled = True
			LayoutRoot.Cursor = Cursors.Arrow
		End Sub

	End Class
End Namespace

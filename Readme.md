<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1865)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainPage.xaml](./CS/GetStartedSpellChecker/MainPage.xaml) (VB: [MainPage.xaml](./VB/GetStartedSpellChecker/MainPage.xaml))
* [MainPage.xaml.cs](./CS/GetStartedSpellChecker/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/GetStartedSpellChecker/MainPage.xaml.vb))
<!-- default file list end -->
# How to use external dictionaries to check spelling (SpellCheckerHelper technique)


<p>This example illustrates the use of external OpenOffice dictionaries for German language to check spelling of the TextBox content. The <strong>SpellCheckerHelper</strong> object provides access to the spell checker. <br />
The dictionary has been converted to UTF-8 prior to use because SilverLight technology does not allow encodings other than UTF-8 and Unicode. To convert a dictionary, you can use the utility attached to the <a href="https://www.devexpress.com/Support/Center/p/K18404">K18404</a> article.<br />
Note: when adding new dictionaries to this project, do not forget to specify for them Compile Action = Content.</p><p><i>NB</i>: <strong>DevExpress.XtraRichEdit.Commands.SpellCheckerHelper</strong> class is obsolete starting with version v2010 vol.2 . For a recommended technique, review the following article:<br />
<a href="https://www.devexpress.com/Support/Center/p/E2306">E2306: How to use external dictionaries to check spelling (via SpellChecker() in code)</a>.</p>

<br/>



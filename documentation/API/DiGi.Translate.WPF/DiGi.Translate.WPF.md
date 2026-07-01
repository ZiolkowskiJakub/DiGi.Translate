## DiGi\.Translate\.WPF Namespace
### Classes

<a name='DiGi.Translate.WPF.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.Translate.WPF.Modify.Add(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.DependencyObject,bool,bool)'></a>

## Modify\.Add\(this TranslationModel, Language, DependencyObject, bool, bool\) Method

Adds a translation entry for the specified WPF [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject') to the [DiGi\.Translate\.Classes\.TranslationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.translationmodel 'DiGi\.Translate\.Classes\.TranslationModel')\.

```csharp
public static bool Add(this DiGi.Translate.Classes.TranslationModel translationModel, DiGi.Translate.Classes.Language language, System.Windows.DependencyObject dependencyObject, bool includeNullOrEmpty=false, bool includeNested=true);
```
#### Parameters

<a name='DiGi.Translate.WPF.Modify.Add(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.DependencyObject,bool,bool).translationModel'></a>

`translationModel` [DiGi\.Translate\.Classes\.TranslationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.translationmodel 'DiGi\.Translate\.Classes\.TranslationModel')

The [DiGi\.Translate\.Classes\.TranslationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.translationmodel 'DiGi\.Translate\.Classes\.TranslationModel') instance where the translation will be added\.

<a name='DiGi.Translate.WPF.Modify.Add(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.DependencyObject,bool,bool).language'></a>

`language` [DiGi\.Translate\.Classes\.Language](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.language 'DiGi\.Translate\.Classes\.Language')

The target [DiGi\.Translate\.Classes\.Language](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.language 'DiGi\.Translate\.Classes\.Language') for the translation entry\.

<a name='DiGi.Translate.WPF.Modify.Add(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.DependencyObject,bool,bool).dependencyObject'></a>

`dependencyObject` [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject')

The [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject') from which the identifier and text are extracted\.

<a name='DiGi.Translate.WPF.Modify.Add(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.DependencyObject,bool,bool).includeNullOrEmpty'></a>

`includeNullOrEmpty` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to include entries with null or empty text\. Defaults to `false`\.

<a name='DiGi.Translate.WPF.Modify.Add(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.DependencyObject,bool,bool).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to process nested child elements\. Defaults to `true`\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the translation was successfully processed; otherwise, `false`\.

<a name='DiGi.Translate.WPF.Modify.Add(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Forms.Control,bool,bool)'></a>

## Modify\.Add\(this TranslationModel, Language, Control, bool, bool\) Method

Adds a translation entry for the specified control to the translation model\.

```csharp
public static bool Add(this DiGi.Translate.Classes.TranslationModel translationModel, DiGi.Translate.Classes.Language language, System.Windows.Forms.Control control, bool includeNullOrEmpty=false, bool includeNested=true);
```
#### Parameters

<a name='DiGi.Translate.WPF.Modify.Add(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Forms.Control,bool,bool).translationModel'></a>

`translationModel` [DiGi\.Translate\.Classes\.TranslationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.translationmodel 'DiGi\.Translate\.Classes\.TranslationModel')

The translation model to update\.

<a name='DiGi.Translate.WPF.Modify.Add(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Forms.Control,bool,bool).language'></a>

`language` [DiGi\.Translate\.Classes\.Language](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.language 'DiGi\.Translate\.Classes\.Language')

The target language for the translation\.

<a name='DiGi.Translate.WPF.Modify.Add(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Forms.Control,bool,bool).control'></a>

`control` [System\.Windows\.Forms\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control 'System\.Windows\.Forms\.Control')

The control whose identifier and text are used for the translation entry\.

<a name='DiGi.Translate.WPF.Modify.Add(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Forms.Control,bool,bool).includeNullOrEmpty'></a>

`includeNullOrEmpty` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Indicates whether entries with null or empty text should be included\.

<a name='DiGi.Translate.WPF.Modify.Add(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Forms.Control,bool,bool).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Indicates whether to recursively process nested controls\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the control was successfully processed; otherwise, false\.

<a name='DiGi.Translate.WPF.Modify.SetText(thisSystem.Windows.DependencyObject,string)'></a>

## Modify\.SetText\(this DependencyObject, string\) Method

Sets the text of the specified [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject') if it supports a text property\.

```csharp
public static bool SetText(this System.Windows.DependencyObject dependencyObject, string text);
```
#### Parameters

<a name='DiGi.Translate.WPF.Modify.SetText(thisSystem.Windows.DependencyObject,string).dependencyObject'></a>

`dependencyObject` [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject')

The [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject') to modify\.

<a name='DiGi.Translate.WPF.Modify.SetText(thisSystem.Windows.DependencyObject,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The text string to assign\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the text was successfully set; otherwise, false\.

<a name='DiGi.Translate.WPF.Modify.TranslateControl(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Forms.Control,bool)'></a>

## Modify\.TranslateControl\(this TranslationModel, Language, Control, bool\) Method

Translates the text of a specified control using the provided translation model and language\.

```csharp
public static bool TranslateControl(this DiGi.Translate.Classes.TranslationModel? translationModel, DiGi.Translate.Classes.Language? language, System.Windows.Forms.Control? control, bool includeNested=true);
```
#### Parameters

<a name='DiGi.Translate.WPF.Modify.TranslateControl(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Forms.Control,bool).translationModel'></a>

`translationModel` [DiGi\.Translate\.Classes\.TranslationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.translationmodel 'DiGi\.Translate\.Classes\.TranslationModel')

The translation model used to retrieve translated text\.

<a name='DiGi.Translate.WPF.Modify.TranslateControl(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Forms.Control,bool).language'></a>

`language` [DiGi\.Translate\.Classes\.Language](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.language 'DiGi\.Translate\.Classes\.Language')

The target language for the translation\.

<a name='DiGi.Translate.WPF.Modify.TranslateControl(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Forms.Control,bool).control'></a>

`control` [System\.Windows\.Forms\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control 'System\.Windows\.Forms\.Control')

The control whose text is to be translated\.

<a name='DiGi.Translate.WPF.Modify.TranslateControl(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Forms.Control,bool).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to translate nested controls within the specified control\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the control was successfully translated; otherwise, false\.

<a name='DiGi.Translate.WPF.Modify.TranslateControl(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Enums.Language,System.Windows.Forms.Control,bool)'></a>

## Modify\.TranslateControl\(this TranslationModel, Language, Control, bool\) Method

Translates the specified WPF control and optionally its nested children using the provided translation model and language\.

```csharp
public static bool TranslateControl(this DiGi.Translate.Classes.TranslationModel? translationModel, DiGi.Translate.Enums.Language language, System.Windows.Forms.Control? control, bool includeNested=true);
```
#### Parameters

<a name='DiGi.Translate.WPF.Modify.TranslateControl(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Enums.Language,System.Windows.Forms.Control,bool).translationModel'></a>

`translationModel` [DiGi\.Translate\.Classes\.TranslationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.translationmodel 'DiGi\.Translate\.Classes\.TranslationModel')

The translation model containing the localized strings\.

<a name='DiGi.Translate.WPF.Modify.TranslateControl(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Enums.Language,System.Windows.Forms.Control,bool).language'></a>

`language` [DiGi\.Translate\.Enums\.Language](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.enums.language 'DiGi\.Translate\.Enums\.Language')

The target language to apply for the translation\.

<a name='DiGi.Translate.WPF.Modify.TranslateControl(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Enums.Language,System.Windows.Forms.Control,bool).control'></a>

`control` [System\.Windows\.Forms\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control 'System\.Windows\.Forms\.Control')

The WPF control to be translated\.

<a name='DiGi.Translate.WPF.Modify.TranslateControl(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Enums.Language,System.Windows.Forms.Control,bool).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to recursively translate nested controls within the specified control\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the translation process was successful; otherwise, false\.

<a name='DiGi.Translate.WPF.Modify.TranslateControl(thisDiGi.Translate.Classes.Translator,System.Windows.Forms.Control,bool)'></a>

## Modify\.TranslateControl\(this Translator, Control, bool\) Method

Translates the specified WPF control using the provided translator instance\.

```csharp
public static bool TranslateControl(this DiGi.Translate.Classes.Translator? translator, System.Windows.Forms.Control? control, bool includeNested=true);
```
#### Parameters

<a name='DiGi.Translate.WPF.Modify.TranslateControl(thisDiGi.Translate.Classes.Translator,System.Windows.Forms.Control,bool).translator'></a>

`translator` [DiGi\.Translate\.Classes\.Translator](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.translator 'DiGi\.Translate\.Classes\.Translator')

The [DiGi\.Translate\.Classes\.Translator](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.translator 'DiGi\.Translate\.Classes\.Translator') used to retrieve translated text\.

<a name='DiGi.Translate.WPF.Modify.TranslateControl(thisDiGi.Translate.Classes.Translator,System.Windows.Forms.Control,bool).control'></a>

`control` [System\.Windows\.Forms\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control 'System\.Windows\.Forms\.Control')

The [System\.Windows\.Forms\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control 'System\.Windows\.Forms\.Control') to be translated\.

<a name='DiGi.Translate.WPF.Modify.TranslateControl(thisDiGi.Translate.Classes.Translator,System.Windows.Forms.Control,bool).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the translation should be applied recursively to nested child controls\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the control was successfully translated; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Translate.WPF.Modify.TranslateFrameworkElement(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.FrameworkElement,bool)'></a>

## Modify\.TranslateFrameworkElement\(this TranslationModel, Language, FrameworkElement, bool\) Method

Translates the specified [System\.Windows\.FrameworkElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.frameworkelement 'System\.Windows\.FrameworkElement') using the provided translation model and language\.

```csharp
public static bool TranslateFrameworkElement(this DiGi.Translate.Classes.TranslationModel? translationModel, DiGi.Translate.Classes.Language? language, System.Windows.FrameworkElement? frameworkElement, bool includeNested=true);
```
#### Parameters

<a name='DiGi.Translate.WPF.Modify.TranslateFrameworkElement(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.FrameworkElement,bool).translationModel'></a>

`translationModel` [DiGi\.Translate\.Classes\.TranslationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.translationmodel 'DiGi\.Translate\.Classes\.TranslationModel')

The translation model containing the localized strings\.

<a name='DiGi.Translate.WPF.Modify.TranslateFrameworkElement(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.FrameworkElement,bool).language'></a>

`language` [DiGi\.Translate\.Classes\.Language](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.language 'DiGi\.Translate\.Classes\.Language')

The target language for translation\.

<a name='DiGi.Translate.WPF.Modify.TranslateFrameworkElement(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.FrameworkElement,bool).frameworkElement'></a>

`frameworkElement` [System\.Windows\.FrameworkElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.frameworkelement 'System\.Windows\.FrameworkElement')

The framework element to translate\.

<a name='DiGi.Translate.WPF.Modify.TranslateFrameworkElement(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.FrameworkElement,bool).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to recursively translate nested child elements\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the element was successfully translated; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Translate.WPF.Modify.TranslateFrameworkElement(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Enums.Language,System.Windows.FrameworkElement,bool)'></a>

## Modify\.TranslateFrameworkElement\(this TranslationModel, Language, FrameworkElement, bool\) Method

Translates the specified [System\.Windows\.FrameworkElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.frameworkelement 'System\.Windows\.FrameworkElement') using the provided translation model and language\.

```csharp
public static bool TranslateFrameworkElement(this DiGi.Translate.Classes.TranslationModel translationModel, DiGi.Translate.Enums.Language language, System.Windows.FrameworkElement frameworkElement, bool includeNested=true);
```
#### Parameters

<a name='DiGi.Translate.WPF.Modify.TranslateFrameworkElement(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Enums.Language,System.Windows.FrameworkElement,bool).translationModel'></a>

`translationModel` [DiGi\.Translate\.Classes\.TranslationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.translationmodel 'DiGi\.Translate\.Classes\.TranslationModel')

The translation model used to retrieve translated strings\.

<a name='DiGi.Translate.WPF.Modify.TranslateFrameworkElement(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Enums.Language,System.Windows.FrameworkElement,bool).language'></a>

`language` [DiGi\.Translate\.Enums\.Language](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.enums.language 'DiGi\.Translate\.Enums\.Language')

The target language for the translation\.

<a name='DiGi.Translate.WPF.Modify.TranslateFrameworkElement(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Enums.Language,System.Windows.FrameworkElement,bool).frameworkElement'></a>

`frameworkElement` [System\.Windows\.FrameworkElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.frameworkelement 'System\.Windows\.FrameworkElement')

The framework element to translate\.

<a name='DiGi.Translate.WPF.Modify.TranslateFrameworkElement(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Enums.Language,System.Windows.FrameworkElement,bool).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to recursively translate nested child elements\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the translation process was successful; otherwise, false\.

<a name='DiGi.Translate.WPF.Modify.TranslateFrameworkElement(thisDiGi.Translate.Classes.Translator,System.Windows.FrameworkElement,bool)'></a>

## Modify\.TranslateFrameworkElement\(this Translator, FrameworkElement, bool\) Method

Translates the specified framework element using the provided translator based on its identifier\.

```csharp
public static bool TranslateFrameworkElement(this DiGi.Translate.Classes.Translator? translator, System.Windows.FrameworkElement? frameworkElement, bool includeNested=true);
```
#### Parameters

<a name='DiGi.Translate.WPF.Modify.TranslateFrameworkElement(thisDiGi.Translate.Classes.Translator,System.Windows.FrameworkElement,bool).translator'></a>

`translator` [DiGi\.Translate\.Classes\.Translator](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.translator 'DiGi\.Translate\.Classes\.Translator')

The [DiGi\.Translate\.Classes\.Translator](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.translator 'DiGi\.Translate\.Classes\.Translator') instance used to retrieve translated text\.

<a name='DiGi.Translate.WPF.Modify.TranslateFrameworkElement(thisDiGi.Translate.Classes.Translator,System.Windows.FrameworkElement,bool).frameworkElement'></a>

`frameworkElement` [System\.Windows\.FrameworkElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.frameworkelement 'System\.Windows\.FrameworkElement')

The [System\.Windows\.FrameworkElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.frameworkelement 'System\.Windows\.FrameworkElement') to be translated\.

<a name='DiGi.Translate.WPF.Modify.TranslateFrameworkElement(thisDiGi.Translate.Classes.Translator,System.Windows.FrameworkElement,bool).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to recursively translate nested child elements\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the element was successfully translated; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Translate.WPF.Modify.TranslateWindow(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Window,bool)'></a>

## Modify\.TranslateWindow\(this TranslationModel, Language, Window, bool\) Method

Translates the specified WPF window and its elements using the provided translation model and language\.

```csharp
public static bool TranslateWindow(this DiGi.Translate.Classes.TranslationModel? translationModel, DiGi.Translate.Classes.Language? language, System.Windows.Window? window, bool includeNested=true);
```
#### Parameters

<a name='DiGi.Translate.WPF.Modify.TranslateWindow(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Window,bool).translationModel'></a>

`translationModel` [DiGi\.Translate\.Classes\.TranslationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.translationmodel 'DiGi\.Translate\.Classes\.TranslationModel')

The translation model used to retrieve localized text\.

<a name='DiGi.Translate.WPF.Modify.TranslateWindow(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Window,bool).language'></a>

`language` [DiGi\.Translate\.Classes\.Language](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.language 'DiGi\.Translate\.Classes\.Language')

The target language for the translation\.

<a name='DiGi.Translate.WPF.Modify.TranslateWindow(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Window,bool).window'></a>

`window` [System\.Windows\.Window](https://learn.microsoft.com/en-us/dotnet/api/system.windows.window 'System\.Windows\.Window')

The WPF window instance to translate\.

<a name='DiGi.Translate.WPF.Modify.TranslateWindow(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Window,bool).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to recursively translate nested framework elements within the window\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the window was successfully translated; otherwise, false\.

<a name='DiGi.Translate.WPF.Modify.TranslateWindow(thisDiGi.Translate.Classes.Translator,System.Windows.Window,bool)'></a>

## Modify\.TranslateWindow\(this Translator, Window, bool\) Method

Translates the specified window and its components using the provided translator instance\.

```csharp
public static bool TranslateWindow(this DiGi.Translate.Classes.Translator? translator, System.Windows.Window? window, bool includeNested=true);
```
#### Parameters

<a name='DiGi.Translate.WPF.Modify.TranslateWindow(thisDiGi.Translate.Classes.Translator,System.Windows.Window,bool).translator'></a>

`translator` [DiGi\.Translate\.Classes\.Translator](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.translator 'DiGi\.Translate\.Classes\.Translator')

The translator used to retrieve translated text\.

<a name='DiGi.Translate.WPF.Modify.TranslateWindow(thisDiGi.Translate.Classes.Translator,System.Windows.Window,bool).window'></a>

`window` [System\.Windows\.Window](https://learn.microsoft.com/en-us/dotnet/api/system.windows.window 'System\.Windows\.Window')

The WPF window to translate\.

<a name='DiGi.Translate.WPF.Modify.TranslateWindow(thisDiGi.Translate.Classes.Translator,System.Windows.Window,bool).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Indicates whether nested elements within the window should also be translated\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the translation was successfully applied; otherwise, false\.

<a name='DiGi.Translate.WPF.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.Translate.WPF.Query.Controls(thisSystem.Windows.Forms.Form)'></a>

## Query\.Controls\(this Form\) Method

Retrieves a list of all controls contained within the specified form\.

```csharp
public static System.Collections.Generic.List<System.Windows.Forms.Control>? Controls(this System.Windows.Forms.Form? form);
```
#### Parameters

<a name='DiGi.Translate.WPF.Query.Controls(thisSystem.Windows.Forms.Form).form'></a>

`form` [System\.Windows\.Forms\.Form](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.form 'System\.Windows\.Forms\.Form')

The form whose controls are to be retrieved\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Windows\.Forms\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control 'System\.Windows\.Forms\.Control')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [System\.Windows\.Forms\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control 'System\.Windows\.Forms\.Control') objects if the form and its controls collection exist; otherwise, null\.

<a name='DiGi.Translate.WPF.Query.Controls_T_(thisSystem.Windows.Forms.Control)'></a>

## Query\.Controls\<T\>\(this Control\) Method

Retrieves the collection of child controls for the specified control\.

```csharp
public static System.Collections.Generic.List<T>? Controls<T>(this System.Windows.Forms.Control? control)
    where T : System.Windows.Forms.Control;
```
#### Type parameters

<a name='DiGi.Translate.WPF.Query.Controls_T_(thisSystem.Windows.Forms.Control).T'></a>

`T`

The type of the controls to be returned\.
#### Parameters

<a name='DiGi.Translate.WPF.Query.Controls_T_(thisSystem.Windows.Forms.Control).control'></a>

`control` [System\.Windows\.Forms\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control 'System\.Windows\.Forms\.Control')

The control whose children are being retrieved\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Translate.WPF.md#DiGi.Translate.WPF.Query.Controls_T_(thisSystem.Windows.Forms.Control).T 'DiGi\.Translate\.WPF\.Query\.Controls\<T\>\(this System\.Windows\.Forms\.Control\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing the child controls of type [T](DiGi.Translate.WPF.md#DiGi.Translate.WPF.Query.Controls_T_(thisSystem.Windows.Forms.Control).T 'DiGi\.Translate\.WPF\.Query\.Controls\<T\>\(this System\.Windows\.Forms\.Control\)\.T'), or null if the collection is unavailable\.

<a name='DiGi.Translate.WPF.Query.Controls_T_(thisSystem.Windows.Forms.Control,string,DiGi.Core.Enums.TextComparisonType,bool)'></a>

## Query\.Controls\<T\>\(this Control, string, TextComparisonType, bool\) Method

Finds all controls of a specified type that match the provided text criteria within the control hierarchy\.

```csharp
public static System.Collections.Generic.List<T>? Controls<T>(this System.Windows.Forms.Control? control, string? text, DiGi.Core.Enums.TextComparisonType textComparisonType, bool caseSensitive=true)
    where T : System.Windows.Forms.Control;
```
#### Type parameters

<a name='DiGi.Translate.WPF.Query.Controls_T_(thisSystem.Windows.Forms.Control,string,DiGi.Core.Enums.TextComparisonType,bool).T'></a>

`T`

The type of [System\.Windows\.Forms\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control 'System\.Windows\.Forms\.Control') to search for\.
#### Parameters

<a name='DiGi.Translate.WPF.Query.Controls_T_(thisSystem.Windows.Forms.Control,string,DiGi.Core.Enums.TextComparisonType,bool).control'></a>

`control` [System\.Windows\.Forms\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control 'System\.Windows\.Forms\.Control')

The root control to begin the search from\.

<a name='DiGi.Translate.WPF.Query.Controls_T_(thisSystem.Windows.Forms.Control,string,DiGi.Core.Enums.TextComparisonType,bool).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The text value used for comparison\.

<a name='DiGi.Translate.WPF.Query.Controls_T_(thisSystem.Windows.Forms.Control,string,DiGi.Core.Enums.TextComparisonType,bool).textComparisonType'></a>

`textComparisonType` [DiGi\.Core\.Enums\.TextComparisonType](https://learn.microsoft.com/en-us/dotnet/api/digi.core.enums.textcomparisontype 'DiGi\.Core\.Enums\.TextComparisonType')

The method used to compare the text strings\.

<a name='DiGi.Translate.WPF.Query.Controls_T_(thisSystem.Windows.Forms.Control,string,DiGi.Core.Enums.TextComparisonType,bool).caseSensitive'></a>

`caseSensitive` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the comparison should be case\-sensitive\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Translate.WPF.md#DiGi.Translate.WPF.Query.Controls_T_(thisSystem.Windows.Forms.Control,string,DiGi.Core.Enums.TextComparisonType,bool).T 'DiGi\.Translate\.WPF\.Query\.Controls\<T\>\(this System\.Windows\.Forms\.Control, string, DiGi\.Core\.Enums\.TextComparisonType, bool\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of controls of type [T](DiGi.Translate.WPF.md#DiGi.Translate.WPF.Query.Controls_T_(thisSystem.Windows.Forms.Control,string,DiGi.Core.Enums.TextComparisonType,bool).T 'DiGi\.Translate\.WPF\.Query\.Controls\<T\>\(this System\.Windows\.Forms\.Control, string, DiGi\.Core\.Enums\.TextComparisonType, bool\)\.T') that match the criteria, or `null` if the root control is null\.

<a name='DiGi.Translate.WPF.Query.Controls_T_(thisSystem.Windows.Forms.Form)'></a>

## Query\.Controls\<T\>\(this Form\) Method

Retrieves a list of all controls of a specified type contained within the given form\.

```csharp
public static System.Collections.Generic.List<T>? Controls<T>(this System.Windows.Forms.Form? form)
    where T : System.Windows.Forms.Control;
```
#### Type parameters

<a name='DiGi.Translate.WPF.Query.Controls_T_(thisSystem.Windows.Forms.Form).T'></a>

`T`

The type of [System\.Windows\.Forms\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control 'System\.Windows\.Forms\.Control') to retrieve\.
#### Parameters

<a name='DiGi.Translate.WPF.Query.Controls_T_(thisSystem.Windows.Forms.Form).form'></a>

`form` [System\.Windows\.Forms\.Form](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.form 'System\.Windows\.Forms\.Form')

The form whose controls are to be retrieved\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Translate.WPF.md#DiGi.Translate.WPF.Query.Controls_T_(thisSystem.Windows.Forms.Form).T 'DiGi\.Translate\.WPF\.Query\.Controls\<T\>\(this System\.Windows\.Forms\.Form\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of controls of type [T](DiGi.Translate.WPF.md#DiGi.Translate.WPF.Query.Controls_T_(thisSystem.Windows.Forms.Form).T 'DiGi\.Translate\.WPF\.Query\.Controls\<T\>\(this System\.Windows\.Forms\.Form\)\.T') if the form and its controls collection exist; otherwise, null\.

<a name='DiGi.Translate.WPF.Query.DependencyObjects_TDependencyObject_(thisSystem.Windows.DependencyObject,bool)'></a>

## Query\.DependencyObjects\<TDependencyObject\>\(this DependencyObject, bool\) Method

Retrieves a collection of child dependency objects from the specified [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject')\.

```csharp
public static System.Collections.Generic.List<TDependencyObject>? DependencyObjects<TDependencyObject>(this System.Windows.DependencyObject dependencyObject, bool includeNested=true)
    where TDependencyObject : System.Windows.DependencyObject;
```
#### Type parameters

<a name='DiGi.Translate.WPF.Query.DependencyObjects_TDependencyObject_(thisSystem.Windows.DependencyObject,bool).TDependencyObject'></a>

`TDependencyObject`

The type of dependency object to be retrieved\.
#### Parameters

<a name='DiGi.Translate.WPF.Query.DependencyObjects_TDependencyObject_(thisSystem.Windows.DependencyObject,bool).dependencyObject'></a>

`dependencyObject` [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject')

The source dependency object to query for children\.

<a name='DiGi.Translate.WPF.Query.DependencyObjects_TDependencyObject_(thisSystem.Windows.DependencyObject,bool).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Indicates whether to include nested child elements in the search\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TDependencyObject](DiGi.Translate.WPF.md#DiGi.Translate.WPF.Query.DependencyObjects_TDependencyObject_(thisSystem.Windows.DependencyObject,bool).TDependencyObject 'DiGi\.Translate\.WPF\.Query\.DependencyObjects\<TDependencyObject\>\(this System\.Windows\.DependencyObject, bool\)\.TDependencyObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing the found dependency objects, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if no children are available\.

<a name='DiGi.Translate.WPF.Query.Id(thisSystem.Windows.Controls.DataGridColumn,System.Windows.Controls.DataGrid)'></a>

## Query\.Id\(this DataGridColumn, DataGrid\) Method

Retrieves the unique identifier for the specified data grid column within the provided data grid\.

```csharp
public static string? Id(this System.Windows.Controls.DataGridColumn dataGridColumn, System.Windows.Controls.DataGrid dataGrid);
```
#### Parameters

<a name='DiGi.Translate.WPF.Query.Id(thisSystem.Windows.Controls.DataGridColumn,System.Windows.Controls.DataGrid).dataGridColumn'></a>

`dataGridColumn` [System\.Windows\.Controls\.DataGridColumn](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.datagridcolumn 'System\.Windows\.Controls\.DataGridColumn')

The data grid column to identify\.

<a name='DiGi.Translate.WPF.Query.Id(thisSystem.Windows.Controls.DataGridColumn,System.Windows.Controls.DataGrid).dataGrid'></a>

`dataGrid` [System\.Windows\.Controls\.DataGrid](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.datagrid 'System\.Windows\.Controls\.DataGrid')

The data grid containing the column\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The unique identifier of the column if successful; otherwise, `null`\.

<a name='DiGi.Translate.WPF.Query.Id(thisSystem.Windows.DependencyObject)'></a>

## Query\.Id\(this DependencyObject\) Method

Retrieves a unique identifier for the specified [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject')\.

```csharp
public static string? Id(this System.Windows.DependencyObject? dependencyObject);
```
#### Parameters

<a name='DiGi.Translate.WPF.Query.Id(thisSystem.Windows.DependencyObject).dependencyObject'></a>

`dependencyObject` [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject')

The dependency object to evaluate\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The identifier string based on the element's name, type, or index; otherwise, `null`\.

<a name='DiGi.Translate.WPF.Query.Id(thisSystem.Windows.Forms.Control)'></a>

## Query\.Id\(this Control\) Method

Retrieves a unique identifier for the specified WPF control, prioritizing its name and falling back to its type name\.

```csharp
public static string? Id(this System.Windows.Forms.Control? control);
```
#### Parameters

<a name='DiGi.Translate.WPF.Query.Id(thisSystem.Windows.Forms.Control).control'></a>

`control` [System\.Windows\.Forms\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control 'System\.Windows\.Forms\.Control')

The control to retrieve the identifier from\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The identifier of the control, or null if the provided control is null\.

<a name='DiGi.Translate.WPF.Query.Id(thisSystem.Windows.Forms.DataGridViewColumn)'></a>

## Query\.Id\(this DataGridViewColumn\) Method

Retrieves the unique identifier for the specified [System\.Windows\.Forms\.DataGridViewColumn](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridviewcolumn 'System\.Windows\.Forms\.DataGridViewColumn')\.

```csharp
public static string? Id(this System.Windows.Forms.DataGridViewColumn? dataGridViewColumn);
```
#### Parameters

<a name='DiGi.Translate.WPF.Query.Id(thisSystem.Windows.Forms.DataGridViewColumn).dataGridViewColumn'></a>

`dataGridViewColumn` [System\.Windows\.Forms\.DataGridViewColumn](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridviewcolumn 'System\.Windows\.Forms\.DataGridViewColumn')

The data grid column to identify\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The unique identifier of the column, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the provided column is null\.

<a name='DiGi.Translate.WPF.Query.Text(thisSystem.Windows.DependencyObject)'></a>

## Query\.Text\(this DependencyObject\) Method

Extracts the text content from the specified dependency object\.

```csharp
public static string? Text(this System.Windows.DependencyObject dependencyObject);
```
#### Parameters

<a name='DiGi.Translate.WPF.Query.Text(thisSystem.Windows.DependencyObject).dependencyObject'></a>

`dependencyObject` [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject')

The dependency object to retrieve text from\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The extracted text string if the object supports it; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Translate.WPF.Query.TextDictionary(thisSystem.Windows.Controls.DataGrid)'></a>

## Query\.TextDictionary\(this DataGrid\) Method

Extracts a dictionary of column identifiers and their associated text from the specified [System\.Windows\.Controls\.DataGrid](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.datagrid 'System\.Windows\.Controls\.DataGrid')\.

```csharp
public static System.Collections.Generic.Dictionary<string,string?>? TextDictionary(this System.Windows.Controls.DataGrid? dataGrid);
```
#### Parameters

<a name='DiGi.Translate.WPF.Query.TextDictionary(thisSystem.Windows.Controls.DataGrid).dataGrid'></a>

`dataGrid` [System\.Windows\.Controls\.DataGrid](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.datagrid 'System\.Windows\.Controls\.DataGrid')

The [System\.Windows\.Controls\.DataGrid](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.datagrid 'System\.Windows\.Controls\.DataGrid') to extract text from\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary mapping column IDs to their display text, or `null` if the [dataGrid](DiGi.Translate.WPF.md#DiGi.Translate.WPF.Query.TextDictionary(thisSystem.Windows.Controls.DataGrid).dataGrid 'DiGi\.Translate\.WPF\.Query\.TextDictionary\(this System\.Windows\.Controls\.DataGrid\)\.dataGrid') is null or contains no columns\.

<a name='DiGi.Translate.WPF.Query.TextDictionary(thisSystem.Windows.Forms.DataGridView)'></a>

## Query\.TextDictionary\(this DataGridView\) Method

Extracts a dictionary of text values from the columns of the specified [System\.Windows\.Forms\.DataGridView](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview 'System\.Windows\.Forms\.DataGridView')\.

```csharp
public static System.Collections.Generic.Dictionary<string,string?>? TextDictionary(this System.Windows.Forms.DataGridView? dataGridView);
```
#### Parameters

<a name='DiGi.Translate.WPF.Query.TextDictionary(thisSystem.Windows.Forms.DataGridView).dataGridView'></a>

`dataGridView` [System\.Windows\.Forms\.DataGridView](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview 'System\.Windows\.Forms\.DataGridView')

The [System\.Windows\.Forms\.DataGridView](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview 'System\.Windows\.Forms\.DataGridView') to process\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A [System\.Collections\.Generic\.Dictionary&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2') mapping column identifiers to their text values, or `null` if the [dataGridView](DiGi.Translate.WPF.md#DiGi.Translate.WPF.Query.TextDictionary(thisSystem.Windows.Forms.DataGridView).dataGridView 'DiGi\.Translate\.WPF\.Query\.TextDictionary\(this System\.Windows\.Forms\.DataGridView\)\.dataGridView') is null or contains no columns\.

<a name='DiGi.Translate.WPF.Query.TextDictionary_TControl_(thisSystem.Windows.Forms.Control)'></a>

## Query\.TextDictionary\<TControl\>\(this Control\) Method

Extracts a dictionary of text values from the specified control and its descendants of type [TControl](DiGi.Translate.WPF.md#DiGi.Translate.WPF.Query.TextDictionary_TControl_(thisSystem.Windows.Forms.Control).TControl 'DiGi\.Translate\.WPF\.Query\.TextDictionary\<TControl\>\(this System\.Windows\.Forms\.Control\)\.TControl')\.

```csharp
public static System.Collections.Generic.Dictionary<string,string?>? TextDictionary<TControl>(this System.Windows.Forms.Control? control)
    where TControl : System.Windows.Forms.Control;
```
#### Type parameters

<a name='DiGi.Translate.WPF.Query.TextDictionary_TControl_(thisSystem.Windows.Forms.Control).TControl'></a>

`TControl`

The type of controls to search for within the control hierarchy\.
#### Parameters

<a name='DiGi.Translate.WPF.Query.TextDictionary_TControl_(thisSystem.Windows.Forms.Control).control'></a>

`control` [System\.Windows\.Forms\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control 'System\.Windows\.Forms\.Control')

The source control to analyze\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary containing the extracted text keys and values, or null if the control is null or no matching descendants are found\.

<a name='DiGi.Translate.WPF.Query.TextDictionary_TDependencyObject_(thisSystem.Windows.DependencyObject)'></a>

## Query\.TextDictionary\<TDependencyObject\>\(this DependencyObject\) Method

Extracts a dictionary of text entries from the specified dependency object and its descendants of type [TDependencyObject](DiGi.Translate.WPF.md#DiGi.Translate.WPF.Query.TextDictionary_TDependencyObject_(thisSystem.Windows.DependencyObject).TDependencyObject 'DiGi\.Translate\.WPF\.Query\.TextDictionary\<TDependencyObject\>\(this System\.Windows\.DependencyObject\)\.TDependencyObject')\.

```csharp
public static System.Collections.Generic.Dictionary<string,string?>? TextDictionary<TDependencyObject>(this System.Windows.DependencyObject? dependencyObject)
    where TDependencyObject : System.Windows.DependencyObject;
```
#### Type parameters

<a name='DiGi.Translate.WPF.Query.TextDictionary_TDependencyObject_(thisSystem.Windows.DependencyObject).TDependencyObject'></a>

`TDependencyObject`

The type of dependency objects to be queried for text\.
#### Parameters

<a name='DiGi.Translate.WPF.Query.TextDictionary_TDependencyObject_(thisSystem.Windows.DependencyObject).dependencyObject'></a>

`dependencyObject` [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject')

The root dependency object from which to extract the text dictionary\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary containing the extracted text entries, or null if the specified dependency object is null or no matching descendants are found\.

<a name='DiGi.Translate.WPF.Query.TryGetIndex(thisSystem.Windows.Controls.DataGridColumn,System.Windows.Controls.DataGrid,int)'></a>

## Query\.TryGetIndex\(this DataGridColumn, DataGrid, int\) Method

Attempts to retrieve the index of the specified [System\.Windows\.Controls\.DataGridColumn](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.datagridcolumn 'System\.Windows\.Controls\.DataGridColumn') within the provided [System\.Windows\.Controls\.DataGrid](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.datagrid 'System\.Windows\.Controls\.DataGrid')\.

```csharp
public static bool TryGetIndex(this System.Windows.Controls.DataGridColumn? dataGridColumn, System.Windows.Controls.DataGrid? dataGrid, out int index);
```
#### Parameters

<a name='DiGi.Translate.WPF.Query.TryGetIndex(thisSystem.Windows.Controls.DataGridColumn,System.Windows.Controls.DataGrid,int).dataGridColumn'></a>

`dataGridColumn` [System\.Windows\.Controls\.DataGridColumn](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.datagridcolumn 'System\.Windows\.Controls\.DataGridColumn')

The [System\.Windows\.Controls\.DataGridColumn](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.datagridcolumn 'System\.Windows\.Controls\.DataGridColumn') to locate\.

<a name='DiGi.Translate.WPF.Query.TryGetIndex(thisSystem.Windows.Controls.DataGridColumn,System.Windows.Controls.DataGrid,int).dataGrid'></a>

`dataGrid` [System\.Windows\.Controls\.DataGrid](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.datagrid 'System\.Windows\.Controls\.DataGrid')

The [System\.Windows\.Controls\.DataGrid](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.datagrid 'System\.Windows\.Controls\.DataGrid') containing the columns\.

<a name='DiGi.Translate.WPF.Query.TryGetIndex(thisSystem.Windows.Controls.DataGridColumn,System.Windows.Controls.DataGrid,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

When this method returns, contains the zero\-based index of the column if found; otherwise, \-1\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the index was successfully retrieved; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Translate.WPF.Query.TryGetIndex(thisSystem.Windows.DependencyObject,int)'></a>

## Query\.TryGetIndex\(this DependencyObject, int\) Method

Attempts to retrieve the zero\-based index of the specified [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject') relative to its parent's children in the logical tree\.

```csharp
public static bool TryGetIndex(this System.Windows.DependencyObject dependencyObject, out int index);
```
#### Parameters

<a name='DiGi.Translate.WPF.Query.TryGetIndex(thisSystem.Windows.DependencyObject,int).dependencyObject'></a>

`dependencyObject` [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject')

The [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject') for which to determine the index\.

<a name='DiGi.Translate.WPF.Query.TryGetIndex(thisSystem.Windows.DependencyObject,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

When this method returns, contains the zero\-based index of the object if found; otherwise, \-1\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the index was successfully retrieved; otherwise, false\.
## DiGi\.Translate\.Framework Namespace
### Classes

<a name='DiGi.Translate.Framework.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.Translate.Framework.Modify.Add(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Forms.Control,bool,bool)'></a>

## Modify\.Add\(this TranslationModel, Language, Control, bool, bool\) Method

Adds a translation entry for the specified control to the translation model\.

```csharp
public static bool Add(this DiGi.Translate.Classes.TranslationModel translationModel, DiGi.Translate.Classes.Language language, System.Windows.Forms.Control control, bool includeNullOrEmpty=false, bool includeNested=true);
```
#### Parameters

<a name='DiGi.Translate.Framework.Modify.Add(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Forms.Control,bool,bool).translationModel'></a>

`translationModel` [DiGi\.Translate\.Classes\.TranslationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.translationmodel 'DiGi\.Translate\.Classes\.TranslationModel')

The [DiGi\.Translate\.Classes\.TranslationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.translationmodel 'DiGi\.Translate\.Classes\.TranslationModel') instance to which the translation will be added\.

<a name='DiGi.Translate.Framework.Modify.Add(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Forms.Control,bool,bool).language'></a>

`language` [DiGi\.Translate\.Classes\.Language](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.language 'DiGi\.Translate\.Classes\.Language')

The [DiGi\.Translate\.Classes\.Language](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.language 'DiGi\.Translate\.Classes\.Language') associated with the translation\.

<a name='DiGi.Translate.Framework.Modify.Add(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Forms.Control,bool,bool).control'></a>

`control` [System\.Windows\.Forms\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control 'System\.Windows\.Forms\.Control')

The [System\.Windows\.Forms\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control 'System\.Windows\.Forms\.Control') whose text is to be extracted and translated\.

<a name='DiGi.Translate.Framework.Modify.Add(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Forms.Control,bool,bool).includeNullOrEmpty'></a>

`includeNullOrEmpty` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether controls with null or empty text should be included\. Defaults to `false`\.

<a name='DiGi.Translate.Framework.Modify.Add(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Forms.Control,bool,bool).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether nested child controls should also be processed\. Defaults to `true`\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the translation was successfully added; otherwise, `false`\.

<a name='DiGi.Translate.Framework.Modify.SetText(thisSystem.Windows.DependencyObject,string)'></a>

## Modify\.SetText\(this DependencyObject, string\) Method

Sets the text content of the specified dependency object if it supports a text property\.

```csharp
public static bool SetText(this System.Windows.DependencyObject dependencyObject, string text);
```
#### Parameters

<a name='DiGi.Translate.Framework.Modify.SetText(thisSystem.Windows.DependencyObject,string).dependencyObject'></a>

`dependencyObject` [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject')

The [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject') whose text is to be set\.

<a name='DiGi.Translate.Framework.Modify.SetText(thisSystem.Windows.DependencyObject,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string value to assign as the text\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the text was successfully set; otherwise, false\.

<a name='DiGi.Translate.Framework.Modify.TranslateControl(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Forms.Control,bool)'></a>

## Modify\.TranslateControl\(this TranslationModel, Language, Control, bool\) Method

Translates the text of the specified control using the provided translation model and language\.

```csharp
public static bool TranslateControl(this DiGi.Translate.Classes.TranslationModel translationModel, DiGi.Translate.Classes.Language language, System.Windows.Forms.Control control, bool includeNested=true);
```
#### Parameters

<a name='DiGi.Translate.Framework.Modify.TranslateControl(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Forms.Control,bool).translationModel'></a>

`translationModel` [DiGi\.Translate\.Classes\.TranslationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.translationmodel 'DiGi\.Translate\.Classes\.TranslationModel')

The translation model used to retrieve translated text\.

<a name='DiGi.Translate.Framework.Modify.TranslateControl(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Forms.Control,bool).language'></a>

`language` [DiGi\.Translate\.Classes\.Language](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.language 'DiGi\.Translate\.Classes\.Language')

The target language for the translation\.

<a name='DiGi.Translate.Framework.Modify.TranslateControl(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Forms.Control,bool).control'></a>

`control` [System\.Windows\.Forms\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control 'System\.Windows\.Forms\.Control')

The control whose text is to be translated\.

<a name='DiGi.Translate.Framework.Modify.TranslateControl(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Forms.Control,bool).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to recursively translate nested controls\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the control's text was successfully translated; otherwise, false\.

<a name='DiGi.Translate.Framework.Modify.TranslateControl(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Enums.Language,System.Windows.Forms.Control,bool)'></a>

## Modify\.TranslateControl\(this TranslationModel, Language, Control, bool\) Method

Translates the specified control and optionally its nested children using the provided translation model and language\.

```csharp
public static bool TranslateControl(this DiGi.Translate.Classes.TranslationModel translationModel, DiGi.Translate.Enums.Language language, System.Windows.Forms.Control control, bool includeNested=true);
```
#### Parameters

<a name='DiGi.Translate.Framework.Modify.TranslateControl(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Enums.Language,System.Windows.Forms.Control,bool).translationModel'></a>

`translationModel` [DiGi\.Translate\.Classes\.TranslationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.translationmodel 'DiGi\.Translate\.Classes\.TranslationModel')

The translation model used to retrieve translated text\.

<a name='DiGi.Translate.Framework.Modify.TranslateControl(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Enums.Language,System.Windows.Forms.Control,bool).language'></a>

`language` [DiGi\.Translate\.Enums\.Language](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.enums.language 'DiGi\.Translate\.Enums\.Language')

The target language for the translation\.

<a name='DiGi.Translate.Framework.Modify.TranslateControl(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Enums.Language,System.Windows.Forms.Control,bool).control'></a>

`control` [System\.Windows\.Forms\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control 'System\.Windows\.Forms\.Control')

The control to be translated\.

<a name='DiGi.Translate.Framework.Modify.TranslateControl(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Enums.Language,System.Windows.Forms.Control,bool).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to recursively translate nested controls\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the translation process was successful; otherwise, false\.

<a name='DiGi.Translate.Framework.Modify.TranslateControl(thisDiGi.Translate.Classes.Translator,System.Windows.Forms.Control,bool)'></a>

## Modify\.TranslateControl\(this Translator, Control, bool\) Method

Translates the specified control and optionally its nested children using the provided translator\.

```csharp
public static bool TranslateControl(this DiGi.Translate.Classes.Translator translator, System.Windows.Forms.Control control, bool includeNested=true);
```
#### Parameters

<a name='DiGi.Translate.Framework.Modify.TranslateControl(thisDiGi.Translate.Classes.Translator,System.Windows.Forms.Control,bool).translator'></a>

`translator` [DiGi\.Translate\.Classes\.Translator](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.translator 'DiGi\.Translate\.Classes\.Translator')

The translator instance used to retrieve translated text\.

<a name='DiGi.Translate.Framework.Modify.TranslateControl(thisDiGi.Translate.Classes.Translator,System.Windows.Forms.Control,bool).control'></a>

`control` [System\.Windows\.Forms\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control 'System\.Windows\.Forms\.Control')

The control to be translated\.

<a name='DiGi.Translate.Framework.Modify.TranslateControl(thisDiGi.Translate.Classes.Translator,System.Windows.Forms.Control,bool).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to recursively translate child controls\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the translation process was successful; otherwise, false\.

<a name='DiGi.Translate.Framework.Modify.TranslateForm(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Forms.Form,bool)'></a>

## Modify\.TranslateForm\(this TranslationModel, Language, Form, bool\) Method

Translates the specified form using the provided translation model and target language\.

```csharp
public static bool TranslateForm(this DiGi.Translate.Classes.TranslationModel translationModel, DiGi.Translate.Classes.Language language, System.Windows.Forms.Form form, bool includeNested=true);
```
#### Parameters

<a name='DiGi.Translate.Framework.Modify.TranslateForm(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Forms.Form,bool).translationModel'></a>

`translationModel` [DiGi\.Translate\.Classes\.TranslationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.translationmodel 'DiGi\.Translate\.Classes\.TranslationModel')

The translation model used to retrieve localized strings\.

<a name='DiGi.Translate.Framework.Modify.TranslateForm(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Forms.Form,bool).language'></a>

`language` [DiGi\.Translate\.Classes\.Language](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.language 'DiGi\.Translate\.Classes\.Language')

The target language for the translation\.

<a name='DiGi.Translate.Framework.Modify.TranslateForm(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Forms.Form,bool).form'></a>

`form` [System\.Windows\.Forms\.Form](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.form 'System\.Windows\.Forms\.Form')

The form instance to be translated\.

<a name='DiGi.Translate.Framework.Modify.TranslateForm(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Forms.Form,bool).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether nested controls within the form should also be translated\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the form was successfully translated; otherwise, false\.

<a name='DiGi.Translate.Framework.Modify.TranslateForm(thisDiGi.Translate.Classes.Translator,System.Windows.Forms.Form,bool)'></a>

## Modify\.TranslateForm\(this Translator, Form, bool\) Method

Translates the specified form using the provided translator instance\.

```csharp
public static bool TranslateForm(this DiGi.Translate.Classes.Translator translator, System.Windows.Forms.Form form, bool includeNested=true);
```
#### Parameters

<a name='DiGi.Translate.Framework.Modify.TranslateForm(thisDiGi.Translate.Classes.Translator,System.Windows.Forms.Form,bool).translator'></a>

`translator` [DiGi\.Translate\.Classes\.Translator](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.translator 'DiGi\.Translate\.Classes\.Translator')

The [DiGi\.Translate\.Classes\.Translator](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.translator 'DiGi\.Translate\.Classes\.Translator') used to retrieve translated text\.

<a name='DiGi.Translate.Framework.Modify.TranslateForm(thisDiGi.Translate.Classes.Translator,System.Windows.Forms.Form,bool).form'></a>

`form` [System\.Windows\.Forms\.Form](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.form 'System\.Windows\.Forms\.Form')

The [System\.Windows\.Forms\.Form](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.form 'System\.Windows\.Forms\.Form') to be translated\.

<a name='DiGi.Translate.Framework.Modify.TranslateForm(thisDiGi.Translate.Classes.Translator,System.Windows.Forms.Form,bool).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether nested controls within the form should also be translated\. Defaults to `true`\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the form was successfully translated; otherwise, `false`\.

<a name='DiGi.Translate.Framework.Modify.TranslateFrameworkElement(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.FrameworkElement,bool)'></a>

## Modify\.TranslateFrameworkElement\(this TranslationModel, Language, FrameworkElement, bool\) Method

Translates the specified [System\.Windows\.FrameworkElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.frameworkelement 'System\.Windows\.FrameworkElement') using the provided translation model and language\.

```csharp
public static bool TranslateFrameworkElement(this DiGi.Translate.Classes.TranslationModel translationModel, DiGi.Translate.Classes.Language language, System.Windows.FrameworkElement frameworkElement, bool includeNested=true);
```
#### Parameters

<a name='DiGi.Translate.Framework.Modify.TranslateFrameworkElement(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.FrameworkElement,bool).translationModel'></a>

`translationModel` [DiGi\.Translate\.Classes\.TranslationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.translationmodel 'DiGi\.Translate\.Classes\.TranslationModel')

The translation model used to retrieve translated text\.

<a name='DiGi.Translate.Framework.Modify.TranslateFrameworkElement(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.FrameworkElement,bool).language'></a>

`language` [DiGi\.Translate\.Classes\.Language](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.language 'DiGi\.Translate\.Classes\.Language')

The target language for the translation\.

<a name='DiGi.Translate.Framework.Modify.TranslateFrameworkElement(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.FrameworkElement,bool).frameworkElement'></a>

`frameworkElement` [System\.Windows\.FrameworkElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.frameworkelement 'System\.Windows\.FrameworkElement')

The framework element to translate\.

<a name='DiGi.Translate.Framework.Modify.TranslateFrameworkElement(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.FrameworkElement,bool).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to recursively translate nested child elements\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the element was successfully translated; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Translate.Framework.Modify.TranslateFrameworkElement(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Enums.Language,System.Windows.FrameworkElement,bool)'></a>

## Modify\.TranslateFrameworkElement\(this TranslationModel, Language, FrameworkElement, bool\) Method

Translates the specified framework element into the target language using the provided translation model\.

```csharp
public static bool TranslateFrameworkElement(this DiGi.Translate.Classes.TranslationModel translationModel, DiGi.Translate.Enums.Language language, System.Windows.FrameworkElement frameworkElement, bool includeNested=true);
```
#### Parameters

<a name='DiGi.Translate.Framework.Modify.TranslateFrameworkElement(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Enums.Language,System.Windows.FrameworkElement,bool).translationModel'></a>

`translationModel` [DiGi\.Translate\.Classes\.TranslationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.translationmodel 'DiGi\.Translate\.Classes\.TranslationModel')

The translation model used to retrieve translated text\.

<a name='DiGi.Translate.Framework.Modify.TranslateFrameworkElement(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Enums.Language,System.Windows.FrameworkElement,bool).language'></a>

`language` [DiGi\.Translate\.Enums\.Language](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.enums.language 'DiGi\.Translate\.Enums\.Language')

The target language for the translation\.

<a name='DiGi.Translate.Framework.Modify.TranslateFrameworkElement(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Enums.Language,System.Windows.FrameworkElement,bool).frameworkElement'></a>

`frameworkElement` [System\.Windows\.FrameworkElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.frameworkelement 'System\.Windows\.FrameworkElement')

The framework element to translate\.

<a name='DiGi.Translate.Framework.Modify.TranslateFrameworkElement(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Enums.Language,System.Windows.FrameworkElement,bool).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to recursively translate nested child elements\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the translation process was successful; otherwise, false\.

<a name='DiGi.Translate.Framework.Modify.TranslateFrameworkElement(thisDiGi.Translate.Classes.Translator,System.Windows.FrameworkElement,bool)'></a>

## Modify\.TranslateFrameworkElement\(this Translator, FrameworkElement, bool\) Method

Translates the specified framework element using the provided translator\.

```csharp
public static bool TranslateFrameworkElement(this DiGi.Translate.Classes.Translator translator, System.Windows.FrameworkElement frameworkElement, bool includeNested=true);
```
#### Parameters

<a name='DiGi.Translate.Framework.Modify.TranslateFrameworkElement(thisDiGi.Translate.Classes.Translator,System.Windows.FrameworkElement,bool).translator'></a>

`translator` [DiGi\.Translate\.Classes\.Translator](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.translator 'DiGi\.Translate\.Classes\.Translator')

The [DiGi\.Translate\.Classes\.Translator](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.translator 'DiGi\.Translate\.Classes\.Translator') instance used to retrieve translation strings\.

<a name='DiGi.Translate.Framework.Modify.TranslateFrameworkElement(thisDiGi.Translate.Classes.Translator,System.Windows.FrameworkElement,bool).frameworkElement'></a>

`frameworkElement` [System\.Windows\.FrameworkElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.frameworkelement 'System\.Windows\.FrameworkElement')

The [System\.Windows\.FrameworkElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.frameworkelement 'System\.Windows\.FrameworkElement') to be translated\.

<a name='DiGi.Translate.Framework.Modify.TranslateFrameworkElement(thisDiGi.Translate.Classes.Translator,System.Windows.FrameworkElement,bool).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to recursively translate nested child elements\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the element was successfully translated; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Translate.Framework.Modify.TranslateWindow(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Window,bool)'></a>

## Modify\.TranslateWindow\(this TranslationModel, Language, Window, bool\) Method

Translates the specified window using the provided translation model and language\.

```csharp
public static bool TranslateWindow(this DiGi.Translate.Classes.TranslationModel translationModel, DiGi.Translate.Classes.Language language, System.Windows.Window window, bool includeNested=true);
```
#### Parameters

<a name='DiGi.Translate.Framework.Modify.TranslateWindow(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Window,bool).translationModel'></a>

`translationModel` [DiGi\.Translate\.Classes\.TranslationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.translationmodel 'DiGi\.Translate\.Classes\.TranslationModel')

The translation model used to retrieve translated text\.

<a name='DiGi.Translate.Framework.Modify.TranslateWindow(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Window,bool).language'></a>

`language` [DiGi\.Translate\.Classes\.Language](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.language 'DiGi\.Translate\.Classes\.Language')

The target language for the translation\.

<a name='DiGi.Translate.Framework.Modify.TranslateWindow(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Window,bool).window'></a>

`window` [System\.Windows\.Window](https://learn.microsoft.com/en-us/dotnet/api/system.windows.window 'System\.Windows\.Window')

The window instance to translate\.

<a name='DiGi.Translate.Framework.Modify.TranslateWindow(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Windows.Window,bool).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to recursively translate nested elements within the window\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the window was successfully translated; otherwise, false\.

<a name='DiGi.Translate.Framework.Modify.TranslateWindow(thisDiGi.Translate.Classes.Translator,System.Windows.Window,bool)'></a>

## Modify\.TranslateWindow\(this Translator, Window, bool\) Method

Translates the specified window using the provided translator\.

```csharp
public static bool TranslateWindow(this DiGi.Translate.Classes.Translator translator, System.Windows.Window window, bool includeNested=true);
```
#### Parameters

<a name='DiGi.Translate.Framework.Modify.TranslateWindow(thisDiGi.Translate.Classes.Translator,System.Windows.Window,bool).translator'></a>

`translator` [DiGi\.Translate\.Classes\.Translator](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.translator 'DiGi\.Translate\.Classes\.Translator')

The [DiGi\.Translate\.Classes\.Translator](https://learn.microsoft.com/en-us/dotnet/api/digi.translate.classes.translator 'DiGi\.Translate\.Classes\.Translator') instance used to perform the translation\.

<a name='DiGi.Translate.Framework.Modify.TranslateWindow(thisDiGi.Translate.Classes.Translator,System.Windows.Window,bool).window'></a>

`window` [System\.Windows\.Window](https://learn.microsoft.com/en-us/dotnet/api/system.windows.window 'System\.Windows\.Window')

The [System\.Windows\.Window](https://learn.microsoft.com/en-us/dotnet/api/system.windows.window 'System\.Windows\.Window') to be translated\.

<a name='DiGi.Translate.Framework.Modify.TranslateWindow(thisDiGi.Translate.Classes.Translator,System.Windows.Window,bool).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether nested elements within the window should also be translated\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the window was successfully translated; otherwise, false\.

<a name='DiGi.Translate.Framework.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.Translate.Framework.Query.Controls(thisSystem.Windows.Forms.Form)'></a>

## Query\.Controls\(this Form\) Method

Retrieves a list of all controls associated with the specified form\.

```csharp
public static System.Collections.Generic.List<System.Windows.Forms.Control> Controls(this System.Windows.Forms.Form form);
```
#### Parameters

<a name='DiGi.Translate.Framework.Query.Controls(thisSystem.Windows.Forms.Form).form'></a>

`form` [System\.Windows\.Forms\.Form](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.form 'System\.Windows\.Forms\.Form')

The form whose controls are to be retrieved\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Windows\.Forms\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control 'System\.Windows\.Forms\.Control')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [System\.Windows\.Forms\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control 'System\.Windows\.Forms\.Control') objects, or null if the form is null or its control collection is unavailable\.

<a name='DiGi.Translate.Framework.Query.Controls_T_(thisSystem.Windows.Forms.Control)'></a>

## Query\.Controls\<T\>\(this Control\) Method

Retrieves a list of controls associated with the specified control\.

```csharp
public static System.Collections.Generic.List<T> Controls<T>(this System.Windows.Forms.Control control)
    where T : System.Windows.Forms.Control;
```
#### Type parameters

<a name='DiGi.Translate.Framework.Query.Controls_T_(thisSystem.Windows.Forms.Control).T'></a>

`T`

The type of control to retrieve, which must derive from [System\.Windows\.Forms\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control 'System\.Windows\.Forms\.Control')\.
#### Parameters

<a name='DiGi.Translate.Framework.Query.Controls_T_(thisSystem.Windows.Forms.Control).control'></a>

`control` [System\.Windows\.Forms\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control 'System\.Windows\.Forms\.Control')

The control whose child controls are to be retrieved\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Translate.Framework.md#DiGi.Translate.Framework.Query.Controls_T_(thisSystem.Windows.Forms.Control).T 'DiGi\.Translate\.Framework\.Query\.Controls\<T\>\(this System\.Windows\.Forms\.Control\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of controls associated with the specified control, or null if the collection is unavailable\.

<a name='DiGi.Translate.Framework.Query.Controls_T_(thisSystem.Windows.Forms.Control,string,DiGi.Core.Enums.TextComparisonType,bool)'></a>

## Query\.Controls\<T\>\(this Control, string, TextComparisonType, bool\) Method

Retrieves a list of controls of type [T](DiGi.Translate.Framework.md#DiGi.Translate.Framework.Query.Controls_T_(thisSystem.Windows.Forms.Control,string,DiGi.Core.Enums.TextComparisonType,bool).T 'DiGi\.Translate\.Framework\.Query\.Controls\<T\>\(this System\.Windows\.Forms\.Control, string, DiGi\.Core\.Enums\.TextComparisonType, bool\)\.T') that match the specified text criteria within the control hierarchy\.

```csharp
public static System.Collections.Generic.List<T> Controls<T>(this System.Windows.Forms.Control control, string text, DiGi.Core.Enums.TextComparisonType textComparisonType, bool caseSensitive=true)
    where T : System.Windows.Forms.Control;
```
#### Type parameters

<a name='DiGi.Translate.Framework.Query.Controls_T_(thisSystem.Windows.Forms.Control,string,DiGi.Core.Enums.TextComparisonType,bool).T'></a>

`T`

The type of Control to be returned\.
#### Parameters

<a name='DiGi.Translate.Framework.Query.Controls_T_(thisSystem.Windows.Forms.Control,string,DiGi.Core.Enums.TextComparisonType,bool).control'></a>

`control` [System\.Windows\.Forms\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control 'System\.Windows\.Forms\.Control')

The root control to search from\.

<a name='DiGi.Translate.Framework.Query.Controls_T_(thisSystem.Windows.Forms.Control,string,DiGi.Core.Enums.TextComparisonType,bool).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The text value used for comparison\.

<a name='DiGi.Translate.Framework.Query.Controls_T_(thisSystem.Windows.Forms.Control,string,DiGi.Core.Enums.TextComparisonType,bool).textComparisonType'></a>

`textComparisonType` [DiGi\.Core\.Enums\.TextComparisonType](https://learn.microsoft.com/en-us/dotnet/api/digi.core.enums.textcomparisontype 'DiGi\.Core\.Enums\.TextComparisonType')

The method used to compare the strings\.

<a name='DiGi.Translate.Framework.Query.Controls_T_(thisSystem.Windows.Forms.Control,string,DiGi.Core.Enums.TextComparisonType,bool).caseSensitive'></a>

`caseSensitive` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Indicates whether the text comparison should be case\-sensitive\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Translate.Framework.md#DiGi.Translate.Framework.Query.Controls_T_(thisSystem.Windows.Forms.Control,string,DiGi.Core.Enums.TextComparisonType,bool).T 'DiGi\.Translate\.Framework\.Query\.Controls\<T\>\(this System\.Windows\.Forms\.Control, string, DiGi\.Core\.Enums\.TextComparisonType, bool\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of controls of type [T](DiGi.Translate.Framework.md#DiGi.Translate.Framework.Query.Controls_T_(thisSystem.Windows.Forms.Control,string,DiGi.Core.Enums.TextComparisonType,bool).T 'DiGi\.Translate\.Framework\.Query\.Controls\<T\>\(this System\.Windows\.Forms\.Control, string, DiGi\.Core\.Enums\.TextComparisonType, bool\)\.T') that match the criteria, or null if the source control is null\.

<a name='DiGi.Translate.Framework.Query.Controls_T_(thisSystem.Windows.Forms.Form)'></a>

## Query\.Controls\<T\>\(this Form\) Method

Retrieves a list of all controls of the specified type associated with the given form\.

```csharp
public static System.Collections.Generic.List<T> Controls<T>(this System.Windows.Forms.Form form)
    where T : System.Windows.Forms.Control;
```
#### Type parameters

<a name='DiGi.Translate.Framework.Query.Controls_T_(thisSystem.Windows.Forms.Form).T'></a>

`T`

The type of controls to retrieve\.
#### Parameters

<a name='DiGi.Translate.Framework.Query.Controls_T_(thisSystem.Windows.Forms.Form).form'></a>

`form` [System\.Windows\.Forms\.Form](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.form 'System\.Windows\.Forms\.Form')

The form whose controls are to be retrieved\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Translate.Framework.md#DiGi.Translate.Framework.Query.Controls_T_(thisSystem.Windows.Forms.Form).T 'DiGi\.Translate\.Framework\.Query\.Controls\<T\>\(this System\.Windows\.Forms\.Form\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of controls of type \<typeparam ref="T" /\>, or null if the form is null or its control collection is unavailable\.

<a name='DiGi.Translate.Framework.Query.DependencyObjects_TDependencyObject_(thisSystem.Windows.DependencyObject,bool)'></a>

## Query\.DependencyObjects\<TDependencyObject\>\(this DependencyObject, bool\) Method

Retrieves a list of child dependency objects from the specified dependency object\.

```csharp
public static System.Collections.Generic.List<TDependencyObject> DependencyObjects<TDependencyObject>(this System.Windows.DependencyObject dependencyObject, bool includeNested=true)
    where TDependencyObject : System.Windows.DependencyObject;
```
#### Type parameters

<a name='DiGi.Translate.Framework.Query.DependencyObjects_TDependencyObject_(thisSystem.Windows.DependencyObject,bool).TDependencyObject'></a>

`TDependencyObject`

The type of dependency objects to retrieve\.
#### Parameters

<a name='DiGi.Translate.Framework.Query.DependencyObjects_TDependencyObject_(thisSystem.Windows.DependencyObject,bool).dependencyObject'></a>

`dependencyObject` [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject')

The source dependency object to query\.

<a name='DiGi.Translate.Framework.Query.DependencyObjects_TDependencyObject_(thisSystem.Windows.DependencyObject,bool).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Indicates whether to recursively include nested child dependency objects\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TDependencyObject](DiGi.Translate.Framework.md#DiGi.Translate.Framework.Query.DependencyObjects_TDependencyObject_(thisSystem.Windows.DependencyObject,bool).TDependencyObject 'DiGi\.Translate\.Framework\.Query\.DependencyObjects\<TDependencyObject\>\(this System\.Windows\.DependencyObject, bool\)\.TDependencyObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of found dependency objects of type [TDependencyObject](DiGi.Translate.Framework.md#DiGi.Translate.Framework.Query.DependencyObjects_TDependencyObject_(thisSystem.Windows.DependencyObject,bool).TDependencyObject 'DiGi\.Translate\.Framework\.Query\.DependencyObjects\<TDependencyObject\>\(this System\.Windows\.DependencyObject, bool\)\.TDependencyObject'), or null if no children are present\.

<a name='DiGi.Translate.Framework.Query.Id(thisSystem.Windows.Controls.DataGridColumn,System.Windows.Controls.DataGrid)'></a>

## Query\.Id\(this DataGridColumn, DataGrid\) Method

Gets the unique identifier for the specified [System\.Windows\.Controls\.DataGridColumn](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.datagridcolumn 'System\.Windows\.Controls\.DataGridColumn') within the provided [System\.Windows\.Controls\.DataGrid](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.datagrid 'System\.Windows\.Controls\.DataGrid')\.

```csharp
public static string Id(this System.Windows.Controls.DataGridColumn dataGridColumn, System.Windows.Controls.DataGrid dataGrid);
```
#### Parameters

<a name='DiGi.Translate.Framework.Query.Id(thisSystem.Windows.Controls.DataGridColumn,System.Windows.Controls.DataGrid).dataGridColumn'></a>

`dataGridColumn` [System\.Windows\.Controls\.DataGridColumn](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.datagridcolumn 'System\.Windows\.Controls\.DataGridColumn')

The data grid column to identify\.

<a name='DiGi.Translate.Framework.Query.Id(thisSystem.Windows.Controls.DataGridColumn,System.Windows.Controls.DataGrid).dataGrid'></a>

`dataGrid` [System\.Windows\.Controls\.DataGrid](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.datagrid 'System\.Windows\.Controls\.DataGrid')

The data grid containing the column\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the unique identifier of the column, or `null` if the identifier cannot be determined\.

<a name='DiGi.Translate.Framework.Query.Id(thisSystem.Windows.DependencyObject)'></a>

## Query\.Id\(this DependencyObject\) Method

Retrieves a unique identifier for the specified dependency object based on its name, type, and index\.

```csharp
public static string Id(this System.Windows.DependencyObject dependencyObject);
```
#### Parameters

<a name='DiGi.Translate.Framework.Query.Id(thisSystem.Windows.DependencyObject).dependencyObject'></a>

`dependencyObject` [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject')

The dependency object to identify\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the identifier of the dependency object, or null if the provided object is null\.

<a name='DiGi.Translate.Framework.Query.Id(thisSystem.Windows.Forms.Control)'></a>

## Query\.Id\(this Control\) Method

Retrieves the identifier for the specified control, incorporating the control's name or type and its hierarchical path\.

```csharp
public static string Id(this System.Windows.Forms.Control control);
```
#### Parameters

<a name='DiGi.Translate.Framework.Query.Id(thisSystem.Windows.Forms.Control).control'></a>

`control` [System\.Windows\.Forms\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control 'System\.Windows\.Forms\.Control')

The control for which to retrieve the identifier\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The identifier of the control as a string, or null if the control is null\.

<a name='DiGi.Translate.Framework.Query.Id(thisSystem.Windows.Forms.DataGridViewColumn)'></a>

## Query\.Id\(this DataGridViewColumn\) Method

Gets the unique identifier for the specified [System\.Windows\.Forms\.DataGridViewColumn](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridviewcolumn 'System\.Windows\.Forms\.DataGridViewColumn')\.

```csharp
public static string Id(this System.Windows.Forms.DataGridViewColumn dataGridViewColumn);
```
#### Parameters

<a name='DiGi.Translate.Framework.Query.Id(thisSystem.Windows.Forms.DataGridViewColumn).dataGridViewColumn'></a>

`dataGridViewColumn` [System\.Windows\.Forms\.DataGridViewColumn](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridviewcolumn 'System\.Windows\.Forms\.DataGridViewColumn')

The data grid view column to identify\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The unique identifier of the column, or null if the provided column is null\.

<a name='DiGi.Translate.Framework.Query.TextDictionary(thisSystem.Windows.Forms.DataGridView)'></a>

## Query\.TextDictionary\(this DataGridView\) Method

Extracts a dictionary of text mappings from the columns of the specified [System\.Windows\.Forms\.DataGridView](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview 'System\.Windows\.Forms\.DataGridView')\.

```csharp
public static System.Collections.Generic.Dictionary<string,string> TextDictionary(this System.Windows.Forms.DataGridView dataGridView);
```
#### Parameters

<a name='DiGi.Translate.Framework.Query.TextDictionary(thisSystem.Windows.Forms.DataGridView).dataGridView'></a>

`dataGridView` [System\.Windows\.Forms\.DataGridView](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview 'System\.Windows\.Forms\.DataGridView')

The [System\.Windows\.Forms\.DataGridView](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview 'System\.Windows\.Forms\.DataGridView') instance to process\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A [System\.Collections\.Generic\.Dictionary&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2') containing column identifiers and their associated values, or `null` if the columns collection is unavailable\.

<a name='DiGi.Translate.Framework.Query.TextDictionary_TControl_(thisSystem.Windows.Forms.Control)'></a>

## Query\.TextDictionary\<TControl\>\(this Control\) Method

Extracts a dictionary of text mappings from the specified control for all child controls of type [TControl](DiGi.Translate.Framework.md#DiGi.Translate.Framework.Query.TextDictionary_TControl_(thisSystem.Windows.Forms.Control).TControl 'DiGi\.Translate\.Framework\.Query\.TextDictionary\<TControl\>\(this System\.Windows\.Forms\.Control\)\.TControl')\.

```csharp
public static System.Collections.Generic.Dictionary<string,string> TextDictionary<TControl>(this System.Windows.Forms.Control control)
    where TControl : System.Windows.Forms.Control;
```
#### Type parameters

<a name='DiGi.Translate.Framework.Query.TextDictionary_TControl_(thisSystem.Windows.Forms.Control).TControl'></a>

`TControl`

The type of control to be retrieved\.
#### Parameters

<a name='DiGi.Translate.Framework.Query.TextDictionary_TControl_(thisSystem.Windows.Forms.Control).control'></a>

`control` [System\.Windows\.Forms\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control 'System\.Windows\.Forms\.Control')

The root control to search\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary containing the text mappings, or null if the specified control is null or no matching controls are found\.

<a name='DiGi.Translate.Framework.Query.TryGetControl(thisSystem.Windows.Forms.Control,string,System.Windows.Forms.Control)'></a>

## Query\.TryGetControl\(this Control, string, Control\) Method

Attempts to retrieve a control with the specified identifier from the given control's hierarchy\.

```csharp
public static bool TryGetControl(this System.Windows.Forms.Control control, string id, out System.Windows.Forms.Control result);
```
#### Parameters

<a name='DiGi.Translate.Framework.Query.TryGetControl(thisSystem.Windows.Forms.Control,string,System.Windows.Forms.Control).control'></a>

`control` [System\.Windows\.Forms\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control 'System\.Windows\.Forms\.Control')

The root control to search within\.

<a name='DiGi.Translate.Framework.Query.TryGetControl(thisSystem.Windows.Forms.Control,string,System.Windows.Forms.Control).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier of the control to locate\.

<a name='DiGi.Translate.Framework.Query.TryGetControl(thisSystem.Windows.Forms.Control,string,System.Windows.Forms.Control).result'></a>

`result` [System\.Windows\.Forms\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control 'System\.Windows\.Forms\.Control')

When this method returns, contains the found control if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the control with the specified identifier was found; otherwise, false\.

<a name='DiGi.Translate.Framework.Query.TryGetIndex(thisSystem.Windows.Controls.DataGridColumn,System.Windows.Controls.DataGrid,int)'></a>

## Query\.TryGetIndex\(this DataGridColumn, DataGrid, int\) Method

Attempts to retrieve the index of the specified [System\.Windows\.Controls\.DataGridColumn](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.datagridcolumn 'System\.Windows\.Controls\.DataGridColumn') within the columns collection of the provided [System\.Windows\.Controls\.DataGrid](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.datagrid 'System\.Windows\.Controls\.DataGrid')\.

```csharp
public static bool TryGetIndex(this System.Windows.Controls.DataGridColumn dataGridColumn, System.Windows.Controls.DataGrid dataGrid, out int index);
```
#### Parameters

<a name='DiGi.Translate.Framework.Query.TryGetIndex(thisSystem.Windows.Controls.DataGridColumn,System.Windows.Controls.DataGrid,int).dataGridColumn'></a>

`dataGridColumn` [System\.Windows\.Controls\.DataGridColumn](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.datagridcolumn 'System\.Windows\.Controls\.DataGridColumn')

The [System\.Windows\.Controls\.DataGridColumn](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.datagridcolumn 'System\.Windows\.Controls\.DataGridColumn') for which to retrieve the index\.

<a name='DiGi.Translate.Framework.Query.TryGetIndex(thisSystem.Windows.Controls.DataGridColumn,System.Windows.Controls.DataGrid,int).dataGrid'></a>

`dataGrid` [System\.Windows\.Controls\.DataGrid](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.datagrid 'System\.Windows\.Controls\.DataGrid')

The [System\.Windows\.Controls\.DataGrid](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.datagrid 'System\.Windows\.Controls\.DataGrid') containing the columns collection\.

<a name='DiGi.Translate.Framework.Query.TryGetIndex(thisSystem.Windows.Controls.DataGridColumn,System.Windows.Controls.DataGrid,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

When this method returns, contains the index of the column if found; otherwise, \-1\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the index was successfully retrieved; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Translate.Framework.Query.TryGetIndex(thisSystem.Windows.DependencyObject,int)'></a>

## Query\.TryGetIndex\(this DependencyObject, int\) Method

Attempts to get the zero\-based index of the specified [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject') relative to its siblings in the logical tree\.

```csharp
public static bool TryGetIndex(this System.Windows.DependencyObject dependencyObject, out int index);
```
#### Parameters

<a name='DiGi.Translate.Framework.Query.TryGetIndex(thisSystem.Windows.DependencyObject,int).dependencyObject'></a>

`dependencyObject` [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject')

The [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject') for which to retrieve the index\.

<a name='DiGi.Translate.Framework.Query.TryGetIndex(thisSystem.Windows.DependencyObject,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

When this method returns, contains the zero\-based index of the object if found; otherwise, \-1\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the index was successfully retrieved; otherwise, false\.
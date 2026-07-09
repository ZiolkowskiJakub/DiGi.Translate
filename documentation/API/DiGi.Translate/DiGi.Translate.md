#### [DiGi\.Translate](DiGi.Translate.Overview.md 'DiGi\.Translate\.Overview')

## DiGi\.Translate Namespace
### Classes

<a name='DiGi.Translate.Convert'></a>

## Convert Class

```csharp
public static class Convert
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Convert
### Methods

<a name='DiGi.Translate.Convert.ToDiGi_Table(thisDiGi.Translate.Classes.TranslationModel)'></a>

## Convert\.ToDiGi\_Table\(this TranslationModel\) Method

Converts a [TranslationModel](DiGi.Translate.Classes.md#DiGi.Translate.Classes.TranslationModel 'DiGi\.Translate\.Classes\.TranslationModel') instance into a [DiGi\.Core\.IO\.Table\.Classes\.Table](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.classes.table 'DiGi\.Core\.IO\.Table\.Classes\.Table') representation\.

```csharp
public static DiGi.Core.IO.Table.Classes.Table? ToDiGi_Table(this DiGi.Translate.Classes.TranslationModel? translationModel);
```
#### Parameters

<a name='DiGi.Translate.Convert.ToDiGi_Table(thisDiGi.Translate.Classes.TranslationModel).translationModel'></a>

`translationModel` [TranslationModel](DiGi.Translate.Classes.md#DiGi.Translate.Classes.TranslationModel 'DiGi\.Translate\.Classes\.TranslationModel')

The translation model to convert\.

#### Returns
[DiGi\.Core\.IO\.Table\.Classes\.Table](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.classes.table 'DiGi\.Core\.IO\.Table\.Classes\.Table')  
A [DiGi\.Core\.IO\.Table\.Classes\.Table](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.classes.table 'DiGi\.Core\.IO\.Table\.Classes\.Table') object containing the translated data, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the [translationModel](DiGi.Translate.md#DiGi.Translate.Convert.ToDiGi_Table(thisDiGi.Translate.Classes.TranslationModel).translationModel 'DiGi\.Translate\.Convert\.ToDiGi\_Table\(this DiGi\.Translate\.Classes\.TranslationModel\)\.translationModel') is null\.

<a name='DiGi.Translate.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.Translate.Modify.AddEnum_T_(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Func_T,string_)'></a>

## Modify\.AddEnum\<T\>\(this TranslationModel, Language, Func\<T,string\>\) Method

Adds all members of the specified enumeration to the translation model for the given language\.

```csharp
public static bool AddEnum<T>(this DiGi.Translate.Classes.TranslationModel? translationModel, DiGi.Translate.Classes.Language? language, System.Func<T?,string?>? func=null)
    where T : System.Enum;
```
#### Type parameters

<a name='DiGi.Translate.Modify.AddEnum_T_(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Func_T,string_).T'></a>

`T`

The type of the enumeration\.
#### Parameters

<a name='DiGi.Translate.Modify.AddEnum_T_(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Func_T,string_).translationModel'></a>

`translationModel` [TranslationModel](DiGi.Translate.Classes.md#DiGi.Translate.Classes.TranslationModel 'DiGi\.Translate\.Classes\.TranslationModel')

The translation model to which the enum values will be added\.

<a name='DiGi.Translate.Modify.AddEnum_T_(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Func_T,string_).language'></a>

`language` [Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language')

The target language for the translations\.

<a name='DiGi.Translate.Modify.AddEnum_T_(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Func_T,string_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[T](DiGi.Translate.md#DiGi.Translate.Modify.AddEnum_T_(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,System.Func_T,string_).T 'DiGi\.Translate\.Modify\.AddEnum\<T\>\(this DiGi\.Translate\.Classes\.TranslationModel, DiGi\.Translate\.Classes\.Language, System\.Func\<T,string\>\)\.T')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional function used to determine the text value for each enumeration member; defaults to retrieving the description if not provided\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the operation was successful; otherwise, false\.

<a name='DiGi.Translate.Modify.AddText(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,string,System.Func_string,string_)'></a>

## Modify\.AddText\(this TranslationModel, Language, string, Func\<string,string\>\) Method

Adds a text entry to the specified translation model for the given language\.

```csharp
public static bool AddText(this DiGi.Translate.Classes.TranslationModel? translationModel, DiGi.Translate.Classes.Language? language, string? text, System.Func<string?,string?>? func=null);
```
#### Parameters

<a name='DiGi.Translate.Modify.AddText(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,string,System.Func_string,string_).translationModel'></a>

`translationModel` [TranslationModel](DiGi.Translate.Classes.md#DiGi.Translate.Classes.TranslationModel 'DiGi\.Translate\.Classes\.TranslationModel')

The translation model instance to which the text will be added\.

<a name='DiGi.Translate.Modify.AddText(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,string,System.Func_string,string_).language'></a>

`language` [Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language')

The target language for the translation entry\.

<a name='DiGi.Translate.Modify.AddText(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,string,System.Func_string,string_).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The text content to be added\.

<a name='DiGi.Translate.Modify.AddText(thisDiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language,string,System.Func_string,string_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional transformation function to apply to the text before adding it\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the text was successfully added; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Translate.Modify.Read(thisDiGi.Translate.Classes.TranslationModel,string)'></a>

## Modify\.Read\(this TranslationModel, string\) Method

Reads translation data from a specified tab\-delimited file and populates the provided translation model\.

```csharp
public static bool Read(this DiGi.Translate.Classes.TranslationModel? translationModel, string? path);
```
#### Parameters

<a name='DiGi.Translate.Modify.Read(thisDiGi.Translate.Classes.TranslationModel,string).translationModel'></a>

`translationModel` [TranslationModel](DiGi.Translate.Classes.md#DiGi.Translate.Classes.TranslationModel 'DiGi\.Translate\.Classes\.TranslationModel')

The translation model to be populated with the read data\.

<a name='DiGi.Translate.Modify.Read(thisDiGi.Translate.Classes.TranslationModel,string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the source file containing the translation data\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the data was successfully read and loaded into the model; otherwise, `false`\.

<a name='DiGi.Translate.Modify.Write(thisDiGi.Translate.Classes.TranslationModel,string)'></a>

## Modify\.Write\(this TranslationModel, string\) Method

Writes the translation model to a tab\-delimited file at the specified path\.

```csharp
public static bool Write(this DiGi.Translate.Classes.TranslationModel translationModel, string path);
```
#### Parameters

<a name='DiGi.Translate.Modify.Write(thisDiGi.Translate.Classes.TranslationModel,string).translationModel'></a>

`translationModel` [TranslationModel](DiGi.Translate.Classes.md#DiGi.Translate.Classes.TranslationModel 'DiGi\.Translate\.Classes\.TranslationModel')

The translation model to be written\.

<a name='DiGi.Translate.Modify.Write(thisDiGi.Translate.Classes.TranslationModel,string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The destination file path\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the write operation was successful; otherwise, false\.
#### [DiGi\.Translate](index.md 'index')

## DiGi\.Translate\.Classes Namespace
### Classes

<a name='DiGi.Translate.Classes.Category'></a>

## Category Class

Represents a category used for classification\.

```csharp
public class Category
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Category
### Constructors

<a name='DiGi.Translate.Classes.Category.Category(DiGi.Translate.Classes.Category)'></a>

## Category\(Category\) Constructor

Initializes a new instance of the [Category](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Category 'DiGi\.Translate\.Classes\.Category') class using another [Category](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Category 'DiGi\.Translate\.Classes\.Category') object\.

```csharp
public Category(DiGi.Translate.Classes.Category category);
```
#### Parameters

<a name='DiGi.Translate.Classes.Category.Category(DiGi.Translate.Classes.Category).category'></a>

`category` [Category](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Category 'DiGi\.Translate\.Classes\.Category')

The source category to copy from\.

<a name='DiGi.Translate.Classes.Category.Category(DiGi.Translate.Enums.Category)'></a>

## Category\(Category\) Constructor

Initializes a new instance of the [Category](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Category 'DiGi\.Translate\.Classes\.Category') class using a specified category enumeration value\.

```csharp
public Category(DiGi.Translate.Enums.Category category);
```
#### Parameters

<a name='DiGi.Translate.Classes.Category.Category(DiGi.Translate.Enums.Category).category'></a>

`category` [Category](DiGi.Translate.Enums.md#DiGi.Translate.Enums.Category 'DiGi\.Translate\.Enums\.Category')

The category enumeration value used to initialize the category name\.

<a name='DiGi.Translate.Classes.Category.Category(string)'></a>

## Category\(string\) Constructor

Initializes a new instance of the [Category](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Category 'DiGi\.Translate\.Classes\.Category') class with a specified name\.

```csharp
public Category(string name);
```
#### Parameters

<a name='DiGi.Translate.Classes.Category.Category(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the category\.
### Properties

<a name='DiGi.Translate.Classes.Category.Name'></a>

## Category\.Name Property

Gets the name of the category\.

```csharp
public string Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.Translate.Classes.Category.Equals(object)'></a>

## Category\.Equals\(object\) Method

Determines whether the specified object is equal to the current category based on their string representations\.

```csharp
public override bool Equals(object obj);
```
#### Parameters

<a name='DiGi.Translate.Classes.Category.Equals(object).obj'></a>

`obj` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with the current category\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the objects are considered equal; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Translate.Classes.Category.GetHashCode()'></a>

## Category\.GetHashCode\(\) Method

Returns a hash code for the current category based on its name\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
A numeric hash code\.

<a name='DiGi.Translate.Classes.Category.ToString()'></a>

## Category\.ToString\(\) Method

Returns a string representation of the category\.

```csharp
public override string ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The name of the category\.
### Operators

<a name='DiGi.Translate.Classes.Category.op_Equality(DiGi.Translate.Classes.Category,DiGi.Translate.Classes.Category)'></a>

## Category\.operator ==\(Category, Category\) Operator

Indicates whether the two specified [Category](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Category 'DiGi\.Translate\.Classes\.Category') objects are equal\.

```csharp
public static bool operator ==(DiGi.Translate.Classes.Category category_1, DiGi.Translate.Classes.Category category_2);
```
#### Parameters

<a name='DiGi.Translate.Classes.Category.op_Equality(DiGi.Translate.Classes.Category,DiGi.Translate.Classes.Category).category_1'></a>

`category_1` [Category](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Category 'DiGi\.Translate\.Classes\.Category')

The first category to compare\.

<a name='DiGi.Translate.Classes.Category.op_Equality(DiGi.Translate.Classes.Category,DiGi.Translate.Classes.Category).category_2'></a>

`category_2` [Category](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Category 'DiGi\.Translate\.Classes\.Category')

The second category to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the categories are equal; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Translate.Classes.Category.op_ImplicitDiGi.Translate.Classes.Category(DiGi.Translate.Enums.Category)'></a>

## Category\.implicit operator Category\(Category\) Operator

Implicitly converts a [Category](DiGi.Translate.Enums.md#DiGi.Translate.Enums.Category 'DiGi\.Translate\.Enums\.Category') enumeration value to a [Category](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Category 'DiGi\.Translate\.Classes\.Category') instance\.

```csharp
public static DiGi.Translate.Classes.Category implicit operator DiGi.Translate.Classes.Category(DiGi.Translate.Enums.Category category);
```
#### Parameters

<a name='DiGi.Translate.Classes.Category.op_ImplicitDiGi.Translate.Classes.Category(DiGi.Translate.Enums.Category).category'></a>

`category` [Category](DiGi.Translate.Enums.md#DiGi.Translate.Enums.Category 'DiGi\.Translate\.Enums\.Category')

The category enumeration value to convert\.

#### Returns
[Category](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Category 'DiGi\.Translate\.Classes\.Category')  
A new [Category](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Category 'DiGi\.Translate\.Classes\.Category') instance created from the specified enumeration value\.

<a name='DiGi.Translate.Classes.Category.op_ImplicitDiGi.Translate.Classes.Category(string)'></a>

## Category\.implicit operator Category\(string\) Operator

Implicitly converts a string to a [Category](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Category 'DiGi\.Translate\.Classes\.Category') instance\.

```csharp
public static DiGi.Translate.Classes.Category implicit operator DiGi.Translate.Classes.Category(string name);
```
#### Parameters

<a name='DiGi.Translate.Classes.Category.op_ImplicitDiGi.Translate.Classes.Category(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the category to convert\.

#### Returns
[Category](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Category 'DiGi\.Translate\.Classes\.Category')  
A new [Category](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Category 'DiGi\.Translate\.Classes\.Category') instance created from the specified name\.

<a name='DiGi.Translate.Classes.Category.op_Inequality(DiGi.Translate.Classes.Category,DiGi.Translate.Classes.Category)'></a>

## Category\.operator \!=\(Category, Category\) Operator

Indicates whether two [Category](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Category 'DiGi\.Translate\.Classes\.Category') instances are not equal based on their names\.

```csharp
public static bool operator !=(DiGi.Translate.Classes.Category category_1, DiGi.Translate.Classes.Category category_2);
```
#### Parameters

<a name='DiGi.Translate.Classes.Category.op_Inequality(DiGi.Translate.Classes.Category,DiGi.Translate.Classes.Category).category_1'></a>

`category_1` [Category](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Category 'DiGi\.Translate\.Classes\.Category')

The first [Category](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Category 'DiGi\.Translate\.Classes\.Category') to compare\.

<a name='DiGi.Translate.Classes.Category.op_Inequality(DiGi.Translate.Classes.Category,DiGi.Translate.Classes.Category).category_2'></a>

`category_2` [Category](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Category 'DiGi\.Translate\.Classes\.Category')

The second [Category](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Category 'DiGi\.Translate\.Classes\.Category') to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the categories are not equal; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Translate.Classes.Language'></a>

## Language Class

Represents a language used for translation purposes\.

```csharp
public class Language
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Language
### Constructors

<a name='DiGi.Translate.Classes.Language.Language(DiGi.Translate.Classes.Language)'></a>

## Language\(Language\) Constructor

Initializes a new instance of the [Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language') class using another [Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language') object\.

```csharp
public Language(DiGi.Translate.Classes.Language language);
```
#### Parameters

<a name='DiGi.Translate.Classes.Language.Language(DiGi.Translate.Classes.Language).language'></a>

`language` [Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language')

The source language object to copy from\.

<a name='DiGi.Translate.Classes.Language.Language(DiGi.Translate.Enums.Language)'></a>

## Language\(Language\) Constructor

Initializes a new instance of the [Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language') class using the specified language enumeration value\.

```csharp
public Language(DiGi.Translate.Enums.Language language);
```
#### Parameters

<a name='DiGi.Translate.Classes.Language.Language(DiGi.Translate.Enums.Language).language'></a>

`language` [Language](DiGi.Translate.Enums.md#DiGi.Translate.Enums.Language 'DiGi\.Translate\.Enums\.Language')

The language enumeration value used to initialize the current instance\.

<a name='DiGi.Translate.Classes.Language.Language(string)'></a>

## Language\(string\) Constructor

Initializes a new instance of the [Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language') class using the specified name\.

```csharp
public Language(string name);
```
#### Parameters

<a name='DiGi.Translate.Classes.Language.Language(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the language\.
### Properties

<a name='DiGi.Translate.Classes.Language.Name'></a>

## Language\.Name Property

Gets the name of the language\.

```csharp
public string Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.Translate.Classes.Language.Equals(object)'></a>

## Language\.Equals\(object\) Method

Determines whether the specified object is equal to the current [Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language') instance\.

```csharp
public override bool Equals(object obj);
```
#### Parameters

<a name='DiGi.Translate.Classes.Language.Equals(object).obj'></a>

`obj` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with the current instance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the objects are considered equal; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Translate.Classes.Language.GetHashCode()'></a>

## Language\.GetHashCode\(\) Method

Returns a hash code for the current [Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language') instance\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The hash code of the language\.

<a name='DiGi.Translate.Classes.Language.ToString()'></a>

## Language\.ToString\(\) Method

Returns a string that represents the current language's name\.

```csharp
public override string ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The language name\.
### Operators

<a name='DiGi.Translate.Classes.Language.op_Equality(DiGi.Translate.Classes.Language,DiGi.Translate.Classes.Language)'></a>

## Language\.operator ==\(Language, Language\) Operator

Indicates whether the specified [Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language') objects are equal\.

```csharp
public static bool operator ==(DiGi.Translate.Classes.Language language_1, DiGi.Translate.Classes.Language language_2);
```
#### Parameters

<a name='DiGi.Translate.Classes.Language.op_Equality(DiGi.Translate.Classes.Language,DiGi.Translate.Classes.Language).language_1'></a>

`language_1` [Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language')

The first [Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language') object to compare\.

<a name='DiGi.Translate.Classes.Language.op_Equality(DiGi.Translate.Classes.Language,DiGi.Translate.Classes.Language).language_2'></a>

`language_2` [Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language')

The second [Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language') object to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the objects are equal; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Translate.Classes.Language.op_ImplicitDiGi.Translate.Classes.Language(DiGi.Translate.Enums.Language)'></a>

## Language\.implicit operator Language\(Language\) Operator

Implicitly converts a [Language](DiGi.Translate.Enums.md#DiGi.Translate.Enums.Language 'DiGi\.Translate\.Enums\.Language') enumeration value to a [Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language') object\.

```csharp
public static DiGi.Translate.Classes.Language implicit operator DiGi.Translate.Classes.Language(DiGi.Translate.Enums.Language language);
```
#### Parameters

<a name='DiGi.Translate.Classes.Language.op_ImplicitDiGi.Translate.Classes.Language(DiGi.Translate.Enums.Language).language'></a>

`language` [Language](DiGi.Translate.Enums.md#DiGi.Translate.Enums.Language 'DiGi\.Translate\.Enums\.Language')

The language enumeration value to convert\.

#### Returns
[Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language')  
A new [Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language') instance created from the specified enumeration value\.

<a name='DiGi.Translate.Classes.Language.op_ImplicitDiGi.Translate.Classes.Language(string)'></a>

## Language\.implicit operator Language\(string\) Operator

Implicitly converts a string representation of a language name to a [Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language') object\.

```csharp
public static DiGi.Translate.Classes.Language implicit operator DiGi.Translate.Classes.Language(string name);
```
#### Parameters

<a name='DiGi.Translate.Classes.Language.op_ImplicitDiGi.Translate.Classes.Language(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the language to convert\.

#### Returns
[Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language')  
A new [Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language') instance created from the specified name\.

<a name='DiGi.Translate.Classes.Language.op_Inequality(DiGi.Translate.Classes.Language,DiGi.Translate.Classes.Language)'></a>

## Language\.operator \!=\(Language, Language\) Operator

Indicates whether the specified [Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language') objects are not equal\.

```csharp
public static bool operator !=(DiGi.Translate.Classes.Language language_1, DiGi.Translate.Classes.Language language_2);
```
#### Parameters

<a name='DiGi.Translate.Classes.Language.op_Inequality(DiGi.Translate.Classes.Language,DiGi.Translate.Classes.Language).language_1'></a>

`language_1` [Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language')

The first [Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language') object to compare\.

<a name='DiGi.Translate.Classes.Language.op_Inequality(DiGi.Translate.Classes.Language,DiGi.Translate.Classes.Language).language_2'></a>

`language_2` [Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language')

The second [Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language') object to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the objects are not equal; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Translate.Classes.Translation'></a>

## Translation Class

Represents a translation entry that associates a unique identifier and category with localized strings for various languages\.

```csharp
public class Translation
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Translation
### Constructors

<a name='DiGi.Translate.Classes.Translation.Translation(DiGi.Translate.Classes.Category,string)'></a>

## Translation\(Category, string\) Constructor

Initializes a new instance of the Translation class with the specified category and identifier\.

```csharp
public Translation(DiGi.Translate.Classes.Category? category, string? id);
```
#### Parameters

<a name='DiGi.Translate.Classes.Translation.Translation(DiGi.Translate.Classes.Category,string).category'></a>

`category` [Category](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Category 'DiGi\.Translate\.Classes\.Category')

The category associated with the translation\.

<a name='DiGi.Translate.Classes.Translation.Translation(DiGi.Translate.Classes.Category,string).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the translation\.
### Properties

<a name='DiGi.Translate.Classes.Translation.Category'></a>

## Translation\.Category Property

Gets the category associated with the translation\.

```csharp
public DiGi.Translate.Classes.Category? Category { get; }
```

#### Property Value
[Category](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Category 'DiGi\.Translate\.Classes\.Category')

<a name='DiGi.Translate.Classes.Translation.Id'></a>

## Translation\.Id Property

Gets the unique identifier of the translation\.

```csharp
public string? Id { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Translate.Classes.Translation.Languages'></a>

## Translation\.Languages Property

Gets the collection of all languages currently stored\.

```csharp
public System.Collections.Generic.HashSet<DiGi.Translate.Classes.Language>? Languages { get; }
```

#### Property Value
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')

<a name='DiGi.Translate.Classes.Translation.this[DiGi.Translate.Classes.Language]'></a>

## Translation\.this\[Language\] Property

Gets the translated text for the specified language\.

```csharp
public string? this[DiGi.Translate.Classes.Language? language] { get; }
```
#### Parameters

<a name='DiGi.Translate.Classes.Translation.this[DiGi.Translate.Classes.Language].language'></a>

`language` [Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language')

The language for which to retrieve the translation\.

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.Translate.Classes.Translation.Add(DiGi.Translate.Classes.Language,string)'></a>

## Translation\.Add\(Language, string\) Method

Adds or updates a translation for the specified language\.

```csharp
public bool Add(DiGi.Translate.Classes.Language language, string text);
```
#### Parameters

<a name='DiGi.Translate.Classes.Translation.Add(DiGi.Translate.Classes.Language,string).language'></a>

`language` [Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language')

The language to associate with the translated text\.

<a name='DiGi.Translate.Classes.Translation.Add(DiGi.Translate.Classes.Language,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The translated text to be added\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the translation was successfully added; otherwise, `false`\.

<a name='DiGi.Translate.Classes.Translation.TryGetText(DiGi.Translate.Classes.Language,string)'></a>

## Translation\.TryGetText\(Language, string\) Method

Attempts to retrieve the translated text for the specified language\.

```csharp
public bool TryGetText(DiGi.Translate.Classes.Language? language, out string? text);
```
#### Parameters

<a name='DiGi.Translate.Classes.Translation.TryGetText(DiGi.Translate.Classes.Language,string).language'></a>

`language` [Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language')

The language used to look up the translation\.

<a name='DiGi.Translate.Classes.Translation.TryGetText(DiGi.Translate.Classes.Language,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

When this method returns, contains the translated text if the operation succeeded; otherwise, `null`\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the translation was successfully retrieved and is not null or empty; otherwise, `false`\.

<a name='DiGi.Translate.Classes.TranslationModel'></a>

## TranslationModel Class

Represents a model for managing and storing translation data organized by category\.

```csharp
public class TranslationModel
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → TranslationModel
### Constructors

<a name='DiGi.Translate.Classes.TranslationModel.TranslationModel()'></a>

## TranslationModel\(\) Constructor

Initializes a new instance of the [TranslationModel](DiGi.Translate.Classes.md#DiGi.Translate.Classes.TranslationModel 'DiGi\.Translate\.Classes\.TranslationModel') class\.

```csharp
public TranslationModel();
```
### Properties

<a name='DiGi.Translate.Classes.TranslationModel.Categories'></a>

## TranslationModel\.Categories Property

Gets the collection of all categories currently stored in the translation model\.

```csharp
public System.Collections.Generic.HashSet<DiGi.Translate.Classes.Category> Categories { get; }
```

#### Property Value
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[Category](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Category 'DiGi\.Translate\.Classes\.Category')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')
### Methods

<a name='DiGi.Translate.Classes.TranslationModel.Add(DiGi.Translate.Classes.Category,string,DiGi.Translate.Classes.Language,string)'></a>

## TranslationModel\.Add\(Category, string, Language, string\) Method

Adds a translation entry for a specific language to the specified category and identifier\.

```csharp
public bool Add(DiGi.Translate.Classes.Category? category, string? id, DiGi.Translate.Classes.Language? language, string? text);
```
#### Parameters

<a name='DiGi.Translate.Classes.TranslationModel.Add(DiGi.Translate.Classes.Category,string,DiGi.Translate.Classes.Language,string).category'></a>

`category` [Category](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Category 'DiGi\.Translate\.Classes\.Category')

The category to which the translation is added\.

<a name='DiGi.Translate.Classes.TranslationModel.Add(DiGi.Translate.Classes.Category,string,DiGi.Translate.Classes.Language,string).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the translation entry\.

<a name='DiGi.Translate.Classes.TranslationModel.Add(DiGi.Translate.Classes.Category,string,DiGi.Translate.Classes.Language,string).language'></a>

`language` [Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language')

The language of the translation text\.

<a name='DiGi.Translate.Classes.TranslationModel.Add(DiGi.Translate.Classes.Category,string,DiGi.Translate.Classes.Language,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The translation text to be stored\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the translation was successfully added; otherwise, `false`\.

<a name='DiGi.Translate.Classes.TranslationModel.Add(DiGi.Translate.Classes.Translation)'></a>

## TranslationModel\.Add\(Translation\) Method

Adds a translation to the translation model\.

```csharp
public System.Collections.Generic.HashSet<DiGi.Translate.Classes.Language>? Add(DiGi.Translate.Classes.Translation? translation);
```
#### Parameters

<a name='DiGi.Translate.Classes.TranslationModel.Add(DiGi.Translate.Classes.Translation).translation'></a>

`translation` [Translation](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Translation 'DiGi\.Translate\.Classes\.Translation')

The translation object to be added\.

#### Returns
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')  
A [System\.Collections\.Generic\.HashSet&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1') containing the languages associated with the translation if successfully added; otherwise, `null`\.

<a name='DiGi.Translate.Classes.TranslationModel.Add(System.Enum,DiGi.Translate.Classes.Language,string)'></a>

## TranslationModel\.Add\(Enum, Language, string\) Method

Adds a translation for the specified enumeration member in the given language\.

```csharp
public bool Add(System.Enum? @enum, DiGi.Translate.Classes.Language? language, string? text);
```
#### Parameters

<a name='DiGi.Translate.Classes.TranslationModel.Add(System.Enum,DiGi.Translate.Classes.Language,string).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration member to translate\.

<a name='DiGi.Translate.Classes.TranslationModel.Add(System.Enum,DiGi.Translate.Classes.Language,string).language'></a>

`language` [Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language')

The target language for the translation\.

<a name='DiGi.Translate.Classes.TranslationModel.Add(System.Enum,DiGi.Translate.Classes.Language,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The translated text content\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the translation was successfully added; otherwise, false\.

<a name='DiGi.Translate.Classes.TranslationModel.GetIds(DiGi.Translate.Classes.Category)'></a>

## TranslationModel\.GetIds\(Category\) Method

Retrieves the set of identifiers associated with the specified category\.

```csharp
public System.Collections.Generic.HashSet<string>? GetIds(DiGi.Translate.Classes.Category? category);
```
#### Parameters

<a name='DiGi.Translate.Classes.TranslationModel.GetIds(DiGi.Translate.Classes.Category).category'></a>

`category` [Category](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Category 'DiGi\.Translate\.Classes\.Category')

The category for which to retrieve identifiers\.

#### Returns
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')  
A [System\.Collections\.Generic\.HashSet&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1') containing the identifiers if the category exists; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Translate.Classes.TranslationModel.GetLanguages()'></a>

## TranslationModel\.GetLanguages\(\) Method

Retrieves all unique languages associated with the translations stored in the model\.

```csharp
public System.Collections.Generic.HashSet<DiGi.Translate.Classes.Language> GetLanguages();
```

#### Returns
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')  
A [System\.Collections\.Generic\.HashSet&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1') containing all identified languages\.

<a name='DiGi.Translate.Classes.TranslationModel.GetLanguages(DiGi.Translate.Classes.Category)'></a>

## TranslationModel\.GetLanguages\(Category\) Method

Retrieves the set of languages associated with a specified translation category\.

```csharp
public System.Collections.Generic.HashSet<DiGi.Translate.Classes.Language>? GetLanguages(DiGi.Translate.Classes.Category? category);
```
#### Parameters

<a name='DiGi.Translate.Classes.TranslationModel.GetLanguages(DiGi.Translate.Classes.Category).category'></a>

`category` [Category](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Category 'DiGi\.Translate\.Classes\.Category')

The translation category to retrieve languages for\.

#### Returns
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')  
A [System\.Collections\.Generic\.HashSet&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1') containing the available languages for the specified category, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the provided category is null\.

<a name='DiGi.Translate.Classes.TranslationModel.TryGetEnum_T_(string,string,T,DiGi.Core.Enums.TextComparisonType,bool)'></a>

## TranslationModel\.TryGetEnum\<T\>\(string, string, T, TextComparisonType, bool\) Method

Attempts to retrieve an enum value of type [T](DiGi.Translate.Classes.md#DiGi.Translate.Classes.TranslationModel.TryGetEnum_T_(string,string,T,DiGi.Core.Enums.TextComparisonType,bool).T 'DiGi\.Translate\.Classes\.TranslationModel\.TryGetEnum\<T\>\(string, string, T, DiGi\.Core\.Enums\.TextComparisonType, bool\)\.T') that matches the specified translated text for a given language\.

```csharp
public bool TryGetEnum<T>(string? text, string? language, out T? @enum, DiGi.Core.Enums.TextComparisonType textComparisonType=DiGi.Core.Enums.TextComparisonType.Equals, bool caseSensitive=true)
    where T : System.Enum;
```
#### Type parameters

<a name='DiGi.Translate.Classes.TranslationModel.TryGetEnum_T_(string,string,T,DiGi.Core.Enums.TextComparisonType,bool).T'></a>

`T`

The enum type to be retrieved\.
#### Parameters

<a name='DiGi.Translate.Classes.TranslationModel.TryGetEnum_T_(string,string,T,DiGi.Core.Enums.TextComparisonType,bool).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The translated text to match against\.

<a name='DiGi.Translate.Classes.TranslationModel.TryGetEnum_T_(string,string,T,DiGi.Core.Enums.TextComparisonType,bool).language'></a>

`language` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The language identifier used for the translation lookup\.

<a name='DiGi.Translate.Classes.TranslationModel.TryGetEnum_T_(string,string,T,DiGi.Core.Enums.TextComparisonType,bool).enum'></a>

`enum` [T](DiGi.Translate.Classes.md#DiGi.Translate.Classes.TranslationModel.TryGetEnum_T_(string,string,T,DiGi.Core.Enums.TextComparisonType,bool).T 'DiGi\.Translate\.Classes\.TranslationModel\.TryGetEnum\<T\>\(string, string, T, DiGi\.Core\.Enums\.TextComparisonType, bool\)\.T')

When this method returns, contains the matched enum value if successful; otherwise, the default value of type [T](DiGi.Translate.Classes.md#DiGi.Translate.Classes.TranslationModel.TryGetEnum_T_(string,string,T,DiGi.Core.Enums.TextComparisonType,bool).T 'DiGi\.Translate\.Classes\.TranslationModel\.TryGetEnum\<T\>\(string, string, T, DiGi\.Core\.Enums\.TextComparisonType, bool\)\.T')\.

<a name='DiGi.Translate.Classes.TranslationModel.TryGetEnum_T_(string,string,T,DiGi.Core.Enums.TextComparisonType,bool).textComparisonType'></a>

`textComparisonType` [DiGi\.Core\.Enums\.TextComparisonType](https://learn.microsoft.com/en-us/dotnet/api/digi.core.enums.textcomparisontype 'DiGi\.Core\.Enums\.TextComparisonType')

The comparison strategy to use when matching the text\.

<a name='DiGi.Translate.Classes.TranslationModel.TryGetEnum_T_(string,string,T,DiGi.Core.Enums.TextComparisonType,bool).caseSensitive'></a>

`caseSensitive` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Indicates whether the text comparison should be case\-sensitive\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if a matching enum value was found; otherwise, false\.

<a name='DiGi.Translate.Classes.TranslationModel.TryGetId(DiGi.Translate.Classes.Category,string,DiGi.Translate.Classes.Language,string,DiGi.Core.Enums.TextComparisonType,bool)'></a>

## TranslationModel\.TryGetId\(Category, string, Language, string, TextComparisonType, bool\) Method

Attempts to retrieve the identifier for a translation based on the specified category, text, and language\.

```csharp
public bool TryGetId(DiGi.Translate.Classes.Category? category, string? text, DiGi.Translate.Classes.Language? language, out string? id, DiGi.Core.Enums.TextComparisonType textComparisonType=DiGi.Core.Enums.TextComparisonType.Equals, bool caseSensitive=true);
```
#### Parameters

<a name='DiGi.Translate.Classes.TranslationModel.TryGetId(DiGi.Translate.Classes.Category,string,DiGi.Translate.Classes.Language,string,DiGi.Core.Enums.TextComparisonType,bool).category'></a>

`category` [Category](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Category 'DiGi\.Translate\.Classes\.Category')

The category associated with the translation\.

<a name='DiGi.Translate.Classes.TranslationModel.TryGetId(DiGi.Translate.Classes.Category,string,DiGi.Translate.Classes.Language,string,DiGi.Core.Enums.TextComparisonType,bool).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The translation text to search for\.

<a name='DiGi.Translate.Classes.TranslationModel.TryGetId(DiGi.Translate.Classes.Category,string,DiGi.Translate.Classes.Language,string,DiGi.Core.Enums.TextComparisonType,bool).language'></a>

`language` [Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language')

The language of the translation\.

<a name='DiGi.Translate.Classes.TranslationModel.TryGetId(DiGi.Translate.Classes.Category,string,DiGi.Translate.Classes.Language,string,DiGi.Core.Enums.TextComparisonType,bool).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

When this method returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), contains the identifier of the translation; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Translate.Classes.TranslationModel.TryGetId(DiGi.Translate.Classes.Category,string,DiGi.Translate.Classes.Language,string,DiGi.Core.Enums.TextComparisonType,bool).textComparisonType'></a>

`textComparisonType` [DiGi\.Core\.Enums\.TextComparisonType](https://learn.microsoft.com/en-us/dotnet/api/digi.core.enums.textcomparisontype 'DiGi\.Core\.Enums\.TextComparisonType')

The type of text comparison to use\.

<a name='DiGi.Translate.Classes.TranslationModel.TryGetId(DiGi.Translate.Classes.Category,string,DiGi.Translate.Classes.Language,string,DiGi.Core.Enums.TextComparisonType,bool).caseSensitive'></a>

`caseSensitive` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the comparison should be case\-sensitive\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the identifier was successfully retrieved; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Translate.Classes.TranslationModel.TryGetId(string,string,string,string,DiGi.Core.Enums.TextComparisonType,bool)'></a>

## TranslationModel\.TryGetId\(string, string, string, string, TextComparisonType, bool\) Method

Attempts to retrieve the identifier for a specific translation text within a given category and language\.

```csharp
public bool TryGetId(string? category, string? text, string? language, out string? id, DiGi.Core.Enums.TextComparisonType textComparisonType=DiGi.Core.Enums.TextComparisonType.Equals, bool caseSensitive=true);
```
#### Parameters

<a name='DiGi.Translate.Classes.TranslationModel.TryGetId(string,string,string,string,DiGi.Core.Enums.TextComparisonType,bool).category'></a>

`category` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The category of the translation\.

<a name='DiGi.Translate.Classes.TranslationModel.TryGetId(string,string,string,string,DiGi.Core.Enums.TextComparisonType,bool).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The translated text to search for\.

<a name='DiGi.Translate.Classes.TranslationModel.TryGetId(string,string,string,string,DiGi.Core.Enums.TextComparisonType,bool).language'></a>

`language` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The language associated with the translation\.

<a name='DiGi.Translate.Classes.TranslationModel.TryGetId(string,string,string,string,DiGi.Core.Enums.TextComparisonType,bool).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

When this method returns, contains the identifier of the translation if found; otherwise, null\.

<a name='DiGi.Translate.Classes.TranslationModel.TryGetId(string,string,string,string,DiGi.Core.Enums.TextComparisonType,bool).textComparisonType'></a>

`textComparisonType` [DiGi\.Core\.Enums\.TextComparisonType](https://learn.microsoft.com/en-us/dotnet/api/digi.core.enums.textcomparisontype 'DiGi\.Core\.Enums\.TextComparisonType')

The type of text comparison to perform\.

<a name='DiGi.Translate.Classes.TranslationModel.TryGetId(string,string,string,string,DiGi.Core.Enums.TextComparisonType,bool).caseSensitive'></a>

`caseSensitive` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the search is case\-sensitive\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the identifier was successfully retrieved; otherwise, false\.

<a name='DiGi.Translate.Classes.TranslationModel.TryGetText(DiGi.Translate.Classes.Category,string,DiGi.Translate.Classes.Language,string)'></a>

## TranslationModel\.TryGetText\(Category, string, Language, string\) Method

Attempts to retrieve the translated text for a specified category, identifier, and language\.

```csharp
public bool TryGetText(DiGi.Translate.Classes.Category? category, string? id, DiGi.Translate.Classes.Language? language, out string? text);
```
#### Parameters

<a name='DiGi.Translate.Classes.TranslationModel.TryGetText(DiGi.Translate.Classes.Category,string,DiGi.Translate.Classes.Language,string).category'></a>

`category` [Category](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Category 'DiGi\.Translate\.Classes\.Category')

The category of the translation\.

<a name='DiGi.Translate.Classes.TranslationModel.TryGetText(DiGi.Translate.Classes.Category,string,DiGi.Translate.Classes.Language,string).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the translation entry\.

<a name='DiGi.Translate.Classes.TranslationModel.TryGetText(DiGi.Translate.Classes.Category,string,DiGi.Translate.Classes.Language,string).language'></a>

`language` [Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language')

The target language for the translation\.

<a name='DiGi.Translate.Classes.TranslationModel.TryGetText(DiGi.Translate.Classes.Category,string,DiGi.Translate.Classes.Language,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

When this method returns, contains the translated text if found; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the translated text was successfully retrieved; otherwise, false\.

<a name='DiGi.Translate.Classes.TranslationModel.TryGetText(string,string,string,string)'></a>

## TranslationModel\.TryGetText\(string, string, string, string\) Method

Attempts to retrieve the translation text for a specified category, identifier, and language\.

```csharp
public bool TryGetText(string? category, string? id, string? language, out string? text);
```
#### Parameters

<a name='DiGi.Translate.Classes.TranslationModel.TryGetText(string,string,string,string).category'></a>

`category` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The category of the translation\.

<a name='DiGi.Translate.Classes.TranslationModel.TryGetText(string,string,string,string).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier of the translation entry\.

<a name='DiGi.Translate.Classes.TranslationModel.TryGetText(string,string,string,string).language'></a>

`language` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The language code for the requested translation\.

<a name='DiGi.Translate.Classes.TranslationModel.TryGetText(string,string,string,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

When this method returns, contains the retrieved translation text if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the translation text was successfully retrieved; otherwise, false\.

<a name='DiGi.Translate.Classes.TranslationModel.TryGetText(System.Enum,string,string)'></a>

## TranslationModel\.TryGetText\(Enum, string, string\) Method

Attempts to retrieve the translated text for a specified enumeration value in the given language\.

```csharp
public bool TryGetText(System.Enum? @enum, string? language, out string? text);
```
#### Parameters

<a name='DiGi.Translate.Classes.TranslationModel.TryGetText(System.Enum,string,string).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration value to translate\.

<a name='DiGi.Translate.Classes.TranslationModel.TryGetText(System.Enum,string,string).language'></a>

`language` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The identifier of the target language\.

<a name='DiGi.Translate.Classes.TranslationModel.TryGetText(System.Enum,string,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

When this method returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), contains the translated text; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the translation was successfully retrieved; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Translate.Classes.Translator'></a>

## Translator Class

Represents a translator that handles the localization of strings using a specified translation model and language\.

```csharp
public class Translator
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Translator
### Constructors

<a name='DiGi.Translate.Classes.Translator.Translator(DiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language)'></a>

## Translator\(TranslationModel, Language\) Constructor

Initializes a new instance of the [Translator](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Translator 'DiGi\.Translate\.Classes\.Translator') class\.

```csharp
public Translator(DiGi.Translate.Classes.TranslationModel? translationModel, DiGi.Translate.Classes.Language? language);
```
#### Parameters

<a name='DiGi.Translate.Classes.Translator.Translator(DiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language).translationModel'></a>

`translationModel` [TranslationModel](DiGi.Translate.Classes.md#DiGi.Translate.Classes.TranslationModel 'DiGi\.Translate\.Classes\.TranslationModel')

The translation model containing the localized strings\.

<a name='DiGi.Translate.Classes.Translator.Translator(DiGi.Translate.Classes.TranslationModel,DiGi.Translate.Classes.Language).language'></a>

`language` [Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language')

The initial language to be used for translations\.
### Properties

<a name='DiGi.Translate.Classes.Translator.Language'></a>

## Translator\.Language Property

Gets or sets the current language used by the translator\.

```csharp
public DiGi.Translate.Classes.Language? Language { get; set; }
```

#### Property Value
[Language](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Language 'DiGi\.Translate\.Classes\.Language')
### Methods

<a name='DiGi.Translate.Classes.Translator.TryGetText(DiGi.Translate.Classes.Category,string,string)'></a>

## Translator\.TryGetText\(Category, string, string\) Method

Attempts to retrieve the translated text for the specified category and identifier based on the current language\.

```csharp
public bool TryGetText(DiGi.Translate.Classes.Category? category, string? id, out string? text);
```
#### Parameters

<a name='DiGi.Translate.Classes.Translator.TryGetText(DiGi.Translate.Classes.Category,string,string).category'></a>

`category` [Category](DiGi.Translate.Classes.md#DiGi.Translate.Classes.Category 'DiGi\.Translate\.Classes\.Category')

The translation category\.

<a name='DiGi.Translate.Classes.Translator.TryGetText(DiGi.Translate.Classes.Category,string,string).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier of the text to retrieve\.

<a name='DiGi.Translate.Classes.Translator.TryGetText(DiGi.Translate.Classes.Category,string,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

When this method returns, contains the translated text if found; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the translation was successfully retrieved; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.Translate.Classes.Translator.TryGetText(string,string,string)'></a>

## Translator\.TryGetText\(string, string, string\) Method

Attempts to retrieve the translated text associated with the specified category name and identifier\.

```csharp
public bool TryGetText(string? category, string? id, out string? text);
```
#### Parameters

<a name='DiGi.Translate.Classes.Translator.TryGetText(string,string,string).category'></a>

`category` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the translation category\.

<a name='DiGi.Translate.Classes.Translator.TryGetText(string,string,string).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the text entry\.

<a name='DiGi.Translate.Classes.Translator.TryGetText(string,string,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

When this method returns, contains the translated text if found; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the translation was successfully retrieved; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.
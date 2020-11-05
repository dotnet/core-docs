### TextFormatFlags.ModifyString is obsolete

The <xref:System.Windows.Forms.TextFormatFlags.ModifyString?displayProperty=nameWithType> field is obsolete, as warning, and may be removed in a future .NET version.

#### Change description

In previous .NET versions, the <xref:System.Windows.Forms.TextFormatFlags.ModifyString?displayProperty=nameWithType> enumeration field is not marked obsolete. In .NET 5.0 and later versions, it is marked obsolete as a warning. This field may be removed in a future .NET version.

#### Reason for change

Passing a string to <xref:System.Windows.Forms.TextRenderer.MeasureText%2A?displayProperty=nameWithType> with <xref:System.Windows.Forms.TextFormatFlags.ModifyString?displayProperty=nameWithType> alters the string in some situations. This behavior breaks the string immutability promise and may lead to a fatal .NET runtime state corruption.

#### Version introduced

.NET 5.0 RC1

#### Recommended action

Update any code that relies on <xref:System.Windows.Forms.TextFormatFlags.ModifyString?displayProperty=nameWithType>.

#### Category

Windows Forms

#### Affected APIs

- <xref:System.Windows.Forms.TextFormatFlags.ModifyString?displayProperty=fullName>

<!--

#### Affected APIs

- `F:System.Windows.Forms.TextFormatFlags.ModifyString`

-->

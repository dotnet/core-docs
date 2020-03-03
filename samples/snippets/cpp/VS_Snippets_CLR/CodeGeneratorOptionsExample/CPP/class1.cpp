#using <System.dll>

using namespace System;
using namespace System::CodeDom;
using namespace System::CodeDom::Compiler;

[STAThread]
int main()
{
   //<Snippet1>
   // Creates a new CodeGeneratorOptions.
   CodeGeneratorOptions^ genOptions = gcnew CodeGeneratorOptions;
   
   // Sets a value indicating that the code generator should insert blank lines between type members.
   genOptions->BlankLinesBetweenMembers = true;
   
   // Sets the style of bracing format to use: either S"Block" to start a
   // bracing block on the same line as the declaration of its container, or
   // S"C" to start the bracing for the block on the following line.
   genOptions->BracingStyle = "C";
   
   // Sets a value indicating that the code generator should not append an else,
   // catch or finally block, including brackets, at the closing line of a preceeding if or try block.
   genOptions->ElseOnClosing = false;
   
   // Sets the String* to indent each line with.
   genOptions->IndentString = "    ";
   
   // Uses the CodeGeneratorOptions indexer property to set an
   // example Object* to the type's String*-keyed ListDictionary.
   // Custom ICodeGenerator* implementations can use objects
   // in this dictionary to customize process behavior.
   genOptions[ "CustomGeneratorOptionStringExampleID" ] = "BuildFlags: /A /B /C /D /E";
   //</Snippet1>

   Console::WriteLine( genOptions );
}

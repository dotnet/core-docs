

// <Snippet1>
#using <system.dll>

using namespace System;
using namespace System::Reflection;
using namespace System::ComponentModel::Design;

int main()
{
   try
   {
      // Get the type handle of a specified class.
      Type^ myType = ViewTechnology::typeid;

      // Get the fields of the specified class.
      array<FieldInfo^>^myField = myType->GetFields();
      Console::WriteLine( "\nDisplaying fields that have SpecialName attributes:\n" );
      for ( int i = 0; i < myField->Length; i++ )
      {
         // Determine whether or not each field is a special name.
         if ( myField[ i ]->IsSpecialName )
         {
            Console::WriteLine( "The field {0} has a SpecialName attribute.", myField[ i ]->Name );
         }
      }
   }
   catch ( Exception^ e ) 
   {
      Console::WriteLine( "Exception : {0} ", e->Message );
   }
}
// </Snippet1>

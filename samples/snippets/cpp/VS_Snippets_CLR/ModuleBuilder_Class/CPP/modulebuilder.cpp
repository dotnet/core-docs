
// System.Reflection.Emit.ModuleBuilder
/*
The following example demonstrates the 'ModuleBuilder' class. 
A dynamic assembly with a module in it is created in 'CodeGenerator' class. 
A run time class having a method and a field is created using the 'ModuleBuilder'
class and created class is called from the 'TestClass'.
*/
// <Snippet1>
using namespace System;
using namespace System::Reflection;
using namespace System::Reflection::Emit;
public ref class CodeGenerator
{
private:
   AssemblyBuilder^ myAssemblyBuilder;

public:
   CodeGenerator()
   {
      // Get the current application domain for the current thread.
      AppDomain^ myCurrentDomain = AppDomain::CurrentDomain;
      AssemblyName^ myAssemblyName = gcnew AssemblyName;
      myAssemblyName->Name = "TempAssembly";

      // Define a dynamic assembly in the current application domain.
      myAssemblyBuilder = myCurrentDomain->DefineDynamicAssembly( myAssemblyName, AssemblyBuilderAccess::Run );

      // Define a dynamic module in this assembly.
      ModuleBuilder^ myModuleBuilder = myAssemblyBuilder->DefineDynamicModule( "TempModule" );

      // Define a runtime class with specified name and attributes.
      TypeBuilder^ myTypeBuilder = myModuleBuilder->DefineType( "TempClass", TypeAttributes::Public );

      // Add 'Greeting' field to the class, with the specified attribute and type.
      FieldBuilder^ greetingField = myTypeBuilder->DefineField( "Greeting", String::typeid, FieldAttributes::Public );
      array<Type^>^myMethodArgs = {String::typeid};

      // Add 'MyMethod' method to the class, with the specified attribute and signature.
      MethodBuilder^ myMethod = myTypeBuilder->DefineMethod( "MyMethod", MethodAttributes::Public, CallingConventions::Standard, nullptr, myMethodArgs );
      ILGenerator^ methodIL = myMethod->GetILGenerator();
      methodIL->EmitWriteLine( "In the method..." );
      methodIL->Emit( OpCodes::Ldarg_0 );
      methodIL->Emit( OpCodes::Ldarg_1 );
      methodIL->Emit( OpCodes::Stfld, greetingField );
      methodIL->Emit( OpCodes::Ret );
      myTypeBuilder->CreateType();
   }

   property AssemblyBuilder^ MyAssembly 
   {
      AssemblyBuilder^ get()
      {
         return this->myAssemblyBuilder;
      }
   }
};

int main()
{
   CodeGenerator^ myCodeGenerator = gcnew CodeGenerator;

   // Get the assembly builder for 'myCodeGenerator' object.
   AssemblyBuilder^ myAssemblyBuilder = myCodeGenerator->MyAssembly;

   // Get the module builder for the above assembly builder object .
   ModuleBuilder^ myModuleBuilder = myAssemblyBuilder->GetDynamicModule( "TempModule" );
   Console::WriteLine( "The fully qualified name and path to this module is :{0}", myModuleBuilder->FullyQualifiedName );
   Type^ myType = myModuleBuilder->GetType( "TempClass" );
   MethodInfo^ myMethodInfo = myType->GetMethod( "MyMethod" );

   // Get the token used to identify the method within this module.
   MethodToken myMethodToken = myModuleBuilder->GetMethodToken( myMethodInfo );
   Console::WriteLine( "Token used to identify the method of 'myType'"
   " within the module is {0:x}", myMethodToken.Token );
   array<Object^>^args = {"Hello."};
   Object^ myObject = Activator::CreateInstance( myType, nullptr, nullptr );
   myMethodInfo->Invoke( myObject, args );
}
// </Snippet1>

#using <System.Xml.dll>

using namespace System;
using namespace System::IO;
using namespace System::Xml;
using namespace System::Xml::Serialization;

public ref class Sample
{
   // <Snippet1>
private:
   void serializer_UnknownNode( Object^ /*sender*/, XmlNodeEventArgs^ e )
   {
      Console::WriteLine( "UnknownNode LocalName: {0}", e->LocalName );
   }
   // </Snippet1>
};

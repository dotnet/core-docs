﻿using System;

//-----------------------------------------------------------------------------
namespace XmlTags
{
    //<ClassExample>
    /// <summary>
    /// Every class and member should have a one sentence
    /// summary describing its purpose.
    /// </summary>
    /// <remarks>
    /// You can expand on that one sentence summary to
    /// provide more information for readers. In this case, 
    /// the <c>ExampleClass</c> provides different C#
    /// elements to show how you would add documentation
    ///comments for most elements in a typical class.
    /// <para>
    /// The remarks can add multiple paragraphs, so you can
    /// write detailed information for developers that use
    /// your work. You should add everything needed for
    /// readers to be successful. This class contains
    /// examples for the following:
    /// </para>
    /// <list type="table">
    /// <item>
    /// <term>Summary</term>
    /// <description>
    /// This should provide a one sentence summary of the class or member.
    /// </description>
    /// </item>
    /// <item>
    /// <term>Remarks</term>
    /// <description>
    /// This is typically a more detailed description of the class or member
    /// </description>
    /// </item>
    /// <item>
    /// <term>para</term>
    /// <description>
    /// The para tag separates a section into multiple paragraphs
    /// </description>
    /// </item>
    /// <item>
    /// <term>list</term>
    /// <description>
    /// Provides a list of terms or elements
    /// </description>
    /// </item>
    /// <item>
    /// <term>returns, param</term>
    /// <description>
    /// Used to describe parameters and return values
    /// </description>
    /// </item>
    /// <item>
    /// <term>value</term>
    /// <description>Used to describe properties</description>
    /// </item>
    /// <item>
    /// <term>exception</term>
    /// <description>
    /// Used to describe exceptions that may be thrown
    /// </description>
    /// </item>
    /// <item>
    /// <term>c, cref, see, seealso</term>
    /// <description>
    /// These provide code style and links to other
    /// documentation elements
    /// </description>
    /// </item>
    /// <item>
    /// <term>example, code</term>
    /// <description>
    /// These are used for code examples
    /// </description>
    /// </item>
    /// </list>
    /// <para>
    /// The list above uses the "table" style. You could
    /// also use the "bullet" or "number" style. Neither
    /// would typically use the "term" element.
    /// </para>
    /// </remarks>
    public class ExampleClass
    {
        /// <value>
        /// The <c>Label</c> property represents a label
        /// for this instance.
        /// </value>
        /// <remarks>
        /// The <see cref="Label"/> is a <see langword="string"/>
        /// that you use for a label.
        /// <para>
        /// Note that there isn't a way to provide a "cref" to
        /// each accessor, only to the property itself.
        /// </para>
        /// </remarks>
        public string Label
        {
            get;
            set;
        }

        /// <summary>
        /// Adds two integers and returns the result.
        /// </summary>
        /// <returns>
        /// The sum of two integers.
        /// </returns>
        /// <param name="left">
        /// The left operand of the addition.
        /// </param>
        /// <param name="right">
        /// The right operand of the addition.
        /// </param>
        /// <example>
        /// <code>
        /// int c = Math.Add(4, 5);
        /// if (c > 10)
        /// {
        ///     Console.WriteLine(c);
        /// }
        /// </code>
        /// </example>
        /// <exception cref="System.OverflowException">
        /// Thrown when one parameter is 
        /// <see cref="Int32.MaxValue"/> and the other is
        /// greater than 0.
        /// Note that here you can also use 
        /// <see href="https://docs.microsoft.com/dotnet/api/system.int32.maxvalue"/>
        ///  to point a web page instead.
        /// </exception>
        /// <see cref="ExampleClass"/> for a list of all
        /// the tags in these examples.
        /// <seealso cref="ExampleClass.Label"/>
        public static int Add(int left, int right)
        {
            if ((left == int.MaxValue && right > 0) || (right == int.MaxValue && left > 0))
                throw new System.OverflowException();

            return left + right;
        }
    }

    /// <summary>
    /// This is an example of a positional record.
    /// </summary>
    /// <remarks>
    /// There isn't a way to add XML comments for properties
    /// created for positional records, yet. The language
    /// design team is still considering what tags should
    /// be supported, and where. Currently, you can use
    /// the "param" tag to describe the parameters to the
    /// primary constructor.
    /// </remarks>
    /// <param name="FirstName">
    /// This tag will apply to the primary constructor parameter.
    /// </param>
    /// <param name="LastName">
    /// This tag will apply to the primary constructor parameter.
    /// </param>
    public record Person(string FirstName, string LastName);
}
//</ClassExample>

namespace InheritDoc
{
    //<InheritDocTag>
    /// <summary>
    /// A summary about this class.
    /// </summary>
    /// <remarks>
    /// These remarks would explain more about this class.
    /// In this example, these comments also explain the 
    /// general information about the derived class.
    /// </remarks>
    public class MainClass
    {
    }

    ///<inheritdoc/>
    public class DerivedClass : MainClass
    {
    }

    /// <summary>
    /// This interface would describe all the methods in
    /// its contract.
    /// </summary>
    /// <remarks>
    /// While elided for brevity, each method or property
    /// in this interface would contain docs that you want
    /// to duplicate in each implementing class. 
    /// </remarks>
    public interface ITestInterface
    {
    }

    ///<inheritdoc cref="ITestInterface"/>
    public class ImplementingClass : ITestInterface
    {
    }

    /// <summary>
    /// This class shows hows you can "inherit" the doc
    /// comments from one method in another method.
    /// </summary>
    /// <remarks>
    /// You can inherit all comments, or only a specific tag,
    /// represented by an xpath expression.
    /// </remarks>
    public class InheritOnlyReturns
    {
        /// <summary>
        /// In this example, this summary is only visible for this method.
        /// </summary>
        /// <returns>A boolean</returns>
        public static bool MyParentMethod(bool x) { return x; }

        /// <inheritdoc cref="MyParentMethod" path="/returns"/>
        public static bool MyChildMethod() { return false; }
    }

    public class InheritAllButRemarks
    {
        /// <summary>
        /// In this example, this summary is visible on all the methods.
        /// </summary>
        /// <remarks>
        /// The remarks can be inherited by other methods
        /// using the xpath expression.
        /// </remarks>
        /// <returns>A boolean</returns>
        public static bool MyParentMethod(bool x) { return x; }

        /// <inheritdoc cref="MyParentMethod" path="//*[not(self::remarks)]"/>
        public static bool MyChildMethod() { return false; }
    }
    //</InheritDocTag>

    //<IncludeTag>
    /// <include file='xml_include_tag.xml' path='MyDocs/MyMembers[@name="test"]/*' />
    class Test
    {
        static void Main()
        {
        }
    }

    /// <include file='xml_include_tag.xml' path='MyDocs/MyMembers[@name="test2"]/*' />
    class Test2
    {
        public void Test()
        {
        }
    }
    //</IncludeTag>
}

//<GenericExample>
/// <summary>
/// This is a generic class.
/// </summary>
/// <remarks>
/// This example shows how to specify the <see cref="GenericClass{T}"/>
/// type as a cref attribute.
/// In generic classes and methods, you'll often want to reference the
/// generic type, or the type parameter.
/// </remarks>
class GenericClass<T>
{
    // Fields and members.
}

public class ParamsAndParamRefs
{
    /// <summary>
    /// The GetGenericValue method.
    /// </summary>
    /// <remarks>
    /// This sample shows how to specify the <see cref="GetGenericValue"/>
    /// method as a cref attribute.
    /// The parameter and return value are both of an arbitrary type,
    /// <typeparamref name="T"/>
    /// </remarks>
    public static T GetGenericValue<T>(T para)
    {
        return para;
    }
}
//</GenericExample>

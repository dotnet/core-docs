---
title: Create a .NET Standard class library in Visual Studio
description: Learn how to create a .NET Standard class library using Visual Studio.
ms.date: 05/21/2020
dev_langs:
  - "csharp"
  - "vb"
ms.custom: "vs-dotnet"
---
# Tutorial: Create a .NET Standard library in Visual Studio

A *class library* defines types and methods that are called by an application. A class library that targets .NET Standard 2.0 allows your library to be called by any .NET implementation that supports that version of .NET Standard. When you finish your class library, you can decide whether you want to distribute it as a third-party component or whether you want to include it as a bundled component with one or more applications.

> [!NOTE]
> For a list of .NET Standard versions and the platforms they support, see [.NET Standard](../../standard/net-standard.md).

In this tutorial, you create a simple utility library that contains a single string-handling method. You implement it as an [extension method](../../csharp/programming-guide/classes-and-structs/extension-methods.md) so that you can call it as if it were a member of the <xref:System.String> class.

## Prerequisites

- [Visual Studio 2019 version 16.6 or a later version](https://visualstudio.microsoft.com/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=inline+link&utm_content=download+vs2019) with the **.NET Core cross-platform development** workload installed. .NET Core 3.1 SDK is automatically installed when you select this workload.

  For more information, see the [Install with Visual Studio](../install/sdk.md?pivots=os-windows#install-with-visual-studio) section on the [Install the .NET Core SDK](../install/sdk.md?pivots=os-windows) article.

## Create a Visual Studio solution

Start by creating a blank solution to put the class library project in. A Visual Studio solution serves as a container for one or more projects. You'll add additional, related projects to the same solution.

To create the blank solution:

1. Open Visual Studio.

2. On the start window, choose **Create a new project**.

3. On the **Create a new project** page, enter **solution** in the search box. Choose the **Blank Solution** template, and then choose **Next**.

   ![Blank solution template in Visual Studio](media/library-with-visual-studio/blank-solution.png)

4. On the **Configure your new project** page, enter **ClassLibraryProjects** in the **Project name** box. Then choose **Create**.

## Create a class library project

1. Add a new .NET Standard class library project named "StringLibrary" to the solution.

   1. Right-click on the solution in **Solution Explorer** and select **Add** > **New Project**.

   1. On the **Add a new project** page, enter **library** in the search box. Choose **C#** or **Visual Basic** from the Language list, and then choose **All platforms** from the Platform list. Choose the **Class Library (.NET Standard)** template, and then choose **Next**.

   1. On the **Configure your new project** page, enter **StringLibrary** in the **Project name** box. Then, choose **Create**.

1. Check to make sure that the library targets the correct version of .NET Standard. Right-click on the library project in **Solution Explorer**, and then select **Properties**. The **Target Framework** text box shows that the project targets .NET Standard 2.0.

   ![Project properties for the class library](./media/library-with-visual-studio/library-project-properties.png)

1. If you're using Visual Basic, clear the text in the **Root namespace** text box.

   ![Project properties for the class library](./media/library-with-visual-studio/vb/library-project-properties.png)

   For each project, Visual Basic automatically creates a namespace that corresponds to the project name. In this tutorial, you define a top-level namespace by using the [`namespace`](../../visual-basic/language-reference/statements/namespace-statement.md) keyword in the code file.

1. Replace the code in the code window for *Class1.cs*  or *Class1.vb* with the following code, and save the file. If the language you want to use is not shown, change the language selector at the top of the page.

   [!code-csharp[](../../../samples/snippets/csharp/getting_started/with_visual_studio_2017/classlib.cs)]
   [!code-vb[](../../../samples/snippets/core/tutorials/vb-library-with-visual-studio/stringlibrary.vb)]

   The class library, `UtilityLibraries.StringLibrary`, contains a method named `StartsWithUpper`. This method returns a <xref:System.Boolean> value that indicates whether the current string instance begins with an uppercase character. The Unicode standard distinguishes uppercase characters from lowercase characters. The <xref:System.Char.IsUpper(System.Char)?displayProperty=nameWithType> method returns `true` if a character is uppercase.

1. On the menu bar, select **Build** > **Build Solution** to verify that the project compiles without error.

## Add a console app to the solution

Use the class library in a console application that prompts the user to enter a string and reports whether the string begins with an uppercase character.

1. Add a new .NET Core console application named "ShowCase" to the solution.

   1. Right-click on the solution in **Solution Explorer** and select **Add** > **New project**.

   1. On the **Add a new project** page, enter **console** in the search box. Choose **C#** or **Visual Basic** from the Language list, and then choose **All platforms** from the Platform list.

   1. Choose the **Console App (.NET Core)** template, and then choose **Next**.

   1. On the **Configure your new project** page, enter **ShowCase** in the **Project name** box. Then choose **Create**.

1. In **Solution Explorer**, right-click the **ShowCase** project and select **Set as StartUp Project** in the context menu.

   ![Visual Studio project context menu to set startup project](media/library-with-visual-studio/set-startup-project-context-menu.png)

1. Initially, the new console app project doesn't have access to the class library. To allow it to call methods in the class library, create a project reference to the class library project. In **Solution Explorer**, right-click the `ShowCase` project's **Dependencies** node, and select **Add Project Reference**.

   ![Add reference context menu in Visual Studio](media/library-with-visual-studio/add-reference-context-menu.png)

1. In the **Reference Manager** dialog, select the **StringLibrary** project, and select **OK**.

   ![Reference Manager dialog with StringLibrary selected](media/library-with-visual-studio/manage-project-references.png)

1. In the code window for the *Program.cs* or *Program.vb* file, replace all of the code with the following code.

   [!code-csharp[UsingClassLib#1](~/samples/snippets/csharp/getting_started/with_visual_studio_2017/showcase.cs)]
   [!code-vb[UsingClassLib#1](~/samples/snippets/core/tutorials/vb-library-with-visual-studio/showcase.vb)]

   The code uses the `row` variable to maintain a count of the number of rows of data written to the console window. Whenever it's greater than or equal to 25, the code clears the console window and displays a message to the user.

   The program prompts the user to enter a string. It indicates whether the string starts with an uppercase character. If the user presses the Enter key without entering a string, the application ends, and the console window closes.

1. If necessary, change the toolbar to compile the **Debug** release of the `ShowCase` project. Compile and run the program by selecting the green arrow on the **ShowCase** button.

   ![Visual Studio project toolbar showing Debug button](media/library-with-visual-studio/visual-studio-project-toolbar.png)

1. Try out the program by entering strings and pressing **Enter**, then press **Enter** to exit.

   :::image type="content" source="media/library-with-visual-studio/run-showcase.png" alt-text="Console window with ShowCase running":::

## Next steps

In this tutorial, you created a solution, added a library project, and added a console app project that uses the library. In the next tutorial, you add a unit test project to the solution.

> [!div class="nextstepaction"]
> [Test a .NET Standard library with .NET Core in Visual Studio](testing-library-with-visual-studio.md)

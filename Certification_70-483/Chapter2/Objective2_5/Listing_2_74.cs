namespace Certification.Chapter2.Objective2_5
{
    using System;

    using Certification.Common;
    using System.CodeDom;
    using Microsoft.CSharp;
    using System.IO;
    using System.CodeDom.Compiler;

    [Listing("CodeDOM")]
    public class Listing_2_74 : IRunnable
    {
        public void Run()
        {
            CodeCompileUnit compileUnit = new CodeCompileUnit();
            CodeNamespace myNamespace = new CodeNamespace("MyNamespace");
            myNamespace.Imports.Add(new CodeNamespaceImport("System"));
            CodeTypeDeclaration myClass = new CodeTypeDeclaration("MyClass");
            CodeEntryPointMethod start = new CodeEntryPointMethod();
            CodeMethodInvokeExpression cs1 = new CodeMethodInvokeExpression(
                new CodeTypeReferenceExpression("Console"),
                "WriteLine",
                new CodePrimitiveExpression("Hello World!"));
            compileUnit.Namespaces.Add(myNamespace);
            myNamespace.Types.Add(myClass);
            myClass.Members.Add(start);
            start.Statements.Add(cs1);

            CSharpCodeProvider provider = new CSharpCodeProvider();
            using (StreamWriter sw = new StreamWriter("HelloWorld.cs", false))
            {
                IndentedTextWriter tw = new IndentedTextWriter(sw, " ");
                provider.GenerateCodeFromCompileUnit(
                    compileUnit, 
                    tw,
                    new CodeGeneratorOptions());
                tw.Close();
            }

            System.Diagnostics.Process.Start("explorer.exe", ".");
        }
    }
}

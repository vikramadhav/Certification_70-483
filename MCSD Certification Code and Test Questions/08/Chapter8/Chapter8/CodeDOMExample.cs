using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;
using System.Reflection;
using System.CodeDom.Compiler;
using System.IO;

namespace Chapter8
{
    class CodeDOMExample
    {
        static void Main(string[] args)
        {
            //Create the CodeCompileUnit that will contain the code for the class.
            CodeCompileUnit codeCompileUnit = new CodeCompileUnit();

            //Create the namespace
            CodeNamespace codeNamespace = new CodeNamespace("Reflection");

            //Add the using statements
            codeNamespace.Imports.Add(new CodeNamespaceImport("System"));
            codeNamespace.Imports.Add(new CodeNamespaceImport("System.Collections.Generic"));
            codeNamespace.Imports.Add(new CodeNamespaceImport("System.Linq"));
            codeNamespace.Imports.Add(new CodeNamespaceImport("System.Text"));
            codeNamespace.Imports.Add(new CodeNamespaceImport("System.Threading.Tasks"));

            //Declare the class
            CodeTypeDeclaration targetClass = new CodeTypeDeclaration("Calculator");
            targetClass.IsClass = true;
            targetClass.TypeAttributes = TypeAttributes.Public;

            //Add the class to the namespace.
            codeNamespace.Types.Add(targetClass);

            //Add the namespace to the code compile unit
            codeCompileUnit.Namespaces.Add(codeNamespace);

            //Create the fields
            CodeMemberField xField = new CodeMemberField();
            xField.Name = "_x";
            xField.Type = new CodeTypeReference(typeof(double));
            targetClass.Members.Add(xField);

            CodeMemberField yField = new CodeMemberField();
            yField.Name = "_y";
            yField.Type = new CodeTypeReference(typeof(double));
            targetClass.Members.Add(yField);


            //Create the properties
            CodeMemberProperty xProperty = new CodeMemberProperty();
            xProperty.Attributes = MemberAttributes.Public | MemberAttributes.Final;
            xProperty.Name = "X";
            xProperty.HasGet = true;
            xProperty.HasSet = true;
            xProperty.Type = new CodeTypeReference(typeof(System.Double));
            xProperty.GetStatements.Add(new CodeMethodReturnStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), "_x")));
            xProperty.SetStatements.Add(new CodeAssignStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), "_x"), new CodePropertySetValueReferenceExpression()));
            targetClass.Members.Add(xProperty);

            CodeMemberProperty yProperty = new CodeMemberProperty();
            yProperty.Attributes = MemberAttributes.Public | MemberAttributes.Final;
            yProperty.Name = "Y";
            yProperty.HasGet = true;
            yProperty.HasSet = true;
            yProperty.Type = new CodeTypeReference(typeof(System.Double));
            yProperty.GetStatements.Add(new CodeMethodReturnStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), "_y")));
            yProperty.SetStatements.Add(new CodeAssignStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), "_y"), new CodePropertySetValueReferenceExpression()));
            targetClass.Members.Add(yProperty);

            //Create the divide method
            CodeMemberMethod divideMethod = new CodeMemberMethod();
            divideMethod.Name = "Divide";
            divideMethod.ReturnType = new CodeTypeReference(typeof(double));
            divideMethod.Attributes = MemberAttributes.Public | MemberAttributes.Final;

            //Create the body of the method
            CodeConditionStatement ifLogic = new CodeConditionStatement();
            ifLogic.Condition = new CodeBinaryOperatorExpression(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), yProperty.Name), CodeBinaryOperatorType.ValueEquality,
                new CodePrimitiveExpression(0));
            ifLogic.TrueStatements.Add(new CodeMethodReturnStatement(new CodePrimitiveExpression(0)));
            ifLogic.FalseStatements.Add(new CodeMethodReturnStatement(
                new CodeBinaryOperatorExpression(
                    new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), xProperty.Name),
                    CodeBinaryOperatorType.Divide,
                    new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), yProperty.Name))));
            divideMethod.Statements.Add(ifLogic);

            //Add the method to the class.
            targetClass.Members.Add(divideMethod);

            //Create the Exponent method
            CodeMemberMethod exponentMethod = new CodeMemberMethod();
            exponentMethod.Name = "Exponent";
            exponentMethod.ReturnType = new CodeTypeReference(typeof(double));
            exponentMethod.Attributes = MemberAttributes.Public | MemberAttributes.Final;

            CodeParameterDeclarationExpression powerParameter = new CodeParameterDeclarationExpression(typeof(double), "power");
            exponentMethod.Parameters.Add(powerParameter);

            CodeMethodInvokeExpression callToMath = new CodeMethodInvokeExpression(
                new CodeTypeReferenceExpression("System.Math"),
                "Pow", new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), xProperty.Name), new CodeArgumentReferenceExpression("power"));

            exponentMethod.Statements.Add(new CodeMethodReturnStatement(callToMath));

            targetClass.Members.Add(exponentMethod);

            //Generate the file as a C# class.
            CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
            CodeGeneratorOptions options = new CodeGeneratorOptions();
            options.BlankLinesBetweenMembers = false;
            options.BracingStyle = "C";

            using (StreamWriter sourceWriter = new StreamWriter(@"c:\CodeDom\Calculator." + provider.FileExtension))
            {
                provider.GenerateCodeFromCompileUnit(codeCompileUnit, sourceWriter, options);
            }
        }
    }
}

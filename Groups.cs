using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1250FinalReview
{
    public class Groups
    {
        public static void TopicGroups()
        {
            string msg = "Topic Groups:\n" +
                "\t1. Misc\n" +
                "\t2. Coding Basics\n" +
                "\t3. Coding Standards\n" +
                "\t4. Data Types and Operators\n" +
                "\t5. Decision Structures\n" +
                "\t6. Decision Structure Operators\n" +
                "\t7. Methods\n" +
                "\t8. Namespace and Classes\n" +
                "\t9. Exit Program\n";
            msg += "Which would you like to access? ";

            Console.Write(msg);
            Selectors.GroupSelector();
        }
        public static void Misc()
        {
            string msg = "Topics:\n" +
                "\t1. Problem Solving\n" +
                "\t2. Memory Allocation\n" +
                "\t3. Compiling\n" +
                "\t4. IDE\n" +
                "\t5. Algorithms\n" +
                "\t6. Select a Different Group\n";
            msg += "Which would you like to access? ";

            Console.Write(msg);
            Selectors.MiscSelector();
        }
        public static void CodingBasics()
        {
            string msg = "Topics:\n" +
                "\t1. WriteLine and ReadLine\n" +
                "\t2. Data Type Conversion\n" +
                "\t3. Concatenation vs Interpolation\n" +
                "\t4. Initiation, Declaration, and Assignment\n" +
                "\t5. Keywords\n" +
                "\t6. Select a Different Group\n";
            msg += "Which would you like to access? ";

            Console.Write(msg);
            Selectors.CodingBasicsSelector();
        }
        public static void CodingStandards()
        {
            string msg = "Topics:\n" +
                "\t1. Casing\n" +
                "\t2. Comments\n" +
                "\t3. Syntax vs Logic Errors\n" +
                "\t4. Select a Different Group\n";
            msg += "Which would you like to access? ";

            Console.Write(msg);
            Selectors.CodingStandardsSelector();
        }
        public static void DataTypesAndOperators()
        {
            string msg = "Topics:\n" +
                "\t1. Data Types\n" +
                "\t2. Primitive vs Non-Primitive\n" +
                "\t3. Null\n" +
                "\t4. Objects\n" +
                "\t5. Implicit vs Explicit Var\n" +
                "\t6. Arrays and Lists\n" +
                "\t7. Constants\n" +
                "\t8. Logic Operators\n" +
                "\t9. Select a Different Group\n";
            msg += "Which would you like to access? ";

            Console.Write(msg);
            Selectors.DataTypesAndOperatorsSelector();
        }
        public static void DecisionStructures()
        {
            string msg = "Topics:\n" +
                "\t1. Scope\n" +
                "\t2. Return Type\n" +
                "\t3. Loops\n" +
                "\t4. Escape Characters\n" +
                "\t5. Header Examples\n" +
                "\t6. Select a Different Group\n";
            msg += "Which would you like to access? ";

            Console.Write(msg);
            Selectors.DecisionStructuresSelector();
        }
        public static void DecisionStructureOperators()
        {
            string msg = "Topics:\n" +
                "\t1. Comparison Operators\n" +
                "\t2. Order of Operations\n" +
                "\t3. Truth Tables\n" +
                "\t4. Select a Different Group\n";
            msg += "Which would you like to access? ";

            Console.Write(msg);
            Selectors.DecisionStructureOperatorsSelector();
        }
        public static void Methods()
        {
            string msg = "Topics:\n" +
                "\t1. Structure\n" +
                "\t2. Accessibility\n" +
                "\t3. Instantiation\n" +
                "\t4. Arguments and Parameters\n" +
                "\t5. Void\n" +
                "\t6. Constructors, Parameterized and Default\n" +
                "\t7. Copy Constructors\n" +
                "\t8. Equals Method\n" +
                "\t9. ToString Method\n" +
                "\t10. Deep vs Shallow Copies\n" +
                "\t11. Select a Different Group\n";
            msg += "Which would you like to access? ";

            Console.Write(msg);
            Selectors.MethodsSelector();
        }
        public static void NamespaceAndClasses()
        {
            string msg = "Topics:\n" +
                "\t1. Top Level Statements\n" +
                "\t2. Namespace\n" +
                "\t3. Classes\n" +
                "\t4. Properties, Fields, and Attributes\n" +
                "\t5. Getters and Setters\n" +
                "\t6. Using --> Other Code\n" +
                "\t7. UML\n" +
                "\t8. Object Class\n" +
                "\t9. Select a Different Group\n";
            msg += "Which would you like to access? ";

            Console.Write(msg);
            Selectors.NamespaceAndClassesSelector();
        }

    }
}

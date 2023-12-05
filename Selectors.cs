using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1250FinalReview
{
    public class Selectors
    {
        public static void GroupSelector()
        {
            string input = Console.ReadLine();
            int caseNum = 1;

            bool loopNumError = false;
            while (!int.TryParse(input, out caseNum) || loopNumError)
            {
                if (caseNum > 9 || caseNum < 1)
                {
                    loopNumError = true;
                }
                Console.Write("That wasn't a number... ");
                input = Console.ReadLine();
            }

            Console.WriteLine("");


            switch (caseNum)
            {
                case 1:
                    Groups.Misc();
                    break;
                case 2:
                    Groups.CodingBasics();
                    break;
                case 3:
                    Groups.CodingStandards();
                    break;
                case 4:
                    Groups.DataTypesAndOperators();
                    break;
                case 5:
                    Groups.DecisionStructures();
                    break;
                case 6:
                    Groups.DecisionStructureOperators();
                    break;
                case 7:
                    Groups.Methods();
                    break;
                case 8:
                    Groups.NamespaceAndClasses();
                    break;
                case 9:
                    Environment.Exit(0);
                    break;
            }
        }
        public static void MiscSelector()
        {
            string input = Console.ReadLine();
            int caseNum = 1;

            bool loopNumError = false;
            while (!int.TryParse(input, out caseNum) || loopNumError)
            {
                if (caseNum > 6 || caseNum < 1)
                {
                    loopNumError = true;
                }
                Console.Write("That wasn't a number... ");
                input = Console.ReadLine();
            }

            Console.WriteLine("");


            switch (caseNum)
            {
                case 1:
                    Topics.ProblemSolving();
                    break;
                case 2:
                    Topics.MemoryAllocation();
                    break;
                case 3:
                    Topics.Compiling();
                    break;
                case 4:
                    Topics.IDE();
                    break;
                case 5:
                    Topics.Algorithms();
                    break;
                case 6:
                    Groups.TopicGroups();
                    break;
            }
        }
        public static void CodingBasicsSelector()
        {
            string input = Console.ReadLine();
            int caseNum = 1;

            bool loopNumError = false;
            while (!int.TryParse(input, out caseNum) || loopNumError)
            {
                if (caseNum > 6 || caseNum < 1)
                {
                    loopNumError = true;
                }
                Console.Write("That wasn't a number... ");
                input = Console.ReadLine();
            }

            Console.WriteLine("");


            switch (caseNum)
            {
                case 1:
                    Topics.WriteLineAndReadLine();
                    break;
                case 2:
                    Topics.DataTypeConversion();
                    break;
                case 3:
                    Topics.ConcatenationInterpolation();
                    break;
                case 4:
                    Topics.InitiationDeclarationAssignment();
                    break;
                case 5:
                    Topics.Keywords();
                    break;
                case 6:
                    Groups.TopicGroups();
                    break;
            }
        }
        public static void CodingStandardsSelector()
        {
            string input = Console.ReadLine();
            int caseNum = 1;

            bool loopNumError = false;
            while (!int.TryParse(input, out caseNum) || loopNumError)
            {
                if (caseNum > 4 || caseNum < 1)
                {
                    loopNumError = true;
                }
                Console.Write("That wasn't a number... ");
                input = Console.ReadLine();
            }

            Console.WriteLine("");


            switch (caseNum)
            {
                case 1:
                    Topics.Casing();
                    break;
                case 2:
                    Topics.Comments();
                    break;
                case 3:
                    Topics.SyntaxVSLogicErrors();
                    break;
                case 4:
                    Groups.TopicGroups();
                    break;
            }
        }
        public static void DataTypesAndOperatorsSelector()
        {
            string input = Console.ReadLine();
            int caseNum = 1;

            bool loopNumError = false;
            while (!int.TryParse(input, out caseNum) || loopNumError)
            {
                if (caseNum > 9 || caseNum < 1)
                {
                    loopNumError = true;
                }
                Console.Write("That wasn't a number... ");
                input = Console.ReadLine();
            }

            Console.WriteLine("");


            switch (caseNum)
            {
                case 1:
                    Topics.DataTypes();
                    break;
                case 2:
                    Topics.PrimitiveVSNonPrimitive();
                    break;
                case 3:
                    Topics.Null();
                    break;
                case 4:
                    Topics.Objects();
                    break;
                case 5:
                    Topics.ImplicitVSExplicitVar();
                    break;
                case 6:
                    Topics.ArraysLists();
                    break;
                case 7:
                    Topics.Constants();
                    break;
                case 8:
                    Topics.LogicOperators();
                    break;
                case 9:
                    Groups.TopicGroups();
                    break;
            }
        }
        public static void DecisionStructuresSelector()
        {
            string input = Console.ReadLine();
            int caseNum = 1;

            bool loopNumError = false;
            while (!int.TryParse(input, out caseNum) || loopNumError)
            {
                if (caseNum > 6 || caseNum < 1)
                {
                    loopNumError = true;
                }
                Console.Write("That wasn't a number... ");
                input = Console.ReadLine();
            }

            Console.WriteLine("");


            switch (caseNum)
            {
                case 1:
                    Topics.Scope();
                    break;
                case 2:
                    Topics.ReturnType();
                    break;
                case 3:
                    Topics.Loops();
                    break;
                case 4:
                    Topics.EscapeCharacters();
                    break;
                case 5:
                    Topics.HeaderExamples();
                    break;
                case 6:
                    Groups.TopicGroups();
                    break;
            }
        }
        public static void DecisionStructureOperatorsSelector()
        {
            string input = Console.ReadLine();
            int caseNum = 1;

            bool loopNumError = false;
            while (!int.TryParse(input, out caseNum) || loopNumError)
            {
                if (caseNum > 4 || caseNum < 1)
                {
                    loopNumError = true;
                }
                Console.Write("That wasn't a number... ");
                input = Console.ReadLine();
            }

            Console.WriteLine("");


            switch (caseNum)
            {
                case 1:
                    Topics.ComparisonOperators();
                    break;
                case 2:
                    Topics.OrderOfOperations();
                    break;
                case 3:
                    Topics.TruthTables();
                    break;
                case 4:
                    Groups.TopicGroups();
                    break;
            }
        }
        public static void MethodsSelector()
        {
            string input = Console.ReadLine();
            int caseNum = 1;

            bool loopNumError = false;
            while (!int.TryParse(input, out caseNum) || loopNumError)
            {
                if (caseNum > 11 || caseNum < 1)
                {
                    loopNumError = true;
                }
                Console.Write("That wasn't a number... ");
                input = Console.ReadLine();
            }

            Console.WriteLine("");


            switch (caseNum)
            {
                case 1:
                    Topics.MethodStructure();
                    break;
                case 2:
                    Topics.Accessibility();
                    break;
                case 3:
                    Topics.Instantiation();
                    break;
                case 4:
                    Topics.ArgumentsParameters();
                    break;
                case 5:
                    Topics.Void();
                    break;
                case 6:
                    Topics.ConstructorsParameterizedDefault();
                    break;
                case 7:
                    Topics.CopyConstructors();
                    break;
                case 8:
                    Topics.EqualsMethod();
                    break;
                case 9:
                    Topics.ToStringMethod();
                    break;
                case 10:
                    Topics.ShallowVSDeepCopies();
                    break;
                case 11:
                    Groups.TopicGroups();
                    break;
            }
        }
        public static void NamespaceAndClassesSelector()
        {
            string input = Console.ReadLine();
            int caseNum = 1;

            bool loopNumError = false;
            while (!int.TryParse(input, out caseNum) || loopNumError)
            {
                if (caseNum > 9 || caseNum < 1)
                {
                    loopNumError = true;
                }
                Console.Write("That wasn't a number... ");
                input = Console.ReadLine();
            }

            Console.WriteLine("");


            switch (caseNum)
            {
                case 1:
                    Topics.TopLevelStatements();
                    break;
                case 2:
                    Topics.Namespace();
                    break;
                case 3:
                    Topics.Classes();
                    break;
                case 4:
                    Topics.PropertiesFieldsAttributes();
                    break;
                case 5:
                    Topics.GettersSetters();
                    break;
                case 6:
                    Topics.UsingOtherCode();
                    break;
                case 7:
                    Topics.UML();
                    break;
                case 8:
                    Topics.ObjectClass();
                    break;
                case 9:
                    Groups.TopicGroups();
                    break;
            }
        }
    }
}

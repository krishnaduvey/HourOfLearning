using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace AdvancedCSharp
{
    class CollectionsInfo
    {

        class ArryasInfo {
            /*
                 limit in .NET
                Single array object take on 2GB memory but you ca overcome the limit via adding <gcAllowVeryLargeObjects enabled="true" />  element inside the <runtime> section of a project’s App.config file. 
                The limits in the preceding paragraph still apply, but those are significantly less restrictive than a 2-GB ceiling.

                 */


            public void arrayBasics() {

                int[] numbers = new int[10];
                string[] strings = new string[numbers.Length];


                // Continued from Example 5-1
                numbers[0] = 42;
                numbers[1] = numbers.Length;
                numbers[2] = numbers[0] + numbers[1];
                numbers[numbers.Length - 1] = 99;


                //var values = new Complex[10];
                // These lines both cause compiler errors:
                //values[0].Real = 10;
                //values[0].Imaginary = 1;



                /*
                 Note :
                 Rectangular arrays are not just about convenience. 
                 There’s a type safety aspect too: int[,] is a different type than int[] or int[,,], 
                 so if you write a method that expects a two-dimensional rectangular array, C# will not allow anything else to be passed.
                 
                 */

                int[,] grid = new int[5, 10];
                var smallerGrid = new int[,]{
                                                { 1, 2, 3, 4 },
                                                { 2, 3, 4, 5 },
                                                { 3, 4, 5, 6 },
                                            };




                var cuboid = new int[,,]
{
    {
        { 1, 2, 3, 4, 5 },
        { 2, 3, 4, 5, 6 },
        { 3, 4, 5, 6, 7 }
    },
    {
        { 2, 3, 4, 5, 6 },
        { 3, 4, 5, 6, 7 },
        { 4, 5, 6, 7, 8 }
    },
};

            }

            //Searching with FindIndex
            public static int GetIndexOfFirstNonEmptyBin(int[] bins)
    => Array.FindIndex(bins, IsNonZero);

            private static bool IsNonZero(int value) => value != 0;

            public static int AdditionOfTwoNumber(int a, int b) 
                => a + b;



            public static string GetCopyrightForType(object o)
            {
                Assembly asm = o.GetType().Assembly;
                var copyrightAttribute = (AssemblyCopyrightAttribute)
                    asm.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), true)[0];
                return copyrightAttribute.Copyright;
            }

        }

        class ListInfo {

        }

        class DictionaryInfo {
            Dictionary<string, int> ages = new Dictionary<string, int> { { "Luke", 53 }, { "Leia", 53 } };
            Dictionary<List<string>, List<string>> dic = new Dictionary<List<string>, List<string>>();
            Dictionary<List<string>, string> dic2 = new Dictionary<List<string>, string>();

            public static void DictionaryInfoData() {

                var droids = new Dictionary<string, SetInfo>() { { "R2 D2", new SetInfo() } };
                SetInfo r2d2 = droids["R2 D2"];
                droids.Add("R2 D2", new SetInfo());

            }

        }

        class SetInfo {

        }
        class EmployyeProperties {

           public String EmployeeName { get; set; }
           public int? price { get; set; }

        }

        public class Slice
        {
            public string PatientName { get; set; }
            public string PatientBirthDate { get; set; }
            public string ScanCode { get; set; }
            public string StudyDate { get; set; }
            public string StudyFolder { get; set; }
            public string ModelName { get; set; }
            public string ManufacturerModelName { get; set; }
            public string StationName { get; set; }
            public float? MagneticFieldStrength { get; set; }
            public string StudyInstanceUid { get; set; }
            public string SeriesInstanceUid { get; set; }
            public int? AcquisitionNumber { get; set; }
            public string ProtocolName { get; set; }
            public string SequenceName { get; set; }
            public string SeriesDescription { get; set; }
            public string DataUid { get; set; }
        }


    }
}

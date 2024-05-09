using System;

using System.IO;



namespace ActivityAssessment_5_9_24

{

    class CopyAndDelete

    {

        static void Main(string[] args)

        {

            string srsPath = @"StudFile1.txt";  // the original source of file

            string desPath = @"StudFile2.txt"; // the destination



            try // try catch method

            {

                if (File.Exists(srsPath))

                {

                    File.Copy(srsPath, desPath, true); // copy the source file to the destination, which is the StudFile2.txt



                    File.Delete(srsPath); // deleting the main source after copying it to the destination



                    string content = File.ReadAllText(desPath);

                    Console.WriteLine("Contents of StudFile2.txt:");

                    Console.WriteLine(content);

                }

                else

                {

                    Console.WriteLine("Error: StudFile1.txt not found");

                }

            }

            catch (Exception ex) // error handler

            {

                Console.WriteLine("Exception: {0}", ex.Message);

            }



            Console.ReadLine();

        }

    }

}


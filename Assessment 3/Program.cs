using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assessment3
{
    public class Assessment3
    {

        public static string[] File1(string[] instructions)
        {
            //Load In the Files
            String[] file1a = File.ReadAllLines("GitRepositories_1a.txt");
            String[] file1b = File.ReadAllLines("GitRepositories_1b.txt");
            String[] file2a = File.ReadAllLines("GitRepositories_2a.txt");
            String[] file2b = File.ReadAllLines("GitRepositories_2b.txt");
            String[] file3a = File.ReadAllLines("GitRepositories_3a.txt");
            String[] file3b = File.ReadAllLines("GitRepositories_3b.txt");

            if (file1a == file1b)
            {
                Console.WriteLine("Both content Same");

            }
            else
            {
                Console.WriteLine("Both content Not Same");
                IEnumerable<string> Check_Difference1 = file1a.Except(file1b);
                Checking_display(Check_Difference1);
            }

            if (file2a == file2b)
            {
                Console.WriteLine("Both content Same");

            }
            else
            {
                Console.WriteLine("Both content Not Same");
                IEnumerable<string> Check_Difference2 = file2a.Except(file2b);
                Checking_display(Check_Difference2);
            }

            if (file3a == file3b)
            {
                Console.WriteLine("Both content Same");

            }
            else
            {
                Console.WriteLine("Both content Not Same");
                IEnumerable<string> Check_Difference3 = file3a.Except(file3b);
                Checking_display(Check_Difference3);
            }
        }


    }

    
    
}
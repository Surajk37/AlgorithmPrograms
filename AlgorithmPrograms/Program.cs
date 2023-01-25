namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome To Algorithm Programs");
            Console.WriteLine("\t\t*****************************\n");
            string str1 = "heart";
            string str2 = "earth";

            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray(); //Asci code is used 

            Array.Sort(ch1);
            Array.Sort(ch2);

            string s1 = new string(ch1);
            string s2 = new string(ch2);

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            if (s1 == s2)
            {
                Console.WriteLine("Is Anagram");
            }
            else
            {
                Console.WriteLine("Is Not Anagram");
            }

            Console.ReadLine();
        }
    }
}
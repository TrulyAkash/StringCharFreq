namespace StringEX
{
    class Xyz
    {
        //public void PrintFrequency(int[] freq)
        //{
        //    for (int i = 0; i < 26; i++)
        //    {



        //        if (freq[i] != 0)
        //        {



        //            Console.WriteLine("frequency of " + Convert.ToChar(i + 'a') + " is " + freq[i]);
        //        }
        //    }
        //}



        //public void FindFrequncy(char[] s)
        //{
        //    int i = 0;



        //    int[] freq = new int[26];


        //    while (i < s.Length)
        //    {


        //        freq[s[i] - 'a']++;


        //        i++;
        //    }


        //    PrintFrequency(freq);
        //}
        static void Main(string[] args)
        {

            int j, i;

            string str = "mathematics";
            char[] arr = new char[str.Length];

             for (i = 0; i < arr.Length; i++)
            {
                arr[i] = str[i];

            }
            for (j = 0; j < arr.Length; j++)
                Console.Write(arr[j]);
            Console.WriteLine();

            //Xyz x = new Xyz();
            //x.FindFrequncy(arr);

            i = 0;
            int[] freq = new int[26];

            while (i < arr.Length)
            {

                freq[arr[i] - 'a']++;
                i++;
            }
            for (i = 0; i < 26; i++)
            {

                if (freq[i] != 0)
                {

                    Console.WriteLine("frequency of " + Convert.ToChar(i + 'a') + " is " + freq[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
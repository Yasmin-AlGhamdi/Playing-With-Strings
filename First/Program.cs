using System;

namespace First
{
    class Program
    {
        class Searchable
        {
            string value; //private

            public Searchable(string val)
            {
                this.value = val;
            }

            //Functions
            public int numOfWord() 
            {
                int index = 0;
                int count = 1;
                //string word = "Welcome to c#!";
                while (index <= value.Length - 1)
                {
                    if (value[index] == ' ' || value[index] == '\n' || value[index] == '\t')
                    {
                        count++;
                    }
                    index++;
                }
                Console.WriteLine("Total Words = " + count);
                return 0;
            }
            public int numofChars() 
            {
                int count = 0;
                bool lastWasSpace = false;
                foreach (var c in value)
                {
                    if (char.IsWhiteSpace(c))
                    {
                        // A.
                        // Only count sequential spaces one time.
                        if (lastWasSpace == false)
                        {
                            count++;
                        }
                        lastWasSpace = true;
                    }
                    else
                    {
                        // B.
                        // Count other characters every time.
                        count++;
                        lastWasSpace = false;
                    }
                }
                Console.WriteLine("Total characters = " + count);
                return this.value.Length;
            }
            public int numOfXWords(String word)
            {
                int count = 0;
               /* for(int i=0; i<= value.Length; i++)
                {
                    if (value.Equals(value[i]))
                    {
                        count++;
                    }
                }*/
                foreach(var w in value)
                {
                  // Console.WriteLine(word);
                  if(w.Equals(word))
                    {
                        count++;
                    }
                }
                Console.WriteLine(word+" was printed " + count +" time/s");
                return 0;
            }
            public int numofXChars(char c) 
            { 
                return 0;
            }
            public int lastIndexOf(char c)
            {
                return -1; //can't use 0 bc it's an index position
            }
            public string mostFWord()
            { 
                return null;
            }
            public string swap(string s)
            {

                string[] a = s.Split(' ');

                Array.Reverse(a);

                Console.WriteLine("Reverse String is:");

                for (int i = 0; i <= a.Length - 1; i++)

                {
                    Console.Write(a[i] + "" + ' ');
                }

                Console.ReadKey();
                return null;
            }
        }
        static void Main(string[] args)
        {
            Searchable s = new Searchable("Welcome to C#");

            s.numofChars();
            s.numOfWord();
            //Console.WriteLine(s.numOfXWords("Welcome to C#"));
            s.numOfXWords("Welcome");
            s.swap("Hello my name is yasmin");
        }
    }
}

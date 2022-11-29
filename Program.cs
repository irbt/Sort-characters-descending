//Given a string, write a method that returns array of chars (ASCII characters) sorted in descending order.
namespace Program
{
    class sortedCharTask
    {
        public static void Main(string[] args)
        {

            static void SortCharactersDescending(string s)
            {
                int len = s.Length;
                char [] tab = new char [len];
                tab= s.ToCharArray();
                Array.Sort()
                Array.Reverse(tab);
                for (int i = 0; i < len; i++)
                {                    
                Console.Write(tab[i]);y
                }
                Console.WriteLine();
            }



            SortCharactersDescending("onomatopoeia");//→ tpoooonmieaa
            SortCharactersDescending("fohjwf42os");// → wsoojhff42
        }
    }
}
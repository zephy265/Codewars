namespace Codewars
{
    internal class Program
    {
        static void Main(string[] args)
        {

    

            Console.WriteLine(  Enough(100,50,60));
            //Console.WriteLine(Maskify("Th45e"));
            //Console.WriteLine(isEven(6));
            //Console.WriteLine(CheckNumber(6));


            //Console.WriteLine(OddCount(154512365423));

            Console.ReadLine();
        }

        public static ulong OddCount(ulong u)
        {
            //Given a number n, return the number of positive odd numbers below n, EASY!

            List<ulong> oddNumberList = new List<ulong>();
            for (ulong i = 1; i < u; i++)
            {
                if (i % 2 != 0)
                {
                    oddNumberList.Add(i);
                }
            }
            return Convert.ToUInt64(((ulong)oddNumberList.Count));

        }

        public static string Maskify(string cc) 
        {
            if (cc.Length > 4)
            {
                List<char> chars = new List<char>();
                for (int i = 0; i < cc.Length - 4; i++)
                {
                    chars.Add('#');
                }

                string hashChars = String.Join("", chars);

                return hashChars + cc.Substring(cc.Length - 4, 4);
            }else 
            {
                return cc;
            }
            
        }

        public static bool isEven(int n) 
        {
            if (n%2 == 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public static string CheckNumber(int n) 
        {
            if (n>0)
            {
                return "Positive";
            }else if (n < 0) 
            {
                return "Negative";
            }
            else 
            {
                return "Zero";
            }
        }

        public static int Enough(int cap, int on, int wait)
        {
            return (on +wait > cap) ? (on+wait) -cap : 0;
        }
    }
}
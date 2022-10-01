namespace HackerEarth
{
    //-- Alice got a number written in seven segment format where each segment was creatted used a matchstick.
    //-- Example: If Alice gets a number 123 so basically Alice used 12 matchsticks for this number.

    //-- Alice is wondering what is the numerically largest value that she can generate by using at most the matchsticks that she currently possess.Help Alice out by telling her that number.

    //-- Input Format:

    //--First line contains T(test cases).

    //-- Next T lines contain a Number N.

    //-- Output Format:
    //-- Print the largest possible number numerically that can be generated using at max that many number of matchsticks which was used to generate N.

    //  Digit      MatchSticks
    //  ======     ===========
    //  0           6
    //  1           2
    //  2           5
    //  3           5
    //  4           4
    //  5           5
    //  6           6
    //  7           3
    //  8           7
    //  9           6
    public static class SevenSegmentDisplay
    {
        static readonly Dictionary<char, int> sticks = new Dictionary<char, int>()
        {
            { '0', 6 },
            { '1', 2 },
            { '2', 5 },
            { '3', 5 },
            { '4', 4 },
            { '5', 5 },
            { '6', 6 },
            { '7', 3 },
            { '8', 7 },
            { '9', 6 }
        };
        public static void GenerateNumUsingMatchSticks()
        {
            //-- Get the inputs
            int totalCases = Convert.ToInt32(Console.ReadLine());
            List<string> nums = new List<string>();

            int counter = 1;
            //-- Get the nums based on the total test cases value
            while (counter <= totalCases)
            {
                nums.Add(Console.ReadLine());
                counter++;
            }

            if (nums.Count > 0)
            {
                nums.ForEach(num =>
                {
                    int totalSticks = 0;
                    num.ToList().ForEach(digit => totalSticks += sticks[digit]);
                    //-- Get remaining value by substacting stick value of 7 which is 3
                    int remValues = totalSticks - sticks['7'];

                    //-- Check remaining value can be segregate by stick value of 1 or not
                    if (remValues % 2 == 0)
                    {
                        Console.Write(7);
                        Enumerable.Repeat(1, (totalSticks - sticks['7']) / 2).ToList().ForEach(Console.Write);
                    }
                    //-- Segregate by stick value of 1
                    else
                    {
                        Enumerable.Repeat(1, totalSticks / 2).ToList().ForEach(Console.Write);
                    }
                    Console.Write(Environment.NewLine);
                });
            }
        }
    }
}

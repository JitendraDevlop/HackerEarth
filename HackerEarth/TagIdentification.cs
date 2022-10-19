using System.Text.RegularExpressions;

namespace HackerEarth
{
    //-- Problem
    //-- Arpasland has surrounded by attackers.A truck enters the city. The driver claims the load is food and medicine from Iranians.Ali is one of the soldiers in Arpasland.He doubts about the truck, maybe it's from the siege. He knows that a tag is valid if the sum of every two consecutive digits of it is even and its letter is not a vowel. Determine if the tag of the truck is valid or not.
    //-- We consider the letters "A","E","I","O","U","Y" to be vowels for this problem.
    //-- Input Format
    //-- The first line contains a string of length 9. The format is "DDXDDD-DD", where D stands for a digit (non zero) and X is an uppercase english letter.

    //-- Output Format
    //-- Print "valid" (without quotes) if the tag is valid, print "invalid" otherwise (without quotes)
    internal static class TagIdentification
    {
        public static void IdentifyValidTag()
        {
            //-- Get the tag details
            string tag = Console.ReadLine();

            bool isValidTag = false;
            if (!string.IsNullOrEmpty(tag))
            {
                //-- vowels array
                char[] vowels = new char[6] { 'A', 'E', 'I', 'O', 'U', 'Y' };

                //-- Check tag contains vowel or not
                bool isContainsVowel = vowels.Any(vowel => tag.Contains(vowel));

                //-- If the tag doesn't contain any vowels, then valid if the sum of every two consecutive digits is even or not.
                if (!isContainsVowel)
                {
                    string[] splittedTag = Regex.Split(tag, "[-A-Z]");
                    bool isBreaked = false;

                    foreach (string tagPart in splittedTag)
                    {
                        for (int counter = 0; counter < tagPart.Length; counter++)
                        {
                            int sum = Convert.ToInt32(tagPart[counter].ToString());
                            if (counter + 1 < tagPart.Length)
                            {
                                sum += Convert.ToInt32(tagPart[counter + 1].ToString());

                                if (sum % 2 != 0)
                                {
                                    isBreaked = true;
                                    break;
                                }
                            }
                        }
                        if (isBreaked)
                            break;
                    }

                    isValidTag = !isBreaked;
                }
            }

            if (isValidTag)
                Console.WriteLine("valid");
            else
                Console.WriteLine("invalid");
        }
    }
}
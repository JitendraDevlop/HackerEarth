namespace HackerEarth
{
    //-- You are conducting a contest at your college.This contest consists of two problems and  participants.You know the problem that a candidate will solve during the contest.

    //-- You provide a balloon to a participant after he or she solves a problem. There are only green and purple-colored balloons available in a market. Each problem must have a balloon associated with it as a prize for solving that specific problem. You can distribute balloons to each participant by performing the following operation:

    //-- Use green-colored balloons for the first problem and purple-colored balloons for the second problem
    //-- Use purple-colored balloons for the first problem and green-colored balloons for the second problem
    //-- You are given the cost of each balloon and problems that each participant solve.Your task is to print the minimum price that you have to pay while purchasing balloons.

    //-- Input format

    //First line:  that denotes the number of test cases ()
    //For each test case: 
    //First line: Cost of green and purple-colored balloons
    //Second line:  that denotes the number of participants ()
    //Next  lines: Contain the status of users.For example, if the value of the  integer in the row is , then it depicts that the participant has not solved the  problem.Similarly, if the value of the  integer in the row is , then it depicts that the participant has solved the problem.

    //--Output format
    //-- For each test case, print the minimum cost that you have to pay to purchase balloons.
    public static class CostOfBalloons
    {
        /// <summary>
        /// Method to print the minimum cost that you have to pay to purchase balloons.
        /// </summary>
        public static void GetMinCostOfBalloons()
        {
            //Get the inputs
            int totalTestCases = Convert.ToInt32(Console.ReadLine());
            if (totalTestCases > 0) //-- Process if total test cases count > 0
            {
                for (int count = 0; count < totalTestCases; count++)
                {
                    int[]? costOfBalloons = Console.ReadLine()?.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    if (costOfBalloons?.Length > 0) //-- If array length > 0  then process
                    {
                        //-- Get cost of the total green and purple balloons
                        int costOfGreen = costOfBalloons[0];
                        int costOfPurple = costOfBalloons[1];
                        int totalIthStatus = 0;
                        int totalJthStatus = 0;

                        //-- Get total number of users
                        int totalUserStatus = Convert.ToInt32(Console.ReadLine());
                        for (int statusCount = 0; statusCount < totalUserStatus; statusCount++)
                        {
                            int[] status = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                            totalIthStatus += status[0]; //-- Total i-th row status
                            totalJthStatus += status[1]; //-- Total j-th row status
                        }

                        //-- Get the minimum cost of the balloons
                        Console.WriteLine(Math.Min(costOfGreen * totalIthStatus + costOfPurple * totalJthStatus, costOfPurple * totalIthStatus + costOfGreen * totalJthStatus));
                    }
                }
            }
        }
    }
}

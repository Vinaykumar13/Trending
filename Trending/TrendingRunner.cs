using System;

namespace Trending
{
    public class TrendingRunner
    {
        static void Main(string[] args)
        {
            //int i;
        // TODO : Needs to Remove, once Done
            Console.Out.WriteLine("This will show what's trending according to {0}"
                                    , "http://www.google.com.au/trends/topcharts" );
            Console.Out.WriteLine("Hit any key to see the next result.");
            Console.Out.WriteLine("");

            for (int iteration = 1; iteration < 5; iteration++)
            {
                // HACK
                Console.Out.WriteLine("What's trending top list number {0}: {1}."
                                        , iteration
                                        , WhatsTrending(iteration)
                    );
                // TODO : Needs to Remove, once Done
                Console.ReadKey(true);
            }
        }

        /// <summary>
        /// Will return the top 3 from : http://www.google.com.au/trends/topcharts 
        /// </summary>
        /// <param name="anIndex">Which index to return</param>
        /// <returns>A string holding the interest @ index "anInedx"</returns>
        public static string WhatsTrending(int anIndex)
        {
           // int j;
            string answer;
            switch (anIndex)
            {
                case 1:
                    // TODO : Needs to Remove, once Done
                    answer= "Paul Walker";
                    break;
                case 2:
                    // HACK
                    answer= "Cory Monteith";
                    break;
                case 3:
                    answer= "RoyalBaby";
                    break;
                default:
                    // TODO : Needs to Remove, once Done
                    answer = "Choose an index between 1 or 3, or go and search it yourself.";
                    break;
            }
            return answer;
        }
    }
}

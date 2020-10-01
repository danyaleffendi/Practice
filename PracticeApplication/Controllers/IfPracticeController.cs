using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Web.Http;

namespace PracticeApplication.Controllers
{

    public class IfPracticeController : ApiController
    {
        /// <summary>
        /// Jenny has a Coin collection, and would like to exchange her coins for a new toy,   
        /// which costs $10.50CAD.She organizes each coin by their type(Nickles worth $0.05,
        /// Dimes worth $0.10, Quarters worth $0.25, Loonies worth $1.00, Twoonies worth $2.00)
        /// </summary>
        /// <param name="nickles"></param>
        /// <param name="dimes"></param>
        /// <param name="quarters"></param>
        /// <param name="loonies"></param>
        /// <param name="twoonies"></param>
        /// <returns> true if savings are more than cost of toy i.e. $10.5 else false</returns>
        /// <example>GET api/IfPractice/CoinComputer/0/0/0/15/0		-> TRUE</example>
        [HttpGet]
        [Route("api/IfPractice/CoinComputer/{nickles}/{dimes}/{Quarters}/{Loonies}/{Twoonies}")]

        public bool CoinComputer(int nickles, int dimes, int quarters, int loonies, int twoonies)
        {
            int cost = 1050;
            int savings = nickles * 1 + dimes * 10 + quarters * 25 + loonies * 100 + twoonies * 200;
            if (savings >= cost) return true;
            else return false;
        }

        /// <summary>
        /// A cartesian plane has perpendicular axes representing X and Y values. 
        /// These axes intersect at a 90 degree angle, creating four "Quadrants".
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns> The quadrant number. Output 0 if the point does not lie in a quadrant.</returns>
        /// <example>GET api/IfPractice/PointQuadrant/1/1	-> 	1</example>
        [HttpGet]
        [Route("api/IfPractice/PointQuadrant/{x}/{y}")]

        public int PointQuadrant(int x, int y)
        {
            if (x > 0 && y > 0) return 1;
            else if (x > 0 && y < 0) return 2;
            else if (x < 0 && y < 0) return 3;
            else if (x < 0 && y > 0) return 4;
            else return 0;

        }
        /// <summary>
        /// A line on a cartesian plane is defined as having two points.
        /// Four integers representing a line which joins(x1, y1) and(x2, y2).
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns>The number of quadrants the line passes through.</returns>
        /// <example>
        /// GET api/IfPractice/LineQuadrant/1/1/-1/-1		->	2
        /// GET api/IfPractice/LineQuadrant/1/2/3/4		    ->	1
        /// GET api/IfPractice/LineQuadrant/10/0/-10/0		->	0
        /// GET api/IfPractice/LineQuadrant/-6/-10/2/20		->	3
        /// </example>
        [HttpGet]
        [Route("api/IfPractice/LineQuadrant/{x1}/{y1}/{x2}/{y2}")]

        public int LineQuadrant(int x1, int y1, int x2, int y2)
        {
            int m = (y2 - y1) / (x2 - x1);
            int c = y1 - x1 * m;

            if (m != 0 && c != 0)
                if (x1 > 0 && y1 > 0 && x2 > 0 && y2 > 0) return 1;                
                else if (x1 < 0 && y1 < 0 && x2 < 0 && y2 < 0) return 1;                
                else return 3;

            else 
                if (x1 > 0 && y1 > 0 && x2 > 0 && y2 > 0) return 1;
                else if (x1 > 0 && y1 > 0 && x2 < 0 && y2 < 0) return 2;
                else if (x1 < 0 && y1 < 0 && x2 < 0 && y2 < 0) return 1;
                else if (x1 < 0 && y1 < 0 && x2 > 0 && y2 > 0) return 2;
                else if (x1 < 0 && y1 > 0 && x2 > 0 && y2 > 0) return 2;
                else if (x1 > 0 && y1 < 0 && x2 > 0 && y2 > 0) return 2;
                else return 0;

        }

    }
}


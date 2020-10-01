using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PracticeApplication.Controllers
{
    public class practiceController : ApiController
    {
        // Question 1 - Returns 10 more than the integer input {id}.
        public int GET(int id)
        {
            int cost = (100 / 15);
            return cost;
        }
        

        /// <summary>
        /// Values of 2 sides are given of a right angle. Find out the hypotenuse
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <returns>value of Hypotenuse i.e. side c of the triangle</returns>
        /// <example>Get api/practice/Pythagorean/9/12 -> 15</example>
        [HttpGet]
        [Route("api/practice/Pythagorean/{sindeA}/{sideB}")]

        public double Pythagorean(double sideA, double sideB)
        {
            double hypotenuse = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            return hypotenuse;
        }
    }
}


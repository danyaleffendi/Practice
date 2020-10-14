using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PracticeApplication.Controllers
{
    public class LoopPracticeController : ApiController
    {
        
        [HttpGet]
        [Route("api/LoopPractice/CounterW")]
        //Testing WHile Loop
        public string CounterW()
        {
            string message = "";
            int i = -10;
            while (i <= 10)
            {
                message = message + i.ToString();
                i = i + 1;
            }

            return message;
        }

        [HttpGet]
        [Route("api/LoopPractice/CounterF")]
        //Testing For Loop
        public string CounterF()
        {
            string message = "";
            for (int i=1; i<= 20; i=i+2)
            {
                message = message + i.ToString();
                
            }

            return message;
        }
        //Testing While Loop2
        [Route("api/LoopPractice/Counter2W")]
        [HttpGet]
        public string Counter2W()
        {
            string message = "";
            int i = -20;
            while (i <= -10)
            {
                message = message + i.ToString() + ",";
                i = 2 + i;
            }

            return message;
        }
        [HttpGet]
        [Route("api/LoopPractice/Counter2F")]
        //Testing For Loop2
        public string Counter2F()
        {
            string message = "";
            for (int i = -1; i >= -10; i=i-1)
            {
                message = message + i.ToString() + ",";

            }

            return message;
        }

        [HttpGet]
        [Route("api/LoopPractice/arrayw")]
        //Testing For Arrays
        public string ArrayW()
        {
            string[] colors = {"green", "blue", "red", "white", "black"};         
            string message = "";
            int i = 0;
            while (i < colors.Length)
            {
                string separater = ", ";
                if (i == (colors.Length-1))
                {
                    separater = ".";
                }
                message = message + colors[i] + separater;
                i=1+i;
            }

            return message;
        }

        //Problem 1 - api/LoopPractice/Counter/{start}/{limit}/{step}
        [HttpGet]
        [Route("api/LoopPractice/Counter/{start}/{limit}/{step}")]
        public string Counter(int start, int limit, int step)
        {
            string message = "";
            //int i = start;
            if (step < 0)
            {
                for (int i = start; i >= limit; i = i + step)
                {
                    string separater = ", ";
                    if (i == (limit + start + step))
                    {
                        separater = "";
                    }                   
                    message = message + i.ToString() + separater;
                }
            }
           else
            {
                for (int i = start; i <= limit; i = i + step)
                {
                    string separater = ", ";
                    if (i == (limit - start - step))
                    {
                        separater = "";
                    }
                    message = message + i.ToString() + separater;
                }
            }
            
            /* while (i <= limit)
             {
                 if (limit > start)
                 {
                     message = message + i.ToString() + ",";
                     i = i + step;
                 }
                 else
                 {
                     message = message + i.ToString() + ",";
                     i = i - step;
                 }                
             }*/

            return "["+ message + "]";
        }
    }
}

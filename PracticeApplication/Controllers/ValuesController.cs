using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PracticeApplication.Controllers
{
	public class ValuesController : ApiController
	{
		// GET api/values
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2", "value3" };
		}

		// GET api/values/abc
		//public string Get(int id)
		//{
		//	return "Hello";
		//}

		// GET api/values/int
		//putput will be next 3 numbers of the input
		public IEnumerable<int> Get(int id)
				{
			 return new int[] { id+1, id+2, id+3 };
		}

		

		// POST api/values
		public void Post([FromBody] string value)
		{
		}

		// PUT api/values/5
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/values/5
		public void Delete(int id)
		{
		}
	}
}

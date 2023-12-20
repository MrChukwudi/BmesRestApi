using System;
using System.Net;

namespace BmesRestApi.Messages.Response
{
	public class ResponseBase
	{
        //Because we want to register/add StatusCodes dynamically as operations progress:
        public HttpStatusCode StatusCode { get; set; }

        //Because we want to register/add Status Messages dynamically as operations progress:
        public List<String> Messages { get; set; }


		public ResponseBase()
		{
			Messages = new List<String>();
		}
	}
}


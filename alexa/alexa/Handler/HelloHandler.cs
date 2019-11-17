using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alexa.NET.Request;

namespace alexa.Handler
{
    public class HelloHandler
    {
        public string GetResponse(SkillRequest request)
        {
            return "Hi from just answer";
        }
    }
}

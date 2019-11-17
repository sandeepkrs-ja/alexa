using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alexa.NET.Request;

namespace alexa.Handler
{
    public class FamilyLawHandler
    {
        public string GetResponse(SkillRequest request)
        {
            return "We have taken a note of your request. In the meanwhile can you please link your account?";
        }
    }
}

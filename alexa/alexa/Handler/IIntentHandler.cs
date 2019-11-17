using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alexa.NET.Request;
using Alexa.NET.Response;

namespace alexa.Handler
{
    public interface IIntentHandler
    {
        /// <summary>
        /// The Process
        /// </summary>
        /// <param name="request">The request<see cref="SkillRequest"/></param>
        /// <returns>The <see cref="SkillResponse"/></returns>
        SkillResponse Process(SkillRequest request);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using alexa.Handler;
using Alexa.NET.Request;
using Alexa.NET.Response;
using Microsoft.AspNetCore.Mvc;

namespace alexa.Controllers
{

    /// <summary>
    /// Defines the <see cref="AlexaController" />
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AlexaController : ControllerBase
    {
        /// <summary>
        /// Defines the _intentHandler
        /// </summary>
        private readonly IIntentHandler _intentHandler;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlexaController"/> class.
        /// </summary>
        /// <param name="intentHandler">The intentHandler<see cref="IIntentHandler"/></param>
        public AlexaController(IIntentHandler intentHandler)
        {
            _intentHandler = intentHandler;
        }

        /// <summary>
        /// The Post
        /// </summary>
        /// <param name="request">The request<see cref="SkillRequest"/></param>
        /// <returns>The <see cref="ActionResult{SkillResponse}"/></returns>
        [HttpPost("question")]
        public ActionResult<SkillResponse> Post([FromBody]SkillRequest request)
        {
            var response = _intentHandler.Process(request);
            return Ok(response);
        }
        public ActionResult<SkillResponse> Get()
        {

            return Ok(new { a = 1 });
        }
    }
}
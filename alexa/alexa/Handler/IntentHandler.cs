using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Alexa.NET.Request;
using Alexa.NET.Request.Type;
using Alexa.NET.Response;
using Newtonsoft.Json.Linq;

namespace alexa.Handler
{

    /// <summary>
    /// Defines the <see cref="IntentHandler" />
    /// </summary>
    public class IntentHandler : IIntentHandler
    {
        /// <summary>
        /// The Process
        /// </summary>
        /// <param name="request">The request<see cref="SkillRequest"/></param>
        /// <returns>The <see cref="SkillResponse"/></returns>
        public SkillResponse Process(SkillRequest request)
        {
            var text = GetResponse(request);
            var simpleCard = new SimpleCard()
            {
                Title = "This is a simple card",
                Content = "This is a simple content"
            };
            var linkAccounCard = new LinkAccountCard();
            var response = new SkillResponse
            {
                Version = "1.0.0",
                Response = new ResponseBody
                {
                    OutputSpeech = new PlainTextOutputSpeech
                    {
                        Text = GetResponse(request)
                    },
                    Card = linkAccounCard
                }
            };

            return response;
        }

        /// <summary>
        /// The GetResponse
        /// </summary>
        /// <param name="request">The request<see cref="SkillRequest"/></param>
        /// <returns>The <see cref="string"/></returns>
        private string GetResponse(SkillRequest request)
        {
            var response = string.Empty;
            var intentName = !(request.Request is IntentRequest intentRequest) ? "DefaultIntent" : intentRequest.Intent.Name;
            switch (intentName)
            {
                case "HelloIntent":
                {
                    response = new HelloHandler().GetResponse(request);
                }
                    break;
                case "FamilyLaw":
                {
                    response = new FamilyLawHandler().GetResponse(request);
                }
                    break;
                case "ConsumerLaw":
                {
                    response = new ConsumerLawHandler().GetResponse(request);
                }
                    break;
                default:
                {
                    
                }
                    break;
            }
            //var baseDir = ".\\";
            //var parser = JObject.Parse(File.ReadAllText(Path.Combine(baseDir, "Intents", "intents.json")));
            //var className = parser[intentName];
            //var response = (string)parser[intentName];
            return response;
        }
    }
}

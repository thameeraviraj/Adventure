using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Adventure.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Adventure.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AdventuresController : ControllerBase
    {
        /// <summary>
        /// Produce the complete decision tree
        /// </summary>
        /// <returns>A questioner</returns>
        /// <response code="201">Returns a successfully generated decision tree</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [EnableCors]
        public ActionResult<DecisionNode> GetDecisionTree()
        {
            return new DecisionNode()
            {
                Value = "Do I want a Doughnut?",
                IsQuestion = true,
                LinkedNodes = new List<DecisionNode>()
                {
                    new DecisionNode(){Value = "Yes", IsQuestion = false, IsSelected = false, LinkedNodes=new List<DecisionNode>(){
                        new DecisionNode(){Value = "Do I deserve it?", IsQuestion = true, LinkedNodes = new List<DecisionNode>(){
                            new DecisionNode(){Value = "Yes", IsQuestion = false, IsSelected=false, LinkedNodes= new List<DecisionNode>(){
                                new DecisionNode(){Value = "Are you sure?", IsQuestion = true, LinkedNodes = new List<DecisionNode>(){
                                    new DecisionNode(){Value = "Yes", IsQuestion = false, IsSelected = false, LinkedNodes = new List<DecisionNode>(){
                                        new DecisionNode(){Value = "Get It", IsQuestion = true}
                                    } },
                                    new DecisionNode(){Value = "No", IsQuestion = false, IsSelected = false, LinkedNodes = new List<DecisionNode>(){
                                        new DecisionNode(){Value = "Do jumping jacks first", IsQuestion = true}
                                    } }
                                } }
                            } },
                            new DecisionNode(){Value = "No", IsQuestion = false, IsSelected=false, LinkedNodes = new List<DecisionNode>(){
                                new DecisionNode(){Value = "Is it a good Doughnut?", IsQuestion = true, LinkedNodes = new List<DecisionNode>(){
                                    new DecisionNode(){Value = "Yes", IsQuestion = false, IsSelected = false, LinkedNodes = new List<DecisionNode>(){
                                        new DecisionNode(){Value = "What are you waiting for? Grab it now.", IsQuestion = true}
                                    } },
                                    new DecisionNode(){Value = "No", IsQuestion = false, IsSelected = false, LinkedNodes = new List<DecisionNode>(){
                                        new DecisionNode(){Value = "Wait 'til you find a sinful, unforgettable doughnut", IsQuestion = true}
                                    } }
                                } }
                            } }
                        } }
                    } },
                    new DecisionNode(){Value = "No", IsQuestion = false, IsSelected = false, LinkedNodes = new List<DecisionNode>(){
                        new DecisionNode(){Value = "May be you want an Apple?", IsQuestion = true, LinkedNodes = new List<DecisionNode>(){
                            new DecisionNode(){Value = "Yes", IsQuestion = false, IsSelected = false, LinkedNodes=new List<DecisionNode>(){
                                new DecisionNode(){Value="Apples are good for your health.", IsQuestion=true}
                            } },
                            new DecisionNode(){Value = "No", IsQuestion = false, IsSelected = false, LinkedNodes=new List<DecisionNode>(){
                                new DecisionNode(){Value="It's pretty hard to guess what you want Hooooman.", IsQuestion=true}
                            } }
                        }}
                    }}
                }
            };
        }
    }
}
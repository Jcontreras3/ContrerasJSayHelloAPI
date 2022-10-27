//Jovann Contreras
//Date 10/25/2022
//Peer reviewed by: Jessie Lamzon
//Code is running and no errors were present.  Code runs and does required for assignment.  Good job!

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ContrerasJSayHelloAPI.Controllers
{
    [Route("[controller]")]
    public class SayHelloController : Controller
    {
      [HttpGet]
      [Route("SayHello/{name}")]

      public string SayHelloChallenge(string name)
      {
        return $"Hello {name} how are you";
      }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    [Controller]
    [Route("text")]
    public class TextController : Controller
    {
        private readonly TextHandler _textHandler;

        public TextController(TextHandler textHandler)
        {
            _textHandler = textHandler;
        }

        [HttpGet("calculate")]
        public string Calculate(string name1, string name2)
        {
            var f = float.Parse(name1);
            var f1 = float.Parse(name2);
            return _textHandler.Calculate(f, f1);
        }
    }
}

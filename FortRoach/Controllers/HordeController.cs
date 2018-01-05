using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FortRoach.Controllers
{
    public class HordeController : Controller
    {
        private static Dictionary<string, string> _Dudes = new Dictionary<string, string>();

        [HttpPost("horde/{dude}")]
        public string Post(string dude, [FromBody]string sound)
        {
            _Dudes[dude] = sound;

            return String.Format("{0} added to the horde!", dude);
        }

        [HttpGet("horde/{dude}")]
        public string Get(string dude)
        {
            if (!_Dudes.ContainsKey(dude))
            {
                return "Dude not found.";
            }

            return _Dudes[dude];
        }

        [HttpPatch("horde/{dude}")]
        public string Patch(string dude, [FromBody]string sound)
        {
            if (!_Dudes.ContainsKey(dude))
            {
                return "Dude not found.";
            }

            _Dudes[dude] = sound;

            return "Dude updated.";
        }

        [HttpDelete("horde/{dude}")]
        public string Delete(string dude)
        {
            if (!_Dudes.ContainsKey(dude))
            {
                return "Dude not found.";
            }

            _Dudes.Remove(dude);

            return "Dude deleted.";
        }
    }
}

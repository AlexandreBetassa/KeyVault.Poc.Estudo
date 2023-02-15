using KeyVault.Poc.Models;
using Microsoft.AspNetCore.Mvc;

namespace KeyVault.Poc.Controllers
{
    [Route("[controller]/v1")]
    [ApiController]
    public class KeyVaultController : ControllerBase
    {
        private readonly Variables _variables;
        public KeyVaultController(Variables variables)
        {
            _variables = variables;
        }

        [HttpGet("GetValueOne")]
        public IActionResult GetValue1()
        {
            return Ok(_variables.ValueOne);
        }

        [HttpGet("GetValueTwo")]
        public IActionResult GetValue2()
        {
            return Ok(_variables.ValueTwo);
        }

        [HttpGet("GetValueThree")]
        public IActionResult GetValue3()
        {
            return Ok(_variables.ValueThree);
        }

    }
}

﻿using LoggerService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanyEmployees.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ILoggerManager _logger; 
        public ValuesController(ILoggerManager logger) { _logger = logger; }

        [HttpGet] public IEnumerable<string> Get() 
        { 
            _logger.LogInfo("Here is info message from our values controller."); 
            _logger.LogDebug("Here is debug message from our values controller."); 
            _logger.LogWarn("Here is warn message from our values controller."); 
            _logger.LogError("Here is an error message from our values controller."); 
            return new string[] { "value1", "value2" }; }
    }
}

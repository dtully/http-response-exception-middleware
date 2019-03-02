﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using http_response_exception_middleware.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace http_response_exception_middleware.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            throw new BadRequestException("Oh dear...");
            
            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            throw new NotFoundException("Huh?");

            //return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromForm] string value)
        {
            throw new Exception("Not an IHttpException");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API_template.Services;

namespace API_template.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReverseItAlphaNumeric : ControllerBase
{
    private readonly ReverseItAlphaNumericService _service;

    public ReverseItAlphaNumeric(ReverseItAlphaNumericService service)
    {
        _service = service;
    }

    [HttpGet]
    public string Reverse(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return "Input is required.";
        }

        return _service.Reverse(input);
    }
}

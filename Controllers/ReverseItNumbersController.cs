using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API_template.Services;

namespace API_template.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReverseItNumbers : ControllerBase
{
    private readonly ReverseItNumbersService _service;

    public ReverseItNumbers(ReverseItNumbersService service)
    {
        _service = service;
    }

    [HttpGet]
    public string Reverse(string numbers)
    {
        if (string.IsNullOrEmpty(numbers) || !numbers.All(char.IsDigit))
        {
            return "Please enter numbers only.";
        }

        return _service.ReverseNumbers(numbers);
    }
}

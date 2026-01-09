using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API_template.Services;

namespace API_template.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OddOrEven : ControllerBase
{
    private readonly OddOrEvenService _service;

    public OddOrEven(OddOrEvenService service)
    {
        _service = service;
    }

    [HttpGet]
    public string CheckNumber(int number)
    {
        return _service.CheckOddOrEven(number);
    }
}

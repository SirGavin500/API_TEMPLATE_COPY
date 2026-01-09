using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API_template.Services;

namespace API_template.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MadLib : ControllerBase
{
    private readonly MadLibService _service;

    public MadLib(MadLibService service)
    {
        _service = service;
    }

    [HttpGet]
    public string CreateStory(string name, string place, string adjective, string noun)
    {
        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(place) ||
            string.IsNullOrEmpty(adjective) || string.IsNullOrEmpty(noun))
        {
            return "All inputs are required.";
        }

        return _service.CreateStory(name, place, adjective, noun);
    }
}

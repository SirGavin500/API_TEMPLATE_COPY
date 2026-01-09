using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_template.Services;

public class MadLibService
{
    public string CreateStory(string name, string place, string adjective, string noun)
    {
        return $"{name} went to {place} and saw a very {adjective} {noun}.";
    }
}

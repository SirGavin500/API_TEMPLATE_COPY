using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_template.Services;

public class ReverseItAlphaNumericService
{
    public string Reverse(string input)
    {
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);

        string reversed = new string(chars);
        return $"You entered {input}, reversed is {reversed}.";
    }
}

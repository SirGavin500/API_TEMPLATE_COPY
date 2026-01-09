using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_template.Services;

public class ReverseItNumbersService
{
    public string ReverseNumbers(string numbers)
    {
        char[] chars = numbers.ToCharArray();
        Array.Reverse(chars);

        string reversed = new string(chars);
        return $"You entered {numbers}, reversed is {reversed}.";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace APIMiniChallenge4.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class GreaterorLessThanController : ControllerBase
    {
        [HttpGet]
    [Route("GreaterLess/{num1}/{num2}")]

    public string GreaterThanLessThan(string num1, string num2)
    {
        string text = "";
        bool Num1;
        bool Num2;
        int wholeNum1 = 0;
        int wholeNum2 = 0;
        Num1 = Int32.TryParse(num1, out wholeNum1);
        Num2 = Int32.TryParse(num2, out wholeNum2);
        if (Num1 != true || Num2 != true)
        {
            text = "You didn't enter two whole numbers please try again";
        }
        else if (Num1 == true && Num2 == true)
        {
            if (wholeNum1 == wholeNum2)
            {
                text = $"{wholeNum1} is equal to {wholeNum2}";
            }
            else if (wholeNum1 > wholeNum2)
            {
                text = $"{wholeNum1} is Greater Than {wholeNum2}";
            }
            else if (wholeNum1 < wholeNum2)
            {
                text = $"{wholeNum1} is Less Than {wholeNum2}";
            }
        }
        return text;
    }
    }

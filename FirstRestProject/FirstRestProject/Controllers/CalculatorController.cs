using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstRestProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        //Calcular soma de dois valores
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            //1 - Verificar se os números são numéricos
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid input");
        }

        //Calcular a subtração de dois valores
        [HttpGet("subtract/{firstNumber}/{secondNumber}")]
        public IActionResult Subtract(string firstNumber, string secondNumber)
        {
            //1 - Verificar se os números são numéricos
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid input");
        }

        //Calcular a multiplicação de dois valores
        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplication(string firstNumber, string secondNumber)
        {
            //1 - Verificar se os números são numéricos
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid input");
        }

        //Calcular a subdivisãotração de dois valores
        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult Division(string firstNumber, string secondNumber)
        {
            //1 - Verificar se os números são numéricos
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid input");
        }

        //Calcular a média de dois valores
        [HttpGet("average/{firstNumber}/{secondNumber}")]
        public IActionResult Average(string firstNumber, string secondNumber)
        {
            //1 - Verificar se os números são numéricos
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var number = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                number /= 2;
                return Ok(number.ToString());
            }

            return BadRequest("Invalid input");
        }

        //Calcular a raiz quadrada de um valor
        [HttpGet("squareroot/{firstNumber}")]
        public IActionResult Square(string firstNumber)
        {
            //1 - Verificar se os números são numéricos
            if (IsNumeric(firstNumber))
            {
                var number = Math.Sqrt(ConvertToDouble(firstNumber));
                return Ok(number.ToString());
            }

            return BadRequest("Invalid input");
        }

        

        /*Funções auxiliares*/

        //Verifica se uma variável é numérica
        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(
                strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out number);
            return isNumber;
        }

        //Converte para decimal
        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;
            if (decimal.TryParse(strNumber, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }
        //Converte para double
        private double ConvertToDouble(string strNumber)
        {
            double doubleNumber;
            if(double.TryParse(strNumber, out doubleNumber))
            {
                return doubleNumber;
            }
            return 0;
        }

    }
}

using System;

namespace ConversionCalculator.Models
{
    public class ConverterViewModel
    {
        public decimal ValueToConvert {get; set; }
        public int ConversionType {get; set; }
        public decimal ConvertedValue {get; set; }
        
    }
}
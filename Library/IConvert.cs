using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace Library
{
    public class IConvert
    {
        public static string ToDay(int value)
        {
            var result = string.Empty;

            switch (value + 2)
            {
                case 2:
                    result = "Thứ hai";
                    break;
                case 3:
                    result = "Thứ ba";
                    break;
                case 4:
                    result = "Thứ tư";
                    break;
                case 5:
                    result = "Thứ năm";
                    break;
                case 6:
                    result = "Thứ sáu";
                    break;
                case 7:
                    result = "Thứ bảy";
                    break;
                case 8:
                    result = "Chủ nhật";
                    break;
            }
            return result;
        }

        #region ConvertNumbersToRoman
        private enum RomanNumber
        {
            I = 1,
            IV = 4,
            V = 5,
            IX = 9,
            X = 10,
            XL = 40,
            L = 50,
            XC = 90,
            C = 100,
            CD = 400,
            D = 500,
            CM = 900,
            M = 1000
        }

        public static string ConvertNumbersToRoman(int number)
        {
            var romanRepresentation = string.Empty;

            var values = Enum.GetValues(typeof(RomanNumber));

            for (var i = values.Length - 1; i >= 0; --i)
            {
                var value = (int)values.GetValue(i);

                while (number >= value)
                {
                    romanRepresentation += Enum.GetName(typeof(RomanNumber), value);

                    number -= value;
                }
            }
            return romanRepresentation;
        }
        #endregion
    }
}

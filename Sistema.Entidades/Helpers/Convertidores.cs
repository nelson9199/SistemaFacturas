using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Entidades.Helpers
{
    public static class Convertidores
    {
        public static BoolToStringConverter ObtenerBoolToStringConverter(string falseValue, string trueValue)
        {
            var converter = new BoolToStringConverter(falseValue, trueValue);

            return converter;
        }
    }
}

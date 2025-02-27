using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BibliotecaTopicosV1
{
    public class ValidacionInPut
    {
        public bool SoloNumeros(string texto)
        {
            return Regex.IsMatch(texto, @"^\d+$");
        }
        public bool SoloLetras (string texto)
        {
            return Regex.IsMatch(texto, @"^[a-zA-Z]+$");
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BibliotecaTopicosV1
{
    public class ValidarRFC
    {
        private static readonly Regex PatronRFC = new Regex(@"^[A-Z&Ñ]{4}\d{6}[A-Z0-9]{2,3}$");

        public bool EsRFCValido(string rfc)
        {
            if (string.IsNullOrWhiteSpace(rfc)) return false;
            rfc = CorregirRFC(rfc);
            return PatronRFC.IsMatch(rfc);
        }

        public string CorregirRFC(string rfc)
        {
            if (string.IsNullOrWhiteSpace(rfc)) return string.Empty;
            return rfc.Trim().ToUpper();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SintegraBr.Common
{
    public class RegistroBaseSintegra
    {
        [SintegraCampos(1, "TIPO", "N", 2, 0, true)]
        public string Tipo { get; set; }

        public static object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }
    }
}

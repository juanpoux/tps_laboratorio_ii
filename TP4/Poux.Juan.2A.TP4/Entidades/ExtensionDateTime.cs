using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ExtensionDateTime
    {
        /// <summary>
        /// Valida si la fecha es anterior al dia de hoy
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool EsAnteriorAHoy(this DateTime a)
        {
            return a < DateTime.Today;
        }
    }
}

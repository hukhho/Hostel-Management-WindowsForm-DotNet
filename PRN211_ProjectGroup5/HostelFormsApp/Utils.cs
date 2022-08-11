using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HostelFormsApp
{
    public static class Utils
    {
        public static int? ToNullableInt(this string s)
        {
            int i;
            if (int.TryParse(s, out i)) return i;
            return null;
        }
        public static double? ToNullableDouble(this string s)
        {
            double i;
            if (double.TryParse(s, out i)) return i;
            return null;
        }
        public static Boolean FindPhoneNumberVietNamFromText(string inputText)
        {
            var exp = new Regex("/(84|0[3|5|7|8|9])+([0-9]{8})\b/g");

            var text = inputText.Replace(".", "").Replace(" ", "");

            var matchList = exp.Matches(text).Cast<Match>()
              .Select(m => m.Groups[0].Value)
              .ToArray();
            if (matchList.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Password
{
    public class Pass
    { 
        public int CheckPassword(string password)
        {
            var score = 0;
            if (Regex.IsMatch(password, @"\d") == true) score++;
            if (Regex.IsMatch(password, @"[a-z]") == true) score++;
            if (Regex.IsMatch(password, @"[A-Z]") == true) score++;
            if (Regex.IsMatch(password, @"[!@#\$%\^&\*\(\)_\+\-=\[\]\{\};:'""\\|,.<>\/?]") == true) score++;
            if ((password.Length > 10) == true) score++;
            return score;
        }
  
    }
}

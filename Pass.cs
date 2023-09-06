using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Module_test
{
    public class Pass
    {
        public static int Password(string word)
        {
            
            int score = 0;
            
            foreach(char c in word)
            {
                if (char.IsDigit(c))
                {
                    score++;
                    break;
                }
               
            }
            foreach (char c in word)
            {
                if (char.IsLower(c))        
                {
                    score++;
                    break;
                   
                }
                
            }
            foreach (char c in word)
            {
                if (char.IsUpper(c))        
                {
                    score++;
                    break;
                }
                
            }
            if (Regex.IsMatch(word, @"[-!@#№$|[{\]};%^:?&*()_+=./<>,}`~]"))
            { 
                score++;
            }
            if (word.Length > 7) 
            {
                score++;    
            }
                return score;
        }
    }
}

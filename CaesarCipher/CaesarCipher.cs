using System;
using System.Linq;
using System.Text;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            string cipher = string.Empty;
            foreach(char ch in text)
            {
               cipher+=CipherHelper(ch,shiftKey);
            }
            return cipher;
        }
        
        public static char CipherHelper(char ch, int shiftKey) {  
            if (!char.IsLetter(ch)) {  
                return ch;  
            }  
  
            char d = char.IsUpper(ch) ? 'A' : 'a';  
            return (char)((((ch + shiftKey) - d) % 26) + d);  
        }  

    }
}

using System;
using System.Linq;
using System.Text;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {   //initialize empty string
            string cipher = string.Empty;
            //loop through each char
            foreach(char ch in text)
            {  //find the cipher char
               cipher+=CipherHelper(ch,shiftKey);
            }
            return cipher;
        }
        
        public static char CipherHelper(char ch, int shiftKey) 
        {   
            char d = char.IsUpper(ch) ? 'A' : 'a'; 
            // simply returns the char after adding the shiftKey
            //if it exceeds Z or z then we need %26
            return (char)((((ch + shiftKey) - d) % 26) + d);  
        }  

    }
}

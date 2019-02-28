using System;

namespace Pangram
{
    public class CheckPangram {
        public bool checkDic(string pangram) {
            char [] DicEng = new char []{
                'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
            };
            int sum = 0;
            for (int i = 0; i < DicEng.Length; i++)
            {
                if (pangram.ToUpper().IndexOf(DicEng[i]) != -1) { 
                    ++sum;
                }
                Console.WriteLine(DicEng[i]);
            }
            Console.WriteLine(sum);
            if (sum == 26) {
                return true;
            }
            return false;
        }
    }
}
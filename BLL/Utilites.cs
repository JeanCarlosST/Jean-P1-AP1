using System;

namespace Jean_P1_AP1.BLL
{
    public class Utilities
    {
        public static int ToInt(string num)
        {
            int n = 0;
            try{
                n = Convert.ToInt32(num);
            } catch {
            }

            return n;
        }
    }
}
using System;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        { 
        int [] numbers = {1,2,3,4,5};
        new ArrayHelder.Pow();
        
        }
    }
    static class ArrayHelder
    {
        static string Pow( ref string [] stringArr )
        {
            return stringArr[stringArr.Length -1];
        }
        static int Push( ref int [] intArr )
        {
            return intArr[intArr.Length+1];
    
        }
        static  double Shift( ref double [] doubleArr)
        {

        }
        static float UnShift( ref float [] floatArr )
        {

        }
    }
}

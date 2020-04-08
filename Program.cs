using System;
using System.Collections.Generic;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        { 
            
        }
    }
    static class ArrayHelder
    {
        
        static string Pow( ref string [] array )
        {
            string arr = array[array.Length-1];
            Array.Resize(ref array,array.Length-1);
            return arr;
        }
        static int Pow( ref int [] array )
        {
            int arr = array[array.Length-1];
            Array.Resize(ref array,array.Length-1);
            return arr;
        }
        static double Pow( ref double [] array )
        {
            double arr = array[array.Length-1];
            Array.Resize(ref array,array.Length-1);
            return arr;
        }
        static decimal Pow( ref decimal [] array )
        {
            decimal arr = array[array.Length-1];
            Array.Resize(ref array,array.Length-1);
            return arr;
        }
        static float Pow( ref float [] array )
        {
            float arr = array[array.Length-1];
            Array.Resize(ref array,array.Length-1);
            return arr;
        }
        public static int Push (ref string[] array,string delited)
        {
            Array.Resize(ref array,array.Length+1);
            array[array.Length-1] = delited;
            return array.Length;
        }
        public static int Push (ref int[] array,int delited)
        {
            Array.Resize(ref array,array.Length+1);
            array[array.Length-1] = delited;
            return array.Length;
        }
        public static int Push (ref double[] array,double delited)
        {
            Array.Resize(ref array,array.Length+1);
            array[array.Length-1] = delited;
            return array.Length;
        }
        public static int Push (ref decimal[] array,decimal delited)
        {
            Array.Resize(ref array,array.Length+1);
            array[array.Length-1] = delited;
            return array.Length;
        }
        public static int Push (ref float[] array,float delited)
        {
            Array.Resize(ref array,array.Length+1);
            array[array.Length-1] = delited;
            return array.Length;
        }
        public static string Shift(ref string[] array)
        {
            string[] newArray = new string[array.Length - 1];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array[i + 1];
            }
            string firstElement = array[0];
            array = newArray;
            return firstElement;
        }
        public static int Shift(ref int[] array)
        {
            int[] newArray = new int[array.Length - 1];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array[i + 1];
            }
            int firstElement = array[0];
            array = newArray;
            return firstElement;
        }
        public static double Shift(ref double[] array)
        {
            double[] newArray = new double[array.Length - 1];
            for (int x = 0; x < newArray.Length; x++)
            {
                newArray[x] = array[x + 1];
            }
            double firstElement = array[0];
            array = newArray;
            return firstElement;
        }
        public static decimal Shift(ref decimal[] array)
        {
            decimal[] newarray = new decimal[array.Length - 1];
            for (int x = 0; x < newarray.Length; x++)
            {
                newarray[x] = array[x + 1];
            }
            decimal firstElement = array[0];
            array = newarray;
            return firstElement;
        }
        public static float Shift(ref float[] array)
        {
            float[] newarray = new float[array.Length - 1];
            for (int x = 0; x < newarray.Length; x++)
            {
                newarray[x] = array[x + 1];
            }
            float firstElement = array[0];
            array = newarray;
            return firstElement;
        }
        public static int UnShift (ref string [] array, string newElement)
        {
            Array.Reverse(array);
            Array.Resize(ref array, array.Length+1);
            array[array.Length-1]= newElement;
            Array.Reverse(array);
            return array.Length;
        }
        public static int UnShift (ref int [] array, int newElement)
        {
            Array.Reverse(array);
            Array.Resize(ref array, array.Length+1);
            array[array.Length-1]= newElement;
            Array.Reverse(array);
            return array.Length;
        }
        public static int UnShift (ref double [] array, double newElement)
        {
            Array.Reverse(array);
            Array.Resize(ref array, array.Length+1);
            array[array.Length-1]= newElement;
            Array.Reverse(array);
            return array.Length;
        }
        public static int UnShift (ref decimal [] array, decimal newElement)
        {
            Array.Reverse(array);
            Array.Resize(ref array, array.Length+1);
            array[array.Length-1]= newElement;
            Array.Reverse(array);
            return array.Length;
        }
         public static int UnShift (ref float[] array,float newElement)
        {
            Array.Reverse(array);
            Array.Resize(ref array,array.Length+1);
            array[array.Length-1] = newElement;
            Array.Reverse(array);
            return array.Length;
        }
        
        
    }
}

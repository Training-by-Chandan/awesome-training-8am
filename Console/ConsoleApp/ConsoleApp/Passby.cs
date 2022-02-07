using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class Passby
    {
        //here we are passing values directly
        public static void PassbyValue(int i, int j)
        {
            i++;
            j++;
        }

        //here we are passing the address of the variable/
        //ref defines the reference of the variable
        public static void PassbyReference(ref int i, ref int j)
        {
            i++;
            j++;
        }

        //here we are using out
        // we have to assign something beforre the method exits
        //when we use "in", the variable becomes readonly within function
        public static void PassOut(in int i, int j, out int k)
        {
            //i = 5;
            j++;
            k = i + j;
        }

        //we are passing the default values here
        //i is the required parameter
        // j and s are optional, when we dont pass , the vlue of j becomes 30 and s becomes test
        //optional parameters are followed by required parameters
        public static void DefaultParameters(int i, int j = 30, string s = "Test")
        {
            //
            // here the default value fo j becomes 30 and s becomes Test
        }
    }
}
using System;

namespace DataTypes_Lib
{
    public class TypeConversion
    {
        public static short UIntToShort(uint num)
        {
            return (short)num;
        }

        public static long FloatToLong(float num)
        { /*Modify to round num to nearest integer before casting*/
            return (long)num;
        }
    }
}

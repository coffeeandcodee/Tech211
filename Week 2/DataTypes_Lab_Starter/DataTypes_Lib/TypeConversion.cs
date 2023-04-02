using System;

namespace DataTypes_Lib
{
    public class TypeConversion
    {
        public static short UIntToShort(uint num)
        {
            /* short --- signed 16 bit (4 byte) integer. Range: -32,768 to 32,767 (0000...[x 4] being -32,768)
               uint --- UNsigned(positve only) 32 bit (8 byte) integer. Range 0 to 4,294,967,295 (0000...[x 8] being 0)  */

            if (num > short.MaxValue)
            {
                throw new OverflowException();
            }
            return (short)num;
        }

        public static long FloatToLong(float num)
        { /*As it were, decimal part of float is truncated before being cast to long
            e.g 2.9f ---> cast to 2L
            Modify to round num to nearest integral before casting. 
           MathF.Round() rounds float up or down appropriately */

            num = MathF.Round(num);
            return (long)num;
        }
    }
}

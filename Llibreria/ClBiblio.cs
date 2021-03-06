﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Llibreria
{
    public class ClBiblio
    {
        public Boolean esPrimer(Int32 num)
        {
            int i = 2;
            Boolean trobat = false;
            Boolean xtrue = false;

            while (i < num && trobat == false)
            {
                if (num % i == 0)
                {
                    xtrue = true;
                    trobat = true;
                }
                i++;
            }
            
            return xtrue;
        }

        public Int32 esMesGran(Int32 a, Int32 b)
        {
            int result = b;

            if (a > b)
            {
                result = a;
            }
            return result;
        }

        public Int32 esMesPetit(Int32 a, Int32 b)
        {
            int result = b;

            if (a < b)
            {
                result = a;
            }
            return result;
        }

        public String divisors(Int32 num)
        {
            String divisors = "";
            int i = 1;

            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    divisors = divisors + i + ",";
                }
            }
            return divisors;
        }
    }
}

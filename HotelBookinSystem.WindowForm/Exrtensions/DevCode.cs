﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookinSystem.WindowForm.Exrtensions
{
    public static class DevCode
    {
        public static bool IsNullOrEmpty(this string str) => string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str);
    }
}

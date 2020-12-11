﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCORE.Extensions
{
    public static class ReflctionExtensions
    {
        public static string GetPropertyValue<T>(this T item,string propertyname)
        {
            return item.GetType().GetProperty(propertyname).GetValue(item, null).ToString();
        }
    }
}

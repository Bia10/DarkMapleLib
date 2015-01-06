﻿/*!
Copyright 2014 Yaminike

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkMapleLib.Helpers
{
    public static class Extensions
    {
        /// <summary>
        /// Converts a byte array to a hexadecimal string
        /// </summary>
        public static string ToHexString(this byte[] bArray, bool appendSpace = true)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in bArray)
                if (appendSpace)
                {
                    sb.Append(b.ToString("X2"));
                    sb.Append(' ');
                } else 
                    sb.Append(b.ToString("X2"));
            return sb.ToString();
        }
    }
}

// Copyright 2001-2010 - Active Up SPRLU (http://www.agilecomponents.com)
//
// This file is part of MailSystem.NET.
// MailSystem.NET is free software; you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
// 
// MailSystem.NET is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.

// You should have received a copy of the GNU Lesser General Public License
// along with SharpMap; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA 

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ActiveUp.Net.Security
{
    public class Canonicalizer
    {
        public static string Canonicalize(string input, CanonicalizationAlgorithm algorithm)
        {
            if (algorithm.Equals(CanonicalizationAlgorithm.NoFws)) return NoFws(input);
            else if (algorithm.Equals(CanonicalizationAlgorithm.Simple)) return Simple(input);
            else return input;
        }
        private static string NoFws(string input)
        {
            return input.Replace(" ", "").Replace("\t", "");
        }
        private static string Simple(string input)
        {
            return input;
        }
    }
}

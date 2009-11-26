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
namespace ActiveUp.Net.Mail
{
	/// <summary>
	/// Represents a MX dns record.
	/// </summary>
#if !PocketPC
	[System.Serializable]
#endif
    //[Obsolete("Please use ActiveUp.Net.Dns.MXRecord instead")]
	public class MxRecord
	{
		private string _exchange;
		private int _preference;

		/// <summary>
		/// The default constructor.
		/// </summary>
		public MxRecord()
		{
			_exchange = string.Empty;
			_preference = 10;
		}

		/// <summary>
		/// Creates a MX record based on the exchange name and preference level.
		/// </summary>
		/// <param name="exchange"></param>
		/// <param name="preference"></param>
		public MxRecord(string exchange, int preference)
		{
			_exchange = exchange;
			_preference = preference;
		}

		/// <summary>
		/// The exchange (host).
		/// </summary>
		public string Exchange
		{
			get
			{
				return _exchange;
			}
			set
			{
				_exchange = value;
			}
		}

		/// <summary>
		/// The preference level.
		/// </summary>
		public int Preference
		{
			get
			{
				return _preference;
			}
			set
			{
				_preference = value;
			}
		}
	}
}

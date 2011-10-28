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

namespace ActiveUp.Net.Mail
{
#region Imap4Exception
	/// <summary>
	/// Represents an IMAP4 specific error.
	/// </summary>
#if !PocketPC
	[System.Serializable]
#endif
    public class Imap4Exception : System.Exception
	{
        /// <summary>
        /// Generic error
        /// </summary>
        public Imap4Exception() : this("An unspecified IMAP error occurred.") { }
        
		/// <summary>
		/// Constructor, sets message to the specified value.
		/// </summary>
		/// <param name="message"></param>
		public Imap4Exception(string message) : base(message) { }
	}
	#endregion
}
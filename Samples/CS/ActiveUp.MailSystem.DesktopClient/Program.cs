﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ActiveUp.MailSystem.DesktopClient
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(MainForm.GetInstance());
		}
	}
}
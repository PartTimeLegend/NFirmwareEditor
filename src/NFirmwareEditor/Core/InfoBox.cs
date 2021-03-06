﻿using System.Windows.Forms;

namespace NFirmwareEditor.Core
{
	internal static class InfoBox
	{
		public static void Show(string text)
		{
			MessageBox.Show(text, @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public static void Show(string format, params object[] args)
		{
			Show(string.Format(format, args));
		}
	}
}

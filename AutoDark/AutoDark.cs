using System;
using Microsoft.Win32;

namespace AutoDark {
	class AutoDark {
		static int Main(string[] args) {
			int mode = -1;

			if (args.Length > 0 && args[0].Equals("dark", StringComparison.InvariantCultureIgnoreCase))
				mode = 0;
			else if (args.Length > 0 && args[0].Equals("light", StringComparison.InvariantCultureIgnoreCase))
				mode = 1;
			else if (args.Length > 0) // there is an argument, but it's invalid
				return -1;

			RegistryKey k = Registry.CurrentUser.OpenSubKey(
				"Software\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize",
				true
			);

			// if no argument, then just toggle
			if (mode == -1) {
				string val = k.GetValue("AppsUseLightTheme", 1).ToString();
				mode = int.Parse(val);
				if (mode == 1)
					mode = 0;
				else
					mode = 1;
			}

			if (k != null) {
				k.SetValue("AppsUseLightTheme", mode, RegistryValueKind.DWord);
				k.Close();
			} else
				return -2;

			return 0;
		}
	}
}

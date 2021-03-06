using System;
using CleverComponents.InetSuite;

namespace HttpClientConsole {
	class Program {
		static void Main(string[] args) {
			if (args.Length < 1) {
				Console.WriteLine("Please enter URL");
				Console.WriteLine("Usage: HttpClientConsole.exe <URL>");
				return;
			}

			using (Http http = new Http()) {
				var result = http.Get(args[0]);
				Console.Write(result);
			}
		}
	}
}

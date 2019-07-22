using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Diagnostics.PerformanceData;


namespace Test {
	class Program {
		static void Main(string[] args) {
			PerformanceCounterCategory category = new PerformanceCounterCategory("Network Interface");
			foreach(string a in category.GetInstanceNames()){
				Console.WriteLine(a);
			}
			Console.ReadKey();
		}
	}
}

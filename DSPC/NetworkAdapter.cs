using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace DSPC {
	 class NetworkAdapter {
		
		public string Name{ get; set; }
		public PerformanceCounter DownloadCounter{ get; set; }
		
		public double DownloadSpeed { get; set; }
		private long _downloadedValue = 1;
		private long _oldDownloadedValue = 1;
		
		public void Refresh(int time) {
			_oldDownloadedValue = _downloadedValue;
			_downloadedValue = DownloadCounter.NextSample().RawValue;
			DownloadSpeed = (_downloadedValue - _oldDownloadedValue) / (time / 1000f);
		}
	
	}
}

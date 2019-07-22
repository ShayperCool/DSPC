using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace DSPC {
	public partial class Form1 : Form {

		private List<NetworkAdapter> _adapters;
		private NetworkAdapter _selectedAdapter;
		private bool _startLook = false;
		private const int REFRESH_INTERVAL = 5000;
		private double _minimalSpeed;

		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			_adapters = new List<NetworkAdapter>();
			FindAllNetworkAdapters();
			System.Timers.Timer timer = new System.Timers.Timer(REFRESH_INTERVAL);
			timer.Elapsed += TimerElapsed;
			timer.Start();
			
		}

		private void FindAllNetworkAdapters(){
			var category = new PerformanceCounterCategory("Network Interface");
			foreach(string interfaceName in category.GetInstanceNames()){
				if (interfaceName.Contains("isatap."))
					continue;
				var networkAdapter = new NetworkAdapter();
				networkAdapter.Name = interfaceName;
				networkAdapter.DownloadCounter = new PerformanceCounter("Network Interface", "Bytes Received/sec", interfaceName);
				networkAdapters.Items.Add(networkAdapter.Name);
				_adapters.Add(networkAdapter);
			}
		}

		public void TimerElapsed(object sender, System.Timers.ElapsedEventArgs e){
			if(_selectedAdapter != null){
				_selectedAdapter.Refresh(REFRESH_INTERVAL);
				string _currentSpeed = $"Текущая скорость: {String.Format("{0:F2}", _selectedAdapter.DownloadSpeed / 1024)} kbps";
				currentSpeed.Invoke(new Action(() => { currentSpeed.Text = _currentSpeed; }));
				if(_startLook == true){
					double.TryParse(textBox1.Text, out _minimalSpeed);
					if (_minimalSpeed > (_selectedAdapter.DownloadSpeed / 1024))
						Process.Start("cmd", "/c shutdown -s -f -t 00");
				}
			}
		}

		private void NetworkAdapters_SelectedIndexChanged(object sender, EventArgs e) {
			string selectedState = networkAdapters.SelectedItem.ToString();
			foreach(var adapter in _adapters)
				if(adapter.Name == selectedState)
					_selectedAdapter = adapter;
		}

		private void Button1_Click(object sender, EventArgs e) {
			if (button1.Text == "Старт"){
				button1.Text = "Стоп";
				_startLook = true;
			}
			else{
				button1.Text = "Старт";
				_startLook = false;
			}
			
		}
	}
}

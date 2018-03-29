/*
 * Created by SharpDevelop.
 * User: Myrat
 * Date: 28.03.2018
 * Time: 21:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Pomodoro
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		//private bool state = false;
		//private bool break_time=false;
		private int seconds = 60;
		private int minute;
		private int pomo_count;
		private int now;
		
		bool _paused;
		bool running;
		
		int pomo;
		int sht;
		int lng;
		
		private string s;
		private string m;
		
		private string path = "\"" + Process.GetCurrentProcess().MainModule.FileName.ToString() + "\" -s";
		//private Microsoft.Win32.RegistryKey hkey;
		
		string[] msg = { "Time to Work", "Time to Relax", "Time to Long time break" };
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			string[] args = Environment.GetCommandLineArgs();
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//


			
			// Setting up components
			n_pomodoro.Visible = true;
			t_pomo.Interval = 1000;
			c_autorun.Checked = autorun_state;
			
			pomo_count = int.Parse(n_long_delay.Value.ToString());
			_paused = false;
			running = false;
			now = 0;
			c_profile.SelectedIndex = 0;
			Reset();
			

			foreach (string arg in args) {
				if (arg.Equals("-s")) {
					pomo_count = int.Parse(n_long_delay.Value.ToString());
		
					g_setup.Enabled = false;
					run();

					//this.Hide();
				}
			}
			
		}
		void N_pomodoroMouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.Show();
		}
		
		void C_autorunCheckedChanged(object sender, EventArgs e)
		{
			autorun(c_autorun.Checked);
		}
		
		
		void b_setupClick(object sender, EventArgs e)
		{
			if (window_expanded) {
				window_expanded = false;
				this.Width = 260;

			} else {
				window_expanded = true;
				this.Width = 440;
			}
		}
		
		
		void c_profileSelectedIndexChanged(object sender, EventArgs e)
		{			
			profile(c_profile.SelectedIndex);
			pomo = int.Parse(n_pomotime.Value.ToString());
			sht = int.Parse(n_short.Value.ToString());
			lng = int.Parse(n_long.Value.ToString());
			
			Reset();
		}
		
		void T_pomoTick(object sender, EventArgs e)
		{	
			//int i=1;
			if (minute <= 0 & seconds <= 0) {
				t_pomo.Stop();				
				//var sound = new System.Media.SoundPlayer(@".\Sound.wav");
				//sound.Play();
				seconds = 60;
				session(now);
						
				
				
			} else {
				if (seconds == 0) {
					seconds = 59;
					s = ":" + seconds.ToString();
					minute -= 1;
				} else
					seconds -= 1;
					
				if (seconds < 10)
					s = ":0" + seconds.ToString();
				else
					s = ":" + seconds.ToString();
				
				
				if (minute < 10)
					m = "0" + minute.ToString();
				else
					m = minute.ToString();
				
				if (minute == 0)
					m = "00";
				//i+=1;
				l_timer.Text = m + s;
			}
		}
		void B_startClick(object sender, EventArgs e)
		{
			pomo_count = int.Parse(n_long_delay.Value.ToString());
			pomo = int.Parse(n_pomotime.Value.ToString());
			sht = int.Parse(n_short.Value.ToString());
			lng = int.Parse(n_long.Value.ToString());
			
			
			g_setup.Enabled = false;
			run();
		}
		
		// Some functions
		// Configure autorun
		void autorun(bool b)
		{
			Microsoft.Win32.RegistryKey key;
			key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
			
			if (b) {
				key.SetValue("PomodoroTimer", path);
			} else {
				key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
				key.DeleteValue("PomodoroTimer");
			}
			
		}
		
		// Switch to %i pomodoro profile
		private void profile(int i)
		{
			switch (i) {
				case 0:
					{
						n_pomotime.Value = 25;
						n_short.Value = 5;
						n_long.Value = 15;
						n_long_delay.Value = 4;
						break;
					}
				case 1:
					{
						n_pomotime.Value = 50;
						n_short.Value = 10;
						n_long.Value = 20;
						n_long_delay.Value = 2;
						break;
					}
				case 2:
					{
						n_pomotime.Value = 30;
						n_short.Value = 2;
						n_long.Value = 25;
						n_long_delay.Value = 4;
						break;
					}
					
			}
		}
		
		// Reset the timer
		private void Reset()
		{
			t_pomo.Stop();
			seconds = 60;
			//minute = int.Parse(n_pomotime.Value.ToString());
			now = 0;
			pomo_count = int.Parse(n_long_delay.Value.ToString());
			_paused = false;
			running = false;
			b_start.Text = "Start";
			minute = pomo - 1;
			l_timer.Text = pomo.ToString() + ":00";
		}
		
		void run()
		{
			if (running) {
				running = false;
				_paused = true;
				t_pomo.Stop();
				b_start.Text = "Continue";
			} else {
				if (_paused) {
					running = true;
					_paused = false;
					t_pomo.Start();
					b_start.Text = "Pause";
				} else {
					_paused = false;
					running = true;
					b_start.Text = "Pause";
					session(now);
				}
			}
		}
		
		// Pomodoro sessions
		private void session(int id)
		{

			
			// if %pomo_count% is 0 then must long break
			if (pomo_count == 0) {
				id = 2;
				now = 0; // now - is session id.
				pomo_count = int.Parse(n_long_delay.Value.ToString());
			}
			
			MessageBox.Show(msg[id]);
			
			switch (id) {
			// Pomodoro time
				case 0:
					{
						p_timer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
						pomo_count--;
						minute = pomo - 1;
						now = 1;
						t_pomo.Start();
						break;
					}
			// Short break time
				case 1:
					{
						now = 0;
						p_timer.BackColor = System.Drawing.Color.MediumSpringGreen;
						minute = sht - 1;
						t_pomo.Start();
						break;
					}
				
			// Long break time
				case 2:
					{
						p_timer.BackColor = System.Drawing.Color.SkyBlue;
						minute = lng - 1;
						t_pomo.Start();
						break;
					}
			}
		}
		
		// Helpers
		
		// Settings window state
		bool window_expanded {
			get {
				if (this.Width > 260) {
					this.b_setup.Text = ">";
					return true;
				} else {
					this.b_setup.Text = "<";
					return false;
				}
					
			}

			set {
				g_setup.Visible = value;

			}
		}

		
		
		// get value for starting with windows
		bool autorun_state {
			get {		
				Microsoft.Win32.RegistryKey key;
				string val = "";
				key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
				val = key.GetValue("PomodoroTimer", val = "").ToString();
				if (!val.Equals(path))
					return false;
				else
					return true;

			}
		}

		void B_stopClick(object sender, EventArgs e)
		{
			Reset();			
			g_setup.Enabled = true;
		}
		void N_pomotimeValueChanged(object sender, EventArgs e)
		{
			minute = int.Parse(n_pomotime.Value.ToString()) - 1;
			l_timer.Text = n_pomotime.Value.ToString() + ":00";
		}



	}
}

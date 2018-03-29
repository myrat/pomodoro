/*
 * Created by SharpDevelop.
 * User: Myrat
 * Date: 28.03.2018
 * Time: 21:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Pomodoro
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel p_timer;
		private System.Windows.Forms.Label l_timer;
		private System.Windows.Forms.Button b_stop;
		private System.Windows.Forms.Button b_start;
		private System.Windows.Forms.NotifyIcon n_pomodoro;
		private System.Windows.Forms.Timer t_pomo;
		private System.Windows.Forms.ContextMenuStrip c_menu;
		private System.Windows.Forms.CheckBox c_autorun;
		private System.Windows.Forms.Button b_setup;
		private System.Windows.Forms.GroupBox g_setup;
		private System.Windows.Forms.ComboBox c_profile;
		private System.Windows.Forms.NumericUpDown n_short;
		private System.Windows.Forms.Label l_short;
		private System.Windows.Forms.Label l_profile;
		private System.Windows.Forms.NumericUpDown n_long_delay;
		private System.Windows.Forms.NumericUpDown n_long;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown n_pomotime;
		private System.Windows.Forms.Label n_pomodor;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.p_timer = new System.Windows.Forms.Panel();
			this.b_stop = new System.Windows.Forms.Button();
			this.b_start = new System.Windows.Forms.Button();
			this.l_timer = new System.Windows.Forms.Label();
			this.n_pomodoro = new System.Windows.Forms.NotifyIcon(this.components);
			this.t_pomo = new System.Windows.Forms.Timer(this.components);
			this.c_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.c_autorun = new System.Windows.Forms.CheckBox();
			this.b_setup = new System.Windows.Forms.Button();
			this.g_setup = new System.Windows.Forms.GroupBox();
			this.n_long_delay = new System.Windows.Forms.NumericUpDown();
			this.n_long = new System.Windows.Forms.NumericUpDown();
			this.n_pomotime = new System.Windows.Forms.NumericUpDown();
			this.n_short = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.n_pomodor = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.l_short = new System.Windows.Forms.Label();
			this.l_profile = new System.Windows.Forms.Label();
			this.c_profile = new System.Windows.Forms.ComboBox();
			this.p_timer.SuspendLayout();
			this.g_setup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.n_long_delay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.n_long)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.n_pomotime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.n_short)).BeginInit();
			this.SuspendLayout();
			// 
			// p_timer
			// 
			this.p_timer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.p_timer.Controls.Add(this.b_stop);
			this.p_timer.Controls.Add(this.b_start);
			this.p_timer.Controls.Add(this.l_timer);
			this.p_timer.Location = new System.Drawing.Point(4, 4);
			this.p_timer.Margin = new System.Windows.Forms.Padding(0);
			this.p_timer.Name = "p_timer";
			this.p_timer.Size = new System.Drawing.Size(236, 115);
			this.p_timer.TabIndex = 0;
			// 
			// b_stop
			// 
			this.b_stop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.b_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.b_stop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.b_stop.Location = new System.Drawing.Point(129, 81);
			this.b_stop.Margin = new System.Windows.Forms.Padding(4);
			this.b_stop.Name = "b_stop";
			this.b_stop.Size = new System.Drawing.Size(70, 26);
			this.b_stop.TabIndex = 1;
			this.b_stop.Text = "Stop";
			this.b_stop.UseVisualStyleBackColor = false;
			this.b_stop.Click += new System.EventHandler(this.B_stopClick);
			// 
			// b_start
			// 
			this.b_start.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.b_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.b_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.b_start.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.b_start.Location = new System.Drawing.Point(51, 81);
			this.b_start.Margin = new System.Windows.Forms.Padding(4);
			this.b_start.Name = "b_start";
			this.b_start.Size = new System.Drawing.Size(70, 26);
			this.b_start.TabIndex = 1;
			this.b_start.Text = "Start";
			this.b_start.UseVisualStyleBackColor = false;
			this.b_start.Click += new System.EventHandler(this.B_startClick);
			// 
			// l_timer
			// 
			this.l_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.l_timer.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.l_timer.Location = new System.Drawing.Point(2, 1);
			this.l_timer.Margin = new System.Windows.Forms.Padding(0);
			this.l_timer.Name = "l_timer";
			this.l_timer.Size = new System.Drawing.Size(230, 60);
			this.l_timer.TabIndex = 0;
			this.l_timer.Text = "25:00";
			this.l_timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// n_pomodoro
			// 
			this.n_pomodoro.Text = "Pomodoro";
			this.n_pomodoro.Visible = true;
			this.n_pomodoro.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.N_pomodoroMouseDoubleClick);
			// 
			// t_pomo
			// 
			this.t_pomo.Tick += new System.EventHandler(this.T_pomoTick);
			// 
			// c_menu
			// 
			this.c_menu.Name = "contextMenuStrip1";
			this.c_menu.Size = new System.Drawing.Size(61, 4);
			// 
			// c_autorun
			// 
			this.c_autorun.Location = new System.Drawing.Point(6, 302);
			this.c_autorun.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.c_autorun.Name = "c_autorun";
			this.c_autorun.Size = new System.Drawing.Size(135, 36);
			this.c_autorun.TabIndex = 3;
			this.c_autorun.Text = "Start with windows";
			this.c_autorun.UseVisualStyleBackColor = true;
			this.c_autorun.CheckedChanged += new System.EventHandler(this.C_autorunCheckedChanged);
			// 
			// b_setup
			// 
			this.b_setup.BackColor = System.Drawing.SystemColors.ControlLight;
			this.b_setup.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
			this.b_setup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.b_setup.Location = new System.Drawing.Point(213, 147);
			this.b_setup.Name = "b_setup";
			this.b_setup.Size = new System.Drawing.Size(27, 28);
			this.b_setup.TabIndex = 4;
			this.b_setup.Text = ">";
			this.b_setup.UseVisualStyleBackColor = false;
			this.b_setup.Click += new System.EventHandler(this.b_setupClick);
			// 
			// g_setup
			// 
			this.g_setup.Controls.Add(this.n_long_delay);
			this.g_setup.Controls.Add(this.n_long);
			this.g_setup.Controls.Add(this.n_pomotime);
			this.g_setup.Controls.Add(this.n_short);
			this.g_setup.Controls.Add(this.c_autorun);
			this.g_setup.Controls.Add(this.label2);
			this.g_setup.Controls.Add(this.n_pomodor);
			this.g_setup.Controls.Add(this.label1);
			this.g_setup.Controls.Add(this.l_short);
			this.g_setup.Controls.Add(this.l_profile);
			this.g_setup.Controls.Add(this.c_profile);
			this.g_setup.Location = new System.Drawing.Point(258, 11);
			this.g_setup.Name = "g_setup";
			this.g_setup.Size = new System.Drawing.Size(160, 340);
			this.g_setup.TabIndex = 5;
			this.g_setup.TabStop = false;
			this.g_setup.Text = "Settings";
			// 
			// n_long_delay
			// 
			this.n_long_delay.Location = new System.Drawing.Point(9, 279);
			this.n_long_delay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.n_long_delay.Maximum = new decimal(new int[] {
			4,
			0,
			0,
			0});
			this.n_long_delay.Minimum = new decimal(new int[] {
			2,
			0,
			0,
			0});
			this.n_long_delay.Name = "n_long_delay";
			this.n_long_delay.Size = new System.Drawing.Size(146, 21);
			this.n_long_delay.TabIndex = 3;
			this.n_long_delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.n_long_delay.Value = new decimal(new int[] {
			2,
			0,
			0,
			0});
			// 
			// n_long
			// 
			this.n_long.Location = new System.Drawing.Point(8, 215);
			this.n_long.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.n_long.Maximum = new decimal(new int[] {
			25,
			0,
			0,
			0});
			this.n_long.Minimum = new decimal(new int[] {
			5,
			0,
			0,
			0});
			this.n_long.Name = "n_long";
			this.n_long.Size = new System.Drawing.Size(146, 21);
			this.n_long.TabIndex = 3;
			this.n_long.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.n_long.Value = new decimal(new int[] {
			5,
			0,
			0,
			0});
			// 
			// n_pomotime
			// 
			this.n_pomotime.Location = new System.Drawing.Point(6, 95);
			this.n_pomotime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.n_pomotime.Maximum = new decimal(new int[] {
			50,
			0,
			0,
			0});
			this.n_pomotime.Minimum = new decimal(new int[] {
			20,
			0,
			0,
			0});
			this.n_pomotime.Name = "n_pomotime";
			this.n_pomotime.Size = new System.Drawing.Size(146, 21);
			this.n_pomotime.TabIndex = 3;
			this.n_pomotime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.n_pomotime.Value = new decimal(new int[] {
			20,
			0,
			0,
			0});
			this.n_pomotime.ValueChanged += new System.EventHandler(this.N_pomotimeValueChanged);
			// 
			// n_short
			// 
			this.n_short.Location = new System.Drawing.Point(7, 148);
			this.n_short.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.n_short.Maximum = new decimal(new int[] {
			15,
			0,
			0,
			0});
			this.n_short.Minimum = new decimal(new int[] {
			2,
			0,
			0,
			0});
			this.n_short.Name = "n_short";
			this.n_short.Size = new System.Drawing.Size(146, 21);
			this.n_short.TabIndex = 3;
			this.n_short.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.n_short.Value = new decimal(new int[] {
			11,
			0,
			0,
			0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(8, 259);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Long break delay:";
			// 
			// n_pomodor
			// 
			this.n_pomodor.AutoSize = true;
			this.n_pomodor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.n_pomodor.Location = new System.Drawing.Point(6, 74);
			this.n_pomodor.Margin = new System.Windows.Forms.Padding(0);
			this.n_pomodor.Name = "n_pomodor";
			this.n_pomodor.Size = new System.Drawing.Size(68, 15);
			this.n_pomodor.TabIndex = 2;
			this.n_pomodor.Text = "Pomodoro:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(7, 195);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Long break:";
			// 
			// l_short
			// 
			this.l_short.AutoSize = true;
			this.l_short.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.l_short.Location = new System.Drawing.Point(8, 128);
			this.l_short.Name = "l_short";
			this.l_short.Size = new System.Drawing.Size(73, 15);
			this.l_short.TabIndex = 2;
			this.l_short.Text = "Short break:";
			// 
			// l_profile
			// 
			this.l_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.l_profile.Location = new System.Drawing.Point(6, 20);
			this.l_profile.Name = "l_profile";
			this.l_profile.Size = new System.Drawing.Size(100, 19);
			this.l_profile.TabIndex = 1;
			this.l_profile.Text = "Profiles";
			// 
			// c_profile
			// 
			this.c_profile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.c_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.c_profile.FormattingEnabled = true;
			this.c_profile.Items.AddRange(new object[] {
			"default - 25 5 15 4",
			"working  - 50 10 20 2",
			"personal - 30 2 25 4"});
			this.c_profile.Location = new System.Drawing.Point(6, 42);
			this.c_profile.Name = "c_profile";
			this.c_profile.Size = new System.Drawing.Size(148, 23);
			this.c_profile.TabIndex = 0;
			this.c_profile.SelectedIndexChanged += new System.EventHandler(this.c_profileSelectedIndexChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(424, 366);
			this.Controls.Add(this.g_setup);
			this.Controls.Add(this.b_setup);
			this.Controls.Add(this.p_timer);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "Pomodoro";
			this.p_timer.ResumeLayout(false);
			this.g_setup.ResumeLayout(false);
			this.g_setup.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.n_long_delay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.n_long)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.n_pomotime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.n_short)).EndInit();
			this.ResumeLayout(false);

		}
	}
}

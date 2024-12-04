﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using System.Runtime.InteropServices;

namespace TaskManager
{
	public partial class TaskManager : Form
	{
		Dictionary<int, Process> processes;
		public TaskManager()
		{
			InitializeComponent();
			LoadProcesses();
		}
		void LoadProcesses()
		{
			//listViewProcesses.Items.Clear();
			processes = Process.GetProcesses().ToDictionary(i => i.Id);
			//for (int i = 0; i < processes.Count; i++)
			//{
			//    ////listViewProcesses.Columns.Add()
			//    //listViewProcesses.Items
			//    //    .Add(processes[i].Id.).SubItems
			//    //    .Add(processes[i].ProcessName);
			//    KeyValuePair<int, Process> pair = processes.ElementAt(i);
			//}
			foreach (KeyValuePair<int, Process> p in processes)
			{
				//listViewProcesses.Items.Add(p.Key.ToString()).SubItems.Add(p.Value.ProcessName);
				//ListViewItem item = new ListViewItem();
				//item.Name = item.Text = p.Key.ToString();
				//item.SubItems.Add(p.Value.ProcessName);
				//listViewProcesses.Items.Add(item);
				AddProcessToListView(p.Value);
			}
		}
		void AddNewProcesses()
		{
			//processes = Process.GetProcesses().ToDictionary(i => i.Id);
			foreach (KeyValuePair<int, Process> p in processes)
			{
				if (!listViewProcesses.Items.ContainsKey(p.Key.ToString()))
				{
					//listViewProcesses.Items.Add(processes.Key.ToString()).SubItems.Add(processes.Value.ProcessName);
					//-----------------------------------
					//ListViewItem item = new ListViewItem();
					//item.Name =item.Text = p.Key.ToString();
					//item.SubItems.Add(p.Value.ProcessName);
					//listViewProcesses.Items.Add(item);
					//-----------------------------------
					AddProcessToListView(p.Value);
				}

			}
		}
		void AddProcessToListView(Process p)
		{
			ListViewItem item = new ListViewItem();
			item.Name = item.Text = p.Id.ToString();
			item.SubItems.Add(p.ProcessName);
			listViewProcesses.Items.Add(item);
		}
		void RemoveOldProcesses()
		{
			foreach (ListViewItem i in listViewProcesses.Items)
			{
				//if (processes[Convert.ToInt32(i.SubItems[0].Text)])
				if (!processes.ContainsKey(Convert.ToInt32(i.SubItems[0].Text)))
				{
					listViewProcesses.Items.Remove(i);
				}
			}
		}
		void RefreshProcesses()
		{
			processes = Process.GetProcesses().ToDictionary(i => i.Id);
			AddNewProcesses();
			RemoveOldProcesses();

		}

		private void timer_Tick(object sender, EventArgs e)
		{
			//processes = Process.GetProcesses().ToDictionary(i => i.Id);
			//LoadProcesses();
			RefreshProcesses();
			toolStripStatusLabelProcessCount.Text = $"Processes count:{listViewProcesses.Items.Count.ToString()}";
		}

		private void mainMenuFileRun_Click(object sender, EventArgs e)
		{
			RunFileDlg(this.Handle, IntPtr.Zero, "C:\\Windows\\System32\\", "Run PD_311", "Task Manager! Привет от PD_311", 0);
		}
		[DllImport("shell32.dll", EntryPoint = "#61", CharSet = CharSet.Unicode)]
		public static extern int RunFileDlg
			(
			[In] IntPtr hwnd,
			[In] IntPtr icon,
			[In] string path,
			[In] string titile,
			[In] string promt,
			[In] uint flags
			);
	}
}

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
using System.Windows.Forms.VisualStyles;
using System.Net.Configuration;
using System.Collections;
using System.Security.Principal;

namespace TaskManager
{
	public partial class TaskManager : Form
	{
		Dictionary<int, Process> processes;
		ListViewColumnSorter lvColumnSorter;
		//bool[] columns = new bool[4];
		Dictionary<string,bool>selectedColumns = new Dictionary<string,bool>();
		
		public TaskManager()
		{
			InitializeComponent();
			LoadProcesses();

			lvColumnSorter = new ListViewColumnSorter();
			listViewProcesses.ListViewItemSorter = lvColumnSorter;
			AdjustColumnsWidth();
			AllocConsole();
			InitSelectedColumns();
			
		}
		void InitSelectedColumns()
		{
			foreach (ToolStripMenuItem i in mainMenuColumns.DropDownItems)
			{
				selectedColumns[i.Text] = i.Checked;
			}
			PrintSelectedColumns();
		}
		void SetColumnsVisibility()
		{
			AdjustColumnsWidth();
				for(int i=1; i<listViewProcesses.Columns.Count; i++)
				{
				if (selectedColumns[listViewProcesses.Columns[i].Text] == false)
					listViewProcesses.Columns[i].Width = 0;
				}
		}
		//void SetColumns()
		//{
		//	listViewProcesses.Columns.Clear();
		//	listViewProcesses.Columns.Add("Name");
		//	//Console.WriteLine(listViewProcesses.Items[0].SubItems["PID"]);
		//	if (mainMenuViewSelectColumnsPID.Checked) listViewProcesses.Columns.Add("PID");
		//	if (mainMenuViewSelectColumnsOwner.Checked) listViewProcesses.Columns.Add("Owner");
		//	if (mainMenuViewSelectColumnsPath.Checked) listViewProcesses.Columns.Add("Path");

		//	AdjustColumnsWidth();
		//}
		void AdjustColumnsWidth()
		{ 
			foreach (ColumnHeader ch in this.listViewProcesses.Columns)
			{
				ch.Width = -1;
			}
		
		}
		[DllImport("kernel32.dll")]
		static extern bool AllocConsole();
		int GetColumnIndex(string name)
		{
			for(int i=0; i<listViewProcesses.Columns.Count; i++)
			{
				if (listViewProcesses.Columns[i].Text == Name) return i;
			}
			return -1;
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
			item.Name = p.Id.ToString();
			item.Text = p.ProcessName;
			//item.Name = item.Text = p.Id.ToString();
			item.SubItems.Add(p.Id.ToString());
			item.SubItems.Add(GetProcessUser(p));
			try
			{
				item.SubItems.Add(p.MainModule.FileName);
			}
			catch (Win32Exception ex)
			{
				item.SubItems.Add("");
				//throw;
			}

			listViewProcesses.Items.Add(item);
		}
		void RemoveOldProcesses()
		{
			foreach (ListViewItem i in listViewProcesses.Items)
			{
				//if (processes[Convert.ToInt32(i.SubItems[0].Text)])
				if (!processes.ContainsKey(Convert.ToInt32(i.SubItems[1].Text)))
				{
					listViewProcesses.Items.Remove(i);
				}
			}
		}
		void RefreshProcesses()
		{
			processes = Process.GetProcesses().ToDictionary(i => i.Id);
			RemoveOldProcesses();
			AddNewProcesses();
			//foreach (ColumnHeader ch in this.listViewProcesses.Columns)
			//{
			//	ch.Width = -2;
			//}
		}
		void DestroyProcess(int pid)
		{
			processes[pid].Kill();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			//processes = Process.GetProcesses().ToDictionary(i => i.Id);
			//LoadProcesses();
			RefreshProcesses();
			toolStripStatusLabelProcessCount.Text = $"Processes count:{listViewProcesses.Items.Count.ToString()}";
			//SetColumns();
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

		private void destroyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(listViewProcesses.SelectedItems.Count>0)
			DestroyProcess(Convert.ToInt32(listViewProcesses.SelectedItems[0].Name));
		}

		private void contextMenuProcList_Opening(object sender, CancelEventArgs e)
		{
			toolStripMenuItemOpenFileLocation.Enabled =
			toolStripMenuItemDestroy.Enabled =
				listViewProcesses.SelectedItems.Count > 0;
		}

		private void mainMenuTopmost_CheckedChanged(object sender, EventArgs e)
		{
			this.TopMost = mainMenuTopmost.Checked;
		}

		private void toolStripMenuItemOpenFileLocation_Click(object sender, EventArgs e)
		{
			string filename = processes[Convert.ToInt32(listViewProcesses.SelectedItems[0].Name)].MainModule.FileName;
			//MessageBox.Show(this, filename, "Location", MessageBoxButtons.OK, MessageBoxIcon.Information);
			ShellExecute(this.Handle, "open", "explorer.exe", $"/select, \"{filename}\"","", 1);
			//filename = filename.Remove(filename.LastIndexOf("\\"));
			//Process.Start("explorer", filename);
			//Process p =Process.Start(new ProcessStartInfo("explorer.exe", $"/select, \" {filename}\""));	
		}
		

		[DllImport("shell32.dll")]
		static extern IntPtr ShellExecute
			(
			IntPtr hwnd,
			string lpOperation,
			string lpFile,
			string lpParameters,
			string lpDirectory,
			int nCmdShow
			);

		private void listViewProcesses_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			if (e.Column == lvColumnSorter.SortColumn)
			{
				if (lvColumnSorter.Order == SortOrder.Ascending)
					lvColumnSorter.Order = SortOrder.Descending;
				else
					lvColumnSorter.Order = SortOrder.Ascending;
			}
			else 
			{
				lvColumnSorter.SortColumn = e.Column;
				lvColumnSorter.Order = SortOrder.Ascending;
			}
			this.listViewProcesses.Sort();
		}
		//Process owner
		[DllImport("advapi32.dll", SetLastError = true)]
		static extern bool OpenProcessToken(IntPtr handle, uint DesiredAccess, out IntPtr TokenHandle);
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool CloseHandle(IntPtr hObject);
		static string GetProcessUser (Process process)
		{
			string username = "N/A";
			IntPtr processHandle = IntPtr.Zero;
			try
			{
				OpenProcessToken(process.Handle, 8, out processHandle);
				using (WindowsIdentity wi = new WindowsIdentity(processHandle))
				{
					username = wi.Name;
				}
			}
			catch (Win32Exception ex )
			{

			}
			
			return username;
		}
		void PrintSelectedColumns()
		{
			foreach(KeyValuePair<string,bool> p in selectedColumns)
			{
				Console.WriteLine(p.Key + "\t" + p.Value);
			}
			Console.WriteLine("\n-----------------------------------------\n");
		}

        private void mainMenuViewSelectColumns_Click(object sender, EventArgs e)
        {
			selectedColumns[( sender as ToolStripMenuItem).Text] = (sender as ToolStripMenuItem).Checked;
			PrintSelectedColumns();
			SetColumnsVisibility();
        }

   //     private void mainMenuViewSelectColumnsOwner_Click(object sender, EventArgs e)
   //     {
   //         selectedColumns[(sender as ToolStripMenuItem).Text] = (sender as ToolStripMenuItem).Checked;
			//PrintSelectedColumns();
   //     }

   //     private void mainMenuViewSelectColumnsPath_Click(object sender, EventArgs e)
   //     {
   //         selectedColumns[(sender as ToolStripMenuItem).Text] = (sender as ToolStripMenuItem).Checked;
			//PrintSelectedColumns();
   //     }
    }
}

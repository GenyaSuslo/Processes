namespace Processes
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxProgramm = new TextBox();
            buttonStart = new Button();
            buttonCancel = new Button();
            process = new System.Diagnostics.Process();
            comboBoxPrograms = new ComboBox();
            SuspendLayout();
            // 
            // textBoxProgramm
            // 
            textBoxProgramm.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxProgramm.Location = new Point(35, 39);
            textBoxProgramm.Name = "textBoxProgramm";
            textBoxProgramm.Size = new Size(549, 27);
            textBoxProgramm.TabIndex = 0;
            // 
            // buttonStart
            // 
            buttonStart.DialogResult = DialogResult.OK;
            buttonStart.Location = new Point(301, 225);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(94, 29);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(436, 225);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // process
            // 
            process.StartInfo.Domain = "";
            process.StartInfo.LoadUserProfile = false;
            process.StartInfo.Password = null;
            process.StartInfo.StandardErrorEncoding = null;
            process.StartInfo.StandardInputEncoding = null;
            process.StartInfo.StandardOutputEncoding = null;
            process.StartInfo.UseCredentialsForNetworkingOnly = false;
            process.StartInfo.UserName = "";
            process.SynchronizingObject = this;
            // 
            // comboBoxPrograms
            // 
            comboBoxPrograms.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxPrograms.AutoCompleteSource = AutoCompleteSource.RecentlyUsedList;
            comboBoxPrograms.FormattingEnabled = true;
            comboBoxPrograms.Location = new Point(35, 87);
            comboBoxPrograms.Name = "comboBoxPrograms";
            comboBoxPrograms.Size = new Size(547, 28);
            comboBoxPrograms.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 266);
            Controls.Add(comboBoxPrograms);
            Controls.Add(buttonCancel);
            Controls.Add(buttonStart);
            Controls.Add(textBoxProgramm);
            Name = "MainForm";
            Text = "Processes";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxProgramm;
        private Button buttonStart;
        private Button buttonCancel;
        private System.Diagnostics.Process process;
        private ComboBox comboBoxPrograms;
    }
}

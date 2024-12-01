using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Processes
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            string cmd = textBoxProgramm.Text;
            if (comboBoxPrograms.Text.Length>0) cmd = comboBoxPrograms.Text;
            string[] splitted = cmd.Split(' ');
            string file = splitted[0];
            string arguments = "";
            if (splitted.Length>1) arguments = cmd.Remove(0, cmd.IndexOf(' '));
            process.StartInfo.FileName = file;
            process.StartInfo.Arguments = arguments;

            //��� ������� �������� ����� ����������� ������ ������� � ����� ������� ��������,
            //� ����� � ��������� ��������� ������� ��� �������� �������� � ���������� ��������� %PATH%.
            //��� ���������� ��������� Windows ����� ���������� �������� "set"
            //���� ��������� ������� �� ������, �� ��������� �������������� ��������:
            // System.ComponentModel.Win32Exception �� ������� ����� ��������� ����
            try
            {
                process.Start();
                if(!comboBoxPrograms.Items.Contains(cmd))comboBoxPrograms.Items.Add(cmd);
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                MessageBox.Show(this,ex.GetType().ToString() +  ex.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.GetType().ToString() + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

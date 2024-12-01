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

            //наш процесс пытаетс€ найти запускаемый поцесс сначала в своем рабочем каталоге,
            //а потом в системных каталогах включа€ все каталоги хранимые в переменной окружени€ %PATH%.
            //все переменные окружени€ Windows можно отобразить командой "set"
            //если указанный процесс не найден, то возникает исключительна€ ситуаци€:
            // System.ComponentModel.Win32Exception Ќе удаетс€ найти указанный файл
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

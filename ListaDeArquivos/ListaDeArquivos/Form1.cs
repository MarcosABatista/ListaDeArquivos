namespace ListaDeArquivos
{
    public partial class Form1 : Form
    {
        string rota ="";
        public Form1()
        {
            InitializeComponent();
        }

        private void botao_Click(object sender, EventArgs e)
        {
            using (var openDlg = new FolderBrowserDialog())
            {
                openDlg.SelectedPath = rota;
                if(openDlg.ShowDialog() == DialogResult.OK)
                    rota = openDlg.SelectedPath;
            }

            arquivos.Items.Clear();
            GetDir(rota);
            GetFiles(rota);
        }
        private void GetDir(string rota)
        {
            var diretorio = Directory.GetDirectories(rota);

            foreach(string dir in diretorio)
                arquivos.Items.Add(dir.Distinct() + "<DIR>");
        }
        private void GetFiles(string rota)
        {
            var arquivo = Directory.GetFiles(rota);

            foreach (string dir in arquivo)
                arquivos.Items.Add(dir);
        }
      
    }
}
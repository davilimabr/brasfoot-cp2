using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp27
{
    public partial class FormMenuInical : Form
    {
        DataBaseManager Gerenciador;

        int X = 0;
        int Y = 0;
        public FormMenuInical()
        {
            InitializeComponent();
            Gerenciador = new DataBaseManager("BD_Padrao");


            this.MouseMove += new MouseEventHandler(FormMenuInicial_MouseMove);
            this.MouseDown += new MouseEventHandler(FormMenuInicial_MouseDown);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controleDePaginas.SelectedTab = tabPageNovoJogo;

            List<string> Times = BuscarTimes();

            foreach (string time in Times)
            {
                comboBoxTimes.Items.Add(time);
            }
        }

        private List<string> BuscarTimes()
        {
            string busca = "SELECT Nome FROM Time";

            DataTable tabelinha = Gerenciador.ConsultarBanco(busca);

            string linha;

            List<string> times = new List<string>();

            for (int i = 0; i < tabelinha.Rows.Count; i++)
            {
                linha = tabelinha.Rows[i]["Nome"].ToString();
                times.Add(linha);
            }

            return times;


        }
        
        private void buttonComeçar_Click(object sender, EventArgs e)
        {

            string tecnico = textBoxTecnico.Text;
            string time = comboBoxTimes.Text;

            if (tecnico != "" && time != "")
            {
                SelecionarTime(tecnico, time);

                FormPreJogo formzin = new FormPreJogo(tecnico);
                this.Hide();
                DialogResult resultado = formzin.ShowDialog();

                if (resultado == DialogResult.Cancel)
                    this.Close();  
            }
            else
                MessageBox.Show("Preencha o formulario.");
        }

        private void SelecionarTime(string tecnico, string time)
        {
            string alteracao = $"UPDATE Time " +
                $"SET Nome_Tecnico = '{tecnico}' " +
                $"WHERE Nome = '{time}' ";

            Gerenciador.AtualizarBanco(alteracao);
        }

        //Movimentar formulario
        private void FormMenuInicial_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void FormMenuInicial_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }


        //Sair
        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //TrocarPag
        private void buttonVoltar1_Click(object sender, EventArgs e)
        {
            controleDePaginas.SelectedTab = tabPagePrincipal;

        }


        private void FormMenuInical_Load(object sender, EventArgs e)
        {
            ResetBD();
        }

        private void ResetBD()
        {
            string drop = "DROP TABLE Partidas; " +
                "DROP TABLE Jogador; " +
                "DROP TABLE Jogador_Especificacao; " +
                "DROP TABLE Time; " +
                "DROP TABLE Estatistica_Time; ";

            Gerenciador.AtualizarBanco(drop);

            string caminho = $@"{Directory.GetCurrentDirectory()}\ComandosSQL\CreateTable.txt";
            string comando = "";

            using (StreamReader leitor = new StreamReader(caminho))
            {
                while(!leitor.EndOfStream)
                {
                    comando += leitor.ReadLine();
                }
            }

            Gerenciador.AtualizarBanco(comando);

            caminho = $@"{Directory.GetCurrentDirectory()}\ComandosSQL\Estatistica_Time.txt";
            comando = "";

            using (StreamReader leitor = new StreamReader(caminho))
            {
                while (!leitor.EndOfStream)
                {
                    comando += leitor.ReadLine();
                }
            }
            Gerenciador.AtualizarBanco(comando);

            caminho = $@"{Directory.GetCurrentDirectory()}\ComandosSQL\Jogador_Especificacao.txt";
            comando = "";

            using (StreamReader leitor = new StreamReader(caminho))
            {
                while (!leitor.EndOfStream)
                {
                    comando += leitor.ReadLine();
                }
            }
            Gerenciador.AtualizarBanco(comando);

            caminho = $@"{Directory.GetCurrentDirectory()}\ComandosSQL\Time.txt";
            comando = "";

            using (StreamReader leitor = new StreamReader(caminho))
            {
                while (!leitor.EndOfStream)
                {
                    comando += leitor.ReadLine();
                }
            }
            Gerenciador.AtualizarBanco(comando);

            caminho = $@"{Directory.GetCurrentDirectory()}\ComandosSQL\Jogador.txt";
            comando = "";

            using (StreamReader leitor = new StreamReader(caminho))
            {
                while (!leitor.EndOfStream)
                {
                    comando += leitor.ReadLine();
                }
            }
            Gerenciador.AtualizarBanco(comando);

            caminho = $@"{Directory.GetCurrentDirectory()}\ComandosSQL\Partidas.txt";
            comando = "";

            using (StreamReader leitor = new StreamReader(caminho))
            {
                while (!leitor.EndOfStream)
                {
                    comando += leitor.ReadLine();
                }
            }
            Gerenciador.AtualizarBanco(comando);
        }

        private void tabPagePrincipal_Click(object sender, EventArgs e)
        {

        }
    }
}

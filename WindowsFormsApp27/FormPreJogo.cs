using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp27
{
    public partial class FormPreJogo : Form
    {
        DataBaseManager Gerenciador;
        string NomeDoTecnico = "";
        int ContRodadas = 1;
        int PartidaID = 1;
        bool proxpart = false;



        int X = 0;
        int Y = 0;

        public FormPreJogo(string tecnico)
        {
            InitializeComponent();
            Gerenciador = new DataBaseManager("BD_Padrao");
            NomeDoTecnico = tecnico;

            this.MouseMove += new MouseEventHandler(FormMenuInicial_MouseMove);
            this.MouseDown += new MouseEventHandler(FormMenuInicial_MouseDown);
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

        private void button5_Click(object sender, EventArgs e)
        {
            Form menuJogo = new FormJogo(NomeDoTecnico);           
            this.Hide();
            DialogResult resultado = menuJogo.ShowDialog();
            if(resultado == DialogResult.Cancel)
            {
                menuJogo.Close();
                CalcularDados();
                this.Show();
            }

        }

        private void AtualizarDadosPartida()
        {
            string consulta = $"SELECT Jogador.Nome,Ataque,Defesa,Posicao FROM Jogador,Jogador_Especificacao, Time " +
                $"WHERE Jogador.Especificacoes=Jogador_Especificacao.Especificacao_id " +
                $"AND  Jogador.Time_id= Time.Time_id " +
                $"AND Time.Nome_Tecnico = '{NomeDoTecnico}' " +
                $"ORDER BY Posicao asc";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPreJogo_Load(object sender, EventArgs e)
        {
            CarregarJogadores();
            CalcularDados();
        }

        private void CarregarJogadores()
        {
            string consulta = $"SELECT Jogador.Nome,Ataque,Defesa,Posicao FROM Jogador,Jogador_Especificacao, Time " +
                $"WHERE Jogador.Especificacoes=Jogador_Especificacao.Especificacao_id " +
                $"AND  Jogador.Time_id= Time.Time_id " +
                $"AND Time.Nome_Tecnico = '{NomeDoTecnico}' " +
                $"ORDER BY Posicao asc";

            DataTable tabelinha = Gerenciador.ConsultarBanco(consulta);

            string linha;
            for (int i =0;i<tabelinha.Rows.Count;i++)
            {
                linha = tabelinha.Rows[i]["Nome"].ToString();
                listBoxNomeJogador.Items.Add(linha);

                linha = tabelinha.Rows[i]["Ataque"].ToString();
                listBoxAtkk.Items.Add(linha);

                linha = tabelinha.Rows[i]["Defesa"].ToString();
                listBoxDfs.Items.Add(linha);

                linha = tabelinha.Rows[i]["Posicao"].ToString();
                listBoxPoze.Items.Add(linha);
            }
        }

        private void CalcularDados()
        {
            string consulta = $"SELECT AVG(Ataque)as Ataque,AVG(Defesa) as Defesa, Pontos,GolsPro,GoslContra, GolsPro-GoslContra as Saldo " +
                $"FROM Jogador_Especificacao, Time,Jogador,Estatistica_Time " +
                $"WHERE Time.Estatistica=Estatistica_Time.Estatistica_id " +
                $"AND Jogador.Time_id=Time.Time_id " +
                $"AND Jogador.Especificacoes=Jogador_Especificacao.Especificacao_id " +
                $"AND time.Nome_Tecnico = '{NomeDoTecnico}' " +
                $"group by Pontos,GolsPro,GoslContra,GolsPro-GoslContra";

            DataTable tabelinha = Gerenciador.ConsultarBanco(consulta);

            string linha = "";

            linha = tabelinha.Rows[0]["Ataque"].ToString();
            labelMA.Text = $"Media Ataque : {linha}";

            linha = tabelinha.Rows[0]["Defesa"].ToString();
            labelMD.Text = $"Media Defesa : {linha}";

            //linha = tabelinha.Rows[0]["GolsPro"].ToString();
            labelGP.Text = $"GolsPro : Em breve...";

            //linha = tabelinha.Rows[0]["GoslContra"].ToString();
            labelGC.Text = $"GolsContra : Em breve...";

            //linha = tabelinha.Rows[0]["Saldo"].ToString();
            labelSaldo.Text = $"Saldo : Em breve...";         

            //linha = tabelinha.Rows[0]["Pontos"].ToString();
            labelPTS.Text = $"Pontos : Em breve...";
        }

        private void ProximaPartida()
        {
            string consulta1 = $"SELECT * FROM Partidas " +
                $"WHERE Rodada = {ContRodadas}";
            DataTable tabelinha1 = Gerenciador.ConsultarBanco(consulta1);

            string consulta = "";
            DataTable tabelinha;

            for (int i = 0; i < tabelinha1.Rows.Count; i++)
            {
                    consulta = $"SELECT Nome,Time_Casa,Time_Fora FROM Time,Partidas " +
                    $"Where Time.Time_id = Partidas.Time_Casa " +
                    $"AND Nome_Tecnico <> '{NomeDoTecnico}' " +
                    $"AND Partida_ID = {i} " +
                    $"AND Rodada =`{ContRodadas}" +
                    $"UNION ALL " +
                    $"SELECT Nome,Time_Casa,Time_Fora FROM Time,Partidas " +
                    $"Where Time.Time_id = Partidas.Time_Fora " +
                    $"AND Nome_Tecnico <> '{NomeDoTecnico}' " +
                    $"AND Partida_ID = {i} " +
                    $"AND Rodada =`{ContRodadas}";

                tabelinha = Gerenciador.ConsultarBanco(consulta);

                if(tabelinha.Rows.Count == 2)
                {
                    
                }
                else
                {
                    proxpart = true;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;

            string consulta = "SELECT Nome,Gols FROM jogador,Jogador_Especificacao WHERE jogador.Especificacoes=Jogador_Especificacao.Especificacao_id ORDER BY Gols desc";

            DataTable tabela = Gerenciador.ConsultarBanco(consulta);

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            for (int i =0;i<15;i++)
            {
                listBox1.Items.Add(tabela.Rows[i]["Nome"].ToString());
                listBox2.Items.Add(tabela.Rows[i]["Gols"].ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Breve...");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Breve...");
        }
    }
}

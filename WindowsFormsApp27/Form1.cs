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
    public partial class FormJogo : Form
    {
        //Atributos
        DataBaseManager gerenciador = null;
        Random aleatorio = new Random();
        private Time TimeA;
        private Time TimeB;       
        int minutos = 0;
        int GolA = 0;
        int GolB = 0;
        string NomeDoTecnico = "";
        List<string> AllTimes;
        string NomeTime;
        int Time_id;

        int X = 0;
        int Y = 0;

        //Barras de stamina
        List<ProgressBar> TitularesBarA = new List<ProgressBar>();
        List<ProgressBar> TitularesBarB = new List<ProgressBar>();
        List<ProgressBar> ReservasBarA = new List<ProgressBar>();
        List<ProgressBar> ReservasBarB = new List<ProgressBar>();

        //Construtor
        public FormJogo(string tecnico)
        {
            InitializeComponent();
            gerenciador = new DataBaseManager("BD_Padrao");
            AllTimes = new List<string>();
            CarregarComboboxes();
            loadBar1.Value = 0;
            CarregarBarrasStamin();
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


        private void CarregarTimes()
        {
            string consulta = $"SELECT Nome FROM Time ORDER BY Time_id asc";

            DataTable tabela = gerenciador.ConsultarBanco(consulta);

            for(int i =0;i<tabela.Rows.Count;i++)
            {
                AllTimes.Add(tabela.Rows[i]["Nome"].ToString());
            }

            consulta = $"SELECT Nome FROM Time WHERE Nome_Tecnico ='{NomeDoTecnico}'";
            tabela = gerenciador.ConsultarBanco(consulta);

            NomeTime = tabela.Rows[0][0].ToString();
        }

        //Métodos de Evento      

        private void cmbBoxMarcacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimeA.SetMarcacao(cmbBoxMarcacao.Text);
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            buttonVoltar.Enabled = false;   
            Time_id = aleatorio.Next(0, AllTimes.Count);

            bool repetido = true;
            while(repetido)
            {
                if (NomeTime == AllTimes[Time_id])
                {
                    Time_id = aleatorio.Next(0, AllTimes.Count);

                }
                else
                    repetido = false;
            }
           

            labelTimeB.Text = AllTimes[Time_id-1];

            LimparListBox();

            ZerarBarrasStamin();

            

            TimeA.GetJogadoresTitulares().Clear();
            TimeA.GetJogadoresReservas().Clear();
            TimeB.GetJogadoresReservas().Clear();
            TimeB.GetJogadoresTitulares().Clear();

            AtualizarListaA();
            AtualizarListaB(Time_id);

            PorcetagemStamina();

            GolA = 0;
            GolB = 0;
            TimeA.VoltarTudo();
            TimeB.VoltarTudo();

            buttonPause.Enabled = true;
            loadBar1.Value = 0;
            cmbBoxMarcacao.Enabled = false;
            cmbBoxEstilodeAttk.Enabled = false;

            int marctipo = aleatorio.Next(0, cmbBoxMarcacaoB.Items.Count);
            int estiloatktipo = aleatorio.Next(0, cmbBoxEstilodeAttkB.Items.Count);
            cmbBoxMarcacaoB.Text = cmbBoxMarcacaoB.Items[marctipo].ToString();
            cmbBoxEstilodeAttkB.Text = cmbBoxEstilodeAttkB.Items[estiloatktipo].ToString();

            if (cmbBoxEstilodeAttk.Text=="")
            {
                cmbBoxEstilodeAttk.Text = "Equilibrado";
            }

            if(cmbBoxMarcacao.Text=="")
            {
                cmbBoxMarcacao.Text = "Equilibrado";
            }

            buttonIniciar.Enabled = false;
            listBox3.Items.Clear();
            labelGolA.Text = "0";
            labelGolB.Text = "0";

            timer1.Enabled = true;
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            RealizarJogada(minutos);

            minutos++;

            loadBar1.Value = minutos;
            loadBar1.Text = Convert.ToString(minutos) + "'";

            if (minutos == 20)
            {
                cmbBoxEstilodeAttk.Enabled = true;
                cmbBoxMarcacao.Enabled = true;
                PausarPartida();               
            }

            if (minutos == 21)
            {
                int marctipo = aleatorio.Next(0, cmbBoxMarcacaoB.Items.Count);
                int estiloatktipo = aleatorio.Next(0, cmbBoxEstilodeAttkB.Items.Count);
                cmbBoxMarcacaoB.Text = cmbBoxMarcacaoB.Items[marctipo].ToString();
                cmbBoxEstilodeAttkB.Text = cmbBoxEstilodeAttkB.Items[estiloatktipo].ToString();
            }

            if (minutos == 40)
            {
                timer1.Enabled = false;
                minutos = 0;
                buttonIniciar.Enabled = true;
                buttonPause.Enabled = false;
                cmbBoxEstilodeAttk.Enabled = true;
                cmbBoxMarcacao.Enabled = true;
                buttonVoltar.Enabled = true;
                AtualizarGolsJogadorBD();
            }
            if(minutos %4==0)
            {
                TimeA.CansarJogadores();
                TimeB.CansarJogadores();
                TimeA.DescansarJogadores();
                TimeB.DescansarJogadores();
                PorcetagemStamina();
            }
                 
        }

        private void buttonTroca_Click(object sender, EventArgs e)
        {
            if(!timer1.Enabled)
            {
                if (listBoxJogadoresA.SelectedIndex != -1 && listBoxReservasA.SelectedIndex != -1)
                {
                    TimeA.AlterarReservas(listBoxReservasA.Items[listBoxReservasA.SelectedIndex].ToString());
                    TimeA.AlterarTitulares(listBoxJogadoresA.Items[listBoxJogadoresA.SelectedIndex].ToString());

                    AtualizarListaA();
                    PorcetagemStamina();
                }

            }
        }

        private void listBoxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listSender = (ListBox)sender;
            int indice = 0;

            if (listSender == listBoxJogadoresA || listSender == listBoxAtaqueA || listSender == listBoxDefesaA)
            {
                indice = listSender.SelectedIndex;

                listBoxJogadoresA.SelectedIndex = indice;
                listBoxAtaqueA.SelectedIndex = indice;
                listBoxDefesaA.SelectedIndex = indice;
            }
            else if (listSender == listBoxReservasA || listSender == listBoxReservaAtkA || listSender == listBoxReservaDfsA)
            {
                indice = listSender.SelectedIndex;

                listBoxReservasA.SelectedIndex = indice;
                listBoxReservaAtkA.SelectedIndex = indice;
                listBoxReservaDfsA.SelectedIndex = indice;
            }

        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            PausarPartida();
        }

        //Métodos de apoio
        private void LimparListBox()
        {
            listBoxJogadoresA.Items.Clear();
            listBoxAtaqueA.Items.Clear();
            listBoxDefesaA.Items.Clear();
            listBoxReservasA.Items.Clear();
            listBoxReservaAtkA.Items.Clear();
            listBoxReservaDfsA.Items.Clear();

            listBoxJogadoresB.Items.Clear();
            listBoxAtaqueB.Items.Clear();
            listBoxDefesaB.Items.Clear();
            listBoxReservasB.Items.Clear();
            listBoxReservaAtkB.Items.Clear();
            listBoxReservaDfsB.Items.Clear();

            listBox3.Items.Clear();
            labelGolA.Text = "0";
            labelGolB.Text = "0";

            loadBar1.Text = "0'";
        }

        private void RealizarJogada(int minutos)
        {
            cmbBoxEstilodeAttk.Enabled = false;
            cmbBoxMarcacao.Enabled = false;

            double momento = aleatorio.NextDouble();
            double momentocartao = aleatorio.NextDouble();
            double ataqueA = 0;
            double ataqueB = 0;
            double defesaA = 0;
            double defesaB = 0;
            TimeA.SetMarcacao(cmbBoxMarcacao.Text);
            TimeB.SetMarcacao(cmbBoxMarcacaoB.Text);
            TimeA.SetEstilodeAtaque(cmbBoxEstilodeAttk.Text);
            TimeB.SetEstilodeAtaque(cmbBoxEstilodeAttkB.Text);

            TimeBSub();

            ataqueA = TimeA.GetAtaqueFinal();
            defesaA = TimeA.GetDefesaFinal();
            ataqueB = TimeB.GetAtaqueFinal();
            defesaB = TimeB.GetDefesaFinal();

            VantagemEstAtk(ref ataqueA, ref defesaA, ref ataqueB, ref defesaB);

            if (momento < Momentos(TimeGol.TimeA))
            {
                if (momentocartao < TimeA.GetMarcCartaoV())
                {
                    DarCartaoV(TimeGol.TimeA);
                }
            }

            else if (momento > 1 - Momentos(TimeGol.TimeB))
            {
                if (momentocartao < TimeB.GetMarcCartaoV())
                {
                    DarCartaoV(TimeGol.TimeB);
                }
            }

            if (momento < Momentos(TimeGol.TimeA))
            {
                if (momentocartao < TimeA.GetMarcCartaoA())
                    DarCartaoA(TimeGol.TimeA);
            }

            else if (momento > 1 - Momentos(TimeGol.TimeB))
            {
                if (momentocartao < TimeB.GetMarcCartaoA())
                    DarCartaoA(TimeGol.TimeB);
            }

            if (momento < Momentos(TimeGol.TimeA))
            {
                FazerGol(TimeGol.TimeA, ataqueA, defesaB);                             
            }

            if (momento > 1 - Momentos(TimeGol.TimeB))
            {
                FazerGol(TimeGol.TimeB, ataqueB, defesaA);               
            }

        }

        private void RealizarGol(TimeGol time)
        {
            if(time==TimeGol.TimeA)
            {
                GolA++;
                labelGolA.Text = GolA.ToString();
            }
            else
            {
                GolB++;
                labelGolB.Text = GolB.ToString();
            }
        }

        private void DarCartaoV(TimeGol time)
        {
            if (time == TimeGol.TimeA)
            {
                int jogadorIndice = aleatorio.Next(0, TimeA.GetJogadoresTitulares().Count);
                Jogador jogador = TimeA.GetJogadoresTitulares()[jogadorIndice];

                jogador.DarCartaoVermelho();

                if (Jogador.Cartao.Expulso == jogador.GetEstado())
                {
                    listBox3.Items.Add("O jogador " + jogador.GetNome() + " recebeu um cartão vermelho " + minutos + "'");
                    listBoxJogadoresA.Items.RemoveAt(jogadorIndice);
                    listBoxAtaqueA.Items.RemoveAt(jogadorIndice);
                    listBoxDefesaA.Items.RemoveAt(jogadorIndice);

                    TimeA.JogadorExpulso(jogador.GetNome());
                    TimeA.IncrementarExpulsao();
                }
            }

            else if (time == TimeGol.TimeB)
            {
                int jogadorIndice = aleatorio.Next(0, TimeB.GetJogadoresTitulares().Count);
                Jogador jogador = TimeB.GetJogadoresTitulares()[jogadorIndice];

                jogador.DarCartaoVermelho();

                if (Jogador.Cartao.Expulso == jogador.GetEstado())
                {
                    listBox3.Items.Add("O jogador " + jogador.GetNome() + " recebeu um cartão vermelho " + minutos + "'");
                    listBoxJogadoresB.Items.RemoveAt(jogadorIndice);
                    listBoxAtaqueB.Items.RemoveAt(jogadorIndice);
                    listBoxDefesaB.Items.RemoveAt(jogadorIndice);

                    TimeB.JogadorExpulso(jogador.GetNome());
                    TimeB.IncrementarExpulsao();
                }
            }
        }

        private void DarCartaoA(TimeGol time)
        {

            if (time == TimeGol.TimeA)
            {
                int jogadorIndice = aleatorio.Next(0, TimeA.GetJogadoresTitulares().Count);
                Jogador jogador = TimeA.GetJogadoresTitulares()[jogadorIndice];

                jogador.DarCartaoAmarelo();

                if (Jogador.Cartao.Amarelado == jogador.GetEstado())
                {
                    listBox3.Items.Add("O jogador " + jogador.GetNome() + " recebeu um cartão amarelo " + minutos + "'");
                }

                else if (Jogador.Cartao.Expulso == jogador.GetEstado())
                {
                    listBox3.Items.Add("O jogador " + jogador.GetNome() + " recebeu um cartão vermelho " + minutos + "'");
                    listBoxJogadoresA.Items.RemoveAt(jogadorIndice);
                    listBoxAtaqueA.Items.RemoveAt(jogadorIndice);
                    listBoxDefesaA.Items.RemoveAt(jogadorIndice);

                    TimeA.JogadorExpulso(jogador.GetNome());
                    TimeA.IncrementarExpulsao();
                }
            }

            else if (time == TimeGol.TimeB)
            {
                int jogadorIndice = aleatorio.Next(0, TimeB.GetJogadoresTitulares().Count);
                Jogador jogador = TimeB.GetJogadoresTitulares()[jogadorIndice];

                jogador.DarCartaoAmarelo();

                if (Jogador.Cartao.Amarelado == jogador.GetEstado())
                {
                    listBox3.Items.Add("O jogador " + jogador.GetNome() + " recebeu um cartão amarelo " + minutos + "'");
                }

                else if (Jogador.Cartao.Expulso == jogador.GetEstado())
                {
                    listBox3.Items.Add("O jogador " + jogador.GetNome() + " recebeu um cartão vermelho " + minutos + "'");
                    listBoxJogadoresB.Items.RemoveAt(jogadorIndice);
                    listBoxAtaqueB.Items.RemoveAt(jogadorIndice);
                    listBoxDefesaB.Items.RemoveAt(jogadorIndice);

                    TimeB.JogadorExpulso(jogador.GetNome());
                    TimeB.IncrementarExpulsao();
                }
            }

        }

        private double Momentos(TimeGol time)
        {
            if(time == TimeGol.TimeA)
            {
                double momentotime = TimeA.GetMarcMomento() / (TimeA.GetMarcMomento() + TimeB.GetMarcMomento());
                return momentotime;
            }
            else if(time == TimeGol.TimeB)
            {
                double momentotime = TimeB.GetMarcMomento() / (TimeA.GetMarcMomento() + TimeB.GetMarcMomento());
                return momentotime;
            }
            else
            {
                return 0.5;
            }
        }

        private void FazerGol(TimeGol time,double ataque,double defesa)
        {
            if(time == TimeGol.TimeA)
            {
                if (ataque > aleatorio.NextDouble())
                {
                    int jogadorIndice = aleatorio.Next(0, TimeA.GetJogadoresTitulares().Count);
                    double jogadorAtk = Convert.ToDouble(TimeA.GetJogadoresTitulares()[jogadorIndice].GetAtaque()) / 100;
                    string nomeJogador = TimeA.GetJogadoresTitulares()[jogadorIndice].GetNome().ToString();

                    if (jogadorAtk > aleatorio.NextDouble())
                    {
                        if (defesa < aleatorio.NextDouble())
                        {
                            TimeA.GetJogadoresTitulares()[jogadorIndice].AtualizarGol();
                            RealizarGol(TimeGol.TimeA);
                            listBox3.Items.Add(NomeTime + " - " + nomeJogador + " - " + minutos + "'");
                        }
                    }
                }
            }

            else if(time == TimeGol.TimeB)
            {
                if (ataque > aleatorio.NextDouble())
                {
                    int jogadorIndice = aleatorio.Next(0, TimeB.GetJogadoresTitulares().Count);
                    double jogadorAtk = Convert.ToDouble(TimeB.GetJogadoresTitulares()[jogadorIndice].GetAtaque()) / 100;
                    string nomeJogador = TimeB.GetJogadoresTitulares()[jogadorIndice].GetNome().ToString();

                    if (jogadorAtk > aleatorio.NextDouble())
                    {
                        if (defesa < aleatorio.NextDouble())
                        {
                            TimeB.GetJogadoresTitulares()[jogadorIndice].AtualizarGol();
                            RealizarGol(TimeGol.TimeB);
                            listBox3.Items.Add(labelTimeB.Text + " - " + nomeJogador + " - " + minutos + "'");
                        }
                    }
                }
            }
        }

        private void PausarPartida()
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                buttonPause.Text = "Continuar Partida";
            }

            else if (!timer1.Enabled)
            {
                timer1.Enabled = true;
                buttonPause.Text = "Pausar Partida";
            }           
        }

        private void CarregarComboboxes()
        {         
            cmbBoxEstilodeAttk.Items.Add("Ataque Total");
            cmbBoxEstilodeAttk.Items.Add("Equilibrado");
            cmbBoxEstilodeAttk.Items.Add("Contra-Ataque");

            cmbBoxMarcacao.Items.Add("Pesado");
            cmbBoxMarcacao.Items.Add("Equilibrado");
            cmbBoxMarcacao.Items.Add("Leve");

            cmbBoxEstilodeAttkB.Items.Add("Ataque Total");
            cmbBoxEstilodeAttkB.Items.Add("Equilibrado");
            cmbBoxEstilodeAttkB.Items.Add("Contra-Ataque");

            cmbBoxMarcacaoB.Items.Add("Pesado");
            cmbBoxMarcacaoB.Items.Add("Equilibrado");
            cmbBoxMarcacaoB.Items.Add("Leve");
        }

        private void AtualizarListaA()
        {
            if (TimeA.GetJogadoresTitulares().Count != 0 && TimeA.GetJogadoresReservas().Count != 0)
            {
                listBoxJogadoresA.Items.Clear();
                listBoxAtaqueA.Items.Clear();
                listBoxDefesaA.Items.Clear();

                listBoxReservasA.Items.Clear();
                listBoxReservaAtkA.Items.Clear();
                listBoxReservaDfsA.Items.Clear();

                for (int i = 0; i < TimeA.GetJogadoresReservas().Count; i++)
                {
                    listBoxReservasA.Items.Add(TimeA.GetJogadoresReservas()[i].GetNome());
                    listBoxReservaAtkA.Items.Add(TimeA.GetJogadoresReservas()[i].GetAtaqueBruto());
                    listBoxReservaDfsA.Items.Add(TimeA.GetJogadoresReservas()[i].GetDefesaBruta());
                }

                for (int i = 0; i < TimeA.GetJogadoresTitulares().Count; i++)
                {
                    listBoxAtaqueA.Items.Add(TimeA.GetJogadoresTitulares()[i].GetAtaqueBruto());
                    listBoxDefesaA.Items.Add(TimeA.GetJogadoresTitulares()[i].GetDefesaBruta());
                    listBoxJogadoresA.Items.Add(TimeA.GetJogadoresTitulares()[i].GetNome());
                }

            }

            else
            {
                

                string consulta = $"SELECT Jogador.Nome,Jogador_Especificacao.ataque,Jogador_Especificacao.defesa, Jogador_Especificacao.Resistencia, Jogador_Especificacao.Titularidade,Jogador_Especificacao.Posicao,Jogador_Especificacao.Gols  FROM Jogador_Especificacao,Time,Jogador WHERE Time.Time_id = Jogador.Time_id  AND Jogador.Especificacoes=Jogador_Especificacao.Especificacao_id AND Time.Nome_Tecnico = '{NomeDoTecnico}';";

                DataTable tabelinha = gerenciador.ConsultarBanco(consulta);                

                for (int i = 0; i < tabelinha.Rows.Count; i++)
                {

                    string nome = tabelinha.Rows[i][0].ToString();
                    int ataque = Convert.ToInt32(tabelinha.Rows[i][1]);
                    int defesa = Convert.ToInt32(tabelinha.Rows[i][2]);
                    double resistencia = (double)tabelinha.Rows[i][3];
                    int titular = Convert.ToInt32(tabelinha.Rows[i][4]);
                    string posição = (string)tabelinha.Rows[i][5];
                    int gols = Convert.ToInt32(tabelinha.Rows[i][6]);
                    int cartaoamarelo = 0;
                    int cartaovermelho = 0;

                    Jogador jg = new Jogador(nome, ataque, defesa, resistencia, titular, posição, cartaoamarelo, cartaovermelho,gols);

                    TimeA.AdicionarJogador(jg);
                    

                    if (jg.Titular)
                    {
                        listBoxJogadoresA.Items.Add(nome);
                        listBoxAtaqueA.Items.Add(ataque);
                        listBoxDefesaA.Items.Add(defesa);
                    } 
                    else
                    {
                        listBoxReservasA.Items.Add(nome);
                        listBoxReservaAtkA.Items.Add(ataque);
                        listBoxReservaDfsA.Items.Add(defesa);
                    }
                }
            }
        }

        private void AtualizarListaB(int num)
        {
            if (TimeB.GetJogadoresTitulares().Count != 0 && TimeB.GetJogadoresReservas().Count != 0)
            {
                listBoxJogadoresB.Items.Clear();
                listBoxAtaqueB.Items.Clear();
                listBoxDefesaB.Items.Clear();

                listBoxReservasB.Items.Clear();
                listBoxReservaAtkB.Items.Clear();
                listBoxReservaDfsB.Items.Clear();

                for (int i = 0; i < TimeB.GetJogadoresReservas().Count; i++)
                {
                    listBoxReservasB.Items.Add(TimeB.GetJogadoresReservas()[i].GetNome());
                    listBoxReservaAtkB.Items.Add(TimeB.GetJogadoresReservas()[i].GetAtaqueBruto());
                    listBoxReservaDfsB.Items.Add(TimeB.GetJogadoresReservas()[i].GetDefesaBruta());
                }

                for (int i = 0; i < TimeB.GetJogadoresTitulares().Count; i++)
                {
                    listBoxAtaqueB.Items.Add(TimeB.GetJogadoresTitulares()[i].GetAtaqueBruto());
                    listBoxDefesaB.Items.Add(TimeB.GetJogadoresTitulares()[i].GetDefesaBruta());
                    listBoxJogadoresB.Items.Add(TimeB.GetJogadoresTitulares()[i].GetNome());
                }

            }

            else
            {
                string consulta = $"SELECT Jogador.Nome,Jogador_Especificacao.ataque,Jogador_Especificacao.defesa, Jogador_Especificacao.Resistencia, Jogador_Especificacao.Titularidade,Jogador_Especificacao.Posicao,Jogador_Especificacao.Gols  FROM Jogador_Especificacao,Time,Jogador WHERE Time.Time_id = Jogador.Time_id  AND Jogador.Especificacoes=Jogador_Especificacao.Especificacao_id AND Time.Time_id = {num}";
                    
                DataTable tabelinha = gerenciador.ConsultarBanco(consulta);

                for (int i = 0; i < tabelinha.Rows.Count; i++)
                {
                    string nome = tabelinha.Rows[i][0].ToString();
                    int ataque = Convert.ToInt32(tabelinha.Rows[i][1]);
                    int defesa = Convert.ToInt32(tabelinha.Rows[i][2]);
                    double resistencia = (double)tabelinha.Rows[i][3];
                    int titular = Convert.ToInt32(tabelinha.Rows[i][4]);
                    string posição = (string)tabelinha.Rows[i][5];
                    int gols = Convert.ToInt32(tabelinha.Rows[i][6]);
                    int cartaoamarelo = 0;
                    int cartaovermelho = 0;

                    Jogador jg = new Jogador(nome, ataque, defesa, resistencia, titular, posição, cartaoamarelo, cartaovermelho,gols);

                    TimeB.AdicionarJogador(jg);

           

                    if (jg.Titular)
                    {
                        listBoxJogadoresB.Items.Add(nome);
                        listBoxAtaqueB.Items.Add(ataque);
                        listBoxDefesaB.Items.Add(defesa);
                    }
                    else
                    {
                        listBoxReservasB.Items.Add(nome);
                        listBoxReservaAtkB.Items.Add(ataque);
                        listBoxReservaDfsB.Items.Add(defesa);
                    }
                }
            }
        }

        private void PorcetagemStamina()
        {                
            for (int i = 0; i < TimeA.GetJogadoresTitulares().Count; i++)
            {
                TitularesBarA[i].Value = Convert.ToInt32(TimeA.GetJogadoresTitulares()[i].GetStamina() * 100);
            }

            for (int i = 0; i < TimeB.GetJogadoresTitulares().Count; i++)
            {
                TitularesBarB[i].Value = Convert.ToInt32(TimeB.GetJogadoresTitulares()[i].GetStamina() * 100);
            }

            for (int i = 0; i < TimeA.GetJogadoresReservas().Count; i++)
            {
                ReservasBarA[i].Value = Convert.ToInt32(TimeA.GetJogadoresReservas()[i].GetStamina() * 100);
            }

            for (int i = 0; i < TimeB.GetJogadoresReservas().Count; i++)
            {
                ReservasBarB[i].Value = Convert.ToInt32(TimeB.GetJogadoresReservas()[i].GetStamina() * 100);
            }
        }

        private void CarregarBarrasStamin()
        {
            //TitularesA
            TitularesBarA.Add(TituStaminBarA1);
            TitularesBarA.Add(TituStaminBarA2);
            TitularesBarA.Add(TituStaminBarA3);
            TitularesBarA.Add(TituStaminBarA4);
            TitularesBarA.Add(TituStaminBarA5);

            //TitularesB
            TitularesBarB.Add(TituStaminBarB1);
            TitularesBarB.Add(TituStaminBarB2);
            TitularesBarB.Add(TituStaminBarB3);
            TitularesBarB.Add(TituStaminBarB4);
            TitularesBarB.Add(TituStaminBarB5);

            //ReservasA
            ReservasBarA.Add(ReserStaminBarA1);
            ReservasBarA.Add(ReserStaminBarA2);
            ReservasBarA.Add(ReserStaminBarA3);
            ReservasBarA.Add(ReserStaminBarA4);
            ReservasBarA.Add(ReserStaminBarA5);
            ReservasBarA.Add(ReserStaminBarA6);
            ReservasBarA.Add(ReserStaminBarA7);

            //ReservasB
            ReservasBarB.Add(ReserStaminBarB1);
            ReservasBarB.Add(ReserStaminBarB2);
            ReservasBarB.Add(ReserStaminBarB3);
            ReservasBarB.Add(ReserStaminBarB4);
            ReservasBarB.Add(ReserStaminBarB5);
            ReservasBarB.Add(ReserStaminBarB6);
            ReservasBarB.Add(ReserStaminBarB7);
        }

        private void ZerarBarrasStamin()
        {
            foreach(ProgressBar barra in TitularesBarA)
            {
                barra.Value = 100;
            }
            foreach (ProgressBar barra in TitularesBarB)
            {
                barra.Value = 100;
            }
            foreach (ProgressBar barra in ReservasBarA)
            {
                barra.Value = 100;
            }
            foreach (ProgressBar barra in ReservasBarB)
            {
                barra.Value = 100;
            }
        }

        private void VantagemEstAtk(ref double atkA, ref double dfsA, ref double atkB, ref double dfsB)
        {
            if (TimeA.GetEstAtk() == Time.EstilodeAtaque.AtaqueTotal)
            {
                if(TimeB.GetEstAtk() == Time.EstilodeAtaque.ContraAtaque)
                {
                    atkB = TimeB.CalcularMedias(Time.Estilo.Ataque);
                    dfsB = dfsB * 1.02;
                }
                else if(TimeB.GetEstAtk() == Time.EstilodeAtaque.Equilibrado)
                {
                    atkA = atkA * 1.02;
                    dfsA = TimeA.CalcularMedias(Time.Estilo.Defesa);
                }
            }

            else if(TimeA.GetEstAtk() == Time.EstilodeAtaque.Equilibrado)
            {
                if(TimeB.GetEstAtk() == Time.EstilodeAtaque.ContraAtaque)
                {
                    atkA = atkA * 1.02;
                    dfsA = dfsA * 1.02;
                }
                else if(TimeB.GetEstAtk() == Time.EstilodeAtaque.AtaqueTotal)
                {
                    atkB = atkB * 1.02;
                    dfsB = TimeB.CalcularMedias(Time.Estilo.Defesa);
                }
            }
            else if(TimeA.GetEstAtk() == Time.EstilodeAtaque.ContraAtaque)
            {
                if(TimeB.GetEstAtk() == Time.EstilodeAtaque.AtaqueTotal)
                {
                    atkA = TimeA.CalcularMedias(Time.Estilo.Ataque);
                    dfsA = dfsA * 1.02;
                }
                else if(TimeB.GetEstAtk() == Time.EstilodeAtaque.Equilibrado)
                {
                    atkB = atkB * 1.02;
                    dfsB = dfsB * 1.02;
                }
            }
        }

        private void TimeBSub()
        {
            for(int i =0;i<TimeB.GetJogadoresTitulares().Count;i++)
            {
                if (TimeB.GetJogadoresTitulares()[i].GetStamina() * 100 < 35)
                {
                    int posicao = aleatorio.Next(0, TimeB.GetJogadoresReservas().Count);

                    TimeB.AlterarReservas(listBoxReservasB.Items[posicao].ToString());
                    TimeB.AlterarTitulares(listBoxJogadoresB.Items[i].ToString());

                    AtualizarListaB(Time_id);
                    PorcetagemStamina();
                }
            }
        }

        private void AtualizarGolsJogadorBD()
        {
            string update;
            string resistencia = "";
            for (int i = 0; i < TimeA.GetJogadoresTitulares().Count; i++)
            {
                resistencia = TimeA.GetJogadoresTitulares()[i].GetResistencia().ToString().Replace(",", ".");
                update = $"UPDATE Jogador_Especificacao " +
            $"SET Gols = {TimeA.GetJogadoresTitulares()[i].GetGol()} " +
            $"WHERE Ataque = {TimeA.GetJogadoresTitulares()[i].GetAtaqueBruto()} " +
            $"AND Defesa = {TimeA.GetJogadoresTitulares()[i].GetDefesaBruta()} " +
            $"AND Resistencia = {resistencia} " +
            $"AND Posicao = '{TimeA.GetJogadoresTitulares()[i].GetPosicao()}';";

                gerenciador.AtualizarBanco(update);
            }
            for (int i = 0; i < TimeA.GetJogadoresReservas().Count; i++)
            {
                resistencia = TimeA.GetJogadoresReservas()[i].GetResistencia().ToString().Replace(",", ".");
                update = $"UPDATE Jogador_Especificacao " +
           $"SET Gols = {TimeA.GetJogadoresReservas()[i].GetGol()} " +
           $"WHERE Ataque = {TimeA.GetJogadoresReservas()[i].GetAtaqueBruto()} " +
           $"AND Defesa = {TimeA.GetJogadoresReservas()[i].GetDefesaBruta()} " +
           $"AND Resistencia = {resistencia} " +
           $"AND Posicao = '{TimeA.GetJogadoresReservas()[i].GetPosicao()}';";

                gerenciador.AtualizarBanco(update);
            }
            for (int i = 0; i < TimeB.GetJogadoresTitulares().Count; i++)
            {
                resistencia = TimeB.GetJogadoresTitulares()[i].GetResistencia().ToString().Replace(",", ".");
                update = $"UPDATE Jogador_Especificacao " +
            $"SET Gols = {TimeB.GetJogadoresTitulares()[i].GetGol()} " +
            $"WHERE Ataque = {TimeB.GetJogadoresTitulares()[i].GetAtaqueBruto()} " +
            $"AND Defesa = {TimeB.GetJogadoresTitulares()[i].GetDefesaBruta()} " +
            $"AND Resistencia = {resistencia} " +
            $"AND Posicao = '{TimeB.GetJogadoresTitulares()[i].GetPosicao()}';";

                gerenciador.AtualizarBanco(update);
            }
            for (int i = 0; i < TimeB.GetJogadoresReservas().Count; i++)
            {
                resistencia = TimeB.GetJogadoresReservas()[i].GetResistencia().ToString().Replace(",", ".");
                update = $"UPDATE Jogador_Especificacao " +
                $"SET Gols = {TimeB.GetJogadoresReservas()[i].GetGol()} " +
                $"WHERE Ataque = {TimeB.GetJogadoresReservas()[i].GetAtaqueBruto()} " +
                $"AND Defesa = {TimeB.GetJogadoresReservas()[i].GetDefesaBruta()} " +
                $"AND Resistencia = {resistencia} " +
                $"AND Posicao = '{TimeB.GetJogadoresReservas()[i].GetPosicao()}';";

                gerenciador.AtualizarBanco(update);
            }


        }

        //Enumeracoes
        public enum TimeGol
        {
            TimeA,
            TimeB
        }

        private void FormJogo_FormClosed(object sender, FormClosedEventArgs e)
        {
         
        }

        private void FormJogo_Load(object sender, EventArgs e)
        {
            LimparListBox();
            CarregarTimes();

            TimeA = new Time();
            TimeB = new Time();

            labelTimeA.Text = NomeTime;
            AtualizarListaA();

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelGolA_Click(object sender, EventArgs e)
        {

        }
    }
}

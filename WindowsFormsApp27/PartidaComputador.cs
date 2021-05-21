using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace WindowsFormsApp27
{
    class PartidaComputador
    {
        DataBaseManager gerenciador = null;
        Random aleatorio = new Random();
        private Time TimeA;
        private Time TimeB;
        int minutos = 0;
        int GolA = 0;
        int GolB = 0;
        string NomeDoTecnico = "";
        int partidaid;
        int timecasa;
        int timefora;

        List<string> marcacao;
        List<string> estiloataque;

        private void carregarListas()
        {
            marcacao.Clear();
            marcacao = new List<String>();
            estiloataque.Clear();
            estiloataque = new List<String>();

            marcacao.Add("Pesado");
            marcacao.Add("Equilibrado");
            marcacao.Add("Leve");

            estiloataque.Add("Ataque Total");
            estiloataque.Add("Equilibrado");
            estiloataque.Add("Contra-Ataque");
        }

        public PartidaComputador(int id, int timec, int timef)
        {
            GolA = 0;
            GolB = 0;
            TimeA.VoltarTudo();
            TimeB.VoltarTudo();

            gerenciador = new DataBaseManager("BD_Padrao");
            partidaid = id;
            timecasa = timec;
            timefora = timef;
            RealizarPartida();

        }

        private void RealizarPartida()
        {
            TimeTimeA();
            TimeTimeB();

            for (int i = 0; i <= 40; i++)
            {
                int marcA = aleatorio.Next(0, marcacao.Count);
                int marcB = aleatorio.Next(0, marcacao.Count);
                int estA = aleatorio.Next(0, estiloataque.Count);
                int estB = aleatorio.Next(0, estiloataque.Count);
                RealizarJogada(minutos, marcA, marcB, estA, estB);

                minutos++;

                if (minutos == 21)
                {
                    marcA = aleatorio.Next(0, marcacao.Count);
                    marcB = aleatorio.Next(0, marcacao.Count);
                    estA = aleatorio.Next(0, estiloataque.Count);
                    estB = aleatorio.Next(0, estiloataque.Count);
                }

                if (minutos == 40)
                {
                    minutos = 0;
                    AcabarPartida();
                }

                if (minutos % 4 == 0)
                {
                    TimeA.CansarJogadores();
                    TimeB.CansarJogadores();
                    TimeA.DescansarJogadores();
                    TimeB.DescansarJogadores();
                }
            }
        }

        private void RealizarJogada(int minutos,int marcA,int marcB,int estA,int estB)
        {
            double momento = aleatorio.NextDouble();
            double momentocartao = aleatorio.NextDouble();
            double ataqueA = 0;
            double ataqueB = 0;
            double defesaA = 0;
            double defesaB = 0;
            TimeA.SetMarcacao(marcacao[marcA]);
            TimeB.SetMarcacao(marcacao[marcB]);
            TimeA.SetEstilodeAtaque(estiloataque[estA]);
            TimeB.SetEstilodeAtaque(estiloataque[estB]);


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

        private void RealizarGol(TimeGol time,int jogadorIndice)
        {
            if (time == TimeGol.TimeA)
            {
                GolA++;
                TimeA.GetJogadoresTitulares()[jogadorIndice].AtualizarGol();
            }
            else
            {
                GolB++;
                TimeB.GetJogadoresTitulares()[jogadorIndice].AtualizarGol();
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

                if (Jogador.Cartao.Expulso == jogador.GetEstado())
                {
                    TimeA.JogadorExpulso(jogador.GetNome());
                    TimeA.IncrementarExpulsao();
                }
            }

            else if (time == TimeGol.TimeB)
            {
                int jogadorIndice = aleatorio.Next(0, TimeB.GetJogadoresTitulares().Count);
                Jogador jogador = TimeB.GetJogadoresTitulares()[jogadorIndice];

                jogador.DarCartaoAmarelo();

                if (Jogador.Cartao.Expulso == jogador.GetEstado())
                {
                    TimeB.JogadorExpulso(jogador.GetNome());
                    TimeB.IncrementarExpulsao();
                }
            }

        }

        private double Momentos(TimeGol time)
        {
            if (time == TimeGol.TimeA)
            {
                double momentotime = TimeA.GetMarcMomento() / (TimeA.GetMarcMomento() + TimeB.GetMarcMomento());
                return momentotime;
            }
            else if (time == TimeGol.TimeB)
            {
                double momentotime = TimeB.GetMarcMomento() / (TimeA.GetMarcMomento() + TimeB.GetMarcMomento());
                return momentotime;
            }
            else
            {
                return 0.5;
            }
        }

        private void FazerGol(TimeGol time, double ataque, double defesa)
        {
            if (time == TimeGol.TimeA)
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
                            RealizarGol(TimeGol.TimeA,jogadorIndice);
                        }
                    }
                }
            }

            else if (time == TimeGol.TimeB)
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
                            RealizarGol(TimeGol.TimeB,jogadorIndice);
                            
                        }
                    }
                }
            }
        }

        private void VantagemEstAtk(ref double atkA, ref double dfsA, ref double atkB, ref double dfsB)
        {
            if (TimeA.GetEstAtk() == Time.EstilodeAtaque.AtaqueTotal)
            {
                if (TimeB.GetEstAtk() == Time.EstilodeAtaque.ContraAtaque)
                {
                    atkB = TimeB.CalcularMedias(Time.Estilo.Ataque);
                    dfsB = dfsB * 1.02;
                }
                else if (TimeB.GetEstAtk() == Time.EstilodeAtaque.Equilibrado)
                {
                    atkA = atkA * 1.02;
                    dfsA = TimeA.CalcularMedias(Time.Estilo.Defesa);
                }
            }

            else if (TimeA.GetEstAtk() == Time.EstilodeAtaque.Equilibrado)
            {
                if (TimeB.GetEstAtk() == Time.EstilodeAtaque.ContraAtaque)
                {
                    atkA = atkA * 1.02;
                    dfsA = dfsA * 1.02;
                }
                else if (TimeB.GetEstAtk() == Time.EstilodeAtaque.AtaqueTotal)
                {
                    atkB = atkB * 1.02;
                    dfsB = TimeB.CalcularMedias(Time.Estilo.Defesa);
                }
            }
            else if (TimeA.GetEstAtk() == Time.EstilodeAtaque.ContraAtaque)
            {
                if (TimeB.GetEstAtk() == Time.EstilodeAtaque.AtaqueTotal)
                {
                    atkA = TimeA.CalcularMedias(Time.Estilo.Ataque);
                    dfsA = dfsA * 1.02;
                }
                else if (TimeB.GetEstAtk() == Time.EstilodeAtaque.Equilibrado)
                {
                    atkB = atkB * 1.02;
                    dfsB = dfsB * 1.02;
                }
            }
        }

        private void TimeASub()
        {
            for (int i = 0; i < TimeA.GetJogadoresTitulares().Count; i++)
            {
                if (TimeA.GetJogadoresTitulares()[i].GetStamina() * 100 < 35)
                {
                    int posicao = aleatorio.Next(0, TimeA.GetJogadoresReservas().Count);

                    TimeA.AlterarReservas(TimeA.GetJogadoresReservas()[posicao].GetNome());
                    TimeA.AlterarTitulares(TimeA.GetJogadoresTitulares()[i].GetNome());
                }
            }
        }

        private void TimeBSub()
        {
            for (int i = 0; i < TimeB.GetJogadoresTitulares().Count; i++)
            {
                if (TimeB.GetJogadoresTitulares()[i].GetStamina() * 100 < 35)
                {
                    int posicao = aleatorio.Next(0, TimeB.GetJogadoresReservas().Count);

                    TimeB.AlterarReservas(TimeB.GetJogadoresReservas()[posicao].GetNome());
                    TimeB.AlterarTitulares(TimeB.GetJogadoresTitulares()[i].GetNome());
                }
            }
        }

        private void TimeTimeA()
        {
            string consulta = $"SELECT Jogador.Nome,Jogador_Especificacao.Ataque,Jogador_Especificacao.Defesa, Jogador_Especificacao.Resistencia, Jogador_Especificacao.Titularidade, Jogador_Especificacao.Posicao,Jogador_Especificacao.Gols FROM Jogador,Time,Jogador_Especificacao " +
                $"WHERE Time.Time_id = Jogador.Time_id " +
                $"AND Jogador.Especificacoes = Jogador_Especificacao.Especificacao_id " +
                $"AND Time.Time_Id = {timecasa} ";

            DataTable tabelinha = gerenciador.ConsultarBanco(consulta);

            for (int i = 0; i < tabelinha.Rows.Count; i++)
            {
                string nome = tabelinha.Rows[i][0].ToString();
                int ataque = (int)tabelinha.Rows[i][1];
                int defesa = (int)tabelinha.Rows[i][2];
                double resistencia = (double)tabelinha.Rows[i][3];
                int titular = (int)tabelinha.Rows[i][4];
                string posicao = (string)tabelinha.Rows[i][5];
                int gols = (int)tabelinha.Rows[i][6];
                int cartaoamarelo = 0;
                int cartaovermelho = 0;

                Jogador jg = new Jogador(nome, ataque, defesa, resistencia, titular, posicao, cartaoamarelo, cartaovermelho, gols);

                TimeA.AdicionarJogador(jg);
            }
        }

        private void TimeTimeB()
        {
            string consulta = $"SELECT Jogador.Nome,Jogador_Especificacao.Ataque,Jogador_Especificacao.Defesa, Jogador_Especificacao.Resistencia, Jogador_Especificacao.Titularidade, Jogador_Especificacao.Posicao,Jogador_Especificacao.Gols FROM Jogador,Time,Jogador_Especificacao " +
                $"WHERE Time.Time_id = Jogador.Time_id " +
                $"AND Jogador.Especificacoes = Jogador_Especificacao.Especificacao_id " +
                $"AND Time.Time_Id = {timefora} ";

            DataTable tabelinha = gerenciador.ConsultarBanco(consulta);

            for (int i = 0; i < tabelinha.Rows.Count; i++)
            {
                string nome = tabelinha.Rows[i][0].ToString();
                int ataque = (int)tabelinha.Rows[i][1];
                int defesa = (int)tabelinha.Rows[i][2];
                double resistencia = (double)tabelinha.Rows[i][3];
                int titular = (int)tabelinha.Rows[i][4];
                string posicao = (string)tabelinha.Rows[i][5];
                int gols = (int)tabelinha.Rows[i][6];
                int cartaoamarelo = 0;
                int cartaovermelho = 0;

                Jogador jg = new Jogador(nome, ataque, defesa, resistencia, titular, posicao, cartaoamarelo, cartaovermelho, gols);

                TimeB.AdicionarJogador(jg);
            }
        }    

        private void AcabarPartida()
        {
            AtualizarGolsPartidaBD();
            AtualizarGolsJogadorBD();
            AtualizarGolsBD();
        }

        private void AtualizarGolsJogadorBD()
        {
            string update;

            for (int i = 0; i < TimeA.GetJogadoresTitulares().Count; i++)
            {
                update = $"UPDATE Jogador_Especificacao " +
            $"SET Gols = {TimeA.GetJogadoresTitulares()[i].GetGol()} " +
            $"WHERE Ataque = {TimeA.GetJogadoresTitulares()[i].GetAtaqueBruto()} " +
            $"AND Defesa = {TimeA.GetJogadoresTitulares()[i].GetDefesaBruta()} " +
            $"AND Resistencia = {TimeA.GetJogadoresTitulares()[i].GetResistencia()} " +
            $"AND Posicao = '{TimeA.GetJogadoresTitulares()[i].GetPosicao()}';";

                gerenciador.AtualizarBanco(update);
            }
            for (int i = 0; i < TimeA.GetJogadoresReservas().Count; i++)
            {
                update = $"UPDATE Jogador_Especificacao " +
           $"SET Gols = {TimeA.GetJogadoresReservas()[i].GetGol()} " +
           $"WHERE Ataque = {TimeA.GetJogadoresReservas()[i].GetAtaqueBruto()} " +
           $"AND Defesa = {TimeA.GetJogadoresReservas()[i].GetDefesaBruta()} " +
           $"AND Resistencia = {TimeA.GetJogadoresReservas()[i].GetResistencia()} " +
           $"AND Posicao = '{TimeA.GetJogadoresReservas()[i].GetPosicao()}';";

                gerenciador.AtualizarBanco(update);
            }
            for (int i = 0; i < TimeB.GetJogadoresTitulares().Count; i++)
            {
                update = $"UPDATE Jogador_Especificacao " +
            $"SET Gols = {TimeB.GetJogadoresTitulares()[i].GetGol()} " +
            $"WHERE Ataque = {TimeB.GetJogadoresTitulares()[i].GetAtaqueBruto()} " +
            $"AND Defesa = {TimeB.GetJogadoresTitulares()[i].GetDefesaBruta()} " +
            $"AND Resistencia = {TimeB.GetJogadoresTitulares()[i].GetResistencia()} " +
            $"AND Posicao = '{TimeB.GetJogadoresTitulares()[i].GetPosicao()}';";

                gerenciador.AtualizarBanco(update);
            }
            for (int i = 0; i < TimeB.GetJogadoresReservas().Count; i++)
            {
                update = $"UPDATE Jogador_Especificacao " +
                $"SET Gols = {TimeB.GetJogadoresReservas()[i].GetGol()} " +
                $"WHERE Ataque = {TimeB.GetJogadoresReservas()[i].GetAtaqueBruto()} " +
                $"AND Defesa = {TimeB.GetJogadoresReservas()[i].GetDefesaBruta()} " +
                $"AND Resistencia = {TimeB.GetJogadoresReservas()[i].GetResistencia()} " +
                $"AND Posicao = '{TimeB.GetJogadoresReservas()[i].GetPosicao()}';";

                gerenciador.AtualizarBanco(update);
            }


        }
        private void AtualizarGolsPartidaBD()
        {
            string update = "";
            update = $"UPDATE Estatistica_Time " +
                         $"SET GolsPro = {GolA} " +
                         $"WHERE Estatistica_id = {timecasa}";

            gerenciador.AtualizarBanco(update);

            update = $"UPDATE Estatistica_Time " +
             $"SET GoslContra = {GolB} " +
            $"WHERE Estatistica_id = {timecasa}";

            gerenciador.AtualizarBanco(update);
            update = $"UPDATE Estatistica_Time " +
            $"SET GolsPro = {GolB} " +
            $"WHERE Estatistica_id = {timefora}";

            gerenciador.AtualizarBanco(update);
            update = $"UPDATE Estatistica_Time " +
            $"SET GolsContra = {GolA} " +
            $"WHERE Estatistica_id = {timefora}";

            gerenciador.AtualizarBanco(update);

            update = $"UPDATE Partidas " +
                $"SET  Gols_timeCasa = {GolA} " +
                $"WHERE Partida_id = {partidaid}";

            update = $"UPDATE Partidas " +
                $"SET  Gols_timeFora = {GolB} " +
                $"WHERE Partida_id = {partidaid}";



        }
        private void AtualizarGolsBD()
        {
            string update = "";
            if (GolA > GolB)
            {
                update = $"UPDATE Estatistica_Time SET  Pontos = Pontos+3 WHERE Estatistica_id = {timecasa}";
                gerenciador.AtualizarBanco(update);
            }
            else if (GolA == GolB)
            {
                update = $"UPDATE Estatistica_Time SET  Pontos = Pontos+1 WHERE Estatistica_id = {timecasa}";
                gerenciador.AtualizarBanco(update);
                update = $"UPDATE Estatistica_Time SET  Pontos = Pontos+1 WHERE Estatistica_id = {timefora}";
                gerenciador.AtualizarBanco(update);
            }
            else if (GolA < GolB)
            {
                update = $"UPDATE Estatistica_Time SET  Pontos = Pontos+3 WHERE Estatistica_id = {timefora}";
                gerenciador.AtualizarBanco(update);
            }
        }
    }

        public enum TimeGol
        {
            TimeA,
            TimeB
        }
    }


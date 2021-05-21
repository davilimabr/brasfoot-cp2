using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp27
{
    class Time
    {
       

        private int NumMarc;

        private List<Jogador> jogadoresTitulares;
        private List<Jogador> jogadoresReservas;
        private int numexpulso = 0;
        private Marcacao Marcação = Marcacao.Equilibrado;
        private double MarcMomento = 2;
        private double MarcCartaoA = 0.03;
        private double MarcCartaoV = 0.01;
        private double MarcResist = 0.2;
        private EstilodeAtaque EstAtk = EstilodeAtaque.Equilibrado;

        public Time()
        {
            jogadoresTitulares = new List<Jogador>();
            jogadoresReservas = new List<Jogador>();
        }

        public enum Estilo
        {
            Ataque,
            Defesa
        }

        public enum Marcacao
        {
            Pesado,
            Equilibrado,
            Leve
        }

        public enum EstilodeAtaque
        {
            AtaqueTotal,
            Equilibrado,
            ContraAtaque
        }

        public Marcacao GetMarcacao()
        {
            return Marcação;
        }

        public void AdicionarJogador(Jogador jg)
        {
            //Verificar se existe
            for(int i=0;i<jogadoresTitulares.Count;i++)
            {
                if (jogadoresTitulares[i] == jg)
                {
                    jogadoresTitulares.RemoveAt(i);
                }
            }
            for (int i = 0; i < jogadoresReservas.Count; i++)
            {
                if (jogadoresReservas[i] == jg)
                {
                    jogadoresReservas.RemoveAt(i);
                }
            }

            //Adicionar
            if (jg.Titular)
                jogadoresTitulares.Add(jg);
            else
                jogadoresReservas.Add(jg);
        }

        public double CalcularMedias(Estilo a)
        {
            double media = 0;
            if(a==Estilo.Ataque)
            {                
                {
                    int soma = 0;
                    for (int i = 0; i < jogadoresTitulares.Count; i++)
                    {
                        if(jogadoresTitulares[i].GetPosicao() != "Goleiro")
                        soma += jogadoresTitulares[i].GetAtaque();
                    }

                    media = (soma / jogadoresTitulares.Count + numexpulso) - numexpulso * 10;
                }
                
            }

            else if (a == Estilo.Defesa)
            {
                int cont = 0;
                int soma = 0;
                for (int i = 0; i < jogadoresTitulares.Count; i++)
                {
                    if (jogadoresTitulares[i].GetPosicao() == "Goleiro")
                        cont++;

                    soma += jogadoresTitulares[i].GetDefesa();
                }
                media = (soma / jogadoresTitulares.Count + numexpulso) - numexpulso * 10;

                if (cont == 0)
                    media -= 10;
            }

            return media;
        }

        public void AlterarReservas(string a)
        {
            Jogador aux = null;

            foreach(Jogador i in jogadoresReservas)
            {
                if(i.GetNome()==a)
                {
                    i.Titular = true;
                    aux = i;                    
                }
            }

            AdicionarJogador(aux);
        }

        public void JogadorExpulso(string nomejogador)
        {
            for(int i=0 ; i < jogadoresTitulares.Count ; i++)
            {
                if(nomejogador == GetJogadoresTitulares()[i].GetNome())
                {
                    jogadoresTitulares.RemoveAt(i);
                    numexpulso++;
                }
            }
        }

        public void AlterarTitulares(string a)
        {
            Jogador aux = null;

            foreach (Jogador i in jogadoresTitulares)
            {
                if (i.GetNome() == a)
                {
                    i.Titular = false;
                    aux = i;
                }
            }

            AdicionarJogador(aux);
        }


        public List<Jogador> GetJogadoresTitulares()
        {
            return jogadoresTitulares;
        }

        public List<Jogador> GetJogadoresReservas()
        {
            return jogadoresReservas;
        }

        public void IncrementarExpulsao()
        {
            numexpulso++;
        }

        public void CansarJogadores()
        {
            foreach(Jogador jogador in jogadoresTitulares)
            {
                jogador.CansarJogador(MarcResist);
            }
        }

        public void DescansarJogadores()
        {
            foreach(Jogador jogador in jogadoresReservas)
            {
                jogador.DescansarJogador();
            }
        }

        public void VoltarTudo()
        {
            foreach(Jogador jogador in jogadoresTitulares)
            {
                jogador.VoltarStamina();
                jogador.VoltarEstado();
            }
            foreach (Jogador jogador in jogadoresReservas)
            {
                jogador.VoltarStamina();
                jogador.VoltarEstado();
            }
            numexpulso = 0;
        }

        public void SetMarcacao(string marc)
        {
            if(marc == "Pesado")
            {
                Marcação = Marcacao.Pesado;
                MarcMomento = 3;
                MarcCartaoA = 0.05;
                MarcCartaoV = 0.03;
                MarcResist = 0.3;
            }

            if (marc == "Equilibrado")
            {
                Marcação = Marcacao.Equilibrado;
                MarcMomento = 2;
                MarcCartaoA = 0.03;
                MarcCartaoV = 0.01;
                MarcResist = 0.2;
            }

            if (marc == "Leve")
            {
                Marcação = Marcacao.Leve;
                MarcMomento = 1;
                MarcCartaoA = 0.01;
                MarcCartaoV = 0.005;
                MarcResist = 0.1;
            }
        }

        public void SetEstilodeAtaque(string estatk)
        {
            if (estatk == "Ataque Total")
            {
                EstAtk = EstilodeAtaque.AtaqueTotal;
            }

            if (estatk == "Equilibrado")
            {
                EstAtk = EstilodeAtaque.Equilibrado;
            }

            if (estatk == "Contra-Ataque")
            {
                EstAtk = EstilodeAtaque.ContraAtaque;
            }
        }

        public EstilodeAtaque GetEstAtk()
        {
            return EstAtk;
        }

        public double GetMarcMomento()
        {
            return MarcMomento;
        }

        public double GetMarcCartaoA()
        {
            return MarcCartaoA;
        }

        public double GetMarcCartaoV()
        {
            return MarcCartaoV;
        }

        public double GetAtaqueFinal()
        {
            if (EstAtk == EstilodeAtaque.AtaqueTotal)
            {
                double ataque = ((CalcularMedias(Estilo.Ataque) * 1.05) / 100) -numexpulso * 10;
                return ataque;
            }

            else if (EstAtk == EstilodeAtaque.ContraAtaque)
            {
                double ataque = ((CalcularMedias(Estilo.Ataque) * 0.95) / 100) - numexpulso * 10;
                return ataque;
            }
            
            else
            {
                double ataque = (CalcularMedias(Estilo.Ataque) / 100) - numexpulso * 10;
                return ataque;
            }

        }

        public double GetDefesaFinal()
        {
            if (EstAtk == EstilodeAtaque.AtaqueTotal)
            {
                double defesa = ((CalcularMedias(Estilo.Defesa) * 0.95) / 100) - numexpulso * 10;
                return defesa;
            }

            else if (EstAtk == EstilodeAtaque.ContraAtaque)
            {
                double defesa = ((CalcularMedias(Estilo.Defesa) * 1.05) / 100) - numexpulso * 10;
                return defesa;
            }

            else
            {
                double defesa = (CalcularMedias(Estilo.Defesa) / 100) - numexpulso * 10;
                return defesa;
            }
        }
    }
}

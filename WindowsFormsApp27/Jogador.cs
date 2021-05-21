using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp27
{
    class Jogador
    {
        double Stamina = 1;
        string Nome = "";
        int Ataque = 0;
        int Defesa = 0;
        double Resistencia = 0;
        public bool Titular = false;
        private string Posição = "";
        int Cartaoamarelo = 0;
        int Cartaovermelho = 0;
        int Gols = 0;
        Cartao estado = Cartao.Limpo; 

        
        public enum Cartao
        {
            Limpo,
            Amarelado,
            Expulso,
            JaExpulso
        }

        public Jogador(string nome,int ataque,int defesa,double resistencia,int titular,string posi,int cartaoamarelo,int cartaovermelho,int gol)
        {
            Nome = nome;
            Ataque = ataque;
            Defesa = defesa;
            Resistencia = resistencia;
            SetTitular(titular);
            Posição = posi;
            Cartaoamarelo = cartaoamarelo;
            Cartaovermelho = cartaovermelho;
            Gols = gol;
        }

        public void AtualizarGol()
        {
            Gols=Gols+1;
        }

        private void SetTitular(int titular)
        {
            if (titular == 1)
                Titular = true;
            else
                Titular = false;
        }

        public int GetAtaque()
        {
            return Convert.ToInt32(Ataque * Stamina);
        }

        public int GetAtaqueBruto()
        {
            return Convert.ToInt32(Ataque);
        }

        public int GetDefesa()
        {
            return Convert.ToInt32(Defesa * Stamina);
        }

        public int GetDefesaBruta()
        {
            return Convert.ToInt32(Defesa);
        }

        public string GetNome()
        {
            return Nome;
        }

        public int GetGol()
        {
            return Gols;
        }

        public double GetResistencia()
        {
            return Resistencia;
        }

        public string GetPosicao()
        {
            return Posição;
        }

        public Cartao GetEstado()
        {
            return estado;
        }

        public double GetStamina()
        {
            return Stamina;
        }

        public void DarCartaoAmarelo ()
        {
            if (Cartaovermelho == 1)
            {
                estado = Cartao.JaExpulso;
            }

            else if (Cartaoamarelo == 1)
            {
                Cartaovermelho++;
                Cartaoamarelo++;
                estado = Cartao.Expulso;
            }

            else
            {
                Cartaoamarelo++;
                estado = Cartao.Amarelado;
            }
        }

        public void DarCartaoVermelho()
        {
            if (Cartaovermelho == 1)
            {
                estado = Cartao.JaExpulso;
            }

            else
            {
                Cartaovermelho++;
                estado = Cartao.Expulso;
            }
        }

        public void CansarJogador(double T)
        {
            if (Stamina > 0)
            {
                //y=-1(1-R)*0,3*T+1
                Stamina += -(1 - Resistencia) * (T * 1);

                if(Stamina < 0)
                {
                    Stamina = 0;
                }
            }
        }

        public void DescansarJogador()
        {
            if (Stamina < 1)
            {
                Stamina -= -(1 - Resistencia) * (0.2 * 1);

                if(Stamina > 1)
                {
                    Stamina = 1;
                }
            }            
        }

        public void VoltarStamina()
        {
            Stamina = 1;
        }

        public void VoltarEstado()
        {
            estado = Cartao.Limpo;
            Cartaoamarelo = 0;
            Cartaovermelho = 0;
        }
    }
}

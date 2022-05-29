using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    public class Elevador
    {
        public int AndarAtual { get; set; }
        public int TotalDeAndares { get; set; }
        public int CapacidadeDoElevador { get; set; }
        public int QuantidadeDePessoas { get; set; }

        public void Inicializar (int totalDeAndares, int capacidadeDoElevador)
        {
            this.TotalDeAndares = totalDeAndares;
            this.CapacidadeDoElevador = capacidadeDoElevador;
        }
        public void Entrar()
        {
            if (this.CapacidadeDoElevador < this.CapacidadeDoElevador)
            {
                this.CapacidadeDoElevador++;
            }
        }
        public void Sair()
        {
            if (this.CapacidadeDoElevador > 0)
            {
                this.CapacidadeDoElevador--;
            }
        }
        public void Subir()
        {
            if (this.AndarAtual < this.TotalDeAndares)
            {
                this.AndarAtual++;
            }
        }
        public void Descer()
        {
            if (this.AndarAtual > 0)
            {
                this.AndarAtual--;
            }
        }



    }

}



































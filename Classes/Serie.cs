using System;
namespace DIO.Series
{
    public class Serie: EntidadeBase
    {
        //Atributos

        private Genero Genero {get; set;}

        private string Titulo {get; set;}

        private string Descricao {get; set;}

        private int Ano {get; set;}

        private bool Excluido {get; set;}

        //Metodos

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Lançamento: " + this.Ano + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido;

            return retorno;
        }

        public string retornoTitulo()
        {
            return this.Titulo;
        }

        internal int retornoId()
        {
            return this.Id;
        }

        internal int retornoAno()
        {
            return this.Ano;
        }

        public bool retornoExcluido()
        {
            return this.Excluido;
        }

        public void Excluir(){

            this.Excluido = true;
        }
    }
}
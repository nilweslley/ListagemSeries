namespace Dio.Series
{
    public class Serie : EntidadeBase
    {
        // Atributos
        private Genero Genero { get; set; }

        private string Titulo { get; set; }

        private string Descrição { get; set; }

        private int Ano { get; set; }

        private bool Excluido { get; set; }

        //Métodos
        public Series(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descrição = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environnent.NewLine;
            retorno += "Título: " + this.Titulo + Environnent.NewLine;
            retorno += "Descrição: " + this.Descricao + Environnent.NewLine;
            retorno += "Ano de Início: " + this.Ano;
            return retorno;
        }

        public string retornaTitulo()
        {
            returnthis.Titulo;
        }

        internal int retornaId()
        {
            return this.Id;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}
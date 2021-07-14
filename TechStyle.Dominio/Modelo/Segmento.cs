namespace TechStyle.Dominio.Modelo
{
    public class Segmento
    {
        public int Id { get; set; }
        public string Categoria { get; private set; }
        public string SubCategoria { get; private set; }
        public bool Ativo { get; set; }


        internal void Cadastrar(int id, string categoria, string subcategoria)
        {
            Id = id;
            Categoria = categoria;
            SubCategoria = subcategoria;
            Ativo = true;
        }

        internal void Alterar(string categoria, string subCategoria)
        {
            Categoria = string.IsNullOrEmpty(categoria.Trim()) ? Categoria : categoria;
            SubCategoria = string.IsNullOrEmpty(subCategoria.Trim()) ? SubCategoria : subCategoria;
        }

        internal void AlterarStatus(bool ativo)
        {
            Ativo = ativo;
        }
    }
}

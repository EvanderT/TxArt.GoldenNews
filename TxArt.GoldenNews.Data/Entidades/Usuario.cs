using Microsoft.AspNetCore.Identity;

namespace TxArt.GoldenNews.Data.Entidades
{
    public class Usuario:IdentityUser
    {

        public Usuario()
        {
            Id = Guid.NewGuid().ToString();
            DataCadastro = DateTime.Now;
            Activo = true;
        }

        public string Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Activo { get; set; }
        public string FotoPerfilUrl { get; set; } = string.Empty;
        public string Nome { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; }
        public string Telefone { get; set; } = string.Empty;

        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();
        public List<Post> Posts { get; set; } = new List<Post>();
        public List<Reacao> Reacoes { get; set; } = new List<Reacao>();


        //Métodos
        public List<Post> BuscarPosts()
        {
            return Posts;
        }

        public List<Comentario> BuscarComentarios()
        {
            return Comentarios;
        }
    }
}

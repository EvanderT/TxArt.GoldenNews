using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string? FotoPerfilUrl { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string? Telefone { get; set; }

        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();
        public List<Post> Posts { get; set; } = new List<Post>();
        public List<Reacao> Reacoes { get; set; } = new List<Reacao>();


        //Métodos
        public List<Post> GetPosts()
        {
            return Posts;
        }
    }
}

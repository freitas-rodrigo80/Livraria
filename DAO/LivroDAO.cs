using Livraria.Infra;
using Livraria.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Livraria.DAO
{
    public class LivroDAO
    {
        public IList<Livro> Lista()
        {
            using (LivrariaContext contexto = new LivrariaContext())
            {
                var lista = contexto.Livros.OrderBy(l => l.Titulo).ToList();
                return lista;
            }

        }
        public void Adiciona(Livro livro)
        {
            using (LivrariaContext contexto = new LivrariaContext())
            {
                contexto.Livros.Add(livro);
                contexto.SaveChanges();
            }
        }

        public void Remove(int id)
        {
            using (LivrariaContext contexto = new LivrariaContext())
            {
                var livro = contexto.Livros.Find(id);
                contexto.Livros.Remove(livro);
                contexto.SaveChanges();
            }
        }

        public Livro BuscaPorId(int id)
        {
            using (LivrariaContext contexto = new LivrariaContext())
            {
                var livro = contexto.Livros.Find(id);
                return livro;
            }

        }

        public void Atualiza(Livro livro)
        {
            using (LivrariaContext contexto = new LivrariaContext())
            {
                contexto.Entry(livro).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Publica(int id)
        {
            using (LivrariaContext contexto = new LivrariaContext())
            {
                var livro = contexto.Livros.Find(id);
                livro.Publicado = true;
                livro.DataPublicacao = DateTime.Now;
                contexto.SaveChanges();
            }

        }

        public IList<string> ListaCategoriasQueContemTermo(string termo)
        {
            using (var contexto = new LivrariaContext())
            {
                return contexto.Livros
                .Where(l => l.Categoria.Contains(termo))
                .Select(l => l.Categoria)
                .Distinct()
                .ToList();
            }
        }
    }
}
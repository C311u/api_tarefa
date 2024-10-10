using api_tarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace api_tarefas.DBContext
{
    public class AppDBContext : DbContext
    {
        //Cria uma conexão com o BD
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        //Referência  das classes models para as tabelas do BD
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Tarefa> tarefa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarefa>()
                .HasOne(t => t.usuario)  //relação de apenas um usuário
                .WithMany(u => u.Tarefas) //relação de várias tarefas por usuário
                .HasForeignKey(t => t.fk_usuario) //condição de relação (chave etrangeira)
                .OnDelete(DeleteBehavior.Restrict); //condição de deletar usuários

            base.OnModelCreating(modelBuilder);
        }
    }
}

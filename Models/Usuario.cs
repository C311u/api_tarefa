using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_tarefas.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int id_usuario { get; set; }

        [Display(Name = "Nome do usuário")]
        [Required]
        public string nome_usuario { get; set;}

        [Display(Name = "Email do usuário")]
        [Required]
        public string email_usuario { get; set; }

        [Display(Name = "Senha do usuário")]
        [Required]
        public string senha_usuario { get; set; }

        //recurso de navegação (existência de relações)
        public ICollection<Tarefa> tarefas { get; set; } //ICollection<Tarefa> cria uma lista nomeada "Tarefa"

}

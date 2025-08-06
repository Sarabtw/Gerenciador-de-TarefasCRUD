using System.ComponentModel.DataAnnotations;
namespace app_tarefas.Models;

public class Tarefa
{

    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo Nome é obrigatório")]
    [MinLength(2, ErrorMessage = "Mínimo 2 caracteres.")]
    [MaxLength(100, ErrorMessage = "Máximo 100 caracteres")]
}
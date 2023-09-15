using System.ComponentModel.DataAnnotations;

namespace Sistema_de_Gerenciamento_de_Tarefas.Modelos;

public class TaskModel
 {
    public int Id { get; set; }

    [Required(ErrorMessage = "O título da tarefa é obrigatório.")]
    [StringLength(50, ErrorMessage = "O título deve ter no máximo 50 caracteres.")]
    public string Title { get; set; }

    [StringLength(500, ErrorMessage = "A descrição deve ter no máximo 500 caracteres.")]
    public string Description { get; set; }

    [Display(Name = "Data de Vencimento")]
    [DataType(DataType.Date)]
    [Required(ErrorMessage = "A data de vencimento é obrigatória.")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime DueDate { get; set; }

    [Display(Name = "Concluída")]
    public bool IsCompleted { get; set; }
}

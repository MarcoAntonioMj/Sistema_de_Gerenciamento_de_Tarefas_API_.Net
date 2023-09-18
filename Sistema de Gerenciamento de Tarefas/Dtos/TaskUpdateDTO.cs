namespace Sistema_de_Gerenciamento_de_Tarefas.Dtos;

public class TaskUpdateDTO
{
    public string Title { get; set; }
    public string Description { get; set;}
    public DateTime DueDate { get; set; }
    public bool IsCompleted { get; set; }


}

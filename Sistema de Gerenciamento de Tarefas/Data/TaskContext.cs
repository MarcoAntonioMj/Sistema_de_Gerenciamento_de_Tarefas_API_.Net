using Microsoft.EntityFrameworkCore;
using Sistema_de_Gerenciamento_de_Tarefas.Modelos;

namespace Sistema_de_Gerenciamento_de_Tarefas.Data;

public class TaskContext : DbContext
{

    public TaskContext(DbContextOptions<TaskContext> options)
        : base(options)
    {

    }

    public DbSet<TaskModel> TaskItems { get; set; }
}


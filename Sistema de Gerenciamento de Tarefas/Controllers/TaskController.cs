using Microsoft.AspNetCore.Mvc;
using Sistema_de_Gerenciamento_de_Tarefas.Data;
using Sistema_de_Gerenciamento_de_Tarefas.Dtos;
using Sistema_de_Gerenciamento_de_Tarefas.Modelos;
namespace Sistema_de_Gerenciamento_de_Tarefas.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // Rota da API, utilize "api" para indicar que é uma API REST
    public class TaskController : ControllerBase
    {
        private readonly TaskContext _context;

        public TaskController(TaskContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddTask([FromBody] TaskModel taskModel)
        {
            if (taskModel == null)
            {
                return BadRequest("Os dados da tarefa são inválidos."); // Verifica se os dados do modelo são nulos
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // Retorna erros de validação se o modelo não for válido
            }

            // Adicione a tarefa ao contexto e salve as alterações no banco de dados
            _context.TaskItems.Add(taskModel);
            _context.SaveChanges();

            // Retorne uma resposta HTTP 201 Created com os dados da tarefa criada
            return CreatedAtAction("GetTaskById", new { id = taskModel.Id }, taskModel);
        }


        [HttpGet("{id}", Name = "GetTaskById")] // Exemplo de ação para buscar uma tarefa pelo ID
        public IActionResult GetTaskById(int id)
        {
            var task = _context.TaskItems.Find(id);

            if (task == null)
            {
                return NotFound(); // Retorna HTTP 404 se a tarefa não for encontrada
            }

            return Ok(task); // Retorna HTTP 200 com os dados da tarefa
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTask(int id, [FromBody] TaskUpdateDTO taskUpdateDTO) 
        {
            if (taskUpdateDTO == null) 
            {
                return BadRequest("Os dados de atualização da tarefa são inválidos.");
            }

            if (!ModelState.IsValid) 
            {
                return BadRequest(ModelState);
            }

            var existingTask = _context.TaskItems.Find(id);

            if (existingTask == null)
            {
                return NotFound();
            }
            // Atualize os campos da tarefa existente com os dados do DTO

            existingTask.Title = taskUpdateDTO.Title;
            existingTask.Description = taskUpdateDTO.Description;
            existingTask.DueDate = taskUpdateDTO.DueDate;
            existingTask.IsCompleted = taskUpdateDTO.IsCompleted;

            _context.SaveChanges();

            return NoContent(); // Retorna HTTP 204 (sem conteúdo) para indicar que a atualização foi bem-sucedida

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id)
        {
            var task = _context.TaskItems.Find(id);

            if (task == null)
            {
                return NotFound(); // Retorna HTTP 404 se a tarefa não for encontrada
            }

            _context.TaskItems.Remove(task);
            _context.SaveChanges();

            return NoContent(); // Retorna HTTP 204 (sem conteúdo) para indicar que a exclusão foi bem-sucedida
        }
    }
}

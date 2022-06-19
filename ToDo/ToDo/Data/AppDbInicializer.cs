using ToDo.Models;

namespace ToDo.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppCont>();
                context.Database.EnsureCreated();

                //Criar as tarefas
                if (!context.Tarefas.Any())
                {
                    context.Tarefas.AddRange(new List<Tarefa>()
                    {
                        new Tarefa()
                        {
                            
                            Name = "Renaira Fofa meu coracao",
                            EndData = DateTime.Now.AddDays(2),
                            Status = false

                        },
                          new Tarefa()
                        {
                            Name = "Voce é linda dimais",
                            EndData = DateTime.Now.AddDays(3),
                            Status = false

                        },
                            new Tarefa()
                        {
                            Name = "Te amo amo amo",
                            EndData = DateTime.Now.AddDays(10),
                            Status = false

                        }

                    });
                    context.SaveChanges();

                }

            }
        }
    }
}

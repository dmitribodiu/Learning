using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var options = new DbContextOptionsBuilder<TasksDbContext>()
                .UseSqlServer("Server=localhost,5433;Database=tasks;User Id=sa;Password=Pass@word;TrustServerCertificate=True")
                .Options;

            // show all tasks
            List<Task> tasks;
            using (var dbContext = new TasksDbContext(options))
            {
                tasks = dbContext.Tasks.ToList();
            }

            foreach (var task in tasks)
            {
                Console.WriteLine($"{task.Id} --- {task.Name} --- {task.IsFinished}");
            }


            // add task
            using (var dbContext = new TasksDbContext(options))
            {
                dbContext.Tasks.Add(new Task
                {
                    Name = "Hello from c#",
                    IsFinished = false
                });

                dbContext.SaveChanges();
            }

            //// remove task
            //using (var dbContext = new TasksDbContext(options))
            //{
            //    var taskToRemove = dbContext.Tasks.SingleOrDefault(x => x.Name == "Hello from c#");
            //    dbContext.Tasks.Remove(taskToRemove);
            //    dbContext.SaveChanges();
            //}

            // update
            using (var dbContext = new TasksDbContext(options))
            {
                var taskToUpdate = dbContext.Tasks.SingleOrDefault(x => x.Name == "Hello from c#");

                taskToUpdate.IsFinished = true;

                dbContext.SaveChanges();
            }

            Console.WriteLine("Hello, World!");
        }
    }

    public class TasksDbContext : DbContext
    {
        public TasksDbContext(DbContextOptions<TasksDbContext> options) : base(options)
        {
            
        }

        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TaskConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }

    public class Task
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsFinished { get; set; }
    }

    public class TaskConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(50);
        }
    }

    public class TasksContextFactory : IDesignTimeDbContextFactory<TasksDbContext>
    {
        public TasksDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TasksDbContext>();
            optionsBuilder.UseSqlServer("Server=sqlserver;Database=tasks;User Id=sa;Password=Pass@word;");

            return new TasksDbContext(optionsBuilder.Options);
        }
    }
}
using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu projeto ASPNET Core 1", "Minha Descricao de Projeto 1", 1, 1, 10000 ),
                new Project("Meu projeto ASPNET Core 2", "Minha Descricao de Projeto 2", 1, 1, 20000 ),
                new Project("Meu projeto ASPNET Core 3", "Minha Descricao de Projeto 3", 1, 1, 30000 )
            };

            Users = new List<User>
            {
                new User("Daniel Peralba", "daniel@gmail.com", new DateTime(2001, 10, 22)),
                new User("John Doe", "johndoe@gmail.com", new DateTime(2000, 10, 22)),
                new User("Ayrton Senna", "ayrton@gmail.com", new DateTime(2002, 10, 22))
            };

            Skills = new List<Skill>
            {
                new Skill(".NET Core"),
                new Skill(".C#"),
                new Skill("SQL")
            };
        }
        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
        public List<ProjectComment> ProjectComments { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using WebAPI.DAL.Entities;

namespace WebAPI.DAL.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<Application> Applications { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) // Only configure if not already configured
            {
                optionsBuilder.UseSqlServer("server=L-REMONDA; database=JobPortal; user id=sa; password=123; integrated security = true");

            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Job>()
                .HasData(new Job
                {
                    JobId = 1,
                    Company = "Coptic Orphans",
                    Title = "Full Stack Developer",
                    Location = "Cairo, Egypt (Onsite)",
                    Description = "Essential Functions and Responsibilities : Develop and maintain front-end and back-end aspects of web applications. Design and implement responsive user interfaces using modern web technologies such as HTML5, CSS3, and JavaScript frameworks (e.g. Angular, Vue.js).",
                    Requirements = "Bachelor's degree in computer engineering, computer science, information systems management, or related fields. 2-4 years of related professional experience. Must have 2+ years of Net Core experience",
                    Photo = "logo.jpg"
                },
               new Job
               {
                   JobId = 2,
                   Company = "Oliv",
                   Title = "Senior Backend Developer",
                   Location = "Cairo, Egypt (Hybrid)",
                   Description = "Do you enjoy solving complex problems and designing scalable systems? Are you a team player who is versatile, curious to learn, and delivers high quality work? Do you want to have positive impact on the world around you?",
                   Requirements = "4-7 years of software engineering experience, with a focus on backend development. solid computer science background with sound understanding of algorithms and information security. solid understanding of data modeling, query optimization, and database performance tuning."
               ,
                   Photo = "olivlogo.jpg"
               },
               new Job
               {
                   JobId = 3,
                   Company = "DualEntry",
                   Title = "Senior Backend Engineer",
                   Location = "Egypt (Remote)",
                   Description = "Our Founders started their previous company after meeting while coding in Computer Science class. With just $2,000 in savings, the two bootstrapped their first company to $25 million in ARR - and profitably - in just 5 years.",
                   Requirements = "8+ yrs of total backend software development experience incl. testing. Experience managing long-term software development complexity in a business-logic heavy project."
             ,
                   Photo = "dualentry_logo.jpg"
               },
               new Job
               {
                   JobId = 4,
                   Company = "BlackStone eIT",
                   Title = "Backend Developer (.Net)",
                   Location = "Cairo,Egypt (Remote)",
                   Description = "BlackStone eIT, a leading computer software company, is currently seeking a highly skilled and motivated Backend Developer with expertise in .Net to join our talented team. ",
                   Requirements = "Bachelor's degree in Computer Science or a related field. 4+ years of experience in backend development using .Net. Proficiency in C# and ASP.Net"
               ,
                   Photo = "blackstoneeit_logo.jpg"
               },
               new Job
               {
                   JobId = 5,
                   Company = "Docspert Health",
                   Title = "Junior Django Developer",
                   Location = "Cairo,Egypt (Hybrid)",
                   Description = "Contribute to the development of both frontend and backend components for web applications using Django and Python. Work closely with senior developers to integrate user-facing elements with server-side logic seamlessly.",
                   Requirements = "Basic proficiency in Django and Python, with a willingness to learn and grow.  Exposure to frontend technologies, including JavaScript, HTML5, and CSS3."
              ,
                   Photo = "docspert_logo.jpg"
               },
               new Job
               {
                   JobId = 6,
                   Company = "Vezeeta",
                   Title = "Backend Engineer",
                   Location = "Cairo,Egypt (Hybrid)",
                   Description = "Vezeeta is a groundbreaking healthcare startup in MENA, with over three million users, a growing portfolio of products, and an expanding geographical footprint. As talent flocks to land in our nest, we single out the most promising caliber and set of skills that would add value and diversity to our team in the MENA region.",
                   Requirements = "Bachelor's degree of Computer Science or Computer Engineering from a reputable university. 2+ years of experience in Back-End engineering. Strong knowledge and first-hand experience in C#, MySQL and SQL Server Development."
              ,
                   Photo = "Vezeeta.jpg"
               }

                );
        }
    }
}

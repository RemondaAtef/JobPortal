using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    public partial class seedNewData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    JobId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Requirements = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.JobId);
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Applications_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "JobId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "JobId", "Company", "Description", "Location", "Photo", "Requirements", "Title" },
                values: new object[,]
                {
                    { 1, "Coptic Orphans", "Essential Functions and Responsibilities : Develop and maintain front-end and back-end aspects of web applications. Design and implement responsive user interfaces using modern web technologies such as HTML5, CSS3, and JavaScript frameworks (e.g. Angular, Vue.js).", "Cairo, Egypt (Onsite)", "logo.jpg", "Bachelor's degree in computer engineering, computer science, information systems management, or related fields. 2-4 years of related professional experience. Must have 2+ years of Net Core experience", "Full Stack Developer" },
                    { 2, "Oliv", "Do you enjoy solving complex problems and designing scalable systems? Are you a team player who is versatile, curious to learn, and delivers high quality work? Do you want to have positive impact on the world around you?", "Cairo, Egypt (Hybrid)", "olivlogo.jpg", "4-7 years of software engineering experience, with a focus on backend development. solid computer science background with sound understanding of algorithms and information security. solid understanding of data modeling, query optimization, and database performance tuning.", "Senior Backend Developer" },
                    { 3, "DualEntry", "Our Founders started their previous company after meeting while coding in Computer Science class. With just $2,000 in savings, the two bootstrapped their first company to $25 million in ARR - and profitably - in just 5 years.", "Egypt (Remote)", "dualentry_logo.jpg", "8+ yrs of total backend software development experience incl. testing. Experience managing long-term software development complexity in a business-logic heavy project.", "Senior Backend Engineer" },
                    { 4, "BlackStone eIT", "BlackStone eIT, a leading computer software company, is currently seeking a highly skilled and motivated Backend Developer with expertise in .Net to join our talented team. ", "Cairo,Egypt (Remote)", "blackstoneeit_logo.jpg", "Bachelor's degree in Computer Science or a related field. 4+ years of experience in backend development using .Net. Proficiency in C# and ASP.Net", "Backend Developer (.Net)" },
                    { 5, "Docspert Health", "Contribute to the development of both frontend and backend components for web applications using Django and Python. Work closely with senior developers to integrate user-facing elements with server-side logic seamlessly.", "Cairo,Egypt (Hybrid)", "docspert_logo.jpg", "Basic proficiency in Django and Python, with a willingness to learn and grow.  Exposure to frontend technologies, including JavaScript, HTML5, and CSS3.", "Junior Django Developer" },
                    { 6, "Vezeeta", "Vezeeta is a groundbreaking healthcare startup in MENA, with over three million users, a growing portfolio of products, and an expanding geographical footprint. As talent flocks to land in our nest, we single out the most promising caliber and set of skills that would add value and diversity to our team in the MENA region.", "Cairo,Egypt (Hybrid)", "Vezeeta.jpg", "Bachelor's degree of Computer Science or Computer Engineering from a reputable university. 2+ years of experience in Back-End engineering. Strong knowledge and first-hand experience in C#, MySQL and SQL Server Development.", "Backend Engineer" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_JobId",
                table: "Applications",
                column: "JobId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "Jobs");
        }
    }
}

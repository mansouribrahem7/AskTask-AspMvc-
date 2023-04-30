using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Final_Project.Migrations
{
    public partial class newTrial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskDoers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    SalaryPerHour = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskDoers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskPosters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<int>(type: "integer", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskPosters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: false),
                    Street = table.Column<string>(type: "text", nullable: false),
                    MinimumAmount = table.Column<double>(type: "double precision", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Documentations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: true),
                    DoerId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documentations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documentations_TaskDoers_DoerId",
                        column: x => x.DoerId,
                        principalTable: "TaskDoers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkillTaskDoer",
                columns: table => new
                {
                    SkillsId = table.Column<int>(type: "integer", nullable: false),
                    taskDoersId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillTaskDoer", x => new { x.SkillsId, x.taskDoersId });
                    table.ForeignKey(
                        name: "FK_SkillTaskDoer_Skills_SkillsId",
                        column: x => x.SkillsId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillTaskDoer_TaskDoers_taskDoersId",
                        column: x => x.taskDoersId,
                        principalTable: "TaskDoers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PaymentAmount = table.Column<double>(type: "double precision", nullable: false),
                    TaskPosterID = table.Column<int>(type: "integer", nullable: false),
                    TaskDoerID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_TaskDoers_TaskDoerID",
                        column: x => x.TaskDoerID,
                        principalTable: "TaskDoers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_TaskPosters_TaskPosterID",
                        column: x => x.TaskPosterID,
                        principalTable: "TaskPosters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PosterName = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    mail = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    ServiceType = table.Column<string>(type: "text", nullable: false),
                    TaskPosterId = table.Column<int>(type: "integer", nullable: false),
                    TaskId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_TaskPosters_TaskPosterId",
                        column: x => x.TaskPosterId,
                        principalTable: "TaskPosters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskTaskDoer",
                columns: table => new
                {
                    TaskdoersId = table.Column<int>(type: "integer", nullable: false),
                    TasksId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskTaskDoer", x => new { x.TaskdoersId, x.TasksId });
                    table.ForeignKey(
                        name: "FK_TaskTaskDoer_TaskDoers_TaskdoersId",
                        column: x => x.TaskdoersId,
                        principalTable: "TaskDoers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskTaskDoer_Tasks_TasksId",
                        column: x => x.TasksId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskTaskPoster",
                columns: table => new
                {
                    taskPostersId = table.Column<int>(type: "integer", nullable: false),
                    tasksId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskTaskPoster", x => new { x.taskPostersId, x.tasksId });
                    table.ForeignKey(
                        name: "FK_TaskTaskPoster_TaskPosters_taskPostersId",
                        column: x => x.taskPostersId,
                        principalTable: "TaskPosters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskTaskPoster_Tasks_tasksId",
                        column: x => x.tasksId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Documentations_DoerId",
                table: "Documentations",
                column: "DoerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TaskId",
                table: "Orders",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TaskPosterId",
                table: "Orders",
                column: "TaskPosterId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_TaskDoerID",
                table: "Payments",
                column: "TaskDoerID");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_TaskPosterID",
                table: "Payments",
                column: "TaskPosterID");

            migrationBuilder.CreateIndex(
                name: "IX_SkillTaskDoer_taskDoersId",
                table: "SkillTaskDoer",
                column: "taskDoersId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskTaskDoer_TasksId",
                table: "TaskTaskDoer",
                column: "TasksId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskTaskPoster_tasksId",
                table: "TaskTaskPoster",
                column: "tasksId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documentations");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "SkillTaskDoer");

            migrationBuilder.DropTable(
                name: "TaskTaskDoer");

            migrationBuilder.DropTable(
                name: "TaskTaskPoster");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "TaskDoers");

            migrationBuilder.DropTable(
                name: "TaskPosters");

            migrationBuilder.DropTable(
                name: "Tasks");
        }
    }
}

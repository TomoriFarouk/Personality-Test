using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonalityTest.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "teamWorks",
                columns: table => new
                {
                    TeamworkId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TeamWork1 = table.Column<int>(nullable: false),
                    TeamWork2 = table.Column<int>(nullable: false),
                    TeamWork3 = table.Column<int>(nullable: false),
                    TeamWork4 = table.Column<int>(nullable: false),
                    TeamWork5 = table.Column<int>(nullable: false),
                    TeamWork6 = table.Column<int>(nullable: false),
                    TeamWork7 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teamWorks", x => x.TeamworkId);
                });

            migrationBuilder.CreateTable(
                name: "shapers",
                columns: table => new
                {
                    ShaperId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Shaper1 = table.Column<int>(nullable: false),
                    Shaper2 = table.Column<int>(nullable: false),
                    Shaper3 = table.Column<int>(nullable: false),
                    Shaper4 = table.Column<int>(nullable: false),
                    Shaper5 = table.Column<int>(nullable: false),
                    Shaper6 = table.Column<int>(nullable: false),
                    Shaper7 = table.Column<int>(nullable: false),
                    TeamworkId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shapers", x => x.ShaperId);
                    table.ForeignKey(
                        name: "FK_shapers_teamWorks_TeamworkId",
                        column: x => x.TeamworkId,
                        principalTable: "teamWorks",
                        principalColumn: "TeamworkId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "resources",
                columns: table => new
                {
                    ResourceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Resource1 = table.Column<int>(nullable: false),
                    Resource2 = table.Column<int>(nullable: false),
                    Resource3 = table.Column<int>(nullable: false),
                    Resource4 = table.Column<int>(nullable: false),
                    Resource5 = table.Column<int>(nullable: false),
                    Resource6 = table.Column<int>(nullable: false),
                    Resource7 = table.Column<int>(nullable: false),
                    ShaperId = table.Column<int>(nullable: true),
                    TeamworkId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resources", x => x.ResourceId);
                    table.ForeignKey(
                        name: "FK_resources_shapers_ShaperId",
                        column: x => x.ShaperId,
                        principalTable: "shapers",
                        principalColumn: "ShaperId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_resources_teamWorks_TeamworkId",
                        column: x => x.TeamworkId,
                        principalTable: "teamWorks",
                        principalColumn: "TeamworkId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "planters",
                columns: table => new
                {
                    PlanterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Planter1 = table.Column<int>(nullable: false),
                    Planter2 = table.Column<int>(nullable: false),
                    Planter3 = table.Column<int>(nullable: false),
                    Planter4 = table.Column<int>(nullable: false),
                    Planter5 = table.Column<int>(nullable: false),
                    Planter6 = table.Column<int>(nullable: false),
                    Planter7 = table.Column<int>(nullable: false),
                    ResourceId = table.Column<int>(nullable: true),
                    ShaperId = table.Column<int>(nullable: true),
                    TeamworkId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_planters", x => x.PlanterId);
                    table.ForeignKey(
                        name: "FK_planters_resources_ResourceId",
                        column: x => x.ResourceId,
                        principalTable: "resources",
                        principalColumn: "ResourceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_planters_shapers_ShaperId",
                        column: x => x.ShaperId,
                        principalTable: "shapers",
                        principalColumn: "ShaperId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_planters_teamWorks_TeamworkId",
                        column: x => x.TeamworkId,
                        principalTable: "teamWorks",
                        principalColumn: "TeamworkId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "implementers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Implementer1 = table.Column<int>(nullable: false),
                    Implementer2 = table.Column<int>(nullable: false),
                    Implementer3 = table.Column<int>(nullable: false),
                    Implementer4 = table.Column<int>(nullable: false),
                    Implementer5 = table.Column<int>(nullable: false),
                    Implementer6 = table.Column<int>(nullable: false),
                    Implementer7 = table.Column<int>(nullable: false),
                    PlanterId = table.Column<int>(nullable: true),
                    ResourceId = table.Column<int>(nullable: true),
                    ShaperId = table.Column<int>(nullable: true),
                    TeamworkId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_implementers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_implementers_planters_PlanterId",
                        column: x => x.PlanterId,
                        principalTable: "planters",
                        principalColumn: "PlanterId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_implementers_resources_ResourceId",
                        column: x => x.ResourceId,
                        principalTable: "resources",
                        principalColumn: "ResourceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_implementers_shapers_ShaperId",
                        column: x => x.ShaperId,
                        principalTable: "shapers",
                        principalColumn: "ShaperId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_implementers_teamWorks_TeamworkId",
                        column: x => x.TeamworkId,
                        principalTable: "teamWorks",
                        principalColumn: "TeamworkId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "finishers",
                columns: table => new
                {
                    FinisherId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Finisher1 = table.Column<int>(nullable: false),
                    Finisher2 = table.Column<int>(nullable: false),
                    Finisher3 = table.Column<int>(nullable: false),
                    Finisher4 = table.Column<int>(nullable: false),
                    Finisher5 = table.Column<int>(nullable: false),
                    Finisher6 = table.Column<int>(nullable: false),
                    Finisher7 = table.Column<int>(nullable: false),
                    implementerId = table.Column<int>(nullable: true),
                    PlanterId = table.Column<int>(nullable: true),
                    ResourceId = table.Column<int>(nullable: true),
                    ShaperId = table.Column<int>(nullable: true),
                    TeamworkId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_finishers", x => x.FinisherId);
                    table.ForeignKey(
                        name: "FK_finishers_planters_PlanterId",
                        column: x => x.PlanterId,
                        principalTable: "planters",
                        principalColumn: "PlanterId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_finishers_resources_ResourceId",
                        column: x => x.ResourceId,
                        principalTable: "resources",
                        principalColumn: "ResourceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_finishers_shapers_ShaperId",
                        column: x => x.ShaperId,
                        principalTable: "shapers",
                        principalColumn: "ShaperId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_finishers_teamWorks_TeamworkId",
                        column: x => x.TeamworkId,
                        principalTable: "teamWorks",
                        principalColumn: "TeamworkId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_finishers_implementers_implementerId",
                        column: x => x.implementerId,
                        principalTable: "implementers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "coordinators",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Coordinator1 = table.Column<int>(nullable: false),
                    Coordinator2 = table.Column<int>(nullable: false),
                    Coordinator3 = table.Column<int>(nullable: false),
                    Coordinator4 = table.Column<int>(nullable: false),
                    Coordinator5 = table.Column<int>(nullable: false),
                    Coordinator6 = table.Column<int>(nullable: false),
                    Coordinator7 = table.Column<int>(nullable: false),
                    FinisherId = table.Column<int>(nullable: true),
                    implementerId = table.Column<int>(nullable: true),
                    PlanterId = table.Column<int>(nullable: true),
                    ResourceId = table.Column<int>(nullable: true),
                    ShaperId = table.Column<int>(nullable: true),
                    TeamworkId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coordinators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_coordinators_finishers_FinisherId",
                        column: x => x.FinisherId,
                        principalTable: "finishers",
                        principalColumn: "FinisherId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_coordinators_planters_PlanterId",
                        column: x => x.PlanterId,
                        principalTable: "planters",
                        principalColumn: "PlanterId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_coordinators_resources_ResourceId",
                        column: x => x.ResourceId,
                        principalTable: "resources",
                        principalColumn: "ResourceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_coordinators_shapers_ShaperId",
                        column: x => x.ShaperId,
                        principalTable: "shapers",
                        principalColumn: "ShaperId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_coordinators_teamWorks_TeamworkId",
                        column: x => x.TeamworkId,
                        principalTable: "teamWorks",
                        principalColumn: "TeamworkId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_coordinators_implementers_implementerId",
                        column: x => x.implementerId,
                        principalTable: "implementers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_coordinators_FinisherId",
                table: "coordinators",
                column: "FinisherId");

            migrationBuilder.CreateIndex(
                name: "IX_coordinators_PlanterId",
                table: "coordinators",
                column: "PlanterId");

            migrationBuilder.CreateIndex(
                name: "IX_coordinators_ResourceId",
                table: "coordinators",
                column: "ResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_coordinators_ShaperId",
                table: "coordinators",
                column: "ShaperId");

            migrationBuilder.CreateIndex(
                name: "IX_coordinators_TeamworkId",
                table: "coordinators",
                column: "TeamworkId");

            migrationBuilder.CreateIndex(
                name: "IX_coordinators_implementerId",
                table: "coordinators",
                column: "implementerId");

            migrationBuilder.CreateIndex(
                name: "IX_finishers_PlanterId",
                table: "finishers",
                column: "PlanterId");

            migrationBuilder.CreateIndex(
                name: "IX_finishers_ResourceId",
                table: "finishers",
                column: "ResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_finishers_ShaperId",
                table: "finishers",
                column: "ShaperId");

            migrationBuilder.CreateIndex(
                name: "IX_finishers_TeamworkId",
                table: "finishers",
                column: "TeamworkId");

            migrationBuilder.CreateIndex(
                name: "IX_finishers_implementerId",
                table: "finishers",
                column: "implementerId");

            migrationBuilder.CreateIndex(
                name: "IX_implementers_PlanterId",
                table: "implementers",
                column: "PlanterId");

            migrationBuilder.CreateIndex(
                name: "IX_implementers_ResourceId",
                table: "implementers",
                column: "ResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_implementers_ShaperId",
                table: "implementers",
                column: "ShaperId");

            migrationBuilder.CreateIndex(
                name: "IX_implementers_TeamworkId",
                table: "implementers",
                column: "TeamworkId");

            migrationBuilder.CreateIndex(
                name: "IX_planters_ResourceId",
                table: "planters",
                column: "ResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_planters_ShaperId",
                table: "planters",
                column: "ShaperId");

            migrationBuilder.CreateIndex(
                name: "IX_planters_TeamworkId",
                table: "planters",
                column: "TeamworkId");

            migrationBuilder.CreateIndex(
                name: "IX_resources_ShaperId",
                table: "resources",
                column: "ShaperId");

            migrationBuilder.CreateIndex(
                name: "IX_resources_TeamworkId",
                table: "resources",
                column: "TeamworkId");

            migrationBuilder.CreateIndex(
                name: "IX_shapers_TeamworkId",
                table: "shapers",
                column: "TeamworkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "coordinators");

            migrationBuilder.DropTable(
                name: "finishers");

            migrationBuilder.DropTable(
                name: "implementers");

            migrationBuilder.DropTable(
                name: "planters");

            migrationBuilder.DropTable(
                name: "resources");

            migrationBuilder.DropTable(
                name: "shapers");

            migrationBuilder.DropTable(
                name: "teamWorks");
        }
    }
}

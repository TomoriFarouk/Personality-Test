using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonalityTest.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "sectionGs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Shaper7 = table.Column<int>(nullable: false),
                    Coordinator7 = table.Column<int>(nullable: false),
                    Planter7 = table.Column<int>(nullable: false),
                    Resource7 = table.Column<int>(nullable: false),
                    Monitor7 = table.Column<int>(nullable: false),
                    Implementer7 = table.Column<int>(nullable: false),
                    Teamwork7 = table.Column<int>(nullable: false),
                    Finisher7 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sectionGs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sectionBs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Shaper2 = table.Column<int>(nullable: false),
                    Coordinator2 = table.Column<int>(nullable: false),
                    Planter2 = table.Column<int>(nullable: false),
                    Resource2 = table.Column<int>(nullable: false),
                    Monitor2 = table.Column<int>(nullable: false),
                    Implementer2 = table.Column<int>(nullable: false),
                    Teamwork2 = table.Column<int>(nullable: false),
                    Finisher2 = table.Column<int>(nullable: false),
                    sectionHId = table.Column<int>(nullable: true),
                    sectionFId = table.Column<int>(nullable: true),
                    sectionCId = table.Column<int>(nullable: true),
                    sectionDId = table.Column<int>(nullable: true),
                    sectionAId = table.Column<int>(nullable: true),
                    sectionGId = table.Column<int>(nullable: true),
                    sectionEId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sectionBs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sectionBs_sectionGs_sectionGId",
                        column: x => x.sectionGId,
                        principalTable: "sectionGs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "sectionCs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Shaper3 = table.Column<int>(nullable: false),
                    Coordinator3 = table.Column<int>(nullable: false),
                    Planter3 = table.Column<int>(nullable: false),
                    Resource3 = table.Column<int>(nullable: false),
                    Monitor3 = table.Column<int>(nullable: false),
                    Implementer3 = table.Column<int>(nullable: false),
                    Teamwork3 = table.Column<int>(nullable: false),
                    Finisher3 = table.Column<int>(nullable: false),
                    sectionHsId = table.Column<int>(nullable: true),
                    sectionEsId = table.Column<int>(nullable: true),
                    sectionDId = table.Column<int>(nullable: true),
                    sectionAId = table.Column<int>(nullable: true),
                    sectionGId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sectionCs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sectionCs_sectionGs_sectionGId",
                        column: x => x.sectionGId,
                        principalTable: "sectionGs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "sectionDs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Shaper4 = table.Column<int>(nullable: false),
                    Coordinator4 = table.Column<int>(nullable: false),
                    Planter4 = table.Column<int>(nullable: false),
                    Resource4 = table.Column<int>(nullable: false),
                    Monitor4 = table.Column<int>(nullable: false),
                    Implementer4 = table.Column<int>(nullable: false),
                    Teamwork4 = table.Column<int>(nullable: false),
                    Finisher4 = table.Column<int>(nullable: false),
                    sectionAId = table.Column<int>(nullable: true),
                    sectionGId = table.Column<int>(nullable: true),
                    SectionDId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sectionDs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sectionDs_sectionDs_SectionDId",
                        column: x => x.SectionDId,
                        principalTable: "sectionDs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_sectionDs_sectionGs_sectionGId",
                        column: x => x.sectionGId,
                        principalTable: "sectionGs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "sectionEs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Shaper5 = table.Column<int>(nullable: false),
                    Coordinator5 = table.Column<int>(nullable: false),
                    Planter5 = table.Column<int>(nullable: false),
                    Resource5 = table.Column<int>(nullable: false),
                    Monitor5 = table.Column<int>(nullable: false),
                    Implementer5 = table.Column<int>(nullable: false),
                    Teamwork5 = table.Column<int>(nullable: false),
                    Finisher5 = table.Column<int>(nullable: false),
                    sectionDId = table.Column<int>(nullable: true),
                    sectionAId = table.Column<int>(nullable: true),
                    sectionGId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sectionEs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sectionEs_sectionDs_sectionDId",
                        column: x => x.sectionDId,
                        principalTable: "sectionDs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_sectionEs_sectionGs_sectionGId",
                        column: x => x.sectionGId,
                        principalTable: "sectionGs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "sectionFs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Shaper6 = table.Column<int>(nullable: false),
                    Coordinator6 = table.Column<int>(nullable: false),
                    Planter6 = table.Column<int>(nullable: false),
                    Resource6 = table.Column<int>(nullable: false),
                    Monitor6 = table.Column<int>(nullable: false),
                    Implementer6 = table.Column<int>(nullable: false),
                    Teamwork6 = table.Column<int>(nullable: false),
                    Finisher6 = table.Column<int>(nullable: false),
                    sectionCsId = table.Column<int>(nullable: true),
                    sectionEsId = table.Column<int>(nullable: true),
                    sectionDId = table.Column<int>(nullable: true),
                    sectionGId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sectionFs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sectionFs_sectionCs_sectionCsId",
                        column: x => x.sectionCsId,
                        principalTable: "sectionCs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_sectionFs_sectionDs_sectionDId",
                        column: x => x.sectionDId,
                        principalTable: "sectionDs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_sectionFs_sectionEs_sectionEsId",
                        column: x => x.sectionEsId,
                        principalTable: "sectionEs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_sectionFs_sectionGs_sectionGId",
                        column: x => x.sectionGId,
                        principalTable: "sectionGs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SectionH",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Shaper8 = table.Column<int>(nullable: false),
                    Coordinator8 = table.Column<int>(nullable: false),
                    Planter8 = table.Column<int>(nullable: false),
                    Resource8 = table.Column<int>(nullable: false),
                    Monitor8 = table.Column<int>(nullable: false),
                    Implementer8 = table.Column<int>(nullable: false),
                    Teamwork8 = table.Column<int>(nullable: false),
                    Finisher8 = table.Column<int>(nullable: false),
                    sectionFsId = table.Column<int>(nullable: true),
                    sectionEsId = table.Column<int>(nullable: true),
                    sectionDId = table.Column<int>(nullable: true),
                    sectionGId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionH", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SectionH_sectionDs_sectionDId",
                        column: x => x.sectionDId,
                        principalTable: "sectionDs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SectionH_sectionEs_sectionEsId",
                        column: x => x.sectionEsId,
                        principalTable: "sectionEs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SectionH_sectionFs_sectionFsId",
                        column: x => x.sectionFsId,
                        principalTable: "sectionFs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SectionH_sectionGs_sectionGId",
                        column: x => x.sectionGId,
                        principalTable: "sectionGs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "sectionAs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Shaper1 = table.Column<int>(nullable: false),
                    Coordinator1 = table.Column<int>(nullable: false),
                    Planter1 = table.Column<int>(nullable: false),
                    Resource1 = table.Column<int>(nullable: false),
                    Monitor1 = table.Column<int>(nullable: false),
                    Implementer1 = table.Column<int>(nullable: false),
                    Teamwork1 = table.Column<int>(nullable: false),
                    Finisher1 = table.Column<int>(nullable: false),
                    sectionGsId = table.Column<int>(nullable: true),
                    sectionFsId = table.Column<int>(nullable: true),
                    sectionHId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sectionAs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sectionAs_sectionFs_sectionFsId",
                        column: x => x.sectionFsId,
                        principalTable: "sectionFs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_sectionAs_sectionGs_sectionGsId",
                        column: x => x.sectionGsId,
                        principalTable: "sectionGs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_sectionAs_SectionH_sectionHId",
                        column: x => x.sectionHId,
                        principalTable: "SectionH",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_sectionAs_sectionFsId",
                table: "sectionAs",
                column: "sectionFsId");

            migrationBuilder.CreateIndex(
                name: "IX_sectionAs_sectionGsId",
                table: "sectionAs",
                column: "sectionGsId");

            migrationBuilder.CreateIndex(
                name: "IX_sectionAs_sectionHId",
                table: "sectionAs",
                column: "sectionHId");

            migrationBuilder.CreateIndex(
                name: "IX_sectionBs_sectionAId",
                table: "sectionBs",
                column: "sectionAId");

            migrationBuilder.CreateIndex(
                name: "IX_sectionBs_sectionCId",
                table: "sectionBs",
                column: "sectionCId");

            migrationBuilder.CreateIndex(
                name: "IX_sectionBs_sectionDId",
                table: "sectionBs",
                column: "sectionDId");

            migrationBuilder.CreateIndex(
                name: "IX_sectionBs_sectionEId",
                table: "sectionBs",
                column: "sectionEId");

            migrationBuilder.CreateIndex(
                name: "IX_sectionBs_sectionFId",
                table: "sectionBs",
                column: "sectionFId");

            migrationBuilder.CreateIndex(
                name: "IX_sectionBs_sectionGId",
                table: "sectionBs",
                column: "sectionGId");

            migrationBuilder.CreateIndex(
                name: "IX_sectionBs_sectionHId",
                table: "sectionBs",
                column: "sectionHId");

            migrationBuilder.CreateIndex(
                name: "IX_sectionCs_sectionAId",
                table: "sectionCs",
                column: "sectionAId");

            migrationBuilder.CreateIndex(
                name: "IX_sectionCs_sectionDId",
                table: "sectionCs",
                column: "sectionDId");

            migrationBuilder.CreateIndex(
                name: "IX_sectionCs_sectionEsId",
                table: "sectionCs",
                column: "sectionEsId");

            migrationBuilder.CreateIndex(
                name: "IX_sectionCs_sectionGId",
                table: "sectionCs",
                column: "sectionGId");

            migrationBuilder.CreateIndex(
                name: "IX_sectionCs_sectionHsId",
                table: "sectionCs",
                column: "sectionHsId");

            migrationBuilder.CreateIndex(
                name: "IX_sectionDs_SectionDId",
                table: "sectionDs",
                column: "SectionDId");

            migrationBuilder.CreateIndex(
                name: "IX_sectionDs_sectionAId",
                table: "sectionDs",
                column: "sectionAId");

            migrationBuilder.CreateIndex(
                name: "IX_sectionDs_sectionGId",
                table: "sectionDs",
                column: "sectionGId");

            migrationBuilder.CreateIndex(
                name: "IX_sectionEs_sectionAId",
                table: "sectionEs",
                column: "sectionAId");

            migrationBuilder.CreateIndex(
                name: "IX_sectionEs_sectionDId",
                table: "sectionEs",
                column: "sectionDId");

            migrationBuilder.CreateIndex(
                name: "IX_sectionEs_sectionGId",
                table: "sectionEs",
                column: "sectionGId");

            migrationBuilder.CreateIndex(
                name: "IX_sectionFs_sectionCsId",
                table: "sectionFs",
                column: "sectionCsId");

            migrationBuilder.CreateIndex(
                name: "IX_sectionFs_sectionDId",
                table: "sectionFs",
                column: "sectionDId");

            migrationBuilder.CreateIndex(
                name: "IX_sectionFs_sectionEsId",
                table: "sectionFs",
                column: "sectionEsId");

            migrationBuilder.CreateIndex(
                name: "IX_sectionFs_sectionGId",
                table: "sectionFs",
                column: "sectionGId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionH_sectionDId",
                table: "SectionH",
                column: "sectionDId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionH_sectionEsId",
                table: "SectionH",
                column: "sectionEsId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionH_sectionFsId",
                table: "SectionH",
                column: "sectionFsId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionH_sectionGId",
                table: "SectionH",
                column: "sectionGId");

            migrationBuilder.AddForeignKey(
                name: "FK_sectionBs_sectionFs_sectionFId",
                table: "sectionBs",
                column: "sectionFId",
                principalTable: "sectionFs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_sectionBs_SectionH_sectionHId",
                table: "sectionBs",
                column: "sectionHId",
                principalTable: "SectionH",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_sectionBs_sectionAs_sectionAId",
                table: "sectionBs",
                column: "sectionAId",
                principalTable: "sectionAs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_sectionBs_sectionCs_sectionCId",
                table: "sectionBs",
                column: "sectionCId",
                principalTable: "sectionCs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_sectionBs_sectionDs_sectionDId",
                table: "sectionBs",
                column: "sectionDId",
                principalTable: "sectionDs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_sectionBs_sectionEs_sectionEId",
                table: "sectionBs",
                column: "sectionEId",
                principalTable: "sectionEs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_sectionCs_SectionH_sectionHsId",
                table: "sectionCs",
                column: "sectionHsId",
                principalTable: "SectionH",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_sectionCs_sectionAs_sectionAId",
                table: "sectionCs",
                column: "sectionAId",
                principalTable: "sectionAs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_sectionCs_sectionDs_sectionDId",
                table: "sectionCs",
                column: "sectionDId",
                principalTable: "sectionDs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_sectionCs_sectionEs_sectionEsId",
                table: "sectionCs",
                column: "sectionEsId",
                principalTable: "sectionEs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_sectionDs_sectionAs_sectionAId",
                table: "sectionDs",
                column: "sectionAId",
                principalTable: "sectionAs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_sectionEs_sectionAs_sectionAId",
                table: "sectionEs",
                column: "sectionAId",
                principalTable: "sectionAs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sectionAs_sectionFs_sectionFsId",
                table: "sectionAs");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionH_sectionFs_sectionFsId",
                table: "SectionH");

            migrationBuilder.DropForeignKey(
                name: "FK_sectionAs_sectionGs_sectionGsId",
                table: "sectionAs");

            migrationBuilder.DropForeignKey(
                name: "FK_sectionDs_sectionGs_sectionGId",
                table: "sectionDs");

            migrationBuilder.DropForeignKey(
                name: "FK_sectionEs_sectionGs_sectionGId",
                table: "sectionEs");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionH_sectionGs_sectionGId",
                table: "SectionH");

            migrationBuilder.DropForeignKey(
                name: "FK_sectionAs_SectionH_sectionHId",
                table: "sectionAs");

            migrationBuilder.DropTable(
                name: "sectionBs");

            migrationBuilder.DropTable(
                name: "sectionFs");

            migrationBuilder.DropTable(
                name: "sectionCs");

            migrationBuilder.DropTable(
                name: "sectionGs");

            migrationBuilder.DropTable(
                name: "SectionH");

            migrationBuilder.DropTable(
                name: "sectionEs");

            migrationBuilder.DropTable(
                name: "sectionDs");

            migrationBuilder.DropTable(
                name: "sectionAs");

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
                    PlanterId = table.Column<int>(nullable: true),
                    ResourceId = table.Column<int>(nullable: true),
                    ShaperId = table.Column<int>(nullable: true),
                    TeamworkId = table.Column<int>(nullable: true),
                    implementerId = table.Column<int>(nullable: true)
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
                    PlanterId = table.Column<int>(nullable: true),
                    ResourceId = table.Column<int>(nullable: true),
                    ShaperId = table.Column<int>(nullable: true),
                    TeamworkId = table.Column<int>(nullable: true),
                    implementerId = table.Column<int>(nullable: true)
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
    }
}

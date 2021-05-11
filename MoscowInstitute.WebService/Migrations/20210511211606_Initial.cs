using Microsoft.EntityFrameworkCore.Migrations;

namespace InformationAboutParks.WebService.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TrafficRestrictions",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NameOfManagingOrg = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    INN = table.Column<string>(nullable: true),
                    IssuedPrescriptions = table.Column<string>(nullable: true),
                    ViolationsAmount = table.Column<string>(nullable: true),
                    ProtocolsComposed = table.Column<string>(nullable: true),
                    EventsExecuted = table.Column<string>(nullable: true),
                    EventsNotExecutedInTime = table.Column<string>(nullable: true),
                    ProtocolsComposedForFailure = table.Column<string>(nullable: true),
                    SumOfFine = table.Column<string>(nullable: true),
                    global_id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrafficRestrictions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TrafficRestrictions",
                columns: new[] { "Id", "EventsExecuted", "EventsNotExecutedInTime", "INN", "IssuedPrescriptions", "NameOfManagingOrg", "ProtocolsComposed", "ProtocolsComposedForFailure", "SumOfFine", "ViolationsAmount", "Year", "global_id" },
                values: new object[] { 1L, "0", "0", "7702560790", "1", "Товарищество собственников жилья «Рождественский бульвар дом 5-7 » 7702560790 2015", "0", "0", "0", "3", "2015", "639913050" });

            migrationBuilder.InsertData(
                table: "TrafficRestrictions",
                columns: new[] { "Id", "EventsExecuted", "EventsNotExecutedInTime", "INN", "IssuedPrescriptions", "NameOfManagingOrg", "ProtocolsComposed", "ProtocolsComposedForFailure", "SumOfFine", "ViolationsAmount", "Year", "global_id" },
                values: new object[] { 2L, "0", "0", "5074046552", "219", "ООО «Управляющая компания» Шишкин Лес» 5074046552 2015", "60", "1", "1998", "617", "2015", "639913054" });

            migrationBuilder.InsertData(
                table: "TrafficRestrictions",
                columns: new[] { "Id", "EventsExecuted", "EventsNotExecutedInTime", "INN", "IssuedPrescriptions", "NameOfManagingOrg", "ProtocolsComposed", "ProtocolsComposedForFailure", "SumOfFine", "ViolationsAmount", "Year", "global_id" },
                values: new object[] { 3L, "0", "0", "7737023041", "7", "Жилищно Строительный Кооператив «Фаза» 7737023041 2015", "1", "0", "40", "5", "2015", "639913083" });

            migrationBuilder.InsertData(
                table: "TrafficRestrictions",
                columns: new[] { "Id", "EventsExecuted", "EventsNotExecutedInTime", "INN", "IssuedPrescriptions", "NameOfManagingOrg", "ProtocolsComposed", "ProtocolsComposedForFailure", "SumOfFine", "ViolationsAmount", "Year", "global_id" },
                values: new object[] { 4L, "0", "0", "7712019533", "0", "ФГУП «Управление служебными и жилыми зданиями» РАМН 7712019533 2015", "0", "0", "0", "2", "2015", "639913137" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrafficRestrictions");
        }
    }
}

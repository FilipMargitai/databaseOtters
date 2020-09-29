using Microsoft.EntityFrameworkCore.Migrations;

namespace databaseOtters.Migrations
{
    public partial class _02Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Otters_Otters_MothertattooID",
                table: "Otters");

            migrationBuilder.DropForeignKey(
                name: "FK_Otters_Places_placeName",
                table: "Otters");

            migrationBuilder.DropForeignKey(
                name: "FK_Places_Locations_LocationID",
                table: "Places");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Places",
                table: "Places");

            migrationBuilder.DropIndex(
                name: "IX_Otters_MothertattooID",
                table: "Otters");

            migrationBuilder.DropIndex(
                name: "IX_Otters_placeName",
                table: "Otters");

            migrationBuilder.DropColumn(
                name: "MothertattooID",
                table: "Otters");

            migrationBuilder.RenameColumn(
                name: "LocationID",
                table: "Places",
                newName: "LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Places_LocationID",
                table: "Places",
                newName: "IX_Places_LocationId");

            migrationBuilder.RenameColumn(
                name: "placeName",
                table: "Otters",
                newName: "PlaceName");

            migrationBuilder.RenameColumn(
                name: "tattooID",
                table: "Otters",
                newName: "TattooID");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Places",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Otters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MotherId",
                table: "Otters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Places",
                table: "Places",
                columns: new[] { "Name", "LocationId" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationID", "Area", "Name" },
                values: new object[] { 111, 33233f, "NP Šumava" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationID", "Area", "Name" },
                values: new object[] { 128, 13165f, "CHKO Jizerské hory" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationID", "Area", "Name" },
                values: new object[] { 666, 15432f, "CHKO Čeký Les" });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Name", "LocationId" },
                values: new object[,]
                {
                    { "U Studánky", 111 },
                    { "U Buku", 111 },
                    { "Černé Jezero", 128 },
                    { "U Studánky", 128 },
                    { "Na Čihadlech", 128 },
                    { "U Studánky", 666 },
                    { "Český Pařez", 666 }
                });

            migrationBuilder.InsertData(
                table: "Otters",
                columns: new[] { "TattooID", "Color", "LocationId", "MotherId", "Name", "PlaceName" },
                values: new object[] { 1, "hnědá jako hodně", 111, 0, "Velká Máti", "U Studánky" });

            migrationBuilder.InsertData(
                table: "Otters",
                columns: new[] { "TattooID", "Color", "LocationId", "MotherId", "Name", "PlaceName" },
                values: new object[] { 2, "Hnědá taky", 111, 1, "První Dcera", "U Studánky" });

            migrationBuilder.InsertData(
                table: "Otters",
                columns: new[] { "TattooID", "Color", "LocationId", "MotherId", "Name", "PlaceName" },
                values: new object[] { 3, "Hnědá trochu", 128, 1, "ZBloudilka", "Černé Jezero" });

            migrationBuilder.CreateIndex(
                name: "IX_Otters_MotherId",
                table: "Otters",
                column: "MotherId");

            migrationBuilder.CreateIndex(
                name: "IX_Otters_PlaceName_LocationId",
                table: "Otters",
                columns: new[] { "PlaceName", "LocationId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Otters_Otters_MotherId",
                table: "Otters",
                column: "MotherId",
                principalTable: "Otters",
                principalColumn: "TattooID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Otters_Places_PlaceName_LocationId",
                table: "Otters",
                columns: new[] { "PlaceName", "LocationId" },
                principalTable: "Places",
                principalColumns: new[] { "Name", "LocationId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Places_Locations_LocationId",
                table: "Places",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Otters_Otters_MotherId",
                table: "Otters");

            migrationBuilder.DropForeignKey(
                name: "FK_Otters_Places_PlaceName_LocationId",
                table: "Otters");

            migrationBuilder.DropForeignKey(
                name: "FK_Places_Locations_LocationId",
                table: "Places");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Places",
                table: "Places");

            migrationBuilder.DropIndex(
                name: "IX_Otters_MotherId",
                table: "Otters");

            migrationBuilder.DropIndex(
                name: "IX_Otters_PlaceName_LocationId",
                table: "Otters");

            migrationBuilder.DeleteData(
                table: "Otters",
                keyColumn: "TattooID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Otters",
                keyColumn: "TattooID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumns: new[] { "Name", "LocationId" },
                keyValues: new object[] { "Český Pařez", 666 });

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumns: new[] { "Name", "LocationId" },
                keyValues: new object[] { "Na Čihadlech", 128 });

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumns: new[] { "Name", "LocationId" },
                keyValues: new object[] { "U Buku", 111 });

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumns: new[] { "Name", "LocationId" },
                keyValues: new object[] { "U Studánky", 128 });

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumns: new[] { "Name", "LocationId" },
                keyValues: new object[] { "U Studánky", 666 });

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Otters",
                keyColumn: "TattooID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumns: new[] { "Name", "LocationId" },
                keyValues: new object[] { "Černé Jezero", 128 });

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumns: new[] { "Name", "LocationId" },
                keyValues: new object[] { "U Studánky", 111 });

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 111);

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Otters");

            migrationBuilder.DropColumn(
                name: "MotherId",
                table: "Otters");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Places",
                newName: "LocationID");

            migrationBuilder.RenameIndex(
                name: "IX_Places_LocationId",
                table: "Places",
                newName: "IX_Places_LocationID");

            migrationBuilder.RenameColumn(
                name: "PlaceName",
                table: "Otters",
                newName: "placeName");

            migrationBuilder.RenameColumn(
                name: "TattooID",
                table: "Otters",
                newName: "tattooID");

            migrationBuilder.AlterColumn<int>(
                name: "LocationID",
                table: "Places",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "MothertattooID",
                table: "Otters",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Places",
                table: "Places",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Otters_MothertattooID",
                table: "Otters",
                column: "MothertattooID");

            migrationBuilder.CreateIndex(
                name: "IX_Otters_placeName",
                table: "Otters",
                column: "placeName");

            migrationBuilder.AddForeignKey(
                name: "FK_Otters_Otters_MothertattooID",
                table: "Otters",
                column: "MothertattooID",
                principalTable: "Otters",
                principalColumn: "tattooID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Otters_Places_placeName",
                table: "Otters",
                column: "placeName",
                principalTable: "Places",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Places_Locations_LocationID",
                table: "Places",
                column: "LocationID",
                principalTable: "Locations",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

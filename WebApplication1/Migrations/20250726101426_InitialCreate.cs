using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InverterData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InverterId = table.Column<int>(type: "INTEGER", nullable: false),
                    Time = table.Column<DateTime>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    Total_kWh = table.Column<double>(type: "REAL", nullable: false),
                    Today_kWh = table.Column<double>(type: "REAL", nullable: false),
                    Temp_C = table.Column<double>(type: "REAL", nullable: false),
                    MPPT01_V = table.Column<double>(type: "REAL", nullable: false),
                    PV01_A = table.Column<double>(type: "REAL", nullable: false),
                    PV02_A = table.Column<double>(type: "REAL", nullable: false),
                    MPPT02_V = table.Column<double>(type: "REAL", nullable: false),
                    PV03_A = table.Column<double>(type: "REAL", nullable: false),
                    PV04_A = table.Column<double>(type: "REAL", nullable: false),
                    MPPT03_V = table.Column<double>(type: "REAL", nullable: false),
                    PV05_A = table.Column<double>(type: "REAL", nullable: false),
                    PV06_A = table.Column<double>(type: "REAL", nullable: false),
                    MPPT04_V = table.Column<double>(type: "REAL", nullable: false),
                    PV07_A = table.Column<double>(type: "REAL", nullable: false),
                    PV08_A = table.Column<double>(type: "REAL", nullable: false),
                    MPPT05_V = table.Column<double>(type: "REAL", nullable: false),
                    PV09_A = table.Column<double>(type: "REAL", nullable: false),
                    PV10_A = table.Column<double>(type: "REAL", nullable: false),
                    MPPT06_V = table.Column<double>(type: "REAL", nullable: false),
                    PV11_A = table.Column<double>(type: "REAL", nullable: false),
                    PV12_A = table.Column<double>(type: "REAL", nullable: false),
                    MPPT07_V = table.Column<double>(type: "REAL", nullable: false),
                    PV13_A = table.Column<double>(type: "REAL", nullable: false),
                    PV14_A = table.Column<double>(type: "REAL", nullable: false),
                    MPPT08_V = table.Column<double>(type: "REAL", nullable: false),
                    PV15_A = table.Column<double>(type: "REAL", nullable: false),
                    PV16_A = table.Column<double>(type: "REAL", nullable: false),
                    MPPT09_V = table.Column<double>(type: "REAL", nullable: false),
                    PV17_A = table.Column<double>(type: "REAL", nullable: false),
                    PV18_A = table.Column<double>(type: "REAL", nullable: false),
                    MPPT10_V = table.Column<double>(type: "REAL", nullable: false),
                    PV19_A = table.Column<double>(type: "REAL", nullable: false),
                    PV20_A = table.Column<double>(type: "REAL", nullable: false),
                    AC_W = table.Column<string>(type: "TEXT", nullable: false),
                    AC_Var = table.Column<string>(type: "TEXT", nullable: false),
                    AC1_V = table.Column<string>(type: "TEXT", nullable: false),
                    AC2_V = table.Column<string>(type: "TEXT", nullable: false),
                    AC3_V = table.Column<string>(type: "TEXT", nullable: false),
                    AC1_A = table.Column<string>(type: "TEXT", nullable: false),
                    AC2_A = table.Column<string>(type: "TEXT", nullable: false),
                    AC3_A = table.Column<string>(type: "TEXT", nullable: false),
                    AC_Hz = table.Column<string>(type: "TEXT", nullable: false),
                    AlarmCode = table.Column<string>(type: "TEXT", nullable: false),
                    AlarmCodeType = table.Column<string>(type: "TEXT", nullable: false),
                    Standby = table.Column<string>(type: "TEXT", nullable: false),
                    PowerDownOperation = table.Column<string>(type: "TEXT", nullable: false),
                    OverPowerProtection = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InverterData", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InverterData");
        }
    }
}

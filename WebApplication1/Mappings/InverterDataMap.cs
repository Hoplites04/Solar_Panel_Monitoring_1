using CsvHelper.Configuration;
using WebApplication1.Models;

public class InverterDataMap : ClassMap<InverterData>
{
    public InverterDataMap()
    {
        // Assuming InverterId is not in the CSV and is added manually later
        Map(m => m.Time).Name("Time");
        Map(m => m.State).Name("State");
        Map(m => m.Total_kWh).Name("Total(kWh)");
        Map(m => m.Today_kWh).Name("Today(kWh)");
        Map(m => m.Temp_C).Name("Tem(C)");

        Map(m => m.MPPT01_V).Name("MPPT01(V)");
        Map(m => m.PV01_A).Name("PV01(A)");
        Map(m => m.PV02_A).Name("PV02(A)");

        Map(m => m.MPPT02_V).Name("MPPT02(V)");
        Map(m => m.PV03_A).Name("PV03(A)");
        Map(m => m.PV04_A).Name("PV04(A)");

        Map(m => m.MPPT03_V).Name("MPPT03(V)");
        Map(m => m.PV05_A).Name("PV05(A)");
        Map(m => m.PV06_A).Name("PV06(A)");

        Map(m => m.MPPT04_V).Name("MPPT04(V)");
        Map(m => m.PV07_A).Name("PV07(A)");
        Map(m => m.PV08_A).Name("PV08(A)");

        Map(m => m.MPPT05_V).Name("MPPT05(V)");
        Map(m => m.PV09_A).Name("PV09(A)");
        Map(m => m.PV10_A).Name("PV10(A)");

        Map(m => m.MPPT06_V).Name("MPPT06(V)");
        Map(m => m.PV11_A).Name("PV11(A)");
        Map(m => m.PV12_A).Name("PV12(A)");

        Map(m => m.MPPT07_V).Name("MPPT07(V)");
        Map(m => m.PV13_A).Name("PV13(A)");
        Map(m => m.PV14_A).Name("PV14(A)");

        Map(m => m.MPPT08_V).Name("MPPT08(V)");
        Map(m => m.PV15_A).Name("PV15(A)");
        Map(m => m.PV16_A).Name("PV16(A)");

        Map(m => m.MPPT09_V).Name("MPPT09(V)");
        Map(m => m.PV17_A).Name("PV17(A)");
        Map(m => m.PV18_A).Name("PV18(A)");

        Map(m => m.MPPT10_V).Name("MPPT10(V)");
        Map(m => m.PV19_A).Name("PV19(A)");
        Map(m => m.PV20_A).Name("PV20(A)");

        Map(m => m.AC_W).Name("AC(W)");
        Map(m => m.AC_Var).Name("AC(Var)");

        Map(m => m.AC1_V).Name("AC1(V)");
        Map(m => m.AC2_V).Name("AC2(V)");
        Map(m => m.AC3_V).Name("AC3(V)");

        Map(m => m.AC1_A).Name("AC1(A)");
        Map(m => m.AC2_A).Name("AC2(A)");
        Map(m => m.AC3_A).Name("AC3(A)");

        Map(m => m.AC_Hz).Name("AC(HZ)");

        Map(m => m.AlarmCode).Name("Alarm Code");
        Map(m => m.AlarmCodeType).Name("Alarm code type");

        Map(m => m.Standby).Name("Standby");
        Map(m => m.PowerDownOperation).Name("Power down operation");
        Map(m => m.OverPowerProtection).Name("Over Temperature Protection");
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class InverterData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int InverterId { get; set; }  // Example: 1, 2, 3, 4, 5

        [Required]
        public DateTime Time { get; set; }   // Timestamp of the data

        public string State { get; set; } = string.Empty;

        public double Total_kWh { get; set; }
        public double Today_kWh { get; set; }
        public double Temp_C { get; set; }

        public double MPPT01_V { get; set; } 
        public double PV01_A { get; set; }     
        public double PV02_A { get; set; }     

        public double MPPT02_V { get; set; } 
        public double PV03_A { get; set; }     
        public double PV04_A { get; set; }    

        public double MPPT03_V { get; set; }
        public double PV05_A { get; set; }
        public double PV06_A { get; set; }

        public double MPPT04_V { get; set; }
        public double PV07_A { get; set; }
        public double PV08_A { get; set; }

        public double MPPT05_V { get; set; }
        public double PV09_A { get; set; }
        public double PV10_A { get; set; }

        public double MPPT06_V { get; set; }
        public double PV11_A { get; set; }
        public double PV12_A { get; set; }

        public double MPPT07_V { get; set; }
        public double PV13_A { get; set; }
        public double PV14_A { get; set; }

        public double MPPT08_V { get; set; }
        public double PV15_A { get; set; }
        public double PV16_A { get; set; }

        public double MPPT09_V { get; set; }
        public double PV17_A { get; set; }
        public double PV18_A { get; set; }

        public double MPPT10_V { get; set; }
        public double PV19_A { get; set; }
        public double PV20_A { get; set; }

        public string AC_W { get; set; }  // AC Power in Watts
        public string AC_Var { get; set; } // AC Reactive Power in Volt-Amperes Reactive

        public string AC1_V { get; set; } // AC Voltage Phase 1
        public string AC2_V { get; set; } // AC Voltage Phase 2
        public string AC3_V { get; set; } // AC Voltage Phase 3

        public string AC1_A { get; set; } // AC Current Phase 1
        public string AC2_A { get; set; } // AC Current Phase 2
        public string AC3_A { get; set; } // AC Current Phase 3

        public string AC_Hz { get; set; } // AC Frequency

        public string AlarmCode { get; set; } // Alarm code, if any
        public string AlarmCodeType { get; set; } = string.Empty; // Type of alarm code, if any

        public string Standby { get; set; } = string.Empty; // Standby status, if applicable

        public string PowerDownOperation { get; set; } = string.Empty; // Power down operation status, if applicable

        public string OverPowerProtection { get; set; } = string.Empty; // Overpower protection status, if applicable

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
namespace HIS.AutoUpdate.Blazor.Models
{
    public class HISSettingsSection
    {
        #region HIS

        [JsonPropertyName("DWIO_HIS.DWIO.exe")]
        public CurrentVersionURL DWIO_HIS_DWIO_exe { get; set; } = new CurrentVersionURL { currentVersionURL = "123123" };
        [JsonPropertyName("IP_HIS.Inpatient.Pharmacy.exe")]
        public CurrentVersionURL IP_HIS_Inpatient_Pharmacy_exe { get; set; }
        [JsonPropertyName("OP_HIS.Outpatient.Pharmacy.exe")]
        public CurrentVersionURL OP_HIS_Outpatient_Pharmacy_exe { get; set; }
        [JsonPropertyName("MT_HIS.MT.exe")]
        public CurrentVersionURL MT_HIS_MT_exe { get; set; }
        [JsonPropertyName("HIS.Client.Launcher.exe")]
        public CurrentVersionURL HIS_Client_Launcher_exe { get; set; }
        [JsonPropertyName("OPD_HIS.Outpatient.RC.exe")]
        public CurrentVersionURL OPD_HIS_Outpatient_RC_exe { get; set; }
        [JsonPropertyName("IPDTest_HIS.Inpatient.Admission.QueryTest.exe")]
        public CurrentVersionURL IPDTest_HIS_Inpatient_Admission_QueryTest_exe { get; set; }
        [JsonPropertyName("ComplexQuery_HIS.ComplexQuery.exe")]
        public CurrentVersionURL ComplexQuery_HIS_ComplexQuery_exe { get; set; }
        [JsonPropertyName("PatientTest_HIS.Patient.Test.exe")]
        public CurrentVersionURL PatientTest_HIS_Patient_Test_exe { get; set; }
        [JsonPropertyName("DW_HIS.DW.exe")]
        public CurrentVersionURL DW_HIS_DW_exe { get; set; }
        [JsonPropertyName("NW_HIS.NW.exe")]
        public CurrentVersionURL NW_HIS_NW_exe { get; set; }
        [JsonPropertyName("OPDFree_HIS.Outpatient.RC.Free.exe")]
        public CurrentVersionURL OPDFree_HIS_Outpatient_RC_Free_exe { get; set; }
        [JsonPropertyName("SYSTEM_HIS.Foundations.exe")]
        public CurrentVersionURL SYSTEM_HIS_Foundations_exe { get; set; }
        [JsonPropertyName("IPD.SC_HIS.Inpatient.SC.exe")]
        public CurrentVersionURL IPD_SC_HIS_Inpatient_SC_exe { get; set; }
        [JsonPropertyName("Patient_HIS.Patient.exe")]
        public CurrentVersionURL Patient_HIS_Patient_exe { get; set; }
        [JsonPropertyName("AutoUpgradeComponent")]
        public CurrentVersionURL AutoUpgradeComponent { get; set; }
        [JsonPropertyName("OPDHs_HIS.Outpatient.RC.Hs.exe")]
        public CurrentVersionURL OPDHs_HIS_Outpatient_RC_Hs_exe { get; set; }
        [JsonPropertyName("DWIOInternet_HIS.DWIONET.exe")]
        public CurrentVersionURL DWIOInternet_HIS_DWIONET_exe { get; set; }
        [JsonPropertyName("IPD_HIS.Inpatient.Admission.Query.exe")]
        public CurrentVersionURL IPD_HIS_Inpatient_Admission_Query_exe { get; set; }
        [JsonPropertyName("IPD_HIS.Inpatient.Admission.Reception.exe")]
        public CurrentVersionURL IPD_HIS_Inpatient_Admission_Reception_exe { get; set; }
        [JsonPropertyName("OPDTest_HIS.Outpatient.RC.Test.exe")]
        public CurrentVersionURL OPDTest_HIS_Outpatient_RC_Test_exe { get; set; }
        [JsonPropertyName("IPDTest_HIS.Inpatient.Admission.ReceptionTest.exe")]
        public CurrentVersionURL IPDTest_HIS_Inpatient_Admission_ReceptionTest_exe { get; set; }
        #endregion

        #region CMIT

        [JsonPropertyName("HIS.NW")]
        public CurrentVersionURL HIS_NW { get; set; }
        [JsonPropertyName("HIS.DWIO")]
        public CurrentVersionURL HIS_DWIO { get; set; }
        [JsonPropertyName("HIS.Outpatient.DW")]
        public CurrentVersionURL HIS_Outpatient_DW { get; set; }
        //[JsonPropertyName("AutoUpgradeComponent")]
        //public CurrentVersionURL AutoUpgradeComponent { get; set; }
        [JsonPropertyName("HIS.Inpatient.DW")]
        public CurrentVersionURL HIS_Inpatient_DW { get; set; }

        #endregion
    }
}

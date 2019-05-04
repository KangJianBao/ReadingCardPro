using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTISModels
{
    public class Patient
    {

       
        /// <summary>
        /// 放疗号 / Patient Radiation therapy ID
        /// </summary>
        public string TreatmentId { get; set; }

        /// <summary>
        /// 病历号 / PatientMedicalRecordNo
        /// </summary>
        public string PatientMedicalRecordNo { get; set; }

        /// <summary>
        /// 姓名 / Patient Name
        /// </summary>
        public string PatientName { get; set; }

        /// <summary>
        /// 性别 / Patient Gender
        /// </summary>
        public string PatientGender { get; set; }

        /// <summary>
        /// 出生年月 / Patient Date of birth
        /// </summary>
        public DateTime PatientBirthday { get; set; }

        /// <summary>
        /// 联系电话 
        /// </summary>
        public string PatientPhoneNumber { get; set; }

        /// <summary>
        /// 证件类型 
        /// </summary>
        public int IDTypeId { get; set; }

        /// <summary>
        /// 证件号码 
        /// </summary>
        public string PatientIDCardNumber { get; set; }

        /// <summary>
        /// 籍贯
        /// </summary>
        public string PatientNativePlace { get; set; }

        /// <summary>
        /// 家庭住址 
        /// </summary>
        public string PatientAddress { get; set; }

        /// <summary>
        /// 照片 / Patient Image
        /// </summary>
        public string PatientImage { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string PatientRemarks { get; set; }

        /// <summary>
        /// 主管医师 
        /// </summary>
        public int DirectorDoctorId { get; set; }

        /// <summary>
        /// 主诊医师 
        /// </summary>
        public int AttendingDoctorId { get; set; }

        /// <summary>
        /// 临床诊断 Patient Clinical diagnosis
        /// </summary>
        public string ClinicalDiagnosis { get; set; }

        /// <summary>
        /// 病发类型 Patient Disease types
        /// </summary>
        public int DiseaseTypeId { get; set; }

        /// <summary>
        /// 照射部位 Patient irradiated site
        /// </summary>
        public int IrradiatedSiteId { get; set; }

        /// <summary>
        /// 治疗方式
        /// </summary>
        public int TreatmentMethodId { get; set; }

        /// <summary>
        /// 分期
        /// </summary>
        public string Stage { get; set; }

        /// <summary>
        /// 分期T
        /// </summary>
        public string StageT { get; set; }

        /// <summary>
        /// 分期N
        /// </summary>
        public string StageN { get; set; }

        /// <summary>
        /// 分期M
        /// </summary>
        public string StageM { get; set; }

        /// <summary>
        /// 登记人 / The registrar
        /// </summary>
        public string Register { get; set; }

        /// <summary>
        /// 登记日期 / Date of registration
        /// </summary>
        public DateTime RegisterTime { get; set; }

        /// <summary>
        /// 射频卡卡号
        /// </summary>
        public string RFCardNumber { get; set; }

        //扩展属性

        /// <summary>
        /// 证件号码
        /// </summary>
        public string IDTypeName { get; set; }

        /// <summary>
        /// 主管医师名称
        /// </summary>
        public string DirectorDoctorName { get; set; }

        /// <summary>
        /// 主治医师名称
        /// </summary>
        public string AttendingDoctorName { get; set; }

        /// <summary>
        /// 临床诊断名称
        /// </summary>
        public string DiseaseTypeName { get; set; }

        /// <summary>
        /// 照射部位名称
        /// </summary>
        public string IrradiatedSiteName { get; set; }

        /// <summary>
        /// 治疗方式名称
        /// </summary>
        public string TreatmentMethodName { get; set; }


        //TreatmentId, PatientMedicalRecordNo, PatientName, PatientGender, PatientBirthday,
        //PatientPhoneNumber, IDTypeId, PatientIDCardNumber, PatientNativePlace, PatientAddress,
        //PatientImage, PatientRemarks, DirectorDoctorId, AttendingDoctorId, ClinicalDiagnosis, 
        //DiseaseTypeId, IrradiatedSiteId, 
        //TreatmentMethodId, Stage, StageT, StageN, StageM, Register, RegisterTime, RFCardNumber

    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BDRAEntities : DbContext
    {
        public BDRAEntities()
            : base("name=BDRAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<additionalInformationByContact> additionalInformationByContact { get; set; }
        public virtual DbSet<ally> ally { get; set; }
        public virtual DbSet<areas> areas { get; set; }
        public virtual DbSet<branch> branch { get; set; }
        public virtual DbSet<Canal> Canal { get; set; }
        public virtual DbSet<CashSpecialist> CashSpecialist { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<CNE> CNE { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<EconomicActivity> EconomicActivity { get; set; }
        public virtual DbSet<jobTitle> jobTitle { get; set; }
        public virtual DbSet<JobTitlesClient> JobTitlesClient { get; set; }
        public virtual DbSet<kindOfAlly> kindOfAlly { get; set; }
        public virtual DbSet<KindOfBanking> KindOfBanking { get; set; }
        public virtual DbSet<kindOfDocument> kindOfDocument { get; set; }
        public virtual DbSet<logins> logins { get; set; }
        public virtual DbSet<modules> modules { get; set; }
        public virtual DbSet<operationalInformationByRequest> operationalInformationByRequest { get; set; }
        public virtual DbSet<permission> permission { get; set; }
        public virtual DbSet<permissionByModule> permissionByModule { get; set; }
        public virtual DbSet<permissionByRole> permissionByRole { get; set; }
        public virtual DbSet<probability> probability { get; set; }
        public virtual DbSet<Regional> Regional { get; set; }
        public virtual DbSet<RegionalsMain> RegionalsMain { get; set; }
        public virtual DbSet<RegionalsVice> RegionalsVice { get; set; }
        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<riskInformationByRequest> riskInformationByRequest { get; set; }
        public virtual DbSet<roles> roles { get; set; }
        public virtual DbSet<Segment> Segment { get; set; }
        public virtual DbSet<stateGroup> stateGroup { get; set; }
        public virtual DbSet<states> states { get; set; }
        public virtual DbSet<userByRol> userByRol { get; set; }
        public virtual DbSet<users> users { get; set; }
        public virtual DbSet<VicePresident> VicePresident { get; set; }
        public virtual DbSet<Zonal> Zonal { get; set; }
        public virtual DbSet<VP> VP { get; set; }
        public virtual DbSet<CanalGroup> CanalGroup { get; set; }
        public virtual DbSet<PreClient> PreClient { get; set; }
        public virtual DbSet<PreRequest> PreRequest { get; set; }
        public virtual DbSet<VehicleModel> VehicleModel { get; set; }
        public virtual DbSet<Template> Template { get; set; }
        public virtual DbSet<TemplateField> TemplateField { get; set; }
        public virtual DbSet<PreRequest_Observation> PreRequest_Observation { get; set; }
    
        public virtual ObjectResult<RA_SP_GetDataToFile_Result> RA_SP_GetDataToFile()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RA_SP_GetDataToFile_Result>("RA_SP_GetDataToFile");
        }
    
        public virtual ObjectResult<SP_GET_CLIENT_Result> SP_GET_CLIENT(string dATA)
        {
            var dATAParameter = dATA != null ?
                new ObjectParameter("DATA", dATA) :
                new ObjectParameter("DATA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GET_CLIENT_Result>("SP_GET_CLIENT", dATAParameter);
        }
    
        public virtual ObjectResult<STRPRC_GetConfigTemplateByPrefix_Result> STRPRC_GetConfigTemplateByPrefix(string prefix)
        {
            var prefixParameter = prefix != null ?
                new ObjectParameter("prefix", prefix) :
                new ObjectParameter("prefix", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRC_GetConfigTemplateByPrefix_Result>("STRPRC_GetConfigTemplateByPrefix", prefixParameter);
        }
    
        public virtual ObjectResult<STRPRC_GetFielsdByTemplate_Result> STRPRC_GetFielsdByTemplate(Nullable<int> iD_TEMPLATE)
        {
            var iD_TEMPLATEParameter = iD_TEMPLATE.HasValue ?
                new ObjectParameter("ID_TEMPLATE", iD_TEMPLATE) :
                new ObjectParameter("ID_TEMPLATE", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRC_GetFielsdByTemplate_Result>("STRPRC_GetFielsdByTemplate", iD_TEMPLATEParameter);
        }
    
        public virtual int STRPRC_UpdateRiskInformation(string iD_CLIENT, string rISK_STATE, Nullable<System.DateTime> dATE_SUBMIT_ANALYSIS, Nullable<System.DateTime> dATE_RESPONSE_ANALYSIS, Nullable<long> aMOUNT_APPROVED, string uSER)
        {
            var iD_CLIENTParameter = iD_CLIENT != null ?
                new ObjectParameter("ID_CLIENT", iD_CLIENT) :
                new ObjectParameter("ID_CLIENT", typeof(string));
    
            var rISK_STATEParameter = rISK_STATE != null ?
                new ObjectParameter("RISK_STATE", rISK_STATE) :
                new ObjectParameter("RISK_STATE", typeof(string));
    
            var dATE_SUBMIT_ANALYSISParameter = dATE_SUBMIT_ANALYSIS.HasValue ?
                new ObjectParameter("DATE_SUBMIT_ANALYSIS", dATE_SUBMIT_ANALYSIS) :
                new ObjectParameter("DATE_SUBMIT_ANALYSIS", typeof(System.DateTime));
    
            var dATE_RESPONSE_ANALYSISParameter = dATE_RESPONSE_ANALYSIS.HasValue ?
                new ObjectParameter("DATE_RESPONSE_ANALYSIS", dATE_RESPONSE_ANALYSIS) :
                new ObjectParameter("DATE_RESPONSE_ANALYSIS", typeof(System.DateTime));
    
            var aMOUNT_APPROVEDParameter = aMOUNT_APPROVED.HasValue ?
                new ObjectParameter("AMOUNT_APPROVED", aMOUNT_APPROVED) :
                new ObjectParameter("AMOUNT_APPROVED", typeof(long));
    
            var uSERParameter = uSER != null ?
                new ObjectParameter("USER", uSER) :
                new ObjectParameter("USER", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("STRPRC_UpdateRiskInformation", iD_CLIENTParameter, rISK_STATEParameter, dATE_SUBMIT_ANALYSISParameter, dATE_RESPONSE_ANALYSISParameter, aMOUNT_APPROVEDParameter, uSERParameter);
        }
    
        public virtual ObjectResult<STRPRCD_GET_REQUEST_Result> STRPRCD_GET_REQUEST()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRCD_GET_REQUEST_Result>("STRPRCD_GET_REQUEST");
        }
    
        public virtual ObjectResult<string> STRPRCD_GET_REQUEST_JSON()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("STRPRCD_GET_REQUEST_JSON");
        }
    
        public virtual ObjectResult<STRPRCD_GET_REQUEST1_Result> STRPRCD_GET_REQUEST1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRCD_GET_REQUEST1_Result>("STRPRCD_GET_REQUEST1");
        }
    
        public virtual ObjectResult<STRPRCD_GET_ALL_REQUEST_Result> STRPRCD_GET_ALL_REQUEST()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRCD_GET_ALL_REQUEST_Result>("STRPRCD_GET_ALL_REQUEST");
        }
    
        public virtual int STRPRC_GET_REQUEST_BY_FILTER(string fILTER, string vALUE)
        {
            var fILTERParameter = fILTER != null ?
                new ObjectParameter("FILTER", fILTER) :
                new ObjectParameter("FILTER", typeof(string));
    
            var vALUEParameter = vALUE != null ?
                new ObjectParameter("VALUE", vALUE) :
                new ObjectParameter("VALUE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("STRPRC_GET_REQUEST_BY_FILTER", fILTERParameter, vALUEParameter);
        }
    
        public virtual ObjectResult<STRPRC_GET_REQUEST_BY_FILTER_VALUE_Result> STRPRC_GET_REQUEST_BY_FILTER_VALUE(string fILTER, string vALUE)
        {
            var fILTERParameter = fILTER != null ?
                new ObjectParameter("FILTER", fILTER) :
                new ObjectParameter("FILTER", typeof(string));
    
            var vALUEParameter = vALUE != null ?
                new ObjectParameter("VALUE", vALUE) :
                new ObjectParameter("VALUE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRC_GET_REQUEST_BY_FILTER_VALUE_Result>("STRPRC_GET_REQUEST_BY_FILTER_VALUE", fILTERParameter, vALUEParameter);
        }
    
        public virtual ObjectResult<STRPRC_GET_ALL_PRE_REQUEST_Result> STRPRC_GET_ALL_PRE_REQUEST()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRC_GET_ALL_PRE_REQUEST_Result>("STRPRC_GET_ALL_PRE_REQUEST");
        }
    
        public virtual ObjectResult<STRPRC_GET_PRE_REQUEST_BY_FILTER_VALUE_Result> STRPRC_GET_PRE_REQUEST_BY_FILTER_VALUE(string fILTER, string vALUE)
        {
            var fILTERParameter = fILTER != null ?
                new ObjectParameter("FILTER", fILTER) :
                new ObjectParameter("FILTER", typeof(string));
    
            var vALUEParameter = vALUE != null ?
                new ObjectParameter("VALUE", vALUE) :
                new ObjectParameter("VALUE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRC_GET_PRE_REQUEST_BY_FILTER_VALUE_Result>("STRPRC_GET_PRE_REQUEST_BY_FILTER_VALUE", fILTERParameter, vALUEParameter);
        }
    
        public virtual ObjectResult<RA_SP_GetDataToExportFile_Result> RA_SP_GetDataToExportFile()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RA_SP_GetDataToExportFile_Result>("RA_SP_GetDataToExportFile");
        }
    
        public virtual ObjectResult<STRPRC_GetDataToExportFile_Result> STRPRC_GetDataToExportFile()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRC_GetDataToExportFile_Result>("STRPRC_GetDataToExportFile");
        }
    
        public virtual ObjectResult<STRPRC_GetData_To_ExportFile_Result> STRPRC_GetData_To_ExportFile()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRC_GetData_To_ExportFile_Result>("STRPRC_GetData_To_ExportFile");
        }
    
        public virtual int STRPRC_Create_New_Contact_Bank(string cOSTCENTER, string cONTACT_NAME, string kIND_OD_BANK, string rEGIONAL, string cNE, string sEGMENT, string cITY, string vICE_REGIONAL, string rEGIONAL_MAIN, string vICE_PRESIDENT, string cASH_ESPECIALIST, string cODE_ESPECIALIST, string zONAL)
        {
            var cOSTCENTERParameter = cOSTCENTER != null ?
                new ObjectParameter("COSTCENTER", cOSTCENTER) :
                new ObjectParameter("COSTCENTER", typeof(string));
    
            var cONTACT_NAMEParameter = cONTACT_NAME != null ?
                new ObjectParameter("CONTACT_NAME", cONTACT_NAME) :
                new ObjectParameter("CONTACT_NAME", typeof(string));
    
            var kIND_OD_BANKParameter = kIND_OD_BANK != null ?
                new ObjectParameter("KIND_OD_BANK", kIND_OD_BANK) :
                new ObjectParameter("KIND_OD_BANK", typeof(string));
    
            var rEGIONALParameter = rEGIONAL != null ?
                new ObjectParameter("REGIONAL", rEGIONAL) :
                new ObjectParameter("REGIONAL", typeof(string));
    
            var cNEParameter = cNE != null ?
                new ObjectParameter("CNE", cNE) :
                new ObjectParameter("CNE", typeof(string));
    
            var sEGMENTParameter = sEGMENT != null ?
                new ObjectParameter("SEGMENT", sEGMENT) :
                new ObjectParameter("SEGMENT", typeof(string));
    
            var cITYParameter = cITY != null ?
                new ObjectParameter("CITY", cITY) :
                new ObjectParameter("CITY", typeof(string));
    
            var vICE_REGIONALParameter = vICE_REGIONAL != null ?
                new ObjectParameter("VICE_REGIONAL", vICE_REGIONAL) :
                new ObjectParameter("VICE_REGIONAL", typeof(string));
    
            var rEGIONAL_MAINParameter = rEGIONAL_MAIN != null ?
                new ObjectParameter("REGIONAL_MAIN", rEGIONAL_MAIN) :
                new ObjectParameter("REGIONAL_MAIN", typeof(string));
    
            var vICE_PRESIDENTParameter = vICE_PRESIDENT != null ?
                new ObjectParameter("VICE_PRESIDENT", vICE_PRESIDENT) :
                new ObjectParameter("VICE_PRESIDENT", typeof(string));
    
            var cASH_ESPECIALISTParameter = cASH_ESPECIALIST != null ?
                new ObjectParameter("CASH_ESPECIALIST", cASH_ESPECIALIST) :
                new ObjectParameter("CASH_ESPECIALIST", typeof(string));
    
            var cODE_ESPECIALISTParameter = cODE_ESPECIALIST != null ?
                new ObjectParameter("CODE_ESPECIALIST", cODE_ESPECIALIST) :
                new ObjectParameter("CODE_ESPECIALIST", typeof(string));
    
            var zONALParameter = zONAL != null ?
                new ObjectParameter("ZONAL", zONAL) :
                new ObjectParameter("ZONAL", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("STRPRC_Create_New_Contact_Bank", cOSTCENTERParameter, cONTACT_NAMEParameter, kIND_OD_BANKParameter, rEGIONALParameter, cNEParameter, sEGMENTParameter, cITYParameter, vICE_REGIONALParameter, rEGIONAL_MAINParameter, vICE_PRESIDENTParameter, cASH_ESPECIALISTParameter, cODE_ESPECIALISTParameter, zONALParameter);
        }
    }
}

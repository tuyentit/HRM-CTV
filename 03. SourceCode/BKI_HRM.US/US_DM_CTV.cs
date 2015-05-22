///************************************************
/// Generated by: HaiHD
/// Date: 21/05/2015 06:52:45
/// Goal: Create User Service Class for DM_CTV
///************************************************
/// <summary>
/// Create User Service Class for DM_CTV
/// </summary>

using System;
using BKI_HRM.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_HRM.US{

public class US_DM_CTV : US_Object
{
	private const string c_TableName = "DM_CTV";
#region "Public Properties"
	public decimal dcID 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID"] = value;
		}
	}

	public bool IsIDNull()	{
		return pm_objDR.IsNull("ID");
	}

	public void SetIDNull() {
		pm_objDR["ID"] = System.Convert.DBNull;
	}

	public string strMA_CTV 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_CTV", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_CTV"] = value;
		}
	}

	public bool IsMA_CTVNull() 
	{
		return pm_objDR.IsNull("MA_CTV");
	}

	public void SetMA_CTVNull() {
		pm_objDR["MA_CTV"] = System.Convert.DBNull;
	}

	public string strHO_DEM 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "HO_DEM", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["HO_DEM"] = value;
		}
	}

	public bool IsHO_DEMNull() 
	{
		return pm_objDR.IsNull("HO_DEM");
	}

	public void SetHO_DEMNull() {
		pm_objDR["HO_DEM"] = System.Convert.DBNull;
	}

	public string strTEN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN"] = value;
		}
	}

	public bool IsTENNull() 
	{
		return pm_objDR.IsNull("TEN");
	}

	public void SetTENNull() {
		pm_objDR["TEN"] = System.Convert.DBNull;
	}

	public string strGIOI_TINH 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "GIOI_TINH", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["GIOI_TINH"] = value;
		}
	}

	public bool IsGIOI_TINHNull() 
	{
		return pm_objDR.IsNull("GIOI_TINH");
	}

	public void SetGIOI_TINHNull() {
		pm_objDR["GIOI_TINH"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_SINH
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_SINH", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_SINH"] = value;
		}
	}

	public bool IsNGAY_SINHNull()
	{
		return pm_objDR.IsNull("NGAY_SINH");
	}

	public void SetNGAY_SINHNull()
	{
		pm_objDR["NGAY_SINH"] = System.Convert.DBNull;
	}

	public string strNOI_SINH 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "NOI_SINH", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["NOI_SINH"] = value;
		}
	}

	public bool IsNOI_SINHNull() 
	{
		return pm_objDR.IsNull("NOI_SINH");
	}

	public void SetNOI_SINHNull() {
		pm_objDR["NOI_SINH"] = System.Convert.DBNull;
	}

	public string strNGUYEN_QUAN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "NGUYEN_QUAN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["NGUYEN_QUAN"] = value;
		}
	}

	public bool IsNGUYEN_QUANNull() 
	{
		return pm_objDR.IsNull("NGUYEN_QUAN");
	}

	public void SetNGUYEN_QUANNull() {
		pm_objDR["NGUYEN_QUAN"] = System.Convert.DBNull;
	}

	public string strANH 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "ANH", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["ANH"] = value;
		}
	}

	public bool IsANHNull() 
	{
		return pm_objDR.IsNull("ANH");
	}

	public void SetANHNull() {
		pm_objDR["ANH"] = System.Convert.DBNull;
	}

	public string strCMND 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "CMND", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["CMND"] = value;
		}
	}

	public bool IsCMNDNull() 
	{
		return pm_objDR.IsNull("CMND");
	}

	public void SetCMNDNull() {
		pm_objDR["CMND"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_CAP_CMND
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_CAP_CMND", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_CAP_CMND"] = value;
		}
	}

	public bool IsNGAY_CAP_CMNDNull()
	{
		return pm_objDR.IsNull("NGAY_CAP_CMND");
	}

	public void SetNGAY_CAP_CMNDNull()
	{
		pm_objDR["NGAY_CAP_CMND"] = System.Convert.DBNull;
	}

	public string strNOI_CAP_CMND 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "NOI_CAP_CMND", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["NOI_CAP_CMND"] = value;
		}
	}

	public bool IsNOI_CAP_CMNDNull() 
	{
		return pm_objDR.IsNull("NOI_CAP_CMND");
	}

	public void SetNOI_CAP_CMNDNull() {
		pm_objDR["NOI_CAP_CMND"] = System.Convert.DBNull;
	}

	public string strTRINH_DO 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TRINH_DO", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TRINH_DO"] = value;
		}
	}

	public bool IsTRINH_DONull() 
	{
		return pm_objDR.IsNull("TRINH_DO");
	}

	public void SetTRINH_DONull() {
		pm_objDR["TRINH_DO"] = System.Convert.DBNull;
	}

	public string strNOI_DAO_TAO 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "NOI_DAO_TAO", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["NOI_DAO_TAO"] = value;
		}
	}

	public bool IsNOI_DAO_TAONull() 
	{
		return pm_objDR.IsNull("NOI_DAO_TAO");
	}

	public void SetNOI_DAO_TAONull() {
		pm_objDR["NOI_DAO_TAO"] = System.Convert.DBNull;
	}

	public string strCHUYEN_NGANH 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "CHUYEN_NGANH", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["CHUYEN_NGANH"] = value;
		}
	}

	public bool IsCHUYEN_NGANHNull() 
	{
		return pm_objDR.IsNull("CHUYEN_NGANH");
	}

	public void SetCHUYEN_NGANHNull() {
		pm_objDR["CHUYEN_NGANH"] = System.Convert.DBNull;
	}

	public decimal dcNAM_TOT_NGHIEP 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "NAM_TOT_NGHIEP", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["NAM_TOT_NGHIEP"] = value;
		}
	}

	public bool IsNAM_TOT_NGHIEPNull()	{
		return pm_objDR.IsNull("NAM_TOT_NGHIEP");
	}

	public void SetNAM_TOT_NGHIEPNull() {
		pm_objDR["NAM_TOT_NGHIEP"] = System.Convert.DBNull;
	}

	public string strEMAIL_CQ 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "EMAIL_CQ", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["EMAIL_CQ"] = value;
		}
	}

	public bool IsEMAIL_CQNull() 
	{
		return pm_objDR.IsNull("EMAIL_CQ");
	}

	public void SetEMAIL_CQNull() {
		pm_objDR["EMAIL_CQ"] = System.Convert.DBNull;
	}

	public string strEMAIL_CA_NHAN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "EMAIL_CA_NHAN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["EMAIL_CA_NHAN"] = value;
		}
	}

	public bool IsEMAIL_CA_NHANNull() 
	{
		return pm_objDR.IsNull("EMAIL_CA_NHAN");
	}

	public void SetEMAIL_CA_NHANNull() {
		pm_objDR["EMAIL_CA_NHAN"] = System.Convert.DBNull;
	}

	public string strDT_NHA 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DT_NHA", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DT_NHA"] = value;
		}
	}

	public bool IsDT_NHANull() 
	{
		return pm_objDR.IsNull("DT_NHA");
	}

	public void SetDT_NHANull() {
		pm_objDR["DT_NHA"] = System.Convert.DBNull;
	}

	public string strDI_DONG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DI_DONG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DI_DONG"] = value;
		}
	}

	public bool IsDI_DONGNull() 
	{
		return pm_objDR.IsNull("DI_DONG");
	}

	public void SetDI_DONGNull() {
		pm_objDR["DI_DONG"] = System.Convert.DBNull;
	}

	public string strCHO_O 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "CHO_O", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["CHO_O"] = value;
		}
	}

	public bool IsCHO_ONull() 
	{
		return pm_objDR.IsNull("CHO_O");
	}

	public void SetCHO_ONull() {
		pm_objDR["CHO_O"] = System.Convert.DBNull;
	}

	public string strHO_KHAU 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "HO_KHAU", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["HO_KHAU"] = value;
		}
	}

	public bool IsHO_KHAUNull() 
	{
		return pm_objDR.IsNull("HO_KHAU");
	}

	public void SetHO_KHAUNull() {
		pm_objDR["HO_KHAU"] = System.Convert.DBNull;
	}

	public string strNGUOI_LIEN_HE 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "NGUOI_LIEN_HE", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["NGUOI_LIEN_HE"] = value;
		}
	}

	public bool IsNGUOI_LIEN_HENull() 
	{
		return pm_objDR.IsNull("NGUOI_LIEN_HE");
	}

	public void SetNGUOI_LIEN_HENull() {
		pm_objDR["NGUOI_LIEN_HE"] = System.Convert.DBNull;
	}

	public string strDI_DONG_LIEN_HE 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DI_DONG_LIEN_HE", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DI_DONG_LIEN_HE"] = value;
		}
	}

	public bool IsDI_DONG_LIEN_HENull() 
	{
		return pm_objDR.IsNull("DI_DONG_LIEN_HE");
	}

	public void SetDI_DONG_LIEN_HENull() {
		pm_objDR["DI_DONG_LIEN_HE"] = System.Convert.DBNull;
	}

	public string strQUAN_HE 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "QUAN_HE", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["QUAN_HE"] = value;
		}
	}

	public bool IsQUAN_HENull() 
	{
		return pm_objDR.IsNull("QUAN_HE");
	}

	public void SetQUAN_HENull() {
		pm_objDR["QUAN_HE"] = System.Convert.DBNull;
	}

	public string strTON_GIAO 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TON_GIAO", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TON_GIAO"] = value;
		}
	}

	public bool IsTON_GIAONull() 
	{
		return pm_objDR.IsNull("TON_GIAO");
	}

	public void SetTON_GIAONull() {
		pm_objDR["TON_GIAO"] = System.Convert.DBNull;
	}

	public string strDAN_TOC 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DAN_TOC", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DAN_TOC"] = value;
		}
	}

	public bool IsDAN_TOCNull() 
	{
		return pm_objDR.IsNull("DAN_TOC");
	}

	public void SetDAN_TOCNull() {
		pm_objDR["DAN_TOC"] = System.Convert.DBNull;
	}

	public string strMA_SO_THUE 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_SO_THUE", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_SO_THUE"] = value;
		}
	}

	public bool IsMA_SO_THUENull() 
	{
		return pm_objDR.IsNull("MA_SO_THUE");
	}

	public void SetMA_SO_THUENull() {
		pm_objDR["MA_SO_THUE"] = System.Convert.DBNull;
	}

	public string strTRANG_THAI 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TRANG_THAI", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TRANG_THAI"] = value;
		}
	}

	public bool IsTRANG_THAINull() 
	{
		return pm_objDR.IsNull("TRANG_THAI");
	}

	public void SetTRANG_THAINull() {
		pm_objDR["TRANG_THAI"] = System.Convert.DBNull;
	}

	public string strSO_TAI_KHOAN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "SO_TAI_KHOAN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["SO_TAI_KHOAN"] = value;
		}
	}

	public bool IsSO_TAI_KHOANNull() 
	{
		return pm_objDR.IsNull("SO_TAI_KHOAN");
	}

	public void SetSO_TAI_KHOANNull() {
		pm_objDR["SO_TAI_KHOAN"] = System.Convert.DBNull;
	}

	public string strCHI_NHANH_NGANHANG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "CHI_NHANH_NGANHANG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["CHI_NHANH_NGANHANG"] = value;
		}
	}

	public bool IsCHI_NHANH_NGANHANGNull() 
	{
		return pm_objDR.IsNull("CHI_NHANH_NGANHANG");
	}

	public void SetCHI_NHANH_NGANHANGNull() {
		pm_objDR["CHI_NHANH_NGANHANG"] = System.Convert.DBNull;
	}

	public string strDIA_DIEM_LV 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DIA_DIEM_LV", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DIA_DIEM_LV"] = value;
		}
	}

	public bool IsDIA_DIEM_LVNull() 
	{
		return pm_objDR.IsNull("DIA_DIEM_LV");
	}

	public void SetDIA_DIEM_LVNull() {
		pm_objDR["DIA_DIEM_LV"] = System.Convert.DBNull;
	}

	public string strHO_TEN_BO 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "HO_TEN_BO", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["HO_TEN_BO"] = value;
		}
	}

	public bool IsHO_TEN_BONull() 
	{
		return pm_objDR.IsNull("HO_TEN_BO");
	}

	public void SetHO_TEN_BONull() {
		pm_objDR["HO_TEN_BO"] = System.Convert.DBNull;
	}

	public string strNGHE_NGHIEP_BO 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "NGHE_NGHIEP_BO", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["NGHE_NGHIEP_BO"] = value;
		}
	}

	public bool IsNGHE_NGHIEP_BONull() 
	{
		return pm_objDR.IsNull("NGHE_NGHIEP_BO");
	}

	public void SetNGHE_NGHIEP_BONull() {
		pm_objDR["NGHE_NGHIEP_BO"] = System.Convert.DBNull;
	}

	public decimal dcNAM_SINH_BO 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "NAM_SINH_BO", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["NAM_SINH_BO"] = value;
		}
	}

	public bool IsNAM_SINH_BONull()	{
		return pm_objDR.IsNull("NAM_SINH_BO");
	}

	public void SetNAM_SINH_BONull() {
		pm_objDR["NAM_SINH_BO"] = System.Convert.DBNull;
	}

	public string strHO_TEN_ME 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "HO_TEN_ME", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["HO_TEN_ME"] = value;
		}
	}

	public bool IsHO_TEN_MENull() 
	{
		return pm_objDR.IsNull("HO_TEN_ME");
	}

	public void SetHO_TEN_MENull() {
		pm_objDR["HO_TEN_ME"] = System.Convert.DBNull;
	}

	public string strNGHE_NGHIEP_ME 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "NGHE_NGHIEP_ME", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["NGHE_NGHIEP_ME"] = value;
		}
	}

	public bool IsNGHE_NGHIEP_MENull() 
	{
		return pm_objDR.IsNull("NGHE_NGHIEP_ME");
	}

	public void SetNGHE_NGHIEP_MENull() {
		pm_objDR["NGHE_NGHIEP_ME"] = System.Convert.DBNull;
	}

	public decimal dcNAM_SINH_ME 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "NAM_SINH_ME", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["NAM_SINH_ME"] = value;
		}
	}

	public bool IsNAM_SINH_MENull()	{
		return pm_objDR.IsNull("NAM_SINH_ME");
	}

	public void SetNAM_SINH_MENull() {
		pm_objDR["NAM_SINH_ME"] = System.Convert.DBNull;
	}

	public string strHO_TEN_CON_THU_1 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "HO_TEN_CON_THU_1", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["HO_TEN_CON_THU_1"] = value;
		}
	}

	public bool IsHO_TEN_CON_THU_1Null() 
	{
		return pm_objDR.IsNull("HO_TEN_CON_THU_1");
	}

	public void SetHO_TEN_CON_THU_1Null() {
		pm_objDR["HO_TEN_CON_THU_1"] = System.Convert.DBNull;
	}

	public string strNGHE_NGHIEP_CON_THU_1 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "NGHE_NGHIEP_CON_THU_1", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["NGHE_NGHIEP_CON_THU_1"] = value;
		}
	}

	public bool IsNGHE_NGHIEP_CON_THU_1Null() 
	{
		return pm_objDR.IsNull("NGHE_NGHIEP_CON_THU_1");
	}

	public void SetNGHE_NGHIEP_CON_THU_1Null() {
		pm_objDR["NGHE_NGHIEP_CON_THU_1"] = System.Convert.DBNull;
	}

	public decimal dcNAM_SINH_CON_THU_1 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "NAM_SINH_CON_THU_1", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["NAM_SINH_CON_THU_1"] = value;
		}
	}

	public bool IsNAM_SINH_CON_THU_1Null()	{
		return pm_objDR.IsNull("NAM_SINH_CON_THU_1");
	}

	public void SetNAM_SINH_CON_THU_1Null() {
		pm_objDR["NAM_SINH_CON_THU_1"] = System.Convert.DBNull;
	}

	public string strHO_TEN_CON_THU_2 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "HO_TEN_CON_THU_2", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["HO_TEN_CON_THU_2"] = value;
		}
	}

	public bool IsHO_TEN_CON_THU_2Null() 
	{
		return pm_objDR.IsNull("HO_TEN_CON_THU_2");
	}

	public void SetHO_TEN_CON_THU_2Null() {
		pm_objDR["HO_TEN_CON_THU_2"] = System.Convert.DBNull;
	}

	public string strNGHE_NGHIEP_CON_THU_2 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "NGHE_NGHIEP_CON_THU_2", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["NGHE_NGHIEP_CON_THU_2"] = value;
		}
	}

	public bool IsNGHE_NGHIEP_CON_THU_2Null() 
	{
		return pm_objDR.IsNull("NGHE_NGHIEP_CON_THU_2");
	}

	public void SetNGHE_NGHIEP_CON_THU_2Null() {
		pm_objDR["NGHE_NGHIEP_CON_THU_2"] = System.Convert.DBNull;
	}

	public decimal dcNAM_SINH_CON_THU_2 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "NAM_SINH_CON_THU_2", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["NAM_SINH_CON_THU_2"] = value;
		}
	}

	public bool IsNAM_SINH_CON_THU_2Null()	{
		return pm_objDR.IsNull("NAM_SINH_CON_THU_2");
	}

	public void SetNAM_SINH_CON_THU_2Null() {
		pm_objDR["NAM_SINH_CON_THU_2"] = System.Convert.DBNull;
	}

	public string strHO_TEN_CON_THU_3 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "HO_TEN_CON_THU_3", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["HO_TEN_CON_THU_3"] = value;
		}
	}

	public bool IsHO_TEN_CON_THU_3Null() 
	{
		return pm_objDR.IsNull("HO_TEN_CON_THU_3");
	}

	public void SetHO_TEN_CON_THU_3Null() {
		pm_objDR["HO_TEN_CON_THU_3"] = System.Convert.DBNull;
	}

	public string strNGHE_NGHIEP_CON_THU_3 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "NGHE_NGHIEP_CON_THU_3", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["NGHE_NGHIEP_CON_THU_3"] = value;
		}
	}

	public bool IsNGHE_NGHIEP_CON_THU_3Null() 
	{
		return pm_objDR.IsNull("NGHE_NGHIEP_CON_THU_3");
	}

	public void SetNGHE_NGHIEP_CON_THU_3Null() {
		pm_objDR["NGHE_NGHIEP_CON_THU_3"] = System.Convert.DBNull;
	}

	public decimal dcNAM_SINH_CON_THU_3 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "NAM_SINH_CON_THU_3", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["NAM_SINH_CON_THU_3"] = value;
		}
	}

	public bool IsNAM_SINH_CON_THU_3Null()	{
		return pm_objDR.IsNull("NAM_SINH_CON_THU_3");
	}

	public void SetNAM_SINH_CON_THU_3Null() {
		pm_objDR["NAM_SINH_CON_THU_3"] = System.Convert.DBNull;
	}

	public string strHO_TEN_VO_OR_CHONG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "HO_TEN_VO_OR_CHONG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["HO_TEN_VO_OR_CHONG"] = value;
		}
	}

	public bool IsHO_TEN_VO_OR_CHONGNull() 
	{
		return pm_objDR.IsNull("HO_TEN_VO_OR_CHONG");
	}

	public void SetHO_TEN_VO_OR_CHONGNull() {
		pm_objDR["HO_TEN_VO_OR_CHONG"] = System.Convert.DBNull;
	}

	public string strNGHE_NGHIEP_VO_OR_CHONG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "NGHE_NGHIEP_VO_OR_CHONG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["NGHE_NGHIEP_VO_OR_CHONG"] = value;
		}
	}

	public bool IsNGHE_NGHIEP_VO_OR_CHONGNull() 
	{
		return pm_objDR.IsNull("NGHE_NGHIEP_VO_OR_CHONG");
	}

	public void SetNGHE_NGHIEP_VO_OR_CHONGNull() {
		pm_objDR["NGHE_NGHIEP_VO_OR_CHONG"] = System.Convert.DBNull;
	}

	public decimal dcNAM_SINH_VO_OR_CHONG 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "NAM_SINH_VO_OR_CHONG", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["NAM_SINH_VO_OR_CHONG"] = value;
		}
	}

	public bool IsNAM_SINH_VO_OR_CHONGNull()	{
		return pm_objDR.IsNull("NAM_SINH_VO_OR_CHONG");
	}

	public void SetNAM_SINH_VO_OR_CHONGNull() {
		pm_objDR["NAM_SINH_VO_OR_CHONG"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_DM_CTV() 
	{
		pm_objDS = new DS_DM_CTV();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_DM_CTV(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_DM_CTV(decimal i_dbID) 
	{
		pm_objDS = new DS_DM_CTV();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion
	}
}

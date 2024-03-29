///************************************************
/// Generated by: AnhLT
/// Date: 09/05/2014 06:39:20
/// Goal: Create User Service Class for RPT_DON_VI_TRANG_THAI
///************************************************
/// <summary>
/// Create User Service Class for RPT_DON_VI_TRANG_THAI
/// </summary>

using System;
using BKI_HRM.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_HRM.US{

public class US_RPT_DON_VI_TRANG_THAI : US_Object
{
	private const string c_TableName = "RPT_DON_VI_TRANG_THAI";
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

	public decimal dcID_DV 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_DV", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_DV"] = value;
		}
	}

	public bool IsID_DVNull()	{
		return pm_objDR.IsNull("ID_DV");
	}

	public void SetID_DVNull() {
		pm_objDR["ID_DV"] = System.Convert.DBNull;
	}

	public string strMA_DON_VI 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_DON_VI", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_DON_VI"] = value;
		}
	}

	public bool IsMA_DON_VINull() 
	{
		return pm_objDR.IsNull("MA_DON_VI");
	}

	public void SetMA_DON_VINull() {
		pm_objDR["MA_DON_VI"] = System.Convert.DBNull;
	}

	public decimal dcID_DON_VI_CAP_TREN 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_DON_VI_CAP_TREN", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_DON_VI_CAP_TREN"] = value;
		}
	}

	public bool IsID_DON_VI_CAP_TRENNull()	{
		return pm_objDR.IsNull("ID_DON_VI_CAP_TREN");
	}

	public void SetID_DON_VI_CAP_TRENNull() {
		pm_objDR["ID_DON_VI_CAP_TREN"] = System.Convert.DBNull;
	}

	public string strMA_DON_VI_CAP_TEN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_DON_VI_CAP_TEN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_DON_VI_CAP_TEN"] = value;
		}
	}

	public bool IsMA_DON_VI_CAP_TENNull() 
	{
		return pm_objDR.IsNull("MA_DON_VI_CAP_TEN");
	}

	public void SetMA_DON_VI_CAP_TENNull() {
		pm_objDR["MA_DON_VI_CAP_TEN"] = System.Convert.DBNull;
	}

	public decimal dcID_TRANG_THAI 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_TRANG_THAI", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_TRANG_THAI"] = value;
		}
	}

	public bool IsID_TRANG_THAINull()	{
		return pm_objDR.IsNull("ID_TRANG_THAI");
	}

	public void SetID_TRANG_THAINull() {
		pm_objDR["ID_TRANG_THAI"] = System.Convert.DBNull;
	}

	public string strMA_TU_DIEN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_TU_DIEN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_TU_DIEN"] = value;
		}
	}

	public bool IsMA_TU_DIENNull() 
	{
		return pm_objDR.IsNull("MA_TU_DIEN");
	}

	public void SetMA_TU_DIENNull() {
		pm_objDR["MA_TU_DIEN"] = System.Convert.DBNull;
	}

	public decimal dcSO_LUONG 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "SO_LUONG", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["SO_LUONG"] = value;
		}
	}

	public bool IsSO_LUONGNull()	{
		return pm_objDR.IsNull("SO_LUONG");
	}

	public void SetSO_LUONGNull() {
		pm_objDR["SO_LUONG"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_RPT_DON_VI_TRANG_THAI() 
	{
		pm_objDS = new DS_RPT_DON_VI_TRANG_THAI();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_RPT_DON_VI_TRANG_THAI(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_RPT_DON_VI_TRANG_THAI(decimal i_dbID) 
	{
		pm_objDS = new DS_RPT_DON_VI_TRANG_THAI();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion
    public void FillDatasetByProc(DS_RPT_DON_VI_TRANG_THAI op_ds_rpt, DateTime ip_dat_thoi_diem, decimal ip_dc_phap_nhan)
    {
        CStoredProc v_sp = new CStoredProc("pr_RPT_DON_VI_TRANG_THAI");
        v_sp.addDatetimeInputParam("@THOI_DIEM", ip_dat_thoi_diem);
        v_sp.addDecimalInputParam("@ID_PHAP_NHAN",ip_dc_phap_nhan);
        v_sp.fillDataSetByCommand(this, op_ds_rpt);
    }
	}
}

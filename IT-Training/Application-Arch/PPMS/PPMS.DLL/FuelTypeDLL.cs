using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PPMS.DTO;
using System.Data.SqlClient;
using System.Data;

namespace PPMS.DLL
{
    public class FuelTypeDLL
    {
        DBAccess db;

        public bool NewFuelType(FuelTypeDTO fuleTypeDTO)
        {
            string sql = "Insert into FuleTypes (FuelTypeName) values ("+
                "'"+fuleTypeDTO.FuleTypeName+@"')";
            db = new DBAccess();
            int rows_affected = db.ExecuteNonQuery(sql);
            if (rows_affected == 1) return true;
            else return false;
        }
        public bool UpdateFuelType(FuelTypeDTO fuleTypeDTO)
        {
            string sql = "update FuleTypes set FuelTypeName='" + fuleTypeDTO.FuleTypeName
                + @"' where FuelTypeID =" + fuleTypeDTO.FuelTypeID;
            db = new DBAccess();
            int rows_affected = db.ExecuteNonQuery(sql);
            if (rows_affected == 1) return true;
            else return false;
        }

        public bool DeleteFuelType(int fuelTypeID)
        {
            string sql = " Delete  FuelTypes where FuelTypeID =" + fuelTypeID;
            db = new DBAccess();
            int rows_affected = db.ExecuteNonQuery(sql);
            if (rows_affected == 1) return true;
            else return false;
        }
        public FuelTypeDTO GetFuelType(int fuelTypeID)
        {
            db = new DBAccess();
            DataTable dt = new DataTable();
            string sql = "Select * from FuelTypes where FuelTypeID=" + fuelTypeID;
            dt = db.ExecuteDataTable(sql);
            if (dt.Rows.Count <= 0)
            {
                return null;
            }
            else
            {
                FuelTypeDTO fuelTypeDTO = new FuelTypeDTO();
                fuelTypeDTO.FuelTypeID = int.Parse(dt.Rows[0]["FuelTypeID"].ToString());
                fuelTypeDTO.FuleTypeName = dt.Rows[0]["FuleTypeName"].ToString();
                return fuelTypeDTO;
            }
        }

        public DataTable GetFuelTypes()
        {
            db = new DBAccess();
            DataTable dt = new DataTable();
            string sql = "Select * from FuelTypes ";
            dt = db.ExecuteDataTable(sql);
            if (dt.Rows.Count <= 0)
            {
                return null;
            }
            else
            {
                return dt;
            }
        }

    }
}

using PPMS.DLL;
using PPMS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMS.BLL
{
    public class FuelTypeBLL
    {
        FuelTypeDLL fuelTypeDLL;
        public bool NewFuelType(FuelTypeDTO fuelTypeDTO)
        {
            fuelTypeDLL = new FuelTypeDLL();
            return fuelTypeDLL.NewFuelType(fuelTypeDTO);
        }
        public bool UpdateFuelType(FuelTypeDTO fuelTypeDTO)
        {
            fuelTypeDLL = new FuelTypeDLL();
            return fuelTypeDLL.UpdateFuelType(fuelTypeDTO);
        }

        public bool DeleteFuelType(int fuelTypeID)
        {
            fuelTypeDLL = new FuelTypeDLL();
            return fuelTypeDLL.DeleteFuelType(fuelTypeID);
        }
        public FuelTypeDTO GetFuelType(int fuelTypeID)
        {
            fuelTypeDLL = new FuelTypeDLL();
            return fuelTypeDLL.GetFuelType(fuelTypeID);
        }

        public DataTable GetFuelTypes()
        {
            fuelTypeDLL = new FuelTypeDLL();
            return fuelTypeDLL.GetFuelTypes();
        }
    }
}

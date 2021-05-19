﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTL;
using DAL;
namespace BUS
{
    public class BUS_StatusData
    {
        private static BUS_StatusData _Instance;
        public static BUS_StatusData Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BUS_StatusData();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        public List<StatusShow> BUS_StatusShow()
        {
            return DAL_StatusData.Instance.DAL_StatusShow();
        }
        public void BUS_SETSTATUS(STATUS rm)
        {
            DAL_StatusData.Instance.DAL_SETSTATUS(rm);
        }
        public void BUS_DELETESTATUS(string statusid)
        {
            DAL_StatusData.Instance.DAL_DELETESTATUS(statusid);
        }
        public void BUS_UPDATESTATUS(STATUS rm2, string statusid)
        {
            DAL_StatusData.Instance.DAL_UPDATESTATUS(rm2, statusid);
        }
        public STATUS BUS_getStatusByIDStatus(string statusid)
        {
            return DAL_StatusData.Instance.DAL_getStatusByIDStatus(statusid);
        }
        public List<STATUS> BUS_SortZoneByIdStatus()
        {
            return DAL_StatusData.Instance.DAL_SortZoneByIdStatus();

        }
        public List<STATUS> BUS_SortZoneByIdEquipment()
        {
            return DAL_StatusData.Instance.DAL_SortZoneByIdEquipment();
        }
        public List<STATUS> BUS_SortZoneByEquipmentStatus()
        {
            return DAL_StatusData.Instance.DAL_SortZoneByEquipmentStatus();
        }
        public int BUS_CHECKSTATUS(STATUS st)
        {
            return DAL_StatusData.Instance.DAL_CHECKSTATUS(st);
        }
        public List<StatusShow> BUS_StatusShowForIDEquipment(string equipmentid)
        {
            return DAL_StatusData.Instance.DAL_StatusShowForIDEquipment(equipmentid);
        }
    }
}
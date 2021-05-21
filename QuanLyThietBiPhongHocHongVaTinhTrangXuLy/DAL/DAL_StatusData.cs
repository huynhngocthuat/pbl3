﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTL;
namespace DAL
{
    public class DAL_StatusData
    {

        private MVH_10Entities db;
        private static DAL_StatusData _Instance;
        public static DAL_StatusData Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_StatusData();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private DAL_StatusData()
        {
            db = new MVH_10Entities();
        }
        public List<StatusShow> DAL_StatusShow()
        {
            List<StatusShow> listStatusShow = new List<StatusShow>();
            var l1 = (from status in db.STATUS

                      select new
                      {
                          statusID = status.statusId,
                          equipmentID = status.equipmentId,
                          equipmentStatus = status.equipmentStatus,
                      });
            foreach (var item in l1)
            {
                listStatusShow.Add(new StatusShow
                {
                    statusID = item.statusID,
                    equipmentID = item.equipmentID,
                    equipmentStatus = item.equipmentStatus

                });
            }
            return listStatusShow;
        }
        public void DAL_SETSTATUS(STATUS rm)
        {
            db.STATUS.Add(rm);
            db.SaveChanges();
        }
        public int DAL_CHECKSTATUS(STATUS st)
        {
            int a = 1;
            foreach (var i in db.STATUS)
            {
                if (i.statusId == st.statusId)
                {
                    a = 0;
                    break;
                }
            }
            return a;
        }
        public void DAL_DELETESTATUS(string statusid)
        {
            STATUS rm = db.STATUS.Where(p => p.statusId == statusid).SingleOrDefault();
            db.STATUS.Remove(rm);
            db.SaveChanges();
        }
        public void DAL_UPDATESTATUS(STATUS rm2, string statusid)
        {
            var sup = db.STATUS.Where(p => p.statusId == statusid).SingleOrDefault();
            sup.statusId = rm2.statusId;
            sup.equipmentId = rm2.equipmentId;
            sup.equipmentStatus = rm2.equipmentStatus;
            db.SaveChanges();
        }

        public STATUS DAL_getStatusByIDStatus(string statusid)
        {
            STATUS rm = new STATUS();
            var sup = db.STATUS.Where(p => p.statusId == statusid).SingleOrDefault();
            rm.statusId = sup.statusId;
            rm.equipmentId = sup.equipmentId;
            rm.equipmentStatus = sup.equipmentStatus;
            return rm;
        }
        public List<STATUS> DAL_SortZoneByIdStatus()
        {
            List<STATUS> oldList = DAL_MainData.Instance.DAL_getStatus();
            List<STATUS> newList = new List<STATUS>();
            newList = oldList.OrderBy(z => z.statusId).ToList();
            return newList;
        }
        public List<STATUS> DAL_SortZoneByIdEquipment()
        {
            List<STATUS> oldList = DAL_MainData.Instance.DAL_getStatus();
            List<STATUS> newList = new List<STATUS>();
            newList = oldList.OrderBy(z => z.equipmentId).ToList();
            return newList;
        }
        public List<STATUS> DAL_SortZoneByEquipmentStatus()
        {
            List<STATUS> oldList = DAL_MainData.Instance.DAL_getStatus();
            List<STATUS> newList = new List<STATUS>();
            newList = oldList.OrderBy(z => z.equipmentStatus).ToList();
            return newList;
        }
        public List<StatusShow> DAL_StatusShowForIDEquipment(string equipmentId)
        {
            List<StatusShow> listStatusShow = new List<StatusShow>();
            var l1 = (from status in db.STATUS
                      where status.equipmentId == equipmentId

                      select new
                      {
                          statusID = status.statusId,
                          equipmentID = status.equipmentId,
                          equipmentStatus = status.equipmentStatus
                      });
            foreach (var item in l1)
            {
                listStatusShow.Add(new StatusShow
                {
                    statusID = item.statusID,
                    equipmentID = item.equipmentID,
                    equipmentStatus = item.equipmentStatus
                });
            }
            return listStatusShow;
        }
    }
}

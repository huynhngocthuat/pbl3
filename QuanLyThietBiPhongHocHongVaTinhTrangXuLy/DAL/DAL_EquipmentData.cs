using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTL;

namespace DAL
{
    public class DAL_EquipmentData
    {

        private MVH_10Entities db;
        private static DAL_EquipmentData _Instance;
        public static DAL_EquipmentData Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_EquipmentData();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private DAL_EquipmentData()
        {
            db = new MVH_10Entities();
        }
        public List<EquipmentShow> DAL_EquipmentShow()
        {
            List<EquipmentShow> listEquipmentShow = new List<EquipmentShow>();
            var l1 = (from equipment in db.EQUIPMENTs
                      select new
                      {
                          equipmentID = equipment.equipmentId,
                          roomID = equipment.roomId,
                          equipmentName = equipment.equipmentName,
                          dateOfInstallation = equipment.dateOfInstallation,
                          company = equipment.company
                      });
            foreach (var item in l1)
            {
                listEquipmentShow.Add(new EquipmentShow
                {
                    equipmentID = item.equipmentID,
                    roomID = item.roomID,
                    equipmentName = item.equipmentName,
                    dateOfInstallation = item.dateOfInstallation.Value,
                    company = item.company
                });
            }
            return listEquipmentShow;
        }
        public void DAL_SETEQUIPMENT(EQUIPMENT eq)
        {
            db.EQUIPMENTs.Add(eq);
            db.SaveChanges();
        }
        public int DAL_CHECKEQUIPMENT(EQUIPMENT eq)
        {
            int a = 1;
            foreach (var i in db.EQUIPMENTs)
            {
                if (i.equipmentId == eq.equipmentId)
                {
                    a = 0;
                    break;
                }
            }
            return a;
        }

        public void DAL_DELETEEQUIPMENT(string equipmentid)
        {
            EQUIPMENT eq = db.EQUIPMENTs.Where(p => p.equipmentId == equipmentid).SingleOrDefault();
            db.EQUIPMENTs.Remove(eq);
            db.SaveChanges();
        }
        public void DAL_UPDATEEQUIPMENT(EQUIPMENT eq2, string equipmentid)
        {
            var sup = db.EQUIPMENTs.Where(p => p.equipmentId == equipmentid).SingleOrDefault();
            sup.roomId = eq2.roomId;
            sup.equipmentId = eq2.equipmentId;
            sup.equipmentName = eq2.equipmentName;
            sup.company = eq2.company;
            sup.dateOfInstallation = eq2.dateOfInstallation;
            db.SaveChanges();
        }
        public List<EQUIPMENT> DAL_SortEquipmentByIdEquipment()
        {
            List<EQUIPMENT> oldList = DAL_MainData.Instance.DAL_getEquipment();
            List<EQUIPMENT> newList = new List<EQUIPMENT>();
            newList = oldList.OrderBy(z => z.equipmentId).ToList();
            return newList;
        }
        public List<EQUIPMENT> DAL_SortEquipmentByName()
        {
            List<EQUIPMENT> oldList = DAL_MainData.Instance.DAL_getEquipment();
            List<EQUIPMENT> newList = new List<EQUIPMENT>();
            newList = oldList.OrderBy(z => z.equipmentName).ToList();
            return newList;
        }
        public List<EQUIPMENT> DAL_SortEquipmentByDate()
        {
            List<EQUIPMENT> oldList = DAL_MainData.Instance.DAL_getEquipment();
            List<EQUIPMENT> newList = new List<EQUIPMENT>();
            newList = oldList.OrderBy(z => z.dateOfInstallation).ToList();
            return newList;
        }
        public List<EQUIPMENT> DAL_SortEquipmentByCompany()
        {
            List<EQUIPMENT> oldList = DAL_MainData.Instance.DAL_getEquipment();
            List<EQUIPMENT> newList = new List<EQUIPMENT>();
            newList = oldList.OrderBy(z => z.company).ToList();
            return newList;
        }
        public List<EQUIPMENT> DAL_SortEquipmentByIdRoom()
        {
            List<EQUIPMENT> oldList = DAL_MainData.Instance.DAL_getEquipment();
            List<EQUIPMENT> newList = new List<EQUIPMENT>();
            newList = oldList.OrderBy(z => z.roomId).ToList();
            return newList;
        }
        public List<EquipmentShow> DAL_ShowEquipmentByRoomId(string roomId)
        {
            List<EquipmentShow> listEquipmentShow = new List<EquipmentShow>();
            var l1 = (from equipment in db.EQUIPMENTs
                      where equipment.roomId == roomId
                      select new
                      {
                          equipmentID = equipment.equipmentId,
                          roomID = equipment.roomId,
                          equipmentName = equipment.equipmentName,
                          dateOfInstallation = equipment.dateOfInstallation,
                          company = equipment.company
                      });
            foreach (var item in l1)
            {
                listEquipmentShow.Add(new EquipmentShow
                {
                    equipmentID = item.equipmentID,
                    roomID = item.roomID,
                    equipmentName = item.equipmentName,
                    dateOfInstallation = item.dateOfInstallation.Value,
                    company = item.company

                });
            }
            return listEquipmentShow;
        }
    }
}

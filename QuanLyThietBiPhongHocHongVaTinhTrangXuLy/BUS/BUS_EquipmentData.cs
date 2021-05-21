using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTL;
using DAL;
namespace BUS
{
    public class BUS_EquipmentData
    {
        EQUIPMENT ac = new EQUIPMENT();
        private static BUS_EquipmentData _Instance;
        public static BUS_EquipmentData Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BUS_EquipmentData();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        public List<EquipmentShow> BUS_EquipmentShow(string text)
        {
            List<EquipmentShow> list = new List<EquipmentShow>();
            foreach (EquipmentShow item in DAL_EquipmentData.Instance.DAL_EquipmentShow())
            {
                if (item.roomID.Contains(text))
                {
                    list.Add(item);
                }
            }
            return list;
        }
        public void BUS_SETEQUIPMENT(EQUIPMENT eq)
        {
            DAL_EquipmentData.Instance.DAL_SETEQUIPMENT(eq);
        }
        public void BUS_DELETEEQUIPMENT(string equipmentid)
        {
            DAL_EquipmentData.Instance.DAL_DELETEEQUIPMENT(equipmentid);
        }
        public void BUS_UPDATEEQUIPMENT(EQUIPMENT eq2, string equipmentid)
        {
            DAL_EquipmentData.Instance.DAL_UPDATEEQUIPMENT(eq2, equipmentid);
        }
        public EquipmentShow BUS_getEquipmentByIDEquipment(string equipmentid)
        {
            foreach (EquipmentShow item in DAL_EquipmentData.Instance.DAL_EquipmentShow())
            {
                if (item.equipmentID == equipmentid)
                {
                    return item;
                }
            }
            return null;
        }
        public List<EQUIPMENT> BUS_SortEquipmentByIdEquipment()
        {
            return DAL_EquipmentData.Instance.DAL_SortEquipmentByIdEquipment();
        }
        public List<EQUIPMENT> BUS_SortEquipmentByName()
        {
            return DAL_EquipmentData.Instance.DAL_SortEquipmentByName();
        }
        public List<EQUIPMENT> BUS_SortEquipmentByDate()
        {
            return DAL_EquipmentData.Instance.DAL_SortEquipmentByDate();
        }
        public List<EQUIPMENT> BUS_SortEquipmentByCompany()
        {
            return DAL_EquipmentData.Instance.DAL_SortEquipmentByCompany();
        }
        public List<EQUIPMENT> BUS_SortEquipmentByIdRoom()
        {
            return DAL_EquipmentData.Instance.DAL_SortEquipmentByIdRoom();
        }
        public int BUS_CHECKEQUIPMENT(EQUIPMENT eq)
        {
            return DAL_EquipmentData.Instance.DAL_CHECKEQUIPMENT(eq);
        }
        public List<EquipmentShow> BUS_ShowEquipmentByRoomId(string roomId)
        {
            return DAL_EquipmentData.Instance.DAL_ShowEquipmentByRoomId(roomId);
        }
        public List<EquipmentShow> BUS_EquipmentShow()
        {
            return DAL_EquipmentData.Instance.DAL_EquipmentShow();
        }
    }
}

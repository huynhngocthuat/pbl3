using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTL;
using DAL;
namespace BUS
{
    public class BUS_RoomData
    {
        private static BUS_RoomData _Instance;
        public static BUS_RoomData Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BUS_RoomData();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        public List<RoomShow> BUS_RoomShow()
        {
            return DAL_RoomData.Instance.DAL_RoomShow();
        }
        public List<RoomShow> BUS_GetRoomShow()
        {
            return DAL_RoomData.Instance.DAL_GetRoomShow();
        }
        public List<RoomShow> BUS_RoomShowByIDZone(string zoneid)
        {
            List<RoomShow> list = new List<RoomShow>();
            foreach (ROOM item in DAL_RoomData.Instance.getRoomByIDZone(zoneid))
            {
                list.Add(new RoomShow
                {
                    zoneID = item.zoneId,
                    roomID = item.roomId,
                    roomFunciton = item.roomFunction
                });
            }
            return list;
        }
        public void BUS_SETROOM(ROOM rm)
        {
            DAL_RoomData.Instance.DAL_SetRoom(rm);
        }
        public void BUS_DELETEROOM(string roomid)
        {
            DAL_RoomData.Instance.DAL_DeleteRoom(roomid);
        }
        public void BUS_UPDATEROOM(ROOM rm2)
        {
            DAL_RoomData.Instance.DAL_UpdateRoom(rm2);
        }
        public ROOM BUS_getRoomByIDRoom(string roomid)
        {
            foreach (ROOM item in BUS_MainData.Instance.BUS_ROOM())
            {
                if (item.roomId == roomid)
                {
                    return item;
                }
            }
            return null;
        }
        public int BUS_CHECKROOM(ROOM rm)
        {
            return DAL_RoomData.Instance.DAL_CheckRoom(rm);
        }
        public List<RoomShow> BUS_Sort(string cbbitem)
        {
            string item = cbbitem;
            switch (item)
            {
                case "roomId":
                    {
                        return BUS_GetRoomShow().OrderBy(o => o.roomID).ToList();
                    }
                case "zoneId":
                    {
                        return BUS_GetRoomShow().OrderBy(o => o.zoneID).ToList();
                    }
                case "roomFunction":
                    {
                        return BUS_GetRoomShow().OrderBy(o => o.roomFunciton).ToList();
                    }
                default:
                    {
                        return BUS_GetRoomShow();
                    }
            }
        }
    }
}

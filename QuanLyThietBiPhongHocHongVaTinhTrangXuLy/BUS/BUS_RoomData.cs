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
        public List<RoomShow> BUS_RoomShowForIDZone(string zoneid)
        {
            return DAL_RoomData.Instance.DAL_RoomShowForIDZone(zoneid);
        }
        public void BUS_SETROOM(ROOM rm)
        {
            DAL_RoomData.Instance.DAL_SETROOM(rm);
        }
        public void BUS_DELETEROOM(string roomid)
        {
            DAL_RoomData.Instance.DAL_DELETEROOM(roomid);
        }
        public void BUS_UPDATEROOM(ROOM rm2, string roomid)
        {
            DAL_RoomData.Instance.DAL_UPDATEROOM(rm2, roomid);
        }
        public ROOM BUS_getRoomByIDRoom(string roomid)
        {
            return DAL_RoomData.Instance.DAL_getRoomByIDRoom(roomid);
        }
        public List<ROOM> BUS_SortRoomByIdRoom()
        {
            return DAL_RoomData.Instance.DAL_SortRoomByIdRoom();
        }
        public List<ROOM> BUS_SortRoomByIdZone()
        {
            return DAL_RoomData.Instance.DAL_SortRoomByIdZone();
        }
        public List<ROOM> BUS_SortRoomByRoomFuntion()
        {
            return DAL_RoomData.Instance.DAL_SortRoomByRoomFuntion();
        }
        public int BUS_CHECKROOM(ROOM rm)
        {
            return DAL_RoomData.Instance.DAL_CHECKROOM(rm);
        }
    }
}

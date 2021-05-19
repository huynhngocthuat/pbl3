using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTL;
namespace DAL
{
    public class DAL_RoomData
    {
        private MVH_10Entities db;
        private static DAL_RoomData _Instance;
        public static DAL_RoomData Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_RoomData();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private DAL_RoomData()
        {
            db = new MVH_10Entities();
        }
        public List<RoomShow> DAL_RoomShow()
        {
            List<RoomShow> listRoomShow = new List<RoomShow>();
            var l1 = (from room in db.ROOMs

                      select new
                      {
                          roomID = room.roomId,
                          zoneID = room.zoneId,
                          roomFunction = room.roomFunction,
                      });
            foreach (var item in l1)
            {
                listRoomShow.Add(new RoomShow
                {
                    roomID = item.roomID,
                    zoneID = item.zoneID,
                    roomFunciton = item.roomFunction

                });
            }
            return listRoomShow;
        }
        public List<RoomShow> DAL_RoomShowForIDZone(string zoneid)
        {
            List<RoomShow> listRoomShow = new List<RoomShow>();
            var l1 = (from room in db.ROOMs
                      where room.zoneId == zoneid
                      select new
                      {
                          roomID = room.roomId,
                          zoneID = room.zoneId,
                          roomFunction = room.roomFunction,
                      });
            foreach (var item in l1)
            {
                listRoomShow.Add(new RoomShow
                {
                    roomID = item.roomID,
                    zoneID = item.zoneID,
                    roomFunciton = item.roomFunction

                });
            }
            return listRoomShow;
        }
        public void DAL_SETROOM(ROOM rm)
        {
            db.ROOMs.Add(rm);
            db.SaveChanges();
        }
        public int DAL_CHECKROOM(ROOM rm)
        {
            int a = 1;
            foreach (var i in db.ROOMs)
            {
                if (i.roomId == rm.roomId)
                {
                    a = 0;
                    break;
                }
            }
            return a;
        }
        public void DAL_DELETEROOM(string roomid)
        {
            ROOM rm = db.ROOMs.Where(p => p.roomId == roomid).SingleOrDefault();
            db.ROOMs.Remove(rm);
            db.SaveChanges();
        }
        public void DAL_UPDATEROOM(ROOM rm2, string roomid)
        {
            var sup = db.ROOMs.Where(p => p.roomId == roomid).SingleOrDefault();
            sup.roomId = rm2.roomId;
            sup.zoneId = rm2.zoneId;
            sup.roomFunction = rm2.roomFunction;
            db.SaveChanges();
        }

        public ROOM DAL_getRoomByIDRoom(string roomid)
        {
            ROOM rm = new ROOM();
            var sup = db.ROOMs.Where(p => p.roomId == roomid).SingleOrDefault();
            rm.roomId = sup.roomId;
            rm.zoneId = sup.zoneId;
            rm.roomFunction = sup.roomFunction;
            return rm;
        }
        public List<ROOM> DAL_SortRoomByIdRoom()
        {
            List<ROOM> oldRoomList = DAL_MainData.Instance.DAL_getRoom();
            List<ROOM> newRoomList = new List<ROOM>();
            newRoomList = oldRoomList.OrderBy(z => z.roomId).ToList();
            return newRoomList;
        }
        public List<ROOM> DAL_SortRoomByIdZone()
        {
            List<ROOM> oldRoomList = DAL_MainData.Instance.DAL_getRoom();
            List<ROOM> newRoomList = new List<ROOM>();
            newRoomList = oldRoomList.OrderBy(z => z.zoneId).ToList();
            return newRoomList;
        }
        public List<ROOM> DAL_SortRoomByRoomFuntion()
        {
            List<ROOM> oldRoomList = DAL_MainData.Instance.DAL_getRoom();
            List<ROOM> newRoomList = new List<ROOM>();
            newRoomList = oldRoomList.OrderBy(z => z.roomFunction).ToList();
            return newRoomList;
        }
    }
}

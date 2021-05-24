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
        public List<RoomShow> DAL_GetRoomShow()
        {           
            var la = (from c in db.ROOMs select 
                      new RoomShow{
                                       roomID = c.roomId,
                                       zoneID = c.zoneId,
                                       roomFunciton = c.roomFunction
                      }).ToList();
            return la.ToList<RoomShow>();
        }

        public void DAL_SetRoom(ROOM rm)
        {
            db.ROOMs.Add(rm);
            db.SaveChanges();
        }
        public int DAL_CheckRoom(ROOM rm)
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
        public void DAL_DeleteRoom(string roomid)
        {
            ROOM rm = db.ROOMs.Where(p => p.roomId == roomid).SingleOrDefault();
            db.ROOMs.Remove(rm);
            db.SaveChanges();
        }
        public void DAL_UpdateRoom(ROOM rm2, string roomid)
        {
            var sup = db.ROOMs.Where(p => p.roomId == roomid).SingleOrDefault();
            sup.roomId = rm2.roomId;
            sup.zoneId = rm2.zoneId;
            sup.roomFunction = rm2.roomFunction;
            db.SaveChanges();
        }
        public List<ROOM> getRoomByIDZone(string zoneId)
        {
            return db.ROOMs.Where(p => p.zoneId == zoneId).ToList<ROOM>();
        }
    }
}

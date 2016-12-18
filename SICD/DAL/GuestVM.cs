using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SICD.DAL;
using SICD.Models;

namespace SICD.DAL
{
    public class GuestVM :IDisposable
    {
        private GuestModel db = new GuestModel();
        public void Dispose()
        {
            db.Dispose();
        }

        public IQueryable<GuestList> GetData()

        {
            //var hsl = from g in db.GuestLists orderby g.GuestName select g;
            var res = from g in db.GuestLists orderby g.GuestName select g;
            return res;
        }

        public GuestList GetDataByID(int lstID)
        {
            var res = (from g in db.GuestLists where g.ListID == lstID select g).SingleOrDefault();
            return res;
        }
        public GuestList GetDataByUser(string name)
        {
            var res = (from g in db.GuestLists where g.GuestName == name select g).SingleOrDefault();
            return res;
        }
        public void Add(GuestList obj)
        {
            try
            {
                db.GuestLists.Add(obj);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public void Delete(int lstId)
        {
            var res = GetDataByID(lstId);
            if (res != null)
            {
                db.GuestLists.Remove(res);
            }
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Meow.Models;
using System.Data.Entity;

namespace Meow.Models
{
    
    public class UyeRepository:IRepository<Uye>
    {
        MeowbookEntities1 db = new MeowbookEntities1();
        public void Insert(Uye item)
        {
            db.Uye.Add(item);
            db.SaveChanges();
        }

        public void Update(Uye item)
        {
            Uye updated = db.Uye.Find(item.UyeId);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }

        public void Delete(int itemId)
        {
            db.Uye.Remove(db.Uye.Find(itemId));
            db.SaveChanges();
        }

        public List<Uye> SelectAll()
        {
            return db.Uye.ToList();
        }

        public Uye SelectById(int itemId)
        {
            return db.Uye.Find(itemId);
        }
    }
}
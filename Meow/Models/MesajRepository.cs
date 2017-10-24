using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Meow.Models;

namespace Meow.Models
{
    public class MesajRepository
    {
        MeowbookEntities1 db = new MeowbookEntities1();
        public void Insert(Mesaj item)
        {
            db.Mesaj.Add(item);
            db.SaveChanges();
        }

        public void Update(Mesaj item)
        {
            Mesaj updated = db.Mesaj.Find(item.MesajId);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }

        public void Delete(int itemId)
        {
            db.Mesaj.Remove(db.Mesaj.Find(itemId));
            db.SaveChanges();
        }

        public List<Mesaj> SelectAll()
        {
            return db.Mesaj.ToList();
        }

        public Mesaj SelectById(int itemId)
        {
            return db.Mesaj.Find(itemId);
        }
    }
}
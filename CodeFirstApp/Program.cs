using CodeFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp
{
    class Program
    {
        static BatchDbContext db = new BatchDbContext();

        static void Main(string[] args)
        {
            GetBatches();
            Insert();
            UpdateBatch(1, "B002", "Java", 20);
            DeleteBatch(2);
        }
        //List<Batch> list = new List<Batch>();
        //list.ToList();
        //list.Add() {  new }
        static void GetBatches()
        {
            var batches = db.Batches.ToList();
            foreach (Batch batch in db.Batches)
            {
                Console.Write(batch.Id + " " + batch.Name + " " + batch.Course + " " + batch.Count);
            }

        }
        static void Insert()
        {
            Batch batch = new Batch();
            batch.Name = "B001";
            batch.Course = "C#";
            batch.Count = 30;
            db.Batches.Add(batch);
            db.SaveChanges();
        }

        static void UpdateBatch(int id, string name, string course, int count)
        {
            Batch temp = db.Batches.FirstOrDefault(x => x.Id == id);
            if (temp != null)
            {
                foreach (Batch obj in db.Batches)
                {
                    if (obj.Id == id)
                    {
                        obj.Name = name;
                        obj.Count = count;
                        obj.Course = course;
                        break;
                    }
                }
                db.SaveChanges();
            }

        }
        static void DeleteBatch(int id)
        {
            Batch temp = db.Batches.FirstOrDefault(x => x.Id == id);
            if (temp != null)
            {
                db.Batches.Remove(temp);
                db.SaveChanges();
            }


        }
    }
}
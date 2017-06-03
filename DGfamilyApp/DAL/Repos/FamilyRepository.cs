using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using DGfamilyApp.DAL.Interfaces;
using FamilyApp.Models;
using Dapper;

namespace DGfamilyApp.DAL.Repos
{
    public class FamilyRepository : IFamily
    {
        readonly AppContext _context;

        public FamilyRepository(AppContext connection)
        {
            _context = connection;
        }

        public void AddNewFamily(Family familyNew)
        {
            _context.Families.Add(familyNew);
            _context.SaveChanges();
        }

        public void DeleteSingleFamily(int id)
        {
            var deleteThis = _context.Families.Find(id);
            _context.Families.Remove(deleteThis);
        }

        public void EditFamily(Family familyEdit)
        {
            _context.Families.AddOrUpdate(familyEdit);
            _context.SaveChanges();
        }

        public IEnumerable<Family> GetAllFamilies()
        {
            return _context.Families;
        }

        public Family GetSingleFamily(int id)
        {
            return _context.Families.Find(id);
        }
    }
}
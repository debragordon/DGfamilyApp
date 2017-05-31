using System;
using System.Collections.Generic;
using System.Data;
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
            throw new NotImplementedException();
        }

        public int EditFamily(Family familyEdit)
        {
            throw new NotImplementedException();
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
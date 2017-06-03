using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DGfamilyApp.DAL.Interfaces;
using FamilyApp.Models;
using System.Data.Entity.Migrations;

namespace DGfamilyApp.DAL.Repos
{
    public class MemberRepository : IMember
    {
        readonly AppContext _context;

        public MemberRepository(AppContext connection)
        {
            _context = connection;
        }

        public void AddNewMember(Member memberNew)
        {
            _context.Members.Add(memberNew);
            _context.SaveChanges();
        }

        public void DeleteSingleMember(int id)
        {
            var deleteThis = _context.Members.Find(id);
            _context.Members.Remove(deleteThis);
        }

        public void EditMember(Member memberEdit)
        {
            _context.Members.AddOrUpdate(memberEdit);
            _context.SaveChanges();
        }

        public IEnumerable<Member> GetAllMembers()
        {
            return _context.Members;
        }

        public Member GetSingleMember(int id)
        {
            return _context.Members.Find(id);
        }
    }
}
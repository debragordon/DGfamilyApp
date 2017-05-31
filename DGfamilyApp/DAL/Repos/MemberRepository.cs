using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DGfamilyApp.DAL.Interfaces;
using FamilyApp.Models;

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
            throw new NotImplementedException();
        }

        public void DeleteSingleMember(int id)
        {
            throw new NotImplementedException();
        }

        public int EditMember(Member memberEdit)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Member> GetAllMembers()
        {
            throw new NotImplementedException();
        }

        public Member GetSingleMember(int id)
        {
            throw new NotImplementedException();
        }
    }
}
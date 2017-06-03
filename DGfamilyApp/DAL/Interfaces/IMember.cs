using FamilyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGfamilyApp.DAL.Interfaces
{
    interface IMember
    {
        void AddNewMember(Member memberNew);
        void EditMember(Member memberEdit);
        Member GetSingleMember(int id);
        IEnumerable<Member> GetAllMembers();
        void DeleteSingleMember(int id);
    }
}

using FamilyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGfamilyApp.DAL.Interfaces
{
    public interface IFamily
    {
        void AddNewFamily(Family familyNew);
        void EditFamily(Family familyEdit);
        Family GetSingleFamily(int id);
        IEnumerable<Family> GetAllFamilies();
        void DeleteSingleFamily(int id);
    }
}

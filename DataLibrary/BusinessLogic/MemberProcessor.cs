using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class MemberProcessor
    {
        public static int CreateMember(int memberId, string firstName, string lastName, string telNo, string email, string postCode)
        {
            MemberModel data = new MemberModel
            {
                MemberId = memberId,
                FirstName = firstName,
                LastName = lastName,
                TelNo = telNo,
                EMail = email,
                PostCode = postCode
            };

            string sql = @"insert into dbo.Member(MemberId, FirstName, LastName, TelNo, EMail, PostCode)
                            values (@MemberId, @FirstName, @LastName, @TelNo, @Email, @PostCode)";

            return SQLDataAccess.SaveData(sql, data);

        }
        public static List<MemberModel> LoadMembers()
        {
            string sql = @"select Id, MemberId, FirstName, LastName, TelNo, EMail, PostCode
                            from dbo.Members";
            return SQLDataAccess.LoadData<MemberModel>(sql);
        }
    }
}

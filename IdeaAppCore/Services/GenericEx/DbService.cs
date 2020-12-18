//using AdminDemo.Data;
//using AdminDemo.Models;
//using System.Collections.Generic;
//using System.Linq;

//namespace AdminDemo.Services
//{
//    public class DbService : IDbService<TGroup, TGroup>
//    {
//        private UserDbContext _context;

//        public DbService(UserDbContext context)
//        {
//            _context = context;
//        }

//        # region Group
//        public List<TGroup> GetGroupList()
//        {
//            //WebAPI 호출 대신 직접 DB에서 불러옴.
//            return _context.TGroup.ToList();
//            //return null;
//        }

//        public TGroup GetGroupData(string code)
//        {
//            return _context.TGroup.Select(s => s).Where(w => w.GrpCode.Equals(code)).FirstOrDefault();
//            //return null;
//        }

//        public void AddGroup(TGroup data)
//        {
//            _context.TGroup.Add(data);
//        }
//        #endregion Group

//        #region Member
//        public List<TMember> GetMemberList()
//        {
//            return _context.TMember.ToList();
//        }
//        #endregion Member
//    }
//}

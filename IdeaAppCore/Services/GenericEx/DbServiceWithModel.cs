//using AdminDemo.Data;
//using AdminDemo.Models;
//using System.Collections.Generic;
//using System.Linq;

//namespace AdminDemo.Services
//{
//    public class DbServiceWithModel : IDbService<GroupModel, GroupModel>
//    {
//        private UserDbContext _context;

//        public DbServiceWithModel(UserDbContext context)
//        {
//            _context = context;
//        }

//        public List<GroupModel> GetGroupList()
//        {
//            //WebAPI 호출 대신 직접 DB에서 불러옴.
//            List<GroupModel> modelList = new List<GroupModel>();
//            var d = _context.TGroup.ToList();
//            foreach (var item in d)
//            {
//                GroupModel model = new GroupModel()
//                {
//                    GRP_IDX = item.GrpIdx,
//                    GRP_CODE = item.GrpCode,
//                    GRP_ID = item.GrpId,
//                    GRP_DESC = item.GrpDesc,
//                    GRP_SITE = item.GrpSite,
//                    GRP_DOWNLMT = item.GrpDownlmt,
//                    GRP_LEVEL = item.GrpLevel,
//                    GRP_PACK = item.GrpPack,
//                    GRP_EXPIRY = item.GrpExpiry,
//                    GRP_EDATE = item.GrpEdate,
//                    GRP_UPDATE = item.GrpUpdate,
//                    GRP_SVCTYPE = item.GrpSvctype,
//                    GRP_COLSET = item.GrpColset,
//                    GRP_ONLINE = item.GrpOnline,
//                    GRP_CREATER = item.GrpCreater,
//                    GRP_CREATEDATE = item.GrpCreatedate,
//                    GRP_LASTMODIFIER = item.GrpLastmodifier,
//                    GRP_MEMO = item.GrpMemo
//                };
//                modelList.Add(model);
//            }
//            return modelList;
//            //return null;
//        }

//        public GroupModel GetGroupData(string code)
//        {
//            var item = _context.TGroup.Select(s => s).Where(w => w.GrpCode.Equals(code)).FirstOrDefault();
//            GroupModel model = new GroupModel()
//            {
//                GRP_IDX = item.GrpIdx,
//                GRP_CODE = item.GrpCode,
//                GRP_ID = item.GrpId,
//                GRP_DESC = item.GrpDesc,
//                GRP_SITE = item.GrpSite,
//                GRP_DOWNLMT = item.GrpDownlmt,
//                GRP_LEVEL = item.GrpLevel,
//                GRP_PACK = item.GrpPack,
//                GRP_EXPIRY = item.GrpExpiry,
//                GRP_EDATE = item.GrpEdate,
//                GRP_UPDATE = item.GrpUpdate,
//                GRP_SVCTYPE = item.GrpSvctype,
//                GRP_COLSET = item.GrpColset,
//                GRP_ONLINE = item.GrpOnline,
//                GRP_CREATER = item.GrpCreater,
//                GRP_CREATEDATE = item.GrpCreatedate,
//                GRP_LASTMODIFIER = item.GrpLastmodifier,
//                GRP_MEMO = item.GrpMemo
//            };
//            return model;
//            //return null;
//        }

//        public void AddGroup(GroupModel data)
//        {
//            TGroup newGroup = new TGroup()
//            {
//                GrpIdx = data.GRP_IDX,
//                GrpCode = data.GRP_CODE,
//                GrpId = data.GRP_ID,
//                GrpDesc = data.GRP_DESC,
//                GrpSite = data.GRP_SITE,
//                GrpDownlmt = data.GRP_DOWNLMT,
//                GrpLevel = data.GRP_LEVEL,
//                GrpPack = data.GRP_PACK,
//                GrpExpiry = data.GRP_EXPIRY,
//                GrpEdate = data.GRP_EDATE,
//                GrpUpdate = data.GRP_UPDATE,
//                GrpSvctype = data.GRP_SVCTYPE,
//                GrpColset = data.GRP_COLSET,
//                GrpOnline = data.GRP_ONLINE,
//                GrpCreater = data.GRP_CREATER,
//                GrpCreatedate = data.GRP_CREATEDATE,
//                GrpLastmodifier = data.GRP_LASTMODIFIER,
//                GrpMemo = data.GRP_MEMO
//            };
//            _context.TGroup.Add(newGroup);
//        }
//    }
//}

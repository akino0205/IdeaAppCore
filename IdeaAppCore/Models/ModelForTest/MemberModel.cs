using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdeaAppCore.Models
{
    public class MemberListModel
    {
        public int MEM_IDX { get; set; }
        public string MEM_CODE { get; set; }
        public string GRP_CODE { get; set; }
        public string MEM_ID { get; set; }
        public string MEM_NAME { get; set; }
        public string MEM_EMAIL { get; set; }
        public int MEM_LEVEL { get; set; }
        public string MEM_LEVELNAME { get; set; }
        public string MEM_PACK { get; set; }
        public string MEM_SGRP { get; set; }
        [global::System.ComponentModel.DataAnnotations.DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime MEM_EXPIRY { get; set; }
        [global::System.ComponentModel.DataAnnotations.DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime MEM_EDATE { get; set; }
        public string MEM_TEL { get; set; }
        [global::System.ComponentModel.DataAnnotations.DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> MEM_JOINDATE { get; set; }
        public Nullable<System.DateTime> MEM_OUTDATE { get; set; }
        public string MEM_STATUS { get; set; }
        public string MEM_RECOVERY_EMAIL { get; set; }
        public string MEM_FIRSTNAME { get; set; }
        public string MEM_LASTNAME { get; set; }
        public string GRP_DESC { get; set; }
        public int MEM_BALANCE { get; set; }
        public string MEM_CREATER { get; set; }
        public DateTime MEM_CREATEDATE { get; set; }
        public string MEM_LASTMODIFIER { get; set; }
        public string MEM_MEMO { get; set; }
    }
}

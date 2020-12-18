using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdeaAppCore.Models
{
    public class GroupModel 
    {
        [Required]
        public int GRP_IDX { get; set; }
        [Key]
        public string GRP_CODE { get; set; }
        [Required]
        public string GRP_ID { get; set; }
        public string GRP_DESC { get; set; }
        public string GRP_SITE { get; set; }
        [Required]
        public int GRP_DOWNLMT { get; set; }
        [Required]
        public int GRP_LEVEL { get; set; }
        [Required]
        public string GRP_PACK { get; set; }
        public DateTime GRP_EXPIRY { get; set; }
        [Required]
        public DateTime GRP_EDATE { get; set; }
        public string GRP_UPDATE { get; set; }
        public string GRP_SVCTYPE { get; set; }
        public string GRP_COLSET { get; set; }
        [Required]
        public char GRP_ONLINE { get; set; }
        public string GRP_CREATER { get; set; }
        public DateTime GRP_CREATEDATE { get; set; }
        public string GRP_LASTMODIFIER { get; set; }
        public string GRP_MEMO { get; set; }
    }
}

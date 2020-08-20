using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Aa4userNo
    {
        public Aa4userNo()
        {
            Aa4userLove = new HashSet<Aa4userLove>();
            Aa4userPgm = new HashSet<Aa4userPgm>();
        }

        public string UserNo { get; set; }
        public string UserNm { get; set; }
        public string UserPwd { get; set; }
        public string AutType { get; set; }
        public string EmpNo { get; set; }
        public string DeptNo { get; set; }
        public decimal RecWt1 { get; set; }
        public decimal RecWt2 { get; set; }
        public string ColWt { get; set; }
        public string AutYn { get; set; }
        public string Email { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
        public string AsUserNo { get; set; }

        public virtual ICollection<Aa4userLove> Aa4userLove { get; set; }
        public virtual ICollection<Aa4userPgm> Aa4userPgm { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Aa4userUpdate
    {
        public string SqlType { get; set; }
        public string UserNo { get; set; }
        public string PgmNo { get; set; }
        public string Updatetable { get; set; }
        public DateTime? ActTime { get; set; }
        public string SqlCommand { get; set; }
    }
}

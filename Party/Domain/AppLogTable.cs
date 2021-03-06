﻿using System;
using System.Collections.Generic;

namespace JustDo.Party.Domain
{
    public partial class AppLogTable
    {
        public long Id { get; set; }
        public string TableName { get; set; }
        public byte WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string InsertData { get; set; }
        public string DeleteData { get; set; }
    }
}

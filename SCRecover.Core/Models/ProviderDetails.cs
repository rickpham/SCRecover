﻿using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRecover.Core.Models
{
    public class ProviderDetails
    {
        //[PrimaryKey, AutoIncrement]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public string PhoneNum { get; set; }
    }
}

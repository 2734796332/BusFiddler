﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BaiduBusFiddler
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BusEntities : DbContext
    {
        public BusEntities()
            : base("name=BusEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<node_baidu> node_baidu { get; set; }
        public DbSet<node_tencent> node_tencent { get; set; }
        public DbSet<node_tianditu> node_tianditu { get; set; }
        public DbSet<route_baidu> route_baidu { get; set; }
        public DbSet<route_tencent> route_tencent { get; set; }
        public DbSet<route_tianditu> route_tianditu { get; set; }
        public DbSet<station_baidu> station_baidu { get; set; }
        public DbSet<station_tencent> station_tencent { get; set; }
        public DbSet<station_tianditu> station_tianditu { get; set; }
    }
}

using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.Migrations.Sql;
using System.Linq;
using System.Reflection;

namespace Chapter11.DBConnection
{


    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class OrderContext : DbContext
    {
        //您的上下文已配置为从您的应用程序的配置文件(App.config 或 Web.config)
        //使用“OrderContext”连接字符串。默认情况下，此连接字符串针对您的 LocalDb 实例上的
        //“Chapter11.DBConnection.OrderContext”数据库。
        // 
        //如果您想要针对其他数据库和/或数据库提供程序，请在应用程序配置文件中修改“OrderContext”
        //连接字符串。
        public OrderContext()
            : base("name=orderdb")
        {
            Database.SetInitializer<OrderContext>(new MigrateDatabaseToLatestVersion<OrderContext, LogDataMigration>(true));
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }

        //为您要在模型中包含的每种实体类型都添加 DbSet。有关配置和使用 Code First  模型
        //的详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=390109。

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }



    public class FixedMySqlMigrationSqlGenerator : MySqlMigrationSqlGenerator
    {
        public FixedMySqlMigrationSqlGenerator()
            : base()
        {
        }

        /// <summary>
        /// we want BTREE because HASH is not correct for normal Keys on MySQL 8
        /// </summary>
        /// <param name="op"></param>
        /// <returns></returns>
        protected override MigrationStatement Generate(CreateIndexOperation op)
        {
            MigrationStatement migrationStatement = base.Generate(op);
            System.Diagnostics.Trace.WriteLine(migrationStatement.Sql);
            string fubarSql = migrationStatement.Sql.TrimEnd();

            if (fubarSql.EndsWith("using HASH", StringComparison.OrdinalIgnoreCase))
            {
                string modSql = fubarSql.Replace("using HASH", " using BTREE");
                migrationStatement.Sql = modSql;
            }
            return migrationStatement;
        }


    }
    public sealed class LogDataMigration : DbMigrationsConfiguration<OrderContext>
    {
        public const string CONTEXT_KEY = "BalsamicSoftware.LogData";
        private static readonly HashSet<string> _InitializedConnections = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        private static readonly object _LockProxy = new object();

        public LogDataMigration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = CONTEXT_KEY;
            SetSqlGenerator("MySql.Data.MySqlClient", new FixedMySqlMigrationSqlGenerator());

        }
    }


    //public class MyEntity
    //{
    //    public int OrderId { get; set; }
    //    public string Name { get; set; }
    //}
}
using DapperFactory.Domain.Data;
using DapperFactory.Domain.Entities.Enums;
using DapperFactory.Infrastructure.FactorySelector;

var mysqlFactory = DbFactorySelector.GetConnection(DBType.MySQL, "ConnectionString", "AnaMakine");

DapperMethods dapperMethods = new DapperMethods();

dapperMethods.SetConnection(mysqlFactory.GetConnection());

var mysqlList = dapperMethods.Query<string>("SELECT TCKN FROM MUSTERILER");

var sqlServerFactory = DbFactorySelector.GetConnection(DBType.SQLServer, "ConnectionString", "AnaMakine");

dapperMethods.SetConnection(sqlServerFactory.GetConnection());

var sqlServerList = dapperMethods.Query<string>("SELECT TCKN FROM MUSTERILER");
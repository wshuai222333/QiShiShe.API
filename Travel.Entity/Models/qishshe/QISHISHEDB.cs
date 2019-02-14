

using QiShiShe.DDD.Config;
using PetaPoco.NetCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace QiShiShe.Entity.Model
{

	 public partial class QISHISHEDB : Database
     {
        private static SqlConnection con;
        /// <summary>
        /// open the connection
        /// </summary>
        /// <returns></returns>
        private static SqlConnection OpenConnection()
        {
            if (con == null)
            {
                con = new SqlConnection(GetConn());
            }
            else
            {
                if (con.State == System.Data.ConnectionState.Closed)
                    con.Open();
            }
            return con;
        }

		private static string GetConn()
        {
            return JsonConfig.JsonRead("QISHISHEConnection");
        }

        private static SqlConnection OpenConnection(string name)
        {
            if (con == null)
            {
                con = new SqlConnection(JsonConfig.JsonRead(name));
            }
            else
            {
                if (con.State == System.Data.ConnectionState.Closed)
                    con.Open();
            }
            return con;
        }


        public QISHISHEDB() : base(OpenConnection())
        {
            CommonConstruct();
        }

        public QISHISHEDB(string connectionStringName) : base(OpenConnection(connectionStringName))
        {
            CommonConstruct();
        }

        partial void CommonConstruct();

        public interface IFactory
        {
            QISHISHEDB GetInstance();
        }

        public static IFactory Factory { get; set; }
        public static QISHISHEDB GetInstance()
        {
            if (_instance != null)
                return _instance;

            if (Factory != null)
                return Factory.GetInstance();
            else
                return new QISHISHEDB();
        }

        [ThreadStatic] static QISHISHEDB _instance;

        public override void OnBeginTransaction()
        {
            if (_instance == null)
                _instance = this;
        }

        public override void OnEndTransaction()
        {
            if (_instance == this)
                _instance = null;
        }

		public static int BulkUpdate<T>(string tableName, List<T> data, Func<T, string> funColumns) 
        {
            try
            {
			    using (SqlConnection conn = OpenConnection())
                {
                    conn.Open();

                    String sql = "";

                    foreach (var item in data)
                    {
                        sql += string.Format("UPDATE dbo.[{0}] SET {1} ;", tableName, funColumns(item));
                    }

                    SqlCommand comm = new SqlCommand()
                    {
                        CommandText = sql,
                        Connection = conn
                    };

                    return comm.ExecuteNonQuery();
                }
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public class Record<T> where T : new()
        {
            public static QISHISHEDB repo { get { return QISHISHEDB.GetInstance(); } }
            public bool IsNew() { return repo.IsNew(this); }
            public object Insert() { return repo.Insert(this); }

            public void Save() { repo.Save(this); }
            public int Update() { return repo.Update(this); }

            public int Update(IEnumerable<string> columns) { return repo.Update(this, columns); }
            public static int Update(string sql, params object[] args) { return repo.Update<T>(sql, args); }
            public static int Update(Sql sql) { return repo.Update<T>(sql); }
            public int Delete() { return repo.Delete(this); }
            public static int Delete(string sql, params object[] args) { return repo.Delete<T>(sql, args); }
            public static int Delete(Sql sql) { return repo.Delete<T>(sql); }
            public static int Delete(object primaryKey) { return repo.Delete<T>(primaryKey); }
            public static bool Exists(object primaryKey) { return repo.Exists<T>(primaryKey); }
            public static T SingleOrDefault(object primaryKey) { return repo.SingleOrDefault<T>(primaryKey); }
            public static T SingleOrDefault(string sql, params object[] args) { return repo.SingleOrDefault<T>(sql, args); }
            public static T SingleOrDefault(Sql sql) { return repo.SingleOrDefault<T>(sql); }
            public static T FirstOrDefault(string sql, params object[] args) { return repo.FirstOrDefault<T>(sql, args); }
            public static T FirstOrDefault(Sql sql) { return repo.FirstOrDefault<T>(sql); }
            public static T Single(object primaryKey) { return repo.Single<T>(primaryKey); }
            public static T Single(string sql, params object[] args) { return repo.Single<T>(sql, args); }
            public static T Single(Sql sql) { return repo.Single<T>(sql); }
            public static T First(string sql, params object[] args) { return repo.First<T>(sql, args); }
            public static T First(Sql sql) { return repo.First<T>(sql); }
            public static List<T> Fetch(string sql, params object[] args) { return repo.Fetch<T>(sql, args); }
            public static List<T> Fetch(Sql sql) { return repo.Fetch<T>(sql); }

            public static List<T> Fetch(int page, int itemsPerPage, string sql, params object[] args) { return repo.Fetch<T>(page, itemsPerPage, sql, args); }

            public static List<T> SkipTake(int skip, int take, string sql, params object[] args) { return repo.SkipTake<T>(skip, take, sql, args); }
            public static List<T> SkipTake(int skip, int take, Sql sql) { return repo.SkipTake<T>(skip, take, sql); }
            public static Page<T> Page(int page, int itemsPerPage, string sql, params object[] args) { return repo.Page<T>(page, itemsPerPage, sql, args); }
            public static Page<T> Page(int page, int itemsPerPage, Sql sql) { return repo.Page<T>(page, itemsPerPage, sql); }
            public static IEnumerable<T> Query(string sql, params object[] args) { return repo.Query<T>(sql, args); }
            public static IEnumerable<T> Query(Sql sql) { return repo.Query<T>(sql); }

        }

    }


	
	 [TableName("dbo.BackgroundUser")]
	 [PrimaryKey("BackgroundUserId")]
	 [ExplicitColumns]
     public partial class BackgroundUser:QISHISHEDB.Record<BackgroundUser>
	 {
		
		[Column] public int BackgroundUserId {get;set;}
		[Column] public int? BackgroundRoleId {get;set;}
		[Column] public string UserName {get;set;}
		[Column] public string UserPwd {get;set;}
		[Column] public DateTime? CreateTime {get;set;}
		[Column] public string RealName {get;set;}
		[Column] public int? Status {get;set;}
		[Column] public DateTime? UpdateTime {get;set;}
		[Column] public int? UpdateUserId {get;set;}
		[Column] public int? CreateUserId {get;set;}
		
	 }
	
	 [TableName("dbo.Department")]
	 [PrimaryKey("DepartmentId")]
	 [ExplicitColumns]
     public partial class Department:QISHISHEDB.Record<Department>
	 {
		
		[Column] public int DepartmentId {get;set;}
		[Column] public string DepartmentName {get;set;}
		[Column] public DateTime? CreateTime {get;set;}
		[Column] public int? CreateId {get;set;}
		[Column] public DateTime? UpdateTime {get;set;}
		[Column] public int? UpdateId {get;set;}
		[Column] public int? EnterpriseId {get;set;}
		
	 }
	
	 [TableName("dbo.Enterprise")]
	 [PrimaryKey("EnterpriseId")]
	 [ExplicitColumns]
     public partial class Enterprise:QISHISHEDB.Record<Enterprise>
	 {
		
		[Column] public int EnterpriseId {get;set;}
		[Column] public string EnterpriseName {get;set;}
		[Column] public string EnterpriseCode {get;set;}
		[Column] public string ContactsName {get;set;}
		[Column] public string ContactsPhone {get;set;}
		[Column] public string ContactsEmail {get;set;}
		[Column] public int? Status {get;set;}
		[Column] public DateTime? CreateTime {get;set;}
		[Column] public DateTime? UpdateTime {get;set;}
		[Column] public int? CreateUserId {get;set;}
		[Column] public int? UpdateUserId {get;set;}
		
	 }
	
	 [TableName("dbo.Staff")]
	 [PrimaryKey("StaffId")]
	 [ExplicitColumns]
     public partial class Staff:QISHISHEDB.Record<Staff>
	 {
		
		[Column] public int StaffId {get;set;}
		[Column] public int? EnterpriseId {get;set;}
		[Column] public string EnterpriseName {get;set;}
		[Column] public string StaffName {get;set;}
		[Column] public string StaffCardNo {get;set;}
		[Column] public DateTime? StaffBirthday {get;set;}
		[Column] public DateTime? CreateTime {get;set;}
		[Column] public DateTime? UpdateTime {get;set;}
		[Column] public int? CreateId {get;set;}
		[Column] public int? UpdateId {get;set;}
		[Column] public int? DepartmentId {get;set;}
		[Column] public int? Status {get;set;}
		[Column] public int? Integral {get;set;}
		[Column] public string UserName {get;set;}
		[Column] public string UserPwd {get;set;}
		[Column] public string Phone {get;set;}
		
	 }
	
	 [TableName("dbo.OrderPassenger")]
	 [PrimaryKey("OrderPassengerId")]
	 [ExplicitColumns]
     public partial class OrderPassenger:QISHISHEDB.Record<OrderPassenger>
	 {
		
		[Column] public int OrderPassengerId {get;set;}
		[Column] public string OrderId {get;set;}
		[Column] public string PassengerName {get;set;}
		[Column] public string PassengerCardNo {get;set;}
		[Column] public string PassengerCardType {get;set;}
		[Column] public DateTime? Passengerbirthday {get;set;}
		[Column] public DateTime? CreateTime {get;set;}
		
	 }
	
	 [TableName("dbo.OrderApartment")]
	 [PrimaryKey("OrderApartmentId")]
	 [ExplicitColumns]
     public partial class OrderApartment:QISHISHEDB.Record<OrderApartment>
	 {
		
		[Column] public int OrderApartmentId {get;set;}
		[Column] public int? ApartmentType {get;set;}
		[Column] public int? Apartmentcount {get;set;}
		[Column] public DateTime? CreateTime {get;set;}
		[Column] public string OrderId {get;set;}
		
	 }
	
	 [TableName("dbo.DemandOrder")]
	 [PrimaryKey("DemandOrderId")]
	 [ExplicitColumns]
     public partial class DemandOrder:QISHISHEDB.Record<DemandOrder>
	 {
		
		[Column] public int DemandOrderId {get;set;}
		[Column] public string OrderId {get;set;}
		[Column] public int? BookingType {get;set;}
		[Column] public int? TravelType {get;set;}
		[Column] public DateTime? DepartDate {get;set;}
		[Column] public DateTime? ArriveDate {get;set;}
		[Column] public string DepartCity {get;set;}
		[Column] public string ArriveCity {get;set;}
		[Column] public int? TravelWay {get;set;}
		[Column] public string ExpectDepartTime {get;set;}
		[Column] public string ExpectArrivetime {get;set;}
		[Column] public string TravelOthers {get;set;}
		[Column] public DateTime? HotelCheckinDate {get;set;}
		[Column] public DateTime? HotelCheckoutDate {get;set;}
		[Column] public int? HotelType {get;set;}
		[Column] public string Destination {get;set;}
		[Column] public int? HotelLocation {get;set;}
		[Column] public string HotelOthers {get;set;}
		[Column] public DateTime? CreateTime {get;set;}
		[Column] public int? StaffId {get;set;}
		[Column] public int? EnterpriseId {get;set;}
		[Column] public int? Status {get;set;}
		
	 }
	
	 [TableName("dbo.T_AirPorts")]
	 [PrimaryKey("ID")]
	 [ExplicitColumns]
     public partial class T_AirPorts:QISHISHEDB.Record<T_AirPorts>
	 {
		
		[Column] public int ID {get;set;}
		[Column] public string City_Name {get;set;}
		[Column] public string City_Code {get;set;}
		[Column] public string City_EnName {get;set;}
		[Column] public string Airport_name {get;set;}
		[Column] public int? Order_Index {get;set;}
		[Column] public string City_PinYin {get;set;}
		[Column] public string City_JianPin {get;set;}
		[Column] public string City_OtherCode {get;set;}
		[Column] public int? City_Up {get;set;}
		[Column] public int? City_Type {get;set;}
		[Column] public string City_Ports {get;set;}
		
	 }
	
	 [TableName("dbo.SelectAirTicket")]
	 [PrimaryKey("SelectAirTicketId")]
	 [ExplicitColumns]
     public partial class SelectAirTicket:QISHISHEDB.Record<SelectAirTicket>
	 {
		
		[Column] public int SelectAirTicketId {get;set;}
		[Column] public string OrderId {get;set;}
		[Column] public DateTime? OneDepartDate {get;set;}
		[Column] public DateTime? OneArriveDate {get;set;}
		[Column] public DateTime? TwoDepartDate {get;set;}
		[Column] public DateTime? TwoArriveDate {get;set;}
		[Column] public string OneFightNo {get;set;}
		[Column] public string TwoFightNo {get;set;}
		[Column] public string DepartCity {get;set;}
		[Column] public string ArriveCity {get;set;}
		[Column] public int? SeatType {get;set;}
		[Column] public DateTime? CreateTime {get;set;}
		[Column] public decimal? TicketPrice {get;set;}
		[Column] public decimal? FuelAirPrice {get;set;}
		[Column] public int? TravelType {get;set;}
		
	 }

}









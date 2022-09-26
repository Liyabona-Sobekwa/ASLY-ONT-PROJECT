using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DAL
{
    //hi
    public class DataAccessLayer
    {
        static string connstring = "Data source = localhost; Initial Catalog = dbProperties; Integrated Security = True ";
        SqlConnection dbConn = new SqlConnection(connstring);
        SqlCommand dbComm;
        DataTable dt;
        SqlDataAdapter dbAdapter;

        public int InsertPropertyType(PropertyClass P)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertPropertyType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyTypeDescription", P.PropertyDescription);


            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;
        }
        public DataTable GetPropertyType()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_DisplayPropertyType", dbConn);

            dt = new DataTable();

            dbAdapter = new SqlDataAdapter(dbComm);

            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;

        }

        public int InsertCity(PropertyClass P)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertCity", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@CityDescription", P.CityDescription);
            dbComm.Parameters.AddWithValue("@ProvinceID", P.ProvinceID);



            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;
        }


        public DataTable GetCity()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_DisplayCity", dbConn);

            dt = new DataTable();

            dbAdapter = new SqlDataAdapter(dbComm);

            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;

        }
        public int InsertAgent(PropertyClass P)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Name", P.AgentName);
            dbComm.Parameters.AddWithValue("@Surname", P.AgentSurname);
            dbComm.Parameters.AddWithValue("@Email", P.AgentEmail);
            dbComm.Parameters.AddWithValue("@Password", P.AgentPassword);
            dbComm.Parameters.AddWithValue("@Phone", P.AgentPhone);
            dbComm.Parameters.AddWithValue("@Status", P.AgentStatus);
            dbComm.Parameters.AddWithValue("@AgencyID", P.AgencyID);


            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;
        }

        public int UpdateAgent(PropertyClass P)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_UpdateAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;



            dbComm.Parameters.AddWithValue("@AgentID", P.AgentID);
            dbComm.Parameters.AddWithValue("@Email", P.AgentEmail);
            dbComm.Parameters.AddWithValue("@Phone", P.AgentPhone);
            dbComm.Parameters.AddWithValue("@Status", P.AgentStatus);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;
        }
        public DataTable GeAgent()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_DiplayAgent", dbConn);

            dt = new DataTable();

            dbAdapter = new SqlDataAdapter(dbComm);

            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;

        }
        public int DeleteAgent(PropertyClass P)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DeleteAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;



            dbComm.Parameters.AddWithValue("@AgentID", P.AgentID);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;
        }
        public int InsertRental(PropertyClass P)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertRental", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyTenantID", P.PropertyTenantID);
            dbComm.Parameters.AddWithValue("@TenantID", P.TenantID);
            dbComm.Parameters.AddWithValue("@StartDate", P.StartDate);
            dbComm.Parameters.AddWithValue("@EndDate", P.EndDate);



            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;
        }

        public int UpdateRental(PropertyClass P)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_UpdateRental", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@RentalID", P.RentalID);
            dbComm.Parameters.AddWithValue("@StartDate", P.StartDate);
            dbComm.Parameters.AddWithValue("@EndDate", P.EndDate);



            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;
        }
        public DataTable GetRental()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_DisplayRental", dbConn);

            dt = new DataTable();

            dbAdapter = new SqlDataAdapter(dbComm);

            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;

        }
        public int AddSurbub(PropertyClass P)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertSurbub", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

     
            dbComm.Parameters.AddWithValue("@SurbubDescription", P.SuburbDescription);
            dbComm.Parameters.AddWithValue("@PostalCode", P.PostalCode);
            dbComm.Parameters.AddWithValue("@CityID", P.CityID);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetSurburb()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_Suburb", dbConn);

            dt = new DataTable();

            dbAdapter = new SqlDataAdapter(dbComm);

            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;

        }

        public int AddTenant(PropertyClass P)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertTenant", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@TenantID", P.TenantID);
            dbComm.Parameters.AddWithValue("@Name", P.TenantName);
            dbComm.Parameters.AddWithValue("@Surname",P.TenantSurname);
            dbComm.Parameters.AddWithValue("@Email", P.TenantEmail);
            dbComm.Parameters.AddWithValue("@Password", P.TenantPassword);
            dbComm.Parameters.AddWithValue("@Phone", P.TenantPhone);
            dbComm.Parameters.AddWithValue("@Status", P.TenantStatus);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public int UpdateTenant(PropertyClass P )
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_UpdateTenant", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@TenantID", P.TenantID);
            dbComm.Parameters.AddWithValue("@Email", P.TenantEmail);
            dbComm.Parameters.AddWithValue("@Phone", P.TenantPhone);
            dbComm.Parameters.AddWithValue("@Status", P.TenantStatus);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public int DeleteTenant(PropertyClass P)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DeleteTenant", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;



            dbComm.Parameters.AddWithValue("@TenantID", P.TenantID);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;

    
        }

        public DataTable GetTenant()
        {
            dbComm = new SqlCommand("sp_DisplayTenant", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            return dt;
        }
        public int AddProperty(PropertyClass p)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertProperty", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Description",p.PropertyDescription);
            dbComm.Parameters.AddWithValue("@Price", p.Price);
            dbComm.Parameters.AddWithValue("@Image", p.Image);
            dbComm.Parameters.AddWithValue("@PropertyTypeID", p.PropertyTypeID);
            dbComm.Parameters.AddWithValue("@Status", p.PropertyStatus);
            dbComm.Parameters.AddWithValue("@SurbubID", p.SuburbID);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public int UpdateProperty(PropertyClass p)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_UpdateProperty", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyID", p.PropertyID);
            dbComm.Parameters.AddWithValue("@Price", p.Price);
            dbComm.Parameters.AddWithValue("@PropertyTypeID", p.PropertyTypeID);
            dbComm.Parameters.AddWithValue("@Status", p.PropertyStatus);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public int DeleteProperty(PropertyClass p)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DeleteProperty", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyID", p.PropertyID); 


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public DataTable GetProperty()
        {
            dbComm = new SqlCommand("sp_DisplayProperty", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            return dt;
        }
       

    }
}

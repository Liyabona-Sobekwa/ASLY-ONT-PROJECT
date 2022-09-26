using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PropertyClass
    {
        public int PropertyTypeID { get; set; }
        public string PropertyDescription { get; set; }
        public string CityDescription { get; set; }

        public string AgentName { get; set; }

        public string AgentSurname { get; set; }
        public string AgentEmail { get; set; }
        public string AgentPassword { get; set; }
        public string AgentPhone { get; set; }
        public string AgentStatus { get; set; }

        public int ProvinceID { get; set; }

        public int AgencyID { get; set; }
        public int AgentID { get; set; }
        public int RentalID { get; set; }

        public int PropertyTenantID { get; set; }
        public int TenantID { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }
        public int SuburbID { get; set; }
        public string SuburbDescription { get; set; }

        public string PostalCode { get; set; }
        public int CityID { get; set; }

        public string TenantName { get; set; }

        public string TenantSurname { get; set; }
        public string TenantEmail { get; set; }
        public string TenantPassword { get; set; }
        public string TenantPhone { get; set; }
        public string TenantStatus { get; set; }
        public double Price { get; set; }

        public string Image { get; set; }
        public int PropertyID { get;set ; }
        public string PropertyStatus{ get;set; }




    }
}

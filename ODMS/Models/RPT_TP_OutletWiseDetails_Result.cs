//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ODMS.Models
{
    using System;
    
    public partial class RPT_TP_OutletWiseDetails_Result
    {
        public Nullable<int> REGION_id { get; set; }
        public Nullable<int> AREA_id { get; set; }
        public Nullable<int> CEAREA_id { get; set; }
        public string REGION_Name { get; set; }
        public string AREA_Name { get; set; }
        public string CEAREA_Name { get; set; }
        public Nullable<int> DBCode { get; set; }
        public string DB_Name { get; set; }
        public string PSR { get; set; }
        public Nullable<int> PSR_Code { get; set; }
        public string RouteName { get; set; }
        public Nullable<int> OutletCode { get; set; }
        public string OutletName { get; set; }
        public string Address { get; set; }
        public string OwnerName { get; set; }
        public string ContactNo { get; set; }
        public string channel_name { get; set; }
        public string outlet_category_name { get; set; }
        public string Outlet_grade { get; set; }
        public int TPid { get; set; }
        public string TPName { get; set; }
        public Nullable<System.DateTime> planned_order_date { get; set; }
        public Nullable<System.DateTime> delivery_date { get; set; }
        public Nullable<int> Orderid { get; set; }
        public string so_id { get; set; }
        public string SKUName { get; set; }
        public Nullable<int> Pack_size { get; set; }
        public Nullable<decimal> unit_sale_price { get; set; }
        public Nullable<int> sku_order_type_id { get; set; }
        public Nullable<int> quantity_ordered { get; set; }
        public Nullable<int> quantity_delivered { get; set; }
    }
}
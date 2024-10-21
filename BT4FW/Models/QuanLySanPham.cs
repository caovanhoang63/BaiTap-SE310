using System.Configuration;

namespace BT4FW.Models
{
    partial class QuanLySanPhamDataContext
    {
        public QuanLySanPhamDataContext() :
            base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QuanLySanPhamConnectionString"].ConnectionString, mappingSource)
        {
            OnCreated();
        }
    }
}
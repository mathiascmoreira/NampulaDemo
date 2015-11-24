using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nampula.DI;

namespace NampulaDemoDI
{
    public class BusinessPartner: TableAdapter
    {
        public struct FieldsName
        {
            public static readonly string Id = "Id";
            public static readonly string Name = "Name";
        }

        public struct FieldsDescription
        {
            public static readonly string Id = "Nº";
            public static readonly string Name = "Nome";
        }
        
        TableAdapterField _Id = new TableAdapterField(FieldsName.Id, FieldsDescription.Id, System.Data.DbType.Int32, 11, 0, true, true);
        TableAdapterField _Name = new TableAdapterField(FieldsName.Name, FieldsDescription.Name, 200);

        public BusinessPartner() : base("Business Partner")
        {

        }
        public int Id
        {
            get { return _Id.GetInt32(); }
            set { _Id.Value = value; }
        }

        public String Name 
        {
            get { return _Name.GetString(); }
            set { _Name.Value = value; }
        }
    }
}

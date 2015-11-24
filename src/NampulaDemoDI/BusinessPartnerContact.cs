using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nampula.DI;

namespace NampulaDemoDI
{
    public class BusinessPartnerContact: TableAdapter
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

        public  BusinessPartnerContact(): base("Business Partner Contatact")
        {
            this.OnAfterCreate += BusinessPartner_OnAfterCreate;
        }

        private void BusinessPartner_OnAfterCreate(object sender, TableAdapterEventArgs e)
        {
            var contact = Factory.DBNampula.CreatObject<BusinessPartnerContact>();

            contact.Name = "Mathias";

            contact.Add();
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


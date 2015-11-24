using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nampula.UI;
using Nampula.DI;
using NampulaDemoDI;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Nampula.UI.Form
    {
        public Form1()
        {
            InitializeComponent();
            var contact = NampulaDemoDI.Factory.DBNampula.CreatObject<NampulaDemoDI.BusinessPartnerContact>();
            var tbQry = new TableQuery(contact);
            new Nampula.UI.Helpers.ChooseFromListHelper(editTextContatoId, editTextButtonContatoNome, tbQry, BusinessPartnerContact.FieldsName.Id, BusinessPartnerContact.FieldsName.Name, "Contatos");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void staticText1_Click(object sender, EventArgs e)
        {

        }

        private void staticText2_Click(object sender, EventArgs e)
        {

        }

        private void Ok_Click(object sender, EventArgs e)
        {
            try
            {
                var businessPartner = NampulaDemoDI.Factory.DBNampula.CreatObject<NampulaDemoDI.BusinessPartner>();
                businessPartner.Name = editTextNome.Text;

                businessPartner.Add();

                editTextCodigo.EditValue = businessPartner.Id;
                MessageBox("Registro salvo com sucesso!");


            }
            catch (Exception ex)
            {

                ShowMessageError(ex);
            }
        }

        private void editTextCodigo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void editTextNome_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}

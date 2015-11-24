namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ok = new Nampula.UI.Button();
            this.staticText1 = new Nampula.UI.StaticText();
            this.editTextCodigo = new Nampula.UI.EditText();
            this.staticText2 = new Nampula.UI.StaticText();
            this.editTextNome = new Nampula.UI.EditText();
            this.staticText3 = new Nampula.UI.StaticText();
            this.editTextContatoId = new Nampula.UI.EditText();
            this.editTextButtonContatoNome = new Nampula.UI.EditTextButton();
            ((System.ComponentModel.ISupportInitialize)(this.editTextCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTextNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTextContatoId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTextButtonContatoNome.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(12, 260);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 0;
            this.Ok.Text = "Ok";
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // staticText1
            // 
            this.staticText1.LinkedTo = this.editTextCodigo;
            this.staticText1.Location = new System.Drawing.Point(9, 10);
            this.staticText1.Name = "staticText1";
            this.staticText1.Size = new System.Drawing.Size(67, 17);
            this.staticText1.TabIndex = 1;
            this.staticText1.Text = "Codigo";
            this.staticText1.Click += new System.EventHandler(this.staticText1_Click);
            // 
            // editTextCodigo
            // 
            this.editTextCodigo.DataSourceInformation = null;
            this.editTextCodigo.Location = new System.Drawing.Point(76, 10);
            this.editTextCodigo.Name = "editTextCodigo";
            this.editTextCodigo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.25F);
            this.editTextCodigo.Properties.Appearance.Options.UseFont = true;
            this.editTextCodigo.Properties.Appearance.Options.UseTextOptions = true;
            this.editTextCodigo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.editTextCodigo.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.editTextCodigo.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.editTextCodigo.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.editTextCodigo.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.editTextCodigo.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.editTextCodigo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(156)))));
            this.editTextCodigo.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.editTextCodigo.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.editTextCodigo.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.editTextCodigo.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.editTextCodigo.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.editTextCodigo.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.editTextCodigo.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.editTextCodigo.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.editTextCodigo.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.editTextCodigo.Properties.AutoHeight = false;
            this.editTextCodigo.Properties.DisplayFormat.FormatString = "f0";
            this.editTextCodigo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.editTextCodigo.Properties.EditFormat.FormatString = "f0";
            this.editTextCodigo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.editTextCodigo.Size = new System.Drawing.Size(100, 17);
            this.editTextCodigo.TabIndex = 2;
            this.editTextCodigo.EditValueChanged += new System.EventHandler(this.editTextCodigo_EditValueChanged);
            // 
            // staticText2
            // 
            this.staticText2.LinkedTo = this.editTextNome;
            this.staticText2.Location = new System.Drawing.Point(9, 36);
            this.staticText2.Name = "staticText2";
            this.staticText2.Size = new System.Drawing.Size(67, 17);
            this.staticText2.TabIndex = 3;
            this.staticText2.Text = "Nome";
            this.staticText2.Click += new System.EventHandler(this.staticText2_Click);
            // 
            // editTextNome
            // 
            this.editTextNome.DataSourceInformation = null;
            this.editTextNome.Location = new System.Drawing.Point(76, 36);
            this.editTextNome.Name = "editTextNome";
            this.editTextNome.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.25F);
            this.editTextNome.Properties.Appearance.Options.UseFont = true;
            this.editTextNome.Properties.Appearance.Options.UseTextOptions = true;
            this.editTextNome.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.editTextNome.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.editTextNome.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.editTextNome.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.editTextNome.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.editTextNome.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.editTextNome.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(156)))));
            this.editTextNome.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.editTextNome.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.editTextNome.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.editTextNome.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.editTextNome.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.editTextNome.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.editTextNome.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.editTextNome.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.editTextNome.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.editTextNome.Properties.AutoHeight = false;
            this.editTextNome.Properties.DisplayFormat.FormatString = "f0";
            this.editTextNome.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.editTextNome.Properties.EditFormat.FormatString = "f0";
            this.editTextNome.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.editTextNome.Size = new System.Drawing.Size(100, 17);
            this.editTextNome.TabIndex = 4;
            this.editTextNome.EditValueChanged += new System.EventHandler(this.editTextNome_EditValueChanged);
            // 
            // staticText3
            // 
            this.staticText3.LinkedTo = this.editTextContatoId;
            this.staticText3.Location = new System.Drawing.Point(9, 64);
            this.staticText3.Name = "staticText3";
            this.staticText3.Size = new System.Drawing.Size(67, 17);
            this.staticText3.TabIndex = 5;
            this.staticText3.Text = "Contato";
            // 
            // editTextContatoId
            // 
            this.editTextContatoId.DataSourceInformation = null;
            this.editTextContatoId.Location = new System.Drawing.Point(76, 64);
            this.editTextContatoId.Name = "editTextContatoId";
            this.editTextContatoId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.25F);
            this.editTextContatoId.Properties.Appearance.Options.UseFont = true;
            this.editTextContatoId.Properties.Appearance.Options.UseTextOptions = true;
            this.editTextContatoId.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.editTextContatoId.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.editTextContatoId.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.editTextContatoId.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.editTextContatoId.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.editTextContatoId.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.editTextContatoId.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(156)))));
            this.editTextContatoId.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.editTextContatoId.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.editTextContatoId.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.editTextContatoId.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.editTextContatoId.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.editTextContatoId.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.editTextContatoId.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.editTextContatoId.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.editTextContatoId.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.editTextContatoId.Properties.AutoHeight = false;
            this.editTextContatoId.Properties.DisplayFormat.FormatString = "f0";
            this.editTextContatoId.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.editTextContatoId.Properties.EditFormat.FormatString = "f0";
            this.editTextContatoId.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.editTextContatoId.Size = new System.Drawing.Size(100, 17);
            this.editTextContatoId.TabIndex = 6;
            // 
            // editTextButtonContatoNome
            // 
            this.editTextButtonContatoNome.DataSourceInformation = null;
            this.editTextButtonContatoNome.Location = new System.Drawing.Point(182, 64);
            this.editTextButtonContatoNome.Name = "editTextButtonContatoNome";
            this.editTextButtonContatoNome.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.25F);
            this.editTextButtonContatoNome.Properties.Appearance.Options.UseFont = true;
            this.editTextButtonContatoNome.Properties.Appearance.Options.UseTextOptions = true;
            this.editTextButtonContatoNome.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.editTextButtonContatoNome.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.editTextButtonContatoNome.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.editTextButtonContatoNome.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.editTextButtonContatoNome.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.editTextButtonContatoNome.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.editTextButtonContatoNome.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(156)))));
            this.editTextButtonContatoNome.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.editTextButtonContatoNome.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.editTextButtonContatoNome.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.editTextButtonContatoNome.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.editTextButtonContatoNome.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.editTextButtonContatoNome.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.editTextButtonContatoNome.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.editTextButtonContatoNome.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.editTextButtonContatoNome.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.editTextButtonContatoNome.Properties.AutoHeight = false;
            this.editTextButtonContatoNome.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.editTextButtonContatoNome.Properties.DisplayFormat.FormatString = "f0";
            this.editTextButtonContatoNome.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.editTextButtonContatoNome.Properties.EditFormat.FormatString = "f0";
            this.editTextButtonContatoNome.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.editTextButtonContatoNome.Size = new System.Drawing.Size(142, 17);
            this.editTextButtonContatoNome.TabIndex = 7;
            // 
            // Form1
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 7.85F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 295);
            this.Controls.Add(this.editTextButtonContatoNome);
            this.Controls.Add(this.editTextContatoId);
            this.Controls.Add(this.staticText3);
            this.Controls.Add(this.editTextNome);
            this.Controls.Add(this.staticText2);
            this.Controls.Add(this.editTextCodigo);
            this.Controls.Add(this.staticText1);
            this.Controls.Add(this.Ok);
            this.Name = "Form1";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editTextCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTextNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTextContatoId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTextButtonContatoNome.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Nampula.UI.Button Ok;
        private Nampula.UI.StaticText staticText1;
        private Nampula.UI.EditText editTextCodigo;
        private Nampula.UI.StaticText staticText2;
        private Nampula.UI.EditText editTextNome;
        private Nampula.UI.StaticText staticText3;
        private Nampula.UI.EditText editTextContatoId;
        private Nampula.UI.EditTextButton editTextButtonContatoNome;
    }
}
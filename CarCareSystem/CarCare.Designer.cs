using CarCareSystem.Models.Enums;

namespace CarCareSystem;

partial class CarCare
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        dgwMaintainences = new DataGridView();
        idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        createdDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        materialTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        unitTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        pieceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        unitPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        kDVDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        PriceWithoutKDV = new DataGridViewTextBoxColumn();
        Price = new DataGridViewTextBoxColumn();
        maintainenceBindingSource = new BindingSource(components);
        txtPlate = new TextBox();
        grpAdd = new GroupBox();
        btnAdd = new Button();
        cmbKDV = new ComboBox();
        cmbUnit = new ComboBox();
        txtPiece = new TextBox();
        txtUnitPrice = new TextBox();
        txtMaterialType = new TextBox();
        lblKDV = new Label();
        lblUnitPrice = new Label();
        lblPiece = new Label();
        lblUnit = new Label();
        lblMaintainenceType = new Label();
        label1 = new Label();
        btnGetRecords = new Button();
        lblSumPrice = new Label();
        grpUpdate = new GroupBox();
        btnUpdate = new Button();
        cmbUpdateKDV = new ComboBox();
        cmbUpdateUnit = new ComboBox();
        txtUpdatePiece = new TextBox();
        txtUpdateUnitPrice = new TextBox();
        txtUpdateMaterial = new TextBox();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        btnDelete = new Button();
        lblPriceWithoutKDV = new Label();
        ((System.ComponentModel.ISupportInitialize)dgwMaintainences).BeginInit();
        ((System.ComponentModel.ISupportInitialize)maintainenceBindingSource).BeginInit();
        grpAdd.SuspendLayout();
        grpUpdate.SuspendLayout();
        SuspendLayout();
        // 
        // dgwMaintainences
        // 
        dgwMaintainences.AllowUserToAddRows = false;
        dgwMaintainences.AllowUserToDeleteRows = false;
        dgwMaintainences.AllowUserToResizeColumns = false;
        dgwMaintainences.AllowUserToResizeRows = false;
        dgwMaintainences.AutoGenerateColumns = false;
        dgwMaintainences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgwMaintainences.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgwMaintainences.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, createdDateDataGridViewTextBoxColumn, materialTypeDataGridViewTextBoxColumn, unitTypeDataGridViewTextBoxColumn, pieceDataGridViewTextBoxColumn, unitPriceDataGridViewTextBoxColumn, kDVDataGridViewTextBoxColumn, PriceWithoutKDV, Price });
        dgwMaintainences.DataSource = maintainenceBindingSource;
        dgwMaintainences.Location = new Point(67, 106);
        dgwMaintainences.MultiSelect = false;
        dgwMaintainences.Name = "dgwMaintainences";
        dgwMaintainences.ReadOnly = true;
        dgwMaintainences.Size = new Size(1176, 338);
        dgwMaintainences.TabIndex = 8;
        dgwMaintainences.CellClick += dgwMaintainences_CellClick;
        // 
        // idDataGridViewTextBoxColumn
        // 
        idDataGridViewTextBoxColumn.DataPropertyName = "Id";
        idDataGridViewTextBoxColumn.HeaderText = "Id";
        idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
        idDataGridViewTextBoxColumn.ReadOnly = true;
        idDataGridViewTextBoxColumn.Visible = false;
        // 
        // createdDateDataGridViewTextBoxColumn
        // 
        createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
        createdDateDataGridViewTextBoxColumn.HeaderText = "Tarih";
        createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
        createdDateDataGridViewTextBoxColumn.ReadOnly = true;
        createdDateDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
        // 
        // materialTypeDataGridViewTextBoxColumn
        // 
        materialTypeDataGridViewTextBoxColumn.DataPropertyName = "MaterialType";
        materialTypeDataGridViewTextBoxColumn.HeaderText = "Malzeme Adı";
        materialTypeDataGridViewTextBoxColumn.Name = "materialTypeDataGridViewTextBoxColumn";
        materialTypeDataGridViewTextBoxColumn.ReadOnly = true;
        materialTypeDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
        // 
        // unitTypeDataGridViewTextBoxColumn
        // 
        unitTypeDataGridViewTextBoxColumn.DataPropertyName = "UnitType";
        unitTypeDataGridViewTextBoxColumn.HeaderText = "Birim";
        unitTypeDataGridViewTextBoxColumn.Name = "unitTypeDataGridViewTextBoxColumn";
        unitTypeDataGridViewTextBoxColumn.ReadOnly = true;
        unitTypeDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
        // 
        // pieceDataGridViewTextBoxColumn
        // 
        pieceDataGridViewTextBoxColumn.DataPropertyName = "Piece";
        pieceDataGridViewTextBoxColumn.HeaderText = "Miktar";
        pieceDataGridViewTextBoxColumn.Name = "pieceDataGridViewTextBoxColumn";
        pieceDataGridViewTextBoxColumn.ReadOnly = true;
        pieceDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
        // 
        // unitPriceDataGridViewTextBoxColumn
        // 
        unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
        unitPriceDataGridViewTextBoxColumn.HeaderText = "Birim Fiyatı";
        unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
        unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
        unitPriceDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
        // 
        // kDVDataGridViewTextBoxColumn
        // 
        kDVDataGridViewTextBoxColumn.DataPropertyName = "KDV";
        kDVDataGridViewTextBoxColumn.HeaderText = "KDV";
        kDVDataGridViewTextBoxColumn.Name = "kDVDataGridViewTextBoxColumn";
        kDVDataGridViewTextBoxColumn.ReadOnly = true;
        kDVDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
        // 
        // PriceWithoutKDV
        // 
        dataGridViewCellStyle2.Format = "N2";
        dataGridViewCellStyle2.NullValue = null;
        PriceWithoutKDV.DefaultCellStyle = dataGridViewCellStyle2;
        PriceWithoutKDV.HeaderText = "KDV'siz Tutar";
        PriceWithoutKDV.Name = "PriceWithoutKDV";
        PriceWithoutKDV.ReadOnly = true;
        PriceWithoutKDV.Resizable = DataGridViewTriState.False;
        // 
        // Price
        // 
        Price.HeaderText = "Tutar";
        Price.Name = "Price";
        Price.ReadOnly = true;
        // 
        // maintainenceBindingSource
        // 
        maintainenceBindingSource.DataSource = typeof(Models.Entities.Maintainence);
        // 
        // txtPlate
        // 
        txtPlate.Location = new Point(160, 52);
        txtPlate.Name = "txtPlate";
        txtPlate.Size = new Size(166, 23);
        txtPlate.TabIndex = 1;
        txtPlate.TextChanged += txtPlate_TextChanged;
        // 
        // grpAdd
        // 
        grpAdd.Controls.Add(btnAdd);
        grpAdd.Controls.Add(cmbKDV);
        grpAdd.Controls.Add(cmbUnit);
        grpAdd.Controls.Add(txtPiece);
        grpAdd.Controls.Add(txtUnitPrice);
        grpAdd.Controls.Add(txtMaterialType);
        grpAdd.Controls.Add(lblKDV);
        grpAdd.Controls.Add(lblUnitPrice);
        grpAdd.Controls.Add(lblPiece);
        grpAdd.Controls.Add(lblUnit);
        grpAdd.Controls.Add(lblMaintainenceType);
        grpAdd.Location = new Point(67, 489);
        grpAdd.Name = "grpAdd";
        grpAdd.Size = new Size(387, 275);
        grpAdd.TabIndex = 2;
        grpAdd.TabStop = false;
        grpAdd.Text = "Yeni Kayıt Ekle";
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(264, 229);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(85, 24);
        btnAdd.TabIndex = 13;
        btnAdd.Text = "Ekle";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // cmbKDV
        // 
        cmbKDV.DataSource = new byte[]
{
    8,
    18,
    20
};
        cmbKDV.FormattingEnabled = true;
        cmbKDV.Location = new Point(142, 186);
        cmbKDV.Name = "cmbKDV";
        cmbKDV.Size = new Size(207, 23);
        cmbKDV.TabIndex = 12;
        // 
        // cmbUnit
        // 
        cmbUnit.DataBindings.Add(new Binding("Text", maintainenceBindingSource, "UnitType", true));
        cmbUnit.DataSource = new UnitType[]
{
    UnitType.Adet,
    UnitType.Litre,
    UnitType.Kutu
};
        cmbUnit.FormattingEnabled = true;
        cmbUnit.Location = new Point(142, 66);
        cmbUnit.Name = "cmbUnit";
        cmbUnit.Size = new Size(207, 23);
        cmbUnit.TabIndex = 11;
        // 
        // txtPiece
        // 
        txtPiece.Location = new Point(142, 107);
        txtPiece.Name = "txtPiece";
        txtPiece.Size = new Size(207, 23);
        txtPiece.TabIndex = 10;
        // 
        // txtUnitPrice
        // 
        txtUnitPrice.Location = new Point(142, 145);
        txtUnitPrice.Name = "txtUnitPrice";
        txtUnitPrice.Size = new Size(207, 23);
        txtUnitPrice.TabIndex = 9;
        // 
        // txtMaterialType
        // 
        txtMaterialType.Location = new Point(142, 26);
        txtMaterialType.Name = "txtMaterialType";
        txtMaterialType.Size = new Size(207, 23);
        txtMaterialType.TabIndex = 8;
        // 
        // lblKDV
        // 
        lblKDV.AutoSize = true;
        lblKDV.Location = new Point(15, 189);
        lblKDV.Name = "lblKDV";
        lblKDV.Size = new Size(29, 15);
        lblKDV.TabIndex = 7;
        lblKDV.Text = "KDV";
        // 
        // lblUnitPrice
        // 
        lblUnitPrice.AutoSize = true;
        lblUnitPrice.Location = new Point(15, 148);
        lblUnitPrice.Name = "lblUnitPrice";
        lblUnitPrice.Size = new Size(66, 15);
        lblUnitPrice.TabIndex = 6;
        lblUnitPrice.Text = "Birim Fiyatı";
        // 
        // lblPiece
        // 
        lblPiece.AutoSize = true;
        lblPiece.Location = new Point(15, 110);
        lblPiece.Name = "lblPiece";
        lblPiece.Size = new Size(41, 15);
        lblPiece.TabIndex = 5;
        lblPiece.Text = "Miktar";
        // 
        // lblUnit
        // 
        lblUnit.AutoSize = true;
        lblUnit.Location = new Point(15, 69);
        lblUnit.Name = "lblUnit";
        lblUnit.Size = new Size(35, 15);
        lblUnit.TabIndex = 4;
        lblUnit.Text = "Birim";
        // 
        // lblMaintainenceType
        // 
        lblMaintainenceType.AutoSize = true;
        lblMaintainenceType.Location = new Point(15, 29);
        lblMaintainenceType.Name = "lblMaintainenceType";
        lblMaintainenceType.Size = new Size(58, 15);
        lblMaintainenceType.TabIndex = 3;
        lblMaintainenceType.Text = "Ürün İsmi";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(67, 55);
        label1.Name = "label1";
        label1.Size = new Size(70, 15);
        label1.TabIndex = 3;
        label1.Text = "Araç Plakası";
        // 
        // btnGetRecords
        // 
        btnGetRecords.Location = new Point(363, 52);
        btnGetRecords.Name = "btnGetRecords";
        btnGetRecords.Size = new Size(91, 23);
        btnGetRecords.TabIndex = 4;
        btnGetRecords.Text = "Kayıtları Getir";
        btnGetRecords.UseVisualStyleBackColor = true;
        btnGetRecords.Click += btnGetRecords_Click;
        // 
        // lblSumPrice
        // 
        lblSumPrice.AutoSize = true;
        lblSumPrice.Location = new Point(1030, 462);
        lblSumPrice.Name = "lblSumPrice";
        lblSumPrice.Size = new Size(0, 15);
        lblSumPrice.TabIndex = 5;
        // 
        // grpUpdate
        // 
        grpUpdate.Controls.Add(btnUpdate);
        grpUpdate.Controls.Add(cmbUpdateKDV);
        grpUpdate.Controls.Add(cmbUpdateUnit);
        grpUpdate.Controls.Add(txtUpdatePiece);
        grpUpdate.Controls.Add(txtUpdateUnitPrice);
        grpUpdate.Controls.Add(txtUpdateMaterial);
        grpUpdate.Controls.Add(label2);
        grpUpdate.Controls.Add(label3);
        grpUpdate.Controls.Add(label4);
        grpUpdate.Controls.Add(label5);
        grpUpdate.Controls.Add(label6);
        grpUpdate.Location = new Point(550, 489);
        grpUpdate.Name = "grpUpdate";
        grpUpdate.Size = new Size(387, 275);
        grpUpdate.TabIndex = 6;
        grpUpdate.TabStop = false;
        grpUpdate.Text = "Kaydı Güncelle";
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(264, 229);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(85, 24);
        btnUpdate.TabIndex = 13;
        btnUpdate.Text = "Güncelle";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // cmbUpdateKDV
        // 
        cmbUpdateKDV.DataSource = new byte[]
{
    8,
    18,
    20
};
        cmbUpdateKDV.FormattingEnabled = true;
        cmbUpdateKDV.Location = new Point(142, 186);
        cmbUpdateKDV.Name = "cmbUpdateKDV";
        cmbUpdateKDV.Size = new Size(207, 23);
        cmbUpdateKDV.TabIndex = 12;
        // 
        // cmbUpdateUnit
        // 
        cmbUpdateUnit.DataSource = new UnitType[]
{
    UnitType.Adet,
    UnitType.Litre,
    UnitType.Kutu
};
        cmbUpdateUnit.FormattingEnabled = true;
        cmbUpdateUnit.Location = new Point(142, 66);
        cmbUpdateUnit.Name = "cmbUpdateUnit";
        cmbUpdateUnit.Size = new Size(207, 23);
        cmbUpdateUnit.TabIndex = 11;
        // 
        // txtUpdatePiece
        // 
        txtUpdatePiece.Location = new Point(142, 107);
        txtUpdatePiece.Name = "txtUpdatePiece";
        txtUpdatePiece.Size = new Size(207, 23);
        txtUpdatePiece.TabIndex = 10;
        // 
        // txtUpdateUnitPrice
        // 
        txtUpdateUnitPrice.Location = new Point(142, 145);
        txtUpdateUnitPrice.Name = "txtUpdateUnitPrice";
        txtUpdateUnitPrice.Size = new Size(207, 23);
        txtUpdateUnitPrice.TabIndex = 9;
        // 
        // txtUpdateMaterial
        // 
        txtUpdateMaterial.Location = new Point(142, 26);
        txtUpdateMaterial.Name = "txtUpdateMaterial";
        txtUpdateMaterial.Size = new Size(207, 23);
        txtUpdateMaterial.TabIndex = 8;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(15, 189);
        label2.Name = "label2";
        label2.Size = new Size(29, 15);
        label2.TabIndex = 7;
        label2.Text = "KDV";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(15, 148);
        label3.Name = "label3";
        label3.Size = new Size(66, 15);
        label3.TabIndex = 6;
        label3.Text = "Birim Fiyatı";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(15, 110);
        label4.Name = "label4";
        label4.Size = new Size(41, 15);
        label4.TabIndex = 5;
        label4.Text = "Miktar";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(15, 69);
        label5.Name = "label5";
        label5.Size = new Size(35, 15);
        label5.TabIndex = 4;
        label5.Text = "Birim";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(15, 29);
        label6.Name = "label6";
        label6.Size = new Size(58, 15);
        label6.TabIndex = 3;
        label6.Text = "Ürün İsmi";
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(1030, 586);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(144, 33);
        btnDelete.TabIndex = 7;
        btnDelete.Text = "Seçili Kaydı Sil";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // lblPriceWithoutKDV
        // 
        lblPriceWithoutKDV.AutoSize = true;
        lblPriceWithoutKDV.Location = new Point(1030, 487);
        lblPriceWithoutKDV.Name = "lblPriceWithoutKDV";
        lblPriceWithoutKDV.Size = new Size(0, 15);
        lblPriceWithoutKDV.TabIndex = 9;
        // 
        // CarCare
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1401, 776);
        Controls.Add(lblPriceWithoutKDV);
        Controls.Add(dgwMaintainences);
        Controls.Add(btnDelete);
        Controls.Add(grpUpdate);
        Controls.Add(lblSumPrice);
        Controls.Add(btnGetRecords);
        Controls.Add(label1);
        Controls.Add(grpAdd);
        Controls.Add(txtPlate);
        Name = "CarCare";
        Text = "Car Care System";
        Load += CarCare_Load;
        ((System.ComponentModel.ISupportInitialize)dgwMaintainences).EndInit();
        ((System.ComponentModel.ISupportInitialize)maintainenceBindingSource).EndInit();
        grpAdd.ResumeLayout(false);
        grpAdd.PerformLayout();
        grpUpdate.ResumeLayout(false);
        grpUpdate.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private TextBox txtPlate;
    private GroupBox grpAdd;
    private ComboBox cmbKDV;
    private ComboBox cmbUnit;
    private TextBox txtPiece;
    private TextBox txtUnitPrice;
    private TextBox txtMaterialType;
    private Label lblKDV;
    private Label lblUnitPrice;
    private Label lblPiece;
    private Label lblUnit;
    private Label lblMaintainenceType;
    private Button btnAdd;
    private Label label1;
    private Button btnGetRecords;
    private Label lblSumPrice;
    private GroupBox grpUpdate;
    private Button btnUpdate;
    private ComboBox cmbUpdateKDV;
    private ComboBox cmbUpdateUnit;
    private TextBox txtUpdatePiece;
    private TextBox txtUpdateUnitPrice;
    private TextBox txtUpdateMaterial;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Button btnDelete;
    private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
    private DataGridView dgwMaintainences;
    private BindingSource maintainenceBindingSource;
    private Label lblPriceWithoutKDV;
    private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn materialTypeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn unitTypeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn pieceDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn kDVDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn PriceWithoutKDV;
    private DataGridViewTextBoxColumn Price;
}

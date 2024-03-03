using CarCareSystem.Data;
using CarCareSystem.Models.Entities;
using System.Windows.Forms;

namespace CarCareSystem;

public partial class CarCare : Form
{
    public CarCare()
    {
        InitializeComponent();
    }
    private void CarCare_Load(object sender, EventArgs e)
    {
        DisableAddMaintenanceControls();
        DisableUpdateMaintenanceControls();
    }
    private async void btnGetRecords_Click(object sender, EventArgs e)
    {
        try
        {
            btnGetRecords.Enabled = false;
            DisableAddMaintenanceControls();
            DisableUpdateMaintenanceControls();
            string licencePlate = txtPlate.Text;

            Repository repository = new Repository();
            Car car = await repository.GetCarByPlate(licencePlate);

            if (car is null)
            {
                DialogResult result = MessageBox.Show("Araca ait kayıt bulunamadı. Plakayı doğru girdiğinize eminseniz veritabanına eklenecektir?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    await repository.AddCarAsync(licencePlate);
                    MessageBox.Show("Araç veritabanına eklendi");
                    EnableAddMaintenanceControls();
                }
            }
            else if (car.Maintainences.Any())
            {
                List<Maintainence> maintainences = car.Maintainences.ToList();
                dgwMaintainences.DataSource = maintainences;
                EnableAddMaintenanceControls();
                CalculateRowPrice(maintainences);
                CalculateTotalPrice();
                CalculateTotalPriceWithoutKDV();
            }
            else
            {
                dgwMaintainences.DataSource = null;
                EnableAddMaintenanceControls();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Hata oluştu: {ex.Message}");
        }
        finally
        {
            btnGetRecords.Enabled = true;
        }
    }
    private async void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            DisableAddMaintenanceControls();
            string licencePlate = txtPlate.Text;

            Repository repository = new Repository();
            Car car = await repository.GetCarByPlate(licencePlate);

            if (car is Car)
            {
                Maintainence newMaintenance = new Maintainence();

                if (!string.IsNullOrWhiteSpace(txtMaterialType.Text))
                {
                    newMaintenance.MaterialType = txtMaterialType.Text;
                }
                else
                {
                    MessageBox.Show("Malzeme tipi boş olamaz.");
                    return;
                }

                if (cmbUnit.SelectedValue != null)
                {
                    newMaintenance.UnitType = Helper.StringToEnum(cmbUnit.SelectedValue.ToString());
                }
                else
                {
                    MessageBox.Show("Birim tipi seçilmelidir.");
                    return;
                }

                if (int.TryParse(txtPiece.Text, out int pieceValue))
                {
                    newMaintenance.Piece = pieceValue;
                }
                else
                {
                    MessageBox.Show("Parça sayısı geçerli bir sayı değil.");
                    return;
                }

                if (decimal.TryParse(txtUnitPrice.Text, out decimal unitPriceValue))
                {
                    newMaintenance.UnitPrice = unitPriceValue;
                }
                else
                {
                    MessageBox.Show("Birim fiyat geçerli bir sayı değil.");
                    return;
                }

                if (cmbKDV.SelectedItem != null && byte.TryParse(cmbKDV.SelectedItem.ToString(), out byte kdvValue))
                {
                    newMaintenance.KDV = kdvValue;
                }
                else
                {
                    MessageBox.Show("KDV değeri geçerli bir sayı değil.");
                    return;
                }

                newMaintenance.CarId = car.Id;
                car.Maintainences.Add(newMaintenance);
                await repository.AddMaintainenceAsync(newMaintenance);
                MessageBox.Show("Kayıt işlemi başarılı.");
                ResetAddInputFields();
                btnGetRecords_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Araca ait kayıt bulunamadı. Lütfen geçerli bir plaka giriniz.");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Hata oluştu: {ex.Message}");
        }
        finally
        {
            EnableAddMaintenanceControls();
        }
    }
    private async void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            DisableUpdateMaintenanceControls();

            string licencePlate = txtPlate.Text;
            Repository repository = new Repository();

            Car car = await repository.GetCarByPlate(licencePlate);

            if (car == null)
            {
                MessageBox.Show("Araca ait kayıt bulunamadı. Lütfen geçerli bir plaka giriniz.");
                return;
            }

            if (dgwMaintainences.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgwMaintainences.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgwMaintainences.Rows[selectedRowIndex];

                if (selectedRow.Cells[0].Value == null)
                {
                    MessageBox.Show("Belirtilen bakım kaydı bulunamadı. Lütfen geçerli bir bakım ID giriniz.");
                    return;
                }

                Maintainence updatedMaintenance = new Maintainence();

                if (!string.IsNullOrWhiteSpace(txtUpdateMaterial.Text))
                {
                    updatedMaintenance.MaterialType = txtUpdateMaterial.Text;
                }
                else
                {
                    MessageBox.Show("Malzeme tipi boş olamaz.");
                    return;
                }

                if (cmbUpdateUnit.SelectedValue != null)
                {
                    updatedMaintenance.UnitType = Helper.StringToEnum(cmbUpdateUnit.SelectedValue.ToString());
                }
                else
                {
                    MessageBox.Show("Birim tipi seçilmelidir.");
                    return;
                }

                if (int.TryParse(txtUpdatePiece.Text, out int pieceValue))
                {
                    updatedMaintenance.Piece = pieceValue;
                }
                else
                {
                    MessageBox.Show("Parça sayısı geçerli bir sayı değil.");
                    return;
                }

                if (decimal.TryParse(txtUpdateUnitPrice.Text, out decimal unitPriceValue))
                {
                    updatedMaintenance.UnitPrice = unitPriceValue;
                }
                else
                {
                    MessageBox.Show("Birim fiyat geçerli bir sayı değil.");
                    return;
                }

                if (cmbUpdateKDV.SelectedItem != null && byte.TryParse(cmbUpdateKDV.SelectedItem.ToString(), out byte kdvValue))
                {
                    updatedMaintenance.KDV = kdvValue;
                }
                else
                {
                    MessageBox.Show("KDV değeri geçerli bir sayı değil.");
                    return;
                }

                await repository.UpdateMaintainenceAsync(Guid.Parse(selectedRow.Cells[0].Value.ToString()), updatedMaintenance);
                MessageBox.Show("Güncelleme işlemi başarılı.");
                ResetUpdateInputFields();
                btnGetRecords_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Böyle bir bakım bulunamadı.");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Hata oluştu: {ex.Message}");
        }
        finally
        {
            EnableUpdateMaintenanceControls();
        }
    }
    private async void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            string licencePlate = txtPlate.Text;
            Repository repository = new Repository();

            Car car = await repository.GetCarByPlate(licencePlate);

            if (car == null)
            {
                MessageBox.Show("Araca ait kayıt bulunamadı. Lütfen geçerli bir plaka giriniz.");
                return;
            }

            if (dgwMaintainences.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgwMaintainences.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgwMaintainences.Rows[selectedRowIndex];

                if (selectedRow.Cells[0].Value == null)
                {
                    MessageBox.Show("Belirtilen bakım kaydı bulunamadı.");
                    return;
                }

                DialogResult result = MessageBox.Show("Seçili kayıt silinecektir. Emin misiniz?","Soru",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Guid maintenanceId = Guid.Parse(selectedRow.Cells[0].Value.ToString());
                    Maintainence deletedMaintainence = await repository.GetMaintainenceById(maintenanceId);
                    await repository.DeleteMaintainenceAsync(deletedMaintainence);

                    MessageBox.Show("Silme işlemi başarılı.");
                    ResetUpdateInputFields();

                    if (car.Maintainences.Count > 1)
                    {
                        btnGetRecords_Click(sender, e);
                        return;
                    }
                    dgwMaintainences.DataSource = null;
                    lblSumPrice.Text = string.Empty;
                    lblPriceWithoutKDV.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Böyle bir bakım bulunamadı.");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Hata oluştu: {ex.Message}");
        }
        finally
        {
            DisableUpdateMaintenanceControls();
            btnDelete.Enabled = false;
        }
    }


    private void dgwMaintainences_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        var row = dgwMaintainences.CurrentRow;
        if (row != null)
        {
            txtUpdateMaterial.Text = row.Cells[2].Value.ToString();
            cmbUpdateUnit.SelectedItem = row.Cells[3].Value;
            txtUpdatePiece.Text = row.Cells[4].Value.ToString();
            txtUpdateUnitPrice.Text = row.Cells[5].Value.ToString();
            cmbUpdateKDV.SelectedItem = row.Cells[6].Value;

            EnableUpdateMaintenanceControls();
            btnDelete.Visible = true;
            btnDelete.Enabled = true;
        }
    }
    private void txtPlate_TextChanged(object sender, EventArgs e)
    {
        btnGetRecords.Enabled = !string.IsNullOrWhiteSpace(txtPlate.Text);
    }
    private void ResetAddInputFields()
    {
        txtMaterialType.Text = string.Empty;
        txtPiece.Text = string.Empty;
        txtUnitPrice.Text = string.Empty;
        cmbKDV.SelectedItem = null;
        cmbUnit.SelectedItem = null;
    }
    private void ResetUpdateInputFields()
    {
        txtUpdateMaterial.Text = string.Empty;
        txtUpdatePiece.Text = string.Empty;
        txtUpdateUnitPrice.Text = string.Empty;
        cmbUpdateUnit.SelectedItem = null;
        cmbUpdateKDV.SelectedItem = null;
    }
    private void EnableAddMaintenanceControls()
    {
        txtMaterialType.Enabled = true;
        txtPiece.Enabled = true;
        txtUnitPrice.Enabled = true;
        cmbKDV.Enabled = true;
        cmbUnit.Enabled = true;
        btnAdd.Enabled = true;
    }
    private void DisableAddMaintenanceControls()
    {
        txtMaterialType.Enabled = false;
        txtPiece.Enabled = false;
        txtUnitPrice.Enabled = false;
        cmbKDV.Enabled = false;
        cmbUnit.Enabled = false;
        btnAdd.Enabled = false;
        btnDelete.Visible = false;
    }
    private void EnableUpdateMaintenanceControls()
    {
        txtUpdateMaterial.Enabled = true;
        txtUpdatePiece.Enabled = true;
        txtUpdateUnitPrice.Enabled = true;
        cmbUpdateUnit.Enabled = true;
        cmbUpdateKDV.Enabled = true;
        btnUpdate.Enabled = true;
        lblSumPrice.Enabled = true;
        lblPriceWithoutKDV.Enabled = true;
    }
    private void DisableUpdateMaintenanceControls()
    {
        txtUpdateMaterial.Enabled = false;
        txtUpdatePiece.Enabled = false;
        txtUpdateUnitPrice.Enabled = false;
        cmbUpdateUnit.Enabled = false;
        cmbUpdateKDV.Enabled = false;
        btnUpdate.Enabled = false;
    }
    private void CalculateRowPrice(List<Maintainence> maintainences)
    {
        for (int i = 0; i < maintainences.Count; i++)
        {
            decimal total = maintainences[i].Piece * maintainences[i].UnitPrice;
            dgwMaintainences.Rows[i].Cells[7].Value = total / (1 + ((decimal)maintainences[i].KDV / 100));
            dgwMaintainences.Rows[i].Cells[8].Value = total;
        }
    }
    private void CalculateTotalPrice()
    {
        decimal totalAmount = 0;

        foreach (DataGridViewRow row in dgwMaintainences.Rows)
        {
            if (row.Cells[8].Value != null)
            {
                totalAmount += Convert.ToDecimal(row.Cells[8].Value);
            }
        }
        lblSumPrice.Enabled = true;
        lblSumPrice.Text = $"Toplam Tutar : {totalAmount}";
    }
    private void CalculateTotalPriceWithoutKDV()
    {
        decimal totalAmount = 0;
        foreach (DataGridViewRow row in dgwMaintainences.Rows)
        {
            if (row.Cells[7].Value != null)
            {
                totalAmount += Convert.ToDecimal(row.Cells[7].Value);
            }
        }
        lblPriceWithoutKDV.Enabled = true;
        lblPriceWithoutKDV.Text = $"Toplam KDV'siz Tutar : {totalAmount.ToString("F2")}";
    }
}

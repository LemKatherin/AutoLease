using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoLeaseClass;
using Microsoft.Office.Interop.Excel;
using AutoLeaseServeces;
using AutoLeaseStorage;

namespace AutoLease.StartMenu
{
    public partial class ClientCardInfo : Form
    {
        private Microsoft.Office.Interop.Excel.Application excelapp;
        private Microsoft.Office.Interop.Excel.Workbook excelworkbook;
        private Microsoft.Office.Interop.Excel.Worksheet excelworksheet;
        List<String> returnCars = new List<string>();
        List<Lease> leaseList = new List<Lease>();
        Client showClient = new Client();

        public ClientCardInfo()
        {
            InitializeComponent();
           
        }

        public ClientCardInfo(bool flag)
        {
            InitializeComponent();
            SumCountButton.Enabled = flag;
            ChangeButton.Enabled = !flag;
        }

        public ClientCardInfo(bool flag, Client client)
        {
            InitializeComponent();

            SumCountButton.Enabled = flag;
            ChangeButton.Enabled = !flag;

            IDClientTextBox.Text = client.ID;
            ClientTextBox.Text = client.Surname+" " +client.Name+" " +client.SecondName;
            if(client.Sex)
            SexTextBox.Text = "мужской";
            else
                SexTextBox.Text = "женский";
            AgeTextBox.Text = client.Birthday.Date.ToShortDateString();
            CreationDateTextBox.Text = client.RegistrationDate.Date.ToShortDateString();
            PassportTextBox.Text = client.Passport;
            DriverLicDateTextBox.Text = client.DriverLicenseTime.Date.ToShortDateString();
            DebtCheckBox.Checked = client.Debt;
            leaseList = client.leaseList;
            showClient = client;
            repaint();
            showCars();
            tableClientPanel.Show();
           
        }

        public void repaint()
        {
            tableClientPanel.Hide();
            while (tableClientPanel.RowCount > 4)
            {
                int row = tableClientPanel.RowCount - 1;
                for (int i = 0; i < tableClientPanel.ColumnCount; i++)
                {
                    Control c = tableClientPanel.GetControlFromPosition(i, row);
                    tableClientPanel.Controls.Remove(c);
                }

                tableClientPanel.RowStyles.RemoveAt(row);
                tableClientPanel.RowCount--;
                tableClientPanel.Height -= 35;
            }
        }

        private void showCars()
        {
            if (leaseList.Count != 0)
            {
                int j = 3;
                foreach (Lease automobile in leaseList)
                {
                    if (j == 3)
                    {
                        IDTextBox.Text = automobile.LeasedAutomobile.ID;
                        ModelTextBox.Text = automobile.LeasedAutomobile.Mark + " " + automobile.LeasedAutomobile.Model;
                        LeaseTextBox.Text = automobile.LeaseDate.ToShortDateString();
                        if (!automobile.ReturnDate.Year.Equals(1))
                        {
                            CarCheckBox1.Enabled = false;
                            CarCheckBox1.Checked = true;
                            ReturnTextBox.Text = automobile.ReturnDate.ToShortDateString();
                            if (automobile.ReturnDate.Subtract(automobile.LeaseDate).TotalDays > automobile.DaysLease)
                                DaysLateTextBox.Text = (automobile.ReturnDate.Subtract(automobile.LeaseDate).TotalDays - automobile.DaysLease).ToString();
                            else
                                DaysLateTextBox.Text = "0";
                        }
                        SumLeaseTextBox.Text = automobile.Sum.SumLease.ToString();
                        PennyTextBox.Text = automobile.Sum.SumPenny.ToString();
                        CommonSumTextBox.Text = automobile.Sum.CommonSum.ToString();
                        j++;
                        continue;
                    }

                    tableClientPanel.RowCount = ++tableClientPanel.RowCount;
                    tableClientPanel.Size = new System.Drawing.Size(tableClientPanel.Width, this.tableClientPanel.Size.Height + 35);
                    tableClientPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35));

                    System.Windows.Forms.TextBox IDTextBoxNew = new System.Windows.Forms.TextBox();
                    IDTextBoxNew.Text = automobile.LeasedAutomobile.ID;
                    IDTextBoxNew.Anchor = IDTextBox.Anchor;
                    IDTextBoxNew.Font = IDTextBox.Font;
                    IDTextBoxNew.Size = IDTextBox.Size;
                    IDTextBoxNew.Enabled = IDTextBox.Enabled;

                    System.Windows.Forms.TextBox ModelTextBoxNew = new System.Windows.Forms.TextBox();
                    ModelTextBoxNew.Text = automobile.LeasedAutomobile.Mark + " " + automobile.LeasedAutomobile.Model;
                    ModelTextBoxNew.Anchor = ModelTextBox.Anchor;
                    ModelTextBoxNew.Font = ModelTextBox.Font;
                    ModelTextBoxNew.Size = ModelTextBox.Size;
                    ModelTextBoxNew.Enabled = ModelTextBox.Enabled;

                    System.Windows.Forms.TextBox LeaseTextBoxNew = new System.Windows.Forms.TextBox();
                    LeaseTextBoxNew.Text = automobile.LeaseDate.ToShortDateString();
                    LeaseTextBoxNew.Anchor = LeaseTextBox.Anchor;
                    LeaseTextBoxNew.Font = LeaseTextBox.Font;
                    LeaseTextBoxNew.Size = LeaseTextBox.Size;
                    LeaseTextBoxNew.Enabled = LeaseTextBox.Enabled;


                    System.Windows.Forms.TextBox ReturnTextBoxNew = new System.Windows.Forms.TextBox();
                    if (!automobile.ReturnDate.Year.Equals(1))
                        ReturnTextBoxNew.Text = automobile.ReturnDate.ToShortDateString();
                    ReturnTextBoxNew.Anchor = ReturnTextBox.Anchor;
                    ReturnTextBoxNew.Font = ReturnTextBox.Font;
                    ReturnTextBoxNew.Size = ReturnTextBox.Size;
                    ReturnTextBoxNew.Enabled = ReturnTextBox.Enabled;

                    System.Windows.Forms.TextBox DaysLateTextBoxNew = new System.Windows.Forms.TextBox();
                    if (!automobile.ReturnDate.Year.Equals(1))
                    {
                        if(automobile.ReturnDate.Subtract(automobile.LeaseDate).TotalDays > 7)
                        DaysLateTextBoxNew.Text = (automobile.ReturnDate.Subtract(automobile.LeaseDate).TotalDays - 7).ToString();
                        else
                            DaysLateTextBoxNew.Text = "0";
                    }
                    DaysLateTextBoxNew.Anchor = DaysLateTextBox.Anchor;
                    DaysLateTextBoxNew.Font = DaysLateTextBox.Font;
                    DaysLateTextBoxNew.Size = DaysLateTextBox.Size;
                    DaysLateTextBoxNew.Enabled = DaysLateTextBox.Enabled;

                    System.Windows.Forms.TextBox SumLeaseTextBoxNew = new System.Windows.Forms.TextBox();
                    SumLeaseTextBoxNew.Text = automobile.Sum.SumLease.ToString();
                    SumLeaseTextBoxNew.Anchor = SumLeaseTextBox.Anchor;
                    SumLeaseTextBoxNew.Font = SumLeaseTextBox.Font;
                    SumLeaseTextBoxNew.Size = SumLeaseTextBox.Size;
                    SumLeaseTextBoxNew.Enabled = SumLeaseTextBox.Enabled;

                    System.Windows.Forms.TextBox PennyTextBoxNew = new System.Windows.Forms.TextBox();
                    PennyTextBoxNew.Text = automobile.Sum.SumPenny.ToString();
                    PennyTextBoxNew.Anchor = PennyTextBox.Anchor;
                    PennyTextBoxNew.Font = PennyTextBox.Font;
                    PennyTextBoxNew.Size = PennyTextBox.Size;
                    PennyTextBoxNew.Enabled = PennyTextBox.Enabled;

                    System.Windows.Forms.TextBox CommonSumTextBoxNew = new System.Windows.Forms.TextBox();
                    CommonSumTextBoxNew.Text = automobile.Sum.CommonSum.ToString();
                    CommonSumTextBoxNew.Anchor = CommonSumTextBox.Anchor;
                    CommonSumTextBoxNew.Font = CommonSumTextBox.Font;
                    CommonSumTextBoxNew.Size = CommonSumTextBox.Size;
                    CommonSumTextBoxNew.Enabled = CommonSumTextBox.Enabled;

                    System.Windows.Forms.CheckBox CarCheckBoxNew = new System.Windows.Forms.CheckBox();
                    CarCheckBoxNew.Name = "CarCheckBox" + j.ToString();
                    if (!automobile.ReturnDate.Year.Equals(1))
                    {
                        CarCheckBoxNew.Enabled = false;
                        CarCheckBoxNew.Checked = true;
                    }
                    else
                        CarCheckBoxNew.Enabled = true;
                    CarCheckBoxNew.Anchor = CarCheckBox1.Anchor;
                    CarCheckBoxNew.Size = CarCheckBox1.Size;
                    CarCheckBoxNew.CheckedChanged += CarCheckBox_CheckStateChanged;

                    tableClientPanel.Controls.Add(CarCheckBoxNew, 0, j);
                    tableClientPanel.Controls.Add(IDTextBoxNew, 1, j);
                    tableClientPanel.Controls.Add(ModelTextBoxNew, 2, j);
                    tableClientPanel.Controls.Add(LeaseTextBoxNew, 3, j);
                    tableClientPanel.Controls.Add(ReturnTextBoxNew, 4, j);
                    tableClientPanel.Controls.Add(DaysLateTextBoxNew, 5, j);
                    tableClientPanel.Controls.Add(SumLeaseTextBoxNew, 6, j);
                    tableClientPanel.Controls.Add(PennyTextBoxNew, 7, j);
                    tableClientPanel.Controls.Add(CommonSumTextBoxNew, 8, j);
                    j++;
                }
            }
        }

        private void setExcelTableCells()
        {
            excelworksheet.Cells[1, 3] = ClientTextBox.Text;
            excelworksheet.Cells[2, 3] = SexTextBox.Text;
            excelworksheet.Cells[3, 3] = AgeTextBox.Text;
            excelworksheet.Cells[4, 3] = CreationDateTextBox.Text;
            excelworksheet.Cells[5, 3] = PassportTextBox.Text;
            excelworksheet.Cells[6, 3] = DriverLicDateTextBox.Text;
            if(DebtCheckBox.Checked)
                excelworksheet.Cells[7, 3] = "да";
            else
                excelworksheet.Cells[7, 3] = "нет";
            excelworksheet.Cells[1, 7] = IDClientTextBox.Text;

            int i = 12;
            foreach(Lease auto in showClient.leaseList)
            {
                excelworksheet.Range[excelworksheet.Cells[i, 1], excelworksheet.Cells[i, 8]].Borders.LineStyle = XlLineStyle.xlContinuous;
                excelworksheet.Range[excelworksheet.Cells[i, 1], excelworksheet.Cells[i, 8]].Borders.Color = XlRgbColor.rgbBlack;
                excelworksheet.Cells[i, 1] = auto.LeasedAutomobile.ID.ToString();
                excelworksheet.Cells[i, 2] = auto.LeasedAutomobile.Mark.ToString() + auto.LeasedAutomobile.Model.ToString();
                excelworksheet.Cells[i, 3] = auto.LeaseDate.Date.ToShortDateString();
                if (auto.ReturnDate.Date.Year != 1)
                {
                    excelworksheet.Cells[i, 4] = auto.ReturnDate.Date.ToShortDateString();
                    if (auto.ReturnDate.Subtract(auto.LeaseDate).TotalDays <= 7)
                        excelworksheet.Cells[i, 5] = "0";
                    else
                        excelworksheet.Cells[i, 5] = (auto.ReturnDate.Subtract(auto.LeaseDate).TotalDays - 7).ToString();
                    excelworksheet.Cells[i, 6] = auto.Sum.SumLease.ToString();
                    excelworksheet.Cells[i, 7] = auto.Sum.SumPenny.ToString();
                    excelworksheet.Cells[i, 8] = auto.Sum.CommonSum.ToString();
                }
                i++;
            }       
        }

        private void ExelOpenButton_Click(object sender, EventArgs e)
        {
            excelapp = new Microsoft.Office.Interop.Excel.Application();
            excelapp.SheetsInNewWorkbook = 1;
            excelworkbook = excelapp.Workbooks.Add(Type.Missing);
            excelworksheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkbook.Sheets[1];

            excelworksheet.Cells.Font.Size = 10;
            excelworksheet.Range[excelworksheet.Cells[1, 1], excelworksheet.Cells[9, 8]].Font.Size = 12;
            excelworksheet.Cells.ColumnWidth = 10;
            excelworksheet.Range[excelworksheet.Cells[1, 1], excelworksheet.Cells[1, 2]].Merge();
            excelworksheet.Range[excelworksheet.Cells[1, 3], excelworksheet.Cells[1, 6]].Merge();
            excelworksheet.Range[excelworksheet.Cells[1, 7], excelworksheet.Cells[1, 8]].Merge();
            for (int i = 2; i <= 9; i++)
            {
                excelworksheet.Range[excelworksheet.Cells[i, 1], excelworksheet.Cells[i, 2]].Merge();
                excelworksheet.Range[excelworksheet.Cells[i, 3], excelworksheet.Cells[i, 8]].Merge();
            }

            excelworksheet.Cells[1, 1] = "Клиент:";
            excelworksheet.Cells[2, 1] = "Пол:";
            excelworksheet.Cells[3, 1] = "Возраст:";
            excelworksheet.Cells[4, 1] = "Зарегестрирован:";
            excelworksheet.Cells[5, 1] = "Паспорт:";
            excelworksheet.Cells[6, 1] = "Права до:";
            excelworksheet.Cells[7, 1] = "Задолженность:";
            excelworksheet.Cells[9, 1] = "Список заказов:";
            excelworksheet.Range[excelworksheet.Cells[10, 1], excelworksheet.Cells[10, 2]].Merge();
            excelworksheet.Cells[10, 1] = "Автомобиль";
            excelworksheet.Range[excelworksheet.Cells[10, 3], excelworksheet.Cells[10, 4]].Merge();
            excelworksheet.Range[excelworksheet.Cells[10, 5], excelworksheet.Cells[11, 5]].Merge();
            excelworksheet.Cells[10, 5] = "Кол-во дней опоздания возврата";
            excelworksheet.Cells[10, 3] = "Даты";
            excelworksheet.Range[excelworksheet.Cells[10, 6], excelworksheet.Cells[10, 8]].Merge();
            excelworksheet.Cells[10, 6] = "Сумма";
            excelworksheet.Cells[11, 1] = "Инв. №";
            excelworksheet.Cells[11, 2] = "Модель";
            excelworksheet.Cells[11, 3] = "выдачи";
            excelworksheet.Cells[11, 4] = "возврата";
            excelworksheet.Cells[11, 6] = "проката";
            excelworksheet.Cells[11, 7] = "пени";
            excelworksheet.Cells[11, 8] = "ИТОГО";


            excelworksheet.Cells.VerticalAlignment = true;
            excelworksheet.Cells.WrapText = true;
            excelworksheet.Range[excelworksheet.Cells[11, 1], excelworksheet.Cells[11, 8]].RowHeight = excelworksheet.Cells[10, 1].RowHeight * 2;
            excelworksheet.Range[excelworksheet.Cells[1, 1], excelworksheet.Cells[9, 8]].Borders.Color = XlRgbColor.rgbWhite;
            excelworksheet.Range[excelworksheet.Cells[1, 1], excelworksheet.Cells[9, 8]].Borders.Item[XlBordersIndex.xlEdgeRight].Color = XlRgbColor.rgbBlack;
            excelworksheet.Range[excelworksheet.Cells[10, 1], excelworksheet.Cells[11, 8]].Font.Bold = true;
            excelworksheet.Range[excelworksheet.Cells[10, 1], excelworksheet.Cells[11, 8]].Borders.LineStyle = XlLineStyle.xlContinuous;
            excelworksheet.Cells[1, 3].Font.Bold = true;
            excelworksheet.Cells[1, 7].HorizontalAlignment = XlHAlign.xlHAlignCenter;
            excelworksheet.Cells[1, 7].Borders.Color = XlRgbColor.rgbBlack;
            excelworksheet.Range[excelworksheet.Cells[1, 7], excelworksheet.Cells[1, 8]].Borders.LineStyle = XlLineStyle.xlContinuous;

            setExcelTableCells();
            excelworksheet.Protect();
            excelapp.Visible = true;
        }

        private void SumCountButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Lease> auto = new List<Lease>();
                ClientListService.ClientLease(IDClientTextBox.Text, returnCars, ref auto);
                foreach (Lease i in auto)
                {
                    DialogResult result = MessageBox.Show("Сумма к оплате: " + i.Sum.CommonSum + "$. Потдвердить оплату?", 
                        i.LeasedAutomobile.Mark + " " + i.LeasedAutomobile.Model + " (" + i.LeasedAutomobile.ID + ")", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                        ClientListService.AnnulmentReturn(i);
                    else
                    {
                        NewMileage mileage = new NewMileage(i.LeasedAutomobile);
                        mileage.ShowDialog();
                    }
                }

                Client client = ClientListService.ClientSearch(IDClientTextBox.Text);
                if (client != null)
                {
                    repaint();
                    showCars();
                    tableClientPanel.Show();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           

        }

        private void CarCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            TableLayoutPanelCellPosition pos = tableClientPanel.GetPositionFromControl((Control)sender);
            System.Windows.Forms.CheckBox check = (System.Windows.Forms.CheckBox)sender;

            if(check.Checked)
                returnCars.Add((tableClientPanel.GetControlFromPosition(1, pos.Row).Text));
            else
                returnCars.RemoveAt(returnCars.LastIndexOf(tableClientPanel.GetControlFromPosition(1, pos.Row).Text));
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            ClientTextBox.Enabled = true;
            DriverLicDateTextBox.Enabled = true;
            PassportTextBox.Enabled = true;
            SaveButton.Visible = true;
        }

        private void ClientTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            ChangeClient change = new ChangeClient(showClient);
            change.ShowDialog();
            ClientTextBox.Text = showClient.Surname + " " + showClient.Name + " " + showClient.SecondName;
            IDClientTextBox.Text = showClient.ID;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (PassportTextBox.MaskFull && DriverLicDateTextBox.MaskFull &&
                DateTime.Parse(DriverLicDateTextBox.Text).Date > DateTime.Today.Date &&
                DateTime.Parse(DriverLicDateTextBox.Text).Date <= DateTime.Today.Date.AddYears(10)) 
            {
                ClientTextBox.Enabled = false;
                DriverLicDateTextBox.Enabled = false;
                PassportTextBox.Enabled = false;
                SaveButton.Visible = false;
            }
            else
                MessageBox.Show("Введены некорректные данные.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

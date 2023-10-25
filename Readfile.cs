using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Globalization;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.IO;
using System.Reflection;
using Microsoft.VisualBasic;
using System.Linq.Expressions;

namespace DublinAirport_Prototype
{
    public partial class Readfile : Form
    {
        private string filepath;
        _Application excelfile = new _excel.Application();
        Workbook workBook;
        Worksheet workSheet;

        //Datatypes
        private List<string> dataHeaders = new List<string>();
        private List<List<string>> excelData = new List<List<string>>();

        //Calculate||Make measures with the data
        List<string> calculatedHeaders = new List<string>();
        List<List<string>> calculatedDisplayData = new List<List<string>>();

        List<string> Date = new List<string>();
        List<string> CS = new List<string>();
        List<string> FT = new List<string>();
        List<string> Static = new List<string>();
        List<string> Totalrequireds = new List<string>();

        List<string> TotalHours = new List<string>();
        List<string> TotalDemand = new List<string>();
        List<string> FTE = new List<string>();
        List<string> HeadCount = new List<string>();

        //Download
        bool Hourly = true;
        bool Daily = false;
        bool Weekly = false;
        bool Monthly = false;

        int dateRange = 12;

        int rowCount = 0;
        int colCount = 0;



        public Readfile(string filepath)
        {
            InitializeComponent();
            this.filepath = filepath;

        }

        private void Readfile_Load(object sender, EventArgs e)
        {
            //Forms name
            String onlyFileName = System.IO.Path.GetFileName(filepath);
            this.Text = onlyFileName;

            //Excel or CSV file
            if (System.IO.Path.GetExtension(filepath) == ".xlsx")
            {
                try
                {
                    workBook = excelfile.Workbooks.Open(filepath);
                    workSheet = workBook.Worksheets[1];
                    Range usedRange = workSheet.UsedRange;

                    //Get the number of rows and columns
                    rowCount = usedRange.Rows.Count;
                    colCount = usedRange.Columns.Count;

                    //Read data
                    for (int col = 1; col <= colCount; col++)
                    {
                        string columnHeader = workSheet.Cells[1, col].Text; //Header
                        dataHeaders.Add(columnHeader);

                    }


                    //Array
                    string[] dataHeadersarray = dataHeaders.ToArray();

                    int indexTotalrequired = IndexOfArray("TotalRequired", dataHeadersarray);
                    if (indexTotalrequired != -1)
                    {
                        for (int row = 1; row < rowCount; row++)
                        {
                            //Get the value in each cell
                            Range celldate = usedRange.Cells[row + 1, 1];
                            string cellValuedate = celldate.Value != null ? celldate.Value.ToString() : string.Empty;
                            Date.Add(cellValuedate);

                            //Get the value in each cell
                            Range cellcs = usedRange.Cells[row + 1, 3]; //CS
                            string cellValuecs = cellcs.Value != null ? cellcs.Value.ToString() : string.Empty;
                            CS.Add(cellValuecs);

                            //Get the value in each cell
                            Range cellft = usedRange.Cells[row + 1, 4]; //FT
                            string cellValueft = cellft.Value != null ? cellft.Value.ToString() : string.Empty;
                            FT.Add(cellValueft);

                            //Static = Totalrequired - CS - FT
                            Range celltr = usedRange.Cells[row + 1, indexTotalrequired + 1]; //Totalrequired
                            double cellValue = Convert.ToDouble(celltr.Value) - Convert.ToDouble(cellcs.Value) - Convert.ToDouble(cellft.Value);
                            Static.Add(cellValue.ToString());

                            //Totalrequired
                            Totalrequireds.Add(celltr.Value.ToString());
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Couldnt load in the data", "Error");

                    //Close file
                    closeExcelFile();
                    this.Close();
                }
                finally
                {
                    //Close file
                    closeExcelFile();


                }
            }
            else if (System.IO.Path.GetExtension(filepath) == ".csv")
            {
                try{
                    string myValue = Interaction.InputBox("How are the cells seperated?", "Cell splits", ";");
                    char[] splittingChar = myValue.ToCharArray();

                    var reader = new StreamReader(filepath);
                    //var csv = reader.ReadToEnd();

                    //int colCount = Array.ConvertAll(reader.ReadLine().Split(';'), Double.Parse).Length;
                    rowCount = System.IO.File.ReadAllLines(filepath).Length;

                    string line;
                    bool skipFirstLine = true; // Skip the first line (header)

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (skipFirstLine)
                        {
                            //Header
                            string[] headervalues = line.Split(splittingChar[0]);
                            dataHeaders = headervalues.ToList();

                            skipFirstLine = false;
                            continue; //Skip the first line and continue to the next line
                        }

                        string[] values = line.Split(splittingChar[0]);

                        CS.Add(values[2]);
                        FT.Add(values[3]);
                        double staticValue = Convert.ToDouble(values[12]) - Convert.ToDouble(values[3]) - Convert.ToDouble(values[4]);
                        Static.Add(staticValue.ToString());
                        Totalrequireds.Add(values[12]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Couldnt load in the data", "Error");
                    this.Close();
                }



            }
            

            calculatedHeaders.Add("Hour");
            calculatedHeaders.Add("CS Hours");
            calculatedHeaders.Add("FT Hours");
            calculatedHeaders.Add("Static Hours");
            calculatedHeaders.Add("Totalrequired");

            calculatedHeaders.Add("Total Hours");
            calculatedHeaders.Add("Total Demand");
            calculatedHeaders.Add("FTE");
            calculatedHeaders.Add("HeadCount");

            Calculate();
            DisplayData();
        }

        public void Calculate()
        {
            //Calculations
            string[] dataHeadersarray = dataHeaders.ToArray();
            int indexTotalrequired = IndexOfArray("TotalRequired", dataHeadersarray);
            
            for (int i = 1; i < rowCount; i++)
            {
                //Total Demand = 1.44 * Totalrequired
                double Totalhours = Convert.ToDouble(Totalrequireds[i-1]) / 12;
                TotalHours.Add(Totalhours.ToString());
            
                double TotalDemand = Totalhours * 1.44;
                this.TotalDemand.Add(TotalDemand.ToString());
            
                //FTE = TotalDemand / 40
                double fte = TotalDemand / 40;
                FTE.Add(fte.ToString());
            
                //HeadCount = FTE * 1.15
                double Headcount = fte * 1.15;
                this.HeadCount.Add(Headcount.ToString());
            }

            string[] datearray = Date.ToArray();

            string[] csarray = CS.ToArray();
            string[] ftarray = FT.ToArray();
            string[] staticarray = Static.ToArray();
            string[] totalrequiredarray = Totalrequireds.ToArray();

            

            string[] totalhoursarray = TotalHours.ToArray();
            string[] totaldemandarray = TotalDemand.ToArray();
            string[] ftearray = FTE.ToArray();
            string[] headcountarray = HeadCount.ToArray();

            for (int i = 0; i < (rowCount-1)/dateRange; i++)
            {
                List<string> rowData = new List<string>(); //Creating a new list for each row

                try
                {
                    if (Hourly) 
                    {
                        rowData.Add((i + 1).ToString());

                        rowData.Add(Sumup(csarray, dateRange)[i]);
                        rowData.Add(Sumup(ftarray, dateRange)[i]);
                        rowData.Add(Sumup(staticarray, dateRange)[i]);
                        rowData.Add(Sumup(totalrequiredarray, dateRange)[i]);

                        rowData.Add(Sumup(totalhoursarray, dateRange)[i]);
                        rowData.Add(Sumup(totaldemandarray, dateRange)[i]);
                        rowData.Add(Sumup(ftearray, dateRange)[i]);
                        rowData.Add(Sumup(headcountarray, dateRange)[i]);

                        excelData.Add(rowData);
                    }
                    else if (Weekly)
                    {
                        rowData.Add((i + 1).ToString());

                        rowData.Add(Sumup(csarray, dateRange)[i]);
                        rowData.Add(Sumup(ftarray, dateRange)[i]);
                        rowData.Add(Sumup(staticarray, dateRange)[i]);
                        rowData.Add(Sumup(totalrequiredarray, dateRange)[i]);

                        rowData.Add(Sumup(totalhoursarray, dateRange)[i]);
                        rowData.Add(Sumup(totaldemandarray, dateRange)[i]);
                        rowData.Add(Sumup(ftearray, dateRange)[i]);
                        rowData.Add(Sumup(headcountarray, dateRange)[i]);

                        excelData.Add(rowData);
                    }
                    else if (Daily)
                    {
                        rowData.Add(datearray[i].Split('T')[0]);

                        rowData.Add(Sumup(csarray, dateRange)[i]);
                        rowData.Add(Sumup(ftarray, dateRange)[i]);
                        rowData.Add(Sumup(staticarray, dateRange)[i]);
                        rowData.Add(Sumup(totalrequiredarray, dateRange)[i]);

                        rowData.Add(Sumup(totalhoursarray, dateRange)[i]);
                        rowData.Add(Sumup(totaldemandarray, dateRange)[i]);
                        rowData.Add(Sumup(ftearray, dateRange)[i]);
                        rowData.Add(Sumup(headcountarray, dateRange)[i]);

                        excelData.Add(rowData);
                    }
                    else if (Monthly)
                    {
                        
                    }
                }
                catch(Exception ex)
                {
                    Error("Unable to convert data");
                }
            
            }

            

            calculatedDisplayData = excelData;
        }

        public void Error(string errormessage)
        {
            errorLabel.Text = $"Error: {errormessage}";
        }

        public void DisplayData()
        {
            //Clear
            previewTableDgv.Rows.Clear();
            previewTableDgv.Columns.Clear();
            previewTableDgv.Refresh();

            //Display new data
            string[] calculatedHeadersarray = calculatedHeaders.ToArray();
            if (Hourly)
            {
                calculatedHeadersarray[0] = "Hour";
            }
            else if (Daily)
            {
                calculatedHeadersarray[0] = "Date";
            }
            else if (Weekly)
            {
                calculatedHeadersarray[0] = "Week";
            }
            else if (Monthly)
            {

                calculatedHeadersarray[0] = "Month";
            }

            foreach (string header in calculatedHeadersarray)
            {
                previewTableDgv.Columns.Add(header, header);
            }
            foreach (var rowData in calculatedDisplayData)
            {
                previewTableDgv.Rows.Add(rowData.ToArray());
            }

            //Show rows
            int rowcount = previewTableDgv.Rows.Count -1;
            TotalrowsLabel.Text = $"Total rows: {rowcount}";

            
        }

        public string[] Sumup(string[] list, int sumin)
        {
            //List
            if(list.Length % 2 == 0) //Even number
            {
                if(((list.Length / sumin) % 1) == 0) //If it is no decimal
                {
                    List<string> Summedlist = new List<string>();
                    for (int j = 0; j < list.Length / sumin; j++)
                    {
                        //Variable
                        double summeddouble = 0;

                        //Sum
                        for (int i = 0; i < sumin; i++)
                        {
                            summeddouble += Convert.ToDouble(list[i + (sumin * j)]);
                        }
                        Summedlist.Add(Math.Round(summeddouble, 2).ToString());
                    }
                    string[] Summedarray = Summedlist.ToArray();
                    return Summedarray;
                }

                Error("This cant be displayed in this Timeperiod.");
                return null;
            }

            Error("The excelfile has an odd number of rows");
            return null;

        }



        public int IndexOfArray(string value, string[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if(value == array[i])
                {
                    return i;
                }
            }

            return -1;
        }

        //Save file 
        public void SaveFile()
        {
            SaveFileDialog v1 = new SaveFileDialog();
            v1.Filter = "Excel files(*.xlsx) | *.xlsx |CSV files(*.csv) | *.csv";
            v1.DefaultExt = "xlsx";

            if (v1.ShowDialog() == DialogResult.OK)
            {
                string path = v1.FileName;

                excelfile = new _excel.Application();
                workBook = excelfile.Workbooks.Add();
                workSheet = workBook.Worksheets[1];

                // Write your calculated data to the new Excel file
                for (int i = 0; i < calculatedHeaders.Count; i++)
                {
                    workSheet.Cells[1, i + 1] = calculatedHeaders[i];
                }
                for (int i = 1; i < calculatedDisplayData.Count; i++)
                {
                    
                    List<string> rowData = calculatedDisplayData[i];
                    for (int j = 0; j < rowData.Count; j++)
                    {
                        workSheet.Cells[i + 1, j + 1] = rowData[j];
                    }
                }

                //Save and close the new Excel file
                workBook.SaveAs(path);
                closeExcelFile();
            }
        }
        
        //Close old file
        public void closeExcelFile()
        {
            workBook.Close(false);
            excelfile.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workBook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelfile);

        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void radiobuttonPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HourlyRb_CheckedChanged(object sender, EventArgs e)
        {
            LoadingGif.Visible = true;

            Hourly = HourlyRb.Checked;
            Daily = DailyRb.Checked;
            Weekly = WeeklyRb.Checked;
            Monthly = monthlyRb.Checked;

            calculatedDisplayData.Clear();

            dateRange = 12;

            Calculate();
            DisplayData();

            LoadingGif.Visible = false;


        }

        private void DailyRb_CheckedChanged(object sender, EventArgs e)
        {
            LoadingGif.Visible = true;

            Hourly = HourlyRb.Checked;
            Daily = DailyRb.Checked;
            Weekly = WeeklyRb.Checked;
            Monthly = monthlyRb.Checked;

            calculatedDisplayData.Clear();

            dateRange = 12 * 24;

            LoadingGif.Visible = true;

            Calculate();
            DisplayData();

            LoadingGif.Visible = false;
        }

        private void WeeklyRb_CheckedChanged(object sender, EventArgs e)
        {
            LoadingGif.Visible = true;

            Hourly = HourlyRb.Checked;
            Daily = DailyRb.Checked;
            Weekly = WeeklyRb.Checked;
            Monthly = monthlyRb.Checked;

            calculatedDisplayData.Clear();

            dateRange = 12 * 24 * 7;

            Calculate();
            DisplayData();

            LoadingGif.Visible = false;
        }

        private void monthlyRb_CheckedChanged(object sender, EventArgs e)
        {
            LoadingGif.Visible = true;

            Hourly = HourlyRb.Checked;
            Daily = DailyRb.Checked;
            Weekly = WeeklyRb.Checked;
            Monthly = monthlyRb.Checked;

            calculatedDisplayData.Clear();

            dateRange = 12 * 24 * 7 * 30;


            Calculate();
            DisplayData();

            LoadingGif.Visible = false;


        }

        private void Readfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            //System.Windows.Forms.Application.Exit();
        }

        private void previewTableDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadingGif_Click(object sender, EventArgs e)
        {

        }
    }
}

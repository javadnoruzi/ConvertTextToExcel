using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace ConvertTxtToExcel
{
    public partial class Form1 : Form
    {
        public string FileName { get; set; }
        public Form1()
        {
            InitializeComponent();
            IntializeFormat();
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            try
            {
                string inputPath = txt_inputText.Text.Trim();
                string outputPath = txt_OutPutPath.Text.Trim();
                string spliter = txt_Spliter.Text.Trim();
                if (!string.IsNullOrEmpty(inputPath))
                {
                    string format = com_Formats.Text;
                    FileName = Path.GetFileName(inputPath);
                    switch (format)
                    {
                        case "Excel 97-2003":
                            ConvertToExcel97(inputPath, outputPath, spliter);
                            break;

                        default:

                            break;


                    }
                }
                else
                {
                    MessageBox.Show("Text is Empty!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void IntializeFormat()
        {
            try
            {
                com_Formats.Items.Add("Excel 97-2003");
                com_Formats.SelectedItem = "Excel 97-2003";
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error Add Format To ComboBox Error:{ex.Message}");
            }
        }
        public void ConvertToExcel97(string inputPath, string outputPath, string spliter)
        {

            try
            {
                // بررسی وجود فایل ورودی
                if (!File.Exists(inputPath))
                {
                    MessageBox.Show("فایل ورودی وجود ندارد!");
                    return;
                }

                // بررسی وجود پوشه مقصد و ساخت آن در صورت نیاز
                string directory = Path.GetDirectoryName(outputPath);
                FileName=Path.GetFileName(inputPath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                // ساخت Workbook و Sheet
                HSSFWorkbook workbook = new HSSFWorkbook();
                ISheet sheet = workbook.CreateSheet("Sheet1");

                var lines = File.ReadAllLines(inputPath);
                for (int i = 0; i < lines.Length; i++)
                {
                    var row = sheet.CreateRow(i);

                    // اگر اسپلیتر بیشتر از یک کاراکتر است، استفاده از StringSplitOptions.None
                    var cells = lines[i].Split(new string[] { spliter }, StringSplitOptions.None);

                    for (int j = 0; j < cells.Length; j++)
                    {
                        row.CreateCell(j).SetCellValue(cells[j]);
                    }
                }

                // ذخیره در فایل Excel
                using (var fs = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
                {
                    workbook.Write(fs);
                }

                MessageBox.Show("تبدیل با موفقیت انجام شد! ✅", "Excel Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (UnauthorizedAccessException uaEx)
            {
                MessageBox.Show($"دسترسی به مسیر مورد نظر وجود ندارد!\n\n{uaEx.Message}", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در تبدیل به فرمت Excel 97-2003:\n\n{ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_SelectFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "انتخاب فایل";
                    openFileDialog.Filter = "All Files (*.*)|*.*"; // می‌تونی فیلتر رو تغییر بدی مثلا فقط txt

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // مسیر کامل فایل انتخاب شده رو می‌ذاره توی TextBox
                        txt_inputText.Text = openFileDialog.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_SelectPath_Click(object sender, EventArgs e)
        {
            try
            {
                string inputPath = txt_inputText.Text.Trim();
                FileName = Path.GetFileName(inputPath).Split('.')[0];
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "مسیر ذخیره‌سازی فایل را انتخاب کنید";
                    saveFileDialog.Filter = "Excel 97-2003 (*.xls)|*.xls|All Files (*.*)|*.*";
                    saveFileDialog.DefaultExt = "xls";
                    saveFileDialog.FileName = $"{FileName}.xls"; // اسم پیش‌فرض فایل

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        txt_OutPutPath.Text = saveFileDialog.FileName;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

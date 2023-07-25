// Excel編集用ライブラリ => EPPlus
using OfficeOpenXml;

namespace practice
{
    public class ExcelController
    {  
        public void CreateExcelFile(string filePath)
        {
            var outFile = new FileInfo(filePath);
            using (var package = new ExcelPackage(outFile))
            {
                var workbook = package.Workbook;
                var worksheet = workbook.Worksheets["Sheet1"];

                // セルの結合
                worksheet.Cells["A1:B1"].Merge = true;
                worksheet.Cells["A1"].Value = "結合したセルです";
                worksheet.Cells["A2"].Value = "A2の値";

                // セルの値の取得と設定
                worksheet.Cells["B5"].Value = worksheet.Cells["A2"].Value;

                // セルのスタイル変更
                var cell = worksheet.Cells["A1"];
                cell.Style.Font.Bold = true;
                cell.Style.Font.Size = 12;

                // テキスト位置
                cell.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                cell.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;

                // スタイルを設定するための
                cell.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                cell.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Yellow);

                // 列の幅調整
                worksheet.Column(1).Width = 20;
                worksheet.Column(2).AutoFit();

                // 高さ指定
                worksheet.Row(1).Height = 50;

                // ファイルパスが既に存在する場合
                if (outFile.Exists)
                {
                    // Excelファイルを上書き保存
                    package.Save();
                }
            }
        }
    }
}

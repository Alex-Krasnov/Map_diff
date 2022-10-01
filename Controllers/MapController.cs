using Microsoft.AspNetCore.Mvc;
using Map_diff.Models;
using OfficeOpenXml;

namespace Map_diff.Controllers
{
    public class MapController : Controller
    {
        public IActionResult Index()
        {
            //@"D:\Map_data.xlsx";
            string way_to_file = @"D:\Map_data.xlsx";
            double[] amount = new double[60];
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage package = new ExcelPackage(new FileInfo(way_to_file));
            ExcelWorksheet worksheet = package.Workbook.Worksheets["1"];
            
            for (int i = 0; i <= 59; i++)
            {
                amount[i] = (double)worksheet.Cells[$"C{i + 2}"].Value;
            }
                
            
            List<District> district;
            district = new List<District>
            {
                new District(amount[0]),
                new District(amount[1]),
                new District(amount[2]),
                new District(amount[3]),
                new District(amount[4]),
                new District(amount[5]),
                new District(amount[6]),
                new District(amount[7]),
                new District(amount[8]),
                new District(amount[9]),
                new District(amount[10]),
                new District(amount[11]),
                new District(amount[12]),
                new District(amount[13]),
                new District(amount[14]),
                new District(amount[15]),
                new District(amount[16]),
                new District(amount[17]),
                new District(amount[18]),
                new District(amount[19]),
                new District(amount[20]),
                new District(amount[21]),
                new District(amount[22]),
                new District(amount[23]),
                new District(amount[24]),
                new District(amount[25]),
                new District(amount[26]),
                new District(amount[27]),
                new District(amount[28]),
                new District(amount[29]),
                new District(amount[30]),
                new District(amount[31]),
                new District(amount[32]),
                new District(amount[33]),
                new District(amount[34]),
                new District(amount[35]),
                new District(amount[36]),
                new District(amount[37]),
                new District(amount[38]),
                new District(amount[39]),
                new District(amount[40]),
                new District(amount[41]),
                new District(amount[42]),
                new District(amount[43]),
                new District(amount[44]),
                new District(amount[45]),
                new District(amount[46]),
                new District(amount[47]),
                new District(amount[48]),
                new District(amount[49]),
                new District(amount[50]),
                new District(amount[51]),
                new District(amount[52]),
                new District(amount[53]),
                new District(amount[54]),
                new District(amount[55]),
                new District(amount[56]),
                new District(amount[57]),
                new District(amount[58]),
                new District(amount[59])
            };

            double max = 0;
            for (int i=0; i < 60; i++)
            {
                if (district[i].District_count > max)
                {
                    max = district[i].District_count;
                }
            }

            for (int i = 0; i < 60; i++)
            {
                if (district[i].District_count != 0)
                {
                    double koef = district[i].District_count;// district[i].District_count / max

                    if (koef >= 0 && koef < 0.1)//koef >= 0 && koef < 0.1
                    {
                        district[i].District_r = 175;
                        district[i].District_g = 239;
                        district[i].District_b = 227;
                    }
                    else if (koef >= 0.1 && koef < 0.2)//koef >= 0.1 && koef < 0.2
                    {
                        district[i].District_r = 157;
                        district[i].District_g = 215;
                        district[i].District_b = 204;
                    }
                    else if (koef >= 0.2 && koef < 0.3)//koef >= 0.2 && koef < 0.3
                    {
                        district[i].District_r = 141;
                        district[i].District_g = 193;
                        district[i].District_b = 183;
                    }
                    else if (koef >= 0.3 && koef < 0.4)//koef >= 0.3 && koef < 0.4
                    {
                        district[i].District_r = 126;
                        district[i].District_g = 173;
                        district[i].District_b = 164;
                    }
                    else if (koef >= 0.4 && koef < 0.5)//koef >= 0.4 && koef < 0.5
                    {
                        district[i].District_r = 113;
                        district[i].District_g = 155;
                        district[i].District_b = 147;
                    }
                    else if (koef >= 0.5 && koef < 0.6)//koef >= 0.5 && koef < 0.6
                    {
                        district[i].District_r = 101;
                        district[i].District_g = 139;
                        district[i].District_b = 132;
                    }
                    else if (koef >= 0.6 && koef < 0.7)//koef >= 0.6 && koef < 0.7
                    {
                        district[i].District_r = 90;
                        district[i].District_g = 125;
                        district[i].District_b = 118;
                    }
                    else if (koef >= 0.7 && koef < 0.8)//koef >= 0.7 && koef < 0.8
                    {
                        district[i].District_r = 81;
                        district[i].District_g = 112;
                        district[i].District_b = 106;
                    }
                    else if (koef >= 0.8 && koef < 0.9)
                    {
                        district[i].District_r = 72;
                        district[i].District_g = 100;
                        district[i].District_b = 95;
                    }
                    else if (koef >= 0.9 && koef <= 1)
                    {
                        district[i].District_r = 64;
                        district[i].District_g = 90;
                        district[i].District_b = 85;
                    }
                }
                else
                {
                    district[i].District_r = 175;
                    district[i].District_g = 239;
                    district[i].District_b = 227;
                }
            }
            
            ViewData["Max_1"] = 50;//Math.Round(max * 0.1);
            ViewData["Max_2"] = 51;//Math.Round(max * 0.2);
            ViewData["Max_3"] = 100;//Math.Round(max * 0.3);
            ViewData["Max_4"] = 101;//Math.Round(max * 0.4);
            ViewData["Max_5"] = 300;//Math.Round(max * 0.5);
            ViewData["Max_6"] = 301;//Math.Round(max * 0.6);
            ViewData["Max_7"] = 500;//Math.Round(max * 0.7);
            ViewData["Max_8"] = 501;//Math.Round(max * 0.8);
            ViewData["Max_9"] = 1000;//Math.Round(max * 0.9);
            ViewData["Max_10"] = 1001;//Math.Round(max);

            ViewData["Max_11"] = 1500;
            ViewData["Max_12"] = 1501;
            ViewData["Max_13"] = 2000;
            ViewData["Max_14"] = 2001;
            ViewData["Max_15"] = 2500;
            return View(district);
        }

    }
}
using System;
using System.IO;
using LectorExcel.Models;
using OfficeOpenXml;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            Console.Write("Ingresar la ruta del archivo Excel: ");
            string filePath = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("El archivo no existe.");
            }
            else
            {
                ProcesarArchivoExcel(filePath);
            }

            Console.Write("¿Deseas procesar otro archivo Excel? (Si:teclea 'y' ---- No:teclea 'n'): ");
        } while (Console.ReadLine().Trim().Equals("y", StringComparison.OrdinalIgnoreCase));
    }

    static void ProcesarArchivoExcel(string filePath)
    {
        using (var package = new ExcelPackage(new FileInfo(filePath)))
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // Para uso no comercial
            // Selecciona la primera hoja del archivo
            var worksheet = package.Workbook.Worksheets[0];

            // Obtén los títulos de la primera fila
            var firstRow = worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column]
                .Select(cell => cell.Text);

            Console.WriteLine("Nombre de la columnas definidas en el excel.");
            // Imprime los títulos
            int count = 1;
            foreach (var title in firstRow)
            {
                Console.WriteLine($"{title} ----------------------------------------------------- {count}");
                count++;
            }

            #region Variables

            Console.WriteLine("\n\nIngresa el numero de la columna para el AGE: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el numero de la columna para el GENDER: ");
            int gender = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el numero de la columna para la APE PAT: ");
            int ape_pat = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el numero de la columna para la APE MAT: ");
            int ape_mat = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el numero de la columna para la APES: ");
            int apes = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el numero de la columna para la NOM: ");
            int nom = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el numero de la columna para la APE COM: ");
            int nom_com = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el numero de la columna para la DIR: ");
            int dir = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el numero de la columna para la CP: ");
            int cp = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el numero de la columna para la COL: ");
            int col = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el numero de la columna para la MPO: ");
            int mpo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el numero de la columna para la CDA: ");
            int cda = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el numero de la columna para la EDO: ");
            int edo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el numero de la columna para la CVE: ");
            int cve = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el numero de la columna para la EMAIL: ");
            int email = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el numero de la columna para la RFC: ");
            int rfc = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el numero de la columna para la CURP: ");
            int curp = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el numero de la columna para la TDCB: ");
            int tdcb = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el numero de la columna para la CTA: ");
            int cta = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el numero de la columna para la TEL 1: ");
            int tel_uno = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el numero de la columna para la TEL 2: ");
            int tel_dos = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el numero de la columna para la TEL 3: ");
            int tel_tres = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el numero de la columna para la TEL 4: ");
            int tel_cuatro = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el numero de la columna para la TEL 5: ");
            int tel_cinco = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el numero de la columna para la PDTO: ");
            int pdto = int.Parse(Console.ReadLine());


            Console.WriteLine("Ingresa el nombre de la TABLA: ");
            string table = Console.ReadLine();

            #endregion


            try
            {
                using (var context = new PruebamtosContext())
                {
                    int rowCount = worksheet.Dimension.Rows;
                    //Guid idMob;
                    for (int row = 2; row <= rowCount; row++) // Comienza desde la segunda fila (asumiendo que la primera fila contiene encabezados)
                    {

                        #region ROWS
                        // Accede a los valores de cada celda en la fila
                        var age_row = age == 0 ? "" : worksheet.Cells[row, age].Text;
                        var gender_row = gender == 0 ? "" : worksheet.Cells[row, gender].Text;
                        var ape_pat_row = ape_pat == 0 ? "" : worksheet.Cells[row, ape_pat].Text;
                        var ape_mat_row = ape_mat == 0 ? "" : worksheet.Cells[row, ape_mat].Text;
                        var apes_row = apes == 0 ? "" : worksheet.Cells[row, apes].Text;
                        var nom_row = nom == 0 ? "" : worksheet.Cells[row, nom].Text;
                        var nom_com_row = nom_com == 0 ? "" : worksheet.Cells[row, nom_com].Text;
                        var dir_row = dir == 0 ? "" : worksheet.Cells[row, dir].Text;
                        var cp_row = cp == 0 ? "" : worksheet.Cells[row, cp].Text;
                        var col_row = col == 0 ? "" : worksheet.Cells[row, col].Text;
                        var mpo_row = mpo == 0 ? "" : worksheet.Cells[row, mpo].Text;
                        var cda_row = cda == 0 ? "" : worksheet.Cells[row, cda].Text;
                        var edo_row = edo == 0 ? "" : worksheet.Cells[row, edo].Text;
                        var cve_row = cve == 0 ? "" : worksheet.Cells[row, cve].Text;
                        var email_row = email == 0 ? "" : worksheet.Cells[row, email].Text;
                        var rfc_row = rfc == 0 ? "" : worksheet.Cells[row, rfc].Text;
                        var curp_row = curp == 0 ? "" : worksheet.Cells[row, curp].Text;
                        var tdcb_row = tdcb == 0 ? "" : worksheet.Cells[row, tdcb].Text;
                        var cta_row = cta == 0 ? "" : worksheet.Cells[row, cta].Text;
                        var tel_uno_row = tel_uno == 0 ? "" : worksheet.Cells[row, tel_uno].Text;
                        var tel_dos_row = tel_dos == 0 ? "" : worksheet.Cells[row, tel_dos].Text;
                        var tel_tres_row = tel_tres == 0 ? "" : worksheet.Cells[row, tel_tres].Text;
                        var tel_cuatro_row = tel_cuatro == 0 ? "" : worksheet.Cells[row, tel_cuatro].Text;
                        var tel_cinco_row = tel_cinco == 0 ? "" : worksheet.Cells[row, tel_cinco].Text;
                        var pdto_row = pdto == 0 ? "" : worksheet.Cells[row, pdto].Text;
                        //idMob = Guid.NewGuid();
                        #endregion

                        #region RESULTADO
                        //Console.WriteLine(row - 1);
                        //// Procesa los valores como desees
                        //Console.WriteLine($"ID: {idMob}");
                        Console.WriteLine($"AGE: {age_row}");
                        Console.WriteLine($"GENDER: {gender_row}");
                        Console.WriteLine($"APE PAT: {ape_pat_row}");
                        Console.WriteLine($"APE MAT: {ape_mat_row}");
                        Console.WriteLine($"APES: {apes_row}");
                        Console.WriteLine($"NOM: {nom_row}");
                        Console.WriteLine($"NOM COM: {nom_com_row}");
                        Console.WriteLine($"DIR: {dir_row}");
                        Console.WriteLine($"CP: {cp_row}");
                        Console.WriteLine($"COL: {col_row}");
                        Console.WriteLine($"MPO: {mpo_row}");
                        Console.WriteLine($"CDA: {cda_row}");
                        Console.WriteLine($"EDO: {edo_row}");
                        Console.WriteLine($"CVE: {cve_row}");
                        Console.WriteLine($"EMAIL: {email_row}");
                        Console.WriteLine($"RFC: {rfc_row}");
                        Console.WriteLine($"CURP: {curp_row}");
                        Console.WriteLine($"TDCB: {tdcb_row}");
                        Console.WriteLine($"CTA: {cta_row}");
                        Console.WriteLine($"TEL 1: {tel_uno_row}");
                        Console.WriteLine($"TEL 2: {tel_dos_row}");
                        Console.WriteLine($"TEL 3: {tel_tres_row}");
                        Console.WriteLine($"TEL 4: {tel_cuatro_row}");
                        Console.WriteLine($"TEL 5: {tel_cinco_row}");
                        Console.WriteLine($"PDTO: {pdto_row}");
                        Console.WriteLine($"TABLA: {table}");
                        Console.WriteLine($"{row} \n");
                        #endregion


                        var mobs = new Mob
                        {
                            Id = Guid.NewGuid().ToString(),
                            Age = age_row,
                            Gender = gender_row,
                            ApePat = ape_pat_row,
                            ApeMat = ape_mat_row,
                            Apes = apes_row,
                            Nom = nom_row,
                            NomCom = nom_com_row,
                            Dir = dir_row,
                            Cp = cp_row,
                            Col = col_row,
                            Mpo = mpo_row,
                            Cda = cda_row,
                            Edo = edo_row,
                            Cve = cve_row,
                            Email = email_row,
                            Rfc = rfc_row,
                            Curp = curp_row,
                            Tdcb = tdcb_row,
                            Cta = cta_row,
                            Tel1 = tel_uno_row,
                            Tel2 = tel_dos_row,
                            Tel3 = tel_tres_row,
                            Tel4 = tel_cuatro_row,
                            Tel5 = tel_cinco_row,
                            Pdto = pdto_row,
                            Tabla = table,
                        };
                        context.Mobs.Add(mobs);
                    }

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
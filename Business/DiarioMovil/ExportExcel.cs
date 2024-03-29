using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.DTOs;
using Business.Utils;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using Persistance;




namespace Business.DiarioMovil
{
  public class ExportExcel
  {
    public class Execute : IRequest<object>
    {
      public long[] Ids { get; set; }

    }

    public class Handler : IRequestHandler<Execute, object>
    {
      private readonly FormularioContext context;

      public Handler(FormularioContext context)
      {
        this.context = context;
      }

      public async Task<object> Handle(Execute request, CancellationToken cancellationToken)
      {
        List<FormularioDiarioMovilDTO> formularios = null;
        if (request.Ids != null && request.Ids.Length > 0)
        {
          formularios = await this.context.FormularioDiarioMovil
          .Where(f => request.Ids.Contains(f.Id))
          .Select(f => Helpers.toFormularioDiarioMovilDTO(f))
          .ToListAsync();
        }
        else
        {
          formularios = await this.context.FormularioDiarioMovil
          .Select(f => Helpers.toFormularioDiarioMovilDTO(f))
          .ToListAsync();
        }
        DataTable table = Helpers.ToDataTable(formularios);

        var path = "./temp/file.xlsx";
        if (File.Exists(path))
        {
          File.Delete(path);
        }
        var myFile = File.Create(path);
        myFile.Close();

        FileInfo filePath = new FileInfo(path);
        var excelPack = new ExcelPackage(path);
        var workSheets = excelPack.Workbook.Worksheets.Add("Formulario-Diario-Movil");
        workSheets.Cells.LoadFromDataTable(table, true, OfficeOpenXml.Table.TableStyles.Light8);
        excelPack.Save();

        Byte[] bytes = File.ReadAllBytes(path);
        String file = Convert.ToBase64String(bytes);
        return new { file };
      }


    }

  }
}
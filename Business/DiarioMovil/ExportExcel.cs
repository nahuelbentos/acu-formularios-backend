using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using Newtonsoft.Json;
using OfficeOpenXml;
using Persistance;



namespace Business.DiarioMovil
{
  public static class ExportExcel
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
          formularios = await this.context.FormularioDiarioMovil.Where(f => request.Ids.Contains(f.Id)).Select(f => new FormularioDiarioMovilDTO
          {
            Id = f.Id,
            Fecha = f.FechaCreacion,
            FechaString = f.FechaCreacion.ToShortDateString(),
            Instructor = f.EscInsId,
            Kilometraje = f.MovilKilometraje,
            Movil = f.MovCod,
            Observaciones = f.Observaciones
          }).ToListAsync();
        }
        else
        {
          formularios = await this.context.FormularioDiarioMovil.Select(f => new FormularioDiarioMovilDTO
          {
            Id = f.Id,
            Fecha = f.FechaCreacion,
            FechaString = f.FechaCreacion.ToShortDateString(),
            Instructor = f.EscInsId,
            Kilometraje = f.MovilKilometraje,
            Movil = f.MovCod,
            Observaciones = f.Observaciones
          }).ToListAsync();
        }
        DataTable table = ToDataTable(formularios);

        var path = "./temp/file.xlsx";
        if (File.Exists(path))
        {
          File.Delete(path);
        }
        File.Create(path);

        FileInfo filePath = new FileInfo(path);
        var excelPack = new ExcelPackage(path);
        var workSheets = excelPack.Workbook.Worksheets.Add("Test");
        workSheets.Cells.LoadFromDataTable(table, true, OfficeOpenXml.Table.TableStyles.Light8);
        excelPack.Save();

        Byte[] bytes = File.ReadAllBytes(path);
        String file = Convert.ToBase64String(bytes);
        return new { file };
      }


    }



    public static DataTable ToDataTable<T>(this IList<T> data)
    {
      PropertyDescriptorCollection props =
      TypeDescriptor.GetProperties(typeof(T));
      DataTable table = new DataTable();
      for (int i = 0; i < props.Count; i++)
      {
        PropertyDescriptor prop = props[i];
        table.Columns.Add(prop.Name, prop.PropertyType);
      }
      object[] values = new object[props.Count];
      foreach (T item in data)
      {
        for (int i = 0; i < values.Length; i++)
        {
          values[i] = props[i].GetValue(item);
        }
        table.Rows.Add(values);
      }
      return table;
    }
  }
}
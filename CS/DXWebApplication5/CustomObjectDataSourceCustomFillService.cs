using DevExpress.DashboardCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DXWebApplication5 {
    public class CustomObjectDataSourceCustomFillService : IObjectDataSourceCustomFillService {
        public object GetData(DashboardObjectDataSource dataSource, ObjectDataSourceFillParameters fillParameters) {
            if (fillParameters.DataFields == null || fillParameters.DataFields.Length == 0) {
                return null;
            }

            List<SalesPersonData> data = DataGenerator.Data;

            DataTable table = new DataTable();
            foreach (string field in fillParameters.DataFields) {
                table.Columns.Add(field);
            }

            int NumberOfRecordsToRetrieveParameter = (int)(fillParameters.Parameters.FirstOrDefault(i => i.Name == "NumberOfRecords")?.Value);
            int NumberOfRecordsToRetrieve = NumberOfRecordsToRetrieveParameter <= data.Count ? NumberOfRecordsToRetrieveParameter : data.Count;

            for (int i = 0; i < NumberOfRecordsToRetrieve; i++) {
                object[] row = new object[fillParameters.DataFields.Length];
                for (int j = 0; j < fillParameters.DataFields.Length; j++) {
                    row[j] = GetPropertyValue(data[i], fillParameters.DataFields[j]);
                }
                table.Rows.Add(row);
            }
            return table.DefaultView;
        }
        object GetPropertyValue(SalesPersonData obj, string propName) {
            return propName == "SalesPerson" ? (object)obj.SalesPerson : (object)obj.Quantity;
        }
    }
}
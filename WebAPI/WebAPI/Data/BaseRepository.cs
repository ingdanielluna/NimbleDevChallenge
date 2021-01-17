using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WebAPI.Services;

namespace WebAPI.Data
{
    public class BaseRepository<TModel> where TModel : class, ITeaElementBase, new()
    {
        private string databaseName;

        protected DataAccessService dataAccessService; 

        private string tableName { get; set; }

        public BaseRepository(DataAccessService dataAccessService)
        {
            this.dataAccessService = dataAccessService;
        }

        public IEnumerable<TModel> GetAll()
        {
            List<TModel> TModels = new List<TModel>();
            SqlCommand command = DataAccessService.SelectAllCommand(tableName);

            using (SqlDataReader reader = dataAccessService.GetSqlReader(command))
            {
                while (reader.Read())
                {
                    TModels.Add(ModelFromReader(reader, true));
                }

                //CleanUp(reader, command);
            }

            return TModels;
        }

        public TModel ModelFromReader(SqlDataReader row, bool leaveReaderOpen = false)
        {
            if (row != null)
            {
                TModel teaElement = new TModel()
                {
                    Id = (Guid)row[nameof(ITeaElementBase.Id)],
                    Name = (string)row[nameof(ITeaElementBase.Name)],
                    Price = (string)row[nameof(ITeaElementBase.Price)],
                    CreateDate = (DateTime)row[nameof(ITeaElementBase.CreateDate)],
                    UpdateDate = (DateTime)row[nameof(ITeaElementBase.UpdateDate)],
                };

                if (!leaveReaderOpen)
                {
                    row.Close();
                }

                return teaElement;
            }

            return null;
        }

    }
}

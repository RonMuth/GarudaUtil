﻿using Garuda.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarudaUtil.MetaData
{
    class GarudaPhoenixTable
    {
        const string SqlColumnMetaData = "SELECT COLUMN_NAME, COLUMN_FAMILY, COLUMN_SIZE, COLUMN_DEF, ARRAY_SIZE, BUFFER_LENGTH, DATA_TYPE, IS_AUTOINCREMENT, IS_NULLABLE, NULLABLE, STORE_NULLS, IS_ROW_TIMESTAMP, ORDINAL_POSITION, PK_NAME, SQL_DATA_TYPE, SOURCE_DATA_TYPE  FROM SYSTEM.CATALOG WHERE COLUMN_NAME IS NOT NULL AND TABLE_NAME = :1";
        public DataRow Row { get; }

        private DataTable _columns = null;

        public GarudaPhoenixTable(DataRow row)
        {
            this.Row = row;
        }

        public DataTable GetColumns(PhoenixConnection c, bool refresh)
        {
            if(null == this._columns || refresh)
            {
                _columns = new DataTable("Phoenix Columns");
                using (IDbCommand cmd = c.CreateCommand())
                {
                    cmd.CommandText = SqlColumnMetaData;
                    cmd.Parameters.Add(new PhoenixParameter(Row["TABLE_NAME"]));
                    cmd.Prepare();
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        _columns.BeginLoadData();
                        _columns.Load(dr);
                        _columns.EndLoadData();
                    }
                }
            }

            return _columns;
        }
    }
}
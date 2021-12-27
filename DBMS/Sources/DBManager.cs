using System.Collections.Generic;
using System.Linq;

namespace DBMS.src
{
    public class DBManager
    {
        private Database chosenDatabase;
        private FileSystemManager fsManager;
        private readonly string path = "C:/Projects/SYBD/";
        public DBManager()
        {
            fsManager = new FileSystemManager();
            fsManager.CreateDirectory(path);
        }

        public bool CreateDatabase(string databaseName)
        {
            if (databaseName.Trim().Equals(""))
            {
                return false;
            }
            chosenDatabase = new Database(databaseName);
            return true;
        }

        public bool AddTable(string newTableName)
        {
            if (chosenDatabase == null)
            {
                return false;
            }
            return chosenDatabase.AddTable(newTableName);
        }

        public bool AddTable(Table newTable)
        {
            if (chosenDatabase == null)
            {
                return false;
            }
            return chosenDatabase.AddTable(newTable);
        }


        public Table? GetTable(int index)
        {
           return chosenDatabase.GetTable(index);
        }

        public bool AddColumn(int tableIndex, string columnName, string customTypeName)
        {
            if (chosenDatabase == null)
            {
                return false;
            }
            return chosenDatabase.AddColumn(tableIndex, columnName, customTypeName);
        }

        public bool AddRow(int tableIndex)
        {
            if (chosenDatabase == null)
            {
                return false;
            }
            return chosenDatabase.AddRowToTable(tableIndex);
        }

        public bool ChangeValue(string newValue, int tableIndex, int columnIndex, int rowIndex)
        {
            return chosenDatabase.ChangeValue(newValue, tableIndex, columnIndex, rowIndex);
        }

        public bool DeleteRow(int tableIndex, int rowIndex)
        {
            return chosenDatabase.DeleteRow(tableIndex, rowIndex);
        }

        public bool DeleteColumn(int tableIndex, int columnIndex)
        {
            return chosenDatabase.DeleteColumn(tableIndex, columnIndex);
        }

        public bool DeleteTable(int tableIndex)
        {
           return chosenDatabase.DeleteTable(tableIndex);
        }

        public bool SaveCurrentDatabase()
        {
            return fsManager.SaveDatabaseOnDrive(path, chosenDatabase);
        }

        public bool LoadDatabase(string databaseName)
        {
            if(databaseName != string.Empty && fsManager.isDatabaseExist(path, databaseName))
            {
                chosenDatabase = fsManager.LoadDatabaseFromDrive(path, databaseName);
                return chosenDatabase != null;
            }

            return false;
        }

        public List<string> GetTablesNameList()
        {
            return chosenDatabase.GetTablesNamesList();
        }

        public Table TableProjection(Table table)
        {
            List<Row> rows = new List<Row>();

            for (int i = 0; i < table.rowsList.Count ; ++i)
            {
                bool flag = false;
                for (int j = i + 1; j < table.rowsList.Count; ++j)
				{
                    if (table.rowsList[i].Equals(table.rowsList[j])) {
                        flag = true;
                        break;
					}
                }
                if (!flag)
				{
                    rows.Add(table.rowsList.ElementAt(i));
				}
            }
            var resultTable = new Table($"ProjectionOf{table.GetName()}", table.Columns(), rows);
            return resultTable;
        }

        public Table? TableProjection(Table table, string columnName)
        {
            int columnInndex = -1;
            for (int i = 0; i < table.columnsList.Count; ++i)
			{
                if (table.columnsList[i].GetName() == columnName)
                    columnInndex = i;
			}
            if (columnInndex == -1)
			{
                return null;
			}


            List<Row> rows = new List<Row>();

            for (int i = 0; i < table.rowsList.Count; ++i)
            {
                bool flag = false;
                for (int j = i + 1; j < table.rowsList.Count; ++j)
                {
                    if (table.rowsList[i].valuesList[columnInndex].Equals(table.rowsList[j].valuesList[columnInndex]))
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    rows.Add(table.rowsList.ElementAt(i));
                }
            }
            var resultTable = new Table($"ProjectionOf{table.GetName()}", table.Columns(), rows);
            return resultTable;
        }
    }
}

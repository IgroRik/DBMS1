using System.IO;
using Xunit;
using DBMS.src;

using System.Collections.Generic;

namespace DBMSUnitTests
{
    public class UnitTest1
    {
        private readonly string path = "C:/Projects/SYBD/";
        private readonly string dbFilesExtension = "dbs";

        [Fact]
        public void SaveAndLoadDatabaseFromFS()
        {
            string databaseName = "testDB";
            var databaseManager = new DBManager();
            Assert.True(databaseManager.CreateDatabase(databaseName));
            Assert.True(databaseManager.SaveCurrentDatabase());
            Assert.True(Directory.Exists(path));
            Assert.True(File.Exists($"{path}{databaseName}.{dbFilesExtension}"));
            Assert.True(databaseManager.LoadDatabase(databaseName));



        }

        [Fact]
        public void TableProjectionAll()
        {
            var dbManager = new DBManager();
            var firstColumn = new Column("Name", "String");
            var secondColumn = new Column("TimeSpent", "Time");
            var thirdColumn = new Column("Interval", "TimeInvl");
            var columns = new List<Column>() { firstColumn, secondColumn, thirdColumn };
            var firstTableFirstRow = new Row { valuesList = { "Ivan", "1:20:00", "13:30:34-14:50:34" } };
            var firstTableSecondRow = new Row { valuesList = { "Ivan", "1:20:00", "13:30:34-14:50:34" } };
            var firstTabvarhirdRow = new Row { valuesList = { "Semen", "0:50:00", "12:03:24-12:53:24" } };
            var firstTableFourthRow = new Row { valuesList = { "Sofia", "0:20:30", "23:59:43-00:20:13" } };

            var firstTable = new Table { name = "first", rowsList = { firstTableFirstRow, firstTableSecondRow, firstTabvarhirdRow, firstTableFourthRow }, columnsList = columns };

            var expected = new Table { name = $"ProjectionOf{firstTable.GetName()}", rowsList = { firstTableSecondRow, firstTabvarhirdRow, firstTableFourthRow }, columnsList = columns };
            var actual = dbManager.TableProjection(firstTable);
            Assert.True(expected.Equals(actual));
        }

        [Fact]
        public void TableProjectionName()
        {
            var dbManager = new DBManager();
            var firstColumn = new Column("Name", "String");
            var secondColumn = new Column("TimeSpent", "Time");
            var thirdColumn = new Column("Interval", "TimeInvl");
            var columns = new List<Column>() { firstColumn, secondColumn, thirdColumn };
            var firstTableFirstRow = new Row { valuesList = { "Ivan", "1:20:00", "13:30:34-14:50:34" } };
            var firstTableSecondRow = new Row { valuesList = { "Ivan", "1:20:00", "13:30:34-14:50:34" } };
            var firstTabvarhirdRow = new Row { valuesList = { "Semen", "0:50:00", "12:03:24-12:53:24" } };
            var firstTableFourthRow = new Row { valuesList = { "Sofia", "0:20:30", "23:59:43-00:20:13" } };

            var firstTable = new Table { name = "first", rowsList = { firstTableFirstRow, firstTableSecondRow, firstTabvarhirdRow, firstTableFourthRow }, columnsList = columns };

            var expected = new Table { name = $"ProjectionOf{firstTable.GetName()}", rowsList = { firstTableSecondRow, firstTabvarhirdRow, firstTableFourthRow }, columnsList = columns };
            var actual = dbManager.TableProjection(firstTable, "Name");
            Assert.True(expected.Equals(actual));
        }

        [Fact]
        public void TableProjectionTimeSpent()
        {
            var dbManager = new DBManager();
            var firstColumn = new Column("Name", "String");
            var secondColumn = new Column("TimeSpent", "Time");
            var thirdColumn = new Column("Interval", "TimeInvl");
            var columns = new List<Column>() { firstColumn, secondColumn, thirdColumn };
            var firstTableFirstRow = new Row { valuesList = { "Ivan", "1:20:00", "13:30:34-14:50:34" } };
            var firstTableSecondRow = new Row { valuesList = { "Ivan", "1:20:00", "13:30:34-14:50:34" } };
            var firstTabvarhirdRow = new Row { valuesList = { "Semen", "0:50:00", "12:03:24-12:53:24" } };
            var firstTableFourthRow = new Row { valuesList = { "Sofia", "0:50:00", "23:59:43-00:20:13" } };

            var firstTable = new Table { name = "first", rowsList = { firstTableFirstRow, firstTableSecondRow, firstTabvarhirdRow, firstTableFourthRow }, columnsList = columns };

            var expected = new Table { name = $"ProjectionOf{firstTable.GetName()}", rowsList = { firstTableSecondRow, firstTableFourthRow }, columnsList = columns };
            var actual = dbManager.TableProjection(firstTable, "TimeSpent");
            Assert.True(expected.Equals(actual));
        }


        [Fact]
        public void TestCustomTimeTypeValidation_Valid()
        {
            var value = "12:30:56";
            Assert.True(TypesValidator.IsValidValue("Time", value));
        }

        [Fact]
        public void TestCustomTimeTypeValidation_Invalid()
        {
            var value = "12:30";
            Assert.False(TypesValidator.IsValidValue("Time", value));
        }

        [Fact]
        public void TestCustomTimeTypeValidation_Invalid2()
        {
            var value = "-12:30:23";
            Assert.False(TypesValidator.IsValidValue("Time", value));
        }

        [Fact]
        public void TestCustomTimeInvlTypeValidation_Valid()
        {
            var value = "12:30:34-14:43:34";
            Assert.True(TypesValidator.IsValidValue("TimeInvl", value));
        }

        [Fact]
        public void TestCustomTimeInvlTypeValidation_Invalid()
        {
            var value = "12:30:34; 14:43:34";
            Assert.False(TypesValidator.IsValidValue("TimeInvl", value));
        }

        [Fact]
        public void TestCustomTimeInvlTypeValidation_Invalid2()
        {
            var value = "12:30:34-14:43";
            Assert.False(TypesValidator.IsValidValue("TimeInvl", value));
        }
    }
}
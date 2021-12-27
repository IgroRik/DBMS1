using DBMS.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS
{
    public partial class Form1 : Form
    {
        DBManager databaseManager = new DBManager();
        string currentFilePath = "";
        string cellOldValue = "";
        string cellNewValue = "";
        public Form1()
        {
            InitializeComponent();
            comboBoxColumnsTypes.SelectedIndex = 0;
        }


        private void ShowTable(Table table)
        {
            try
            {
                dataGridView.Rows.Clear();
                dataGridView.Columns.Clear();

                foreach (Column column in table.Columns())
                {
                    DataGridViewColumn dataGridColumn;
                    dataGridColumn = new DataGridViewTextBoxColumn();
                    dataGridColumn.Name = column.GetName();
                    dataGridColumn.HeaderText = column.GetName();
                    dataGridView.Columns.Add(dataGridColumn);
                }

                foreach (Row row in table.Rows())
                {
                    DataGridViewRow dataGridRow = new DataGridViewRow();
                    for (int i = 0; i < row.GetValuesList().Count; ++i)
                    {
                        DataGridViewCell cell;
                        var stringCellValue = row.GetValuesList()[i];

                        cell = new DataGridViewTextBoxCell();
                        cell.Value = stringCellValue;

                        dataGridRow.Cells.Add(cell);
                    }
                    try
                    {
                        dataGridView.Rows.Add(dataGridRow);
                    }
                    catch { }
                }
            }
            catch { }
        }

        private void dataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int selectedTableIndex = tablesControl.SelectedIndex;
            if (selectedTableIndex == -1)
            {
                return;
            }
            var table = databaseManager.GetTable(selectedTableIndex);

            var currentCellValue = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            cellOldValue = currentCellValue == null ? String.Empty : currentCellValue.ToString();
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var cellValue = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            if (cellValue == null)
            {
                return;
            }
            cellNewValue = cellValue.ToString();
            if (!databaseManager.ChangeValue(cellNewValue, tablesControl.SelectedIndex, e.ColumnIndex, e.RowIndex))
            {
                dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cellOldValue;
                return;
            }
            int selectedTableIndex = tablesControl.SelectedIndex;
            if (selectedTableIndex == -1)
            {
                return;
            }
            ShowTable(databaseManager.GetTable(selectedTableIndex));
        }

        private void tablesControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tablesIndex = tablesControl.SelectedIndex;
            if (tablesIndex != -1)
            {
                ShowTable(databaseManager.GetTable(tablesIndex));
            }
        }

        private void openDatabaseDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialogChooseFilePath_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            databaseManager.SaveCurrentDatabase();
        }

        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (currentFilePath != String.Empty)
                {
                    DialogResult dialogResult = MessageBox.Show("Save changings?", "Attention!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        databaseManager.SaveCurrentDatabase();
                    }
                }
                if (databaseManager.CreateDatabase(toolStripTextBox1.Text))
                {
                    currentFilePath = "";
                    tablesControl.TabPages.Clear();
                    dataGridView.Rows.Clear();
                    dataGridView.Columns.Clear();
                }
            }
        }

        private void toolStripTextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (currentFilePath != String.Empty)
                {
                    DialogResult dialogResult = MessageBox.Show("Save changings?", "Attention!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        databaseManager.SaveCurrentDatabase();
                    }
                }
                var databaseName = toolStripTextBox2.Text;
                if (!databaseManager.LoadDatabase(databaseName))
                {
                    return;
                }
                currentFilePath = databaseName;
                tablesControl.TabPages.Clear();
                List<string> tablesNames = databaseManager.GetTablesNameList();
                foreach (string tableName in tablesNames)
                {
                    tablesControl.TabPages.Add(tableName);
                }
                int selectedTableIndex = tablesControl.SelectedIndex;
                if (selectedTableIndex != -1)
                {
                    ShowTable(databaseManager.GetTable(selectedTableIndex));
                }
            }
        }

        private void toolStripTextBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (databaseManager.AddTable(toolStripTextBox3.Text))
                {
                    tablesControl.TabPages.Add(toolStripTextBox3.Text);
                }
            }
        }

        private void toolStripTextBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (databaseManager.AddColumn(tablesControl.SelectedIndex, toolStripTextBox4.Text, toolStripComboBox1.Text))
                {
                    int tableIndex = tablesControl.SelectedIndex;
                    if (tableIndex != -1)
                    {
                        ShowTable(databaseManager.GetTable(tableIndex));
                    }
                }
            }
        }

        private void rowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablesControl.TabCount == 0)
            {
                return;
            }
            try
            {
                databaseManager.DeleteTable(tablesControl.SelectedIndex);
                tablesControl.TabPages.RemoveAt(tablesControl.SelectedIndex);
            }
            catch { }
            if (tablesControl.TabCount == 0)
            {
                return;
            }

            int tableIndex = tablesControl.SelectedIndex;
            if (tableIndex != -1)
            {
                ShowTable(databaseManager.GetTable(tableIndex));
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.Columns.Count == 0) return;
            try
            {
                databaseManager.DeleteColumn(tablesControl.SelectedIndex, dataGridView.CurrentCell.ColumnIndex);
            }
            catch { }

            int tableIndex = tablesControl.SelectedIndex;
            if (tableIndex != -1)
            {
                ShowTable(databaseManager.GetTable(tableIndex));
            }
        }

        private void createToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (databaseManager.AddRow(tablesControl.SelectedIndex))
            {
                int tableIndex = tablesControl.SelectedIndex;
                if (tableIndex != -1)
                {
                    ShowTable(databaseManager.GetTable(tableIndex));
                }
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0)
            {
                return;
            }
            try
            {
                databaseManager.DeleteRow(tablesControl.SelectedIndex, dataGridView.CurrentCell.RowIndex);
            }
            catch { }

            int tableIndex = tablesControl.SelectedIndex;
            if (tableIndex != -1)
            {
                ShowTable(databaseManager.GetTable(tableIndex));
            }
        }

        private void createToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Table table = databaseManager.GetTable(tablesControl.SelectedIndex);
            ShowTable(databaseManager.TableProjection(table));
        }

        private void toolStripTextBox5_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Table table = databaseManager.GetTable(tablesControl.SelectedIndex);
                var newTable = databaseManager.TableProjection(table, toolStripTextBox5.Text);
                if (table != null)
				{
                    ShowTable(newTable);
                }
            }
        }
    }
}

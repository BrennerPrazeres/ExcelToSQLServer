using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelToSqlDataBase
{
    public partial class ExcelToSqlDataBase : Form
    {
        private bool IsTabelaCriada { get; set; }
        private string CaminhoArquivo { get; set; }
        private string ConexaoBanco { get; set; }
        private DataTable TabelaBd { get; set; }
        private string NomTabela { get; set; }
        private string ScriptSql { get; set; }
        private bool DesligarProcessando { get; set; }
        public ExcelToSqlDataBase()
        {
            InitializeComponent();

            TabelaBd = new DataTable();

            pnlLeft.BackColor = Color.FromArgb(0, 128, 128);
            imgLogoBranco.BackColor = Color.Transparent;
            lblTituloLeft.ForeColor = Color.FromArgb(0, 255, 255, 255);
            lblLinhaLeft.ForeColor = Color.FromArgb(0, 255, 255, 255);
            textBoxUsuario.Focus();
            textBoxUsuario.Select();
            pnlProcessando.BackColor = Color.FromArgb(0, 128, 128);
            lblProcessando.ForeColor = Color.White;
            DesligarProcessando = true;
        }

        private void pnlLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExcelToSqlDataBase_Load(object sender, EventArgs e)
        {

        }

        private void BgwBtnExecutar_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                BgwBtnExecutar.ReportProgress(1, true);

                if (TabelaBd.Rows.Count > 0)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show("Deseja mesmo executar essa ação? ", "Alerta!", buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        try
                        {
                            if (IsTabelaCriada.Equals(false))
                            {
                                CreateTable(ScriptSql, ConexaoBanco);
                            }

                            SqlBulkCopy bulkcopy = new SqlBulkCopy(ConexaoBanco);
                            bulkcopy.DestinationTableName = NomTabela;

                            bulkcopy.WriteToServer(TabelaBd);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao gravar os dados: " + ex.Message);
                        }
                    }
                }

                BgwBtnExecutar.ReportProgress(1, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar os dados: " + ex.Message);
            }
        }

        private void BgwBtnExecutar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(string.Format("{0} - {1}", e.Error.Message, e.Error.StackTrace), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            buttonAbrirExcel.Enabled = true;
            richTextBoxScript.Enabled = false;
            richTextBoxScript.Text = string.Empty;
            MessageBox.Show("Operação finalizada com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GC.Collect();
        }

        private void BgwBtnExecutar_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (Convert.ToBoolean(e.UserState))
            {
                DesligarProcessando = true;
                pnlProcessando.Visible = true;
                lblProcessando.Visible = true;
            }
            else
            {
                DesligarProcessando = false;
                lblProcessando.Visible = false;
            }
        }

        private void BgwBtnAbrir_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                BgwBtnAbrir.ReportProgress(1, true);

                using (ExcelEngine excelEngine = new ExcelEngine())
                {
                    IApplication application = excelEngine.Excel;
                    application.DefaultVersion = ExcelVersion.Xlsx;
                    using (FileStream inputStream = new FileStream(CaminhoArquivo, FileMode.Open, FileAccess.Read))
                    {
                        IWorkbook workbook = application.Workbooks.Open(inputStream);
                        IWorksheet worksheet = workbook.Worksheets[0];

                        TabelaBd = worksheet.ExportDataTable(worksheet.UsedRange, ExcelExportDataTableOptions.ColumnNames);

                        TabelaBd = TabelaBd.Rows
                         .Cast<DataRow>()
                         .Where(row => !row.ItemArray.All(f => f is DBNull))
                         .CopyToDataTable();

                        NomTabela = $"{textBoxBase.Text}.DBO.{textBoxTabela.Text}";
                    }
                }

                BgwBtnAbrir.ReportProgress(1, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar os dados: " + ex.Message);
            }
        }

        private void BgwBtnAbrir_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (Convert.ToBoolean(e.UserState))
            {
                DesligarProcessando = true;
                pnlProcessando.Visible = true;
                lblProcessando.Visible = true;
            }
            else
            {
                DesligarProcessando = false;
                lblProcessando.Visible = false;
            }
        }

        private void BgwBtnAbrir_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(string.Format("{0} - {1}", e.Error.Message, e.Error.StackTrace), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (IsTabelaCriada.Equals(false))
            {
                richTextBoxScript.Enabled = true;
                richTextBoxScript.Text = ScriptCreateTable(NomTabela, TabelaBd);
            }
            else
            {
                richTextBoxScript.Text = string.Empty;
            }
            buttonExecutar.Enabled = true;
            GC.Collect();
        }

        public static string ScriptCreateTable(string tableName, DataTable table)
        {
            string sqlsc;
            sqlsc = "CREATE TABLE " + tableName + "\n (";
            for (int i = 0; i < table.Columns.Count; i++)
            {
                sqlsc += "\n [" + table.Columns[i].ColumnName + "] ";
                string columnType = table.Columns[i].DataType.ToString();
                switch (columnType)
                {
                    case "System.Int32":
                        sqlsc += " int ";
                        break;
                    case "System.Int64":
                        sqlsc += " bigint ";
                        break;
                    case "System.Int16":
                        sqlsc += " smallint";
                        break;
                    case "System.Byte":
                        sqlsc += " tinyint";
                        break;
                    case "System.Decimal":
                        sqlsc += " decimal ";
                        break;
                    case "System.DateTime":
                        sqlsc += " datetime ";
                        break;
                    case "System.String":
                    default:
                        sqlsc += string.Format(" nvarchar({0}) ", table.Columns[i].MaxLength == -1 ? "max" : table.Columns[i].MaxLength.ToString());
                        break;
                }
                if (table.Columns[i].AutoIncrement)
                    sqlsc += " IDENTITY(" + table.Columns[i].AutoIncrementSeed.ToString() + "," + table.Columns[i].AutoIncrementStep.ToString() + ") ";
                if (!table.Columns[i].AllowDBNull)
                    sqlsc += " NOT NULL ";
                sqlsc += ",";
            }
            var sql = sqlsc.Substring(0, sqlsc.Length - 1);
            sql += "\n )";
            return sql;
        }

        private void buttonExecutar_Click(object sender, EventArgs e)
        {
            buttonAbrirExcel.Enabled = false;
            buttonExecutar.Enabled = false;
            ScriptSql = richTextBoxScript.Text;
            BgwBtnExecutar.RunWorkerAsync();
        }

        public static void CreateTable(string scriptSql, string conexao)
        {

            using (SqlConnection sqlConn = new SqlConnection(conexao))
            {
                sqlConn.Open();
                SqlCommand sqlComm = new SqlCommand();
                sqlComm.CommandTimeout = 0;
                SqlTransaction transaction;
                transaction = sqlConn.BeginTransaction(IsolationLevel.ReadCommitted);
                sqlComm.Connection = sqlConn;
                sqlComm.Transaction = transaction;

                try
                {
                    sqlComm.CommandText = scriptSql;
                    sqlComm.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception(ex.Message, ex.InnerException);
                }
                finally
                {
                    sqlConn.Close();
                    sqlConn.Dispose();
                    sqlComm.Dispose();
                }
            }
        }

        private void buttonAbrirExcel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxUsuario.Text) & !string.IsNullOrEmpty(textBoxSenha.Text) && !string.IsNullOrEmpty(textBoxServidor.Text) && !string.IsNullOrEmpty(textBoxBase.Text) && !string.IsNullOrEmpty(textBoxTabela.Text))
            {
                ConexaoBanco = $"Server={textBoxServidor.Text};Initial Catalog={textBoxBase.Text};User id={textBoxUsuario.Text};password={textBoxSenha.Text};Min Pool Size=10;Pooling=true;Max Pool Size=200;";

                buttonExecutar.Enabled = false;

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "xlsx files (*.xlsx)|*.xlsx";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        CaminhoArquivo = openFileDialog.FileName;
                        BgwBtnAbrir.RunWorkerAsync();
                    }
                }
            }
            else
            {
                MessageBox.Show("Todos os campos precisam estar preenchidos! ");
            }
        }

        private void radioButtonSim_CheckedChanged(object sender, EventArgs e)
        {
            IsTabelaCriada = true;
        }

        private void radioButtonNao_CheckedChanged(object sender, EventArgs e)
        {
            IsTabelaCriada = false;
        }
    }
}

using OfficeOpenXml;
using OfficeOpenXml.Table;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BizgiFormUtil
{
    public partial class Form1 : Form
    {
        private string pCaseID;
        private string pTkName;
        private string pTkID;
        private string pTTksType;
        private string pCaseNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {

           
            var bc = new BizagiServicesClient.Servico();

            this.pCaseNumber = txtCaso.Text;
            
            var x = bc.GetCaseInfo(pCaseNumber);
            this.pCaseID = x.Process[0].ProcessId;

            this.pTkName = x.Process[0].CurrentWorkItems.WorkItem.Task.TaskName;
            this.pTkID = x.Process[0].CurrentWorkItems.WorkItem.Task.TaskId;
            this.pTTksType = x.Process[0].CurrentWorkItems.WorkItem.Task.TaskType;
            //lbTarefa.Text = string.Format("ID Caso: {0}, tName: {1}, tID: {2}", pCaseID, pTkName, pTkID);
            lblType.Text = this.pTTksType;
                var curTask = x.Process[0].CurrentWorkItems.WorkItem.Task;
                curTask.workItemId = x.Process[0].CurrentWorkItems.WorkItem.WorkItemId;
                curTask.workItemState = x.Process[0].CurrentWorkItems.WorkItem.WorkItemState;
                curTask.workItemEntryDate = x.Process[0].CurrentWorkItems.WorkItem.WorkItemEntryDate;
                curTask.workItemDuration = x.Process[0].CurrentWorkItems.WorkItem.WorkItemDuration;
                curTask.workItemEstimatedSolutionDate = x.Process[0].CurrentWorkItems.WorkItem.WorkItemEstimatedSolutionDate;
                pgWorkItem.SelectedObject = curTask;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnAply_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure?", "Bizagi útil", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    var bc = new BizagiServicesClient.Servico();
                    var pd = bc.PerformActivity(pCaseNumber, pTkName, pCaseID, pTkID);
                    button1.PerformClick();
                }
                catch (Exception ex)
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show(ex.ToString());
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void txtCaso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                var bc = new BizagiServicesClient.Servico();
                var data = bc.GetCaseInfo("");
                var processos = data.Process;


                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Planilha Excel|*.xlsx";
                saveFileDialog1.Title = "Exportar";
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName != "")
                {
                    var excelFile = saveFileDialog1.FileName;
                    ExcelPackage pck = new ExcelPackage();
                    var listToExport = from x in processos
                                       select new
                                       {
                                           IDProcesso = x.ProcessId,
                                           GuidProcesso = x.CaseGuid,
                                           CaseNumber = x.ProcessRadNumber,
                                           DataCriacao = x.ProcessCreationDate,
                                           ProcessoNome = x.ProcessWorkflowClass.WorkflowClassDisplayName,
                                           WorkItemId = x.CurrentWorkItems.WorkItem.WorkItemId,
                                           workItemState = x.CurrentWorkItems.WorkItem.WorkItemState,
                                           workItemEntryDate = x.CurrentWorkItems.WorkItem.WorkItemEntryDate,
                                           workItemDuration = x.CurrentWorkItems.WorkItem.WorkItemDuration,

                                           taskId = x.CurrentWorkItems.WorkItem.Task.TaskId,
                                           taskName = x.CurrentWorkItems.WorkItem.Task.TaskName,
                                           taskDisplayName = x.CurrentWorkItems.WorkItem.Task.TaskDisplayName,
                                           taskType = x.CurrentWorkItems.WorkItem.Task.TaskType


                                       };
                    var wsDt = pck.Workbook.Worksheets.Add("Dados");
                    wsDt.Cells["A1"].LoadFromCollection(listToExport, true, TableStyles.Medium9);
                    // wsDt.Cells[2, 30, listToExport.Count + 1, 30].Style.Numberformat.Format = "dd/mm/yy";
                    wsDt.Cells[wsDt.Dimension.Address].AutoFitColumns();
                    var fi = new FileInfo(excelFile);
                    if (fi.Exists)
                        fi.Delete();
                    pck.SaveAs(fi);
                    System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(excelFile);
                    psi.UseShellExecute = true;
                    Process.Start(psi);
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.ToString());
            }
            Cursor.Current = Cursors.Default;
        }
    }
}

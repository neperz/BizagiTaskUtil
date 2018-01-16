using BizagiServicesClient;
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
                cmbProcessos.Items.Clear();
                var x = bc.GetCaseInfo(pCaseNumber);
                this.pCaseID = x.Process[0].ProcessId;
                foreach (var p in x.Process)
                {
                    var cbItem = new ComboBoxProcessoItem();
                    cbItem.Value = p.ProcessId;
                    cbItem.Name = p.ProcessWorkflowClass.WorkflowClassDisplayName;
                    cbItem.Tag = p;                    
                    cmbProcessos.Items.Add(cbItem);
                }

                ViweProcess(x.Process[0]);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            Cursor.Current = Cursors.Default;
        }

        private void ViweProcess(BizagiServicesClient.Process process)
        {
          
            this.pTkName = process.CurrentWorkItems.WorkItem.Task.TaskName;
            this.pTkID = process.CurrentWorkItems.WorkItem.Task.TaskId;
            this.pTTksType = process.CurrentWorkItems.WorkItem.Task.TaskType;
            //lbTarefa.Text = string.Format("ID Caso: {0}, tName: {1}, tID: {2}", pCaseID, pTkName, pTkID);
            lblType.Text = this.pTTksType;
            var curTask = process.CurrentWorkItems.WorkItem.Task;
            curTask.workItemId = process.CurrentWorkItems.WorkItem.WorkItemId;
            curTask.workItemState = process.CurrentWorkItems.WorkItem.WorkItemState;
            curTask.workItemEntryDate = process.CurrentWorkItems.WorkItem.WorkItemEntryDate;
            curTask.workItemDuration = process.CurrentWorkItems.WorkItem.WorkItemDuration;
            curTask.workItemEstimatedSolutionDate = process.CurrentWorkItems.WorkItem.WorkItemEstimatedSolutionDate;
            pgWorkItem.SelectedObject = curTask;
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
                    System.Diagnostics.Process.Start(psi);
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.ToString());
            }
            Cursor.Current = Cursors.Default;
        }

        private void cmbProcessos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sel = cmbProcessos.SelectedItem;
            var obj = (ComboBoxProcessoItem)sel;
            ViweProcess(obj.Tag);
        }
    }
}

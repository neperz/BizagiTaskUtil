using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            this.pCaseID = x.Process.ProcessId;

            this.pTkName = x.Process.CurrentWorkItems.WorkItem.Task.TaskName;
            this.pTkID = x.Process.CurrentWorkItems.WorkItem.Task.TaskId;
            this.pTTksType = x.Process.CurrentWorkItems.WorkItem.Task.TaskType;
            //lbTarefa.Text = string.Format("ID Caso: {0}, tName: {1}, tID: {2}", pCaseID, pTkName, pTkID);
            lblType.Text = this.pTTksType;
                var curTask = x.Process.CurrentWorkItems.WorkItem.Task;
                curTask.workItemId = x.Process.CurrentWorkItems.WorkItem.WorkItemId;
                curTask.workItemState = x.Process.CurrentWorkItems.WorkItem.WorkItemState;
                curTask.workItemEntryDate = x.Process.CurrentWorkItems.WorkItem.WorkItemEntryDate;
                curTask.workItemDuration = x.Process.CurrentWorkItems.WorkItem.WorkItemDuration;
                curTask.workItemEstimatedSolutionDate = x.Process.CurrentWorkItems.WorkItem.WorkItemEstimatedSolutionDate;
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
    }
}

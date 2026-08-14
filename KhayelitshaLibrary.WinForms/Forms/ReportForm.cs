using System;
using System.Windows.Forms;

using KhayelitshaLibrary.WinForms.Repositories;

namespace KhayelitshaLibrary.WinForms.Forms
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();

            ConfigureForm();
        }


        // =================================================================================================
        // CONFIGURE FORM
        // =================================================================================================

        private void ConfigureForm()
        {
            dataGridViewReport.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewReport.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridViewReport.MultiSelect = false;

            dataGridViewReport.ReadOnly = true;

            dataGridViewReport.AllowUserToAddRows = false;

            dataGridViewReport.AllowUserToDeleteRows = false;
        }


        // =================================================================================================
        // CURRENT / OVERDUE LOANS
        // =================================================================================================

        private void btnCurrentOverdue_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                var repository = new ReportRepository();

                var report =
                    repository.GetCurrentAndOverdueLoans();

                dataGridViewReport.DataSource = report;

                if (report.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "There are currently no active or overdue loans.",
                        "Loan Report",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    return;
                }

                MessageBox.Show(
                    "Current and overdue loan report loaded successfully.",
                    "Report",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to load the current and overdue loan report.\n\n{ex.Message}",
                    "Report Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =================================================================================================
        // LOANS PER MEMBER
        // =================================================================================================

        private void btnLoansPerMember_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                var repository = new ReportRepository();

                var report =
                    repository.GetLoansPerMember();

                dataGridViewReport.DataSource = report;

                if (report.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No member loan data was found.",
                        "Loan Report",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    return;
                }

                MessageBox.Show(
                    "Loans per member report loaded successfully.",
                    "Report",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to load the loans per member report.\n\n{ex.Message}",
                    "Report Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =================================================================================================
        // CLEAR REPORT
        // =================================================================================================

        private void btnClear_Click(
            object sender,
            EventArgs e)
        {
            dataGridViewReport.DataSource = null;

            dataGridViewReport.Rows.Clear();
            dataGridViewReport.Columns.Clear();
        }


        // =================================================================================================
        // FORM LOAD
        // =================================================================================================

        private void ReportForm_Load(
            object sender,
            EventArgs e)
        {
        }
    }
}
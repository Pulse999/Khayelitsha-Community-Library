using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KhayelitshaLibrary.WinForms.Models;
using KhayelitshaLibrary.WinForms.Repositories;

namespace KhayelitshaLibrary.WinForms.Forms
{
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
            LoadMembers();
        }

        // =================================================================================================
        // LOAD ALL MEMBERS
        // =================================================================================================

        private void LoadMembers()
        {
            try
            {
                var repository = new MemberRepository();

                var members = repository.GetAllMembers();

                dataGridView1.DataSource = members;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to load members.\n\n{ex.Message}",
                    "Member Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =================================================================================================
        // SELECT MEMBER FROM GRID
        // =================================================================================================

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks on the column headers
            if (e.RowIndex < 0)
                return;

            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Ignore empty rows
                if (row.IsNewRow)
                    return;

                /*
                 * DataGridView column order:
                 *
                 * 0 = MemberID
                 * 1 = FirstName
                 * 2 = LastName
                 * 3 = Email
                 * 4 = Age
                 * 5 = Address
                 * 6 = PhoneNumber
                 * 7 = JoinDate
                 */

                txtMemberID.Text = row.Cells[0].Value?.ToString() ?? "";
                txtFirstName.Text = row.Cells[1].Value?.ToString() ?? "";
                txtLastName.Text = row.Cells[2].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells[3].Value?.ToString() ?? "";
                txtAge.Text = row.Cells[4].Value?.ToString() ?? "";
                txtAddress.Text = row.Cells[5].Value?.ToString() ?? "";
                txtPhoneNumber.Text = row.Cells[6].Value?.ToString() ?? "";

                // Load Join Date
                if (row.Cells[7].Value != null &&
                    DateTime.TryParse(
                        row.Cells[7].Value.ToString(),
                        out DateTime joinDate))
                {
                    dtpJoinDate.Value = joinDate;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to load member details.\n\n{ex.Message}",
                    "Member Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =================================================================================================
        // UPDATE MEMBER
        // =================================================================================================

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                // -----------------------------------------------------------------------------------------
                // Validate Member ID
                // -----------------------------------------------------------------------------------------

                if (!int.TryParse(txtMemberID.Text, out int memberId))
                {
                    MessageBox.Show(
                        "Please select a member from the grid first.",
                        "Invalid Member",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }


                // -----------------------------------------------------------------------------------------
                // Validate required fields
                // -----------------------------------------------------------------------------------------

                if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                    string.IsNullOrWhiteSpace(txtLastName.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtAge.Text) ||
                    string.IsNullOrWhiteSpace(txtAddress.Text) ||
                    string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
                {
                    MessageBox.Show(
                        "Please fill in all member fields.",
                        "Missing Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }


                // -----------------------------------------------------------------------------------------
                // Validate Age
                // -----------------------------------------------------------------------------------------

                if (!int.TryParse(txtAge.Text, out int age))
                {
                    MessageBox.Show(
                        "Age must be a valid number.",
                        "Invalid Age",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }


                // -----------------------------------------------------------------------------------------
                // Create updated Member object
                // -----------------------------------------------------------------------------------------

                var member = new Member
                {
                    MemberID = memberId,
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Age = age,
                    Address = txtAddress.Text.Trim(),
                    PhoneNumber = txtPhoneNumber.Text.Trim(),
                    JoinDate = DateOnly.FromDateTime(dtpJoinDate.Value)
                };


                // -----------------------------------------------------------------------------------------
                // Update database
                // -----------------------------------------------------------------------------------------

                var repository = new MemberRepository();

                repository.UpdateMember(member);


                // -----------------------------------------------------------------------------------------
                // Refresh grid
                // -----------------------------------------------------------------------------------------

                LoadMembers();


                // -----------------------------------------------------------------------------------------
                // Success message
                // -----------------------------------------------------------------------------------------

                MessageBox.Show(
                    "Member updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to update member.\n\n{ex.Message}",
                    "Update Member Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =================================================================================================
        // DELETE MEMBER
        // =================================================================================================

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // -----------------------------------------------------------------------------------------
                // Validate Member ID
                // -----------------------------------------------------------------------------------------

                if (!int.TryParse(txtMemberID.Text, out int memberId))
                {
                    MessageBox.Show(
                        "Please select a member from the grid first.",
                        "Invalid Member",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }


                // -----------------------------------------------------------------------------------------
                // Confirm deletion
                // -----------------------------------------------------------------------------------------

                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete member #{memberId}?\n\n" +
                    $"{txtFirstName.Text} {txtLastName.Text}",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result != DialogResult.Yes)
                    return;


                // -----------------------------------------------------------------------------------------
                // Delete member
                // -----------------------------------------------------------------------------------------

                var repository = new MemberRepository();

                repository.DeleteMember(memberId);


                // -----------------------------------------------------------------------------------------
                // Refresh grid
                // -----------------------------------------------------------------------------------------

                LoadMembers();


                // -----------------------------------------------------------------------------------------
                // Clear fields
                // -----------------------------------------------------------------------------------------

                ClearFields();


                // -----------------------------------------------------------------------------------------
                // Success message
                // -----------------------------------------------------------------------------------------

                MessageBox.Show(
                    "Member deleted successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to delete member.\n\n{ex.Message}",
                    "Delete Member Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =================================================================================================
        // CLEAR & REFRESH FORM 
        // =================================================================================================

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearFields();
            LoadMembers();
        }


        // =================================================================================================
        // CLEAR ALL MEMBER FIELDS
        // =================================================================================================

        private void ClearFields()
        {
            txtMemberID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtAge.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();

            dtpJoinDate.Value = DateTime.Today;

            dataGridView1.ClearSelection();

            // Restore all members after a search
            LoadMembers();
        }

        // =================================================================================================
        // SEARCH MEMBER
        // =================================================================================================

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // -----------------------------------------------------------------------------------------
                // Validate Member ID
                // -----------------------------------------------------------------------------------------

                if (!int.TryParse(txtMemberID.Text.Trim(), out int memberId))
                {
                    MessageBox.Show(
                        "Please enter a valid Member ID.",
                        "Invalid Member ID",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }


                // -----------------------------------------------------------------------------------------
                // Search database
                // -----------------------------------------------------------------------------------------

                var repository = new MemberRepository();

                var member = repository.SearchMemberById(memberId);


                // -----------------------------------------------------------------------------------------
                // Member not found
                // -----------------------------------------------------------------------------------------

                if (member == null)
                {
                    MessageBox.Show(
                        $"No member was found with Member ID {memberId}.",
                        "Member Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    return;
                }


                // -----------------------------------------------------------------------------------------
                // Display member in the form
                // -----------------------------------------------------------------------------------------

                txtMemberID.Text = member.MemberID.ToString();
                txtFirstName.Text = member.FirstName;
                txtLastName.Text = member.LastName;
                txtEmail.Text = member.Email;
                txtAge.Text = member.Age.ToString();
                txtAddress.Text = member.Address;
                txtPhoneNumber.Text = member.PhoneNumber;

                dtpJoinDate.Value = member.JoinDate.ToDateTime(
                    TimeOnly.MinValue
                );


                // -----------------------------------------------------------------------------------------
                // Display only the searched member in the grid
                // -----------------------------------------------------------------------------------------

                dataGridView1.DataSource = new List<Member>
        {
            member
        };
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to search for member.\n\n{ex.Message}",
                    "Search Member Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {

        }
    }
}
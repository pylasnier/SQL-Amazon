namespace SQL_Amazon
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtRecordAccess = new System.Windows.Forms.TextBox();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.btnStartShopping = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRecordAccess
            // 
            this.txtRecordAccess.Enabled = false;
            this.txtRecordAccess.Location = new System.Drawing.Point(12, 12);
            this.txtRecordAccess.Multiline = true;
            this.txtRecordAccess.Name = "txtRecordAccess";
            this.txtRecordAccess.Size = new System.Drawing.Size(316, 183);
            this.txtRecordAccess.TabIndex = 0;
            this.txtRecordAccess.WordWrap = false;
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Location = new System.Drawing.Point(228, 201);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(100, 20);
            this.txtSearchBar.TabIndex = 1;
            this.txtSearchBar.Visible = false;
            // 
            // btnStartShopping
            // 
            this.btnStartShopping.Location = new System.Drawing.Point(12, 230);
            this.btnStartShopping.Name = "btnStartShopping";
            this.btnStartShopping.Size = new System.Drawing.Size(102, 23);
            this.btnStartShopping.TabIndex = 2;
            this.btnStartShopping.Text = "Start Shopping";
            this.btnStartShopping.UseVisualStyleBackColor = true;
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Location = new System.Drawing.Point(12, 201);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(102, 23);
            this.btnViewOrders.TabIndex = 3;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(178, 204);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search:";
            this.lblSearch.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(181, 234);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(262, 234);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(67, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 269);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnViewOrders);
            this.Controls.Add(this.btnStartShopping);
            this.Controls.Add(this.txtSearchBar);
            this.Controls.Add(this.txtRecordAccess);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecordAccess;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.Button btnStartShopping;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}
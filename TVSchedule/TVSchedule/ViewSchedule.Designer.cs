namespace TVSchedule
{
    partial class ViewSchedule
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemoveFromSchedule = new System.Windows.Forms.Button();
            this.btnViewMovies = new System.Windows.Forms.Button();
            this.btnViewTV = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.lblAvailableShows = new System.Windows.Forms.Label();
            this.dgvScheduleList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduleList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(269, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(192, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TV Schedule";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(561, 383);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 55);
            this.btnExit.TabIndex = 47;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemoveFromSchedule
            // 
            this.btnRemoveFromSchedule.Location = new System.Drawing.Point(642, 323);
            this.btnRemoveFromSchedule.Name = "btnRemoveFromSchedule";
            this.btnRemoveFromSchedule.Size = new System.Drawing.Size(75, 55);
            this.btnRemoveFromSchedule.TabIndex = 46;
            this.btnRemoveFromSchedule.Text = "Remove Show From Schedule";
            this.btnRemoveFromSchedule.UseVisualStyleBackColor = true;
            this.btnRemoveFromSchedule.Click += new System.EventHandler(this.btnRemoveFromSchedule_Click);
            // 
            // btnViewMovies
            // 
            this.btnViewMovies.Location = new System.Drawing.Point(642, 194);
            this.btnViewMovies.Name = "btnViewMovies";
            this.btnViewMovies.Size = new System.Drawing.Size(75, 55);
            this.btnViewMovies.TabIndex = 45;
            this.btnViewMovies.Text = "View Movies Only";
            this.btnViewMovies.UseVisualStyleBackColor = true;
            this.btnViewMovies.Click += new System.EventHandler(this.btnViewMovies_Click);
            // 
            // btnViewTV
            // 
            this.btnViewTV.Location = new System.Drawing.Point(642, 259);
            this.btnViewTV.Name = "btnViewTV";
            this.btnViewTV.Size = new System.Drawing.Size(75, 55);
            this.btnViewTV.TabIndex = 44;
            this.btnViewTV.Text = "View TV Shows Only";
            this.btnViewTV.UseVisualStyleBackColor = true;
            this.btnViewTV.Click += new System.EventHandler(this.btnViewTV_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(642, 130);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(75, 55);
            this.btnViewAll.TabIndex = 43;
            this.btnViewAll.Text = "View All Shows";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // lblAvailableShows
            // 
            this.lblAvailableShows.AutoSize = true;
            this.lblAvailableShows.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableShows.Location = new System.Drawing.Point(182, 85);
            this.lblAvailableShows.Name = "lblAvailableShows";
            this.lblAvailableShows.Size = new System.Drawing.Size(363, 25);
            this.lblAvailableShows.TabIndex = 42;
            this.lblAvailableShows.Text = "Movies and TV Shows Scheduled";
            // 
            // dgvScheduleList
            // 
            this.dgvScheduleList.AllowUserToAddRows = false;
            this.dgvScheduleList.AllowUserToDeleteRows = false;
            this.dgvScheduleList.AllowUserToResizeColumns = false;
            this.dgvScheduleList.AllowUserToResizeRows = false;
            this.dgvScheduleList.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvScheduleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvScheduleList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvScheduleList.GridColor = System.Drawing.Color.DimGray;
            this.dgvScheduleList.Location = new System.Drawing.Point(9, 130);
            this.dgvScheduleList.MultiSelect = false;
            this.dgvScheduleList.Name = "dgvScheduleList";
            this.dgvScheduleList.ReadOnly = true;
            this.dgvScheduleList.RowHeadersVisible = false;
            this.dgvScheduleList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvScheduleList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvScheduleList.Size = new System.Drawing.Size(627, 248);
            this.dgvScheduleList.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 62);
            this.panel1.TabIndex = 40;
            // 
            // ViewSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(726, 444);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemoveFromSchedule);
            this.Controls.Add(this.btnViewMovies);
            this.Controls.Add(this.btnViewTV);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.lblAvailableShows);
            this.Controls.Add(this.dgvScheduleList);
            this.Controls.Add(this.panel1);
            this.Name = "ViewSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduleList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemoveFromSchedule;
        private System.Windows.Forms.Button btnViewMovies;
        private System.Windows.Forms.Button btnViewTV;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Label lblAvailableShows;
        private System.Windows.Forms.DataGridView dgvScheduleList;
        private System.Windows.Forms.Panel panel1;
    }
}
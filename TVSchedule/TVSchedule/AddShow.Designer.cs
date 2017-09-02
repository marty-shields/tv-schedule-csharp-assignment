namespace TVSchedule
{
    partial class AddShow
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
            this.grpType = new System.Windows.Forms.GroupBox();
            this.rdoMovie = new System.Windows.Forms.RadioButton();
            this.rdoEpisode = new System.Windows.Forms.RadioButton();
            this.rdoHidden1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoOption4 = new System.Windows.Forms.RadioButton();
            this.rdoOption3 = new System.Windows.Forms.RadioButton();
            this.rdoOption2 = new System.Windows.Forms.RadioButton();
            this.rdoOption1 = new System.Windows.Forms.RadioButton();
            this.rdoHidden2 = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtRunTime = new System.Windows.Forms.TextBox();
            this.lblRunTime = new System.Windows.Forms.Label();
            this.txtAgeRating = new System.Windows.Forms.TextBox();
            this.lblAgeRating = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtOption1 = new System.Windows.Forms.TextBox();
            this.lblOption1 = new System.Windows.Forms.Label();
            this.txtOption2 = new System.Windows.Forms.TextBox();
            this.lblOption2 = new System.Windows.Forms.Label();
            this.txtOption3 = new System.Windows.Forms.TextBox();
            this.lblOption3 = new System.Windows.Forms.Label();
            this.txtOption4 = new System.Windows.Forms.TextBox();
            this.lblOption4 = new System.Windows.Forms.Label();
            this.btnAddShow = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grpType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpType
            // 
            this.grpType.Controls.Add(this.rdoMovie);
            this.grpType.Controls.Add(this.rdoEpisode);
            this.grpType.Controls.Add(this.rdoHidden1);
            this.grpType.Location = new System.Drawing.Point(277, 104);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(138, 100);
            this.grpType.TabIndex = 0;
            this.grpType.TabStop = false;
            this.grpType.Text = "Choose Type";
            // 
            // rdoMovie
            // 
            this.rdoMovie.AutoSize = true;
            this.rdoMovie.Location = new System.Drawing.Point(7, 66);
            this.rdoMovie.Name = "rdoMovie";
            this.rdoMovie.Size = new System.Drawing.Size(54, 17);
            this.rdoMovie.TabIndex = 2;
            this.rdoMovie.Text = "Movie";
            this.rdoMovie.UseVisualStyleBackColor = true;
            this.rdoMovie.CheckedChanged += new System.EventHandler(this.rdoMovie_CheckedChanged);
            // 
            // rdoEpisode
            // 
            this.rdoEpisode.AutoSize = true;
            this.rdoEpisode.Location = new System.Drawing.Point(7, 42);
            this.rdoEpisode.Name = "rdoEpisode";
            this.rdoEpisode.Size = new System.Drawing.Size(63, 17);
            this.rdoEpisode.TabIndex = 1;
            this.rdoEpisode.Text = "Episode";
            this.rdoEpisode.UseVisualStyleBackColor = true;
            this.rdoEpisode.CheckedChanged += new System.EventHandler(this.rdoEpisode_CheckedChanged);
            // 
            // rdoHidden1
            // 
            this.rdoHidden1.AutoSize = true;
            this.rdoHidden1.Checked = true;
            this.rdoHidden1.Location = new System.Drawing.Point(118, 19);
            this.rdoHidden1.Name = "rdoHidden1";
            this.rdoHidden1.Size = new System.Drawing.Size(14, 13);
            this.rdoHidden1.TabIndex = 0;
            this.rdoHidden1.TabStop = true;
            this.rdoHidden1.UseVisualStyleBackColor = true;
            this.rdoHidden1.Visible = false;
            this.rdoHidden1.CheckedChanged += new System.EventHandler(this.rdoHidden1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoOption4);
            this.groupBox1.Controls.Add(this.rdoOption3);
            this.groupBox1.Controls.Add(this.rdoOption2);
            this.groupBox1.Controls.Add(this.rdoOption1);
            this.groupBox1.Controls.Add(this.rdoHidden2);
            this.groupBox1.Location = new System.Drawing.Point(277, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 115);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Type";
            // 
            // rdoOption4
            // 
            this.rdoOption4.AutoSize = true;
            this.rdoOption4.Location = new System.Drawing.Point(7, 85);
            this.rdoOption4.Name = "rdoOption4";
            this.rdoOption4.Size = new System.Drawing.Size(14, 13);
            this.rdoOption4.TabIndex = 4;
            this.rdoOption4.TabStop = true;
            this.rdoOption4.UseVisualStyleBackColor = true;
            this.rdoOption4.Visible = false;
            this.rdoOption4.CheckedChanged += new System.EventHandler(this.rdoOption4_CheckedChanged);
            // 
            // rdoOption3
            // 
            this.rdoOption3.AutoSize = true;
            this.rdoOption3.Location = new System.Drawing.Point(7, 28);
            this.rdoOption3.Name = "rdoOption3";
            this.rdoOption3.Size = new System.Drawing.Size(14, 13);
            this.rdoOption3.TabIndex = 3;
            this.rdoOption3.TabStop = true;
            this.rdoOption3.UseVisualStyleBackColor = true;
            this.rdoOption3.Visible = false;
            this.rdoOption3.CheckedChanged += new System.EventHandler(this.rdoOption3_CheckedChanged);
            // 
            // rdoOption2
            // 
            this.rdoOption2.AutoSize = true;
            this.rdoOption2.Location = new System.Drawing.Point(7, 66);
            this.rdoOption2.Name = "rdoOption2";
            this.rdoOption2.Size = new System.Drawing.Size(14, 13);
            this.rdoOption2.TabIndex = 2;
            this.rdoOption2.UseVisualStyleBackColor = true;
            this.rdoOption2.Visible = false;
            this.rdoOption2.CheckedChanged += new System.EventHandler(this.rdoOption2_CheckedChanged);
            // 
            // rdoOption1
            // 
            this.rdoOption1.AutoSize = true;
            this.rdoOption1.Location = new System.Drawing.Point(7, 47);
            this.rdoOption1.Name = "rdoOption1";
            this.rdoOption1.Size = new System.Drawing.Size(14, 13);
            this.rdoOption1.TabIndex = 1;
            this.rdoOption1.UseVisualStyleBackColor = true;
            this.rdoOption1.Visible = false;
            this.rdoOption1.CheckedChanged += new System.EventHandler(this.rdoOption1_CheckedChanged);
            // 
            // rdoHidden2
            // 
            this.rdoHidden2.AutoSize = true;
            this.rdoHidden2.Checked = true;
            this.rdoHidden2.Location = new System.Drawing.Point(118, 19);
            this.rdoHidden2.Name = "rdoHidden2";
            this.rdoHidden2.Size = new System.Drawing.Size(14, 13);
            this.rdoHidden2.TabIndex = 0;
            this.rdoHidden2.TabStop = true;
            this.rdoHidden2.UseVisualStyleBackColor = true;
            this.rdoHidden2.Visible = false;
            this.rdoHidden2.CheckedChanged += new System.EventHandler(this.rdoHidden2_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(75, 104);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title:";
            this.lblTitle.Visible = false;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(111, 101);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(157, 20);
            this.txtTitle.TabIndex = 5;
            this.txtTitle.Visible = false;
            // 
            // txtRunTime
            // 
            this.txtRunTime.Location = new System.Drawing.Point(111, 127);
            this.txtRunTime.Name = "txtRunTime";
            this.txtRunTime.Size = new System.Drawing.Size(157, 20);
            this.txtRunTime.TabIndex = 7;
            this.txtRunTime.Visible = false;
            // 
            // lblRunTime
            // 
            this.lblRunTime.AutoSize = true;
            this.lblRunTime.Location = new System.Drawing.Point(49, 130);
            this.lblRunTime.Name = "lblRunTime";
            this.lblRunTime.Size = new System.Drawing.Size(56, 13);
            this.lblRunTime.TabIndex = 6;
            this.lblRunTime.Text = "Run Time:";
            this.lblRunTime.Visible = false;
            // 
            // txtAgeRating
            // 
            this.txtAgeRating.Location = new System.Drawing.Point(111, 153);
            this.txtAgeRating.Name = "txtAgeRating";
            this.txtAgeRating.Size = new System.Drawing.Size(157, 20);
            this.txtAgeRating.TabIndex = 9;
            this.txtAgeRating.Visible = false;
            // 
            // lblAgeRating
            // 
            this.lblAgeRating.AutoSize = true;
            this.lblAgeRating.Location = new System.Drawing.Point(42, 156);
            this.lblAgeRating.Name = "lblAgeRating";
            this.lblAgeRating.Size = new System.Drawing.Size(63, 13);
            this.lblAgeRating.TabIndex = 8;
            this.lblAgeRating.Text = "Age Rating:";
            this.lblAgeRating.Visible = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(111, 179);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(157, 92);
            this.txtDescription.TabIndex = 11;
            this.txtDescription.Visible = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(42, 182);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Description:";
            this.lblDescription.Visible = false;
            // 
            // txtOption1
            // 
            this.txtOption1.Location = new System.Drawing.Point(111, 277);
            this.txtOption1.Name = "txtOption1";
            this.txtOption1.Size = new System.Drawing.Size(157, 20);
            this.txtOption1.TabIndex = 13;
            this.txtOption1.Visible = false;
            // 
            // lblOption1
            // 
            this.lblOption1.Location = new System.Drawing.Point(5, 280);
            this.lblOption1.Name = "lblOption1";
            this.lblOption1.Size = new System.Drawing.Size(100, 13);
            this.lblOption1.TabIndex = 12;
            this.lblOption1.Text = "Label5";
            this.lblOption1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOption1.Visible = false;
            // 
            // txtOption2
            // 
            this.txtOption2.Location = new System.Drawing.Point(111, 301);
            this.txtOption2.Name = "txtOption2";
            this.txtOption2.Size = new System.Drawing.Size(157, 20);
            this.txtOption2.TabIndex = 15;
            this.txtOption2.Visible = false;
            // 
            // lblOption2
            // 
            this.lblOption2.Location = new System.Drawing.Point(5, 304);
            this.lblOption2.Name = "lblOption2";
            this.lblOption2.Size = new System.Drawing.Size(100, 13);
            this.lblOption2.TabIndex = 14;
            this.lblOption2.Text = "label6";
            this.lblOption2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOption2.Visible = false;
            // 
            // txtOption3
            // 
            this.txtOption3.Location = new System.Drawing.Point(111, 327);
            this.txtOption3.Name = "txtOption3";
            this.txtOption3.Size = new System.Drawing.Size(157, 20);
            this.txtOption3.TabIndex = 17;
            this.txtOption3.Visible = false;
            // 
            // lblOption3
            // 
            this.lblOption3.Location = new System.Drawing.Point(5, 330);
            this.lblOption3.Name = "lblOption3";
            this.lblOption3.Size = new System.Drawing.Size(100, 13);
            this.lblOption3.TabIndex = 16;
            this.lblOption3.Text = "label7";
            this.lblOption3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOption3.Visible = false;
            // 
            // txtOption4
            // 
            this.txtOption4.Location = new System.Drawing.Point(111, 353);
            this.txtOption4.Name = "txtOption4";
            this.txtOption4.Size = new System.Drawing.Size(157, 20);
            this.txtOption4.TabIndex = 19;
            this.txtOption4.Visible = false;
            // 
            // lblOption4
            // 
            this.lblOption4.Location = new System.Drawing.Point(5, 356);
            this.lblOption4.Name = "lblOption4";
            this.lblOption4.Size = new System.Drawing.Size(100, 13);
            this.lblOption4.TabIndex = 18;
            this.lblOption4.Text = "label8";
            this.lblOption4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOption4.Visible = false;
            // 
            // btnAddShow
            // 
            this.btnAddShow.Location = new System.Drawing.Point(111, 385);
            this.btnAddShow.Name = "btnAddShow";
            this.btnAddShow.Size = new System.Drawing.Size(75, 56);
            this.btnAddShow.TabIndex = 20;
            this.btnAddShow.Text = "button1";
            this.btnAddShow.UseVisualStyleBackColor = true;
            this.btnAddShow.Visible = false;
            this.btnAddShow.Click += new System.EventHandler(this.btnAddShow_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(277, 385);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 56);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(111, 75);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(157, 20);
            this.txtID.TabIndex = 23;
            this.txtID.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(84, 78);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 22;
            this.lblID.Text = "ID:";
            this.lblID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 62);
            this.panel1.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(143, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "TV Schedule";
            // 
            // AddShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddShow);
            this.Controls.Add(this.txtOption4);
            this.Controls.Add(this.lblOption4);
            this.Controls.Add(this.txtOption3);
            this.Controls.Add(this.lblOption3);
            this.Controls.Add(this.txtOption2);
            this.Controls.Add(this.lblOption2);
            this.Controls.Add(this.txtOption1);
            this.Controls.Add(this.lblOption1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtAgeRating);
            this.Controls.Add(this.lblAgeRating);
            this.Controls.Add(this.txtRunTime);
            this.Controls.Add(this.lblRunTime);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpType);
            this.Name = "AddShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Show";
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoOption3;
        private System.Windows.Forms.RadioButton rdoOption2;
        private System.Windows.Forms.RadioButton rdoOption1;
        private System.Windows.Forms.RadioButton rdoHidden2;
        private System.Windows.Forms.RadioButton rdoHidden1;
        private System.Windows.Forms.RadioButton rdoEpisode;
        private System.Windows.Forms.RadioButton rdoMovie;
        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.RadioButton rdoOption4;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtRunTime;
        private System.Windows.Forms.Label lblRunTime;
        private System.Windows.Forms.TextBox txtAgeRating;
        private System.Windows.Forms.Label lblAgeRating;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblOption4;
        private System.Windows.Forms.TextBox txtOption4;
        private System.Windows.Forms.Label lblOption3;
        private System.Windows.Forms.TextBox txtOption3;
        private System.Windows.Forms.Label lblOption2;
        private System.Windows.Forms.TextBox txtOption2;
        private System.Windows.Forms.Label lblOption1;
        private System.Windows.Forms.TextBox txtOption1;
        private System.Windows.Forms.Button btnAddShow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
namespace Mobile_Banking_System
{
    partial class Trigger
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.father_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mother_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gander = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.signature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ac_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opn_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ac_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(823, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Session History";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 306);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.first_name,
            this.last_name,
            this.father_name,
            this.mother_name,
            this.mobile,
            this.email,
            this.nid,
            this.gander,
            this.dob,
            this.address,
            this.photo,
            this.signature,
            this.ac_no,
            this.opn_date,
            this.ac_type,
            this.author,
            this.time});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.Size = new System.Drawing.Size(823, 306);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // first_name
            // 
            this.first_name.HeaderText = "FIRST NAME";
            this.first_name.Name = "first_name";
            this.first_name.ReadOnly = true;
            this.first_name.Width = 150;
            // 
            // last_name
            // 
            this.last_name.HeaderText = "LAST NAME";
            this.last_name.Name = "last_name";
            this.last_name.ReadOnly = true;
            this.last_name.Width = 150;
            // 
            // father_name
            // 
            this.father_name.HeaderText = "FATHER NAME";
            this.father_name.Name = "father_name";
            this.father_name.ReadOnly = true;
            this.father_name.Width = 150;
            // 
            // mother_name
            // 
            this.mother_name.HeaderText = "MOTHER NAME";
            this.mother_name.Name = "mother_name";
            this.mother_name.ReadOnly = true;
            this.mother_name.Width = 150;
            // 
            // mobile
            // 
            this.mobile.HeaderText = "MOBILE";
            this.mobile.Name = "mobile";
            this.mobile.ReadOnly = true;
            this.mobile.Width = 150;
            // 
            // email
            // 
            this.email.HeaderText = "EMAIL";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 150;
            // 
            // nid
            // 
            this.nid.HeaderText = "NID/STUDENT ID";
            this.nid.Name = "nid";
            this.nid.ReadOnly = true;
            this.nid.Width = 150;
            // 
            // gander
            // 
            this.gander.HeaderText = "GANDER";
            this.gander.Name = "gander";
            this.gander.ReadOnly = true;
            this.gander.Width = 150;
            // 
            // dob
            // 
            this.dob.HeaderText = "DATE OF BIRTH";
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            this.dob.Width = 150;
            // 
            // address
            // 
            this.address.HeaderText = "ADDRESS";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 150;
            // 
            // photo
            // 
            this.photo.HeaderText = "PHOTO";
            this.photo.Name = "photo";
            this.photo.ReadOnly = true;
            this.photo.Width = 150;
            // 
            // signature
            // 
            this.signature.HeaderText = "SIGNATURE";
            this.signature.Name = "signature";
            this.signature.ReadOnly = true;
            this.signature.Width = 150;
            // 
            // ac_no
            // 
            this.ac_no.HeaderText = "ACCOUNT NO";
            this.ac_no.Name = "ac_no";
            this.ac_no.ReadOnly = true;
            this.ac_no.Width = 150;
            // 
            // opn_date
            // 
            this.opn_date.HeaderText = "OPENING DATE";
            this.opn_date.Name = "opn_date";
            this.opn_date.ReadOnly = true;
            this.opn_date.Width = 150;
            // 
            // ac_type
            // 
            this.ac_type.HeaderText = "ACCOUNT TYPE";
            this.ac_type.Name = "ac_type";
            this.ac_type.ReadOnly = true;
            this.ac_type.Width = 150;
            // 
            // author
            // 
            this.author.HeaderText = "AUTHOR";
            this.author.Name = "author";
            this.author.ReadOnly = true;
            // 
            // time
            // 
            this.time.HeaderText = "TIME";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // Trigger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Trigger";
            this.Size = new System.Drawing.Size(823, 346);
            this.Load += new System.EventHandler(this.Trigger_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn father_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn mother_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn nid;
        private System.Windows.Forms.DataGridViewTextBoxColumn gander;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn signature;
        private System.Windows.Forms.DataGridViewTextBoxColumn ac_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn opn_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ac_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
    }
}

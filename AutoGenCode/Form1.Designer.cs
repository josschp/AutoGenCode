namespace AutoGenCode
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtProjext = new System.Windows.Forms.TextBox();
            this.btnGenCode = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmbSchemas = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtIPAdd = new System.Windows.Forms.TextBox();
            this.grbTableName = new System.Windows.Forms.GroupBox();
            this.dtgView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbTableName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Information";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtProjext);
            this.groupBox4.Controls.Add(this.btnGenCode);
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Location = new System.Drawing.Point(412, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(450, 80);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Database";
            // 
            // txtProjext
            // 
            this.txtProjext.Location = new System.Drawing.Point(303, 16);
            this.txtProjext.Name = "txtProjext";
            this.txtProjext.PlaceholderText = "Project Name";
            this.txtProjext.Size = new System.Drawing.Size(141, 23);
            this.txtProjext.TabIndex = 3;
            // 
            // btnGenCode
            // 
            this.btnGenCode.Location = new System.Drawing.Point(303, 51);
            this.btnGenCode.Name = "btnGenCode";
            this.btnGenCode.Size = new System.Drawing.Size(141, 23);
            this.btnGenCode.TabIndex = 2;
            this.btnGenCode.Text = "Gen Code";
            this.btnGenCode.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cmbTables);
            this.groupBox7.Location = new System.Drawing.Point(128, 16);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(159, 58);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Tables";
            // 
            // cmbTables
            // 
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Location = new System.Drawing.Point(6, 22);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(145, 23);
            this.cmbTables.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmbSchemas);
            this.groupBox6.Location = new System.Drawing.Point(6, 16);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(116, 58);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Schemas";
            // 
            // cmbSchemas
            // 
            this.cmbSchemas.FormattingEnabled = true;
            this.cmbSchemas.Location = new System.Drawing.Point(6, 22);
            this.cmbSchemas.Name = "cmbSchemas";
            this.cmbSchemas.Size = new System.Drawing.Size(101, 23);
            this.cmbSchemas.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtPass);
            this.groupBox5.Controls.Add(this.txtUsername);
            this.groupBox5.Location = new System.Drawing.Point(209, 14);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(197, 80);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Info";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(6, 45);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PlaceholderText = "Password";
            this.txtPass.Size = new System.Drawing.Size(185, 23);
            this.txtPass.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(6, 16);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(185, 23);
            this.txtUsername.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Location = new System.Drawing.Point(209, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 80);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.PlaceholderText = "Password";
            this.textBox3.Size = new System.Drawing.Size(185, 23);
            this.textBox3.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Username";
            this.textBox2.Size = new System.Drawing.Size(185, 23);
            this.textBox2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.Controls.Add(this.txtIPAdd);
            this.groupBox2.Location = new System.Drawing.Point(6, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 80);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server IP";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 51);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(185, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // txtIPAdd
            // 
            this.txtIPAdd.Location = new System.Drawing.Point(6, 16);
            this.txtIPAdd.Name = "txtIPAdd";
            this.txtIPAdd.PlaceholderText = "IP Address";
            this.txtIPAdd.Size = new System.Drawing.Size(185, 23);
            this.txtIPAdd.TabIndex = 0;
            // 
            // grbTableName
            // 
            this.grbTableName.Controls.Add(this.dtgView);
            this.grbTableName.Location = new System.Drawing.Point(12, 118);
            this.grbTableName.Name = "grbTableName";
            this.grbTableName.Size = new System.Drawing.Size(868, 322);
            this.grbTableName.TabIndex = 1;
            this.grbTableName.TabStop = false;
            this.grbTableName.Text = "groupBox9";
            // 
            // dtgView
            // 
            this.dtgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgView.Location = new System.Drawing.Point(3, 19);
            this.dtgView.Name = "dtgView";
            this.dtgView.RowTemplate.Height = 25;
            this.dtgView.Size = new System.Drawing.Size(862, 300);
            this.dtgView.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 452);
            this.Controls.Add(this.grbTableName);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbTableName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private TextBox textBox3;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private TextBox txtIPAdd;
        private GroupBox groupBox4;
        private GroupBox groupBox7;
        private ComboBox cmbTables;
        private GroupBox groupBox6;
        private ComboBox cmbSchemas;
        private GroupBox groupBox5;
        private TextBox txtPass;
        private TextBox txtUsername;
        private Button btnConnect;
        private GroupBox grbTableName;
        private DataGridView dtgView;
        private TextBox txtProjext;
        private Button btnGenCode;
    }
}
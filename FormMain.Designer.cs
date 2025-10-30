namespace dnevnikApp
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblRole = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout(); 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRole.Location = new System.Drawing.Point(20, 10);
            this.lblRole.Text = "Роль:";   
            this.dataGridView1.Location = new System.Drawing.Point(20, 40);
            this.dataGridView1.Size = new System.Drawing.Size(460, 230);
            this.dataGridView1.AllowUserToAddRows = true;
            this.dataGridView1.AllowUserToDeleteRows = true;           
            this.btnSave.Text = "Сохранить";
            this.btnSave.Location = new System.Drawing.Point(20, 290);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);            
            this.btnExit.Text = "Выход";
            this.btnExit.Location = new System.Drawing.Point(380, 290);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);            
            this.ClientSize = new System.Drawing.Size(500, 340);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронный дневник";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
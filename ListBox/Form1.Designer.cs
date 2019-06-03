namespace ListBox
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.lvView = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chJob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 228);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 12);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "이름 :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(56, 225);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(188, 21);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(56, 252);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(188, 21);
            this.txtAge.TabIndex = 4;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(12, 255);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(37, 12);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "나이 :";
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(56, 279);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(188, 21);
            this.txtJob.TabIndex = 6;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(12, 282);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(37, 12);
            this.lblJob.TabIndex = 5;
            this.lblJob.Text = "직업 :";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(253, 225);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(97, 75);
            this.BtnAdd.TabIndex = 7;
            this.BtnAdd.Text = "추가";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lvView
            // 
            this.lvView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chAge,
            this.chJob});
            this.lvView.FullRowSelect = true;
            this.lvView.GridLines = true;
            this.lvView.Location = new System.Drawing.Point(13, 13);
            this.lvView.Name = "lvView";
            this.lvView.Size = new System.Drawing.Size(337, 206);
            this.lvView.TabIndex = 8;
            this.lvView.UseCompatibleStateImageBehavior = false;
            this.lvView.View = System.Windows.Forms.View.Details;
            this.lvView.SelectedIndexChanged += new System.EventHandler(this.LvView_SelectedIndexChanged);
            // 
            // chName
            // 
            this.chName.Text = "이름";
            this.chName.Width = 120;
            // 
            // chAge
            // 
            this.chAge.Text = "나이";
            this.chAge.Width = 80;
            // 
            // chJob
            // 
            this.chJob.Text = "직업";
            this.chJob.Width = 130;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 304);
            this.Controls.Add(this.lvView);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "리스트 추가";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ListView lvView;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chAge;
        private System.Windows.Forms.ColumnHeader chJob;
    }
}


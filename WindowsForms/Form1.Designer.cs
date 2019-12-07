namespace WindowsForms
{
    partial class FormList
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentList = new System.Windows.Forms.ListView();
            this.add = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.DeleteSelect = new System.Windows.Forms.Button();
            this.DeleteAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentList
            // 
            this.studentList.HideSelection = false;
            this.studentList.Location = new System.Drawing.Point(12, 12);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(460, 283);
            this.studentList.TabIndex = 0;
            this.studentList.UseCompatibleStateImageBehavior = false;
            this.studentList.SelectedIndexChanged += new System.EventHandler(this.studentList_SelectedIndexChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(156, 301);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 1;
            this.add.Text = "新增";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(237, 301);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 2;
            this.Update.Text = "修改";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // DeleteSelect
            // 
            this.DeleteSelect.Location = new System.Drawing.Point(318, 301);
            this.DeleteSelect.Name = "DeleteSelect";
            this.DeleteSelect.Size = new System.Drawing.Size(75, 23);
            this.DeleteSelect.TabIndex = 3;
            this.DeleteSelect.Text = "删除选中";
            this.DeleteSelect.UseVisualStyleBackColor = true;
            this.DeleteSelect.Click += new System.EventHandler(this.DeleteSelect_Click);
            // 
            // DeleteAll
            // 
            this.DeleteAll.Location = new System.Drawing.Point(399, 301);
            this.DeleteAll.Name = "DeleteAll";
            this.DeleteAll.Size = new System.Drawing.Size(75, 23);
            this.DeleteAll.TabIndex = 4;
            this.DeleteAll.Text = "删除所有";
            this.DeleteAll.UseVisualStyleBackColor = true;
            this.DeleteAll.Click += new System.EventHandler(this.DeleteAll_Click);
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(485, 336);
            this.Controls.Add(this.DeleteAll);
            this.Controls.Add(this.DeleteSelect);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.studentList);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "FormList";
            this.Text = "数据管理";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView studentList;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button DeleteSelect;
        private System.Windows.Forms.Button DeleteAll;
    }
}


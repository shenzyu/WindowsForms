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
            this.update = new System.Windows.Forms.Button();
            this.deleteSelect = new System.Windows.Forms.Button();
            this.deleteAll = new System.Windows.Forms.Button();
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
            // update
            // 
            this.update.Location = new System.Drawing.Point(237, 301);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 2;
            this.update.Text = "修改";
            this.update.UseVisualStyleBackColor = true;
            // 
            // deleteSelect
            // 
            this.deleteSelect.Location = new System.Drawing.Point(318, 301);
            this.deleteSelect.Name = "deleteSelect";
            this.deleteSelect.Size = new System.Drawing.Size(75, 23);
            this.deleteSelect.TabIndex = 3;
            this.deleteSelect.Text = "删除选中";
            this.deleteSelect.UseVisualStyleBackColor = true;
            // 
            // deleteAll
            // 
            this.deleteAll.Location = new System.Drawing.Point(399, 301);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(75, 23);
            this.deleteAll.TabIndex = 4;
            this.deleteAll.Text = "删除所有";
            this.deleteAll.UseVisualStyleBackColor = true;
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(485, 336);
            this.Controls.Add(this.deleteAll);
            this.Controls.Add(this.deleteSelect);
            this.Controls.Add(this.update);
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
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button deleteSelect;
        private System.Windows.Forms.Button deleteAll;
    }
}


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
            this.Query = new System.Windows.Forms.Button();
            this.nameSelectLabel = new System.Windows.Forms.Label();
            this.textQueryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentList
            // 
            this.studentList.HideSelection = false;
            this.studentList.Location = new System.Drawing.Point(26, 63);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(460, 283);
            this.studentList.TabIndex = 0;
            this.studentList.UseCompatibleStateImageBehavior = false;
            this.studentList.SelectedIndexChanged += new System.EventHandler(this.studentList_SelectedIndexChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(170, 352);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 1;
            this.add.Text = "新增";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(251, 352);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 2;
            this.Update.Text = "修改";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // DeleteSelect
            // 
            this.DeleteSelect.Location = new System.Drawing.Point(332, 352);
            this.DeleteSelect.Name = "DeleteSelect";
            this.DeleteSelect.Size = new System.Drawing.Size(75, 23);
            this.DeleteSelect.TabIndex = 3;
            this.DeleteSelect.Text = "删除选中";
            this.DeleteSelect.UseVisualStyleBackColor = true;
            this.DeleteSelect.Click += new System.EventHandler(this.DeleteSelect_Click);
            // 
            // DeleteAll
            // 
            this.DeleteAll.Location = new System.Drawing.Point(413, 352);
            this.DeleteAll.Name = "DeleteAll";
            this.DeleteAll.Size = new System.Drawing.Size(75, 23);
            this.DeleteAll.TabIndex = 4;
            this.DeleteAll.Text = "删除所有";
            this.DeleteAll.UseVisualStyleBackColor = true;
            this.DeleteAll.Click += new System.EventHandler(this.DeleteAll_Click);
            // 
            // Query
            // 
            this.Query.Location = new System.Drawing.Point(332, 24);
            this.Query.Name = "Query";
            this.Query.Size = new System.Drawing.Size(75, 23);
            this.Query.TabIndex = 5;
            this.Query.Text = "查询";
            this.Query.UseVisualStyleBackColor = true;
            this.Query.Click += new System.EventHandler(this.Query_Click);
            // 
            // nameSelectLabel
            // 
            this.nameSelectLabel.AutoSize = true;
            this.nameSelectLabel.Location = new System.Drawing.Point(24, 27);
            this.nameSelectLabel.Name = "nameSelectLabel";
            this.nameSelectLabel.Size = new System.Drawing.Size(29, 12);
            this.nameSelectLabel.TabIndex = 6;
            this.nameSelectLabel.Text = "姓名";
            // 
            // textQueryName
            // 
            this.textQueryName.Location = new System.Drawing.Point(59, 24);
            this.textQueryName.Name = "textQueryName";
            this.textQueryName.Size = new System.Drawing.Size(100, 21);
            this.textQueryName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "性别";
            // 
            // sexComboBox
            // 
            this.sexComboBox.CausesValidation = false;
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "男",
            "女"});
            this.sexComboBox.Location = new System.Drawing.Point(206, 24);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(121, 20);
            this.sexComboBox.TabIndex = 9;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(413, 24);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 10;
            this.Reset.Text = "重置";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(498, 396);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.sexComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textQueryName);
            this.Controls.Add(this.nameSelectLabel);
            this.Controls.Add(this.Query);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView studentList;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button DeleteSelect;
        private System.Windows.Forms.Button DeleteAll;
        private System.Windows.Forms.Button Query;
        private System.Windows.Forms.Label nameSelectLabel;
        private System.Windows.Forms.TextBox textQueryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.Button Reset;
    }
}


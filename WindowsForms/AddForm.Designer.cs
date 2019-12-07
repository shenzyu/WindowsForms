using System.ComponentModel;

namespace WindowsForms
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.nameLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.palceLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.placeText = new System.Windows.Forms.TextBox();
            this.men = new System.Windows.Forms.RadioButton();
            this.women = new System.Windows.Forms.RadioButton();
            this.addDate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(27, 19);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(86, 16);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "姓名：";
            // 
            // sexLabel
            // 
            this.sexLabel.Location = new System.Drawing.Point(27, 43);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(46, 16);
            this.sexLabel.TabIndex = 0;
            this.sexLabel.Text = "性别：";
            // 
            // palceLabel
            // 
            this.palceLabel.Location = new System.Drawing.Point(27, 94);
            this.palceLabel.Name = "palceLabel";
            this.palceLabel.Size = new System.Drawing.Size(86, 16);
            this.palceLabel.TabIndex = 0;
            this.palceLabel.Text = "籍贯：";
            // 
            // phoneLabel
            // 
            this.phoneLabel.Location = new System.Drawing.Point(27, 67);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(86, 16);
            this.phoneLabel.TabIndex = 0;
            this.phoneLabel.Text = "电话：";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(60, 17);
            this.nameText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(137, 21);
            this.nameText.TabIndex = 1;
            // 
            // phoneText
            // 
            this.phoneText.CausesValidation = false;
            this.phoneText.Location = new System.Drawing.Point(60, 65);
            this.phoneText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(137, 21);
            this.phoneText.TabIndex = 1;
            // 
            // placeText
            // 
            this.placeText.CausesValidation = false;
            this.placeText.Location = new System.Drawing.Point(60, 92);
            this.placeText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.placeText.Name = "placeText";
            this.placeText.Size = new System.Drawing.Size(137, 21);
            this.placeText.TabIndex = 1;
            // 
            // men
            // 
            this.men.Location = new System.Drawing.Point(60, 40);
            this.men.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.men.Name = "men";
            this.men.Size = new System.Drawing.Size(89, 17);
            this.men.TabIndex = 2;
            this.men.TabStop = true;
            this.men.Text = "男";
            this.men.UseVisualStyleBackColor = true;
            // 
            // women
            // 
            this.women.Location = new System.Drawing.Point(107, 40);
            this.women.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.women.Name = "women";
            this.women.Size = new System.Drawing.Size(89, 17);
            this.women.TabIndex = 2;
            this.women.TabStop = true;
            this.women.Text = "女";
            this.women.UseVisualStyleBackColor = true;
            // 
            // addDate
            // 
            this.addDate.Location = new System.Drawing.Point(29, 131);
            this.addDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addDate.Name = "addDate";
            this.addDate.Size = new System.Drawing.Size(64, 23);
            this.addDate.TabIndex = 3;
            this.addDate.Text = "确认";
            this.addDate.UseVisualStyleBackColor = true;
            this.addDate.Click += new System.EventHandler(this.AddDate_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(132, 131);
            this.clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(64, 23);
            this.clear.TabIndex = 3;
            this.clear.Text = "清除";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.CausesValidation = false;
            this.Id.Location = new System.Drawing.Point(105, 136);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(17, 12);
            this.Id.TabIndex = 4;
            this.Id.Text = "Id";
            this.Id.Visible = false;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 189);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.addDate);
            this.Controls.Add(this.women);
            this.Controls.Add(this.men);
            this.Controls.Add(this.placeText);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.palceLabel);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "AddForm";
            this.Text = "新增";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button addDate;
        private System.Windows.Forms.RadioButton women;
        private System.Windows.Forms.RadioButton men;
        private System.Windows.Forms.TextBox placeText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label palceLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label Id;
    }
}
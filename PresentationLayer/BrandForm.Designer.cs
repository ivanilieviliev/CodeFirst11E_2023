
namespace PresentationLayer
{
    partial class BrandForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.phoneTxtBox = new System.Windows.Forms.TextBox();
            this.addressTxtBox = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.brandsDataGridView = new System.Windows.Forms.DataGridView();
            this.clearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.brandsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(96, 26);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(217, 31);
            this.nameTxtBox.TabIndex = 4;
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Location = new System.Drawing.Point(96, 90);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(217, 31);
            this.emailTxtBox.TabIndex = 5;
            // 
            // phoneTxtBox
            // 
            this.phoneTxtBox.Location = new System.Drawing.Point(96, 153);
            this.phoneTxtBox.Name = "phoneTxtBox";
            this.phoneTxtBox.Size = new System.Drawing.Size(217, 31);
            this.phoneTxtBox.TabIndex = 6;
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.Location = new System.Drawing.Point(96, 212);
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.Size = new System.Drawing.Size(217, 31);
            this.addressTxtBox.TabIndex = 7;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(83, 292);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(112, 34);
            this.createBtn.TabIndex = 8;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(201, 292);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(112, 34);
            this.updateBtn.TabIndex = 9;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(349, 292);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(112, 34);
            this.deleteBtn.TabIndex = 10;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(827, 292);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(112, 34);
            this.closeBtn.TabIndex = 12;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Brands";
            // 
            // brandsDataGridView
            // 
            this.brandsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brandsDataGridView.Location = new System.Drawing.Point(349, 63);
            this.brandsDataGridView.Name = "brandsDataGridView";
            this.brandsDataGridView.RowHeadersWidth = 62;
            this.brandsDataGridView.RowTemplate.Height = 33;
            this.brandsDataGridView.Size = new System.Drawing.Size(590, 214);
            this.brandsDataGridView.TabIndex = 13;
            this.brandsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.brandsDataGridView_CellClick);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(709, 292);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(112, 34);
            this.clearBtn.TabIndex = 11;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // BrandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 450);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.brandsDataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.addressTxtBox);
            this.Controls.Add(this.phoneTxtBox);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BrandForm";
            this.Text = "Brands Form";
            ((System.ComponentModel.ISupportInitialize)(this.brandsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.TextBox phoneTxtBox;
        private System.Windows.Forms.TextBox addressTxtBox;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView brandsDataGridView;
        private System.Windows.Forms.Button clearBtn;
    }
}
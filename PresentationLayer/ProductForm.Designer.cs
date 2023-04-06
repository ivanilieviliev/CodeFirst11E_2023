
namespace PresentationLayer
{
    partial class ProductForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.barcodeTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.quantityBox = new System.Windows.Forms.NumericUpDown();
            this.priceBox = new System.Windows.Forms.NumericUpDown();
            this.brandsListBox = new System.Windows.Forms.ListBox();
            this.bestBeforeBox = new System.Windows.Forms.DateTimePicker();
            this.createBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barcode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Brand";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Best Before";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Products";
            // 
            // barcodeTxtBox
            // 
            this.barcodeTxtBox.Location = new System.Drawing.Point(130, 30);
            this.barcodeTxtBox.Name = "barcodeTxtBox";
            this.barcodeTxtBox.Size = new System.Drawing.Size(184, 31);
            this.barcodeTxtBox.TabIndex = 7;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(130, 69);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(184, 31);
            this.nameTxtBox.TabIndex = 8;
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(130, 111);
            this.quantityBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(184, 31);
            this.quantityBox.TabIndex = 9;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(130, 151);
            this.priceBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(184, 31);
            this.priceBox.TabIndex = 10;
            // 
            // brandsListBox
            // 
            this.brandsListBox.FormattingEnabled = true;
            this.brandsListBox.ItemHeight = 25;
            this.brandsListBox.Location = new System.Drawing.Point(134, 209);
            this.brandsListBox.Name = "brandsListBox";
            this.brandsListBox.Size = new System.Drawing.Size(180, 129);
            this.brandsListBox.TabIndex = 11;
            this.brandsListBox.SelectedIndexChanged += new System.EventHandler(this.brandsListBox_SelectedIndexChanged);
            // 
            // bestBeforeBox
            // 
            this.bestBeforeBox.Location = new System.Drawing.Point(134, 349);
            this.bestBeforeBox.Name = "bestBeforeBox";
            this.bestBeforeBox.Size = new System.Drawing.Size(180, 31);
            this.bestBeforeBox.TabIndex = 12;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(84, 404);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(112, 34);
            this.createBtn.TabIndex = 13;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(202, 404);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(112, 34);
            this.updateBtn.TabIndex = 14;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(367, 444);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(112, 34);
            this.deleteBtn.TabIndex = 15;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(143, 444);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(112, 34);
            this.clearBtn.TabIndex = 16;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(532, 444);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(112, 34);
            this.closeBtn.TabIndex = 17;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(367, 89);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowHeadersWidth = 62;
            this.productsDataGridView.RowTemplate.Height = 33;
            this.productsDataGridView.Size = new System.Drawing.Size(645, 349);
            this.productsDataGridView.TabIndex = 18;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 506);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.bestBeforeBox);
            this.Controls.Add(this.brandsListBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.barcodeTxtBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox barcodeTxtBox;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.NumericUpDown quantityBox;
        private System.Windows.Forms.NumericUpDown priceBox;
        private System.Windows.Forms.ListBox brandsListBox;
        private System.Windows.Forms.DateTimePicker bestBeforeBox;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.DataGridView productsDataGridView;
    }
}
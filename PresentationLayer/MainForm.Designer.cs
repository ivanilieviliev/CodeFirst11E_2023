
namespace PresentationLayer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.brandBtn = new System.Windows.Forms.Button();
            this.productBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.brandsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // brandBtn
            // 
            this.brandBtn.Location = new System.Drawing.Point(249, 114);
            this.brandBtn.Name = "brandBtn";
            this.brandBtn.Size = new System.Drawing.Size(112, 34);
            this.brandBtn.TabIndex = 0;
            this.brandBtn.Text = "Brands";
            this.brandBtn.UseVisualStyleBackColor = true;
            this.brandBtn.Click += new System.EventHandler(this.brandBtn_Click);
            this.brandBtn.MouseEnter += new System.EventHandler(this.brandBtn_MouseEnter);
            this.brandBtn.MouseLeave += new System.EventHandler(this.CustomMethod);
            this.brandBtn.MouseHover += new System.EventHandler(this.brandBtn_MouseHover);
            // 
            // productBtn
            // 
            this.productBtn.Location = new System.Drawing.Point(475, 114);
            this.productBtn.Name = "productBtn";
            this.productBtn.Size = new System.Drawing.Size(112, 34);
            this.productBtn.TabIndex = 1;
            this.productBtn.Text = "Products";
            this.productBtn.UseVisualStyleBackColor = true;
            this.productBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(366, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(249, 276);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 34);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(475, 276);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 34);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // brandsToolTip
            // 
            this.brandsToolTip.ToolTipTitle = "Title";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.productBtn);
            this.Controls.Add(this.brandBtn);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button brandBtn;
        private System.Windows.Forms.Button productBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolTip brandsToolTip;
    }
}


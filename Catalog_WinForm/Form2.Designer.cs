namespace Catalog_WinForm
{
    partial class productForm
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
            label1 = new Label();
            productNameTxtBox = new TextBox();
            label2 = new Label();
            originTxtBox = new TextBox();
            label3 = new Label();
            productCostTxtBox = new TextBox();
            okButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 34);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 0;
            label1.Text = "Product Name:";
            // 
            // productNameTxtBox
            // 
            productNameTxtBox.Location = new Point(24, 73);
            productNameTxtBox.Multiline = true;
            productNameTxtBox.Name = "productNameTxtBox";
            productNameTxtBox.Size = new Size(244, 37);
            productNameTxtBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 134);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 2;
            label2.Text = "Origin Country:";
            // 
            // originTxtBox
            // 
            originTxtBox.Location = new Point(24, 178);
            originTxtBox.Multiline = true;
            originTxtBox.Name = "originTxtBox";
            originTxtBox.Size = new Size(244, 37);
            originTxtBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 241);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 4;
            label3.Text = "Product Cost:";
            // 
            // productCostTxtBox
            // 
            productCostTxtBox.Location = new Point(24, 285);
            productCostTxtBox.Multiline = true;
            productCostTxtBox.Name = "productCostTxtBox";
            productCostTxtBox.Size = new Size(244, 37);
            productCostTxtBox.TabIndex = 5;
            // 
            // okButton
            // 
            okButton.Location = new Point(24, 369);
            okButton.Name = "okButton";
            okButton.Size = new Size(96, 34);
            okButton.TabIndex = 6;
            okButton.Text = "Ok";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(172, 369);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(96, 34);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // productForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 450);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(productCostTxtBox);
            Controls.Add(label3);
            Controls.Add(originTxtBox);
            Controls.Add(label2);
            Controls.Add(productNameTxtBox);
            Controls.Add(label1);
            Name = "productForm";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox productNameTxtBox;
        private Label label2;
        private TextBox originTxtBox;
        private Label label3;
        private TextBox productCostTxtBox;
        private Button okButton;
        private Button cancelButton;
    }
}
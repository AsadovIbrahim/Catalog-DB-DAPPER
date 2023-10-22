namespace Catalog_WinForm
{
    partial class Form1
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
            listBox = new ListBox();
            addProductButton = new Button();
            editProductButton = new Button();
            removeProductButton = new Button();
            clearProductButton = new Button();
            SuspendLayout();
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 25;
            listBox.Location = new Point(12, 13);
            listBox.Name = "listBox";
            listBox.Size = new Size(414, 429);
            listBox.TabIndex = 0;
            // 
            // addProductButton
            // 
            addProductButton.Location = new Point(12, 464);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(414, 36);
            addProductButton.TabIndex = 1;
            addProductButton.Text = "Add Product";
            addProductButton.UseVisualStyleBackColor = true;
            addProductButton.Click += addProductButton_Click;
            // 
            // editProductButton
            // 
            editProductButton.Location = new Point(12, 506);
            editProductButton.Name = "editProductButton";
            editProductButton.Size = new Size(414, 36);
            editProductButton.TabIndex = 2;
            editProductButton.Text = "Edit Product";
            editProductButton.UseVisualStyleBackColor = true;
            editProductButton.Click += editProductButton_Click;
            // 
            // removeProductButton
            // 
            removeProductButton.Location = new Point(12, 548);
            removeProductButton.Name = "removeProductButton";
            removeProductButton.Size = new Size(414, 36);
            removeProductButton.TabIndex = 3;
            removeProductButton.Text = "Remove Product";
            removeProductButton.UseVisualStyleBackColor = true;
            removeProductButton.Click += removeProductButton_Click;
            // 
            // clearProductButton
            // 
            clearProductButton.Location = new Point(12, 590);
            clearProductButton.Name = "clearProductButton";
            clearProductButton.Size = new Size(414, 36);
            clearProductButton.TabIndex = 4;
            clearProductButton.Text = "Clear List";
            clearProductButton.UseVisualStyleBackColor = true;
            clearProductButton.Click += clearProductButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 638);
            Controls.Add(clearProductButton);
            Controls.Add(removeProductButton);
            Controls.Add(editProductButton);
            Controls.Add(addProductButton);
            Controls.Add(listBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox;
        private Button addProductButton;
        private Button editProductButton;
        private Button removeProductButton;
        private Button clearProductButton;
    }
}
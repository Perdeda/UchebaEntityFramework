namespace Tasks
{
    partial class Form2
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addingButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inspectButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.numLabel = new System.Windows.Forms.Label();
            this.adminAddButton = new System.Windows.Forms.Button();
            this.adminDeleteButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.cartRemoveButton = new System.Windows.Forms.Button();
            this.wareIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // addingButton
            // 
            this.addingButton.Location = new System.Drawing.Point(117, 321);
            this.addingButton.Name = "addingButton";
            this.addingButton.Size = new System.Drawing.Size(75, 23);
            this.addingButton.TabIndex = 1;
            this.addingButton.Text = "Add to cart";
            this.addingButton.UseVisualStyleBackColor = true;
            this.addingButton.Click += new System.EventHandler(this.addingButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(221, 321);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(175, 25);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Paintings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cart";
            // 
            // inspectButton
            // 
            this.inspectButton.Location = new System.Drawing.Point(12, 321);
            this.inspectButton.Name = "inspectButton";
            this.inspectButton.Size = new System.Drawing.Size(75, 23);
            this.inspectButton.TabIndex = 6;
            this.inspectButton.Text = "Inspect";
            this.inspectButton.UseVisualStyleBackColor = true;
            this.inspectButton.Click += new System.EventHandler(this.inspectButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Amount";
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(168, 292);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(24, 23);
            this.plusButton.TabIndex = 8;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(117, 292);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(24, 23);
            this.minusButton.TabIndex = 9;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Location = new System.Drawing.Point(149, 300);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(13, 13);
            this.numLabel.TabIndex = 10;
            this.numLabel.Text = "1";
            // 
            // adminAddButton
            // 
            this.adminAddButton.Location = new System.Drawing.Point(12, 81);
            this.adminAddButton.Name = "adminAddButton";
            this.adminAddButton.Size = new System.Drawing.Size(75, 23);
            this.adminAddButton.TabIndex = 11;
            this.adminAddButton.Text = "Add an item";
            this.adminAddButton.UseVisualStyleBackColor = true;
            this.adminAddButton.Click += new System.EventHandler(this.adminAddButton_Click);
            // 
            // adminDeleteButton
            // 
            this.adminDeleteButton.Location = new System.Drawing.Point(12, 52);
            this.adminDeleteButton.Name = "adminDeleteButton";
            this.adminDeleteButton.Size = new System.Drawing.Size(95, 23);
            this.adminDeleteButton.TabIndex = 12;
            this.adminDeleteButton.Text = "Remove an item";
            this.adminDeleteButton.UseVisualStyleBackColor = true;
            this.adminDeleteButton.Click += new System.EventHandler(this.adminDeleteButton_Click);
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(12, 292);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(75, 23);
            this.buyButton.TabIndex = 13;
            this.buyButton.Text = "Purchase";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // cartRemoveButton
            // 
            this.cartRemoveButton.Location = new System.Drawing.Point(175, 52);
            this.cartRemoveButton.Name = "cartRemoveButton";
            this.cartRemoveButton.Size = new System.Drawing.Size(99, 23);
            this.cartRemoveButton.TabIndex = 14;
            this.cartRemoveButton.Text = "Remove from cart";
            this.cartRemoveButton.UseVisualStyleBackColor = true;
            this.cartRemoveButton.Click += new System.EventHandler(this.cartRemoveButton_Click);
            // 
            // wareIDLabel
            // 
            this.wareIDLabel.AutoSize = true;
            this.wareIDLabel.Location = new System.Drawing.Point(139, 33);
            this.wareIDLabel.Name = "wareIDLabel";
            this.wareIDLabel.Size = new System.Drawing.Size(13, 13);
            this.wareIDLabel.TabIndex = 15;
            this.wareIDLabel.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 356);
            this.Controls.Add(this.wareIDLabel);
            this.Controls.Add(this.cartRemoveButton);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.adminDeleteButton);
            this.Controls.Add(this.adminAddButton);
            this.Controls.Add(this.numLabel);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inspectButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addingButton);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button addingButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button inspectButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.Button adminAddButton;
        private System.Windows.Forms.Button adminDeleteButton;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button cartRemoveButton;
        private System.Windows.Forms.Label wareIDLabel;
    }
}
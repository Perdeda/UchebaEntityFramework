namespace Tasks
{
    partial class Inspect
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.artistLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DesctriptLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(13, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(67, 26);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "name";
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.artistLabel.Location = new System.Drawing.Point(15, 39);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(59, 26);
            this.artistLabel.TabIndex = 2;
            this.artistLabel.Text = "artist";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "picture";
            // 
            // DesctriptLabel
            // 
            this.DesctriptLabel.AutoSize = true;
            this.DesctriptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DesctriptLabel.Location = new System.Drawing.Point(15, 65);
            this.DesctriptLabel.Name = "DesctriptLabel";
            this.DesctriptLabel.Size = new System.Drawing.Size(117, 26);
            this.DesctriptLabel.TabIndex = 5;
            this.DesctriptLabel.Text = "description";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(15, 117);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(59, 26);
            this.priceLabel.TabIndex = 6;
            this.priceLabel.Text = "price";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idLabel.Location = new System.Drawing.Point(12, 287);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(29, 26);
            this.idLabel.TabIndex = 7;
            this.idLabel.Text = "id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inspect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 318);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.DesctriptLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "Inspect";
            this.Text = "Inspect";
            this.Load += new System.EventHandler(this.Inspect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DesctriptLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button button1;
    }
}
namespace MyFlix
{
    partial class MyFlixForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyFlixForm));
            this.movieListBox = new System.Windows.Forms.ListBox();
            this.calButton = new System.Windows.Forms.Button();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.displayTotalLabel = new System.Windows.Forms.Label();
            this.guideLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // movieListBox
            // 
            this.movieListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.movieListBox.FormattingEnabled = true;
            this.movieListBox.ItemHeight = 20;
            this.movieListBox.Items.AddRange(new object[] {
            "The Green Mile",
            "Pulp Fiction",
            "Casablanca",
            "The Shawshank Redemption",
            "Contact",
            "Good Will Hunting"});
            this.movieListBox.Location = new System.Drawing.Point(12, 74);
            this.movieListBox.Name = "movieListBox";
            this.movieListBox.Size = new System.Drawing.Size(225, 144);
            this.movieListBox.TabIndex = 0;
            this.movieListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // calButton
            // 
            this.calButton.Location = new System.Drawing.Point(12, 224);
            this.calButton.Name = "calButton";
            this.calButton.Size = new System.Drawing.Size(225, 41);
            this.calButton.TabIndex = 1;
            this.calButton.Text = "Calculate Price";
            this.calButton.UseVisualStyleBackColor = true;
            this.calButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.totalCostLabel.Location = new System.Drawing.Point(12, 277);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(85, 20);
            this.totalCostLabel.TabIndex = 2;
            this.totalCostLabel.Text = "Total Cost:";
            this.totalCostLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // displayTotalLabel
            // 
            this.displayTotalLabel.AutoSize = true;
            this.displayTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.displayTotalLabel.Location = new System.Drawing.Point(129, 277);
            this.displayTotalLabel.Name = "displayTotalLabel";
            this.displayTotalLabel.Size = new System.Drawing.Size(49, 20);
            this.displayTotalLabel.TabIndex = 3;
            this.displayTotalLabel.Text = "$0.00";
            this.displayTotalLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // guideLabel
            // 
            this.guideLabel.AutoSize = true;
            this.guideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.guideLabel.Location = new System.Drawing.Point(12, 25);
            this.guideLabel.Name = "guideLabel";
            this.guideLabel.Size = new System.Drawing.Size(242, 20);
            this.guideLabel.TabIndex = 4;
            this.guideLabel.Text = "Hold ctrl to select multiple movies";
            // 
            // MyFlixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(299, 364);
            this.Controls.Add(this.guideLabel);
            this.Controls.Add(this.displayTotalLabel);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.calButton);
            this.Controls.Add(this.movieListBox);
            this.Name = "MyFlixForm";
            this.Text = "MyFlix";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox movieListBox;
        private System.Windows.Forms.Button calButton;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label displayTotalLabel;
        private System.Windows.Forms.Label guideLabel;
    }
}


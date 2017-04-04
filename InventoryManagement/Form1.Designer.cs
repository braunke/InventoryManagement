namespace InventoryManagement
{
    partial class Form1
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
            this.Options = new System.Windows.Forms.ListBox();
            this.groupBoxItems = new System.Windows.Forms.GroupBox();
            this.rdoShoes = new System.Windows.Forms.RadioButton();
            this.rdoPants = new System.Windows.Forms.RadioButton();
            this.rdoShirts = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBoxItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // Options
            // 
            this.Options.FormattingEnabled = true;
            this.Options.Location = new System.Drawing.Point(21, 133);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(151, 95);
            this.Options.TabIndex = 0;
            // 
            // groupBoxItems
            // 
            this.groupBoxItems.Controls.Add(this.rdoShoes);
            this.groupBoxItems.Controls.Add(this.rdoPants);
            this.groupBoxItems.Controls.Add(this.rdoShirts);
            this.groupBoxItems.Location = new System.Drawing.Point(21, 13);
            this.groupBoxItems.Name = "groupBoxItems";
            this.groupBoxItems.Size = new System.Drawing.Size(96, 100);
            this.groupBoxItems.TabIndex = 1;
            this.groupBoxItems.TabStop = false;
            this.groupBoxItems.Text = "Items";
            // 
            // rdoShoes
            // 
            this.rdoShoes.AutoSize = true;
            this.rdoShoes.Location = new System.Drawing.Point(7, 68);
            this.rdoShoes.Name = "rdoShoes";
            this.rdoShoes.Size = new System.Drawing.Size(55, 17);
            this.rdoShoes.TabIndex = 2;
            this.rdoShoes.TabStop = true;
            this.rdoShoes.Text = "Shoes";
            this.rdoShoes.UseVisualStyleBackColor = true;
            this.rdoShoes.CheckedChanged += new System.EventHandler(this.ClickRadioButton);
            // 
            // rdoPants
            // 
            this.rdoPants.AutoSize = true;
            this.rdoPants.Location = new System.Drawing.Point(7, 44);
            this.rdoPants.Name = "rdoPants";
            this.rdoPants.Size = new System.Drawing.Size(52, 17);
            this.rdoPants.TabIndex = 1;
            this.rdoPants.TabStop = true;
            this.rdoPants.Text = "Pants";
            this.rdoPants.UseVisualStyleBackColor = true;
            this.rdoPants.CheckedChanged += new System.EventHandler(this.ClickRadioButton);
            // 
            // rdoShirts
            // 
            this.rdoShirts.AutoSize = true;
            this.rdoShirts.Location = new System.Drawing.Point(7, 20);
            this.rdoShirts.Name = "rdoShirts";
            this.rdoShirts.Size = new System.Drawing.Size(51, 17);
            this.rdoShirts.TabIndex = 0;
            this.rdoShirts.TabStop = true;
            this.rdoShirts.Text = "Shirts";
            this.rdoShirts.UseVisualStyleBackColor = true;
            this.rdoShirts.CheckedChanged += new System.EventHandler(this.ClickRadioButton);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(197, 141);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add +1";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(197, 199);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(197, 170);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(98, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove -1";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InventoryManagement.Properties.Resources.Boxes_Background_Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(318, 284);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBoxItems);
            this.Controls.Add(this.Options);
            this.Name = "Form1";
            this.Text = "Inventory Management";
            this.groupBoxItems.ResumeLayout(false);
            this.groupBoxItems.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Options;
        private System.Windows.Forms.GroupBox groupBoxItems;
        private System.Windows.Forms.RadioButton rdoShoes;
        private System.Windows.Forms.RadioButton rdoPants;
        private System.Windows.Forms.RadioButton rdoShirts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemove;
    }
}


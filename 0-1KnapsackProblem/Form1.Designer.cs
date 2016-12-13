namespace _0_1KnapsackProblem
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
            this.lvInserted = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvTable = new System.Windows.Forms.ListView();
            this.lvSelectedItems = new System.Windows.Forms.ListView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txbVariable = new System.Windows.Forms.TextBox();
            this.txbValue = new System.Windows.Forms.TextBox();
            this.txbWeight = new System.Windows.Forms.TextBox();
            this.txbCapacity = new System.Windows.Forms.TextBox();
            this.lblVariable = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lblMaxValue = new System.Windows.Forms.Label();
            this.lblMaxWeight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvInserted
            // 
            this.lvInserted.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvInserted.Location = new System.Drawing.Point(159, 27);
            this.lvInserted.Name = "lvInserted";
            this.lvInserted.Size = new System.Drawing.Size(187, 122);
            this.lvInserted.TabIndex = 0;
            this.lvInserted.UseCompatibleStateImageBehavior = false;
            this.lvInserted.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Variable";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Weight";
            // 
            // lvTable
            // 
            this.lvTable.Location = new System.Drawing.Point(352, 27);
            this.lvTable.Name = "lvTable";
            this.lvTable.Size = new System.Drawing.Size(559, 332);
            this.lvTable.TabIndex = 1;
            this.lvTable.UseCompatibleStateImageBehavior = false;
            // 
            // lvSelectedItems
            // 
            this.lvSelectedItems.Location = new System.Drawing.Point(159, 206);
            this.lvSelectedItems.Name = "lvSelectedItems";
            this.lvSelectedItems.Size = new System.Drawing.Size(121, 153);
            this.lvSelectedItems.TabIndex = 2;
            this.lvSelectedItems.UseCompatibleStateImageBehavior = false;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(53, 116);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 23);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(53, 206);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txbVariable
            // 
            this.txbVariable.Location = new System.Drawing.Point(53, 27);
            this.txbVariable.Name = "txbVariable";
            this.txbVariable.Size = new System.Drawing.Size(100, 20);
            this.txbVariable.TabIndex = 6;
            // 
            // txbValue
            // 
            this.txbValue.Location = new System.Drawing.Point(53, 53);
            this.txbValue.Name = "txbValue";
            this.txbValue.Size = new System.Drawing.Size(100, 20);
            this.txbValue.TabIndex = 7;
            // 
            // txbWeight
            // 
            this.txbWeight.Location = new System.Drawing.Point(53, 79);
            this.txbWeight.Name = "txbWeight";
            this.txbWeight.Size = new System.Drawing.Size(100, 20);
            this.txbWeight.TabIndex = 8;
            // 
            // txbCapacity
            // 
            this.txbCapacity.Location = new System.Drawing.Point(53, 180);
            this.txbCapacity.Name = "txbCapacity";
            this.txbCapacity.Size = new System.Drawing.Size(100, 20);
            this.txbCapacity.TabIndex = 9;
            // 
            // lblVariable
            // 
            this.lblVariable.AutoSize = true;
            this.lblVariable.Location = new System.Drawing.Point(-1, 30);
            this.lblVariable.Name = "lblVariable";
            this.lblVariable.Size = new System.Drawing.Size(48, 13);
            this.lblVariable.TabIndex = 10;
            this.lblVariable.Text = "Variable:";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(-1, 60);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(37, 13);
            this.lblValue.TabIndex = 11;
            this.lblValue.Text = "Value:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(-1, 86);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(44, 13);
            this.lblWeight.TabIndex = 12;
            this.lblWeight.Text = "Weight:";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(-1, 183);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(51, 13);
            this.lblCapacity.TabIndex = 13;
            this.lblCapacity.Text = "Capacity:";
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(200, 152);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(95, 13);
            this.lblSelected.TabIndex = 14;
            this.lblSelected.Text = "Selected Variables";
            // 
            // lblMaxValue
            // 
            this.lblMaxValue.AutoSize = true;
            this.lblMaxValue.Location = new System.Drawing.Point(159, 180);
            this.lblMaxValue.Name = "lblMaxValue";
            this.lblMaxValue.Size = new System.Drawing.Size(0, 13);
            this.lblMaxValue.TabIndex = 15;
            // 
            // lblMaxWeight
            // 
            this.lblMaxWeight.AutoSize = true;
            this.lblMaxWeight.Location = new System.Drawing.Point(261, 180);
            this.lblMaxWeight.Name = "lblMaxWeight";
            this.lblMaxWeight.Size = new System.Drawing.Size(0, 13);
            this.lblMaxWeight.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 385);
            this.Controls.Add(this.lblMaxWeight);
            this.Controls.Add(this.lblMaxValue);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblVariable);
            this.Controls.Add(this.txbCapacity);
            this.Controls.Add(this.txbWeight);
            this.Controls.Add(this.txbValue);
            this.Controls.Add(this.txbVariable);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lvSelectedItems);
            this.Controls.Add(this.lvTable);
            this.Controls.Add(this.lvInserted);
            this.Name = "Form1";
            this.Text = "0-1 Knapsack Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvInserted;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lvTable;
        private System.Windows.Forms.ListView lvSelectedItems;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txbVariable;
        private System.Windows.Forms.TextBox txbValue;
        private System.Windows.Forms.TextBox txbWeight;
        private System.Windows.Forms.TextBox txbCapacity;
        private System.Windows.Forms.Label lblVariable;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Label lblMaxValue;
        private System.Windows.Forms.Label lblMaxWeight;
    }
}


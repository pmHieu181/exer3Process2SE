namespace Process2
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lblAgent = new System.Windows.Forms.Label();
            this.comboAgent = new System.Windows.Forms.ComboBox();
            this.dataGridViewOrderDetails = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.lblFilterItemName = new System.Windows.Forms.Label();
            this.lblFilterSize = new System.Windows.Forms.Label();
            this.txtFilterItemName = new System.Windows.Forms.TextBox();
            this.txtFilterSize = new System.Windows.Forms.TextBox();
            this.btnFilterItems = new System.Windows.Forms.Button();
            this.btnTopPurchasedItems = new System.Windows.Forms.Button();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnShowBestItems = new System.Windows.Forms.Button();
            this.dataGridViewBestItems = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnShowPurchasedItems = new System.Windows.Forms.Button();
            this.dataGridViewPurchasedItems = new System.Windows.Forms.DataGridView();
            this.lbl = new System.Windows.Forms.Label();
            this.btnShowCustomerPurchases = new System.Windows.Forms.Button();
            this.dataGridViewCustomerPurchases = new System.Windows.Forms.DataGridView();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBestItems)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchasedItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerPurchases)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(78, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(472, 328);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAddItem);
            this.tabPage1.Controls.Add(this.txtSize);
            this.tabPage1.Controls.Add(this.txtItemName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(464, 302);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Item";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSaveOrder);
            this.tabPage2.Controls.Add(this.dataGridViewOrderDetails);
            this.tabPage2.Controls.Add(this.comboAgent);
            this.tabPage2.Controls.Add(this.lblAgent);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(464, 302);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Order";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewReport);
            this.tabPage3.Controls.Add(this.btnGenerateReport);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(464, 302);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Report";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridViewItems);
            this.tabPage4.Controls.Add(this.btnTopPurchasedItems);
            this.tabPage4.Controls.Add(this.btnFilterItems);
            this.tabPage4.Controls.Add(this.txtFilterSize);
            this.tabPage4.Controls.Add(this.txtFilterItemName);
            this.tabPage4.Controls.Add(this.lblFilterSize);
            this.tabPage4.Controls.Add(this.lblFilterItemName);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(464, 302);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Filter";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Size";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(140, 42);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(100, 20);
            this.txtItemName.TabIndex = 2;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(140, 112);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 20);
            this.txtSize.TabIndex = 3;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(53, 169);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lblAgent
            // 
            this.lblAgent.AutoSize = true;
            this.lblAgent.Location = new System.Drawing.Point(15, 14);
            this.lblAgent.Name = "lblAgent";
            this.lblAgent.Size = new System.Drawing.Size(35, 13);
            this.lblAgent.TabIndex = 0;
            this.lblAgent.Text = "Agent";
            // 
            // comboAgent
            // 
            this.comboAgent.FormattingEnabled = true;
            this.comboAgent.Location = new System.Drawing.Point(137, 14);
            this.comboAgent.Name = "comboAgent";
            this.comboAgent.Size = new System.Drawing.Size(121, 21);
            this.comboAgent.TabIndex = 1;
            // 
            // dataGridViewOrderDetails
            // 
            this.dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.Quantity,
            this.UnitAmount});
            this.dataGridViewOrderDetails.Location = new System.Drawing.Point(18, 57);
            this.dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
            this.dataGridViewOrderDetails.Size = new System.Drawing.Size(343, 150);
            this.dataGridViewOrderDetails.TabIndex = 2;
            this.dataGridViewOrderDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrderDetails_CellContentClick);
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.Name = "ItemID";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // UnitAmount
            // 
            this.UnitAmount.HeaderText = "UnitAmount";
            this.UnitAmount.Name = "UnitAmount";
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Location = new System.Drawing.Point(18, 214);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(75, 23);
            this.btnSaveOrder.TabIndex = 3;
            this.btnSaveOrder.Text = "SaveOrder";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(21, 24);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(107, 31);
            this.btnGenerateReport.TabIndex = 0;
            this.btnGenerateReport.Text = "GenerateReport";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Location = new System.Drawing.Point(21, 61);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewReport.TabIndex = 1;
            // 
            // lblFilterItemName
            // 
            this.lblFilterItemName.AutoSize = true;
            this.lblFilterItemName.Location = new System.Drawing.Point(26, 17);
            this.lblFilterItemName.Name = "lblFilterItemName";
            this.lblFilterItemName.Size = new System.Drawing.Size(77, 13);
            this.lblFilterItemName.TabIndex = 0;
            this.lblFilterItemName.Text = "FilterItemName";
            // 
            // lblFilterSize
            // 
            this.lblFilterSize.AutoSize = true;
            this.lblFilterSize.Location = new System.Drawing.Point(26, 79);
            this.lblFilterSize.Name = "lblFilterSize";
            this.lblFilterSize.Size = new System.Drawing.Size(49, 13);
            this.lblFilterSize.TabIndex = 1;
            this.lblFilterSize.Text = "FilterSize";
            // 
            // txtFilterItemName
            // 
            this.txtFilterItemName.Location = new System.Drawing.Point(125, 14);
            this.txtFilterItemName.Name = "txtFilterItemName";
            this.txtFilterItemName.Size = new System.Drawing.Size(100, 20);
            this.txtFilterItemName.TabIndex = 2;
            // 
            // txtFilterSize
            // 
            this.txtFilterSize.Location = new System.Drawing.Point(125, 79);
            this.txtFilterSize.Name = "txtFilterSize";
            this.txtFilterSize.Size = new System.Drawing.Size(100, 20);
            this.txtFilterSize.TabIndex = 3;
            // 
            // btnFilterItems
            // 
            this.btnFilterItems.Location = new System.Drawing.Point(281, 14);
            this.btnFilterItems.Name = "btnFilterItems";
            this.btnFilterItems.Size = new System.Drawing.Size(75, 32);
            this.btnFilterItems.TabIndex = 4;
            this.btnFilterItems.Text = "FilterItems";
            this.btnFilterItems.UseVisualStyleBackColor = true;
            this.btnFilterItems.Click += new System.EventHandler(this.btnFilterItems_Click);
            // 
            // btnTopPurchasedItems
            // 
            this.btnTopPurchasedItems.Location = new System.Drawing.Point(281, 79);
            this.btnTopPurchasedItems.Name = "btnTopPurchasedItems";
            this.btnTopPurchasedItems.Size = new System.Drawing.Size(123, 32);
            this.btnTopPurchasedItems.TabIndex = 5;
            this.btnTopPurchasedItems.Text = "TopPurchasedItems";
            this.btnTopPurchasedItems.UseVisualStyleBackColor = true;
            this.btnTopPurchasedItems.Click += new System.EventHandler(this.btnTopPurchasedItems_Click);
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Location = new System.Drawing.Point(29, 146);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewItems.TabIndex = 6;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridViewBestItems);
            this.tabPage5.Controls.Add(this.btnShowBestItems);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(464, 302);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "BestItem";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnShowBestItems
            // 
            this.btnShowBestItems.Location = new System.Drawing.Point(29, 17);
            this.btnShowBestItems.Name = "btnShowBestItems";
            this.btnShowBestItems.Size = new System.Drawing.Size(75, 23);
            this.btnShowBestItems.TabIndex = 0;
            this.btnShowBestItems.Text = "Show";
            this.btnShowBestItems.UseVisualStyleBackColor = true;
            this.btnShowBestItems.Click += new System.EventHandler(this.btnShowBestItems_Click);
            // 
            // dataGridViewBestItems
            // 
            this.dataGridViewBestItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBestItems.Location = new System.Drawing.Point(29, 46);
            this.dataGridViewBestItems.Name = "dataGridViewBestItems";
            this.dataGridViewBestItems.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewBestItems.TabIndex = 1;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dataGridViewPurchasedItems);
            this.tabPage6.Controls.Add(this.btnShowPurchasedItems);
            this.tabPage6.Controls.Add(this.txtCustomerName);
            this.tabPage6.Controls.Add(this.label3);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(464, 302);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "PurchasedItem";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.txtCustomerID);
            this.tabPage7.Controls.Add(this.dataGridViewCustomerPurchases);
            this.tabPage7.Controls.Add(this.btnShowCustomerPurchases);
            this.tabPage7.Controls.Add(this.lbl);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(464, 302);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "CustomerPurchase";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Customer";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(150, 43);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerName.TabIndex = 1;
            // 
            // btnShowPurchasedItems
            // 
            this.btnShowPurchasedItems.Location = new System.Drawing.Point(66, 251);
            this.btnShowPurchasedItems.Name = "btnShowPurchasedItems";
            this.btnShowPurchasedItems.Size = new System.Drawing.Size(75, 23);
            this.btnShowPurchasedItems.TabIndex = 2;
            this.btnShowPurchasedItems.Text = "Show";
            this.btnShowPurchasedItems.UseVisualStyleBackColor = true;
            this.btnShowPurchasedItems.Click += new System.EventHandler(this.btnShowPurchasedItems_Click);
            // 
            // dataGridViewPurchasedItems
            // 
            this.dataGridViewPurchasedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchasedItems.Location = new System.Drawing.Point(66, 87);
            this.dataGridViewPurchasedItems.Name = "dataGridViewPurchasedItems";
            this.dataGridViewPurchasedItems.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewPurchasedItems.TabIndex = 3;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(25, 7);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(62, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "CustomerID";
            // 
            // btnShowCustomerPurchases
            // 
            this.btnShowCustomerPurchases.Location = new System.Drawing.Point(28, 262);
            this.btnShowCustomerPurchases.Name = "btnShowCustomerPurchases";
            this.btnShowCustomerPurchases.Size = new System.Drawing.Size(75, 23);
            this.btnShowCustomerPurchases.TabIndex = 1;
            this.btnShowCustomerPurchases.Text = "Show";
            this.btnShowCustomerPurchases.UseVisualStyleBackColor = true;
            this.btnShowCustomerPurchases.Click += new System.EventHandler(this.btnShowCustomerPurchases_Click);
            // 
            // dataGridViewCustomerPurchases
            // 
            this.dataGridViewCustomerPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomerPurchases.Location = new System.Drawing.Point(28, 32);
            this.dataGridViewCustomerPurchases.Name = "dataGridViewCustomerPurchases";
            this.dataGridViewCustomerPurchases.Size = new System.Drawing.Size(346, 224);
            this.dataGridViewCustomerPurchases.TabIndex = 2;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(109, 6);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerID.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBestItems)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchasedItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerPurchases)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridViewOrderDetails;
        private System.Windows.Forms.ComboBox comboAgent;
        private System.Windows.Forms.Label lblAgent;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitAmount;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Button btnTopPurchasedItems;
        private System.Windows.Forms.Button btnFilterItems;
        private System.Windows.Forms.TextBox txtFilterSize;
        private System.Windows.Forms.TextBox txtFilterItemName;
        private System.Windows.Forms.Label lblFilterSize;
        private System.Windows.Forms.Label lblFilterItemName;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridViewBestItems;
        private System.Windows.Forms.Button btnShowBestItems;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView dataGridViewPurchasedItems;
        private System.Windows.Forms.Button btnShowPurchasedItems;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.DataGridView dataGridViewCustomerPurchases;
        private System.Windows.Forms.Button btnShowCustomerPurchases;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtCustomerID;
    }
}


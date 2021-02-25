
namespace ClearspendingClient
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabContracts = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contractsTextBox = new System.Windows.Forms.TextBox();
            this.contractsComboBox = new System.Windows.Forms.ComboBox();
            this.tabGrants = new System.Windows.Forms.TabPage();
            this.grantsComboBox = new System.Windows.Forms.ComboBox();
            this.grantsTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.customersTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.customersComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabSuppliers = new System.Windows.Forms.TabPage();
            this.suppliersTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.suppliersComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabStatistics = new System.Windows.Forms.TabPage();
            this.hintTextBox = new System.Windows.Forms.TextBox();
            this.executeButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabContracts.SuspendLayout();
            this.tabGrants.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            this.tabSuppliers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabContracts);
            this.tabControl.Controls.Add(this.tabGrants);
            this.tabControl.Controls.Add(this.tabCustomers);
            this.tabControl.Controls.Add(this.tabSuppliers);
            this.tabControl.Controls.Add(this.tabStatistics);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(424, 222);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabContracts
            // 
            this.tabContracts.Controls.Add(this.label2);
            this.tabContracts.Controls.Add(this.label1);
            this.tabContracts.Controls.Add(this.contractsTextBox);
            this.tabContracts.Controls.Add(this.contractsComboBox);
            this.tabContracts.Location = new System.Drawing.Point(4, 29);
            this.tabContracts.Name = "tabContracts";
            this.tabContracts.Padding = new System.Windows.Forms.Padding(3);
            this.tabContracts.Size = new System.Drawing.Size(416, 189);
            this.tabContracts.TabIndex = 0;
            this.tabContracts.Text = "Контракты";
            this.tabContracts.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Параметры запроса";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Тип запроса";
            // 
            // contractsTextBox
            // 
            this.contractsTextBox.Location = new System.Drawing.Point(19, 131);
            this.contractsTextBox.Name = "contractsTextBox";
            this.contractsTextBox.Size = new System.Drawing.Size(380, 27);
            this.contractsTextBox.TabIndex = 1;
            // 
            // contractsComboBox
            // 
            this.contractsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contractsComboBox.FormattingEnabled = true;
            this.contractsComboBox.Items.AddRange(new object[] {
            "Получение полного контракта по идентификатору",
            "Полнотекстовый поиск по контрактам",
            "Выборка по контрактам"});
            this.contractsComboBox.Location = new System.Drawing.Point(19, 56);
            this.contractsComboBox.Name = "contractsComboBox";
            this.contractsComboBox.Size = new System.Drawing.Size(380, 28);
            this.contractsComboBox.TabIndex = 0;
            this.contractsComboBox.SelectedIndexChanged += new System.EventHandler(this.contractsComboBox_SelectedIndexChanged);
            // 
            // tabGrants
            // 
            this.tabGrants.Controls.Add(this.grantsComboBox);
            this.tabGrants.Controls.Add(this.grantsTextBox);
            this.tabGrants.Controls.Add(this.label8);
            this.tabGrants.Controls.Add(this.label3);
            this.tabGrants.Location = new System.Drawing.Point(4, 29);
            this.tabGrants.Name = "tabGrants";
            this.tabGrants.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrants.Size = new System.Drawing.Size(416, 319);
            this.tabGrants.TabIndex = 1;
            this.tabGrants.Text = "Гранты";
            this.tabGrants.UseVisualStyleBackColor = true;
            // 
            // grantsComboBox
            // 
            this.grantsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grantsComboBox.FormattingEnabled = true;
            this.grantsComboBox.Items.AddRange(new object[] {
            "Получение полной информации о гранте по идентификатору",
            "Полнотекстовый поиск по грантам",
            "Выборка по грантам"});
            this.grantsComboBox.Location = new System.Drawing.Point(19, 56);
            this.grantsComboBox.Name = "grantsComboBox";
            this.grantsComboBox.Size = new System.Drawing.Size(380, 28);
            this.grantsComboBox.TabIndex = 8;
            this.grantsComboBox.SelectedIndexChanged += new System.EventHandler(this.grantsComboBox_SelectedIndexChanged);
            // 
            // grantsTextBox
            // 
            this.grantsTextBox.Location = new System.Drawing.Point(19, 131);
            this.grantsTextBox.Name = "grantsTextBox";
            this.grantsTextBox.Size = new System.Drawing.Size(380, 27);
            this.grantsTextBox.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Параметры запроса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Тип запроса";
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.customersTextBox);
            this.tabCustomers.Controls.Add(this.label9);
            this.tabCustomers.Controls.Add(this.customersComboBox);
            this.tabCustomers.Controls.Add(this.label4);
            this.tabCustomers.Location = new System.Drawing.Point(4, 29);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Size = new System.Drawing.Size(416, 319);
            this.tabCustomers.TabIndex = 2;
            this.tabCustomers.Text = "Заказчики";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // customersTextBox
            // 
            this.customersTextBox.Location = new System.Drawing.Point(19, 131);
            this.customersTextBox.Name = "customersTextBox";
            this.customersTextBox.Size = new System.Drawing.Size(380, 27);
            this.customersTextBox.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Параметры запроса";
            // 
            // customersComboBox
            // 
            this.customersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customersComboBox.FormattingEnabled = true;
            this.customersComboBox.Items.AddRange(new object[] {
            "Получение информации о заказчике по идентификатору",
            "Полнотекстовый поиск по заказчикам",
            "Выборка по заказчикам"});
            this.customersComboBox.Location = new System.Drawing.Point(19, 56);
            this.customersComboBox.Name = "customersComboBox";
            this.customersComboBox.Size = new System.Drawing.Size(380, 28);
            this.customersComboBox.TabIndex = 5;
            this.customersComboBox.SelectedIndexChanged += new System.EventHandler(this.customersComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Тип запроса";
            // 
            // tabSuppliers
            // 
            this.tabSuppliers.Controls.Add(this.suppliersTextBox);
            this.tabSuppliers.Controls.Add(this.label10);
            this.tabSuppliers.Controls.Add(this.suppliersComboBox);
            this.tabSuppliers.Controls.Add(this.label5);
            this.tabSuppliers.Location = new System.Drawing.Point(4, 29);
            this.tabSuppliers.Name = "tabSuppliers";
            this.tabSuppliers.Size = new System.Drawing.Size(416, 319);
            this.tabSuppliers.TabIndex = 3;
            this.tabSuppliers.Text = "Поставщики";
            this.tabSuppliers.UseVisualStyleBackColor = true;
            // 
            // suppliersTextBox
            // 
            this.suppliersTextBox.Location = new System.Drawing.Point(19, 131);
            this.suppliersTextBox.Name = "suppliersTextBox";
            this.suppliersTextBox.Size = new System.Drawing.Size(380, 27);
            this.suppliersTextBox.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Параметры запроса";
            // 
            // suppliersComboBox
            // 
            this.suppliersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suppliersComboBox.FormattingEnabled = true;
            this.suppliersComboBox.Items.AddRange(new object[] {
            "Получение информации о поставщике по идентификатору",
            "Полнотекстовый поиск по поставщикам",
            "Выборка по поставщикам"});
            this.suppliersComboBox.Location = new System.Drawing.Point(19, 56);
            this.suppliersComboBox.Name = "suppliersComboBox";
            this.suppliersComboBox.Size = new System.Drawing.Size(380, 28);
            this.suppliersComboBox.TabIndex = 5;
            this.suppliersComboBox.SelectedIndexChanged += new System.EventHandler(this.suppliersComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Тип запроса";
            // 
            // tabStatistics
            // 
            this.tabStatistics.Location = new System.Drawing.Point(4, 29);
            this.tabStatistics.Name = "tabStatistics";
            this.tabStatistics.Size = new System.Drawing.Size(416, 319);
            this.tabStatistics.TabIndex = 5;
            this.tabStatistics.Text = "Статистика";
            this.tabStatistics.UseVisualStyleBackColor = true;
            // 
            // hintTextBox
            // 
            this.hintTextBox.Location = new System.Drawing.Point(442, 12);
            this.hintTextBox.Multiline = true;
            this.hintTextBox.Name = "hintTextBox";
            this.hintTextBox.ReadOnly = true;
            this.hintTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.hintTextBox.Size = new System.Drawing.Size(415, 271);
            this.hintTextBox.TabIndex = 1;
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(149, 251);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(130, 32);
            this.executeButton.TabIndex = 2;
            this.executeButton.Text = "Выполнить";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 301);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.hintTextBox);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Clearspending API";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabContracts.ResumeLayout(false);
            this.tabContracts.PerformLayout();
            this.tabGrants.ResumeLayout(false);
            this.tabGrants.PerformLayout();
            this.tabCustomers.ResumeLayout(false);
            this.tabCustomers.PerformLayout();
            this.tabSuppliers.ResumeLayout(false);
            this.tabSuppliers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabContracts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contractsTextBox;
        private System.Windows.Forms.ComboBox contractsComboBox;
        private System.Windows.Forms.TabPage tabGrants;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.TabPage tabSuppliers;
        private System.Windows.Forms.TabPage tabStatistics;
        private System.Windows.Forms.TextBox hintTextBox;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox suppliersTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox suppliersComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox grantsComboBox;
        private System.Windows.Forms.TextBox grantsTextBox;
        private System.Windows.Forms.TextBox customersTextBox;
        private System.Windows.Forms.ComboBox customersComboBox;
    }
}
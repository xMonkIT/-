using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace lab6
{
    partial class frmBuyers
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvBuys = new System.Windows.Forms.DataGridView();
            this.lAvg = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bSelectBuys = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bSelectClients = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbMerchendise = new System.Windows.Forms.ComboBox();
            this.lbClients = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lBiggestMerchendiseClient = new System.Windows.Forms.Label();
            this.bSelectBiggestMerchendiseClient = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lCountWithDiscount = new System.Windows.Forms.Label();
            this.bSelectClientsWithDiscount = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuys)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Создать из модели Buyers.edmx локальную БД (Создать базу Buyers, сгенерировать" +
    " скрипты, запустить)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(444, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. Привязать модель к БД (в App.config поменять data source на имя своего сервера" +
    ")";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(405, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "3. Запустить приложение (должны сгенерироваться записи во всех таблицах)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(454, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "4. Написать запросы и вывести результат в ListBox или другой подходящий компонент" +
    ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(384, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "- Выбрать всех клиентов, купивших определенный товар (например, хлеб)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(341, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "- Показать количество клиентов, получивших скидку 10% и более";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(331, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "- Выбрать все покупки с суммой выше средней суммы покупки";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(344, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "- Найти клиента, совершившего самую крупную по сумме покупку";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 196);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 271);
            this.panel2.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(754, 271);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvBuys);
            this.panel6.Controls.Add(this.lAvg);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.bSelectBuys);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(379, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(372, 265);
            this.panel6.TabIndex = 7;
            // 
            // dgvBuys
            // 
            this.dgvBuys.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBuys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBuys.Location = new System.Drawing.Point(0, 106);
            this.dgvBuys.Name = "dgvBuys";
            this.dgvBuys.RowHeadersVisible = false;
            this.dgvBuys.Size = new System.Drawing.Size(372, 159);
            this.dgvBuys.TabIndex = 11;
            // 
            // lAvg
            // 
            this.lAvg.Dock = System.Windows.Forms.DockStyle.Top;
            this.lAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lAvg.Location = new System.Drawing.Point(0, 60);
            this.lAvg.Name = "lAvg";
            this.lAvg.Size = new System.Drawing.Size(372, 46);
            this.lAvg.TabIndex = 10;
            this.lAvg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label10.Location = new System.Drawing.Point(0, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(372, 37);
            this.label10.TabIndex = 9;
            this.label10.Text = "Средняя сумма покупки";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bSelectBuys
            // 
            this.bSelectBuys.Dock = System.Windows.Forms.DockStyle.Top;
            this.bSelectBuys.Location = new System.Drawing.Point(0, 0);
            this.bSelectBuys.Name = "bSelectBuys";
            this.bSelectBuys.Size = new System.Drawing.Size(372, 23);
            this.bSelectBuys.TabIndex = 3;
            this.bSelectBuys.Text = "Выбрать покупки";
            this.bSelectBuys.UseVisualStyleBackColor = true;
            this.bSelectBuys.Click += new System.EventHandler(this.bSelectBuys_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bSelectClients);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.cbMerchendise);
            this.panel3.Controls.Add(this.lbClients);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 265);
            this.panel3.TabIndex = 0;
            // 
            // bSelectClients
            // 
            this.bSelectClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSelectClients.Location = new System.Drawing.Point(61, 43);
            this.bSelectClients.Name = "bSelectClients";
            this.bSelectClients.Size = new System.Drawing.Size(118, 23);
            this.bSelectClients.TabIndex = 3;
            this.bSelectClients.Text = "Выбрать клиентов";
            this.bSelectClients.UseVisualStyleBackColor = true;
            this.bSelectClients.Click += new System.EventHandler(this.bSelectClients_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Выберите товар:";
            // 
            // cbMerchendise
            // 
            this.cbMerchendise.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMerchendise.FormattingEnabled = true;
            this.cbMerchendise.Location = new System.Drawing.Point(3, 16);
            this.cbMerchendise.Name = "cbMerchendise";
            this.cbMerchendise.Size = new System.Drawing.Size(176, 21);
            this.cbMerchendise.TabIndex = 1;
            // 
            // lbClients
            // 
            this.lbClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbClients.FormattingEnabled = true;
            this.lbClients.Location = new System.Drawing.Point(3, 72);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(176, 186);
            this.lbClients.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(191, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(182, 265);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lBiggestMerchendiseClient);
            this.panel5.Controls.Add(this.bSelectBiggestMerchendiseClient);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 135);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(176, 127);
            this.panel5.TabIndex = 12;
            // 
            // lBiggestMerchendiseClient
            // 
            this.lBiggestMerchendiseClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBiggestMerchendiseClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lBiggestMerchendiseClient.Location = new System.Drawing.Point(0, 80);
            this.lBiggestMerchendiseClient.Name = "lBiggestMerchendiseClient";
            this.lBiggestMerchendiseClient.Size = new System.Drawing.Size(176, 47);
            this.lBiggestMerchendiseClient.TabIndex = 10;
            this.lBiggestMerchendiseClient.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bSelectBiggestMerchendiseClient
            // 
            this.bSelectBiggestMerchendiseClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.bSelectBiggestMerchendiseClient.Location = new System.Drawing.Point(0, 57);
            this.bSelectBiggestMerchendiseClient.Name = "bSelectBiggestMerchendiseClient";
            this.bSelectBiggestMerchendiseClient.Size = new System.Drawing.Size(176, 23);
            this.bSelectBiggestMerchendiseClient.TabIndex = 9;
            this.bSelectBiggestMerchendiseClient.Text = "Выбрать клиентa";
            this.bSelectBiggestMerchendiseClient.UseVisualStyleBackColor = true;
            this.bSelectBiggestMerchendiseClient.Click += new System.EventHandler(this.bSelectBiggestMerchendiseClient_Click);
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 57);
            this.label12.TabIndex = 7;
            this.label12.Text = "Клиент, совершивший самую крупную по сумме покупку";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lCountWithDiscount);
            this.panel4.Controls.Add(this.bSelectClientsWithDiscount);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(176, 126);
            this.panel4.TabIndex = 11;
            // 
            // lCountWithDiscount
            // 
            this.lCountWithDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lCountWithDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lCountWithDiscount.Location = new System.Drawing.Point(0, 80);
            this.lCountWithDiscount.Name = "lCountWithDiscount";
            this.lCountWithDiscount.Size = new System.Drawing.Size(176, 46);
            this.lCountWithDiscount.TabIndex = 7;
            this.lCountWithDiscount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bSelectClientsWithDiscount
            // 
            this.bSelectClientsWithDiscount.Dock = System.Windows.Forms.DockStyle.Top;
            this.bSelectClientsWithDiscount.Location = new System.Drawing.Point(0, 57);
            this.bSelectClientsWithDiscount.Name = "bSelectClientsWithDiscount";
            this.bSelectClientsWithDiscount.Size = new System.Drawing.Size(176, 23);
            this.bSelectClientsWithDiscount.TabIndex = 6;
            this.bSelectClientsWithDiscount.Text = "Выбрать клиентов";
            this.bSelectClientsWithDiscount.UseVisualStyleBackColor = true;
            this.bSelectClientsWithDiscount.Click += new System.EventHandler(this.bSelectClientsWithDiscount_Click);
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 57);
            this.label11.TabIndex = 0;
            this.label11.Text = "Количество клиентов, получивших скидку 10% и более";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBuyers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 467);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBuyers";
            this.Text = "Лабораторная по запросам LINQ";
            this.Load += new System.EventHandler(this.frmBuyers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuys)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel panel1;
        private Panel panel2;
        private ListBox lbClients;
        private ComboBox cbMerchendise;
        private Label label9;
        private Button bSelectClients;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Panel panel6;
        private Button bSelectBuys;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel5;
        private Label lBiggestMerchendiseClient;
        private Button bSelectBiggestMerchendiseClient;
        private Label label12;
        private Panel panel4;
        private Label lCountWithDiscount;
        private Button bSelectClientsWithDiscount;
        private Label label11;
        private DataGridView dgvBuys;
        private Label lAvg;
        private Label label10;
    }
}


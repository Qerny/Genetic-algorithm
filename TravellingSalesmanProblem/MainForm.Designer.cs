namespace TravellingSalesmanProblem
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
            this.dtGrdVwCitiesMatrix = new System.Windows.Forms.DataGridView();
            this.nmrcCountCities = new System.Windows.Forms.NumericUpDown();
            this.btnRandMatr = new System.Windows.Forms.Button();
            this.lblGenAlg = new System.Windows.Forms.Label();
            this.lblExhaustive = new System.Windows.Forms.Label();
            this.lblCountGen = new System.Windows.Forms.Label();
            this.nmrcCountGen = new System.Windows.Forms.NumericUpDown();
            this.lblCountChildrenInGen = new System.Windows.Forms.Label();
            this.nmrcCountChildren = new System.Windows.Forms.NumericUpDown();
            this.lblShortestPathLen = new System.Windows.Forms.Label();
            this.txtBxPathLenGen = new System.Windows.Forms.TextBox();
            this.txtBxPathLenExh = new System.Windows.Forms.TextBox();
            this.btnFindPath = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtBxTimeGen = new System.Windows.Forms.TextBox();
            this.txtBxTimeExh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nmrcFreqMut = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwCitiesMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcCountCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcCountGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcCountChildren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcFreqMut)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrdVwCitiesMatrix
            // 
            this.dtGrdVwCitiesMatrix.AllowUserToAddRows = false;
            this.dtGrdVwCitiesMatrix.AllowUserToDeleteRows = false;
            this.dtGrdVwCitiesMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGrdVwCitiesMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwCitiesMatrix.Location = new System.Drawing.Point(16, 15);
            this.dtGrdVwCitiesMatrix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtGrdVwCitiesMatrix.Name = "dtGrdVwCitiesMatrix";
            this.dtGrdVwCitiesMatrix.Size = new System.Drawing.Size(528, 402);
            this.dtGrdVwCitiesMatrix.TabIndex = 0;
            this.dtGrdVwCitiesMatrix.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdVwCitiesMatrix_CellEndEdit);
            this.dtGrdVwCitiesMatrix.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdVwCitiesMatrix_CellValueChanged);
            // 
            // nmrcCountCities
            // 
            this.nmrcCountCities.Location = new System.Drawing.Point(141, 431);
            this.nmrcCountCities.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmrcCountCities.Name = "nmrcCountCities";
            this.nmrcCountCities.Size = new System.Drawing.Size(81, 22);
            this.nmrcCountCities.TabIndex = 1;
            this.nmrcCountCities.ValueChanged += new System.EventHandler(this.nmrcCountCities_ValueChanged);
            this.nmrcCountCities.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nmrcCountCities_KeyPress);
            // 
            // btnRandMatr
            // 
            this.btnRandMatr.Location = new System.Drawing.Point(272, 431);
            this.btnRandMatr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRandMatr.Name = "btnRandMatr";
            this.btnRandMatr.Size = new System.Drawing.Size(161, 28);
            this.btnRandMatr.TabIndex = 2;
            this.btnRandMatr.Text = "Случайное заполнение";
            this.btnRandMatr.UseVisualStyleBackColor = true;
            this.btnRandMatr.Click += new System.EventHandler(this.btnRandMatr_Click);
            // 
            // lblGenAlg
            // 
            this.lblGenAlg.AutoSize = true;
            this.lblGenAlg.Location = new System.Drawing.Point(716, 267);
            this.lblGenAlg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenAlg.Name = "lblGenAlg";
            this.lblGenAlg.Size = new System.Drawing.Size(166, 17);
            this.lblGenAlg.TabIndex = 3;
            this.lblGenAlg.Text = "Генетический алгоритм";
            // 
            // lblExhaustive
            // 
            this.lblExhaustive.AutoSize = true;
            this.lblExhaustive.Location = new System.Drawing.Point(922, 267);
            this.lblExhaustive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExhaustive.Name = "lblExhaustive";
            this.lblExhaustive.Size = new System.Drawing.Size(66, 17);
            this.lblExhaustive.TabIndex = 4;
            this.lblExhaustive.Text = "Перебор";
            // 
            // lblCountGen
            // 
            this.lblCountGen.AutoSize = true;
            this.lblCountGen.Location = new System.Drawing.Point(579, 91);
            this.lblCountGen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountGen.Name = "lblCountGen";
            this.lblCountGen.Size = new System.Drawing.Size(136, 17);
            this.lblCountGen.TabIndex = 6;
            this.lblCountGen.Text = "Кол-во поколений: ";
            // 
            // nmrcCountGen
            // 
            this.nmrcCountGen.Location = new System.Drawing.Point(817, 86);
            this.nmrcCountGen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmrcCountGen.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrcCountGen.Name = "nmrcCountGen";
            this.nmrcCountGen.Size = new System.Drawing.Size(112, 22);
            this.nmrcCountGen.TabIndex = 7;
            // 
            // lblCountChildrenInGen
            // 
            this.lblCountChildrenInGen.AutoSize = true;
            this.lblCountChildrenInGen.Location = new System.Drawing.Point(579, 128);
            this.lblCountChildrenInGen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountChildrenInGen.Name = "lblCountChildrenInGen";
            this.lblCountChildrenInGen.Size = new System.Drawing.Size(198, 17);
            this.lblCountChildrenInGen.TabIndex = 8;
            this.lblCountChildrenInGen.Text = "Кол-во особей в поколении: ";
            // 
            // nmrcCountChildren
            // 
            this.nmrcCountChildren.Location = new System.Drawing.Point(817, 126);
            this.nmrcCountChildren.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmrcCountChildren.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrcCountChildren.Name = "nmrcCountChildren";
            this.nmrcCountChildren.Size = new System.Drawing.Size(112, 22);
            this.nmrcCountChildren.TabIndex = 9;
            // 
            // lblShortestPathLen
            // 
            this.lblShortestPathLen.AutoSize = true;
            this.lblShortestPathLen.Location = new System.Drawing.Point(588, 303);
            this.lblShortestPathLen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShortestPathLen.Name = "lblShortestPathLen";
            this.lblShortestPathLen.Size = new System.Drawing.Size(93, 17);
            this.lblShortestPathLen.TabIndex = 12;
            this.lblShortestPathLen.Text = "Длина пути: ";
            // 
            // txtBxPathLenGen
            // 
            this.txtBxPathLenGen.Location = new System.Drawing.Point(718, 300);
            this.txtBxPathLenGen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxPathLenGen.Name = "txtBxPathLenGen";
            this.txtBxPathLenGen.Size = new System.Drawing.Size(117, 22);
            this.txtBxPathLenGen.TabIndex = 13;
            // 
            // txtBxPathLenExh
            // 
            this.txtBxPathLenExh.Location = new System.Drawing.Point(905, 298);
            this.txtBxPathLenExh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxPathLenExh.Name = "txtBxPathLenExh";
            this.txtBxPathLenExh.Size = new System.Drawing.Size(117, 22);
            this.txtBxPathLenExh.TabIndex = 14;
            // 
            // btnFindPath
            // 
            this.btnFindPath.Location = new System.Drawing.Point(272, 473);
            this.btnFindPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFindPath.Name = "btnFindPath";
            this.btnFindPath.Size = new System.Drawing.Size(161, 28);
            this.btnFindPath.TabIndex = 15;
            this.btnFindPath.Text = "Найти путь";
            this.btnFindPath.UseVisualStyleBackColor = true;
            this.btnFindPath.Click += new System.EventHandler(this.btnFindPath_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(588, 340);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(88, 17);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = "Время (мс): ";
            // 
            // txtBxTimeGen
            // 
            this.txtBxTimeGen.Location = new System.Drawing.Point(719, 340);
            this.txtBxTimeGen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxTimeGen.Name = "txtBxTimeGen";
            this.txtBxTimeGen.Size = new System.Drawing.Size(117, 22);
            this.txtBxTimeGen.TabIndex = 17;
            // 
            // txtBxTimeExh
            // 
            this.txtBxTimeExh.Location = new System.Drawing.Point(905, 340);
            this.txtBxTimeExh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxTimeExh.Name = "txtBxTimeExh";
            this.txtBxTimeExh.Size = new System.Drawing.Size(117, 22);
            this.txtBxTimeExh.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(579, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Частота мутаций:";
            // 
            // nmrcFreqMut
            // 
            this.nmrcFreqMut.DecimalPlaces = 2;
            this.nmrcFreqMut.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nmrcFreqMut.Location = new System.Drawing.Point(817, 165);
            this.nmrcFreqMut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmrcFreqMut.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrcFreqMut.Name = "nmrcFreqMut";
            this.nmrcFreqMut.Size = new System.Drawing.Size(112, 22);
            this.nmrcFreqMut.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 433);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Кол-во городов:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 530);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmrcFreqMut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxTimeExh);
            this.Controls.Add(this.txtBxTimeGen);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnFindPath);
            this.Controls.Add(this.txtBxPathLenExh);
            this.Controls.Add(this.txtBxPathLenGen);
            this.Controls.Add(this.lblShortestPathLen);
            this.Controls.Add(this.nmrcCountChildren);
            this.Controls.Add(this.lblCountChildrenInGen);
            this.Controls.Add(this.nmrcCountGen);
            this.Controls.Add(this.lblCountGen);
            this.Controls.Add(this.lblExhaustive);
            this.Controls.Add(this.lblGenAlg);
            this.Controls.Add(this.btnRandMatr);
            this.Controls.Add(this.nmrcCountCities);
            this.Controls.Add(this.dtGrdVwCitiesMatrix);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Задача комивояжера";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwCitiesMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcCountCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcCountGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcCountChildren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcFreqMut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrdVwCitiesMatrix;
        private System.Windows.Forms.NumericUpDown nmrcCountCities;
        private System.Windows.Forms.Button btnRandMatr;
        private System.Windows.Forms.Label lblGenAlg;
        private System.Windows.Forms.Label lblExhaustive;
        private System.Windows.Forms.Label lblCountGen;
        private System.Windows.Forms.NumericUpDown nmrcCountGen;
        private System.Windows.Forms.Label lblCountChildrenInGen;
        private System.Windows.Forms.NumericUpDown nmrcCountChildren;
        private System.Windows.Forms.Label lblShortestPathLen;
        private System.Windows.Forms.TextBox txtBxPathLenGen;
        private System.Windows.Forms.TextBox txtBxPathLenExh;
        private System.Windows.Forms.Button btnFindPath;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtBxTimeGen;
        private System.Windows.Forms.TextBox txtBxTimeExh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmrcFreqMut;
        private System.Windows.Forms.Label label2;
    }
}


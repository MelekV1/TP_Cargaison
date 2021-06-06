namespace TP1
{
    partial class CargaisonUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargaisonUI));
            this.Cargaison = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonAddCargaison = new System.Windows.Forms.Button();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewMarchandise = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRemoveMarchandise = new System.Windows.Forms.Button();
            this.buttonAddMarchandise = new System.Windows.Forms.Button();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.textBoxVolume = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPoids = new System.Windows.Forms.TextBox();
            this.costBox = new System.Windows.Forms.GroupBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonRemoveCargaison = new System.Windows.Forms.Button();
            this.Cargaison.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarchandise)).BeginInit();
            this.costBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cargaison
            // 
            this.Cargaison.Controls.Add(this.buttonRemoveCargaison);
            this.Cargaison.Controls.Add(this.listBox1);
            this.Cargaison.Controls.Add(this.buttonAddCargaison);
            this.Cargaison.Controls.Add(this.textBoxDistance);
            this.Cargaison.Controls.Add(this.comboBoxType);
            this.Cargaison.Controls.Add(this.label2);
            this.Cargaison.Controls.Add(this.label1);
            this.Cargaison.Location = new System.Drawing.Point(12, 12);
            this.Cargaison.Name = "Cargaison";
            this.Cargaison.Size = new System.Drawing.Size(372, 352);
            this.Cargaison.TabIndex = 0;
            this.Cargaison.TabStop = false;
            this.Cargaison.Text = "Cargaison";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(35, 141);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(290, 199);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonAddCargaison
            // 
            this.buttonAddCargaison.Location = new System.Drawing.Point(250, 48);
            this.buttonAddCargaison.Name = "buttonAddCargaison";
            this.buttonAddCargaison.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCargaison.TabIndex = 4;
            this.buttonAddCargaison.Text = "+";
            this.buttonAddCargaison.UseVisualStyleBackColor = true;
            this.buttonAddCargaison.Click += new System.EventHandler(this.buttonAddCargaison_Click);
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Location = new System.Drawing.Point(87, 45);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(119, 20);
            this.textBoxDistance.TabIndex = 3;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Routiére",
            "Aérienne"});
            this.comboBoxType.Location = new System.Drawing.Point(87, 90);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(119, 21);
            this.comboBoxType.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distance";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewMarchandise);
            this.groupBox2.Controls.Add(this.buttonRemoveMarchandise);
            this.groupBox2.Controls.Add(this.buttonAddMarchandise);
            this.groupBox2.Controls.Add(this.textBoxNum);
            this.groupBox2.Controls.Add(this.textBoxVolume);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxPoids);
            this.groupBox2.Location = new System.Drawing.Point(390, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 352);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Marchandise";
            // 
            // dataGridViewMarchandise
            // 
            this.dataGridViewMarchandise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarchandise.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Poids,
            this.Volume});
            this.dataGridViewMarchandise.Location = new System.Drawing.Point(31, 159);
            this.dataGridViewMarchandise.Name = "dataGridViewMarchandise";
            this.dataGridViewMarchandise.Size = new System.Drawing.Size(343, 181);
            this.dataGridViewMarchandise.TabIndex = 12;
            // 
            // Num
            // 
            this.Num.HeaderText = "Num";
            this.Num.Name = "Num";
            // 
            // Poids
            // 
            this.Poids.HeaderText = "Poids";
            this.Poids.Name = "Poids";
            // 
            // Volume
            // 
            this.Volume.HeaderText = "Volume";
            this.Volume.Name = "Volume";
            // 
            // buttonRemoveMarchandise
            // 
            this.buttonRemoveMarchandise.Location = new System.Drawing.Point(241, 88);
            this.buttonRemoveMarchandise.Name = "buttonRemoveMarchandise";
            this.buttonRemoveMarchandise.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveMarchandise.TabIndex = 11;
            this.buttonRemoveMarchandise.Text = "-";
            this.buttonRemoveMarchandise.UseVisualStyleBackColor = true;
            this.buttonRemoveMarchandise.Click += new System.EventHandler(this.buttonRemoveMarchandise_Click);
            // 
            // buttonAddMarchandise
            // 
            this.buttonAddMarchandise.Location = new System.Drawing.Point(241, 59);
            this.buttonAddMarchandise.Name = "buttonAddMarchandise";
            this.buttonAddMarchandise.Size = new System.Drawing.Size(75, 23);
            this.buttonAddMarchandise.TabIndex = 6;
            this.buttonAddMarchandise.Text = "+";
            this.buttonAddMarchandise.UseVisualStyleBackColor = true;
            this.buttonAddMarchandise.Click += new System.EventHandler(this.buttonAddMarchandise_Click);
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(91, 38);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(100, 20);
            this.textBoxNum.TabIndex = 10;
            // 
            // textBoxVolume
            // 
            this.textBoxVolume.Location = new System.Drawing.Point(91, 72);
            this.textBoxVolume.Name = "textBoxVolume";
            this.textBoxVolume.Size = new System.Drawing.Size(100, 20);
            this.textBoxVolume.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Num";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Volume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Poids";
            // 
            // textBoxPoids
            // 
            this.textBoxPoids.Location = new System.Drawing.Point(91, 107);
            this.textBoxPoids.Name = "textBoxPoids";
            this.textBoxPoids.Size = new System.Drawing.Size(100, 20);
            this.textBoxPoids.TabIndex = 0;
            // 
            // costBox
            // 
            this.costBox.Controls.Add(this.textBoxCost);
            this.costBox.Controls.Add(this.label6);
            this.costBox.Location = new System.Drawing.Point(197, 370);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(384, 68);
            this.costBox.TabIndex = 2;
            this.costBox.TabStop = false;
            this.costBox.Text = "Calculateur cout";
            // 
            // textBoxCost
            // 
            this.textBoxCost.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBoxCost.Enabled = false;
            this.textBoxCost.Location = new System.Drawing.Point(57, 31);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(268, 20);
            this.textBoxCost.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cout";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(627, 370);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // buttonRemoveCargaison
            // 
            this.buttonRemoveCargaison.Location = new System.Drawing.Point(250, 88);
            this.buttonRemoveCargaison.Name = "buttonRemoveCargaison";
            this.buttonRemoveCargaison.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveCargaison.TabIndex = 6;
            this.buttonRemoveCargaison.Text = "-";
            this.buttonRemoveCargaison.UseVisualStyleBackColor = true;
            // 
            // CargaisonUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.costBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Cargaison);
            this.Name = "CargaisonUI";
            this.Text = "CargaisonUI";
            this.Cargaison.ResumeLayout(false);
            this.Cargaison.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarchandise)).EndInit();
            this.costBox.ResumeLayout(false);
            this.costBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Cargaison;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonAddCargaison;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewMarchandise;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poids;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volume;
        private System.Windows.Forms.Button buttonRemoveMarchandise;
        private System.Windows.Forms.Button buttonAddMarchandise;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.TextBox textBoxVolume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPoids;
        private System.Windows.Forms.GroupBox costBox;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRemoveCargaison;
    }
}
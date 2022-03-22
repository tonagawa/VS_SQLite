namespace SQLite_Practice
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_CreateDB = new System.Windows.Forms.Button();
            this.btn_CreateTable = new System.Windows.Forms.Button();
            this.btn_CheckTable = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.tb_Insert = new System.Windows.Forms.TextBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.btn_Select = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_CreateDB
            // 
            this.btn_CreateDB.Location = new System.Drawing.Point(50, 23);
            this.btn_CreateDB.Name = "btn_CreateDB";
            this.btn_CreateDB.Size = new System.Drawing.Size(171, 43);
            this.btn_CreateDB.TabIndex = 0;
            this.btn_CreateDB.Text = "dbファイル作成";
            this.btn_CreateDB.UseVisualStyleBackColor = true;
            this.btn_CreateDB.Click += new System.EventHandler(this.Btn_CreateDB_Click);
            // 
            // btn_CreateTable
            // 
            this.btn_CreateTable.Location = new System.Drawing.Point(50, 86);
            this.btn_CreateTable.Name = "btn_CreateTable";
            this.btn_CreateTable.Size = new System.Drawing.Size(171, 43);
            this.btn_CreateTable.TabIndex = 1;
            this.btn_CreateTable.Text = "テーブル作成";
            this.btn_CreateTable.UseVisualStyleBackColor = true;
            this.btn_CreateTable.Click += new System.EventHandler(this.Btn_CreateTable_Click);
            // 
            // btn_CheckTable
            // 
            this.btn_CheckTable.Location = new System.Drawing.Point(50, 151);
            this.btn_CheckTable.Name = "btn_CheckTable";
            this.btn_CheckTable.Size = new System.Drawing.Size(171, 43);
            this.btn_CheckTable.TabIndex = 2;
            this.btn_CheckTable.Text = "テーブル定義の確認";
            this.btn_CheckTable.UseVisualStyleBackColor = true;
            this.btn_CheckTable.Click += new System.EventHandler(this.Btn_CheckTable_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(161, 116);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(134, 23);
            this.btn_Insert.TabIndex = 3;
            this.btn_Insert.Text = "データ挿入";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.Btn_Insert_Click);
            // 
            // tb_Insert
            // 
            this.tb_Insert.Location = new System.Drawing.Point(323, 117);
            this.tb_Insert.Name = "tb_Insert";
            this.tb_Insert.Size = new System.Drawing.Size(198, 22);
            this.tb_Insert.TabIndex = 4;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(161, 33);
            this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(127, 22);
            this.numericUpDown.TabIndex = 5;
            this.numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(161, 179);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(134, 23);
            this.btn_Select.TabIndex = 6;
            this.btn_Select.Text = "データ表示";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.Btn_Select_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "登録 id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.BackColor = System.Drawing.Color.White;
            this.lbl_Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Result.Location = new System.Drawing.Point(323, 183);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(69, 17);
            this.lbl_Result.TabIndex = 8;
            this.lbl_Result.Text = "検索結果";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "選択した id へ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "選択した id の";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "挿入するデータを入力";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "選択した id の";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(161, 238);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(134, 23);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "データ削除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightYellow;
            this.panel1.Controls.Add(this.btn_CreateDB);
            this.panel1.Controls.Add(this.btn_CreateTable);
            this.panel1.Controls.Add(this.btn_CheckTable);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 216);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.tb_Insert);
            this.panel2.Controls.Add(this.btn_Insert);
            this.panel2.Controls.Add(this.btn_Delete);
            this.panel2.Controls.Add(this.numericUpDown);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btn_Select);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbl_Result);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(317, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 289);
            this.panel2.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 316);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CreateDB;
        private System.Windows.Forms.Button btn_CreateTable;
        private System.Windows.Forms.Button btn_CheckTable;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.TextBox tb_Insert;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

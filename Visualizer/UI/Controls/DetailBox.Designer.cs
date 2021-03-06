﻿namespace ILReader.Visualizer.UI.Controls {
    partial class DetailBox {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.colIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOffset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOpCode = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colOperand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBytes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iInstructionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iInstructionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIndex,
            this.colOffset,
            this.colOpCode,
            this.colOperand,
            this.colBytes});
            this.dataGridView.DataSource = this.iInstructionBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(8, 8);
            this.dataGridView.Name = "dataGridView1";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.RowTemplate.Height = 18;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.Size = new System.Drawing.Size(349, 282);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_CellFormatting);
            // 
            // colIndex
            // 
            this.colIndex.DataPropertyName = "Index";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            this.colIndex.DefaultCellStyle = dataGridViewCellStyle2;
            this.colIndex.FillWeight = 50F;
            this.colIndex.HeaderText = "#";
            this.colIndex.Name = "colIndex";
            this.colIndex.ReadOnly = true;
            this.colIndex.Width = 39;
            // 
            // colOffset
            // 
            this.colOffset.DataPropertyName = "Offset";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Format = "X4";
            this.colOffset.DefaultCellStyle = dataGridViewCellStyle3;
            this.colOffset.FillWeight = 60F;
            this.colOffset.HeaderText = "Offset";
            this.colOffset.Name = "colOffset";
            this.colOffset.ReadOnly = true;
            this.colOffset.Width = 60;
            // 
            // colOpCode
            // 
            this.colOpCode.ActiveLinkColor = System.Drawing.Color.White;
            this.colOpCode.DataPropertyName = "OpCode";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Blue;
            this.colOpCode.DefaultCellStyle = dataGridViewCellStyle4;
            this.colOpCode.HeaderText = "OpCode";
            this.colOpCode.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.colOpCode.Name = "colOpCode";
            this.colOpCode.ReadOnly = true;
            this.colOpCode.Width = 52;
            // 
            // colOperand
            // 
            this.colOperand.DataPropertyName = "Operand";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            this.colOperand.DefaultCellStyle = dataGridViewCellStyle5;
            this.colOperand.HeaderText = "Operand";
            this.colOperand.Name = "colOperand";
            this.colOperand.ReadOnly = true;
            this.colOperand.Width = 73;
            // 
            // colBytes
            // 
            this.colBytes.DataPropertyName = "Bytes";
            this.colBytes.HeaderText = "Bytes";
            this.colBytes.Name = "colBytes";
            this.colBytes.ReadOnly = true;
            this.colBytes.Width = 58;
            // 
            // iInstructionBindingSource
            // 
            this.iInstructionBindingSource.DataSource = typeof(ILReader.Readers.IInstruction);
            // 
            // DetailBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView);
            this.Name = "DetailBox";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(365, 298);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iInstructionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource iInstructionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOffset;
        private System.Windows.Forms.DataGridViewLinkColumn colOpCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBytes;
    }
}

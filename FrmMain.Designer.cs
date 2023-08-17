namespace Hamilton
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVertex = new System.Windows.Forms.TextBox();
            this.txtEdge = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnDecide = new System.Windows.Forms.Button();
            this.txtMatrix = new System.Windows.Forms.TextBox();
            this.txtHC = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vertex:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edge:";
            // 
            // txtVertex
            // 
            this.txtVertex.Location = new System.Drawing.Point(78, 11);
            this.txtVertex.Name = "txtVertex";
            this.txtVertex.Size = new System.Drawing.Size(70, 26);
            this.txtVertex.TabIndex = 2;
            this.txtVertex.Text = "32";
            this.txtVertex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEdge
            // 
            this.txtEdge.Location = new System.Drawing.Point(244, 9);
            this.txtEdge.Name = "txtEdge";
            this.txtEdge.Size = new System.Drawing.Size(72, 26);
            this.txtEdge.TabIndex = 3;
            this.txtEdge.Text = "128";
            this.txtEdge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(348, 8);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(102, 29);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnDecide
            // 
            this.btnDecide.Location = new System.Drawing.Point(636, 7);
            this.btnDecide.Name = "btnDecide";
            this.btnDecide.Size = new System.Drawing.Size(99, 29);
            this.btnDecide.TabIndex = 5;
            this.btnDecide.Text = "Decide";
            this.btnDecide.UseVisualStyleBackColor = true;
            this.btnDecide.Click += new System.EventHandler(this.btnDecide_Click);
            // 
            // txtMatrix
            // 
            this.txtMatrix.Location = new System.Drawing.Point(12, 43);
            this.txtMatrix.Multiline = true;
            this.txtMatrix.Name = "txtMatrix";
            this.txtMatrix.ReadOnly = true;
            this.txtMatrix.Size = new System.Drawing.Size(616, 655);
            this.txtMatrix.TabIndex = 6;
            // 
            // txtHC
            // 
            this.txtHC.Location = new System.Drawing.Point(636, 43);
            this.txtHC.Multiline = true;
            this.txtHC.Name = "txtHC";
            this.txtHC.ReadOnly = true;
            this.txtHC.Size = new System.Drawing.Size(584, 228);
            this.txtHC.TabIndex = 7;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(825, 10);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(114, 26);
            this.txtTime.TabIndex = 13;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(741, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Time(ms):";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 757);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHC);
            this.Controls.Add(this.txtMatrix);
            this.Controls.Add(this.btnDecide);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtEdge);
            this.Controls.Add(this.txtVertex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "Hamilton";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVertex;
        private System.Windows.Forms.TextBox txtEdge;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnDecide;
        private System.Windows.Forms.TextBox txtMatrix;
        private System.Windows.Forms.TextBox txtHC;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label4;
    }
}


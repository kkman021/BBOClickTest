namespace BBOClick
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbxReStartPosition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblProcessTimes = new System.Windows.Forms.Label();
            this.labelMousePosition = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIsStart = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxReStartPosition
            // 
            this.tbxReStartPosition.Location = new System.Drawing.Point(98, 2);
            this.tbxReStartPosition.Name = "tbxReStartPosition";
            this.tbxReStartPosition.Size = new System.Drawing.Size(100, 22);
            this.tbxReStartPosition.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "重新挑戰座標：";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(3, 59);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(65, 12);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "執行次數：";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblProcessTimes
            // 
            this.lblProcessTimes.AutoSize = true;
            this.lblProcessTimes.Location = new System.Drawing.Point(96, 57);
            this.lblProcessTimes.Name = "lblProcessTimes";
            this.lblProcessTimes.Size = new System.Drawing.Size(11, 12);
            this.lblProcessTimes.TabIndex = 6;
            this.lblProcessTimes.Text = "0";
            // 
            // labelMousePosition
            // 
            this.labelMousePosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMousePosition.AutoSize = true;
            this.labelMousePosition.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMousePosition.Location = new System.Drawing.Point(95, 81);
            this.labelMousePosition.Name = "labelMousePosition";
            this.labelMousePosition.Size = new System.Drawing.Size(162, 16);
            this.labelMousePosition.TabIndex = 7;
            this.labelMousePosition.Text = "x={0:####}; y={1:####}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "目前座標：";
            // 
            // lblIsStart
            // 
            this.lblIsStart.AutoSize = true;
            this.lblIsStart.ForeColor = System.Drawing.Color.Red;
            this.lblIsStart.Location = new System.Drawing.Point(34, 111);
            this.lblIsStart.Name = "lblIsStart";
            this.lblIsStart.Size = new System.Drawing.Size(188, 12);
            this.lblIsStart.TabIndex = 15;
            this.lblIsStart.Text = "F5：開始。 F6：停止。目前狀態：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "執行間隔(分)：";
            // 
            // tbxTime
            // 
            this.tbxTime.Location = new System.Drawing.Point(98, 28);
            this.tbxTime.Name = "tbxTime";
            this.tbxTime.Size = new System.Drawing.Size(29, 22);
            this.tbxTime.TabIndex = 16;
            this.tbxTime.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 140);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxTime);
            this.Controls.Add(this.lblIsStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMousePosition);
            this.Controls.Add(this.lblProcessTimes);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxReStartPosition);
            this.Name = "Form1";
            this.Text = "全民打棒球 1:1 懶人精靈";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxReStartPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblProcessTimes;
        private System.Windows.Forms.Label labelMousePosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIsStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxTime;
    }
}


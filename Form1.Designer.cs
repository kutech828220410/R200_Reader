
namespace R200_Reader
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Open = new System.Windows.Forms.Button();
            this.comboBox_COM = new System.Windows.Forms.ComboBox();
            this.rJ_Button_讀取卡片 = new MyUI.RJ_Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Card_01 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_Card_02 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_Card_03 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_Card_04 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_Card_05 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(199, 16);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(75, 43);
            this.button_Open.TabIndex = 3;
            this.button_Open.Text = "Open";
            this.button_Open.UseVisualStyleBackColor = true;
            // 
            // comboBox_COM
            // 
            this.comboBox_COM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_COM.Font = new System.Drawing.Font("新細明體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_COM.FormattingEnabled = true;
            this.comboBox_COM.Location = new System.Drawing.Point(29, 16);
            this.comboBox_COM.Name = "comboBox_COM";
            this.comboBox_COM.Size = new System.Drawing.Size(154, 43);
            this.comboBox_COM.TabIndex = 2;
            // 
            // rJ_Button_讀取卡片
            // 
            this.rJ_Button_讀取卡片.AutoResetState = false;
            this.rJ_Button_讀取卡片.BackColor = System.Drawing.Color.RoyalBlue;
            this.rJ_Button_讀取卡片.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.rJ_Button_讀取卡片.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Button_讀取卡片.BorderRadius = 5;
            this.rJ_Button_讀取卡片.BorderSize = 0;
            this.rJ_Button_讀取卡片.buttonType = MyUI.RJ_Button.ButtonType.Push;
            this.rJ_Button_讀取卡片.FlatAppearance.BorderSize = 0;
            this.rJ_Button_讀取卡片.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Button_讀取卡片.ForeColor = System.Drawing.Color.White;
            this.rJ_Button_讀取卡片.GUID = "";
            this.rJ_Button_讀取卡片.Location = new System.Drawing.Point(280, 16);
            this.rJ_Button_讀取卡片.Name = "rJ_Button_讀取卡片";
            this.rJ_Button_讀取卡片.Size = new System.Drawing.Size(151, 43);
            this.rJ_Button_讀取卡片.State = false;
            this.rJ_Button_讀取卡片.TabIndex = 4;
            this.rJ_Button_讀取卡片.Text = "讀取卡片";
            this.rJ_Button_讀取卡片.TextColor = System.Drawing.Color.White;
            this.rJ_Button_讀取卡片.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label_Card_01);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(29, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 45);
            this.panel1.TabIndex = 5;
            // 
            // label_Card_01
            // 
            this.label_Card_01.AutoSize = true;
            this.label_Card_01.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Card_01.Location = new System.Drawing.Point(83, 12);
            this.label_Card_01.Name = "label_Card_01";
            this.label_Card_01.Size = new System.Drawing.Size(162, 19);
            this.label_Card_01.TabIndex = 1;
            this.label_Card_01.Text = "00000000000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InfoText;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card 01";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label_Card_02);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(29, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 45);
            this.panel2.TabIndex = 6;
            // 
            // label_Card_02
            // 
            this.label_Card_02.AutoSize = true;
            this.label_Card_02.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Card_02.Location = new System.Drawing.Point(83, 12);
            this.label_Card_02.Name = "label_Card_02";
            this.label_Card_02.Size = new System.Drawing.Size(162, 19);
            this.label_Card_02.TabIndex = 1;
            this.label_Card_02.Text = "00000000000000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InfoText;
            this.label4.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Card 02";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label_Card_03);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(29, 193);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(328, 45);
            this.panel3.TabIndex = 7;
            // 
            // label_Card_03
            // 
            this.label_Card_03.AutoSize = true;
            this.label_Card_03.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Card_03.Location = new System.Drawing.Point(83, 12);
            this.label_Card_03.Name = "label_Card_03";
            this.label_Card_03.Size = new System.Drawing.Size(162, 19);
            this.label_Card_03.TabIndex = 1;
            this.label_Card_03.Text = "00000000000000000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.InfoText;
            this.label6.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Card 03";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label_Card_04);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(29, 244);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(328, 45);
            this.panel4.TabIndex = 8;
            // 
            // label_Card_04
            // 
            this.label_Card_04.AutoSize = true;
            this.label_Card_04.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Card_04.Location = new System.Drawing.Point(83, 12);
            this.label_Card_04.Name = "label_Card_04";
            this.label_Card_04.Size = new System.Drawing.Size(162, 19);
            this.label_Card_04.TabIndex = 1;
            this.label_Card_04.Text = "00000000000000000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.InfoText;
            this.label8.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Card 04";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label_Card_05);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(29, 295);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(328, 45);
            this.panel5.TabIndex = 9;
            // 
            // label_Card_05
            // 
            this.label_Card_05.AutoSize = true;
            this.label_Card_05.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Card_05.Location = new System.Drawing.Point(83, 12);
            this.label_Card_05.Name = "label_Card_05";
            this.label_Card_05.Size = new System.Drawing.Size(162, 19);
            this.label_Card_05.TabIndex = 1;
            this.label_Card_05.Text = "00000000000000000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.InfoText;
            this.label10.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Card 05";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(472, 424);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rJ_Button_讀取卡片);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.comboBox_COM);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.ComboBox comboBox_COM;
        private MyUI.RJ_Button rJ_Button_讀取卡片;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Card_01;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_Card_02;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_Card_03;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_Card_04;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label_Card_05;
        private System.Windows.Forms.Label label10;
    }
}


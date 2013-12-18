namespace EllipseCurve
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.bt_generateSignature = new System.Windows.Forms.Button();
            this.lb_group = new System.Windows.Forms.Label();
            this.bt_changeGroup = new System.Windows.Forms.Button();
            this.rtb_exchangeKeys = new System.Windows.Forms.RichTextBox();
            this.bt_exchangeKeys = new System.Windows.Forms.Button();
            this.rtb_message = new System.Windows.Forms.RichTextBox();
            this.tb_na = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_pa = new System.Windows.Forms.TextBox();
            this.tb_r = new System.Windows.Forms.TextBox();
            this.tb_s = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_checkSignature = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_generateSignature
            // 
            this.bt_generateSignature.Location = new System.Drawing.Point(324, 227);
            this.bt_generateSignature.Name = "bt_generateSignature";
            this.bt_generateSignature.Size = new System.Drawing.Size(114, 38);
            this.bt_generateSignature.TabIndex = 0;
            this.bt_generateSignature.Text = "Generate Signature";
            this.bt_generateSignature.UseVisualStyleBackColor = true;
            this.bt_generateSignature.Click += new System.EventHandler(this.bt_generateSignature_Click);
            // 
            // lb_group
            // 
            this.lb_group.AutoSize = true;
            this.lb_group.Location = new System.Drawing.Point(15, 25);
            this.lb_group.Name = "lb_group";
            this.lb_group.Size = new System.Drawing.Size(0, 13);
            this.lb_group.TabIndex = 2;
            // 
            // bt_changeGroup
            // 
            this.bt_changeGroup.Location = new System.Drawing.Point(213, 17);
            this.bt_changeGroup.Name = "bt_changeGroup";
            this.bt_changeGroup.Size = new System.Drawing.Size(108, 29);
            this.bt_changeGroup.TabIndex = 3;
            this.bt_changeGroup.Text = "ChangeGroup";
            this.bt_changeGroup.UseVisualStyleBackColor = true;
            this.bt_changeGroup.Click += new System.EventHandler(this.bt_changeGroup_Click);
            // 
            // rtb_exchangeKeys
            // 
            this.rtb_exchangeKeys.Location = new System.Drawing.Point(10, 74);
            this.rtb_exchangeKeys.Name = "rtb_exchangeKeys";
            this.rtb_exchangeKeys.Size = new System.Drawing.Size(268, 139);
            this.rtb_exchangeKeys.TabIndex = 4;
            this.rtb_exchangeKeys.Text = "";
            // 
            // bt_exchangeKeys
            // 
            this.bt_exchangeKeys.Location = new System.Drawing.Point(73, 219);
            this.bt_exchangeKeys.Name = "bt_exchangeKeys";
            this.bt_exchangeKeys.Size = new System.Drawing.Size(132, 35);
            this.bt_exchangeKeys.TabIndex = 5;
            this.bt_exchangeKeys.Text = "Exchange keys";
            this.bt_exchangeKeys.UseVisualStyleBackColor = true;
            this.bt_exchangeKeys.Click += new System.EventHandler(this.bt_exchangeKeys_Click);
            // 
            // rtb_message
            // 
            this.rtb_message.Location = new System.Drawing.Point(335, 25);
            this.rtb_message.Name = "rtb_message";
            this.rtb_message.Size = new System.Drawing.Size(268, 107);
            this.rtb_message.TabIndex = 6;
            this.rtb_message.Text = "";
            // 
            // tb_na
            // 
            this.tb_na.Location = new System.Drawing.Point(360, 179);
            this.tb_na.Name = "tb_na";
            this.tb_na.Size = new System.Drawing.Size(34, 20);
            this.tb_na.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Na = ";
            // 
            // tb_pa
            // 
            this.tb_pa.Location = new System.Drawing.Point(534, 145);
            this.tb_pa.Name = "tb_pa";
            this.tb_pa.Size = new System.Drawing.Size(34, 20);
            this.tb_pa.TabIndex = 9;
            // 
            // tb_r
            // 
            this.tb_r.Location = new System.Drawing.Point(534, 175);
            this.tb_r.Name = "tb_r";
            this.tb_r.Size = new System.Drawing.Size(34, 20);
            this.tb_r.TabIndex = 10;
            // 
            // tb_s
            // 
            this.tb_s.Location = new System.Drawing.Point(534, 201);
            this.tb_s.Name = "tb_s";
            this.tb_s.Size = new System.Drawing.Size(34, 20);
            this.tb_s.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pa = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "r = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "s = ";
            // 
            // bt_checkSignature
            // 
            this.bt_checkSignature.Location = new System.Drawing.Point(474, 227);
            this.bt_checkSignature.Name = "bt_checkSignature";
            this.bt_checkSignature.Size = new System.Drawing.Size(114, 38);
            this.bt_checkSignature.TabIndex = 15;
            this.bt_checkSignature.Text = "Check Signature";
            this.bt_checkSignature.UseVisualStyleBackColor = true;
            this.bt_checkSignature.Click += new System.EventHandler(this.bt_checkSignature_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 295);
            this.Controls.Add(this.bt_checkSignature);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_s);
            this.Controls.Add(this.tb_r);
            this.Controls.Add(this.tb_pa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_na);
            this.Controls.Add(this.rtb_message);
            this.Controls.Add(this.bt_exchangeKeys);
            this.Controls.Add(this.rtb_exchangeKeys);
            this.Controls.Add(this.bt_changeGroup);
            this.Controls.Add(this.lb_group);
            this.Controls.Add(this.bt_generateSignature);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_generateSignature;
        private System.Windows.Forms.Label lb_group;
        private System.Windows.Forms.Button bt_changeGroup;
        private System.Windows.Forms.RichTextBox rtb_exchangeKeys;
        private System.Windows.Forms.Button bt_exchangeKeys;
        private System.Windows.Forms.RichTextBox rtb_message;
        private System.Windows.Forms.TextBox tb_na;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_pa;
        private System.Windows.Forms.TextBox tb_r;
        private System.Windows.Forms.TextBox tb_s;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_checkSignature;
    }
}


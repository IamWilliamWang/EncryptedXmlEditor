namespace XmlEditor
{
    partial class Form1
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
            if (disposing && ( components != null ))
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
            this.labelKeyword = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textKeyword = new System.Windows.Forms.TextBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.buttonCopy7 = new System.Windows.Forms.Button();
            this.buttonCopy6 = new System.Windows.Forms.Button();
            this.buttonCopy5 = new System.Windows.Forms.Button();
            this.buttonCopy4 = new System.Windows.Forms.Button();
            this.buttonCopy3 = new System.Windows.Forms.Button();
            this.buttonCopy2 = new System.Windows.Forms.Button();
            this.buttonCopy1 = new System.Windows.Forms.Button();
            this.labelPropertyValue = new System.Windows.Forms.Label();
            this.labelProperty = new System.Windows.Forms.Label();
            this.textPropVal7 = new System.Windows.Forms.TextBox();
            this.textProp7 = new System.Windows.Forms.TextBox();
            this.textPropVal6 = new System.Windows.Forms.TextBox();
            this.textPropVal5 = new System.Windows.Forms.TextBox();
            this.textPropVal4 = new System.Windows.Forms.TextBox();
            this.textPropVal3 = new System.Windows.Forms.TextBox();
            this.textPropVal2 = new System.Windows.Forms.TextBox();
            this.textPropVal1 = new System.Windows.Forms.TextBox();
            this.textProp6 = new System.Windows.Forms.TextBox();
            this.textProp5 = new System.Windows.Forms.TextBox();
            this.textProp4 = new System.Windows.Forms.TextBox();
            this.textProp3 = new System.Windows.Forms.TextBox();
            this.textProp2 = new System.Windows.Forms.TextBox();
            this.textProp1 = new System.Windows.Forms.TextBox();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelKeyword
            // 
            this.labelKeyword.AutoSize = true;
            this.labelKeyword.Location = new System.Drawing.Point(21, 15);
            this.labelKeyword.Name = "labelKeyword";
            this.labelKeyword.Size = new System.Drawing.Size(77, 12);
            this.labelKeyword.TabIndex = 0;
            this.labelKeyword.Text = "搜索关键字：";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(229, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "搜索";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textKeyword
            // 
            this.textKeyword.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
            this.textKeyword.Location = new System.Drawing.Point(97, 12);
            this.textKeyword.Name = "textKeyword";
            this.textKeyword.Size = new System.Drawing.Size(126, 21);
            this.textKeyword.TabIndex = 2;
            this.textKeyword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textKeyword_KeyPress);
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.buttonCopy7);
            this.groupBoxResult.Controls.Add(this.buttonCopy6);
            this.groupBoxResult.Controls.Add(this.buttonCopy5);
            this.groupBoxResult.Controls.Add(this.buttonCopy4);
            this.groupBoxResult.Controls.Add(this.buttonCopy3);
            this.groupBoxResult.Controls.Add(this.buttonCopy2);
            this.groupBoxResult.Controls.Add(this.buttonCopy1);
            this.groupBoxResult.Controls.Add(this.labelPropertyValue);
            this.groupBoxResult.Controls.Add(this.labelProperty);
            this.groupBoxResult.Controls.Add(this.textPropVal7);
            this.groupBoxResult.Controls.Add(this.textProp7);
            this.groupBoxResult.Controls.Add(this.textPropVal6);
            this.groupBoxResult.Controls.Add(this.textPropVal5);
            this.groupBoxResult.Controls.Add(this.textPropVal4);
            this.groupBoxResult.Controls.Add(this.textPropVal3);
            this.groupBoxResult.Controls.Add(this.textPropVal2);
            this.groupBoxResult.Controls.Add(this.textPropVal1);
            this.groupBoxResult.Controls.Add(this.textProp6);
            this.groupBoxResult.Controls.Add(this.textProp5);
            this.groupBoxResult.Controls.Add(this.textProp4);
            this.groupBoxResult.Controls.Add(this.textProp3);
            this.groupBoxResult.Controls.Add(this.textProp2);
            this.groupBoxResult.Controls.Add(this.textProp1);
            this.groupBoxResult.Location = new System.Drawing.Point(6, 56);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(380, 237);
            this.groupBoxResult.TabIndex = 3;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "搜索结果";
            // 
            // buttonCopy7
            // 
            this.buttonCopy7.Location = new System.Drawing.Point(298, 202);
            this.buttonCopy7.Name = "buttonCopy7";
            this.buttonCopy7.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy7.TabIndex = 16;
            this.buttonCopy7.Text = "复制";
            this.buttonCopy7.UseVisualStyleBackColor = true;
            this.buttonCopy7.Click += new System.EventHandler(this.buttonCopy7_Click);
            // 
            // buttonCopy6
            // 
            this.buttonCopy6.Location = new System.Drawing.Point(298, 172);
            this.buttonCopy6.Name = "buttonCopy6";
            this.buttonCopy6.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy6.TabIndex = 16;
            this.buttonCopy6.Text = "复制";
            this.buttonCopy6.UseVisualStyleBackColor = true;
            this.buttonCopy6.Click += new System.EventHandler(this.buttonCopy6_Click);
            // 
            // buttonCopy5
            // 
            this.buttonCopy5.Location = new System.Drawing.Point(299, 144);
            this.buttonCopy5.Name = "buttonCopy5";
            this.buttonCopy5.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy5.TabIndex = 16;
            this.buttonCopy5.Text = "复制";
            this.buttonCopy5.UseVisualStyleBackColor = true;
            this.buttonCopy5.Click += new System.EventHandler(this.buttonCopy5_Click);
            // 
            // buttonCopy4
            // 
            this.buttonCopy4.Location = new System.Drawing.Point(299, 116);
            this.buttonCopy4.Name = "buttonCopy4";
            this.buttonCopy4.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy4.TabIndex = 16;
            this.buttonCopy4.Text = "复制";
            this.buttonCopy4.UseVisualStyleBackColor = true;
            this.buttonCopy4.Click += new System.EventHandler(this.buttonCopy4_Click);
            // 
            // buttonCopy3
            // 
            this.buttonCopy3.Location = new System.Drawing.Point(299, 88);
            this.buttonCopy3.Name = "buttonCopy3";
            this.buttonCopy3.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy3.TabIndex = 16;
            this.buttonCopy3.Text = "复制";
            this.buttonCopy3.UseVisualStyleBackColor = true;
            this.buttonCopy3.Click += new System.EventHandler(this.buttonCopy3_Click);
            // 
            // buttonCopy2
            // 
            this.buttonCopy2.Location = new System.Drawing.Point(299, 60);
            this.buttonCopy2.Name = "buttonCopy2";
            this.buttonCopy2.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy2.TabIndex = 16;
            this.buttonCopy2.Text = "复制";
            this.buttonCopy2.UseVisualStyleBackColor = true;
            this.buttonCopy2.Click += new System.EventHandler(this.buttonCopy2_Click);
            // 
            // buttonCopy1
            // 
            this.buttonCopy1.Location = new System.Drawing.Point(299, 34);
            this.buttonCopy1.Name = "buttonCopy1";
            this.buttonCopy1.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy1.TabIndex = 16;
            this.buttonCopy1.Text = "复制";
            this.buttonCopy1.UseVisualStyleBackColor = true;
            this.buttonCopy1.Click += new System.EventHandler(this.buttonCopy1_Click);
            // 
            // labelPropertyValue
            // 
            this.labelPropertyValue.AutoSize = true;
            this.labelPropertyValue.Location = new System.Drawing.Point(163, 17);
            this.labelPropertyValue.Name = "labelPropertyValue";
            this.labelPropertyValue.Size = new System.Drawing.Size(41, 12);
            this.labelPropertyValue.TabIndex = 15;
            this.labelPropertyValue.Text = "属性值";
            // 
            // labelProperty
            // 
            this.labelProperty.AutoSize = true;
            this.labelProperty.Location = new System.Drawing.Point(24, 17);
            this.labelProperty.Name = "labelProperty";
            this.labelProperty.Size = new System.Drawing.Size(41, 12);
            this.labelProperty.TabIndex = 14;
            this.labelProperty.Text = "属性名";
            // 
            // textPropVal7
            // 
            this.textPropVal7.Location = new System.Drawing.Point(101, 202);
            this.textPropVal7.Name = "textPropVal7";
            this.textPropVal7.Size = new System.Drawing.Size(191, 21);
            this.textPropVal7.TabIndex = 13;
            // 
            // textProp7
            // 
            this.textProp7.Location = new System.Drawing.Point(14, 202);
            this.textProp7.Name = "textProp7";
            this.textProp7.Size = new System.Drawing.Size(71, 21);
            this.textProp7.TabIndex = 12;
            // 
            // textPropVal6
            // 
            this.textPropVal6.Location = new System.Drawing.Point(101, 174);
            this.textPropVal6.Name = "textPropVal6";
            this.textPropVal6.Size = new System.Drawing.Size(191, 21);
            this.textPropVal6.TabIndex = 11;
            // 
            // textPropVal5
            // 
            this.textPropVal5.Location = new System.Drawing.Point(101, 146);
            this.textPropVal5.Name = "textPropVal5";
            this.textPropVal5.Size = new System.Drawing.Size(191, 21);
            this.textPropVal5.TabIndex = 10;
            // 
            // textPropVal4
            // 
            this.textPropVal4.Location = new System.Drawing.Point(101, 118);
            this.textPropVal4.Name = "textPropVal4";
            this.textPropVal4.Size = new System.Drawing.Size(191, 21);
            this.textPropVal4.TabIndex = 9;
            // 
            // textPropVal3
            // 
            this.textPropVal3.Location = new System.Drawing.Point(101, 90);
            this.textPropVal3.Name = "textPropVal3";
            this.textPropVal3.Size = new System.Drawing.Size(191, 21);
            this.textPropVal3.TabIndex = 8;
            // 
            // textPropVal2
            // 
            this.textPropVal2.Location = new System.Drawing.Point(101, 62);
            this.textPropVal2.Name = "textPropVal2";
            this.textPropVal2.Size = new System.Drawing.Size(191, 21);
            this.textPropVal2.TabIndex = 7;
            // 
            // textPropVal1
            // 
            this.textPropVal1.Location = new System.Drawing.Point(101, 34);
            this.textPropVal1.Name = "textPropVal1";
            this.textPropVal1.Size = new System.Drawing.Size(191, 21);
            this.textPropVal1.TabIndex = 6;
            // 
            // textProp6
            // 
            this.textProp6.Location = new System.Drawing.Point(14, 174);
            this.textProp6.Name = "textProp6";
            this.textProp6.Size = new System.Drawing.Size(71, 21);
            this.textProp6.TabIndex = 5;
            // 
            // textProp5
            // 
            this.textProp5.Location = new System.Drawing.Point(14, 146);
            this.textProp5.Name = "textProp5";
            this.textProp5.Size = new System.Drawing.Size(71, 21);
            this.textProp5.TabIndex = 4;
            // 
            // textProp4
            // 
            this.textProp4.Location = new System.Drawing.Point(14, 118);
            this.textProp4.Name = "textProp4";
            this.textProp4.Size = new System.Drawing.Size(71, 21);
            this.textProp4.TabIndex = 3;
            // 
            // textProp3
            // 
            this.textProp3.Location = new System.Drawing.Point(14, 90);
            this.textProp3.Name = "textProp3";
            this.textProp3.Size = new System.Drawing.Size(71, 21);
            this.textProp3.TabIndex = 2;
            // 
            // textProp2
            // 
            this.textProp2.Location = new System.Drawing.Point(14, 62);
            this.textProp2.Name = "textProp2";
            this.textProp2.Size = new System.Drawing.Size(71, 21);
            this.textProp2.TabIndex = 1;
            // 
            // textProp1
            // 
            this.textProp1.Location = new System.Drawing.Point(14, 34);
            this.textProp1.Name = "textProp1";
            this.textProp1.Size = new System.Drawing.Size(71, 21);
            this.textProp1.TabIndex = 0;
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(311, 12);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(75, 23);
            this.buttonClearAll.TabIndex = 4;
            this.buttonClearAll.Text = "清空";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(12, 35);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(53, 12);
            this.labelInfo.TabIndex = 5;
            this.labelInfo.Text = "文件地址";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 297);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.textKeyword);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelKeyword);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "XML编辑器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKeyword;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textKeyword;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.Button buttonCopy7;
        private System.Windows.Forms.Button buttonCopy6;
        private System.Windows.Forms.Button buttonCopy5;
        private System.Windows.Forms.Button buttonCopy4;
        private System.Windows.Forms.Button buttonCopy3;
        private System.Windows.Forms.Button buttonCopy2;
        private System.Windows.Forms.Button buttonCopy1;
        private System.Windows.Forms.Label labelPropertyValue;
        private System.Windows.Forms.Label labelProperty;
        private System.Windows.Forms.TextBox textPropVal7;
        private System.Windows.Forms.TextBox textProp7;
        private System.Windows.Forms.TextBox textPropVal6;
        private System.Windows.Forms.TextBox textPropVal5;
        private System.Windows.Forms.TextBox textPropVal4;
        private System.Windows.Forms.TextBox textPropVal3;
        private System.Windows.Forms.TextBox textPropVal2;
        private System.Windows.Forms.TextBox textPropVal1;
        private System.Windows.Forms.TextBox textProp6;
        private System.Windows.Forms.TextBox textProp5;
        private System.Windows.Forms.TextBox textProp4;
        private System.Windows.Forms.TextBox textProp3;
        private System.Windows.Forms.TextBox textProp2;
        private System.Windows.Forms.TextBox textProp1;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Label labelInfo;
    }
}


namespace VideoEnhancer
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
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_browse_input = new System.Windows.Forms.Button();
            this.btn_browse_output = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_execute_all = new System.Windows.Forms.Button();
            this.btn_preview = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btn_browse_inputfile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(765, 19);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(80, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(765, 19);
            this.textBox2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1016, 546);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "入力フォルダ";
            // 
            // btn_browse_input
            // 
            this.btn_browse_input.Location = new System.Drawing.Point(851, 9);
            this.btn_browse_input.Name = "btn_browse_input";
            this.btn_browse_input.Size = new System.Drawing.Size(72, 23);
            this.btn_browse_input.TabIndex = 5;
            this.btn_browse_input.Text = "Browse";
            this.btn_browse_input.UseVisualStyleBackColor = true;
            this.btn_browse_input.Click += new System.EventHandler(this.btn_browse_input_Click);
            // 
            // btn_browse_output
            // 
            this.btn_browse_output.Location = new System.Drawing.Point(851, 34);
            this.btn_browse_output.Name = "btn_browse_output";
            this.btn_browse_output.Size = new System.Drawing.Size(72, 23);
            this.btn_browse_output.TabIndex = 6;
            this.btn_browse_output.Text = "Browse";
            this.btn_browse_output.UseVisualStyleBackColor = true;
            this.btn_browse_output.Click += new System.EventHandler(this.btn_browse_output_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(26, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "保存";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(114, 18);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(69, 19);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "4";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(189, 18);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(69, 19);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "ｺﾝﾄﾗｽﾄ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_browse_inputfile);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.btn_preview);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Location = new System.Drawing.Point(13, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1016, 76);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "パラメータ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "ノイズ";
            // 
            // btn_execute_all
            // 
            this.btn_execute_all.Location = new System.Drawing.Point(929, 11);
            this.btn_execute_all.Name = "btn_execute_all";
            this.btn_execute_all.Size = new System.Drawing.Size(100, 46);
            this.btn_execute_all.TabIndex = 13;
            this.btn_execute_all.Text = "バッチ処理";
            this.btn_execute_all.UseVisualStyleBackColor = true;
            this.btn_execute_all.Click += new System.EventHandler(this.btn_execute_all_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.Location = new System.Drawing.Point(916, 42);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(94, 23);
            this.btn_preview.TabIndex = 13;
            this.btn_preview.Text = "プレビュー";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(309, 18);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(71, 19);
            this.textBox5.TabIndex = 14;
            this.textBox5.Text = "3";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(67, 46);
            this.textBox6.Name = "textBox6";
            this.textBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox6.Size = new System.Drawing.Size(765, 19);
            this.textBox6.TabIndex = 15;
            // 
            // btn_browse_inputfile
            // 
            this.btn_browse_inputfile.Location = new System.Drawing.Point(838, 42);
            this.btn_browse_inputfile.Name = "btn_browse_inputfile";
            this.btn_browse_inputfile.Size = new System.Drawing.Size(72, 23);
            this.btn_browse_inputfile.TabIndex = 14;
            this.btn_browse_inputfile.Text = "Browse";
            this.btn_browse_inputfile.UseVisualStyleBackColor = true;
            this.btn_browse_inputfile.Click += new System.EventHandler(this.btn_browse_inputfile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "テスト動画";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 707);
            this.Controls.Add(this.btn_execute_all);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_browse_output);
            this.Controls.Add(this.btn_browse_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_browse_input;
        private System.Windows.Forms.Button btn_browse_output;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_execute_all;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_browse_inputfile;
        private System.Windows.Forms.TextBox textBox6;
    }
}


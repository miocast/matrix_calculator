namespace matrix_calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.matrixA = new System.Windows.Forms.DataGridView();
            this.matrixB = new System.Windows.Forms.DataGridView();
            this.plus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.sizeB = new System.Windows.Forms.TextBox();
            this.size1 = new System.Windows.Forms.Label();
            this.size2 = new System.Windows.Forms.Label();
            this.clean = new System.Windows.Forms.Button();
            this.createA = new System.Windows.Forms.Button();
            this.createB = new System.Windows.Forms.Button();
            this.omatrix = new System.Windows.Forms.DataGridView();
            this.transA = new System.Windows.Forms.Button();
            this.transB = new System.Windows.Forms.Button();
            this.powA = new System.Windows.Forms.Button();
            this.powB = new System.Windows.Forms.Button();
            this.sizeA = new System.Windows.Forms.TextBox();
            this.minA = new System.Windows.Forms.Button();
            this.maxA = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.TextBox();
            this.minB = new System.Windows.Forms.Button();
            this.maxB = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.TextBox();
            this.mulnum = new System.Windows.Forms.Button();
            this.mulnumB = new System.Windows.Forms.Button();
            this.numberB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matrixA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.omatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // matrixA
            // 
            this.matrixA.AllowUserToAddRows = false;
            this.matrixA.AllowUserToDeleteRows = false;
            this.matrixA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixA.Location = new System.Drawing.Point(82, 40);
            this.matrixA.Name = "matrixA";
            this.matrixA.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.matrixA.Size = new System.Drawing.Size(240, 150);
            this.matrixA.TabIndex = 0;
            this.matrixA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.matrixA_CellContentClick);
            // 
            // matrixB
            // 
            this.matrixB.AllowUserToAddRows = false;
            this.matrixB.AllowUserToDeleteRows = false;
            this.matrixB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixB.Location = new System.Drawing.Point(484, 40);
            this.matrixB.Name = "matrixB";
            this.matrixB.Size = new System.Drawing.Size(240, 150);
            this.matrixB.TabIndex = 1;
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(365, 83);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 23);
            this.plus.TabIndex = 2;
            this.plus.Text = "A + B";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(365, 141);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(75, 23);
            this.multiply.TabIndex = 3;
            this.multiply.Text = "A * B";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(365, 112);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 23);
            this.minus.TabIndex = 4;
            this.minus.Text = "A - B";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // sizeB
            // 
            this.sizeB.Location = new System.Drawing.Point(558, 203);
            this.sizeB.Name = "sizeB";
            this.sizeB.Size = new System.Drawing.Size(45, 20);
            this.sizeB.TabIndex = 6;
            // 
            // size1
            // 
            this.size1.AutoSize = true;
            this.size1.Location = new System.Drawing.Point(91, 206);
            this.size1.Name = "size1";
            this.size1.Size = new System.Drawing.Size(56, 13);
            this.size1.TabIndex = 7;
            this.size1.Text = "Размер A";
            this.size1.Click += new System.EventHandler(this.size1_Click);
            // 
            // size2
            // 
            this.size2.AutoSize = true;
            this.size2.Location = new System.Drawing.Point(496, 206);
            this.size2.Name = "size2";
            this.size2.Size = new System.Drawing.Size(56, 13);
            this.size2.TabIndex = 8;
            this.size2.Text = "Размер B";
            // 
            // clean
            // 
            this.clean.Location = new System.Drawing.Point(365, 54);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(75, 23);
            this.clean.TabIndex = 13;
            this.clean.Text = "Очистить";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // createA
            // 
            this.createA.Location = new System.Drawing.Point(141, 12);
            this.createA.Name = "createA";
            this.createA.Size = new System.Drawing.Size(124, 23);
            this.createA.TabIndex = 14;
            this.createA.Text = "Создать матрицу";
            this.createA.UseVisualStyleBackColor = true;
            this.createA.Click += new System.EventHandler(this.createA_Click);
            // 
            // createB
            // 
            this.createB.Location = new System.Drawing.Point(545, 11);
            this.createB.Name = "createB";
            this.createB.Size = new System.Drawing.Size(124, 23);
            this.createB.TabIndex = 15;
            this.createB.Text = "Создать матрицу";
            this.createB.UseVisualStyleBackColor = true;
            this.createB.Click += new System.EventHandler(this.createB_Click);
            // 
            // omatrix
            // 
            this.omatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.omatrix.Location = new System.Drawing.Point(289, 260);
            this.omatrix.Name = "omatrix";
            this.omatrix.Size = new System.Drawing.Size(240, 150);
            this.omatrix.TabIndex = 16;
            this.omatrix.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.omatrix_CellContentClick);
            // 
            // transA
            // 
            this.transA.Location = new System.Drawing.Point(82, 266);
            this.transA.Name = "transA";
            this.transA.Size = new System.Drawing.Size(126, 33);
            this.transA.TabIndex = 17;
            this.transA.Text = "Транспонирование";
            this.transA.UseVisualStyleBackColor = true;
            this.transA.Click += new System.EventHandler(this.trans1_Click);
            // 
            // transB
            // 
            this.transB.Location = new System.Drawing.Point(598, 266);
            this.transB.Name = "transB";
            this.transB.Size = new System.Drawing.Size(126, 33);
            this.transB.TabIndex = 18;
            this.transB.Text = "Транспонирование";
            this.transB.UseVisualStyleBackColor = true;
            this.transB.Click += new System.EventHandler(this.button1_Click);
            // 
            // powA
            // 
            this.powA.Location = new System.Drawing.Point(82, 305);
            this.powA.Name = "powA";
            this.powA.Size = new System.Drawing.Size(126, 23);
            this.powA.TabIndex = 20;
            this.powA.Text = "Степень 2";
            this.powA.UseVisualStyleBackColor = true;
            this.powA.Click += new System.EventHandler(this.powA_Click);
            // 
            // powB
            // 
            this.powB.Location = new System.Drawing.Point(598, 305);
            this.powB.Name = "powB";
            this.powB.Size = new System.Drawing.Size(126, 23);
            this.powB.TabIndex = 21;
            this.powB.Text = "Степень 2";
            this.powB.UseVisualStyleBackColor = true;
            this.powB.Click += new System.EventHandler(this.powB_Click);
            // 
            // sizeA
            // 
            this.sizeA.Location = new System.Drawing.Point(153, 203);
            this.sizeA.Name = "sizeA";
            this.sizeA.Size = new System.Drawing.Size(45, 20);
            this.sizeA.TabIndex = 22;
            // 
            // minA
            // 
            this.minA.Location = new System.Drawing.Point(82, 334);
            this.minA.Name = "minA";
            this.minA.Size = new System.Drawing.Size(126, 35);
            this.minA.TabIndex = 23;
            this.minA.Text = "Минимальный элемент";
            this.minA.UseVisualStyleBackColor = true;
            this.minA.Click += new System.EventHandler(this.minA_Click);
            // 
            // maxA
            // 
            this.maxA.Location = new System.Drawing.Point(82, 375);
            this.maxA.Name = "maxA";
            this.maxA.Size = new System.Drawing.Size(126, 35);
            this.maxA.TabIndex = 24;
            this.maxA.Text = "Максимальный элемент";
            this.maxA.UseVisualStyleBackColor = true;
            this.maxA.Click += new System.EventHandler(this.maxA_Click);
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(344, 234);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(49, 20);
            this.answer.TabIndex = 25;
            // 
            // minB
            // 
            this.minB.Location = new System.Drawing.Point(598, 334);
            this.minB.Name = "minB";
            this.minB.Size = new System.Drawing.Size(126, 35);
            this.minB.TabIndex = 26;
            this.minB.Text = "Минимальный элемент";
            this.minB.UseVisualStyleBackColor = true;
            this.minB.Click += new System.EventHandler(this.minB_Click);
            // 
            // maxB
            // 
            this.maxB.Location = new System.Drawing.Point(598, 375);
            this.maxB.Name = "maxB";
            this.maxB.Size = new System.Drawing.Size(126, 35);
            this.maxB.TabIndex = 27;
            this.maxB.Text = "Максимальный элемент";
            this.maxB.UseVisualStyleBackColor = true;
            this.maxB.Click += new System.EventHandler(this.maxB_Click);
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(173, 239);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(35, 20);
            this.number.TabIndex = 28;
            // 
            // mulnum
            // 
            this.mulnum.Location = new System.Drawing.Point(82, 237);
            this.mulnum.Name = "mulnum";
            this.mulnum.Size = new System.Drawing.Size(85, 23);
            this.mulnum.TabIndex = 29;
            this.mulnum.Text = "A * x";
            this.mulnum.UseVisualStyleBackColor = true;
            this.mulnum.Click += new System.EventHandler(this.sumnum_Click);
            // 
            // mulnumB
            // 
            this.mulnumB.Location = new System.Drawing.Point(598, 237);
            this.mulnumB.Name = "mulnumB";
            this.mulnumB.Size = new System.Drawing.Size(85, 23);
            this.mulnumB.TabIndex = 30;
            this.mulnumB.Text = "B * x";
            this.mulnumB.UseVisualStyleBackColor = true;
            this.mulnumB.Click += new System.EventHandler(this.mulnumB_Click);
            // 
            // numberB
            // 
            this.numberB.Location = new System.Drawing.Point(689, 239);
            this.numberB.Name = "numberB";
            this.numberB.Size = new System.Drawing.Size(35, 20);
            this.numberB.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(298, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ответ:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberB);
            this.Controls.Add(this.mulnumB);
            this.Controls.Add(this.mulnum);
            this.Controls.Add(this.number);
            this.Controls.Add(this.maxB);
            this.Controls.Add(this.minB);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.maxA);
            this.Controls.Add(this.minA);
            this.Controls.Add(this.sizeA);
            this.Controls.Add(this.powB);
            this.Controls.Add(this.powA);
            this.Controls.Add(this.transB);
            this.Controls.Add(this.transA);
            this.Controls.Add(this.omatrix);
            this.Controls.Add(this.createB);
            this.Controls.Add(this.createA);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.size2);
            this.Controls.Add(this.size1);
            this.Controls.Add(this.sizeB);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.matrixB);
            this.Controls.Add(this.matrixA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.matrixA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.omatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView matrixB;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.TextBox sizeB;
        private System.Windows.Forms.Label size1;
        private System.Windows.Forms.Label size2;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Button createA;
        private System.Windows.Forms.Button createB;
        private System.Windows.Forms.DataGridView omatrix;
        private System.Windows.Forms.Button transA;
        private System.Windows.Forms.Button transB;
        private System.Windows.Forms.Button powA;
        private System.Windows.Forms.Button powB;
        private System.Windows.Forms.TextBox sizeA;
        private System.Windows.Forms.Button minA;
        private System.Windows.Forms.Button maxA;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.DataGridView matrixA;
        private System.Windows.Forms.Button minB;
        private System.Windows.Forms.Button maxB;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Button mulnum;
        private System.Windows.Forms.Button mulnumB;
        private System.Windows.Forms.TextBox numberB;
        private System.Windows.Forms.Label label1;
    }
}


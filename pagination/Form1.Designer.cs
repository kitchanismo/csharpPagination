namespace pagination
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lvitems = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnprev = new System.Windows.Forms.Button();
            this.lblpages = new System.Windows.Forms.Label();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btngoto = new System.Windows.Forms.Button();
            this.numIndex = new System.Windows.Forms.NumericUpDown();
            this.lblitems = new System.Windows.Forms.Label();
            this.lblitemPerPage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(595, 349);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 31);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(595, 402);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(273, 31);
            this.textBox2.TabIndex = 2;
            // 
            // lvitems
            // 
            this.lvitems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvitems.FullRowSelect = true;
            this.lvitems.GridLines = true;
            this.lvitems.Location = new System.Drawing.Point(12, 33);
            this.lvitems.Name = "lvitems";
            this.lvitems.Size = new System.Drawing.Size(308, 392);
            this.lvitems.TabIndex = 3;
            this.lvitems.UseCompatibleStateImageBehavior = false;
            this.lvitems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 68;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "itemname";
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "qty";
            this.columnHeader3.Width = 107;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(110, 440);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(35, 31);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(151, 440);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(35, 31);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(233, 440);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(35, 31);
            this.btnnext.TabIndex = 6;
            this.btnnext.Text = ">>";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(274, 440);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(35, 31);
            this.btnlast.TabIndex = 7;
            this.btnlast.Text = "last";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnprev
            // 
            this.btnprev.Location = new System.Drawing.Point(67, 440);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(35, 31);
            this.btnprev.TabIndex = 8;
            this.btnprev.Text = "<<";
            this.btnprev.UseVisualStyleBackColor = true;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // lblpages
            // 
            this.lblpages.AutoSize = true;
            this.lblpages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpages.Location = new System.Drawing.Point(203, 490);
            this.lblpages.Name = "lblpages";
            this.lblpages.Size = new System.Drawing.Size(36, 20);
            this.lblpages.TabIndex = 9;
            this.lblpages.Text = "of n";
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(26, 440);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(35, 31);
            this.btnfirst.TabIndex = 10;
            this.btnfirst.Text = "first";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(192, 440);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(35, 31);
            this.btn3.TabIndex = 11;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btngoto
            // 
            this.btngoto.Location = new System.Drawing.Point(80, 484);
            this.btngoto.Name = "btngoto";
            this.btngoto.Size = new System.Drawing.Size(76, 31);
            this.btngoto.TabIndex = 13;
            this.btngoto.Text = "go to page";
            this.btngoto.UseVisualStyleBackColor = true;
            this.btngoto.Click += new System.EventHandler(this.btngoto_Click);
            // 
            // numIndex
            // 
            this.numIndex.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numIndex.Location = new System.Drawing.Point(162, 486);
            this.numIndex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIndex.Name = "numIndex";
            this.numIndex.Size = new System.Drawing.Size(41, 27);
            this.numIndex.TabIndex = 14;
            this.numIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numIndex.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numIndex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblitems
            // 
            this.lblitems.AutoSize = true;
            this.lblitems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitems.Location = new System.Drawing.Point(12, 10);
            this.lblitems.Name = "lblitems";
            this.lblitems.Size = new System.Drawing.Size(18, 20);
            this.lblitems.TabIndex = 15;
            this.lblitems.Text = "n";
            // 
            // lblitemPerPage
            // 
            this.lblitemPerPage.AutoSize = true;
            this.lblitemPerPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemPerPage.Location = new System.Drawing.Point(183, 9);
            this.lblitemPerPage.Name = "lblitemPerPage";
            this.lblitemPerPage.Size = new System.Drawing.Size(18, 20);
            this.lblitemPerPage.TabIndex = 16;
            this.lblitemPerPage.Text = "n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 529);
            this.Controls.Add(this.lblitemPerPage);
            this.Controls.Add(this.lblitems);
            this.Controls.Add(this.numIndex);
            this.Controls.Add(this.btngoto);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.btnprev);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lvitems);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblpages);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Pagination";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListView lvitems;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.Label lblpages;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btngoto;
        private System.Windows.Forms.NumericUpDown numIndex;
        private System.Windows.Forms.Label lblitems;
        private System.Windows.Forms.Label lblitemPerPage;
    }
}


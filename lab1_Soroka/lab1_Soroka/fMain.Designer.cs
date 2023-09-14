namespace lab1_Soroka
{
    partial class fMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnMain = new Panel();
            pnTools = new Panel();
            btnRightFar = new Button();
            btnRight = new Button();
            btnLeftFar = new Button();
            btnLeft = new Button();
            btnDownFar = new Button();
            btnDown = new Button();
            btnCollapse = new Button();
            btnExpand = new Button();
            btnUp = new Button();
            btnUpFar = new Button();
            btnShow = new Button();
            btnHide = new Button();
            btnCreateNew = new Button();
            cbCircles = new ComboBox();
            label1 = new Label();
            pnTools.SuspendLayout();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.White;
            pnMain.BorderStyle = BorderStyle.FixedSingle;
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(0, 0);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(800, 450);
            pnMain.TabIndex = 0;
            // 
            // pnTools
            // 
            pnTools.Controls.Add(btnRightFar);
            pnTools.Controls.Add(btnRight);
            pnTools.Controls.Add(btnLeftFar);
            pnTools.Controls.Add(btnLeft);
            pnTools.Controls.Add(btnDownFar);
            pnTools.Controls.Add(btnDown);
            pnTools.Controls.Add(btnCollapse);
            pnTools.Controls.Add(btnExpand);
            pnTools.Controls.Add(btnUp);
            pnTools.Controls.Add(btnUpFar);
            pnTools.Controls.Add(btnShow);
            pnTools.Controls.Add(btnHide);
            pnTools.Controls.Add(btnCreateNew);
            pnTools.Controls.Add(cbCircles);
            pnTools.Controls.Add(label1);
            pnTools.Dock = DockStyle.Right;
            pnTools.Location = new Point(504, 0);
            pnTools.Name = "pnTools";
            pnTools.Size = new Size(296, 450);
            pnTools.TabIndex = 1;
            // 
            // btnRightFar
            // 
            btnRightFar.Location = new Point(242, 271);
            btnRightFar.Name = "btnRightFar";
            btnRightFar.Size = new Size(45, 52);
            btnRightFar.TabIndex = 14;
            btnRightFar.Text = "btnRightFar";
            btnRightFar.UseVisualStyleBackColor = true;
            btnRightFar.Click += btnRightFar_Click;
            // 
            // btnRight
            // 
            btnRight.Location = new Point(193, 271);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(45, 52);
            btnRight.TabIndex = 13;
            btnRight.Text = "btnRight";
            btnRight.UseVisualStyleBackColor = true;
            btnRight.Click += btnRight_Click;
            // 
            // btnLeftFar
            // 
            btnLeftFar.Location = new Point(15, 271);
            btnLeftFar.Name = "btnLeftFar";
            btnLeftFar.Size = new Size(45, 52);
            btnLeftFar.TabIndex = 12;
            btnLeftFar.Text = "btnLeftFar";
            btnLeftFar.UseVisualStyleBackColor = true;
            btnLeftFar.Click += btnLeftFar_Click;
            // 
            // btnLeft
            // 
            btnLeft.Location = new Point(66, 271);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(45, 52);
            btnLeft.TabIndex = 11;
            btnLeft.Text = "btnLeft";
            btnLeft.UseVisualStyleBackColor = true;
            btnLeft.Click += btnLeft_Click;
            // 
            // btnDownFar
            // 
            btnDownFar.Location = new Point(112, 358);
            btnDownFar.Name = "btnDownFar";
            btnDownFar.Size = new Size(75, 23);
            btnDownFar.TabIndex = 10;
            btnDownFar.Text = "btnDownFar";
            btnDownFar.UseVisualStyleBackColor = true;
            btnDownFar.Click += btnDownFar_Click;
            // 
            // btnDown
            // 
            btnDown.Location = new Point(112, 329);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(75, 23);
            btnDown.TabIndex = 9;
            btnDown.Text = "btnDown";
            btnDown.UseVisualStyleBackColor = true;
            btnDown.Click += btnDown_Click;
            // 
            // btnCollapse
            // 
            btnCollapse.Location = new Point(112, 300);
            btnCollapse.Name = "btnCollapse";
            btnCollapse.Size = new Size(75, 23);
            btnCollapse.TabIndex = 8;
            btnCollapse.Text = "btnCollapse";
            btnCollapse.UseVisualStyleBackColor = true;
            btnCollapse.Click += btnCollapse_Click;
            // 
            // btnExpand
            // 
            btnExpand.Location = new Point(112, 271);
            btnExpand.Name = "btnExpand";
            btnExpand.Size = new Size(75, 23);
            btnExpand.TabIndex = 7;
            btnExpand.Text = "btnExpand";
            btnExpand.UseVisualStyleBackColor = true;
            btnExpand.Click += btnExpand_Click;
            // 
            // btnUp
            // 
            btnUp.Location = new Point(112, 242);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(75, 23);
            btnUp.TabIndex = 6;
            btnUp.Text = "btnUp";
            btnUp.UseVisualStyleBackColor = true;
            btnUp.Click += btnUp_Click;
            // 
            // btnUpFar
            // 
            btnUpFar.Location = new Point(112, 213);
            btnUpFar.Name = "btnUpFar";
            btnUpFar.Size = new Size(75, 23);
            btnUpFar.TabIndex = 5;
            btnUpFar.Text = "btnUpFar";
            btnUpFar.UseVisualStyleBackColor = true;
            btnUpFar.Click += btnUpFar_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(13, 153);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(273, 41);
            btnShow.TabIndex = 4;
            btnShow.Text = "\"Показати об'єкт\"";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnHide
            // 
            btnHide.Location = new Point(14, 110);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(273, 37);
            btnHide.TabIndex = 3;
            btnHide.Text = "\"Приховати об'єкт\"";
            btnHide.UseVisualStyleBackColor = true;
            btnHide.Click += btnHide_Click;
            // 
            // btnCreateNew
            // 
            btnCreateNew.Location = new Point(14, 64);
            btnCreateNew.Name = "btnCreateNew";
            btnCreateNew.Size = new Size(273, 40);
            btnCreateNew.TabIndex = 2;
            btnCreateNew.Text = "\"Створити новий об’єкт\"";
            btnCreateNew.UseVisualStyleBackColor = true;
            btnCreateNew.Click += btnCreateNew_Click;
            // 
            // cbCircles
            // 
            cbCircles.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCircles.FormattingEnabled = true;
            cbCircles.Location = new Point(14, 35);
            cbCircles.Name = "cbCircles";
            cbCircles.Size = new Size(273, 23);
            cbCircles.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 17);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Перелiк об'єктiв";
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnTools);
            Controls.Add(pnMain);
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторна робота №1_Сорока";
            Load += fMain_Load;
            pnTools.ResumeLayout(false);
            pnTools.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMain;
        private Panel pnTools;
        private Button btnRightFar;
        private Button btnRight;
        private Button btnLeftFar;
        private Button btnLeft;
        private Button btnDownFar;
        private Button btnDown;
        private Button btnCollapse;
        private Button btnExpand;
        private Button btnUp;
        private Button btnUpFar;
        private Button btnShow;
        private Button btnHide;
        private Button btnCreateNew;
        private ComboBox cbCircles;
        private Label label1;
    }
}
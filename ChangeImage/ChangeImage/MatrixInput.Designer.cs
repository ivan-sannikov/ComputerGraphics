namespace ChangeImage
{
    partial class MatrixInput
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            RowsTextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            splitter2 = new Splitter();
            bindingSource1 = new BindingSource(components);
            button3 = new Button();
            MatrixInputContainer = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(231, 28);
            label1.TabIndex = 0;
            label1.Text = "Размер матрицы (N x N)";
            // 
            // RowsTextBox
            // 
            RowsTextBox.Location = new Point(12, 62);
            RowsTextBox.Name = "RowsTextBox";
            RowsTextBox.Size = new Size(334, 23);
            RowsTextBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(191, 531);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(281, 531);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(0, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(3, 566);
            splitter2.TabIndex = 9;
            splitter2.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(9, 101);
            button3.Name = "button3";
            button3.Size = new Size(338, 23);
            button3.TabIndex = 10;
            button3.Text = "Создать матрицу";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // MatrixInputContainer
            // 
            MatrixInputContainer.AutoScroll = true;
            MatrixInputContainer.ColumnCount = 2;
            MatrixInputContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            MatrixInputContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            MatrixInputContainer.Location = new Point(15, 148);
            MatrixInputContainer.Name = "MatrixInputContainer";
            MatrixInputContainer.RowCount = 2;
            MatrixInputContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            MatrixInputContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            MatrixInputContainer.Size = new Size(331, 366);
            MatrixInputContainer.TabIndex = 11;
            // 
            // MatrixInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 566);
            Controls.Add(MatrixInputContainer);
            Controls.Add(button3);
            Controls.Add(splitter2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(RowsTextBox);
            Controls.Add(label1);
            Name = "MatrixInput";
            Text = "MatrixInput";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private TextBox RowsTextBox;
        private Button button1;
        private Button button2;
        private Splitter splitter2;
        private BindingSource bindingSource1;
        private Button button3;
        private TableLayoutPanel MatrixInputContainer;
    }
}
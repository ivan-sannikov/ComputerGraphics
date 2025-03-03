namespace ChangeImage
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            фильтрыToolStripMenuItem = new ToolStripMenuItem();
            точечныеToolStripMenuItem = new ToolStripMenuItem();
            инверсияToolStripMenuItem = new ToolStripMenuItem();
            оттенкиСерогоToolStripMenuItem = new ToolStripMenuItem();
            сепияToolStripMenuItem = new ToolStripMenuItem();
            яркостьToolStripMenuItem = new ToolStripMenuItem();
            серыйМирToolStripMenuItem = new ToolStripMenuItem();
            эффектСтеклаToolStripMenuItem = new ToolStripMenuItem();
            волныToolStripMenuItem = new ToolStripMenuItem();
            горизонтальныеToolStripMenuItem = new ToolStripMenuItem();
            вертикальныеToolStripMenuItem = new ToolStripMenuItem();
            медианаToolStripMenuItem = new ToolStripMenuItem();
            линейноеРастяжениеГистограммыToolStripMenuItem = new ToolStripMenuItem();
            матричныеToolStripMenuItem = new ToolStripMenuItem();
            размытиеToolStripMenuItem = new ToolStripMenuItem();
            фильтрГауссаToolStripMenuItem = new ToolStripMenuItem();
            фильтрСобеляToolStripMenuItem = new ToolStripMenuItem();
            резкостьToolStripMenuItem = new ToolStripMenuItem();
            выделеToolStripMenuItem = new ToolStripMenuItem();
            операторЩарраToolStripMenuItem = new ToolStripMenuItem();
            операторПрюиттаToolStripMenuItem = new ToolStripMenuItem();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            progressBar1 = new ProgressBar();
            button1 = new Button();
            тиснениеToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 387);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, фильтрыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(121, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // фильтрыToolStripMenuItem
            // 
            фильтрыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { точечныеToolStripMenuItem, матричныеToolStripMenuItem });
            фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            фильтрыToolStripMenuItem.Size = new Size(69, 20);
            фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // точечныеToolStripMenuItem
            // 
            точечныеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { инверсияToolStripMenuItem, оттенкиСерогоToolStripMenuItem, сепияToolStripMenuItem, яркостьToolStripMenuItem, серыйМирToolStripMenuItem, эффектСтеклаToolStripMenuItem, волныToolStripMenuItem, медианаToolStripMenuItem, линейноеРастяжениеГистограммыToolStripMenuItem });
            точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            точечныеToolStripMenuItem.Size = new Size(180, 22);
            точечныеToolStripMenuItem.Text = "Точечные";
            // 
            // инверсияToolStripMenuItem
            // 
            инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            инверсияToolStripMenuItem.Size = new Size(275, 22);
            инверсияToolStripMenuItem.Text = "Инверсия";
            инверсияToolStripMenuItem.Click += инверсияToolStripMenuItem_Click;
            // 
            // оттенкиСерогоToolStripMenuItem
            // 
            оттенкиСерогоToolStripMenuItem.Name = "оттенкиСерогоToolStripMenuItem";
            оттенкиСерогоToolStripMenuItem.Size = new Size(275, 22);
            оттенкиСерогоToolStripMenuItem.Text = "Оттенки серого";
            оттенкиСерогоToolStripMenuItem.Click += оттенкиСерогоToolStripMenuItem_Click;
            // 
            // сепияToolStripMenuItem
            // 
            сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
            сепияToolStripMenuItem.Size = new Size(275, 22);
            сепияToolStripMenuItem.Text = "Сепия";
            сепияToolStripMenuItem.Click += сепияToolStripMenuItem_Click;
            // 
            // яркостьToolStripMenuItem
            // 
            яркостьToolStripMenuItem.Name = "яркостьToolStripMenuItem";
            яркостьToolStripMenuItem.Size = new Size(275, 22);
            яркостьToolStripMenuItem.Text = "Яркость";
            яркостьToolStripMenuItem.Click += яркостьToolStripMenuItem_Click;
            // 
            // серыйМирToolStripMenuItem
            // 
            серыйМирToolStripMenuItem.Name = "серыйМирToolStripMenuItem";
            серыйМирToolStripMenuItem.Size = new Size(275, 22);
            серыйМирToolStripMenuItem.Text = "Серый мир";
            серыйМирToolStripMenuItem.Click += серыйМирToolStripMenuItem_Click;
            // 
            // эффектСтеклаToolStripMenuItem
            // 
            эффектСтеклаToolStripMenuItem.Name = "эффектСтеклаToolStripMenuItem";
            эффектСтеклаToolStripMenuItem.Size = new Size(275, 22);
            эффектСтеклаToolStripMenuItem.Text = "Эффект стекла";
            эффектСтеклаToolStripMenuItem.Click += эффектСтеклаToolStripMenuItem_Click;
            // 
            // волныToolStripMenuItem
            // 
            волныToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { горизонтальныеToolStripMenuItem, вертикальныеToolStripMenuItem });
            волныToolStripMenuItem.Name = "волныToolStripMenuItem";
            волныToolStripMenuItem.Size = new Size(275, 22);
            волныToolStripMenuItem.Text = "Волны";
            // 
            // горизонтальныеToolStripMenuItem
            // 
            горизонтальныеToolStripMenuItem.Name = "горизонтальныеToolStripMenuItem";
            горизонтальныеToolStripMenuItem.Size = new Size(166, 22);
            горизонтальныеToolStripMenuItem.Text = "Горизонтальные";
            горизонтальныеToolStripMenuItem.Click += горизонтальныеToolStripMenuItem_Click;
            // 
            // вертикальныеToolStripMenuItem
            // 
            вертикальныеToolStripMenuItem.Name = "вертикальныеToolStripMenuItem";
            вертикальныеToolStripMenuItem.Size = new Size(166, 22);
            вертикальныеToolStripMenuItem.Text = "Вертикальные";
            вертикальныеToolStripMenuItem.Click += вертикальныеToolStripMenuItem_Click;
            // 
            // медианаToolStripMenuItem
            // 
            медианаToolStripMenuItem.Name = "медианаToolStripMenuItem";
            медианаToolStripMenuItem.Size = new Size(275, 22);
            медианаToolStripMenuItem.Text = "Медиана";
            медианаToolStripMenuItem.Click += медианаToolStripMenuItem_Click;
            // 
            // линейноеРастяжениеГистограммыToolStripMenuItem
            // 
            линейноеРастяжениеГистограммыToolStripMenuItem.Name = "линейноеРастяжениеГистограммыToolStripMenuItem";
            линейноеРастяжениеГистограммыToolStripMenuItem.Size = new Size(275, 22);
            линейноеРастяжениеГистограммыToolStripMenuItem.Text = "Линейное растяжение гистограммы";
            линейноеРастяжениеГистограммыToolStripMenuItem.Click += линейноеРастяжениеГистограммыToolStripMenuItem_Click;
            // 
            // матричныеToolStripMenuItem
            // 
            матричныеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { размытиеToolStripMenuItem, фильтрГауссаToolStripMenuItem, фильтрСобеляToolStripMenuItem, резкостьToolStripMenuItem, выделеToolStripMenuItem, тиснениеToolStripMenuItem });
            матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            матричныеToolStripMenuItem.Size = new Size(180, 22);
            матричныеToolStripMenuItem.Text = "Матричные";
            // 
            // размытиеToolStripMenuItem
            // 
            размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            размытиеToolStripMenuItem.Size = new Size(180, 22);
            размытиеToolStripMenuItem.Text = "Размытие";
            размытиеToolStripMenuItem.Click += размытиеToolStripMenuItem_Click;
            // 
            // фильтрГауссаToolStripMenuItem
            // 
            фильтрГауссаToolStripMenuItem.Name = "фильтрГауссаToolStripMenuItem";
            фильтрГауссаToolStripMenuItem.Size = new Size(180, 22);
            фильтрГауссаToolStripMenuItem.Text = "Фильтр Гаусса";
            фильтрГауссаToolStripMenuItem.Click += фильтрГауссаToolStripMenuItem_Click;
            // 
            // фильтрСобеляToolStripMenuItem
            // 
            фильтрСобеляToolStripMenuItem.Name = "фильтрСобеляToolStripMenuItem";
            фильтрСобеляToolStripMenuItem.Size = new Size(180, 22);
            фильтрСобеляToolStripMenuItem.Text = "Фильтр Собеля";
            фильтрСобеляToolStripMenuItem.Click += фильтрСобеляToolStripMenuItem_Click;
            // 
            // резкостьToolStripMenuItem
            // 
            резкостьToolStripMenuItem.Name = "резкостьToolStripMenuItem";
            резкостьToolStripMenuItem.Size = new Size(180, 22);
            резкостьToolStripMenuItem.Text = "Резкость";
            резкостьToolStripMenuItem.Click += резкостьToolStripMenuItem_Click;
            // 
            // выделеToolStripMenuItem
            // 
            выделеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { операторЩарраToolStripMenuItem, операторПрюиттаToolStripMenuItem });
            выделеToolStripMenuItem.Name = "выделеToolStripMenuItem";
            выделеToolStripMenuItem.Size = new Size(180, 22);
            выделеToolStripMenuItem.Text = "Выделение границ";
            // 
            // операторЩарраToolStripMenuItem
            // 
            операторЩарраToolStripMenuItem.Name = "операторЩарраToolStripMenuItem";
            операторЩарраToolStripMenuItem.Size = new Size(180, 22);
            операторЩарраToolStripMenuItem.Text = "Оператор Щарра";
            операторЩарраToolStripMenuItem.Click += операторЩарраToolStripMenuItem_Click;
            // 
            // операторПрюиттаToolStripMenuItem
            // 
            операторПрюиттаToolStripMenuItem.Name = "операторПрюиттаToolStripMenuItem";
            операторПрюиттаToolStripMenuItem.Size = new Size(180, 22);
            операторПрюиттаToolStripMenuItem.Text = "Оператор Прюитта";
            операторПрюиттаToolStripMenuItem.Click += операторПрюиттаToolStripMenuItem_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 420);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(689, 23);
            progressBar1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(713, 420);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Открыть";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // тиснениеToolStripMenuItem
            // 
            тиснениеToolStripMenuItem.Name = "тиснениеToolStripMenuItem";
            тиснениеToolStripMenuItem.Size = new Size(180, 22);
            тиснениеToolStripMenuItem.Text = "Тиснение";
            тиснениеToolStripMenuItem.Click += тиснениеToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem фильтрыToolStripMenuItem;
        private ToolStripMenuItem точечныеToolStripMenuItem;
        private ToolStripMenuItem инверсияToolStripMenuItem;
        private ToolStripMenuItem матричныеToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ProgressBar progressBar1;
        private Button button1;
        private ToolStripMenuItem размытиеToolStripMenuItem;
        private ToolStripMenuItem фильтрГауссаToolStripMenuItem;
        private ToolStripMenuItem оттенкиСерогоToolStripMenuItem;
        private ToolStripMenuItem сепияToolStripMenuItem;
        private ToolStripMenuItem яркостьToolStripMenuItem;
        private ToolStripMenuItem фильтрСобеляToolStripMenuItem;
        private ToolStripMenuItem резкостьToolStripMenuItem;
        private ToolStripMenuItem серыйМирToolStripMenuItem;
        private ToolStripMenuItem эффектСтеклаToolStripMenuItem;
        private ToolStripMenuItem волныToolStripMenuItem;
        private ToolStripMenuItem горизонтальныеToolStripMenuItem;
        private ToolStripMenuItem вертикальныеToolStripMenuItem;
        private ToolStripMenuItem выделеToolStripMenuItem;
        private ToolStripMenuItem операторЩарраToolStripMenuItem;
        private ToolStripMenuItem операторПрюиттаToolStripMenuItem;
        private ToolStripMenuItem медианаToolStripMenuItem;
        private ToolStripMenuItem линейноеРастяжениеГистограммыToolStripMenuItem;
        private ToolStripMenuItem тиснениеToolStripMenuItem;
    }
}
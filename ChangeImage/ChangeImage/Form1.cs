using ChangeImage.PointFilters;

namespace ChangeImage
{
    public partial class Form1 : Form
    {
        Bitmap image;
        public Form1()
        {
            InitializeComponent();
        }

        private void îòêğûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files|*.png;*.jpg;.bmp|All file(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(ofd.FileName);
            }
            pictureBox1.Image = image;
            pictureBox1.Refresh();
        }

        private void èíâåğñèÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvertFilter invert = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(invert);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filters)e.Argument).proccesImage(image, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true) image = newImage;
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;
        }

        private void ğàçìûòèåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);

        }

        private void ôèëüòğÃàóññàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filters = new GaussFilter();
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void îòòåíêèÑåğîãîToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filters = new GrayScaleFilter();
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void ñåïèÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filters = new SepiaFilter();
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void ÿğêîñòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filters = new BrightnessFilter();
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void ôèëüòğÑîáåëÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filters = new SobelFilter();
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void ğåçêîñòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filters = new SharpnessFilter();
            backgroundWorker1.RunWorkerAsync(filters);

        }

        private void ñåğûéÌèğToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filters = new GrayWorldFilter();
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void ıôôåêòÑòåêëàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filters = new GlassEffectFilter();
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void ãîğèçîíòàëüíûåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filters = new HorizontalWaveFilter();
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void âåğòèêàëüíûåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filters = new VerticalWaveFilter();
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void îïåğàòîğÙàğğàToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Filters filters = new SharFilter();
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void îïåğàòîğÏğşèòòàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filters = new PryitFilter();
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void ìåäèàíàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filters = new MedianFilter();
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void ëèíåéíîåĞàñòÿæåíèåÃèñòîãğàììûToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filters = new LinGistFilter();
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void òèñíåíèåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filters = new EmbossingFilter();
            backgroundWorker1.RunWorkerAsync(filters);
        }
    }
}
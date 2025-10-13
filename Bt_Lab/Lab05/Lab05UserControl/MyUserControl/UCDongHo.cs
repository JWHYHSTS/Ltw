namespace MyUserControl
{
    public partial class UCDongHo : UserControl
    {
        private DateTime startTime;

        public UCDongHo()
        {
            InitializeComponent();
        }

        const string TEXT_START = "START";
        const string TEXT_STOP = "STOP";
        private void btnstart_Click(object sender, EventArgs e)
        {
            if (btnstart.Text == TEXT_START)
            {
                btnstart.Text = TEXT_STOP;
                timer1.Enabled = true;
                startTime = DateTime.Now;
            }
            else
            {
                btnstart.Text = TEXT_START;
                timer1.Enabled = false;
                List<TimeSpan> timeSpans = new List<TimeSpan>();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbldongho.Text = (DateTime.Now - startTime).ToString(@"hh\:mm\:ss\:ffff");
        }

        List<TimeSpan> timeSpans = new List<TimeSpan>();
        const int MAX_COUNT = 5;
        private void btnlap_Click(object sender, EventArgs e)
        {
                // Tính thời gian và ghi nhận vào file 
                var thoigian = DateTime.Now - startTime;
                timeSpans.Add(thoigian);
                var content = timeSpans.Select((t, i) => $"{i + 1}. {t:hh\\:mm\\:ss\\:ffff}")
                    .Take(MAX_COUNT);
                File.WriteAllText("lap.txt", string.Join(Environment.NewLine, content));
            if (timeSpans.Count == MAX_COUNT)
            {
                btnstart.Text = TEXT_START;
                timer1.Enabled = false;
                timeSpans.Clear();
            }
        }
    }
}

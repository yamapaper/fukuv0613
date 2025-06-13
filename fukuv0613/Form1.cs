namespace fukuv0613
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -20;
        
        public Form1()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var mpos = MousePosition;
            var fpos = PointToClient(mpos);
            Text = $"{mpos.X}, {mpos.Y} / {fpos.X}, {fpos.Y}";
            label1.Left += vx;
            label1.Top += vy;
            if (label1.Left < 0)
            {
                
                vx = -vx;
                label1.Left += vx;
            }
            else if (label1.Right > this.ClientSize.Width)
            {               
                vx = -vx;                
                label1.Left += vx;
            }
        }
    }
}

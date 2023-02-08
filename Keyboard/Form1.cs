namespace Keyboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }
        private void BackSpace_CheckedChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{BACKSPACE}");
        }

        private void Enter_CheckedChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");  
        }

        private void Space_CheckedChanged(object sender, EventArgs e)
        {
            SendKeys.Send(" ");   
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(10, 500);
        }
    }
}
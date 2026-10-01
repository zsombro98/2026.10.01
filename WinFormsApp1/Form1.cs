namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnKek.Click += BtnKek_Click;
            btnWhiteBg.Click += BtnWhiteBg_Click;
            btnMiddleCenter.Click += BtnMiddleCenter_Click;
            btnMiddleLeft.Click += BtnMiddleLeft_Click;
            btnMiddleRight.Click += BtnMiddleRight_Click;
            btnDelete.Click += BtnDelete_Click;
            btnUppercase.Click += BtnUppercase_Click;
            btnBiggerFont.Click += BtnBiggerFont_Click;
            btnSmallerFont.Click += BtnSmallerFont_Click;
            btnReset.Click += BtnReset_Click;
            btnExit.Click += BtnExit_Click;
        }

        private void BtnExit_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnReset_Click(object? sender, EventArgs e)
        {
            lblHelloWorld.ForeColor = Color.Black;
            lblHelloWorld.BackColor = Color.White;
            lblHelloWorld.Font = new("Segoe", 20F);
            lblHelloWorld.TextAlign = ContentAlignment.TopLeft;
            lblHelloWorld.Text = "hello Wold";
        }

        private void BtnSmallerFont_Click(object? sender, EventArgs e)
        {
            float emsize = lblHelloWorld.Font.Size -2;
            if (emsize <= 0) return;

            lblHelloWorld.Font = new("Segoe", emsize);
        }

        private void BtnBiggerFont_Click(object? sender, EventArgs e)
        { 

            float Size = lblHelloWorld.Font.Size;
             lblHelloWorld.Font = new("Segoe", ++Size);
        }
        private void BtnUppercase_Click(object? sender, EventArgs e)
         
            => lblHelloWorld.Text = lblHelloWorld.Text.ToUpper();

        private void BtnDelete_Click(object? sender, EventArgs e)
        
            =>lblHelloWorld.Text = string.Empty;

        private void BtnMiddleRight_Click(object? sender, EventArgs e)

            => lblHelloWorld.TextAlign = ContentAlignment.MiddleRight;

        private void BtnMiddleLeft_Click(object? sender, EventArgs e)

            => lblHelloWorld.TextAlign = ContentAlignment.MiddleLeft;

        private void BtnMiddleCenter_Click(object? sender, EventArgs e)

            => lblHelloWorld.TextAlign = ContentAlignment.MiddleCenter;  
  

        private void BtnWhiteBg_Click(object? sender, EventArgs e)
        
            => lblHelloWorld.BackColor = Color.White;    
        

        private void BtnKek_Click(object? sender, EventArgs e)
         
            => lblHelloWorld.ForeColor = Color.Blue;
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

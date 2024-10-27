using System.Diagnostics;

namespace VirtualVendingMachine
{
    public partial class VirtualVendingMachine : Form
    {
        public VirtualVendingMachine()
        {
            InitializeComponent();
            PepsiBtn.Name = COLA;
            RootBeerBtn.Name = ROOTB;
            LemonLimeBtn.Name = LEMONLIME;
            GrapeBtn.Name = GRAPE;
            CreamBtn.Name = CREAM;
            Title.Image = Image.FromFile($"{path}logo.png");
            OutputBox.Image = Image.FromFile($"{path}pickUp.png");

            StockVendingMachine();
        }

        private VendingMachine machine;


        const string COLA = "Pepsi-Cola";
        const string ROOTB = "A&W Root Beer";
        const string LEMONLIME = "Lemon Lime 7UP";
        const string GRAPE = "Fanta Grape";
        const string CREAM = "A&W Cream";

        readonly string path = AppDomain.CurrentDomain.BaseDirectory + @"Images\";

        private void StockVendingMachine()
        {
            machine = new VendingMachine();

            machine.StockMachine(BuildOptions());



            PepsiBtn.Image = Image.FromFile($"{path}{machine.FindSoda(COLA).vendingLabelImage}.png");
            RootBeerBtn.Image = Image.FromFile($"{path}{machine.FindSoda(ROOTB).vendingLabelImage}.png");
            LemonLimeBtn.Image = Image.FromFile($"{path}{machine.FindSoda(LEMONLIME).vendingLabelImage}.png");
            GrapeBtn.Image = Image.FromFile($"{path}{machine.FindSoda(GRAPE).vendingLabelImage}.png");
            CreamBtn.Image = Image.FromFile($"{path}{machine.FindSoda(CREAM).vendingLabelImage}.png");


        }

        private void BuyClick(object sender, EventArgs e)
        {
            Button hoveredButton = sender as Button;

            if (hoveredButton is null)
            {
                return;
            }

            Soda soda = machine.FindSoda(hoveredButton.Name);

            string resultImage = machine.BuySoda(soda.name);

            if (resultImage == VendingMachine.OUT_OF_STOCK)
            {
                hoveredButton.Image = Image.FromFile($"{path}{resultImage}.png");
                OutputText.Text = "";
                CanBox.Visible = false;
            }
            else
            {
                OutputText.ForeColor = Color.White;
                OutputText.Text = $"You Got {soda.name} \nfor {soda.price.ToString("C")}";
                OutputText.Font = new Font(OutputText.Font.FontFamily, 13, FontStyle.Italic);

                CanBox.Visible = true;
                CanBox.Image = Image.FromFile($"{path}{resultImage}.png");
            }
        }
        private void PriceHover(object sender, EventArgs e)
        {

            Button hoveredButton = sender as Button;

            if (hoveredButton is null)
            {
                return;
            }

            decimal priceToDisplay = machine.FindSoda(hoveredButton?.Name).price;

            OutputText.ForeColor = Color.DarkRed;
            OutputText.Text = hoveredButton?.Name + ": " + priceToDisplay.ToString("C");
            OutputText.Font = new Font(OutputText.Font.FontFamily, 13, FontStyle.Bold);
        }

        private List<Soda> BuildOptions()
        {
            List<Soda> opts = new List<Soda>() {
                new Soda
                {
                    amount = 20,
                    name = COLA,
                    canImage ="pepsiCan",
                    vendingLabelImage = "pepsiLabel",
                    price = 1M
                },
                 new Soda
                {
                    amount = 20,
                    name = ROOTB,
                    canImage ="rootbeerCan",
                    vendingLabelImage = "rootbeerLabel",
                    price = 1M
                },
                  new Soda
                {
                    amount = 20,
                    name = LEMONLIME,
                    canImage ="lemonlimeCan",
                    vendingLabelImage = "lemonlimeLabel",
                    price = 1M
                },
                   new Soda
                {
                    amount = 20,
                    name = GRAPE,
                    canImage ="grapeCan",
                    vendingLabelImage = "grapeLabel",
                    price = 1.5M
                },
                      new Soda
                {
                    amount = 20,
                    name = CREAM,
                    canImage ="creamCan",
                    vendingLabelImage = "creamLabel",
                    price = 1.5M
                }
            };

            return opts;
        }

    
    }
}

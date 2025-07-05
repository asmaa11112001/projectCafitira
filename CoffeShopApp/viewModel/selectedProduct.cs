using System.ComponentModel;

namespace CoffeShopApp.viewModel
{
    public class selectedProduct : INotifyPropertyChanged
    {
        public int ProductId { get; set; }

        private string productName;
        public string ProductName
        {
            get => productName;
            set { productName = value; OnPropertyChanged(nameof(ProductName)); }
        }

        private double price;
        public double Price
        {
            get => price;
            set { price = value; OnPropertyChanged(nameof(Price)); OnPropertyChanged(nameof(Total)); }
        }

        private int quantity;
        public int Quantity
        {
            get => quantity;
            set { quantity = value; OnPropertyChanged(nameof(Quantity)); OnPropertyChanged(nameof(Total)); }
        }

        public double Total => Price * Quantity;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

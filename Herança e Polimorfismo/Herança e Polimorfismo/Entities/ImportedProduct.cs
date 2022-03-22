using System.Globalization;
namespace Herança_e_Polimorfismo.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }
        public ImportedProduct()
        {
        }
        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
           CustomsFee = 20.0;
        }    

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
        public override string PriceTag()
        {
            return Name
                  + " $ "
                  + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                  + " (Customs fee: $ "
                  + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)
                  + ")";
        }
    }

}

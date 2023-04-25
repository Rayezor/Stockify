namespace Stockify.Models
{
    public class Portfolio1
    {
        private List<PortfolioCrypto> _crypto;

        public Portfolio1()
        {
            _crypto = new List<PortfolioCrypto>();
        }

        public void AddCrypto(Crypto crypto)
        {
            var match = _crypto.FirstOrDefault(x => x.Id == crypto.Id);
            if (match == null)
            {
                _crypto.Add(new PortfolioCrypto() { Id = crypto.Id, Name = crypto.Name, Prefix = crypto.Prefix, MarketCap = crypto.MarketCap, Price = crypto.Price, DateCreated = crypto.DateCreated, CreatedBy = crypto.CreatedBy, Quantity = 1 }); 
            }
            else
            {
                match.Quantity++;
            }
        }


        public double CalculateTotalPrice()
        {
            return _crypto.Sum(crypto => crypto.Price * crypto.Quantity);
        }

        public double deleteportfolio1()
        {
            _crypto.Clear();
            return _crypto.Count();
        }
    }
}

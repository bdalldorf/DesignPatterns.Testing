using DesignPatterns.Library.Strategy.Strategies;

namespace DesignPatterns.Library.Strategy
{
    public static class CreateLetter
    {
        public static string GenerateCustomLetter(string filePath, Company company)
        {
            ILetterStrategy Strategy = null;

            switch (company)
            {
                case Company.Foo:
                    Strategy = new CompanyFooStrategy(filePath);
                    break;
                case Company.Bar:
                    Strategy = new CompanyBarStrategy(filePath);
                    break;
                case Company.Baz:
                    Strategy = new CompanyBazStrategy(filePath);
                    break;
            }

            Strategy.CompanyProducts(CompanyProducts.Products);

            return Strategy.LetterText;
        }
    }
}

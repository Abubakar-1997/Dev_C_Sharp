/*
 * Create a class called Asset that includes three pieces of information as either instance variables or auto-implemeted properties
 * Asset name (type string), asset value (type decimal) and depreciation rate (type decimal).
 * Your class should have a constructor that initializes the three values.
 * Provide a property with a get and set accessor for any instance variables.
 * If the asset value or depreciation rate is negative, the set accessor should leave the instance variable unchanged.
 * Write a test app named AssetTest that demonstrates class Asset’s capabilities
 * Create two Asset ob-jects and display each object's amount of depreciation and their depreciated value.
 * Then increase the value of each asset by 5% and display each asset's amount of depreciation and their depreciated value.
 */
namespace DevCSharp.Chapter4
{
    internal class Assets411
    {
        private decimal assetValue;
        private decimal deprecationRate;

        public Assets411(string initialName, decimal initialAssetValue, decimal initialDeprecationRate)
        {
            Name = initialName;
            assetValue = initialAssetValue;
            deprecationRate = initialDeprecationRate;
        }

        private string Name { get; set; }

        public decimal AssetValue
        {
            get => assetValue;
            set
            {
                if (value > 0.0m) assetValue = value;
            }
        }

        public decimal DeprecationRate
        {
            get => deprecationRate;
            set
            {
                if (value > 0.0m) deprecationRate = value;
            }
        }


    }
}
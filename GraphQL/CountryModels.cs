    public class Country{
        public int Id {get; set;}
        public string Name {get; set;}
        public string CapitalName {get; set;}
        public Government Government {get; set;}
        public FinancialStructure FinancialStructure {get; set;}
    }

    public class Government{
        public int CountryId {get; set;}
        public int Id {get; set;}
        public string Head {get; set;}
        public string FormOfGovernment {get; set;}
        public List<Ministry> Ministires {get; set;}
    }

    public class FinancialStructure{
        public string CountryId {get; set;}
        public string CurrencyCode {get; set;}
        public string Gdp {get; set;}
    }

    public class Ministry{
        public int GovernmentId {get; set;} 
        public string Name {get; set;}
        public string LeaderName {get; set;}
    }
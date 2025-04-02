using System.Globalization;

namespace S6_CSHARP_01.Models;

    public enum CurrencyCountry
    {
        Euro,
        UnitedStates,
        UnitedKingdom,
        Japan,
        Canada,
        Australia
    }
    
    public static class DecimalExtensions
    {
        public static string ToCurrencyString(this decimal amount, CurrencyCountry country)
        {
            CultureInfo culture;

            switch (country)
            {
                case CurrencyCountry.Euro:
                    culture = new CultureInfo("fr-FR"); // Franse notatie voor euro (€)
                    break;
                case CurrencyCountry.UnitedStates:
                    culture = new CultureInfo("en-US"); // Amerikaanse dollar ($)
                    break;
                case CurrencyCountry.UnitedKingdom:
                    culture = new CultureInfo("en-GB"); // Britse pond (£)
                    break;
                case CurrencyCountry.Japan:
                    culture = new CultureInfo("ja-JP"); // Japanse yen (¥)
                    break;
                case CurrencyCountry.Canada:
                    culture = new CultureInfo("en-CA"); // Canadese dollar (C$)
                    break;
                case CurrencyCountry.Australia:
                    culture = new CultureInfo("en-AU"); // Australische dollar (A$)
                    break;
                default:
                    return amount.ToString("0.00"); // Als het land niet wordt herkend, geef alleen het bedrag terug
            }

            return amount.ToString("C", culture);
        }
    }
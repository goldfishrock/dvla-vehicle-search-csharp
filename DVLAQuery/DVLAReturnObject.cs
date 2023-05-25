using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DVLAQuery
{
    public class DVLAReturnedObject
    {
        [JsonProperty("registrationNumber")]
        public string RegistrationNumber { get; set; }

        [JsonProperty("taxStatus")]
        public string TaxStatus { get; set; }

        [JsonProperty("taxDueDate")]
        public DateTimeOffset TaxDueDate { get; set; }

        [JsonProperty("motStatus")]
        public string MotStatus { get; set; }

        [JsonProperty("make")]
        public string Make { get; set; }

        [JsonProperty("yearOfManufacture")]
        public long YearOfManufacture { get; set; }

        [JsonProperty("engineCapacity")]
        public long EngineCapacity { get; set; }

        [JsonProperty("co2Emissions")]
        public long Co2Emissions { get; set; }

        [JsonProperty("fuelType")]
        public string FuelType { get; set; }

        [JsonProperty("markedForExport")]
        public bool MarkedForExport { get; set; }

        [JsonProperty("colour")]
        public string Colour { get; set; }

        [JsonProperty("typeApproval")]
        public string TypeApproval { get; set; }

        [JsonProperty("dateOfLastV5CIssued")]
        public DateTimeOffset DateOfLastV5CIssued { get; set; }

        [JsonProperty("motExpiryDate")]
        public DateTimeOffset MotExpiryDate { get; set; }

        [JsonProperty("wheelplan")]
        public string Wheelplan { get; set; }

        [JsonProperty("monthOfFirstRegistration")]
        public string MonthOfFirstRegistration { get; set; }
    }
}

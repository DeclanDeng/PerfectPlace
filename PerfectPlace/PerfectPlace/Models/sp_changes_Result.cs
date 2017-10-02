//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PerfectPlace.Models
{
    using System;
    
    public partial class sp_changes_Result
    {
        public int suburb_id { get; set; }
        public string suburb { get; set; }
        public string distance_to_city_rate { get; set; }
        public Nullable<double> distance_to_city { get; set; }
        public string residential_rate { get; set; }
        public Nullable<double> residential_percent { get; set; }
        public string commercial_rate { get; set; }
        public Nullable<double> commercial_percent { get; set; }
        public string health_services { get; set; }
        public string nearest_public_hospital { get; set; }
        public string disability_care_rate { get; set; }
        public Nullable<int> disability_care { get; set; }
        public string aged_care_rate { get; set; }
        public Nullable<int> aged_care { get; set; }
        public string time_to_hospital { get; set; }
        public string life_style { get; set; }
        public Nullable<double> population_density { get; set; }
        public string top_country_of_birth_1 { get; set; }
        public string top_country_of_birth_2 { get; set; }
        public string top_country_of_birth_3 { get; set; }
        public string top_country_of_birth_4 { get; set; }
        public string top_country_of_birth_5 { get; set; }
        public string top_language_spoken_1 { get; set; }
        public string top_language_spoken_2 { get; set; }
        public string top_language_spoken_3 { get; set; }
        public string top_language_spoken_4 { get; set; }
        public string top_language_spoken_5 { get; set; }
        public Nullable<int> accident_count { get; set; }
        public string accident_count_rate { get; set; }
        public Nullable<int> offence_count { get; set; }
        public string crime_rate { get; set; }
        public Nullable<int> crime_offence_count { get; set; }
        public string crime_against_person_rate { get; set; }
        public Nullable<int> burglary_offence_count { get; set; }
        public string burglary_rate { get; set; }
        public Nullable<int> theft_offence_count { get; set; }
        public string theft_rate { get; set; }
        public Nullable<double> house_low_quartile { get; set; }
        public Nullable<double> house_high_quartile { get; set; }
        public Nullable<double> unit_low_quartile { get; set; }
        public Nullable<double> unit_high_quartile { get; set; }
        public Nullable<double> house_median_quartile { get; set; }
        public string house_median_quartile_string { get; set; }
        public Nullable<double> unit_median_quartile { get; set; }
        public string unit_median_quartile_string { get; set; }
        public Nullable<int> post_code { get; set; }
    }
}
﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PreferenceEntities : DbContext
    {
        public PreferenceEntities()
            : base("name=PreferenceEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<rating_it2> rating_it2 { get; set; }
    
        public virtual ObjectResult<rating_it2> SearchByPreference(string very_near_distance_to_city, string very_high_moreshops, string very_high_health_services, string low_accident_rate, string very_high_more_agedcare, string very_less_time_to_hospital, string low_crime_rate, string top_country_of_birth)
        {
            var very_near_distance_to_cityParameter = very_near_distance_to_city != null ?
                new ObjectParameter("very_near_distance_to_city", very_near_distance_to_city) :
                new ObjectParameter("very_near_distance_to_city", typeof(string));
    
            var very_high_moreshopsParameter = very_high_moreshops != null ?
                new ObjectParameter("very_high_moreshops", very_high_moreshops) :
                new ObjectParameter("very_high_moreshops", typeof(string));
    
            var very_high_health_servicesParameter = very_high_health_services != null ?
                new ObjectParameter("very_high_health_services", very_high_health_services) :
                new ObjectParameter("very_high_health_services", typeof(string));
    
            var low_accident_rateParameter = low_accident_rate != null ?
                new ObjectParameter("low_accident_rate", low_accident_rate) :
                new ObjectParameter("low_accident_rate", typeof(string));
    
            var very_high_more_agedcareParameter = very_high_more_agedcare != null ?
                new ObjectParameter("very_high_more_agedcare", very_high_more_agedcare) :
                new ObjectParameter("very_high_more_agedcare", typeof(string));
    
            var very_less_time_to_hospitalParameter = very_less_time_to_hospital != null ?
                new ObjectParameter("very_less_time_to_hospital", very_less_time_to_hospital) :
                new ObjectParameter("very_less_time_to_hospital", typeof(string));
    
            var low_crime_rateParameter = low_crime_rate != null ?
                new ObjectParameter("low_crime_rate", low_crime_rate) :
                new ObjectParameter("low_crime_rate", typeof(string));
    
            var top_country_of_birthParameter = top_country_of_birth != null ?
                new ObjectParameter("top_country_of_birth", top_country_of_birth) :
                new ObjectParameter("top_country_of_birth", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<rating_it2>("SearchByPreference", very_near_distance_to_cityParameter, very_high_moreshopsParameter, very_high_health_servicesParameter, low_accident_rateParameter, very_high_more_agedcareParameter, very_less_time_to_hospitalParameter, low_crime_rateParameter, top_country_of_birthParameter);
        }
    
        public virtual ObjectResult<rating_it2> SearchByPreference(string very_near_distance_to_city, string very_high_moreshops, string very_high_health_services, string low_accident_rate, string very_high_more_agedcare, string very_less_time_to_hospital, string low_crime_rate, string top_country_of_birth, MergeOption mergeOption)
        {
            var very_near_distance_to_cityParameter = very_near_distance_to_city != null ?
                new ObjectParameter("very_near_distance_to_city", very_near_distance_to_city) :
                new ObjectParameter("very_near_distance_to_city", typeof(string));
    
            var very_high_moreshopsParameter = very_high_moreshops != null ?
                new ObjectParameter("very_high_moreshops", very_high_moreshops) :
                new ObjectParameter("very_high_moreshops", typeof(string));
    
            var very_high_health_servicesParameter = very_high_health_services != null ?
                new ObjectParameter("very_high_health_services", very_high_health_services) :
                new ObjectParameter("very_high_health_services", typeof(string));
    
            var low_accident_rateParameter = low_accident_rate != null ?
                new ObjectParameter("low_accident_rate", low_accident_rate) :
                new ObjectParameter("low_accident_rate", typeof(string));
    
            var very_high_more_agedcareParameter = very_high_more_agedcare != null ?
                new ObjectParameter("very_high_more_agedcare", very_high_more_agedcare) :
                new ObjectParameter("very_high_more_agedcare", typeof(string));
    
            var very_less_time_to_hospitalParameter = very_less_time_to_hospital != null ?
                new ObjectParameter("very_less_time_to_hospital", very_less_time_to_hospital) :
                new ObjectParameter("very_less_time_to_hospital", typeof(string));
    
            var low_crime_rateParameter = low_crime_rate != null ?
                new ObjectParameter("low_crime_rate", low_crime_rate) :
                new ObjectParameter("low_crime_rate", typeof(string));
    
            var top_country_of_birthParameter = top_country_of_birth != null ?
                new ObjectParameter("top_country_of_birth", top_country_of_birth) :
                new ObjectParameter("top_country_of_birth", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<rating_it2>("SearchByPreference", mergeOption, very_near_distance_to_cityParameter, very_high_moreshopsParameter, very_high_health_servicesParameter, low_accident_rateParameter, very_high_more_agedcareParameter, very_less_time_to_hospitalParameter, low_crime_rateParameter, top_country_of_birthParameter);
        }
    
        public virtual ObjectResult<rating_it2> SearchBySuburbChange(string lifestyle)
        {
            var lifestyleParameter = lifestyle != null ?
                new ObjectParameter("lifestyle", lifestyle) :
                new ObjectParameter("lifestyle", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<rating_it2>("SearchBySuburbChange", lifestyleParameter);
        }
    
        public virtual ObjectResult<rating_it2> SearchBySuburbChange(string lifestyle, MergeOption mergeOption)
        {
            var lifestyleParameter = lifestyle != null ?
                new ObjectParameter("lifestyle", lifestyle) :
                new ObjectParameter("lifestyle", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<rating_it2>("SearchBySuburbChange", mergeOption, lifestyleParameter);
        }
    }
}

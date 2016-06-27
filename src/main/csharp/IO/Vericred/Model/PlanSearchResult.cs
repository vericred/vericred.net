using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IO.Vericred.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class PlanSearchResult :  IEquatable<PlanSearchResult>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanSearchResult" /> class.
        /// Initializes a new instance of the <see cref="PlanSearchResult" />class.
        /// </summary>
        /// <param name="AdultDental">Does the plan provide dental coverage for adults?.</param>
        /// <param name="Age29Rider">.</param>
        /// <param name="Ambulance">Benefits string for ambulance coverage.</param>
        /// <param name="BenefitsSummaryUrl">Link to the summary of benefits and coverage (SBC) document..</param>
        /// <param name="BuyLink">Link to a location to purchase the plan..</param>
        /// <param name="CarrierName">Name of the insurance carrier.</param>
        /// <param name="ChildDental">Does the plan provide dental coverage for children?.</param>
        /// <param name="ChildEyewear">Child eyewear benefits summary.</param>
        /// <param name="ChildEyeExam">Child eye exam benefits summary.</param>
        /// <param name="CustomerServicePhoneNumber">Phone number to contact the insurance carrier.</param>
        /// <param name="DurableMedicalEquipment">Benefits summary for durable medical equipment.</param>
        /// <param name="DiagnosticTest">Diagnostic tests benefit summary.</param>
        /// <param name="DpRider">Is this a domestic plan?.</param>
        /// <param name="DrugFormularyUrl">Link to the summary of drug benefits for the plan.</param>
        /// <param name="EffectiveDate">Effective date of coverage..</param>
        /// <param name="ExpirationDate">Expiration date of coverage..</param>
        /// <param name="EmergencyRoom">Description of costs when visiting the ER.</param>
        /// <param name="FamilyDrugDeductible">Deductible for drugs when a family is on the plan..</param>
        /// <param name="FamilyDrugMoop">Maximum out-of-pocket for drugs when a family is on the plan.</param>
        /// <param name="FamilyMedicalDeductible">Deductible when a family is on the plan.</param>
        /// <param name="FamilyMedicalMoop">Maximum out-of-pocket when a family is on the plan.</param>
        /// <param name="FpRider">Is this a family plan?.</param>
        /// <param name="GenericDrugs">Cost for generic drugs.</param>
        /// <param name="HabilitationServices">Habilitation services benefits summary.</param>
        /// <param name="HiosIssuerId">.</param>
        /// <param name="HomeHealthCare">Home health care benefits summary.</param>
        /// <param name="HospiceService">Hospice service benefits summary.</param>
        /// <param name="Id">Government-issued HIOS plan ID.</param>
        /// <param name="Imaging">Benefits summary for imaging coverage.</param>
        /// <param name="InNetworkIds">List of NPI numbers for Providers passed in who accept this Plan.</param>
        /// <param name="IndividualDrugDeductible">Deductible for drugs when an individual is on the plan.</param>
        /// <param name="IndividualDrugMoop">Maximum out-of-pocket for drugs when an individual is on the plan.</param>
        /// <param name="IndividualMedicalDeductible">Deductible when an individual is on the plan.</param>
        /// <param name="IndividualMedicalMoop">Maximum out-of-pocket when an individual is on the plan.</param>
        /// <param name="InpatientBirth">Inpatient birth benefits summary.</param>
        /// <param name="InpatientFacility">Cost under the plan for an inpatient facility.</param>
        /// <param name="InpatientMentalHealth">Inpatient mental helath benefits summary.</param>
        /// <param name="InpatientPhysician">Cost under the plan for an inpatient physician.</param>
        /// <param name="InpatientSubstance">Inpatient substance abuse benefits summary.</param>
        /// <param name="Level">Plan metal grouping (e.g. platinum, gold, silver, etc).</param>
        /// <param name="LogoUrl">Link to a copy of the insurance carrier&#39;s logo.</param>
        /// <param name="Name">Marketing name of the plan.</param>
        /// <param name="NonPreferredBrandDrugs">Cost under the plan for non-preferred brand drugs.</param>
        /// <param name="OnMarket">Is the plan on-market?.</param>
        /// <param name="OffMarket">Is the plan off-market?.</param>
        /// <param name="OutOfNetworkCoverage">Does this plan provide any out of network coverage?.</param>
        /// <param name="OutOfNetworkIds">List of NPI numbers for Providers passed in who do not accept this Plan.</param>
        /// <param name="OutpatientFacility">Benefits summary for outpatient facility coverage.</param>
        /// <param name="OutpatientMentalHealth">Benefits summary for outpatient mental health coverage.</param>
        /// <param name="OutpatientPhysician">Benefits summary for outpatient physician coverage.</param>
        /// <param name="OutpatientSubstance">Outpatient substance abuse benefits summary.</param>
        /// <param name="PlanMarket">Market in which the plan is offered (on_marketplace, shop, etc).</param>
        /// <param name="PlanType">Category of the plan (e.g. EPO, HMO, PPO, POS, Indemnity).</param>
        /// <param name="PreferredBrandDrugs">Cost under the plan for perferred brand drugs.</param>
        /// <param name="PrenatalPostnatalCare">Inpatient substance abuse benefits summary.</param>
        /// <param name="PreventativeCare">Benefits summary for preventative care.</param>
        /// <param name="PremiumSubsidized">Cumulative premium amount after subsidy.</param>
        /// <param name="Premium">Cumulative premium amount.</param>
        /// <param name="PrimaryCarePhysician">Cost under the plan to visit a Primary Care Physician.</param>
        /// <param name="RehabilitationServices">Benefits summary for rehabilitation services.</param>
        /// <param name="SkilledNursing">Benefits summary for skilled nursing services.</param>
        /// <param name="Specialist">Cost under the plan to visit a specialist.</param>
        /// <param name="SpecialtyDrugs">Cost under the plan for specialty drugs.</param>
        /// <param name="UrgentCare">Benefits summary for urgent care.</param>
        /// <param name="MatchPercentage">Percentage of doctors who matched this Plan.</param>
        /// <param name="PerfectMatchPercentage">Percentage of employees with 100% match.</param>
        /// <param name="EmployeePremium">Cumulative premium amount for employees.</param>
        /// <param name="DependentPremium">Cumulative premium amount for dependents.</param>

        public PlanSearchResult(bool? AdultDental = null, bool? Age29Rider = null, string Ambulance = null, string BenefitsSummaryUrl = null, string BuyLink = null, string CarrierName = null, bool? ChildDental = null, string ChildEyewear = null, string ChildEyeExam = null, string CustomerServicePhoneNumber = null, string DurableMedicalEquipment = null, string DiagnosticTest = null, bool? DpRider = null, string DrugFormularyUrl = null, string EffectiveDate = null, string ExpirationDate = null, string EmergencyRoom = null, string FamilyDrugDeductible = null, string FamilyDrugMoop = null, string FamilyMedicalDeductible = null, string FamilyMedicalMoop = null, bool? FpRider = null, string GenericDrugs = null, string HabilitationServices = null, string HiosIssuerId = null, string HomeHealthCare = null, string HospiceService = null, string Id = null, string Imaging = null, List<int?> InNetworkIds = null, string IndividualDrugDeductible = null, string IndividualDrugMoop = null, string IndividualMedicalDeductible = null, string IndividualMedicalMoop = null, string InpatientBirth = null, string InpatientFacility = null, string InpatientMentalHealth = null, string InpatientPhysician = null, string InpatientSubstance = null, string Level = null, string LogoUrl = null, string Name = null, string NonPreferredBrandDrugs = null, bool? OnMarket = null, bool? OffMarket = null, bool? OutOfNetworkCoverage = null, List<int?> OutOfNetworkIds = null, string OutpatientFacility = null, string OutpatientMentalHealth = null, string OutpatientPhysician = null, string OutpatientSubstance = null, string PlanMarket = null, string PlanType = null, string PreferredBrandDrugs = null, string PrenatalPostnatalCare = null, string PreventativeCare = null, double? PremiumSubsidized = null, double? Premium = null, string PrimaryCarePhysician = null, string RehabilitationServices = null, string SkilledNursing = null, string Specialist = null, string SpecialtyDrugs = null, string UrgentCare = null, int? MatchPercentage = null, int? PerfectMatchPercentage = null, double? EmployeePremium = null, double? DependentPremium = null)
        {
            this.AdultDental = AdultDental;
            this.Age29Rider = Age29Rider;
            this.Ambulance = Ambulance;
            this.BenefitsSummaryUrl = BenefitsSummaryUrl;
            this.BuyLink = BuyLink;
            this.CarrierName = CarrierName;
            this.ChildDental = ChildDental;
            this.ChildEyewear = ChildEyewear;
            this.ChildEyeExam = ChildEyeExam;
            this.CustomerServicePhoneNumber = CustomerServicePhoneNumber;
            this.DurableMedicalEquipment = DurableMedicalEquipment;
            this.DiagnosticTest = DiagnosticTest;
            this.DpRider = DpRider;
            this.DrugFormularyUrl = DrugFormularyUrl;
            this.EffectiveDate = EffectiveDate;
            this.ExpirationDate = ExpirationDate;
            this.EmergencyRoom = EmergencyRoom;
            this.FamilyDrugDeductible = FamilyDrugDeductible;
            this.FamilyDrugMoop = FamilyDrugMoop;
            this.FamilyMedicalDeductible = FamilyMedicalDeductible;
            this.FamilyMedicalMoop = FamilyMedicalMoop;
            this.FpRider = FpRider;
            this.GenericDrugs = GenericDrugs;
            this.HabilitationServices = HabilitationServices;
            this.HiosIssuerId = HiosIssuerId;
            this.HomeHealthCare = HomeHealthCare;
            this.HospiceService = HospiceService;
            this.Id = Id;
            this.Imaging = Imaging;
            this.InNetworkIds = InNetworkIds;
            this.IndividualDrugDeductible = IndividualDrugDeductible;
            this.IndividualDrugMoop = IndividualDrugMoop;
            this.IndividualMedicalDeductible = IndividualMedicalDeductible;
            this.IndividualMedicalMoop = IndividualMedicalMoop;
            this.InpatientBirth = InpatientBirth;
            this.InpatientFacility = InpatientFacility;
            this.InpatientMentalHealth = InpatientMentalHealth;
            this.InpatientPhysician = InpatientPhysician;
            this.InpatientSubstance = InpatientSubstance;
            this.Level = Level;
            this.LogoUrl = LogoUrl;
            this.Name = Name;
            this.NonPreferredBrandDrugs = NonPreferredBrandDrugs;
            this.OnMarket = OnMarket;
            this.OffMarket = OffMarket;
            this.OutOfNetworkCoverage = OutOfNetworkCoverage;
            this.OutOfNetworkIds = OutOfNetworkIds;
            this.OutpatientFacility = OutpatientFacility;
            this.OutpatientMentalHealth = OutpatientMentalHealth;
            this.OutpatientPhysician = OutpatientPhysician;
            this.OutpatientSubstance = OutpatientSubstance;
            this.PlanMarket = PlanMarket;
            this.PlanType = PlanType;
            this.PreferredBrandDrugs = PreferredBrandDrugs;
            this.PrenatalPostnatalCare = PrenatalPostnatalCare;
            this.PreventativeCare = PreventativeCare;
            this.PremiumSubsidized = PremiumSubsidized;
            this.Premium = Premium;
            this.PrimaryCarePhysician = PrimaryCarePhysician;
            this.RehabilitationServices = RehabilitationServices;
            this.SkilledNursing = SkilledNursing;
            this.Specialist = Specialist;
            this.SpecialtyDrugs = SpecialtyDrugs;
            this.UrgentCare = UrgentCare;
            this.MatchPercentage = MatchPercentage;
            this.PerfectMatchPercentage = PerfectMatchPercentage;
            this.EmployeePremium = EmployeePremium;
            this.DependentPremium = DependentPremium;
            
        }

    
        /// <summary>
        /// Does the plan provide dental coverage for adults?
        /// </summary>
        /// <value>Does the plan provide dental coverage for adults?</value>
        [DataMember(Name="adult_dental", EmitDefaultValue=false)]
        public bool? AdultDental { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="age29_rider", EmitDefaultValue=false)]
        public bool? Age29Rider { get; set; }
    
        /// <summary>
        /// Benefits string for ambulance coverage
        /// </summary>
        /// <value>Benefits string for ambulance coverage</value>
        [DataMember(Name="ambulance", EmitDefaultValue=false)]
        public string Ambulance { get; set; }
    
        /// <summary>
        /// Link to the summary of benefits and coverage (SBC) document.
        /// </summary>
        /// <value>Link to the summary of benefits and coverage (SBC) document.</value>
        [DataMember(Name="benefits_summary_url", EmitDefaultValue=false)]
        public string BenefitsSummaryUrl { get; set; }
    
        /// <summary>
        /// Link to a location to purchase the plan.
        /// </summary>
        /// <value>Link to a location to purchase the plan.</value>
        [DataMember(Name="buy_link", EmitDefaultValue=false)]
        public string BuyLink { get; set; }
    
        /// <summary>
        /// Name of the insurance carrier
        /// </summary>
        /// <value>Name of the insurance carrier</value>
        [DataMember(Name="carrier_name", EmitDefaultValue=false)]
        public string CarrierName { get; set; }
    
        /// <summary>
        /// Does the plan provide dental coverage for children?
        /// </summary>
        /// <value>Does the plan provide dental coverage for children?</value>
        [DataMember(Name="child_dental", EmitDefaultValue=false)]
        public bool? ChildDental { get; set; }
    
        /// <summary>
        /// Child eyewear benefits summary
        /// </summary>
        /// <value>Child eyewear benefits summary</value>
        [DataMember(Name="child_eyewear", EmitDefaultValue=false)]
        public string ChildEyewear { get; set; }
    
        /// <summary>
        /// Child eye exam benefits summary
        /// </summary>
        /// <value>Child eye exam benefits summary</value>
        [DataMember(Name="child_eye_exam", EmitDefaultValue=false)]
        public string ChildEyeExam { get; set; }
    
        /// <summary>
        /// Phone number to contact the insurance carrier
        /// </summary>
        /// <value>Phone number to contact the insurance carrier</value>
        [DataMember(Name="customer_service_phone_number", EmitDefaultValue=false)]
        public string CustomerServicePhoneNumber { get; set; }
    
        /// <summary>
        /// Benefits summary for durable medical equipment
        /// </summary>
        /// <value>Benefits summary for durable medical equipment</value>
        [DataMember(Name="durable_medical_equipment", EmitDefaultValue=false)]
        public string DurableMedicalEquipment { get; set; }
    
        /// <summary>
        /// Diagnostic tests benefit summary
        /// </summary>
        /// <value>Diagnostic tests benefit summary</value>
        [DataMember(Name="diagnostic_test", EmitDefaultValue=false)]
        public string DiagnosticTest { get; set; }
    
        /// <summary>
        /// Is this a domestic plan?
        /// </summary>
        /// <value>Is this a domestic plan?</value>
        [DataMember(Name="dp_rider", EmitDefaultValue=false)]
        public bool? DpRider { get; set; }
    
        /// <summary>
        /// Link to the summary of drug benefits for the plan
        /// </summary>
        /// <value>Link to the summary of drug benefits for the plan</value>
        [DataMember(Name="drug_formulary_url", EmitDefaultValue=false)]
        public string DrugFormularyUrl { get; set; }
    
        /// <summary>
        /// Effective date of coverage.
        /// </summary>
        /// <value>Effective date of coverage.</value>
        [DataMember(Name="effective_date", EmitDefaultValue=false)]
        public string EffectiveDate { get; set; }
    
        /// <summary>
        /// Expiration date of coverage.
        /// </summary>
        /// <value>Expiration date of coverage.</value>
        [DataMember(Name="expiration_date", EmitDefaultValue=false)]
        public string ExpirationDate { get; set; }
    
        /// <summary>
        /// Description of costs when visiting the ER
        /// </summary>
        /// <value>Description of costs when visiting the ER</value>
        [DataMember(Name="emergency_room", EmitDefaultValue=false)]
        public string EmergencyRoom { get; set; }
    
        /// <summary>
        /// Deductible for drugs when a family is on the plan.
        /// </summary>
        /// <value>Deductible for drugs when a family is on the plan.</value>
        [DataMember(Name="family_drug_deductible", EmitDefaultValue=false)]
        public string FamilyDrugDeductible { get; set; }
    
        /// <summary>
        /// Maximum out-of-pocket for drugs when a family is on the plan
        /// </summary>
        /// <value>Maximum out-of-pocket for drugs when a family is on the plan</value>
        [DataMember(Name="family_drug_moop", EmitDefaultValue=false)]
        public string FamilyDrugMoop { get; set; }
    
        /// <summary>
        /// Deductible when a family is on the plan
        /// </summary>
        /// <value>Deductible when a family is on the plan</value>
        [DataMember(Name="family_medical_deductible", EmitDefaultValue=false)]
        public string FamilyMedicalDeductible { get; set; }
    
        /// <summary>
        /// Maximum out-of-pocket when a family is on the plan
        /// </summary>
        /// <value>Maximum out-of-pocket when a family is on the plan</value>
        [DataMember(Name="family_medical_moop", EmitDefaultValue=false)]
        public string FamilyMedicalMoop { get; set; }
    
        /// <summary>
        /// Is this a family plan?
        /// </summary>
        /// <value>Is this a family plan?</value>
        [DataMember(Name="fp_rider", EmitDefaultValue=false)]
        public bool? FpRider { get; set; }
    
        /// <summary>
        /// Cost for generic drugs
        /// </summary>
        /// <value>Cost for generic drugs</value>
        [DataMember(Name="generic_drugs", EmitDefaultValue=false)]
        public string GenericDrugs { get; set; }
    
        /// <summary>
        /// Habilitation services benefits summary
        /// </summary>
        /// <value>Habilitation services benefits summary</value>
        [DataMember(Name="habilitation_services", EmitDefaultValue=false)]
        public string HabilitationServices { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="hios_issuer_id", EmitDefaultValue=false)]
        public string HiosIssuerId { get; set; }
    
        /// <summary>
        /// Home health care benefits summary
        /// </summary>
        /// <value>Home health care benefits summary</value>
        [DataMember(Name="home_health_care", EmitDefaultValue=false)]
        public string HomeHealthCare { get; set; }
    
        /// <summary>
        /// Hospice service benefits summary
        /// </summary>
        /// <value>Hospice service benefits summary</value>
        [DataMember(Name="hospice_service", EmitDefaultValue=false)]
        public string HospiceService { get; set; }
    
        /// <summary>
        /// Government-issued HIOS plan ID
        /// </summary>
        /// <value>Government-issued HIOS plan ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Benefits summary for imaging coverage
        /// </summary>
        /// <value>Benefits summary for imaging coverage</value>
        [DataMember(Name="imaging", EmitDefaultValue=false)]
        public string Imaging { get; set; }
    
        /// <summary>
        /// List of NPI numbers for Providers passed in who accept this Plan
        /// </summary>
        /// <value>List of NPI numbers for Providers passed in who accept this Plan</value>
        [DataMember(Name="in_network_ids", EmitDefaultValue=false)]
        public List<int?> InNetworkIds { get; set; }
    
        /// <summary>
        /// Deductible for drugs when an individual is on the plan
        /// </summary>
        /// <value>Deductible for drugs when an individual is on the plan</value>
        [DataMember(Name="individual_drug_deductible", EmitDefaultValue=false)]
        public string IndividualDrugDeductible { get; set; }
    
        /// <summary>
        /// Maximum out-of-pocket for drugs when an individual is on the plan
        /// </summary>
        /// <value>Maximum out-of-pocket for drugs when an individual is on the plan</value>
        [DataMember(Name="individual_drug_moop", EmitDefaultValue=false)]
        public string IndividualDrugMoop { get; set; }
    
        /// <summary>
        /// Deductible when an individual is on the plan
        /// </summary>
        /// <value>Deductible when an individual is on the plan</value>
        [DataMember(Name="individual_medical_deductible", EmitDefaultValue=false)]
        public string IndividualMedicalDeductible { get; set; }
    
        /// <summary>
        /// Maximum out-of-pocket when an individual is on the plan
        /// </summary>
        /// <value>Maximum out-of-pocket when an individual is on the plan</value>
        [DataMember(Name="individual_medical_moop", EmitDefaultValue=false)]
        public string IndividualMedicalMoop { get; set; }
    
        /// <summary>
        /// Inpatient birth benefits summary
        /// </summary>
        /// <value>Inpatient birth benefits summary</value>
        [DataMember(Name="inpatient_birth", EmitDefaultValue=false)]
        public string InpatientBirth { get; set; }
    
        /// <summary>
        /// Cost under the plan for an inpatient facility
        /// </summary>
        /// <value>Cost under the plan for an inpatient facility</value>
        [DataMember(Name="inpatient_facility", EmitDefaultValue=false)]
        public string InpatientFacility { get; set; }
    
        /// <summary>
        /// Inpatient mental helath benefits summary
        /// </summary>
        /// <value>Inpatient mental helath benefits summary</value>
        [DataMember(Name="inpatient_mental_health", EmitDefaultValue=false)]
        public string InpatientMentalHealth { get; set; }
    
        /// <summary>
        /// Cost under the plan for an inpatient physician
        /// </summary>
        /// <value>Cost under the plan for an inpatient physician</value>
        [DataMember(Name="inpatient_physician", EmitDefaultValue=false)]
        public string InpatientPhysician { get; set; }
    
        /// <summary>
        /// Inpatient substance abuse benefits summary
        /// </summary>
        /// <value>Inpatient substance abuse benefits summary</value>
        [DataMember(Name="inpatient_substance", EmitDefaultValue=false)]
        public string InpatientSubstance { get; set; }
    
        /// <summary>
        /// Plan metal grouping (e.g. platinum, gold, silver, etc)
        /// </summary>
        /// <value>Plan metal grouping (e.g. platinum, gold, silver, etc)</value>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public string Level { get; set; }
    
        /// <summary>
        /// Link to a copy of the insurance carrier&#39;s logo
        /// </summary>
        /// <value>Link to a copy of the insurance carrier&#39;s logo</value>
        [DataMember(Name="logo_url", EmitDefaultValue=false)]
        public string LogoUrl { get; set; }
    
        /// <summary>
        /// Marketing name of the plan
        /// </summary>
        /// <value>Marketing name of the plan</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Cost under the plan for non-preferred brand drugs
        /// </summary>
        /// <value>Cost under the plan for non-preferred brand drugs</value>
        [DataMember(Name="non_preferred_brand_drugs", EmitDefaultValue=false)]
        public string NonPreferredBrandDrugs { get; set; }
    
        /// <summary>
        /// Is the plan on-market?
        /// </summary>
        /// <value>Is the plan on-market?</value>
        [DataMember(Name="on_market", EmitDefaultValue=false)]
        public bool? OnMarket { get; set; }
    
        /// <summary>
        /// Is the plan off-market?
        /// </summary>
        /// <value>Is the plan off-market?</value>
        [DataMember(Name="off_market", EmitDefaultValue=false)]
        public bool? OffMarket { get; set; }
    
        /// <summary>
        /// Does this plan provide any out of network coverage?
        /// </summary>
        /// <value>Does this plan provide any out of network coverage?</value>
        [DataMember(Name="out_of_network_coverage", EmitDefaultValue=false)]
        public bool? OutOfNetworkCoverage { get; set; }
    
        /// <summary>
        /// List of NPI numbers for Providers passed in who do not accept this Plan
        /// </summary>
        /// <value>List of NPI numbers for Providers passed in who do not accept this Plan</value>
        [DataMember(Name="out_of_network_ids", EmitDefaultValue=false)]
        public List<int?> OutOfNetworkIds { get; set; }
    
        /// <summary>
        /// Benefits summary for outpatient facility coverage
        /// </summary>
        /// <value>Benefits summary for outpatient facility coverage</value>
        [DataMember(Name="outpatient_facility", EmitDefaultValue=false)]
        public string OutpatientFacility { get; set; }
    
        /// <summary>
        /// Benefits summary for outpatient mental health coverage
        /// </summary>
        /// <value>Benefits summary for outpatient mental health coverage</value>
        [DataMember(Name="outpatient_mental_health", EmitDefaultValue=false)]
        public string OutpatientMentalHealth { get; set; }
    
        /// <summary>
        /// Benefits summary for outpatient physician coverage
        /// </summary>
        /// <value>Benefits summary for outpatient physician coverage</value>
        [DataMember(Name="outpatient_physician", EmitDefaultValue=false)]
        public string OutpatientPhysician { get; set; }
    
        /// <summary>
        /// Outpatient substance abuse benefits summary
        /// </summary>
        /// <value>Outpatient substance abuse benefits summary</value>
        [DataMember(Name="outpatient_substance", EmitDefaultValue=false)]
        public string OutpatientSubstance { get; set; }
    
        /// <summary>
        /// Market in which the plan is offered (on_marketplace, shop, etc)
        /// </summary>
        /// <value>Market in which the plan is offered (on_marketplace, shop, etc)</value>
        [DataMember(Name="plan_market", EmitDefaultValue=false)]
        public string PlanMarket { get; set; }
    
        /// <summary>
        /// Category of the plan (e.g. EPO, HMO, PPO, POS, Indemnity)
        /// </summary>
        /// <value>Category of the plan (e.g. EPO, HMO, PPO, POS, Indemnity)</value>
        [DataMember(Name="plan_type", EmitDefaultValue=false)]
        public string PlanType { get; set; }
    
        /// <summary>
        /// Cost under the plan for perferred brand drugs
        /// </summary>
        /// <value>Cost under the plan for perferred brand drugs</value>
        [DataMember(Name="preferred_brand_drugs", EmitDefaultValue=false)]
        public string PreferredBrandDrugs { get; set; }
    
        /// <summary>
        /// Inpatient substance abuse benefits summary
        /// </summary>
        /// <value>Inpatient substance abuse benefits summary</value>
        [DataMember(Name="prenatal_postnatal_care", EmitDefaultValue=false)]
        public string PrenatalPostnatalCare { get; set; }
    
        /// <summary>
        /// Benefits summary for preventative care
        /// </summary>
        /// <value>Benefits summary for preventative care</value>
        [DataMember(Name="preventative_care", EmitDefaultValue=false)]
        public string PreventativeCare { get; set; }
    
        /// <summary>
        /// Cumulative premium amount after subsidy
        /// </summary>
        /// <value>Cumulative premium amount after subsidy</value>
        [DataMember(Name="premium_subsidized", EmitDefaultValue=false)]
        public double? PremiumSubsidized { get; set; }
    
        /// <summary>
        /// Cumulative premium amount
        /// </summary>
        /// <value>Cumulative premium amount</value>
        [DataMember(Name="premium", EmitDefaultValue=false)]
        public double? Premium { get; set; }
    
        /// <summary>
        /// Cost under the plan to visit a Primary Care Physician
        /// </summary>
        /// <value>Cost under the plan to visit a Primary Care Physician</value>
        [DataMember(Name="primary_care_physician", EmitDefaultValue=false)]
        public string PrimaryCarePhysician { get; set; }
    
        /// <summary>
        /// Benefits summary for rehabilitation services
        /// </summary>
        /// <value>Benefits summary for rehabilitation services</value>
        [DataMember(Name="rehabilitation_services", EmitDefaultValue=false)]
        public string RehabilitationServices { get; set; }
    
        /// <summary>
        /// Benefits summary for skilled nursing services
        /// </summary>
        /// <value>Benefits summary for skilled nursing services</value>
        [DataMember(Name="skilled_nursing", EmitDefaultValue=false)]
        public string SkilledNursing { get; set; }
    
        /// <summary>
        /// Cost under the plan to visit a specialist
        /// </summary>
        /// <value>Cost under the plan to visit a specialist</value>
        [DataMember(Name="specialist", EmitDefaultValue=false)]
        public string Specialist { get; set; }
    
        /// <summary>
        /// Cost under the plan for specialty drugs
        /// </summary>
        /// <value>Cost under the plan for specialty drugs</value>
        [DataMember(Name="specialty_drugs", EmitDefaultValue=false)]
        public string SpecialtyDrugs { get; set; }
    
        /// <summary>
        /// Benefits summary for urgent care
        /// </summary>
        /// <value>Benefits summary for urgent care</value>
        [DataMember(Name="urgent_care", EmitDefaultValue=false)]
        public string UrgentCare { get; set; }
    
        /// <summary>
        /// Percentage of doctors who matched this Plan
        /// </summary>
        /// <value>Percentage of doctors who matched this Plan</value>
        [DataMember(Name="match_percentage", EmitDefaultValue=false)]
        public int? MatchPercentage { get; set; }
    
        /// <summary>
        /// Percentage of employees with 100% match
        /// </summary>
        /// <value>Percentage of employees with 100% match</value>
        [DataMember(Name="perfect_match_percentage", EmitDefaultValue=false)]
        public int? PerfectMatchPercentage { get; set; }
    
        /// <summary>
        /// Cumulative premium amount for employees
        /// </summary>
        /// <value>Cumulative premium amount for employees</value>
        [DataMember(Name="employee_premium", EmitDefaultValue=false)]
        public double? EmployeePremium { get; set; }
    
        /// <summary>
        /// Cumulative premium amount for dependents
        /// </summary>
        /// <value>Cumulative premium amount for dependents</value>
        [DataMember(Name="dependent_premium", EmitDefaultValue=false)]
        public double? DependentPremium { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlanSearchResult {\n");
            sb.Append("  AdultDental: ").Append(AdultDental).Append("\n");
            sb.Append("  Age29Rider: ").Append(Age29Rider).Append("\n");
            sb.Append("  Ambulance: ").Append(Ambulance).Append("\n");
            sb.Append("  BenefitsSummaryUrl: ").Append(BenefitsSummaryUrl).Append("\n");
            sb.Append("  BuyLink: ").Append(BuyLink).Append("\n");
            sb.Append("  CarrierName: ").Append(CarrierName).Append("\n");
            sb.Append("  ChildDental: ").Append(ChildDental).Append("\n");
            sb.Append("  ChildEyewear: ").Append(ChildEyewear).Append("\n");
            sb.Append("  ChildEyeExam: ").Append(ChildEyeExam).Append("\n");
            sb.Append("  CustomerServicePhoneNumber: ").Append(CustomerServicePhoneNumber).Append("\n");
            sb.Append("  DurableMedicalEquipment: ").Append(DurableMedicalEquipment).Append("\n");
            sb.Append("  DiagnosticTest: ").Append(DiagnosticTest).Append("\n");
            sb.Append("  DpRider: ").Append(DpRider).Append("\n");
            sb.Append("  DrugFormularyUrl: ").Append(DrugFormularyUrl).Append("\n");
            sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  EmergencyRoom: ").Append(EmergencyRoom).Append("\n");
            sb.Append("  FamilyDrugDeductible: ").Append(FamilyDrugDeductible).Append("\n");
            sb.Append("  FamilyDrugMoop: ").Append(FamilyDrugMoop).Append("\n");
            sb.Append("  FamilyMedicalDeductible: ").Append(FamilyMedicalDeductible).Append("\n");
            sb.Append("  FamilyMedicalMoop: ").Append(FamilyMedicalMoop).Append("\n");
            sb.Append("  FpRider: ").Append(FpRider).Append("\n");
            sb.Append("  GenericDrugs: ").Append(GenericDrugs).Append("\n");
            sb.Append("  HabilitationServices: ").Append(HabilitationServices).Append("\n");
            sb.Append("  HiosIssuerId: ").Append(HiosIssuerId).Append("\n");
            sb.Append("  HomeHealthCare: ").Append(HomeHealthCare).Append("\n");
            sb.Append("  HospiceService: ").Append(HospiceService).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Imaging: ").Append(Imaging).Append("\n");
            sb.Append("  InNetworkIds: ").Append(InNetworkIds).Append("\n");
            sb.Append("  IndividualDrugDeductible: ").Append(IndividualDrugDeductible).Append("\n");
            sb.Append("  IndividualDrugMoop: ").Append(IndividualDrugMoop).Append("\n");
            sb.Append("  IndividualMedicalDeductible: ").Append(IndividualMedicalDeductible).Append("\n");
            sb.Append("  IndividualMedicalMoop: ").Append(IndividualMedicalMoop).Append("\n");
            sb.Append("  InpatientBirth: ").Append(InpatientBirth).Append("\n");
            sb.Append("  InpatientFacility: ").Append(InpatientFacility).Append("\n");
            sb.Append("  InpatientMentalHealth: ").Append(InpatientMentalHealth).Append("\n");
            sb.Append("  InpatientPhysician: ").Append(InpatientPhysician).Append("\n");
            sb.Append("  InpatientSubstance: ").Append(InpatientSubstance).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  LogoUrl: ").Append(LogoUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NonPreferredBrandDrugs: ").Append(NonPreferredBrandDrugs).Append("\n");
            sb.Append("  OnMarket: ").Append(OnMarket).Append("\n");
            sb.Append("  OffMarket: ").Append(OffMarket).Append("\n");
            sb.Append("  OutOfNetworkCoverage: ").Append(OutOfNetworkCoverage).Append("\n");
            sb.Append("  OutOfNetworkIds: ").Append(OutOfNetworkIds).Append("\n");
            sb.Append("  OutpatientFacility: ").Append(OutpatientFacility).Append("\n");
            sb.Append("  OutpatientMentalHealth: ").Append(OutpatientMentalHealth).Append("\n");
            sb.Append("  OutpatientPhysician: ").Append(OutpatientPhysician).Append("\n");
            sb.Append("  OutpatientSubstance: ").Append(OutpatientSubstance).Append("\n");
            sb.Append("  PlanMarket: ").Append(PlanMarket).Append("\n");
            sb.Append("  PlanType: ").Append(PlanType).Append("\n");
            sb.Append("  PreferredBrandDrugs: ").Append(PreferredBrandDrugs).Append("\n");
            sb.Append("  PrenatalPostnatalCare: ").Append(PrenatalPostnatalCare).Append("\n");
            sb.Append("  PreventativeCare: ").Append(PreventativeCare).Append("\n");
            sb.Append("  PremiumSubsidized: ").Append(PremiumSubsidized).Append("\n");
            sb.Append("  Premium: ").Append(Premium).Append("\n");
            sb.Append("  PrimaryCarePhysician: ").Append(PrimaryCarePhysician).Append("\n");
            sb.Append("  RehabilitationServices: ").Append(RehabilitationServices).Append("\n");
            sb.Append("  SkilledNursing: ").Append(SkilledNursing).Append("\n");
            sb.Append("  Specialist: ").Append(Specialist).Append("\n");
            sb.Append("  SpecialtyDrugs: ").Append(SpecialtyDrugs).Append("\n");
            sb.Append("  UrgentCare: ").Append(UrgentCare).Append("\n");
            sb.Append("  MatchPercentage: ").Append(MatchPercentage).Append("\n");
            sb.Append("  PerfectMatchPercentage: ").Append(PerfectMatchPercentage).Append("\n");
            sb.Append("  EmployeePremium: ").Append(EmployeePremium).Append("\n");
            sb.Append("  DependentPremium: ").Append(DependentPremium).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as PlanSearchResult);
        }

        /// <summary>
        /// Returns true if PlanSearchResult instances are equal
        /// </summary>
        /// <param name="other">Instance of PlanSearchResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlanSearchResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AdultDental == other.AdultDental ||
                    this.AdultDental != null &&
                    this.AdultDental.Equals(other.AdultDental)
                ) && 
                (
                    this.Age29Rider == other.Age29Rider ||
                    this.Age29Rider != null &&
                    this.Age29Rider.Equals(other.Age29Rider)
                ) && 
                (
                    this.Ambulance == other.Ambulance ||
                    this.Ambulance != null &&
                    this.Ambulance.Equals(other.Ambulance)
                ) && 
                (
                    this.BenefitsSummaryUrl == other.BenefitsSummaryUrl ||
                    this.BenefitsSummaryUrl != null &&
                    this.BenefitsSummaryUrl.Equals(other.BenefitsSummaryUrl)
                ) && 
                (
                    this.BuyLink == other.BuyLink ||
                    this.BuyLink != null &&
                    this.BuyLink.Equals(other.BuyLink)
                ) && 
                (
                    this.CarrierName == other.CarrierName ||
                    this.CarrierName != null &&
                    this.CarrierName.Equals(other.CarrierName)
                ) && 
                (
                    this.ChildDental == other.ChildDental ||
                    this.ChildDental != null &&
                    this.ChildDental.Equals(other.ChildDental)
                ) && 
                (
                    this.ChildEyewear == other.ChildEyewear ||
                    this.ChildEyewear != null &&
                    this.ChildEyewear.Equals(other.ChildEyewear)
                ) && 
                (
                    this.ChildEyeExam == other.ChildEyeExam ||
                    this.ChildEyeExam != null &&
                    this.ChildEyeExam.Equals(other.ChildEyeExam)
                ) && 
                (
                    this.CustomerServicePhoneNumber == other.CustomerServicePhoneNumber ||
                    this.CustomerServicePhoneNumber != null &&
                    this.CustomerServicePhoneNumber.Equals(other.CustomerServicePhoneNumber)
                ) && 
                (
                    this.DurableMedicalEquipment == other.DurableMedicalEquipment ||
                    this.DurableMedicalEquipment != null &&
                    this.DurableMedicalEquipment.Equals(other.DurableMedicalEquipment)
                ) && 
                (
                    this.DiagnosticTest == other.DiagnosticTest ||
                    this.DiagnosticTest != null &&
                    this.DiagnosticTest.Equals(other.DiagnosticTest)
                ) && 
                (
                    this.DpRider == other.DpRider ||
                    this.DpRider != null &&
                    this.DpRider.Equals(other.DpRider)
                ) && 
                (
                    this.DrugFormularyUrl == other.DrugFormularyUrl ||
                    this.DrugFormularyUrl != null &&
                    this.DrugFormularyUrl.Equals(other.DrugFormularyUrl)
                ) && 
                (
                    this.EffectiveDate == other.EffectiveDate ||
                    this.EffectiveDate != null &&
                    this.EffectiveDate.Equals(other.EffectiveDate)
                ) && 
                (
                    this.ExpirationDate == other.ExpirationDate ||
                    this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(other.ExpirationDate)
                ) && 
                (
                    this.EmergencyRoom == other.EmergencyRoom ||
                    this.EmergencyRoom != null &&
                    this.EmergencyRoom.Equals(other.EmergencyRoom)
                ) && 
                (
                    this.FamilyDrugDeductible == other.FamilyDrugDeductible ||
                    this.FamilyDrugDeductible != null &&
                    this.FamilyDrugDeductible.Equals(other.FamilyDrugDeductible)
                ) && 
                (
                    this.FamilyDrugMoop == other.FamilyDrugMoop ||
                    this.FamilyDrugMoop != null &&
                    this.FamilyDrugMoop.Equals(other.FamilyDrugMoop)
                ) && 
                (
                    this.FamilyMedicalDeductible == other.FamilyMedicalDeductible ||
                    this.FamilyMedicalDeductible != null &&
                    this.FamilyMedicalDeductible.Equals(other.FamilyMedicalDeductible)
                ) && 
                (
                    this.FamilyMedicalMoop == other.FamilyMedicalMoop ||
                    this.FamilyMedicalMoop != null &&
                    this.FamilyMedicalMoop.Equals(other.FamilyMedicalMoop)
                ) && 
                (
                    this.FpRider == other.FpRider ||
                    this.FpRider != null &&
                    this.FpRider.Equals(other.FpRider)
                ) && 
                (
                    this.GenericDrugs == other.GenericDrugs ||
                    this.GenericDrugs != null &&
                    this.GenericDrugs.Equals(other.GenericDrugs)
                ) && 
                (
                    this.HabilitationServices == other.HabilitationServices ||
                    this.HabilitationServices != null &&
                    this.HabilitationServices.Equals(other.HabilitationServices)
                ) && 
                (
                    this.HiosIssuerId == other.HiosIssuerId ||
                    this.HiosIssuerId != null &&
                    this.HiosIssuerId.Equals(other.HiosIssuerId)
                ) && 
                (
                    this.HomeHealthCare == other.HomeHealthCare ||
                    this.HomeHealthCare != null &&
                    this.HomeHealthCare.Equals(other.HomeHealthCare)
                ) && 
                (
                    this.HospiceService == other.HospiceService ||
                    this.HospiceService != null &&
                    this.HospiceService.Equals(other.HospiceService)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Imaging == other.Imaging ||
                    this.Imaging != null &&
                    this.Imaging.Equals(other.Imaging)
                ) && 
                (
                    this.InNetworkIds == other.InNetworkIds ||
                    this.InNetworkIds != null &&
                    this.InNetworkIds.SequenceEqual(other.InNetworkIds)
                ) && 
                (
                    this.IndividualDrugDeductible == other.IndividualDrugDeductible ||
                    this.IndividualDrugDeductible != null &&
                    this.IndividualDrugDeductible.Equals(other.IndividualDrugDeductible)
                ) && 
                (
                    this.IndividualDrugMoop == other.IndividualDrugMoop ||
                    this.IndividualDrugMoop != null &&
                    this.IndividualDrugMoop.Equals(other.IndividualDrugMoop)
                ) && 
                (
                    this.IndividualMedicalDeductible == other.IndividualMedicalDeductible ||
                    this.IndividualMedicalDeductible != null &&
                    this.IndividualMedicalDeductible.Equals(other.IndividualMedicalDeductible)
                ) && 
                (
                    this.IndividualMedicalMoop == other.IndividualMedicalMoop ||
                    this.IndividualMedicalMoop != null &&
                    this.IndividualMedicalMoop.Equals(other.IndividualMedicalMoop)
                ) && 
                (
                    this.InpatientBirth == other.InpatientBirth ||
                    this.InpatientBirth != null &&
                    this.InpatientBirth.Equals(other.InpatientBirth)
                ) && 
                (
                    this.InpatientFacility == other.InpatientFacility ||
                    this.InpatientFacility != null &&
                    this.InpatientFacility.Equals(other.InpatientFacility)
                ) && 
                (
                    this.InpatientMentalHealth == other.InpatientMentalHealth ||
                    this.InpatientMentalHealth != null &&
                    this.InpatientMentalHealth.Equals(other.InpatientMentalHealth)
                ) && 
                (
                    this.InpatientPhysician == other.InpatientPhysician ||
                    this.InpatientPhysician != null &&
                    this.InpatientPhysician.Equals(other.InpatientPhysician)
                ) && 
                (
                    this.InpatientSubstance == other.InpatientSubstance ||
                    this.InpatientSubstance != null &&
                    this.InpatientSubstance.Equals(other.InpatientSubstance)
                ) && 
                (
                    this.Level == other.Level ||
                    this.Level != null &&
                    this.Level.Equals(other.Level)
                ) && 
                (
                    this.LogoUrl == other.LogoUrl ||
                    this.LogoUrl != null &&
                    this.LogoUrl.Equals(other.LogoUrl)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.NonPreferredBrandDrugs == other.NonPreferredBrandDrugs ||
                    this.NonPreferredBrandDrugs != null &&
                    this.NonPreferredBrandDrugs.Equals(other.NonPreferredBrandDrugs)
                ) && 
                (
                    this.OnMarket == other.OnMarket ||
                    this.OnMarket != null &&
                    this.OnMarket.Equals(other.OnMarket)
                ) && 
                (
                    this.OffMarket == other.OffMarket ||
                    this.OffMarket != null &&
                    this.OffMarket.Equals(other.OffMarket)
                ) && 
                (
                    this.OutOfNetworkCoverage == other.OutOfNetworkCoverage ||
                    this.OutOfNetworkCoverage != null &&
                    this.OutOfNetworkCoverage.Equals(other.OutOfNetworkCoverage)
                ) && 
                (
                    this.OutOfNetworkIds == other.OutOfNetworkIds ||
                    this.OutOfNetworkIds != null &&
                    this.OutOfNetworkIds.SequenceEqual(other.OutOfNetworkIds)
                ) && 
                (
                    this.OutpatientFacility == other.OutpatientFacility ||
                    this.OutpatientFacility != null &&
                    this.OutpatientFacility.Equals(other.OutpatientFacility)
                ) && 
                (
                    this.OutpatientMentalHealth == other.OutpatientMentalHealth ||
                    this.OutpatientMentalHealth != null &&
                    this.OutpatientMentalHealth.Equals(other.OutpatientMentalHealth)
                ) && 
                (
                    this.OutpatientPhysician == other.OutpatientPhysician ||
                    this.OutpatientPhysician != null &&
                    this.OutpatientPhysician.Equals(other.OutpatientPhysician)
                ) && 
                (
                    this.OutpatientSubstance == other.OutpatientSubstance ||
                    this.OutpatientSubstance != null &&
                    this.OutpatientSubstance.Equals(other.OutpatientSubstance)
                ) && 
                (
                    this.PlanMarket == other.PlanMarket ||
                    this.PlanMarket != null &&
                    this.PlanMarket.Equals(other.PlanMarket)
                ) && 
                (
                    this.PlanType == other.PlanType ||
                    this.PlanType != null &&
                    this.PlanType.Equals(other.PlanType)
                ) && 
                (
                    this.PreferredBrandDrugs == other.PreferredBrandDrugs ||
                    this.PreferredBrandDrugs != null &&
                    this.PreferredBrandDrugs.Equals(other.PreferredBrandDrugs)
                ) && 
                (
                    this.PrenatalPostnatalCare == other.PrenatalPostnatalCare ||
                    this.PrenatalPostnatalCare != null &&
                    this.PrenatalPostnatalCare.Equals(other.PrenatalPostnatalCare)
                ) && 
                (
                    this.PreventativeCare == other.PreventativeCare ||
                    this.PreventativeCare != null &&
                    this.PreventativeCare.Equals(other.PreventativeCare)
                ) && 
                (
                    this.PremiumSubsidized == other.PremiumSubsidized ||
                    this.PremiumSubsidized != null &&
                    this.PremiumSubsidized.Equals(other.PremiumSubsidized)
                ) && 
                (
                    this.Premium == other.Premium ||
                    this.Premium != null &&
                    this.Premium.Equals(other.Premium)
                ) && 
                (
                    this.PrimaryCarePhysician == other.PrimaryCarePhysician ||
                    this.PrimaryCarePhysician != null &&
                    this.PrimaryCarePhysician.Equals(other.PrimaryCarePhysician)
                ) && 
                (
                    this.RehabilitationServices == other.RehabilitationServices ||
                    this.RehabilitationServices != null &&
                    this.RehabilitationServices.Equals(other.RehabilitationServices)
                ) && 
                (
                    this.SkilledNursing == other.SkilledNursing ||
                    this.SkilledNursing != null &&
                    this.SkilledNursing.Equals(other.SkilledNursing)
                ) && 
                (
                    this.Specialist == other.Specialist ||
                    this.Specialist != null &&
                    this.Specialist.Equals(other.Specialist)
                ) && 
                (
                    this.SpecialtyDrugs == other.SpecialtyDrugs ||
                    this.SpecialtyDrugs != null &&
                    this.SpecialtyDrugs.Equals(other.SpecialtyDrugs)
                ) && 
                (
                    this.UrgentCare == other.UrgentCare ||
                    this.UrgentCare != null &&
                    this.UrgentCare.Equals(other.UrgentCare)
                ) && 
                (
                    this.MatchPercentage == other.MatchPercentage ||
                    this.MatchPercentage != null &&
                    this.MatchPercentage.Equals(other.MatchPercentage)
                ) && 
                (
                    this.PerfectMatchPercentage == other.PerfectMatchPercentage ||
                    this.PerfectMatchPercentage != null &&
                    this.PerfectMatchPercentage.Equals(other.PerfectMatchPercentage)
                ) && 
                (
                    this.EmployeePremium == other.EmployeePremium ||
                    this.EmployeePremium != null &&
                    this.EmployeePremium.Equals(other.EmployeePremium)
                ) && 
                (
                    this.DependentPremium == other.DependentPremium ||
                    this.DependentPremium != null &&
                    this.DependentPremium.Equals(other.DependentPremium)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.AdultDental != null)
                    hash = hash * 59 + this.AdultDental.GetHashCode();
                if (this.Age29Rider != null)
                    hash = hash * 59 + this.Age29Rider.GetHashCode();
                if (this.Ambulance != null)
                    hash = hash * 59 + this.Ambulance.GetHashCode();
                if (this.BenefitsSummaryUrl != null)
                    hash = hash * 59 + this.BenefitsSummaryUrl.GetHashCode();
                if (this.BuyLink != null)
                    hash = hash * 59 + this.BuyLink.GetHashCode();
                if (this.CarrierName != null)
                    hash = hash * 59 + this.CarrierName.GetHashCode();
                if (this.ChildDental != null)
                    hash = hash * 59 + this.ChildDental.GetHashCode();
                if (this.ChildEyewear != null)
                    hash = hash * 59 + this.ChildEyewear.GetHashCode();
                if (this.ChildEyeExam != null)
                    hash = hash * 59 + this.ChildEyeExam.GetHashCode();
                if (this.CustomerServicePhoneNumber != null)
                    hash = hash * 59 + this.CustomerServicePhoneNumber.GetHashCode();
                if (this.DurableMedicalEquipment != null)
                    hash = hash * 59 + this.DurableMedicalEquipment.GetHashCode();
                if (this.DiagnosticTest != null)
                    hash = hash * 59 + this.DiagnosticTest.GetHashCode();
                if (this.DpRider != null)
                    hash = hash * 59 + this.DpRider.GetHashCode();
                if (this.DrugFormularyUrl != null)
                    hash = hash * 59 + this.DrugFormularyUrl.GetHashCode();
                if (this.EffectiveDate != null)
                    hash = hash * 59 + this.EffectiveDate.GetHashCode();
                if (this.ExpirationDate != null)
                    hash = hash * 59 + this.ExpirationDate.GetHashCode();
                if (this.EmergencyRoom != null)
                    hash = hash * 59 + this.EmergencyRoom.GetHashCode();
                if (this.FamilyDrugDeductible != null)
                    hash = hash * 59 + this.FamilyDrugDeductible.GetHashCode();
                if (this.FamilyDrugMoop != null)
                    hash = hash * 59 + this.FamilyDrugMoop.GetHashCode();
                if (this.FamilyMedicalDeductible != null)
                    hash = hash * 59 + this.FamilyMedicalDeductible.GetHashCode();
                if (this.FamilyMedicalMoop != null)
                    hash = hash * 59 + this.FamilyMedicalMoop.GetHashCode();
                if (this.FpRider != null)
                    hash = hash * 59 + this.FpRider.GetHashCode();
                if (this.GenericDrugs != null)
                    hash = hash * 59 + this.GenericDrugs.GetHashCode();
                if (this.HabilitationServices != null)
                    hash = hash * 59 + this.HabilitationServices.GetHashCode();
                if (this.HiosIssuerId != null)
                    hash = hash * 59 + this.HiosIssuerId.GetHashCode();
                if (this.HomeHealthCare != null)
                    hash = hash * 59 + this.HomeHealthCare.GetHashCode();
                if (this.HospiceService != null)
                    hash = hash * 59 + this.HospiceService.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Imaging != null)
                    hash = hash * 59 + this.Imaging.GetHashCode();
                if (this.InNetworkIds != null)
                    hash = hash * 59 + this.InNetworkIds.GetHashCode();
                if (this.IndividualDrugDeductible != null)
                    hash = hash * 59 + this.IndividualDrugDeductible.GetHashCode();
                if (this.IndividualDrugMoop != null)
                    hash = hash * 59 + this.IndividualDrugMoop.GetHashCode();
                if (this.IndividualMedicalDeductible != null)
                    hash = hash * 59 + this.IndividualMedicalDeductible.GetHashCode();
                if (this.IndividualMedicalMoop != null)
                    hash = hash * 59 + this.IndividualMedicalMoop.GetHashCode();
                if (this.InpatientBirth != null)
                    hash = hash * 59 + this.InpatientBirth.GetHashCode();
                if (this.InpatientFacility != null)
                    hash = hash * 59 + this.InpatientFacility.GetHashCode();
                if (this.InpatientMentalHealth != null)
                    hash = hash * 59 + this.InpatientMentalHealth.GetHashCode();
                if (this.InpatientPhysician != null)
                    hash = hash * 59 + this.InpatientPhysician.GetHashCode();
                if (this.InpatientSubstance != null)
                    hash = hash * 59 + this.InpatientSubstance.GetHashCode();
                if (this.Level != null)
                    hash = hash * 59 + this.Level.GetHashCode();
                if (this.LogoUrl != null)
                    hash = hash * 59 + this.LogoUrl.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.NonPreferredBrandDrugs != null)
                    hash = hash * 59 + this.NonPreferredBrandDrugs.GetHashCode();
                if (this.OnMarket != null)
                    hash = hash * 59 + this.OnMarket.GetHashCode();
                if (this.OffMarket != null)
                    hash = hash * 59 + this.OffMarket.GetHashCode();
                if (this.OutOfNetworkCoverage != null)
                    hash = hash * 59 + this.OutOfNetworkCoverage.GetHashCode();
                if (this.OutOfNetworkIds != null)
                    hash = hash * 59 + this.OutOfNetworkIds.GetHashCode();
                if (this.OutpatientFacility != null)
                    hash = hash * 59 + this.OutpatientFacility.GetHashCode();
                if (this.OutpatientMentalHealth != null)
                    hash = hash * 59 + this.OutpatientMentalHealth.GetHashCode();
                if (this.OutpatientPhysician != null)
                    hash = hash * 59 + this.OutpatientPhysician.GetHashCode();
                if (this.OutpatientSubstance != null)
                    hash = hash * 59 + this.OutpatientSubstance.GetHashCode();
                if (this.PlanMarket != null)
                    hash = hash * 59 + this.PlanMarket.GetHashCode();
                if (this.PlanType != null)
                    hash = hash * 59 + this.PlanType.GetHashCode();
                if (this.PreferredBrandDrugs != null)
                    hash = hash * 59 + this.PreferredBrandDrugs.GetHashCode();
                if (this.PrenatalPostnatalCare != null)
                    hash = hash * 59 + this.PrenatalPostnatalCare.GetHashCode();
                if (this.PreventativeCare != null)
                    hash = hash * 59 + this.PreventativeCare.GetHashCode();
                if (this.PremiumSubsidized != null)
                    hash = hash * 59 + this.PremiumSubsidized.GetHashCode();
                if (this.Premium != null)
                    hash = hash * 59 + this.Premium.GetHashCode();
                if (this.PrimaryCarePhysician != null)
                    hash = hash * 59 + this.PrimaryCarePhysician.GetHashCode();
                if (this.RehabilitationServices != null)
                    hash = hash * 59 + this.RehabilitationServices.GetHashCode();
                if (this.SkilledNursing != null)
                    hash = hash * 59 + this.SkilledNursing.GetHashCode();
                if (this.Specialist != null)
                    hash = hash * 59 + this.Specialist.GetHashCode();
                if (this.SpecialtyDrugs != null)
                    hash = hash * 59 + this.SpecialtyDrugs.GetHashCode();
                if (this.UrgentCare != null)
                    hash = hash * 59 + this.UrgentCare.GetHashCode();
                if (this.MatchPercentage != null)
                    hash = hash * 59 + this.MatchPercentage.GetHashCode();
                if (this.PerfectMatchPercentage != null)
                    hash = hash * 59 + this.PerfectMatchPercentage.GetHashCode();
                if (this.EmployeePremium != null)
                    hash = hash * 59 + this.EmployeePremium.GetHashCode();
                if (this.DependentPremium != null)
                    hash = hash * 59 + this.DependentPremium.GetHashCode();
                return hash;
            }
        }

    }
}

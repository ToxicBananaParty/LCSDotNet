﻿namespace LCSDotNet.Data
{
    public enum LocationType
    {
        Site_Downtown,
        Site_UDistrict,
        Site_OutOfTown,
        Site_Industrial,
        Site_Travel,
        Site_Hospital_Clinic,
        Site_Hospital_University,
        Site_Business_Pawnshop,
        Site_Business_DeptStore,
        Site_Business_ArmsDealer,
        Site_Business_CarDealership,
        Site_Residential_Shelter,
        Site_Residential_Tenement,
        Site_Residential_Apartment,
        Site_Residential_Apartment_Upscale,
        Site_Residential_BombShelter,
        Site_Laboratory_Cosmetics,
        Site_Laboratory_Genetics,
        Site_Government_PoliceStation,
        Site_Government_CourtHouse,
        Site_Government_Prison,
        Site_Government_IntelligenceHQ,
        Site_Government_FireStation,
        Site_Industry_SweatShop,
        Site_Industry_Polluter,
        Site_Industry_Nuclear,
        Site_Industry_Warehouse,
        Site_Corporate_HQ,
        Site_Corporate_House,
        Site_Media_AMRadio,
        Site_Media_CableNews,
        Site_Business_CrackHouse,
        Site_Business_JuiceBar,
        Site_Business_CigarBar,
        Site_Business_LatteStand,
        Site_Business_VeganCoop,
        Site_Business_InternetCafe,
        Site_Business_BarAndGrill,
        Site_Outdoor_PublicPark,
        Site_Outdoor_Bunker,
        Site_Business_Bank
    }

    public enum SpecialBlocks
    {
        CagedAnimals,
        PoliceStation_Lockup,
        CourtHouse_Lockup,
        CourtHouse_JuryRoom,
        Intel_SuperComputer,
        Sweatshop_Equipment,
        Polluter_Equipment,
        Nuclear_OnOff,
        House_Photos,
        House_CEO,
        Corporate_Files,
        Radio_BroadcastStation,
        News_BroadcastStation,
        Apartment_Landlord,
        Restaurant_Table,
        Cafe_Computer,
        Park_Bench,
        Stairs_Up,
        Stairs_Down,
        Club_Bouncer,
        Armory,
        Display_Case,
        Security_Checkpoint,
        Security_MetalDetectors,
        Bank_Vault,
        Bank_Teller,
        Bank_Money,
        CCS_Boss
    }

    public enum SiegeType
    {
        Police,
        CIA,
        Hicks,
        Corporate,
        CCS,
        FireMen,
        Org
    }

    public enum RentingType
    {
        CCS,
        NoControl,
        Permanent
    }
}
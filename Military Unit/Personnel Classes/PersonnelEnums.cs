
namespace Military_Unit.Personnel_Classes
{
    public enum USMCEnlistedRank
    {
        Private = 1, PrivateFirstClass, LanceCorporal, Corporal, Sergeant,
        StaffSergeant, GunnerySergeant, FirstSergeant, MasterSergeant,
        MasterGunnerySergeant, SergeantMajor, SergeantMajoroftheMarineCorps
    }

    public enum USMCOfficerRank
    {
        SecondLieutenant = 1, FirstLieutenant, Captain, Major, LieutenantColonel,
        Colonel, BrigadierGeneral, MajorGeneral, LieutenantGeneral, General
    }

    public enum NavyEnlistedRank
    {
        SeamanRecruit = 1, SeamanApprentice, Seaman, PettyOfficerThirdClass,
        PettyOfficerSecondClass, PettyOfficerFirstClass, ChiefPettyOfficer,
        SeniorChiefPettyOfficer, MasterChiefPettyOfficer, MasterChiefPettyOfficeroftheNavy
    }

    public enum NavyOfficerRank
    {
        Ensign = 1, LieutenantJuniorGrade, Lieutenant, LieutenantCommander, Commander,
        Captain, RearAdmiralLower, RearAdmiralUpper, ViceAdmiral, Admiral, FleetAdmiral
    }

    public enum WarrantOfficerRank
    {
        WarrantOfficer = 1, ChiefWarrantOfficer2, ChiefWarrantOfficer3,
        ChiefWarrantOfficer4, ChiefWarrantOfficer5
    }

    public enum PersonnelTypes
    {
        USMCEnlisted = 1, USMCOfficer, NavyEnlisted, NavyOfficer, WarrantOfficer
    }
}
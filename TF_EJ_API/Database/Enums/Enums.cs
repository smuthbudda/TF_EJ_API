using System.ComponentModel.DataAnnotations;

namespace JWebAPI.Database.Enums
{

    public enum TrackAndFieldEvent
    {
        // Outdoor Sprints
        [Display(Name = "100 Meters")]
        _100Meters,
        
        [Display(Name = "200 Meters")]
        _200Meters,
        
        [Display(Name = "400 Meters")]
        _400Meters,

        // Outdoor Middle Distance
        [Display(Name = "800 Meters")]
        _800Meters,
        
        [Display(Name = "1500 Meters")]
        _1500Meters,
        
        [Display(Name = "Mile")]
        _Mile, // 1609 meters

        // Outdoor Long Distance
        [Display(Name = "3000 Meters")]
        _3000Meters,
        
        [Display(Name = "5000 Meters")]
        _5000Meters,
        
        [Display(Name = "10000 Meters")]
        _10000Meters,
        
        [Display(Name = "Marathon")]
        _Marathon, // 42195 meters

        // Outdoor Hurdles
        [Display(Name = "110 Meter Hurdles")]
        _110MeterHurdles,
        
        [Display(Name = "400 Meter Hurdles")]
        _400MeterHurdles,

        // Outdoor Relays
        [Display(Name = "4x100 Meter Relay")]
        _4x100MeterRelay,
        
        [Display(Name = "4x400 Meter Relay")]
        _4x400MeterRelay,

        // Outdoor Steeplechase
        [Display(Name = "3000 Meter Steeplechase")]
        _3000MeterSteeplechase,

        // Outdoor Field Events
        [Display(Name = "High Jump")]
        _HighJump,
        
        [Display(Name = "Long Jump")]
        _LongJump,
        
        [Display(Name = "Triple Jump")]
        _TripleJump,
        
        [Display(Name = "Pole Vault")]
        _PoleVault,
        
        [Display(Name = "Shot Put")]
        _ShotPut,
        
        [Display(Name = "Discus Throw")]
        _DiscusThrow,
        
        [Display(Name = "Hammer Throw")]
        _HammerThrow,
        
        [Display(Name = "Javelin Throw")]
        _JavelinThrow,

        // Combined Events (Decathlon, Heptathlon)
        [Display(Name = "Decathlon")]
        _Decathlon,
        
        [Display(Name = "Heptathlon")]
        _Heptathlon,

        // Indoor Events
        // Sprints
        [Display(Name = "60 Meters")]
        _60Meters,
        
        // Middle Distance
        [Display(Name = "400 Meters (Indoor)")]
        _400MetersIndoor,
        
        // Relays
        [Display(Name = "4x200 Meter Relay")]
        _4x200MeterRelayIndoor,
        
        [Display(Name = "4x400 Meter Relay (Indoor)")]
        _4x400MeterRelayIndoor,

        // Field Events
        [Display(Name = "Pentathlon")]
        _Pentathlon,
        
        [Display(Name = "Weight Throw")]
        _WeightThrow
    }
}
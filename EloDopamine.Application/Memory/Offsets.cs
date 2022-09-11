namespace EloDopamine.Application.Memory;

/*
Dump done: 2022-08-30 14:06:39
Live patch: 12.16.4624391+branch.releases-12-16.code.public
*/

public static class Offsets
{
// ===== Basic Offsets =====
	public const int ObjectSpellBook = 0x2950; // Dumper could not find this offset.
	public const int GameTime = 0x313aff0;
	public const int UnderMouseObject = 0x24f29c4;
	public const int Renderer = 0x3174df4;
	public const int HudInterface = 0x18a50fc;
	public const int ObjectManager = 0x18a503c;
	public const int LocalPlayer = 0x3141554;
	public const int ViewProjMatrices = 0x316f328;
// ===== Object related Offsets =====
	public const int ObjectMapCount = 44;
	public const int ObjectMapRoot = 40;
	public const int ObjectMapNodeNetId = 16;
	public const int ObjectMapNodeObject = 20;
	public const int ObjectIndex = 8;
	public const int ObjectTeam = 52;
	public const int ObjectDirection = 0x1F4; // Dumper could not find this offset.
	public const int ObjectPosition = 0x1DC; // Dumper could not find this offset.
	public const int ObjectDead = 0x021C; // idk
	public const int ObjectVisibility =  0x274; // Dumper could not find this offset.
	public const int ObjectMana = 0x029C; // Dumper could not find this offset.
	public const int ObjectMaxMana = 0x02AC; // Dumper could not find this offset.
	public const int ObjectInvulnerable = 0x03D4; // Dumper could not find this offset.
	public const int ObjectTargetable = 0x0D04; // Dumper could not find this offset.
	public const int ObjectHealth = 0x0E74;
	public const int ObjectMaxHealth = 0x0E84; // Dumper could not find this offset.
	public const int ObjectBonusAttackDamage = 0x12C4; // Dumper could not find this offset.
	public const int ObjectAttackDamage = 0x134C; // Dumper could not find this offset.
	public const int ObjectArmor = 0x1374; // Dumper could not find this offset.
	public const int ObjectBonusArmor = 0x1374; // Dumper could not find this offset.
	public const int ObjectMagicResist = 0x137C; // Dumper could not find this offset.
	public const int ObjectMovementSpeed = 0x138C; // Dumper could not find this offset.
	public const int ObjectAttackRange = 0x139C; // Dumper could not find this offset.
	public const int ObjectChampionName = 0x2D3C; // Dumper could not find this offset.
// ===== SpellBook related Offsets =====
	public const int SpellReadyAt = 36;
	public const int SpellLevel = 28;
	public const int SpellDamage = 148;
	public const int SpellManaCost = 1324;
	public const int SpellInfo = 0x120;
	public const int SpellName = 0x18;
// ===== Buffs related Offsets =====
// ===== Object lists =====
	public const int MinionInterface = 0x24f2850;
	public const int TurretInterface = 0x3139d5c;
	public const int HeroInterface = 0x18a50d0;
	public const int MissileInterface = 0x3142288;
// ===== Renderer related Offsets =====
	public const int GameWindowWidth = 8;
	public const int GameWindowHeight = 0xc;
// ===== Utility Offsets =====
	public const int ChatInstance = 0x31422e4; // [] means pointer
	public const int ChatIsChatOpen = 0x760; // [ChatInstance] + IsChatOpen
	public const int HudIsFocused = 0x68; // [HudInstance] + IsFocused
	public const int HudMouseWorldPosition = 0x19c; // [HudInstance] + IsFocused
	public const int GameVersion = 0x151dd84;
	
// ===== Ai Manager Offsets =====
	public const int AiManager = 0x2e14;
	public const int AiManagerStartPath = 0x1cc;
	public const int AiManagerEndPath = 0x1d8;
	public const int AiManagerIsMoving = 0x1c0;
	public const int AiManagerIsDashing = 0x214;
	public const int AiManagerDashSpeed = 0x1f8;
	public const int AiManagerNavigationArray = 0x1e4;
	public const int AiManagerNavigationArrayLength = 0x1e8;
	public const int AiManagerCurrentSegment = 0x1c4;
}
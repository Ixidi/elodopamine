namespace EloDopamine.Application.Memory;

/*
Dump done: 2022-08-30 14:06:39
Live patch: 12.16.4624391+branch.releases-12-16.code.public
*/

public static class Offsets
{
// ===== Basic Offsets =====
	public const int LocalPlayer = 0x3118ddc;
	public const int GameTime = 0x3111e68;
	public const int ObjectManager = 0x187bec0;
	public const int Renderer = 0x314b90c;
	public const int UnderMouseObject = 0x24c98fc;
	public const int ViewProjMatrices = 0x3148a20;
	public const int HudInterface = 0x187bf80;
	public const int ObjectSpellBook = 0; // Dumper could not find this offset.
// ===== Object related Offsets =====
	public const int ObjectMapCount = 44;
	public const int ObjectMapRoot = 40;
	public const int ObjectMapNodeNetId = 16;
	public const int ObjectMapNodeObject = 20;
	public const int ObjectIndex = 8;
	public const int ObjectTeam = 52;
	public const int ObjectDirection = 0; // Dumper could not find this offset.
	public const int ObjectPosition = 0x01DC; // Dumper could not find this offset.
	public const int ObjectDead = 0; // Dumper could not find this offset.
	public const int ObjectVisibility = 0x0274; // Dumper could not find this offset.
	public const int ObjectMana = 0; // Dumper could not find this offset.
	public const int ObjectMaxMana = 0; // Dumper could not find this offset.
	public const int ObjectInvulnerable = 0; // Dumper could not find this offset.
	public const int ObjectTargetable = 0; // Dumper could not find this offset.
	public const int ObjectHealth = 0xe74;
	public const int ObjectMaxHealth = 0; // Dumper could not find this offset.
	public const int ObjectBonusAttackDamage = 0; // Dumper could not find this offset.
	public const int ObjectAttackDamage = 0; // Dumper could not find this offset.
	public const int ObjectArmor = 0; // Dumper could not find this offset.
	public const int ObjectBonusArmor = 0; // Dumper could not find this offset.
	public const int ObjectMagicResist = 0; // Dumper could not find this offset.
	public const int ObjectMovementSpeed = 0x138C; // Dumper could not find this offset.
	public const int ObjectAttackRange = 0x1394; // Dumper could not find this offset.
	public const int ObjectChampionName = 0x2BD4; // Dumper could not find this offset.
// ===== SpellBook related Offsets =====
	public const int SpellReadyAt = 36;
	public const int SpellLevel = 28;
	public const int SpellDamage = 148;
	public const int SpellManaCost = 1324;
	public const int SpellInfo = 288;
	public const int SpellName = 24;
// ===== Buffs related Offsets =====
// ===== Object lists =====
	public const int HeroInterface = 0; // Dumper could not find this offset.
	public const int MinionInterface = 0; // Dumper could not find this offset.
	public const int TurretInterface = 0; // Dumper could not find this offset.
	public const int MissileInterface = 0x3118e34;
// ===== Renderer related Offsets =====
	public const int GameWindowWidth = 12;
	public const int GameWindowHeight = 16;
// ===== Utility Offsets =====
	public const int GameVersion = 0x151dd84;
// ===== Ai Manager Offsets =====
	public const int AiManager = 0;
	public const int AiManagerStartPath = 0;
	public const int AiManagerEndPath = 0;
	public const int AiManagerIsMoving = 0;
	public const int AiManagerIsDashing = 0;
	public const int AiManagerNavigationArray = 0;
	public const int AiManagerNavigationArrayLength = 0;
}
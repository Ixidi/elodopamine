namespace EloDopamine.Application.Game;

public static class Offsets
{
    public const int LOCAL_PLAYER = 0x310ed68;
    public const int GAME_TIME = 0x31081a8;
    public const int OBJECT_MANAGER = 0x1870bd8;
    public const int RENDERER = 0x3141584;
    public const int UNDER_MOUSE_OBJECT = 0x24bfc24;
    public const int VIEW_PROJ_MATRICES = 0x313e6a0;
    public const int OBJECT_MAP_COUNT = 44;
    public const int OBJECT_MAP_ROOT = 40;
    public const int OBJECT_MAP_NODE_NET_ID = 16;
    public const int OBJECT_MAP_NODE_OBJECT = 20;
    public const int OBJECT_INDEX = 0x0008; // Dumper could not find this offset. 
    public const int OBJECT_TEAM = 0x0034; // Dumper could not find this offset. 
    public const int OBJECT_DIRECTION = 0x1BB0; // Dumper could not find this offset. 
    public const int OBJECT_POSITION = 0x01DC; // Dumper could not find this offset. 
    public const int OBJECT_DEAD = 0x021C; // Dumper could not find this offset. 
    public const int OBJECT_VISIBILITY = 0x0274; // Dumper could not find this offset. 
    public const int OBJECT_MANA = 0x029C; // Dumper could not find this offset. 
    public const int OBJECT_MAX_MANA = 0x02AC; // Dumper could not find this offset. 
    public const int OBJECT_INVULNERABLE = 0x03D4; // Dumper could not find this offset. 
    public const int OBJECT_TARGETABLE = 0x0D04; // Dumper could not find this offset. 
    public const int OBJECT_HEALTH = 0x0E74; // Dumper could not find this offset. 
    public const int OBJECT_MAX_HEALTH = 0x0E84; // Dumper could not find this offset. 
    public const int OBJECT_BONUS_ATTACK_DAMAGE = 0x12C4; // Dumper could not find this offset. 
    public const int OBJECT_ATTACK_DAMAGE = 0x134C; // Dumper could not find this offset. 
    public const int OBJECT_ARMOR = 0x1374; // Dumper could not find this offset. 
    public const int OBJECT_BONUS_ARMOR = 0x1378; // Dumper could not find this offset. 
    public const int OBJECT_MAGIC_RESIST = 0x137C; // Dumper could not find this offset. 
    public const int OBJECT_MOVEMENT_SPEED = 0x138C; // Dumper could not find this offset. 
    public const int OBJECT_ATTACK_RANGE = 0x1394; // Dumper could not find this offset. 
    public const int OBJECT_CHAMPION_NAME = 0x2BA4; // Dumper could not find this offset. 
    public const int OBJECT_HEALTH_BAR_POS = 0x00E4; // Dumper could not find this offset. 
    public const int HERO_INTERFACE = 0x1870c68;
    public const int MINION_INTERFACE = 0x24bfab4;
    public const int TURRET_INTERFACE = 0x3105acc;
    public const int MISSILE_INTERFACE = 0x24bfa60;
    public const int GAME_WINDOW_WIDTH = 12;
    public const int GAME_WINDOW_HEIGHT = 16;
    public const int GAME_VERSION = 0x1510f04;

    // AI MANAGER 
    public const int AI_MANAGER = 0x2C7C; // must be i32 
    public const int AI_MANAGER_START_PATH = 0x1CC;
    public const int AI_MANAGER_END_PATH = 0x1D8;
    public const int AI_MANAGER_IS_MOVING = 0x1C0;
}
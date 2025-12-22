using UnityEngine;

namespace Thing
{
    public enum items {
        Firewood,
        Bullets
    }

    public enum buttons {
        // Null
        Null,
        // Main Menu
        Start,
        Settings,
        Credits,
        Quit,
        // Settings Menu
        Fullscreen,
        VSync,
        Back
    }

    public enum menuId {
        Start,
        Main,
        Settings,
        Credits,
        GameOver,
        Win
    }

    // ID system for all states the player can be in
    public enum playerStateTypes {
        Standing,
        Aiming,
        Death
    };
}
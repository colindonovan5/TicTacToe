using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : IPlayer {
    public Mark mark { get; set; }
    public bool Won { get; set; }
    public Player()
    {
        Won = false;
        mark = Mark.None;
    }
}

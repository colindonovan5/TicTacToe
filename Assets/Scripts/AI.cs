using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class AI : IPlayer
{
    public Mark mark { get; set; }
    public bool Won { get; set; }
    public Shape SelectedShape { get; set; }
    public AI()
    {
        Won = false;
        mark = Mark.None;     
    }
    public void Move()
    {
            
    }
}

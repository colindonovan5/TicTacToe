using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using UnityEngine;

    public interface IPlayer
    {
        Mark mark { get; set; }
        bool Won { get; set; }
    }

    

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move
{
    public MoveBase moveBase { get; set; }
    public int pp { get; set; }

    public Move(MoveBase moveBase)
    {
        this.moveBase = moveBase;
        this.pp = moveBase.PP;
    }
}

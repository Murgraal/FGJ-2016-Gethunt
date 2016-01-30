using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum Skills {DotDotDot, Hello, ManyTimes, SweetSugar, MyPlace, FuckOrWhat, Punch, Baptism,
Erotomania, BuyBeer, BuyBooze, BuyWine, LickAss, FuckYou, GrabAss, ThrowWater, YoureWelcome, NoMore, Suprise, FuckOff,
KillYou};

public class UnitData : MonoBehaviour
{

    public float morale;
    public float drunkLvl;
    public List<Skills> _skills;
    public List<float> _resists;


    //effectId = 0 neutral
    //effectId = 1 friendly
    //effectId = 2 flirty
    //effectId = 3 cheesy
    //effectId = 4 fuck with
    //effectId = 5 aggressive
    //effectId = 6 idiot

}


using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
//public enum Skills {DotDotDot, Hello, ManyTimes, SweetSugar, MyPlace, FuckOrWhat, Punch, Baptism,
//Erotomania, BuyBeer, BuyBooze, BuyWine, LickAss, FuckYou, GrabAss};ThrowWater, YoureWelcome, NoMore, Suprise, FuckOff,
//KillYou};
public class Skill
{

    public struct Effect
    {
        public float effectAmount;
        public int effectId;
    }


    public string _dialogueOption;
    public Effect _effect;

    public Skill(int _id)
    {
        if (_id == 0)
        {
            _effect = new Effect() {effectAmount = 5f, effectId = 0};
            _dialogueOption = "...";
        }
        else if (_id == 1)
        {
            _dialogueOption = "Hello there!";
        }
        else if (_id == 2)
        {
            _dialogueOption = "So, do you come here often?";
        }
        else if (_id == 3)
        {
            _dialogueOption = "Was you mother sugar because you're so sweet?";
        }
        else if (_id == 4)
        {
            _dialogueOption = "Shall we go to my place, or yours?";
        }
        else if (_id == 5)
        {
            _dialogueOption = "Are we going to fuck or what?";
        }
        else if (_id == 6)
        {
            _dialogueOption = "I'm gonna kick your ass!";
        }
        else if (_id == 7)
        {
            _dialogueOption = "Do you feel like taking Jesus in your life?";
        }
        else if (_id == 8)
        {
            _dialogueOption = "Hey, I'm gonna sing a song!";
        }
        else if (_id == 9)
        {
            _dialogueOption = "One beer, please";
        }
        else if (_id == 10)
        {
            _dialogueOption = "One stiff, please";
        }
        else if (_id ==11)
        {
            _dialogueOption = "Red Wine, please";
        }
        else if (_id == 12)
        {
            _dialogueOption = "Oh pardon me, I didn't really mean that dear sir!";
        }
        else if (_id == 13)
        {
            _dialogueOption = "Fuck you, Motherfucker!";
        }
        else if (_id == 14)
        {
            _dialogueOption = "Let me see that thing more closer!";
        }
        else if (_id == 15)
        {
            _dialogueOption = "Eww, go away you beast!";
        }
        else if (_id == 16)
        {
            _dialogueOption = "You're welcome, sir";
        }
        else if (_id == 17)
        {
            _dialogueOption = "Seems you have had one too many";
        }
        else if (_id == 18)
        {
            _dialogueOption = "Suprise, Motherfucker!";
        }
        else if (_id == 19)
        {
            _dialogueOption = "FUCK OFF!";
        }
        else if (_id == 20)
        {
            _dialogueOption = "I'm gonna kill you!";
        }

    }

    public void Actions1()
    {

    }

    public void Action2()
    {

    }

    public void Action3()
    {

    }

    public void Action4()
    {

    }

    public void Action5()
    {

    }

    public void Action6()
    {

    }
}

public class Fighter
{
    public List<Skill> _skills = new List<Skill>();
    //public List<Action> _Fullactions = new List<Action>();
    public UnitData _unitData;

    public Fighter()
    {
        /*_Fullactions.Add(Skill1);
        _Fullactions.Add(Skill2);
        _Fullactions.Add(Skill3);
        _Fullactions.Add(Skill4);
        _Fullactions.Add(Skill5);
        _Fullactions.Add(Skill6);*/
    }

    

}

public class CombatManager : MonoBehaviour {

    enum CombatState {PlayerTurn, EnemyTurn};
    

    CombatState _combatState;
    Fighter _playerFighter;
    Fighter _enemyFighter;




    // Use this for initialization
    void Start ()
    {
        _combatState = CombatState.PlayerTurn;

        Fighter _fight = new Fighter();

        
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (_combatState == CombatState.PlayerTurn)
        {
           // PlayerCombat.Instance.Attack();
        }

        if (_combatState == CombatState.EnemyTurn)
        {

        }
	
	}

    void OnGUI()
    {
        GUI.BeginGroup(new Rect(300, 600, 200, 200));
        GUILayout.BeginVertical();
        if (_combatState == CombatState.PlayerTurn)
        {
            GUILayout.BeginHorizontal();
            for (int i = 0; i < _playerFighter._skills.Count; i++)
            {
                GUI.BeginGroup(new Rect(0, 20 * i, 199, 199));
                if (_combatState == CombatState.PlayerTurn)
                {
                    WritePlayerOptions(_playerFighter._skills[i]._dialogueOption);
                }
                GUI.EndGroup();
            }

            GUILayout.EndHorizontal();
        }
       
        
        GUILayout.BeginHorizontal();
        //EnemyUI
        GUILayout.EndHorizontal();

        GUILayout.EndVertical();
        GUI.EndGroup();
    }


    void WritePlayerOptions(string _msg)
    {
        GUI.Label(new Rect(20, 0, 300, 30), _msg);
    }

    void WriteEnemyAnswer(string _emsg)
    {
        GUI.Label(new Rect(20, 0, 300, 30), _emsg);
    }

    public void InitBattle(UnitData _player, UnitData _enemy, int _backgroundId)
    {
        IniateArea(_backgroundId);
        

        
        _playerFighter = new Fighter() {_unitData = _player};
        for(int i = 0; i < _player._skills.Count; i++)
        {
            _playerFighter._skills.Add(new Skill((int)_player._skills[i]));
            //very smooth
        }

        _enemyFighter = new Fighter() { _unitData = _enemy };

        for (int i = 0; i < _enemy._skills.Count; i++)
        {
            _enemyFighter._skills.Add(new Skill((int)_enemy._skills[i]));
        }
        
    }

    void IniateArea(int _backgroundArea)
    {

    }

    public void EndTurn()
    {
        if (_combatState == CombatState.EnemyTurn)
        {
            _combatState = CombatState.PlayerTurn;
        }
        else if (_combatState == CombatState.PlayerTurn)
        {
            _combatState = CombatState.EnemyTurn;
        }
    }

   
}

using UnityEngine;
using System.Collections;



public class CombatManager : MonoBehaviour {

    enum CombatState {PlayerTurn, EnemyTurn};
    

    CombatState _combatState;
    
    


	// Use this for initialization
	void Start ()
    {
        _combatState = CombatState.PlayerTurn;
        
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (_combatState == CombatState.PlayerTurn)
        {
            PlayerCombat.Instance.Attack();
        }

        if (_combatState == CombatState.EnemyTurn)
        {

        }
	
	}

    void OnGUI()
    {
        GUI.BeginGroup(new Rect(300, 600, 200, 200));
        GUILayout.BeginVertical();
        GUILayout.BeginHorizontal();

        for (int i = 0; i < PlayerCombat.Instance._Playermsgs.Count; i++)
        {
            GUI.BeginGroup(new Rect(0, 20 * i, 199, 199));
            WritePlayerOptions(PlayerCombat.Instance._Playermsgs[i]);
            GUI.EndGroup();
        }

        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        WriteEnemyAnswer("...");
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
}

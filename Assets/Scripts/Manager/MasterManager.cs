using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

[CreateAssetMenu(menuName = "Singletons/MasterManager")]

public class MasterManager : SingletonScriptableObject<MasterManager>
{

    [SerializeField]

    private GameSettings _gameSettings;

    public static GameSettings GameSettigns { get { return Instance._gameSettings; } }

}

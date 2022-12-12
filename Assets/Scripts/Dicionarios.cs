using System.Collections.Generic;
using UnityEngine;

public class Dicionarios : MonoBehaviour {

    Dictionary<string, string> monster = new Dictionary<string, string>();

    void Start() {
        monster.Add("name", "Matador");
        monster.Add("life", "100");
        foreach(string key in monster.Keys) {
            print($"monster[{key}] = {monster[key]}");
        }
        monster.Remove("life");
        foreach (string key in monster.Keys) {
            print($"monster[{key}] = {monster[key]}");
        }
    }

    void Update() {
        
    }
}

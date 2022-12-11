using UnityEngine;

/* Comentario de multiplas linhas */
public class Variaveis : MonoBehaviour {

    int coins = 10;
    //float money = 10.2f;
    //int integerMoney;
    //bool isAlive = true;
    string text = "Ola mundo!";

    // Roda antes do primeiro frame disparar
    void Start() {
        print(text);
    }

    // Roda a cada frame disparado
    void Update() {
        print($"Moedas: {coins}");
        coins += 1;
    }
}

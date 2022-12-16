using System;
using UnityEngine;

/* Comentario de multiplas linhas */
public class ConversaoDeTipos : MonoBehaviour {

    float money = 10.2f;
    int integerMoney;

    // Roda antes do primeiro frame disparar
    void Start() {
        //integerMoney = (int) money;
        integerMoney = Convert.ToInt32(money);
        print(integerMoney.ToString());
    }

    // Roda a cada frame disparado
    void Update() {
    }
}
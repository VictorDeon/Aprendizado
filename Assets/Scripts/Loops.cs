using UnityEngine;

public class Loops : MonoBehaviour {

    string[] inimigos = { "caveira", "matador", "atirador" };

    void Start() {
        print("La�o FOR");
        for(int i = 0; i <= 10; i++) {
            print(i);
        }

        print("La�o WHILE");
        int j = 0;
        while(j <= 10) {
            print(j);
            j++;
        }

        print("La�o DO WHILE");
        int k = 10;
        do {
            print(k);
            k++;
        } while (k <= 10);

        print("La�o FOREACH");
        foreach(string nome in inimigos) {
            print(nome);
        }

        print("Break e Continue");
        for (int i = 0; i <= 20; i++) {
            // Pula os numeros pares
            if (i % 2 == 0) {
                continue;
            }
            // Para no 9;
            if(i == 11) {
                break;
            }
            print(i);
        }
    }

    void Update() {
        
    }
}

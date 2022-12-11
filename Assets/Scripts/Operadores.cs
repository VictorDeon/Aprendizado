using UnityEngine;

/* Comentario de multiplas linhas */
public class Operadores : MonoBehaviour {

    int n1, n2;

    // Roda antes do primeiro frame disparar
    void Start() {
        n1 = 20;
        n2 = 10;
        print($"N1 = {n1} e N2 = {n2}");
        // Operadores Aritmeticos
        print("Operadores Aritmeticos");
        print($"{n1} + {n2} = {n1 + n2}");
        print($"{n1} - {n2} = {n1 - n2}");
        print($"{n1} * {n2} = {n1 * n2}");
        print($"{n1} / {n2} = {n1 / n2}");
        print($"{n1} % {n2} = {n1 % n2}");
        // Incremento e Decremento
        print("Incremento e Decremento");
        print($"Pos-Incremento: {n1++}");
        print($"Pre-Incremento: {++n1}");
        print($"Pos-Decremento: {n1--}");
        print($"Pre-Decremento: {--n1}");
        // Operadores Reduzidos
        print("Operadores Reduzidos");
        print($"{n1} += 10 => {n1 += 10}");
        print($"{n1} -= 5 => {n1 -= 5}");
        print($"{n1} *= 10 => {n1 *= 2}");
        print($"{n1} /= {n2} => {n1 /= n2}");
        print($"{n1} %= 10 => {n1 %= 2}");
        // Operadores relacionais
        /*
            == igual
            != diferente
            >= maior ou igual
            <= menor ou igual
            >  maior que
            <  menor que
        */
        print("Operadores Relacionais");
        print($"{n1} == {n2} ? {n1 == n2}");
        print($"{n1} != {n2} ? {n1 != n2}");
        print($"{n1} >= {n2} ? {n1 >= n2}");
        print($"{n1} <= {n2} ? {n1 <= n2}");
        print($"{n1} > {n2} ? {n1 > n2}");
        print($"{n1} < {n2} ? {n1 < n2}");
        // Operadores Lógicos
        /*
            AND (&&)
            False AND False = False
            False AND True  = False
            True  AND False = False
            True  AND True  = True

            OR (||)
            False || False  = False
            False || True   = True
            True  || False  = True
            True  || True   = True

            NOT (!)
            NOT False = True
            NOT True  = False
        */
        print($"{n1} != {n2} && {n1} < {n2} = {n1 != n2 && n1 < n2}");
        print($"{n1} == {n2} || {n1} > {n2} = {n1 == n2 || n1 > n2}");
        print($"!({n1} == {n2}) = {!(n1 == n2)}");
    }

    // Roda a cada frame disparado
    void Update() {
    }
}
using System.Collections;
using System.Collections.Generic;
using _Game.Scripts;
using UnityEngine;

public class AnimalHome : MonoBehaviour {
    public AnimalType animalType;

    private void OnTriggerEnter2D(Collider2D col) {
        if (!col.CompareTag("Player")) return;

        if (col.GetComponent<Animal>().animalType == animalType)
            OnCorrectAnimalTrigger();
        else
            OnWrongAnimalTrigger();

        Destroy(col.gameObject);
    }

    private void OnWrongAnimalTrigger() {
        ScoreSystem.Instance.RemoveScore(1);
        print("Wrong Animal");
    }

    private void OnCorrectAnimalTrigger() {
        ScoreSystem.Instance.AddScore(1);
        print("Correct Animal");
    }
}
using UnityEngine;

public class PracticaGitBehaviour : MonoBehaviour {
    [SerializeField]
    [Tooltip("Introducir nombre del autor")]
    private string nombreAutor;
    
    private void Start() {
        Debug.Log("Practica realizada por: ");
        Debug.Log("Autor de la práctica/Práctica realizada por: ");
        Debug.Log(nombreAutor);
    }
}
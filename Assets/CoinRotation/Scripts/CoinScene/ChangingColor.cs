using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingColor : MonoBehaviour
{
    
    private void OnMouseDown() {
        Material currentMaterial = GetComponent<Material>();
        Renderer renderer = GetComponent<Renderer>();

        // Проверяем, что у объекта есть материал
        if (renderer != null && renderer.material != null)
        {
            // Изменяем цвет альбедо материала
            renderer.material.color = new Color(Random.value,Random.value,Random.value);
        }
    }
}

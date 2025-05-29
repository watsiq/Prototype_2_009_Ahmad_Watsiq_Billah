using UnityEngine;
using UnityEngine.Events;

public class FootTrigger : MonoBehaviour
{
    public string triggerTag = "Foot";
    public Color newColor = Color.red; // Warna baru yang bisa dipilih
    public Renderer targetRenderer;    // Objek yang akan diubah warnanya

    public UnityEvent onTriggerEvent;  // Event tambahan opsional

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(triggerTag))
        {
            if (targetRenderer != null)
            {
                targetRenderer.material.color = newColor;
            }

            onTriggerEvent.Invoke(); // Menjalankan event tambahan (jika diatur)
        }
    }
}

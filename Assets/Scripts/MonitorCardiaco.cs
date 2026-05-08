using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MonitorCardiaco : MonoBehaviour
{
    [Header("Configurações da Interação")]
    public Color corNormal = Color.blue;
    public Color corAtiva = Color.green;
    public AudioClip somHeartbeat;
    
    private Renderer monitorRenderer;
    private AudioSource audioSource;
    private bool estaAtivo = false;
    
    void Start()
    {
        // Obtém o componente Renderer do monitor
        monitorRenderer = GetComponent<Renderer>();
        
        // Cria um AudioSource se não existir
        if (GetComponent<AudioSource>() == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        else
        {
            audioSource = GetComponent<AudioSource>();
        }
        
        // Define cor inicial
        if (monitorRenderer != null)
        {
            monitorRenderer.material.color = corNormal;
        }
    }
    
    // Método chamado quando o objeto é selecionado (interação XR)
    public void OnSelectEntered(SelectEnterEventArgs args)
    {
        ToggleMonitor();
    }
    
    // Método chamado quando o objeto é deselecionado
    public void OnSelectExited(SelectExitEventArgs args)
    {
        // Opcional: desativar ao soltar
        // ToggleMonitor();
    }
    
    void ToggleMonitor()
    {
        estaAtivo = !estaAtivo;
        
        if (monitorRenderer != null)
        {
            monitorRenderer.material.color = estaAtivo ? corAtiva : corNormal;
        }
        
        if (audioSource != null && somHeartbeat != null)
        {
            if (estaAtivo)
            {
                audioSource.PlayOneShot(somHeartbeat);
            }
            else
            {
                audioSource.Stop();
            }
        }
        
        Debug.Log($"Monitor cardíaco {(estaAtivo ? "ATIVO" : "INATIVO")}");
    }
}

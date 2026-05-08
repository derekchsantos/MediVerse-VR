# Relatório Técnico: Desenvolvimento de Ambiente Virtual (VR)
**Projeto:** MediVerse — Sala de Emergência Virtual  
**Data:** 08 de Maio de 2024  
**Autor:** Derek Santos  

---

## 1. IDENTIFICAÇÃO


| Campo | Informação |
| :--- | :--- |
| **Nome Completo** | Derek Chrispoher Dos Santos |
| **Turma** | 5 |
| **Limitação de Hardware** | GPU sem suporte a Vulkan / RAM insuficiente para Unity Editor local |

---

## 2. CONCEITO DO PROJETO

### 2.1 Nome do Projeto
**MediVerse: Sala de Emergência Virtual**

### 2.2 Contexto e Objetivo
O projeto consiste em um ambiente educacional imersivo para o treinamento de procedimentos médicos. O foco é democratizar o acesso a simulações de alta fidelidade para instituições com recursos limitados, permitindo a prática de protocolos hospitalares em um ambiente seguro e controlado.

### 2.3 Descrição do Ambiente
Uma sala de emergência com dimensões de **10x8 metros**, configurada com iluminação técnica (6500K). O cenário inclui:
*   **Monitor Cardíaco:** Interface interativa para sinais vitais.
*   **Cama de Hospital:** Centro focal para simulação de pacientes.
*   **Mobiliário Técnico:** Armário de medicamentos e portas automatizadas.

---

## 3. CONFIGURAÇÃO TÉCNICA

### 3.1 Stack Tecnológica
*   **Engine:** Unity 6000.3.9f1 LTS
*   **SDK Principal:** Meta XR All-in-One SDK
*   **Pipeline de Renderização:** Universal Render Pipeline (URP)

### 3.2 Configurações de Build (Meta Quest)


| Configuração | Especificação |
| :--- | :--- |
| **Plataforma** | Android |
| **Texture Compression** | ASTC |
| **Minimum API Level** | Android 10 (Level 29) |
| **Target Architecture** | ARM64 |

---

## 4. ARQUITETURA DE ASSETS E CENA

### 4.1 Inventário de Objetos

| ID | Nome | Tipo | Função |
| :-- | :--- | :--- | :--- |
| 01 | MonitorCardiaco | 3D Mesh | Equipamento interativo principal |
| 02 | CamaHospital | 3D Mesh | Ponto de interação do paciente |
| 03 | HeartbeatSound | Audio | Feedback sonoro (SFX) |
| 04 | XR Origin | Rig | Representação do usuário no espaço virtual |

### 4.2 Hierarquia de Game Objects (Estrutura)
```text
Scene: EmergencyRoom
├── [MANAGEMENT]
│   └── XR Interaction Manager
├── [PLAYER]
│   └── XR Origin (Camera Offset)
│       ├── Main Camera
│       └── Controllers (Left/Right)
├── [ENVIRONMENT]
│   ├── Static_Geometry (Floor, Walls)
│   └── Lighting (Directional/Point)
└── [INTERACTABLES]
    └── Monitor_Vital (Script: MonitorCardiaco.cs)
```

---

## 5. SISTEMA DE INTERAÇÃO

### 5.1 Lógica de Funcionamento
A interação é baseada em **Raycasting**. O usuário utiliza o controlador para apontar e disparar o evento `OnSelectEntered`. O sistema alterna o estado do monitor, alterando a emissão de cor do material e disparando o áudio correspondente.

### 5.2 Script Principal: `MonitorCardiaco.cs`

```csharp
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MonitorCardiaco : MonoBehaviour
{
    public Color corNormal = Color.blue;
    public Color corAtiva = Color.green;
    public AudioClip somHeartbeat;
    
    private Renderer monitorRenderer;
    private AudioSource audioSource;
    private bool estaAtivo = false;
    
    void Start()
    {
        monitorRenderer = GetComponent<Renderer>();
        audioSource = GetComponent<AudioSource>() ?? gameObject.AddComponent<AudioSource>();
            
        if (monitorRenderer != null)
            monitorRenderer.material.color = corNormal;
    }
    
    public void OnSelectEntered(SelectEnterEventArgs args)
    {
        ToggleMonitor();
    }
    
    void ToggleMonitor()
    {
        estaAtivo = !estaAtivo;
        if (monitorRenderer != null)
            monitorRenderer.material.color = estaAtivo ? corAtiva : corNormal;
            
        if (audioSource != null && somHeartbeat != null)
        {
            if (estaAtivo) audioSource.PlayOneShot(somHeartbeat);
            else audioSource.Stop();
        }
    }
}
```

---

## 6. PLANO DE EXECUÇÃO E REPOSITÓRIO

### 6.1 Estrutura do GitHub
*   `/Assets`: Scripts, Prefabs e Materiais.
*   `/Scenes`: Arquivos de cena (.unity).
*   `.gitignore`: Template oficial da Unity para evitar arquivos temporários.

### 6.2 Etapas de Desenvolvimento
1.  Setup do Projeto e Importação do **Meta XR SDK**.
2.  Configuração do **XR Interaction Toolkit** e Simulação em PC.
3.  Criação do cenário e aplicação de materiais URP.
4.  Codificação da lógica de interação em C#.
5.  Otimização de performance e Build final (.apk).

---

## 7. REFLEXÃO E MELHORIAS FUTURAS

*   **Dificuldades:** Otimizar o workflow para contornar a falta de suporte Vulkan no hardware de desenvolvimento.
*   **Aprendizado:** Entendimento profundo da árvore de eventos do XR Interaction Toolkit.
*   **Upgrade:** Planejada a inclusão de suporte **Multiplayer** e sistemas de **Hand Tracking**.

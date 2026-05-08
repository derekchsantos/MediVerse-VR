# MediVerse: Sala de Emergência Virtual 🏥💙

![Unity](https://shields.io)
![Meta](https://shields.io)
![License](https://shields.io)

Um ambiente de **Realidade Virtual (VR)** desenvolvido no Unity para treinamento médico e educação em saúde. Este projeto foi concebido como parte da **Residência em TIC 29 — Desenvolvimento de Metaverso**.

---

##  Sobre o Projeto

O **MediVerse** é uma experiência imersiva que simula uma sala de emergência hospitalar de alta fidelidade. O sistema permite que o usuário:
*   Explore o ambiente clínico em escala real.
*   Interaja com equipamentos médicos (ex: Monitor Cardíaco).
*   Receba feedbacks visuais e sonoros baseados em protocolos reais.

O objetivo técnico é demonstrar os fundamentos de **XR (Extended Reality)**, incluindo navegação espacial, sistemas de interação baseados em Raycast e otimização para dispositivos standalone.

---

## Requisitos Técnicos

*   **Engine:** Unity 6000.3.9f1 (LTS) ou superior.
*   **SDK:** Meta XR All-in-One SDK.
*   **Render Pipeline:** Universal Render Pipeline (URP).
*   **Hardware:** Meta Quest 2 / Quest 3 ou PC com Meta XR Simulator.

---

##  Instalação e Configuração

1.  **Clone o repositório:**
    ```bash
    git clone https://github.com
    ```
2.  **Abertura:** Importe o projeto no Unity Hub utilizando a versão indicada.
3.  **Dependências:** Caso não carreguem automaticamente, instale o `com.meta.xr.sdk.all-in-one` via *Package Manager*.
4.  **XR Settings:** Verifique se o **OpenXR** está habilitado em `Project Settings > XR Plugin Management`.

---

## Como Testar (Sem Headset)

Se você não possui um óculos VR, utilize o **Meta XR Simulator** integrado:

1.  No menu superior, vá em **Meta > Simulator** e ative a funcionalidade.
2.  Pressione **Play** no Unity Editor.
3.  **Controles:**
    *   `WASD`: Movimentação.
    *   `Mouse`: Olhar ao redor.
    *   `Tecla E`: Interagir com objetos (ativar Monitor Cardíaco).

---

## Autor

*   **Nome:** Derek Santos
*   **Turma:** 5
*   **Data:** 08 de Maio de 2026
*   **Instituição:** Residência em TIC 29

---
*Este projeto faz parte do portfólio de desenvolvimento de tecnologias imersivas.*

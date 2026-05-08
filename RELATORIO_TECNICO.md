# RELATÓRIO TÉCNICO — PROJETO VR NO METAVERSO
## Web 3.0 | Residência em TIC 29 — Atividade Avaliativa

---

## SEÇÃO 1 — IDENTIFICAÇÃO
- **Nome Completo:** [SEU NOME COMPLETO AQUI]
- **Turma / Residência:** Residência em TIC 29
- **Limitação de Hardware Relatada:** Placa de vídeo sem suporte a Vulkan e RAM insuficiente para execução do Unity Editor localmente.

---

## SEÇÃO 2 — CONCEITO DO PROJETO

### 2.1 Nome do Projeto
**MediVerse: Sala de Emergência Virtual**

### 2.2 Contexto e Objetivo no Metaverso
Criar um ambiente educacional imersivo para ensino de procedimentos médicos básicos, resolvendo a falta de acesso a simulações reais em instituições de saúde com recursos limitados.

### 2.3 Descrição Geral do Ambiente Virtual
Uma sala de emergência retangular de 10x8 metros, com iluminação clínica branca. Contém:
- Monitor cardíaco na parede esquerda
- Cama de hospital central
- Armário de medicamentos na parede direita
- Porta automática de entrada
- Botão de emergência próximo à cama

Iluminação neutra (6500K) para simular ambiente hospitalar realista.

---

## SEÇÃO 3 — CONFIGURAÇÃO TÉCNICA DO PROJETO

### 3.1 Versão do Unity e Porquê
**Unity 6000.3.9f1 LTS** - Versão estável com suporte de longo prazo, recomendada pela Meta para desenvolvimento com Meta XR SDK.

### 3.2 Instalação do Meta XR SDK (Passo a Passo)
1. Abrir Unity Package Manager
2. Adicionar pacote "Meta XR All-in-One SDK"
3. Configurar Project Settings > XR Plug-in Management > OpenXR
4. Habilitar "Meta XR Feature Group"

### 3.3 Configurações de Build para Android/Meta Quest
- Plataforma: Android
- Texture Compression: ASTC
- Minimum API Level: Android 10 (Level 29)
- Target Architecture: ARM64
- Build Type: Development Build (para testes)

### 3.4 Configuração do XR Plugin Management
- Habilitar OpenXR no Android
- Selecionar "Meta XR Interaction" como driver
- Configurar Input Action Assets

### 3.5 Movimentação no PC (Editor)
Utilizar **XR Device Simulator** do XR Interaction Toolkit para emular controles via teclado/mouse durante desenvolvimento.

---

## SEÇÃO 4 — ASSETS E ELEMENTOS DA CENA

### ASSET 1
- **Nome:** MonitorCardiaco
- **Tipo:** Objeto 3D (Cubos + Plano)
- **Origem:** Primitivos Unity
- **Função:** Equipamento médico interativo principal

### ASSET 2
- **Nome:** CamaHospital
- **Tipo:** Objeto 3D
- **Origem:** Primitivos Unity combinados
- **Função:** Representar leito de paciente

### ASSET 3
- **Nome:** HeartbeatSound
- **Tipo:** Áudio
- **Origem:** Asset Store (Gratuito)
- **Função:** Feedback sonoro da interação

### ASSET 4
- **Nome:** ChaoHospital
- **Tipo:** Plano
- **Origem:** Primitivo Unity
- **Função:** Base navegável do ambiente

### ASSET 5
- **Nome:** PortaAutomática
- **Tipo:** Plano
- **Origem:** Primitivo Unity
- **Função:** Elemento ambiental com animação futura

---

## SEÇÃO 5 — HIERARQUIA DE GAME OBJECTS

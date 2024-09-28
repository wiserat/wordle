# Videohra v CLI: Wordle – Business požadavky
* **SSPŠ**
* **Verze 1**
* **Jonáš Tenora**
* **28.9.2024**

## Obsah
1. Historie Dokumentu
2. Úvod
3. Požadavky

---

## Historie Dokumentu
### Verze 1
* **Autor:** Jonáš Tenora
* **Komentář:** První verze dokumentu

---

## Úvod
* **Účel dokumentu** – Účelem dokumentu je popsání všech požadovaných funkcí hry Wordle a nefunkčních požadavků.
* **Cílová skupina:** Znudění uživatelé TTY
* **Kontakt:** tenora.jo.2022@skola.ssps.cz
* **Odkazy na další dokumenty:** wordle-technicke
* **Strany:** 
    1. **Provozovatel** - Jonáš Tenora
    2. **Uživatel** - Hráč

---

## Požadavky

### Funkční požadavky
* Hráč musí uhodnout 5-písmenné slovo ve stanoveném počtu pokusů  
 **Priorita:** Vysoká
* Hra umožňuje hráči zvolit obtížnost – počet pokusů  
 **Priorita:** Střední
* Po každém pokusu hra poskytuje zpětnou vazbu barevným zobrazením správnosti písmen (zelená – správné písmeno na správném místě, žlutá – správné písmeno na špatném místě, bílá – špatné písmeno)  
 **Priorita:** Vysoká
* Po správném uhodnutí slova hra nabídne možnost ukončení  
 **Priorita:** Střední
* Pokud hráč neuhodne slovo v zadaném počtu pokusů, hra zobrazí správné slovo a nabídne možnost ukončení  
 **Priorita:** Vysoká

### Nefunkční požadavky
* **CLI Aplikace** - Hra poběží v prostředí příkazového řádku.
* **Podporovaná zařízení** - Hra bude optimalizována pro .NET prostředí.
* **Vývojové prostředí** - Aplikace bude vyvíjena v JetBrains Rider s využitím .NET Frameworku.
